using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspnetCoreMvcFull.Models;
using AspnetCoreMvcFull.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using AspnetCoreMvcFull.Models.UserEntities;
using AspnetCoreMvcFull.Shared.Enums;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace AspnetCoreMvcFull.Controllers;

public class AuthController : Controller
{
  private readonly ApplicationDbContext _context;
  public AuthController(ApplicationDbContext context)
  {
    _context = context;
  }

  public IActionResult ForgotPasswordBasic() => View();
  public IActionResult LoginBasic()
  {
    return View();
  }
  public IActionResult RegisterBasic() => View();

  [HttpPost]
  public async Task<IActionResult> Login(string email, string password, bool rememberMe)
  {
    var user = await _context.BaseUsers.FirstOrDefaultAsync(u => u.Email == email);
    if(user is not null && ComparePassword(user,password))
    {
      SetUserClaimsInSession(user);
      return await RedirectUserBasedOnRole(user);
    }
    return View(nameof(LoginBasic));
  }

  private void SetUserClaimsInSession(BaseUser user)
  {
    var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.FirstName),
            new Claim(ClaimTypes.Surname, user.LastName),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Role,user.RoleId.ToString()),
            new Claim(ClaimTypes.Actor,user.Role.RoleName),
            new Claim(ClaimTypes.NameIdentifier,user.RoleId.ToString()),
        };
    foreach(var claim in claims)
    {
      HttpContext.Session.SetString(claim.Type, claim.Value);
    }
  }

  private async Task<IActionResult> RedirectUserBasedOnRole(BaseUser user)
  {
    switch(user.Role.Roles)
    {
      case (Roles.User):
        return View(nameof(RedirectUserBasedOnRole));
      case (Roles.Admin):
        return  RedirectToAction("Index", "Dashboards");
      case (Roles.Chef):
        return RedirectToAction("Index", "Dashboards");
      default:
        return View(nameof(LoginBasic));
    }
  }

  private bool ComparePassword(BaseUser user , string inputPassword)
  {
    return user.PasswordHash == inputPassword;
  }
}

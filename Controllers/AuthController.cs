using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspnetCoreMvcFull.Models;
using AspnetCoreMvcFull.Data;
using Microsoft.EntityFrameworkCore;

namespace AspnetCoreMvcFull.Controllers;

public class AuthController : Controller
{
  private readonly ApplicationDbContext _context;

  public AuthController(ApplicationDbContext context)
  {
    _context = context;
  }

  public IActionResult ForgotPasswordBasic() => View();
  public async Task<IActionResult> LoginBasic()
  {

    // Your login logic here
    var user = await _context.BaseUsers.ToListAsync();
    return View();
  }
  public IActionResult RegisterBasic() => View();

  [HttpPost]
  public async Task<IActionResult> Login(string email, string password, bool rememberMe)
  {
    return View();
  }

}

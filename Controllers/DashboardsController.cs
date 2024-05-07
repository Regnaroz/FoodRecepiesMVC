using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspnetCoreMvcFull.Models;
using System.Security.Claims;

namespace AspnetCoreMvcFull.Controllers;

public class DashboardsController : Controller
{
  private readonly IHttpContextAccessor _httpContextAccessor;

  public DashboardsController(IHttpContextAccessor httpContextAccessor)
  {
    _httpContextAccessor = httpContextAccessor;
  }

  public IActionResult Index()
  {
    string userId = HttpContext.Session.GetString(ClaimTypes.NameIdentifier);
    ViewBag.FullName = HttpContext.Session.GetString(ClaimTypes.Name) + " " + HttpContext.Session.GetString(ClaimTypes.Surname);
    ViewBag.RoleName = HttpContext.Session.GetString(ClaimTypes.Actor);
    return View();
  }
}

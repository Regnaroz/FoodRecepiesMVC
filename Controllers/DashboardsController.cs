using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspnetCoreMvcFull.Models;
using System.Security.Claims;
using RecepieBlog.ViewsDataModel;
using AspnetCoreMvcFull.Data;
using Microsoft.EntityFrameworkCore;

namespace AspnetCoreMvcFull.Controllers;

public class DashboardsController : Controller
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly ApplicationDbContext _context;

  public DashboardsController(IHttpContextAccessor httpContextAccessor, ApplicationDbContext context)
  {
    _httpContextAccessor = httpContextAccessor;
    _context = context;
  }

  public async Task<IActionResult> Index()
  {
    var model = new DashboardModel();
    string userId = HttpContext.Session.GetString(ClaimTypes.NameIdentifier);
    ViewBag.FullName = HttpContext.Session.GetString(ClaimTypes.Name) + " " + HttpContext.Session.GetString(ClaimTypes.Surname);
    ViewBag.RoleName = HttpContext.Session.GetString(ClaimTypes.Actor);
    model.UsersCount = await _context.Users.CountAsync();
    model.ChefsCount = await _context.Chefs.CountAsync();
    model.RecepiesCount = await _context.Recepies.CountAsync();
    model.CategoriesCount = await _context.Categorys.CountAsync();
    return View(model);
  }
}

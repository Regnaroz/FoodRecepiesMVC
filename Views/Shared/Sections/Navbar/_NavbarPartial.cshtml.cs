using Microsoft.AspNetCore.Mvc;

namespace RecepieBlog.Views.Shared.Sections.Navbar
{
  public class _NavbarPartial : ViewComponent
  {
    public IViewComponentResult Invoke(string fullName, string roleName)
    {
      var model = new NavbarViewModel
      {
        FullName = fullName,
        RoleName = roleName
      };

      return View(model);
    }
  }

  public class NavbarViewModel
  {
    public string FullName { get; set; }
    public string RoleName { get; set; }
  }
}

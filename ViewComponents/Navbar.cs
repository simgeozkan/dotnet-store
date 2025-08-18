namespace dotnet_store.ViewComponents;

using Microsoft.AspNetCore.Mvc;
using dotnet_store.Models;


public class Navbar : ViewComponent
{


    //dependies injection
    private readonly DataContext _context;

    public Navbar(DataContext context)
    {
        _context = context;
    }





    public IViewComponentResult Invoke()
    {
        var categories = _context.Categories
            .Where(c => c.IsActive)
            .ToList();

        return View(categories);
    }
}

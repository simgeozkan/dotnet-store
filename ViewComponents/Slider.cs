namespace dotnet_store.ViewComponents;

using Microsoft.AspNetCore.Mvc;
using dotnet_store.Models;

public class Slider : ViewComponent
{
    private readonly DataContext _context;

    public Slider(DataContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var sliders = _context.Sliders
            .Where(s => s.IsActive)
            .OrderBy(s => s.Index)
            .ToList();

        return View(sliders);
    }
}

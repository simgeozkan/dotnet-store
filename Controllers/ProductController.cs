using Microsoft.AspNetCore.Mvc;
using dotnet_store.Models;
namespace dotnet_store.Controllers;


public class ProductController:Controller
{


//dependincy injection
    private readonly DataContext _context;

    public ProductController(DataContext context)
    {
        _context = context;
    }


public ActionResult Index()
{

  var products=_context.Products.ToList();


    return View(products);
}


public ActionResult List()
{

  var products=_context.Products.Where(i=>i.HomePage).ToList();


    return View(products);
}


public ActionResult Details(int id)
{
    var product = _context.Products.FirstOrDefault(p => p.Id == id);


    if (product == null)
    {
        return NotFound();
    }


    return View(product);
}


}

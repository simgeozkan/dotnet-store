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

}

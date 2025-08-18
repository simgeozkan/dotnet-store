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


public ActionResult List(string url)
{

  IQueryable<Product> query = _context.Products;

    if (!string.IsNullOrEmpty(url))
    {
        query = query.Where(p => p.Category.Url == url);
    }

    var products = query.ToList();
    
    return View(products);

    
}


public ActionResult Details(int id)
{
    var product = _context.Products.FirstOrDefault(p => p.Id == id);


    if (product == null)
    {
        return RedirectToAction("List");
    }


    var similarProducts = _context.Products
        .Where(p => p.IsActive && p.CategoryId == product.CategoryId && p.Id != product.Id) // burda detyalari verilen urunu similar icinden cikariyoruz
        
        .Take(4)
        .ToList();
    ViewData["SimilarProducts"] = similarProducts;  // view datalar controller icinde doldurulan dictionarylerdir ve view icinde otomatik goruntulenir



    return View(product);
}


}

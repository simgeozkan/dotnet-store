using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet_store.Models;

namespace dotnet_store.Controllers;

public class HomeController : Controller
{

    //dependincy injection
    private readonly DataContext _context;

    public HomeController(DataContext context) // bu bor constuctor,sinif adi ile ayni'donus degeri yok'class ornegi calistiginda calisir.
    {
        _context = context; // _contect artik databasein bir referansini tutar yani butun tablolara erisebilir
    }


    public ActionResult List()
    {
        var products = _context.Products.ToList(); // burdada context ile products tablodun aerisip listeleme fonksoiyonu yardimiyla bunlari bir degiskene aliyoruz
        return View(products);
    }

    public ActionResult Index()
    {


       var products = _context.Products.Where(product=>product.IsActive && product.HomePage).ToList(); // aktif ise burda sorgulama yapiliyor

        var categories = _context.Categories.ToList();
        ViewData["Categories"] = categories;


        return View(products);
    }



}

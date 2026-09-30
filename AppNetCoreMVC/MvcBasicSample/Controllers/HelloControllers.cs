using Microsoft.AspNetCore.Mvc;  //ControllerとIActionResultを使用
using MvcBasicSample.Models;     //Productを使用

namespace MvcBasicSample.Controllers;

//URLのHelloに対応する要求を受け取るController
public class HelloController : Controller {

    // ../Hello/Indexで呼び出されるAction
    public IActionResult Index() {
        //商品1件のオブジェクトを作る
        var products = new List<Product> {
            new Product{
                Name = "ハンバーガー", //1件目の商品目
                Price = 500            //1件目の価格
            },
            new Product {
                Name = "紅茶",       　//2件目の商品目
                Price = 450            //2件目の価格
            }
        };

        return View(products);
    }
}

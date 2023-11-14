using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using WebApi_EF_Client.Models;


namespace WebApi_EF_Client.Controllers
{
    public class ProductMVCController : Controller
    {
        // GET: ProductMVC
               
        public ActionResult Index()
        {
            return View();
        }

        //action method to consume the WebApi product Get()
        public ActionResult Display()
        {
            IEnumerable<MVCProductModel> productlist = null;
            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44385/api/");
                var responsetask = webclient.GetAsync("product");
                responsetask.Wait();
                var result = responsetask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var resultdata = result.Content.ReadAsStringAsync().Result;
                    productlist = JsonConvert.DeserializeObject<List<MVCProductModel>>(resultdata);
                }
                else
                {
                    productlist = Enumerable.Empty<MVCProductModel>();
                    ModelState.AddModelError(string.Empty, "Some Error Occured..Try Later");
                }
                return View(productlist);
            }
        }

        //create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MVCProductModel mvcprod)
        {
            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44385/api/");
                var posttask = webclient.PostAsJsonAsync<MVCProductModel>("product", mvcprod);
                posttask.Wait();
                var dataresult = posttask.Result;
                if (dataresult.IsSuccessStatusCode)
                {
                    return RedirectToAction("Display");
                }
                ModelState.AddModelError(string.Empty, "Creation failed.. Try Later");
                return View(mvcprod);
            }
        }

        //Edit
       [HttpGet]
       public ActionResult Edit(int id)
        {
            if(id==0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MVCProductModel product = null;
            using(var webclient= new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44385/api/");
                var responsetask = webclient.GetAsync("product/" + id).Result;
                if(responsetask.IsSuccessStatusCode)
                {
                    var resultdata = responsetask.Content.ReadAsStringAsync().Result;
                    product = JsonConvert.DeserializeObject<MVCProductModel>(resultdata);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server Error, try later");
                }
            }
            if(product==null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult>Edit([Bind(Include ="ProductID,ProductName,Price,QuantityAvailable")] MVCProductModel p)
        {
            if(ModelState.IsValid)
            {
                using(var client= new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44385/api/");
                    var response = await client.PutAsJsonAsync("product/edit", p);
                    if(response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Display");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Please try Later.");
                    }
                }
                return RedirectToAction("Index");
            }
            return View(p);
        }
    }
}
using DAL.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ETicaret.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public async Task<ActionResult> Shopping()
        {
            using (HttpClient client=new HttpClient())
            {
                var response=await client.GetAsync("http://localhost:52339/api/Service");
                var model = JsonConvert.DeserializeObject<List<Product>>(response.Content.ReadAsStringAsync().Result);
                return View(model);
            }
           
        }

        public string Message()
        {
            return "MVC 1. ders";
        }
    }
}
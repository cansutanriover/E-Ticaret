using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Service.Controllers
{
    public class SeviceController : ApiController
    {
        // GET: api/Sevice
        public List<Product> Get()
        {
            using (ShopContext context=new ShopContext())
            {
                return context.Products.ToList();
            }
            
        }

        // GET: api/Sevice/5
        public Product Get(int id)
        {
            using (ShopContext context=new ShopContext())
            {
                return context.Products.Single(x=> x.Id==id);
            }
        }

        // POST: api/Sevice
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Sevice/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Sevice/5
        public void Delete(int id)
        {
        }
    }
}

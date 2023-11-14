using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_EF.Models;
using System.Web.Mvc;

namespace WebApi_EF.Controllers
{
    public class ProductController : ApiController
    {
        InfiniteDBContext db = new InfiniteDBContext();

        //Get
        public IEnumerable<Product>Get()
        {
            return db.Products.ToList();
        }

        //Get By Id
        public Product Get(int Id)
        {
            return db.Products.FirstOrDefault(x => x.ProductId == Id);
        }

        //Post
        public IHttpActionResult PostNewProduct([FromBody] Product p)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Validations Failed");
            }
            db.Products.Add(new Product()
            {
                ProductId = p.ProductId,
                ProductName=p.ProductName,
                Price=p.Price,
                QuantityAvailable=p.QuantityAvailable               
                
            });
            db.SaveChanges();
            return Ok("Success");
        }

        //put or edit
        public IHttpActionResult Put([FromBody]Product p)
        {
            if(ModelState.IsValid)
            {
                db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return Ok("Record Updated");
        }

    }
}

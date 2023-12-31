﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_1.Models;

namespace WebApi_1.Controllers
{
    [RoutePrefix("api/User")]
    public class PersonController : ApiController
    {
        static List<Person> personlist = new List<Person>()
        {
            new Person{Id=1, PersonName="Sonu",Designation="Tester"},
            new Person{Id=2, PersonName="Nived",Designation="Developer"},
            new Person{Id=3, PersonName="Nayana",Designation="Quality"},
        };

        [HttpGet]
        [Route("All")]
        public IEnumerable<Person>Get()
        {
            return personlist;
        }

        //getting person details using httpresponsemessage
        [HttpGet]
        [Route("byhttp")]
        public HttpResponseMessage GetAllPersons()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, personlist);
         //   response.Content = new StringContent("Hello All");
           
            return response;
        }

        [HttpGet]
        [Route("ByID")]
        public IHttpActionResult GetByID(int pid)
        {
            var person = personlist.Find(p => p.Id == pid);
            if(person==null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        [HttpGet]
        [Route("GetName")]
        public IHttpActionResult GetPersonByName(int pid)
        {
            string uname = personlist.Where(p => p.Id == pid).SingleOrDefault()?.PersonName;
            if(uname==null)
            {
                return NotFound();
            }
            return Ok(uname);
        }

        //Post 1
        [HttpPost]
        [Route("justpost")]
        public Person Post([FromBody]Person p)
        {
            personlist.Add(p);
            return p;
        }

        //post 2
        [HttpPost]
        [Route("AllPost")]
        public List<Person>PostAll([FromBody] Person person)
        {
            personlist.Add(person);
            return personlist;
        }

        [HttpPost]
        [Route("personpost")]
        public void PersonPost([FromUri] int Id, string name,string desig)
        {
            Person person = new Person();
            person.Id = Id;
            person.PersonName = name;
            person.Designation = desig;
            personlist.Add(person);
        }

        //Put
        [HttpPut]
        [Route("updperson")]
        public void Put(int id,[FromUri] Person p)
        {
            personlist[id - 1] = p;

        }

        //delete
        [Route("del")]
        public void Delete(int id)
        {
            personlist.RemoveAt(id - 1);
        }
    }
}

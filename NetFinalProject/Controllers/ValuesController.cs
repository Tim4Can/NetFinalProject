﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;
using NetFinalProject.Models;
using NetFinalProject.Services;

namespace NetFinalProject.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            using (var db = new DBModel())
            {
                var user = (from t in db.users
                            where t.nickname == "张三"
                            select t).First();

               // var r = LoginService.Login("Sam", "1234");


                return new string[] { user.id.ToString(), "hello" };
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

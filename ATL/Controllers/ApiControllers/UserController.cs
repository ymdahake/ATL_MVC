using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ATL.Models;

namespace ATL.Controllers.ApiControllers
{
    public class UserController : ApiController
    {
        ApplicationDbContext _db;
        public UserController()
        {
            _db = new ApplicationDbContext();
        }

        public IHttpActionResult AddUserSubscription()
        {
            return Ok();
        }


    }
}

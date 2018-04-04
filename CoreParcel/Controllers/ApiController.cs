using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreParcel.Controllers
{
    [Produces("application/json")]
    [Route("api/api")]
    public class ApiController : Controller
    {
        [HttpGet("value")]
        public string Value()
        {
            return "{ key : value }";
        }
    }
}
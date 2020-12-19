using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace WebAPI.Controllers
{
    [ApiController]
    public class SubstractController : ApiController
    {
       
        public double Get([FromQuery] double leftNumber, [FromQuery] double rightNumber)
        {
            return leftNumber - rightNumber;
        }

        public double Post([FromForm] double leftNumber, [FromForm] double rightNumber)
        {
            return leftNumber - rightNumber;
        }

    }
}

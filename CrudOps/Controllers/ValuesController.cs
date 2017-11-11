using CrudOps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrudOps.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : BasedSimpleCrudOps<Stuff>
    {
    }
}

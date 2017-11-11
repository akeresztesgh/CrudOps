using CrudOps.Models;
using CrudOps.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudOps.Controllers
{
    [RoutePrefix("api/stuff")]
    public class StuffController : BaseAutomapperCrudOps<Stuff, StuffViewModel>
    {
    }
}
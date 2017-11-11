using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudOps.Models
{
    public interface IBaseModel
    {
        int Id { get; set; }
    }
}
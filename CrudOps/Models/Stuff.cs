using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudOps.Models
{
    public class Stuff : IBaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Prop1 { get; set; }
        public int Prop2 { get; set; }
    }
}
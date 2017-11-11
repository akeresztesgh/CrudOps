using CrudOps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudOps.ViewModels
{
    public class StuffViewModel : IBaseModel
    {
        public int Id { get; set; }
        public string Prop1 { get; set; }
        public int Prop2 { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudOps.ViewModels
{
    public class PaginationRequest
    {
        public string SearchString { get; set; }
        public int StartRow { get; set; }
        public int EndRow { get; set; }
        public string SortColumn { get; set; }
        public bool SortDescending { get; set; }
    }
}
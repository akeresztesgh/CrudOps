using AutoMapper;
using CrudOps.Models;
using CrudOps.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudOps.App_Start
{
    public class AutomapperConfig
    {
        public static void Config()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<StuffViewModel, Stuff>();
                cfg.CreateMap<Stuff, StuffViewModel>();
            });
        }
    }
}
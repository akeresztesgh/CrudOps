using AutoMapper;
using CrudOps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace CrudOps.Controllers
{
    public class BaseAutomapperCrudOps<TModel, TViewModel> : ApiController
        where TModel : class, IBaseModel
        where TViewModel : class, IBaseModel
    {
        private readonly AppDbContext _db = new AppDbContext();

        [Route(""), HttpGet]
        public IHttpActionResult Get()
        {
            var set = _db.Set<TModel>();

            return Ok(set.ToList().Select(i=>Mapper.Map<TViewModel>(i)));
        }

        [Route("{id}"), HttpGet]
        public IHttpActionResult Get(int id)
        {
            var set = _db.Set<TModel>();
            var item = set.Single(i => i.Id == id);
            return Ok(Mapper.Map<TViewModel>(item));
        }

        [Route(""), HttpPost]
        public async Task<IHttpActionResult> Post(TViewModel vm)
        {

            var set = _db.Set<TModel>();
            var model = Mapper.Map<TModel>(vm);
            set.Add(model);
            await _db.SaveChangesAsync();
            AfterPost(_db, model);
            return Ok();
        }

        protected virtual void AfterPost(AppDbContext db, TModel model)
        {
        }

        [Route(""), HttpPut]
        public async Task<IHttpActionResult> Put(TViewModel vm)
        {
            var set = _db.Set<TModel>();
            var model = set.Single(i => i.Id == vm.Id);
            Mapper.Map(vm, model);
            await _db.SaveChangesAsync();
            AfterPut(_db, model);
            return Ok();
        }

        protected virtual void AfterPut(AppDbContext db, TModel model)
        {

        }


        [Route(""), HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {
            var set = _db.Set<TModel>();
            var item = set.Single(i => i.Id == id);
            set.Remove(item);
            await _db.SaveChangesAsync();
            AfterDelete(_db, item);
            return Ok();
        }

        protected virtual void AfterDelete(AppDbContext db, TModel model)
        {

        }

    }
}
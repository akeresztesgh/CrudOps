using CrudOps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace CrudOps.Controllers
{
    public class BasedSimpleCrudOps<T> : ApiController
        where T: class, IBaseModel
    {
        private readonly AppDbContext _db = new AppDbContext();

        [Route(""), HttpGet]
        public IHttpActionResult Get()
        {
            var set = _db.Set<T>();
            return Ok(set.ToList());
        }

        [Route("{id}"), HttpGet]
        public IHttpActionResult Get(int id)
        {
            var set = _db.Set<T>();
            var item = set.Single(i => i.Id == id);
            return Ok(item);
        }

        [Route(""), HttpPost]
        public async Task<IHttpActionResult> Post(T model)
        {
            var set = _db.Set<T>();
            set.Add(model);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [Route(""), HttpPut]
        public async Task<IHttpActionResult> Put(T model)
        {
            var set = _db.Set<T>();
            set.Attach(model);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [Route(""), HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {
            var set = _db.Set<T>();
            var item = set.Single(i => i.Id == id);
            set.Remove(item);
            await _db.SaveChangesAsync();
            return Ok();
        }


    }
}
using EmployeeRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using System.Web.Http.Cors;

namespace EmployeeRegister.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class RegisterController : ApiController
    {
        employeedataEntities db = new employeedataEntities();
        // GET: api/Register
        public IEnumerable<Register> Get()
        {
            return db.Registers.ToList();
        }

        // GET: api/Register/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Register
        public void Post([FromBody] Register register)
        {
            TblLogin login = new TblLogin();

            login.UserName = register.UserName;
            login.Password = register.Password;
            db.TblLogins.Add(login);
          //  db.SaveChanges();
          //  register.LoginId = login.Id;
            db.Registers.Add(register);
            db.SaveChanges();

        }

        // PUT: api/Register/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Register/5
        public void Delete(int id)
        {
        }
    }
}

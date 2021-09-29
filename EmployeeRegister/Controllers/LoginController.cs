using EmployeeRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EmployeeRegister.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LoginController : ApiController
    {
        // GET: api/Login
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Login/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Login
        
            public TblLogin Post(TblLogin lg)
            {

            employeedataEntities db = new employeedataEntities();
            TblLogin _ld = new TblLogin();

            var result = (from lg1 in db.TblLogins where lg1.UserName == lg.UserName && lg1.Password == lg.Password select lg1.UserName).FirstOrDefault();

            if (result != null)
            {
                _ld.UserName = result;
                _ld.Message = "Login Successful";


                return _ld;
            }

            else
            {
                _ld.UserName = result;
                _ld.Message = "Login Failed";
                return _ld;
            }

            //var userDetails = db.TblLogins.Where(x => x.UserName == lg.UserName && x.Password == lg.Password).FirstOrDefault();
            //if (userDetails == null)
            //{
            //    lg.Message = "Login Failed";
            //    return lg;
            //}

            //else if (userDetails.Registers.FirstOrDefault().Role == "Admin")
            //{
            //    lg.Message = "Admin";
            //    return lg;
            //}
            //else
            //{
            //    lg.Message = "other role";
            //    return lg;
            //}

            // return userDetails;
        }
        
    

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}

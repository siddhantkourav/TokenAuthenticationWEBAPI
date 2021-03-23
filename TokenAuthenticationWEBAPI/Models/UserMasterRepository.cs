using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenAuthenticationWEBAPI.Models
{
    public class UserMasterRepository : IDisposable
    {
        SECURITY_DBEntities context = new SECURITY_DBEntities();
        public UserMaster ValidateUser(string username, string password)
        {
            return context.UserMasters.FirstOrDefault(x => x.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
            && x.UserPassword == password);
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
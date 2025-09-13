using A3.DataAccess;
using Onoqua.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onoqua.Services
{
    public static class UserService
    {
        public static List<Entity> GetUsers(decimal clientID)
        {
            var da = new DataAccess<Entity>();
            return da.Where(m => m.ClientID == clientID).ToList();
        }
    }
}
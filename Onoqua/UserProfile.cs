using Onoqua.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onoqua
{
    public static class UserProfile
    {
        public static Client Client
        {
            get
            {
                return GetValues<Client>("Client");
            }
            set
            {
                SetValue<Client>("Client", value);

            }
        }

        public static List<Process> Processes
        {
            get
            {
                return GetValues<List<Process>>("Processes");
            }
            set
            {
                SetValue<List<Process>>("Processes", value);
            }
        }

        public static T GetValues<T>(string str) where T : new()
        {
            if (HttpContext.Current.Session[str] == null)
                HttpContext.Current.Session.Add(str, new T());
            return (T)HttpContext.Current.Session[str];
        }

        public static void SetValue<T>(string str, object value)
        {
            if (HttpContext.Current.Session[str] == null)
                HttpContext.Current.Session.Add(str, (T)value);
            HttpContext.Current.Session[str] = (T)value;
        }


    }
}
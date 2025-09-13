using A3.Model;
using A3.Models;
using System.Collections.Generic;
using System.Web;

namespace A3
{
    public static class UserProfile
    {

        public static bool LoggedIn { get; set; }

        public static ViewModel Model
        {
            get
            {
                return GetValues<ViewModel>("Model");
            }
            set
            {
                SetValue<ViewModel>("Model", value);

            }
        }

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

        public static Entity LoggedInUser
        {
            get
            {
                return GetValues<Entity>("User");
            }
            set
            {
                SetValue<Entity>("User", value);
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

        public static ProcessModel ProcessModel
        {
            get
            {
                return GetValues<Models.ProcessModel>("ProcessModel");
            }
            set
            {
                SetValue<Models.ProcessModel>("ProcessModel", value);
            }
        }

        public static List<Field> Fields
        {
            get
            {
                return GetValues<List<Field>>("Fields");
            }
            set
            {
                SetValue<List<Field>>("Fields", value);
            }
        }

        public static GroupModel Groups
        {
            get
            {
                return GetValues<GroupModel>("Groups");
            }
            set
            {
                SetValue<GroupModel>("Groups", value);
            }
        }

        public static List<string> FieldTypes
        {
            get
            {
                return GetValues<List<string>>("FieldTypes");
            }
            set
            {
                SetValue<List<string>>("FieldTypes", value);
            }
        }

        public static void Clear()
        {
            LoggedInUser = null;
            Client = null;
            Processes = null;
            ProcessModel = null;
            Fields = null;
            FieldTypes = null;
            LoggedIn = false;

        }
    }
}
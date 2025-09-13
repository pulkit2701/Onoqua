using System.Web.Mvc;

namespace A3.Areas.EV
{
    public class EVAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "EV";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "EV_default",
                "EV/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
using System.Web.Mvc;

namespace Totalligent.UI.Areas.GroupLifeInsurance
{
    public class GroupLifeInsuranceAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "GroupLifeInsurance";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "GroupLifeInsurance_default",
                "GroupLifeInsurance/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
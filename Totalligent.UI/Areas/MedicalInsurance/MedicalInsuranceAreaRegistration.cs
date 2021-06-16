using System.Web.Mvc;

namespace Totalligent.UI.Areas.MedicalInsurance
{
    public class MedicalInsuranceAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "MedicalInsurance";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "MedicalInsurance_default",
                "MedicalInsurance/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
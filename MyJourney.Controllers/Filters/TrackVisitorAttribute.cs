using System.Web.Mvc;
using System.Web;
using MyJourney.Services.VisitorLog;

namespace MyJourney.Controllers.Filters
{
    public class TrackVisitorAttribute : ActionFilterAttribute
    {
        public IVLog LogService { get; set; }

        public TrackVisitorAttribute()
        {
            LogService = DependencyResolver.Current.GetService<IVLog>();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current != null)
            {
                LogService.Save(HttpContext.Current.Request.Url.AbsoluteUri);
            }
            
            base.OnActionExecuting(filterContext);
        }
    }
}

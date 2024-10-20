using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilters
{
    public class Logging : Attribute, IActionFilter
    {
        void IActionFilter.OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("this is After");
        }

        void IActionFilter.OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("this is before");
            
        }
    }
}

using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace ActionFilters
{
    public class Logging : Attribute, IActionFilter
    {
        private Stopwatch stopWatch;

        void IActionFilter.OnActionExecuting(ActionExecutingContext context)
        {
            stopWatch = Stopwatch.StartNew();
            Console.WriteLine("this is before and stop watch started");

        }
        void IActionFilter.OnActionExecuted(ActionExecutedContext context)
        {
            stopWatch.Stop();
            var elapsedmilisec = stopWatch.ElapsedMilliseconds;
            
            Console.WriteLine($"this method takes {elapsedmilisec} to execute");
        }

        
    }
}

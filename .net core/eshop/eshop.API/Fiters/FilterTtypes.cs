using Microsoft.AspNetCore.Mvc.Filters;

namespace eshop.API.Fiters
{
    public class RangeExceptionFilterAttribute : ExceptionFilterAttribute
    {
        //action'da hata olursa
    }


    public class SampleActionAttribute : ActionFilterAttribute
    {
        //action içindeki eylemlere  (başla - bitir gibi) göre:
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //kronometreyi başlat
            base.OnActionExecuting(context);
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            //kronometreyi durdur
            //Sonucu çıktı olarak yaz...
            base.OnActionExecuted(context);
        }
    }

    public class SampleResultAttribute : ResultFilterAttribute
    {
        //action'un sonucuna göre
    }

}

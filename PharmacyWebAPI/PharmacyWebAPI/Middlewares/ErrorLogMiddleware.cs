namespace PharmacyWebAPI.Middlewares
{
    public class ErrorLogMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorLogMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        public async Task Invoke(HttpContext context)
        {

            try
            {


                await _next(context);


            }
            catch (Exception ex)
            { 
            
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync("Some error");
            
            
            }
        
        
        
        
        }

    }
}

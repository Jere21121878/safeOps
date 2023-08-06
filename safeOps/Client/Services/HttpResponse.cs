namespace safeOps.Client.Services
{
    public class HttpResponse<T>
    {

        public T Response { get; }
        public bool Error { get; }
        public HttpResponseMessage HttpResponseMessage { get; }


        public HttpResponse(T response,

                            bool error,     

                            HttpResponseMessage httpResponseMessage  
                                      )
        {
            Response = response;
            Error = error;
            HttpResponseMessage = httpResponseMessage;
        }

      
    }
}

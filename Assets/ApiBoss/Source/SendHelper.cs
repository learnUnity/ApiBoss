
namespace ApiBoss
{
    public static class SendHelper
    {
        public static Request Send(this Request request)
        {
            RequestHandler.Instance.OnHandleRequest(request);
            return request;
        }
    }
}
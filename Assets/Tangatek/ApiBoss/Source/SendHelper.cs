
namespace Tangatek.ApiBoss
{
    public static class SendHelper
    {
        public static Request Send(this Request request)
        {
            request.unityWebRequest.chunkedTransfer = false;
            RequestHandler.Instance.OnHandleRequest(request);
            return request;
        }
    }
}
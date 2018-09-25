
namespace Tangatek.ApiBoss
{
    public static class ErrorResponseHelper
    {
        /// <summary>
        /// Delegate that is invoked on error
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="message"></param>
        public delegate void OnResponseDelegate(int statusCode, string message);
        
        /// <summary>
        /// Attaches an action that is invoked on error
        /// </summary>
        /// <param name="request"></param>
        /// <param name="onResponse"></param>
        /// <returns></returns>
        public static Request OnError(this Request request, OnResponseDelegate onResponse)
        {
            //    Tie into OnError
            request.onError += req =>
            {
                onResponse((int)req.unityWebRequest.responseCode, req.unityWebRequest.error);
            };
            return request;
        }
    }
}
namespace Tangatek.ApiBoss
{
    public static class UrlHelper
    {
        public static Request SetUrl(this Request request, string url)
        {
            request.unityWebRequest.url = url;
            return request;
        }
    }
}
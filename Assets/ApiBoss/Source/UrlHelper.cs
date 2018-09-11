namespace ApiBoss
{
    public static class UrlHelper
    {
        public static Request AddUrl(this Request request, string url)
        {
            request.unityWebRequest.url = url;
            return request;
        }
    }
}
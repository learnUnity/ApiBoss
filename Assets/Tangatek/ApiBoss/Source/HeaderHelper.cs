namespace Tangatek.ApiBoss
{
    public static class HeaderHelper
    {
        public static Request SetHeader(this Request request, string key, string value)
        {
            request.unityWebRequest.SetRequestHeader(key, value);
            return request;
        }
    }
}
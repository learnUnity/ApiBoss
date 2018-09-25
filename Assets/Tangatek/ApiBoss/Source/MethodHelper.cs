namespace Tangatek.ApiBoss
{
    public static class MethodHelper
    {
        public static Request SetMethod(this Request request, string method)
        {
            request.unityWebRequest.method = method;
            return request;
        }
    }
}
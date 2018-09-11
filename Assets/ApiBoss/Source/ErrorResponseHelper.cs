using System;
using UnityEngine.Networking;
using UnityEngine;
namespace ApiBoss
{
    public static class ErrorResponseHelper
    {
        public static Request AddJsonResponse<T>(this Request request, Action<string> onResponse)
        {
            //    Tie into OnError
            request.onError += req =>
            {
                onResponse(req.unityWebRequest.error);
            };
            return request;
        }
    }
}
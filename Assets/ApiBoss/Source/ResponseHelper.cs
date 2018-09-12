using System;
using UnityEngine;
using UnityEngine.Networking;
namespace ApiBoss
{
    public static class ResponseHelper
    {
        public delegate void OnResponseDelegate(int statusCode, string message);
        
        public static Request OnResponse(this Request request, OnResponseDelegate onResponse)
        {
            request.unityWebRequest.downloadHandler = new DownloadHandlerBuffer();
            //    Tie into onComplete
            request.onComplete += req =>
            {
                onResponse((int)req.unityWebRequest.responseCode, req.unityWebRequest.downloadHandler.text);
            };
            return request;
        }
    }
}
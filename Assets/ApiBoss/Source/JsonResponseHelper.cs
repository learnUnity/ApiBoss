using System;
using UnityEngine;
using UnityEngine.Networking;
namespace ApiBoss
{
    public static class JsonResponseHelper
    {
        public static Request AddJsonResponse<T>(this Request request, Action<T> onResponse)
        {
            request.unityWebRequest.downloadHandler = new DownloadHandlerBuffer();
            //    Tie into onComplete
            request.onComplete += req =>
            {
                var obj = JsonUtility.FromJson<T>(req.unityWebRequest.downloadHandler.text);
                onResponse(obj);
            };
            return request;
        }
    }
}
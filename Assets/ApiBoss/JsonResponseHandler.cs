using System;
using UnityEngine;

namespace ApiBoss
{
    public class JsonResponseHandler<T> : ResponseHandler
    {
        private Action<T> handler = delegate(T obj) { };
        
        public override void OnHandleResponse(Request request)
        {
            if (handler != null) handler(JsonUtility.FromJson<T>(downloadHandler.text));
        }

        public static JsonResponseHandler<T> Create(Action<T> handler)
        {
            return new JsonResponseHandler<T>()
            {
                handler = handler
            };
        }
    }
}
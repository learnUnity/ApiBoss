using System;
using UnityEngine.Networking;
using System.Collections;

namespace ApiBoss
{
    public class Request
    {
        public UnityWebRequest unityWebRequest = new UnityWebRequest();
        public event Action<Request> onError = delegate{ };
        public event Action<Request> onComplete = delegate{ };
        
        public IEnumerator Process()
        {
            yield return unityWebRequest.SendWebRequest();
            if (unityWebRequest.isNetworkError || unityWebRequest.isHttpError) onError(this);
            else onComplete(this);
        }

        public static Request Create()
        {
            return new Request();
        }
    }
}
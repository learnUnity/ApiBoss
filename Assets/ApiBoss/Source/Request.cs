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

        /// <summary>
        /// Basic request, don't forget to set method and url
        /// </summary>
        /// <returns></returns>
        public static Request Create()
        {
            return new Request();
        }
        
        /// <summary>
        /// Basic request with URL
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static Request Create(string url)
        {
            return new Request()
            {
                unityWebRequest = new UnityWebRequest(url)
            };
        }

        /// <summary>
        /// Basic POST request
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static Request Post(string url)
        {
            return new Request()
            {
                unityWebRequest = new UnityWebRequest(url, "POST")
            };
        }
        
        /// <summary>
        /// Basic PUT request
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static Request Put(string url)
        {
            return new Request()
            {
                unityWebRequest = new UnityWebRequest(url, "PUT")
            };
        }
        
        /// <summary>
        /// Basic GET request
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static Request Get(string url)
        {
            return new Request()
            {
                unityWebRequest = new UnityWebRequest(url, "Get")
            };
        }
        
        /// <summary>
        /// Basic DELETE request
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static Request Delete(string url)
        {
            return new Request()
            {
                unityWebRequest = new UnityWebRequest(url, "Delete")
            };
        }
    }
}
using UnityEngine.Networking;
using UnityEngine;
using System.Text;

namespace Tangatek.ApiBoss
{
    public static class JsonPayloadHelper
    {
        public static Request SetJsonPayload(this Request request, System.Object obj)
        {
            var json = JsonUtility.ToJson(obj);
            var data = Encoding.UTF8.GetBytes(json);
            request.unityWebRequest.uploadHandler = new UploadHandlerRaw(data);
            return request;
        }
    }
}
using UnityEngine;

namespace Tangatek.ApiBoss
{
    public class RequestHandler : MonoBehaviour
    {
        private static RequestHandler _Instance;
        public static RequestHandler Instance
        {
            get
            {
                if (_Instance == null) _Instance = FindObjectOfType<RequestHandler>();
                if (_Instance == null) _Instance = new GameObject("API Boss").AddComponent<RequestHandler>();
                return _Instance;
            }
        }

        public void OnHandleRequest(Request request)
        {
            StartCoroutine(request.Process());
        }
    }
}
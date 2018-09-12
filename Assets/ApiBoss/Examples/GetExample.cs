using UnityEngine;

namespace ApiBoss
{
    public class GetExample : MonoBehaviour 
    {
        public void Start()
        {
            Request
                .Get("https://jsonplaceholder.typicode.com/posts/1")
                .OnJsonResponse<JsonResponse>(OnResponse)
                .OnError(Helpers.LogError)
                .OnResponse(Helpers.LogResponse)
                .Send();
        }

        private void OnResponse(JsonResponse response)
        {
            Debug.Log("Title:" + response.title);
        }
    }
}


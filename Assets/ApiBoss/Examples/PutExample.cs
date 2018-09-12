using UnityEngine;

namespace ApiBoss
{
    public class PutExample : MonoBehaviour 
    {
        public void Start()
        {
            var payload = new JsonPayload()
            {
                title = "foo",
                body = "bar",
                userId = 1,
                id = 2
            };
            
            Request
                .Put("https://jsonplaceholder.typicode.com/posts/1")
                .SetJsonPayload(payload)
                .OnJsonResponse<JsonResponse>(OnResponse)
                .OnError(Helpers.LogError)
                .SetHeader("Content-type","application/json; charset=UTF-8")
                .Send();
        }

        private void OnResponse(JsonResponse response)
        {
            Debug.Log("Response Received:" + response.title);
        }
    }
}


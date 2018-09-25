using UnityEngine;

namespace Tangatek.ApiBoss
{
    public class PostExample : MonoBehaviour 
    {
        public void Start()
        {
            var payload = new JsonPayload()
            {
                title = "foo",
                body = "bar",
                userId = 1
            };
            
            Request
                .Post("https://jsonplaceholder.typicode.com/posts")
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


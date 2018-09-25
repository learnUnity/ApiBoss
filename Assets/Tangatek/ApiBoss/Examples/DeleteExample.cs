using UnityEngine;

namespace Tangatek.ApiBoss
{
    public class DeleteExample : MonoBehaviour 
    {
        public void Start()
        {
            Request
                .Delete("https://jsonplaceholder.typicode.com/posts/1")
                .OnError(Helpers.LogError)
                .OnResponse(Helpers.LogResponse)
                .Send();
        }
    }
}


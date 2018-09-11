using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ApiBoss
{
    public class GetExample : MonoBehaviour 
    {
        public void Start()
        {
            Request
                .Create()
                .Url("https://jsonplaceholder.typicode.com/posts/1")
                .OnComplete(JsonResponseHandler<Response>.Create(OnResponse))
                .Send();
        }

        private void OnResponse(Response response)
        {
            Debug.Log("Title:" + response.title);
        }

        public class Response
        {
            public int userId;
            public int id;
            public string title;
            public string body;
        }
    }
}


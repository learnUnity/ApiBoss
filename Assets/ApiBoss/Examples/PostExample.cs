using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ApiBoss
{
    public class PostExample : MonoBehaviour 
    {
        public void Start()
        {
            Request
                .Create()
                .AddUrl("https://jsonplaceholder.typicode.com/posts/1")
                .AddJsonResponse<Response>(OnResponse)
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


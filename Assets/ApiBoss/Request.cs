using UnityEngine;
using UnityEngine.Networking; 
using System.Collections;

namespace ApiBoss
{
    public class Request
    {
        public string url;
        public UnityWebRequest unityWebRequest;
        public IRequestHandler requestHandler;
        public IResponseHandler responseHandler;
        public IErrorHandler errorHandler;
        
        public bool isDone
        {
            get { return unityWebRequest != null && unityWebRequest.isDone; }
        }

        public bool isError
        {
            get { return unityWebRequest != null && (unityWebRequest.isNetworkError || unityWebRequest.isHttpError); }
        }

        public Request()
        {
            unityWebRequest = new UnityWebRequest();
        }

        public Request Send()
        {
            if (requestHandler == null) requestHandler = RequestHandler.Instance;
            requestHandler.OnHandleRequest(this);
            return this;
        }
        
        public Request Url(string url)
        {
            this.url = url;
            return this;
        }

        public Request OnError(IErrorHandler errorHandler)
        {
            this.errorHandler = errorHandler;
            return this;
        }

        public Request OnComplete(IResponseHandler responseHandler)
        {
            this.responseHandler = responseHandler;
            return this;
        }

        private void HandleRequest()
        {
            if (requestHandler == null) return;
            requestHandler.OnHandleRequest(this);
        }

        private void HandleError()
        {
            if (errorHandler == null) return;
            if (!isError) return;
            errorHandler.OnHandleError(this);
        }

        private void HandleResponse()
        {
            if (responseHandler == null) return;
            if (isError) return;
            responseHandler.OnHandleResponse(this);
        }
        
        public IEnumerator Process()
        {
            unityWebRequest = new UnityWebRequest();
            unityWebRequest.url = url;
            unityWebRequest.downloadHandler = responseHandler.GetDownloadHandler();
            yield return unityWebRequest.SendWebRequest();
            HandleError();
            HandleResponse();
        }
    }
}
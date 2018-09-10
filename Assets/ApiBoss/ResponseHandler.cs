using UnityEngine.Networking;

namespace ApiBoss
{
    public abstract class ResponseHandler: IResponseHandler
    {
        protected DownloadHandler downloadHandler = new DownloadHandlerBuffer();

        public DownloadHandler GetDownloadHandler()
        {
            return downloadHandler;
        }
        
        public abstract void OnHandleResponse(Request request);
    }
}
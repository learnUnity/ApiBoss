using UnityEngine.Networking;

namespace ApiBoss
{
    public class PayloadHandler: IPayloadHandler
    {
        protected UploadHandler uploadHandler;

        public PayloadHandler SetData<T>(byte[] data) where T : PayloadHandler
        {
            uploadHandler = new UploadHandlerRaw(data);
            return (T) this;
        }

        public void OnHandlePayload(Request request)
        {
            request.unityWebRequest.uploadHandler = uploadHandler;
        }
    }
}
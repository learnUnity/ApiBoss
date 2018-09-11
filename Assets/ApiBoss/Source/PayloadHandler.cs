using UnityEngine.Networking;

namespace ApiBoss
{
    public class PayloadHandler: IPayloadHandler
    {
        protected UploadHandler uploadHandler;

        public PayloadHandler SetData(byte[] data)
        {
            uploadHandler = new UploadHandlerRaw(data);
            return this;
        }

        public void OnHandlePayload(Request request)
        {
            request.unityWebRequest.uploadHandler = uploadHandler;
        }
    }
}
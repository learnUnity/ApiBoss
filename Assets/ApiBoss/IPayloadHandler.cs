using UnityEngine.Networking;

namespace ApiBoss
{
    public interface IPayloadHandler
    {
        void OnHandlePayload(Request request);
    }
}
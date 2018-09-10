using UnityEngine.Networking;

namespace ApiBoss
{
    public interface IResponseHandler
    {
        /// <summary>
        /// Retrieves the current DownloadHandler
        /// </summary>
        /// <returns></returns>
        DownloadHandler GetDownloadHandler();
        /// <summary>
        /// Called when DownloadHandler is finished
        /// </summary>
        void OnHandleResponse(Request request);
    }
}
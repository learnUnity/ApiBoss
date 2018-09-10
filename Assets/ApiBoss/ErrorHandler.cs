using System;
using UnityEditor.PackageManager;

namespace ApiBoss
{
    public class ErrorHandler : IErrorHandler
    {
        private Action<string> handler = delegate(string error) { };
        
        public void OnHandleError(Request request)
        {
            if (handler != null) handler(request.unityWebRequest.error);
        }

        public static ErrorHandler Create(Action<string> handler)
        {
            return new ErrorHandler()
            {
                handler = handler
            };
        }
    }
}
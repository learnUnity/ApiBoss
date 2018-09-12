using System;
using UnityEngine;

namespace ApiBoss
{
    public static class Helpers
    {
        public static void LogError(int statusCode, string message)
        {
            Debug.LogError(String.Format("Error: ({0}) {1}",statusCode, message));
        }

        public static void LogResponse(int statusCode, string message)
        {
            Debug.Log(String.Format("Response: ({0}) {1}",statusCode, message));
        }
    }
}
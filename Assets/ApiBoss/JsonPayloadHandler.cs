using System.Text;
using UnityEngine;
using Object = System.Object;

namespace ApiBoss
{
    public class JsonPayloadHandler: PayloadHandler
    {
        public static JsonPayloadHandler Create(Object obj)
        {
            var json = JsonUtility.ToJson(obj);
            var data = Encoding.UTF8.GetBytes(json);
            return new JsonPayloadHandler()
                .SetData(data); 
        }
    }
}
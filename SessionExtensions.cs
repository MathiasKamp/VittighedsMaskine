using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace VittighedsMaskinen
{
    /// <summary>
    /// this method is used as an extension to api session
    /// </summary>
    public static class SessionExtensions
    {
        /// <summary>
        /// this method sets an object as a json string to the session
        /// </summary>
        /// <param name="session"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        /// <summary>
        /// this method gets a json string from the session and returns it as the original object before it got serialized
        /// </summary>
        /// <param name="session"></param>
        /// <param name="key"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);

            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
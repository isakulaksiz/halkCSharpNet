using Newtonsoft.Json;

namespace eshop.Extensions
{
    public static class SessionExtensions
    {
        public static void SetJson<T>(this ISession session, string key, T value)
        {
            var serialized = JsonConvert.SerializeObject(value);
            session.SetString(key, serialized);
        }


        public static T GetJson<T>(this ISession session, string key)
        {
            var serializedString = session.GetString(key);
            return serializedString == null ? default(T) : JsonConvert.DeserializeObject<T>(serializedString);

        }
    }
}

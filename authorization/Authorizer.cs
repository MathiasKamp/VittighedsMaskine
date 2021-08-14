using Microsoft.Extensions.Configuration;

namespace VittighedsMaskinen.authorization
{
    /// <summary>
    /// this class is used to authorize the client towards the webserver
    /// </summary>
    public class Authorizer
    {
        // property of IConfiguration used to get a value from appsettings.json
        private IConfiguration Config { get; }
        // property to hold the key value of apiKey in appsettings.json
        private static string ApiKeyHeaderName => "apiKey";

        /// <summary>
        /// constructor of Authorizer
        /// </summary>
        /// <param name="config"></param>
        public Authorizer(IConfiguration config)
        {
            Config = config;
        }


        /// <summary>
        /// this method validates if the clients apiKey is the same as the one in appsettings.json
        /// </summary>
        /// <param name="apiKeyFromClient"></param>
        /// <returns>boolean</returns>
        public bool ClientIsAuthorizedWithApiKey(string apiKeyFromClient)
        {
            bool userIsAuthorized = false;
            string apiKeyFromWebserver = Config.GetValue<string>(ApiKeyHeaderName);

            if (apiKeyFromClient == apiKeyFromWebserver)
            {
                userIsAuthorized = true;
            }

            return userIsAuthorized;
        }
    }
}
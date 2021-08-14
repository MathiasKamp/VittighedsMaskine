using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using VittighedsMaskinen.authorization;


namespace VittighedsMaskinen.Controllers
{
   
    /// <summary>
    /// this controller is used to get a random joke
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class Jokes : ControllerBase
    {
        // new instance of jokeManager
        private JokeManager JokeManager = new JokeManager();

        // property i Configuration used to get the api key from appsettings.json
        private IConfiguration Config;

        // constructor
        public Jokes(IConfiguration config)
        {
            Config = config;
        }

        /// <summary>
        /// method is used to show the client all the jokeTypes available 
        /// </summary>
        /// <returns>List<string></returns>
        [HttpGet]
        [Route("GetJokeTypes")]
        public List<String> GetJokeTypes()
        {
            return JokeManager.GetJokeTypes();
        }

        /// <summary>
        /// method is used to set the jokeType that the client have chosen.
        /// the jokeType will be set as a cookie
        /// </summary>
        /// <param name="jokeType"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("SetJokeType")]
        public string SetJokeType(string jokeType)
        {
            // check if the jokeType from the client is valid
            bool isValidJokeType = jokeType.Equals("farJoke") || jokeType.Equals("blondineJoke") ||
                                   jokeType.Equals("dinMorJoke") || jokeType.Equals("alleBorneneJoke");

            // new instance of Authorizer
            Authorizer auth = new Authorizer(Config);
            // check if the clients api-key is the same as the one in appsettings.json
            bool authorized = auth.ClientIsAuthorizedWithApiKey(HttpContext.Request.Headers["apikey"]);

            // if the user is authorized and the jokeType is valid
            if (authorized && isValidJokeType)
            {
                // add the jokeType to cookie
                Response.Cookies.Append("jokeType", jokeType);
                return "you are authorized and have chosen the jokeType : " + jokeType;
            }

            // if the client is authorized but the jokeType is not valid
            if (authorized && !isValidJokeType)
            {
                return $"you are authorized but the chosen jokeType : {jokeType}  is not supported :";
            }

            // if the client is not authorized but the jokeType is valid
            if (!authorized && isValidJokeType)
            {
                Response.Cookies.Append("jokeType", jokeType);
                return
                    $"you are not authorized therefore you can only see limited content of the jokeType : {jokeType} ";
            }

            return $"you are not authorized and the jokeType : {jokeType}, is not valid";
        }

        /// <summary>
        /// method is used to return a random joke to the client
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getRandomJoke")]
        public List<Joke> GetRandomJoke()
        {
            // receive the clients jokeList from the session
            List<Joke> sessionJokes = HttpContext.Session.GetObjectFromJson<List<Joke>>("Jokes");

            // receive the clients jokeType from the cookie
            string jokeTypeFromCookie = Request.Cookies["jokeType"];

            bool isValidLanguage = false;

            string language = null;

            // new instance of Authorizer
            Authorizer auth = new Authorizer(Config);
            // check if the clients api-key is the same as the one in appsettings.json
            bool authorized = auth.ClientIsAuthorizedWithApiKey(HttpContext.Request.Headers["apikey"]);

            // check if the clients header contains any accept-language 
            if (Request.Headers["Accept-Language"].Count > 0)
            {
                language = Request.Headers["Accept-Language"];

                // check if the language is either english or danish
                isValidLanguage = language.Contains("en-") || language.Contains("da-");
            }

            // check if the jokeType is valid
            bool isValidJokeType = jokeTypeFromCookie.Equals("farJoke") || jokeTypeFromCookie.Equals("blondineJoke") ||
                                   jokeTypeFromCookie.Equals("dinMorJoke") ||
                                   jokeTypeFromCookie.Equals("alleBorneneJoke");

            // check if the joketype, language and authorized is valid
            if (isValidJokeType && isValidLanguage && authorized)
            {
                // splits the language string into a string array 
                string[] languages = language.Split(",");

                // if there is more than 1 string then ill use the first language
                string firstLanguage = languages[0].Substring(0, 3);
                
                // get a random joke
                List<Joke> jokes = JokeManager.GetJokes(firstLanguage, jokeTypeFromCookie, sessionJokes, authorized);

                // put the joke List into the session 
                HttpContext.Session.SetObjectAsJson("Jokes", jokes);
                
                // return the jokes to the client
                return jokes;
            }

            return null;
        }
    }
}
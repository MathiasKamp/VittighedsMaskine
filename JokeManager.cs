using System.Collections.Generic;
using System.Linq;


namespace VittighedsMaskinen
{
    /// <summary>
    /// this class has the purpose of sending userinput between the controller and the databaseManager
    /// </summary>
    public class JokeManager
    {
        /// <summary>
        /// this method returns a randomjoke from datbaseManager
        /// </summary>
        /// <param name="language"></param>
        /// <param name="jokeType"></param>
        /// <param name="sessionJokes"></param>
        /// <param name="authorized"></param>
        /// <returns>List<joke></returns>
        public static List<Joke> GetJokes(string language, string jokeType, List<Joke> sessionJokes, bool authorized)
        {
            if (ValidateLanguage(language) && ValidateJokeType(jokeType))
            {
                return DatabaseManager.GetJokes(language, jokeType, sessionJokes, authorized);
            }

            return null;

        }

        /// <summary>
        /// this method returns the list of jokeTypes from DatabaseManager
        /// </summary>
        /// <returns>List<string></returns>
        public static List<string> GetJokeTypes()
        {
            return DatabaseManager.GetJokeTypes();
        }

        /// <summary>
        /// this method validates the language from the controller. thje only languages that are valid is english and danish
        /// </summary>
        /// <param name="language"></param>
        /// <returns>boolean</returns>
        private static bool ValidateLanguage(string language)
        {
            return language.Contains("en-") || language.Contains("da-");
        }

        /// <summary>
        /// this method validates the jokeType
        /// </summary>
        /// <param name="jokeType"></param>
        /// <returns>boolean</returns>
        private static bool ValidateJokeType(string jokeType)
        {
            return jokeType.Equals("farJoke") || jokeType.Equals("blondineJoke") || jokeType.Equals("dinMorJoke") ||
                   jokeType.Equals("alleBorneneJoke");
        }
    }
}

namespace VittighedsMaskinen
{
    /// <summary>
    /// this class purpose is to be an object of a joke
    /// </summary>
    public class Joke
    {
        /// <summary>
        /// Constructor of Joke
        /// </summary>
        /// <param name="jokeId"></param>
        /// <param name="jokeType"></param>
        /// <param name="language"></param>
        /// <param name="content"></param>
        public Joke(int jokeId, string jokeType, string language, string content)
        {
            JokeId = jokeId;
            Content = content;
            Language = language;
            JokeType = jokeType;
        }

        /// <summary>
        /// properties of Joke
        /// </summary>
        public string JokeType { get; }
        public string Content { get; }
        public int JokeId { get; }
        public string Language { get; }
    }
}
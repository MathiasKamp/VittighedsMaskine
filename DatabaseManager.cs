using System;
using System.Collections.Generic;

namespace VittighedsMaskinen
{
    /// <summary>
    /// this class has the purpose of returning data from "database" to jokeManager 
    /// </summary>
    public class DatabaseManager
    {
        /// <summary>
        /// this method adds "din mor jokes" to a list
        /// </summary>
        /// <returns>List<joke></returns>
        private static List<Joke> AddAllDinMorJokes()
        {
            List<Joke> dinMorJokes = new List<Joke>();
            dinMorJokes.AddRange(new List<Joke>
            {
                new(1, "dinMorJoke", "da",
                    "Din mor er så fed så når hun hopper i Limfjorden bliver Storebæltsbroen oversvømmet!"),
                new(2, "dinMorJoke", "da",
                    "Hvorfor ville hitler dræbe jøderne? Din mor var en del af dem!"),
                new(3, "dinMorJoke", "da",
                    "Din mor er så fed at når hun skal se fodboldkamp skal hun bestille hele sydsiden af brøndbystadion"),
                new(4, "dinMorJoke", "da",
                    "Din mor er så fattig at afrika er begyndt at samle ind til hende"),
                new(5, "dinMorJoke", "da",
                    "Din mor er ligsom Fakta Det Tager kun 5 minutter."),
                new(6, "dinMorJoke", "en",
                    "Yo momma is so fat...when she did a push-up, planet Earth went down "),
                new(7, "dinMorJoke", "en",
                    "Yo mama's so fat, when she fell I didn't laugh, but the sidewalk cracked up."),
                new(8, "dinMorJoke", "en",
                    "Yo mama's so fat, when she goes camping, the bears hide their food."),
                new(9, "dinMorJoke", "en",
                    "Yo mama's so fat, if she buys a fur coat, a whole species will become extinct."),
                new(10, "dinMorJoke", "en",
                    "Yo mama's so fat, when she wears high heels, she strikes oil."),
            });

            return dinMorJokes;
        }

        private static List<Joke> AddAllAlleBorneneJokes()
        {
            List<Joke> alleBorneneJokes = new List<Joke>();
            alleBorneneJokes.AddRange(new List<Joke>
            {
                new(1, "alleBorneneJoke", "da",
                    "Alle børnene kom sikkert hjem fra fabrikken " + "-" +
                    " Undtagen Ib og Arne de blev til chili con carne"),
                new(2, "alleBorneneJoke", "en",
                    "My wife said I should do lunges to stay in shape. " + "-" + " That would be a big step forward."),
                new(3, "alleBorneneJoke", "da",
                    "Alle børnene hoppede ned i blenderen? " + "-" + " Undtagen Karlsmart han trykkede på start"),
                new(4, "alleBorneneJoke", "da",
                    "Alle børnene kom sikkert ud af fabrikken  " + "-" +
                    " Undtagen Fin, Bo og Asker de blev til skin sko og tasker"),
                new(5, "alleBorneneJoke", "da",
                    "Alle Børnene hoppede over Hundelorten " + "-" + " Undtagen Tam Tam han satte sig og fik Nam Nam"),
                new(6, "alleBorneneJoke", "da",
                    "Alle børnene var raske " + "-" + " Undtagen Nihat han havde fnat"),
                new(7, "alleBorneneJoke", "en",
                    "All the children were tired, except Jane. " + "-" + " She had cocaine."),
                new(8, "alleBorneneJoke", "en",
                    "All the children are loved by their parents, except Dale. " + "-" + " He is for sale."),
                new(9, "alleBorneneJoke", "en",
                    "All the children died in the school shooting, except Tim. " + "-" +
                    " They'll regret not respecting him."),
                new(10, "alleBorneneJoke", "en",
                    "All the children were cannibals, except Lucy. " + "-" + " She was juicy."),
            });

            return alleBorneneJokes;
        }


        private static List<Joke> AddAllFarJokes()
        {
            List<Joke> farJokes = new List<Joke>();
            farJokes.AddRange(new List<Joke>
            {
                new(1, "farJoke", "da",
                    "Hvorfor skulle skyen i skole? " + "-" + " Fordi den skulle lære at regne"),
                new(2, "farJoke", "en",
                    "My wife said I should do lunges to stay in shape. " + "-" + " That would be a big step forward."),
                new(3, "farJoke", "da",
                    "Hvad er det mindst talte sprog i verden? " + "-" + " Tegnsprog"),
                new(4, "farJoke", "da",
                    "Hvad sagde den ene cykel til den anden? " + "-" + " Styr dig!"),
                new(5, "farJoke", "da",
                    "Hvad laver tømreren når han langt om længe får fri fra arbejde? " + "-" +
                    " Lige vatterpass’er ham"),
                new(6, "farJoke", "da",
                    "Hvad hedder verdens fattigste konge? " + "-" + "Kong Kurs"),
                new(7, "farJoke", "en",
                    "Why do fathers take an extra pair of socks when they go golfing? " + "-" +
                    " In case they get a hole in one!"),
                new(8, "farJoke", "en",
                    "What do you call a fish wearing a bowtie? " + "-" + " Sofishticated."),
                new(9, "farJoke", "en",
                    "Where do fruits go on vacation? " + "-" + " Pear-is!"),
                new(10, "farJoke", "en",
                    "Dad, did you get a haircut? " + "-" + " No, I got them all cut!"),
            });

            return farJokes;
        }

        private static List<Joke> AddAllBlondineJokes()
        {
            List<Joke> blondineJokes = new List<Joke>();
            blondineJokes.AddRange(new List<Joke>
            {
                new(1, "blondineJoke", "da",
                    "Hvorfor var blondinen glad for, at samle et puzzlespil på 6 måneder? " + "-" +
                    "  Fordi der stod 2-4 år"),
                new(2, "blondineJoke", "en",
                    "Why can't a blonde dial 911? " + "-" + " She can't find the eleven."),
                new(3, "blondineJoke", "da",
                    "Hvad kalder man en død blondine i et klædeskab? " + "-" + " Tegnsprog"),
                new(4, "blondineJoke", "en",
                    "A robber comes into the store & steals a TV. A blonde runs after him and says " + "-" +
                    " Wait, you forgot the remote!"),
                new(5, "blondineJoke", "en",
                    " Why couldn't the blonde add 10 + 5 on a calculator?  " + "-" +
                    " She couldn't find the 10 button."),
                new(6, "blondineJoke", "en",
                    " What did the blonde say when she saw the Cheerios box?  " + "-" + " Omg, donut seeds!"),
                new(7, "blondineJoke", "en",
                    " Why did the blonde tip toe near the medicine cabinet?  " + "-" +
                    " Because she didn't want to wake the sleeping pills!! "),
                new(8, "blondineJoke", "da",
                    "Hvordan får du glimtet frem i en blondines øjne? " + "-" +
                    "  Lyser med din lommelygte ind i hendes øre"),
                new(9, "blondineJoke", "da",
                    "Hvorfor lægger blondiner p-piller på vejen? " + "-" + "  – De vil ikke have børn i trafikken."),
                new(10, "blondineJoke", "da",
                    "Hvorfor blev blondinen forvirret da hun fødte tvillinger? " + "-" +
                    "   Hun kunne ikke finde ud af hvem den anden mor var."),
            });

            return blondineJokes;
        }

        
        /// <summary>
        /// this method compares the clients jokeList with the full list of the chosen jokeType.
        /// And returns the jokes that the clients list don't have
        /// </summary>
        /// <param name="sessionJokeList"></param>
        /// <param name="fullJokeList"></param>
        /// <returns>List<Joke></returns>
        private static List<Joke> CompareJokeLists(List<Joke> sessionJokeList, List<Joke> fullJokeList)
        {
            List<Joke> missingJokeList = new List<Joke>();
            if (sessionJokeList.Count != 0)
            {
                bool jokeMatches = false;

                foreach (Joke sessionJoke in sessionJokeList)
                {
                    Joke tmpJoke = null;

                    foreach (Joke fullJoke in fullJokeList)
                    {
                        if (sessionJoke.JokeId == fullJoke.JokeId)
                        {
                            tmpJoke = fullJoke;
                            jokeMatches = true;
                        }
                    }

                    if (jokeMatches)
                    {
                        fullJokeList.Remove(tmpJoke);
                    }
                }

                missingJokeList = fullJokeList;
            }

            else
            {
                return fullJokeList;
            }

            return missingJokeList;
        }

        /// <summary>
        /// This method adds a random joke to the clients JokeList with the given jokeType and language
        /// </summary>
        /// <param name="language"></param>
        /// <param name="jokeType"></param>
        /// <param name="sessionJokes"></param>
        /// <param name="authorized"></param>
        /// <returns>List<Joke></returns>
        private static List<Joke> AddRandomJokeToSessionList(string language, string jokeType, List<Joke> sessionJokes,
            bool authorized)
        {
            // this is for when client is not authorized then they are only able to receive one joke
            if (authorized == false && sessionJokes.Count == 1 && ValidateLanguage(language) &&
                ValidateJokeType(jokeType))
            {
                return sessionJokes;
            }

            // check if the jokeType, authorization and language is valid
            if (ValidateJokeType(jokeType) && authorized && ValidateLanguage(language))
            {
                List<Joke> tmpList;
                List<Joke> missingJokes;

                // remove the Hyphen from language
                string langWithOutHyphen = language.Substring(0, 2);

                // create a new List if its the first time the client is requesting a joke
                if (sessionJokes == null)
                {
                    sessionJokes = new List<Joke>();
                }


                // add a new joke to the clients jokeList depending on what jokeType the client have choosen
                switch (jokeType)
                {
                    case "farJoke":
                        tmpList = AddAllFarJokes();
                        missingJokes = CompareJokeLists(sessionJokes, tmpList);
                        sessionJokes.Add(GetNewJoke(missingJokes, langWithOutHyphen));
                        break;
                    case "blondineJoke":
                        tmpList = AddAllBlondineJokes();
                        missingJokes = CompareJokeLists(sessionJokes, tmpList);
                        sessionJokes.Add(GetNewJoke(missingJokes, langWithOutHyphen));
                        break;
                    case "dinMorJoke":
                        tmpList = AddAllDinMorJokes();
                        missingJokes = CompareJokeLists(sessionJokes, tmpList);
                        sessionJokes.Add(GetNewJoke(missingJokes, langWithOutHyphen));
                        break;
                    case "alleBorneneJoke":
                        tmpList = AddAllAlleBorneneJokes();
                        missingJokes = CompareJokeLists(sessionJokes, tmpList);
                        sessionJokes.Add(GetNewJoke(missingJokes, langWithOutHyphen));
                        break;
                }
            }

            return sessionJokes;
        }


        /// <summary>
        /// this method returns the joke to the jokeManager
        /// </summary>
        /// <param name="language"></param>
        /// <param name="jokeType"></param>
        /// <param name="sessionJokes"></param>
        /// <param name="authorized"></param>
        /// <returns>List<Joke>/returns>
        public static List<Joke> GetJokes(string language, string jokeType, List<Joke> sessionJokes, bool authorized)
        {
            sessionJokes = AddRandomJokeToSessionList(language, jokeType, sessionJokes, authorized);

            return sessionJokes;
        }

        /// <summary>
        /// this method returns a joke that the client dose not have
        /// </summary>
        /// <param name="missingJokes"></param>
        /// <param name="language"></param>
        /// <returns>Joke</returns>
        private static Joke GetNewJoke(List<Joke> missingJokes, string language)
        {
            Joke tmpJoke = null;
            foreach (Joke joke in missingJokes)
            {
                if (joke.Language == language)
                {
                    tmpJoke = joke;
                    break;
                }
            }

            return tmpJoke;
        }

        /// <summary>
        /// this method returns the jokeTypes
        /// </summary>
        /// <returns>List<String></returns>
        public static List<string> GetJokeTypes()
        {
            List<string> jokeTypes = new List<string>
            {
                "farJoke",
                "blondineJoke",
                "dinMorJoke",
                "alleBorneneJoke"
            };

            return jokeTypes;
        }

        /// <summary>
        /// this method validates the jokeType 
        /// </summary>
        /// <param name="jokeType"></param>
        /// <returns>boolean</returns>
        private static bool ValidateJokeType(string jokeType)
        {
            List<String> jokeTypes = GetJokeTypes();

            bool isValidJokeType = false;

            foreach (string jokeTyp in jokeTypes)
            {
                if (jokeTyp.Equals(jokeType))
                {
                    isValidJokeType = true;
                }
            }

            return isValidJokeType;
        }

        /// <summary>
        /// this method validates the language
        /// </summary>
        /// <param name="language"></param>
        /// <returns>boolean</returns>
        private static bool ValidateLanguage(string language)
        {
            bool isValidLanguage = language.Contains("en-") || language.Contains("da-");
            
            return isValidLanguage;
        }
    }
}
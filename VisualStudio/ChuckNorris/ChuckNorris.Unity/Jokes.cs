namespace ChuckNorris
{
    public static class Jokes
    {
        private static readonly ChuckNorris chuck = new ChuckNorris();
        public static string Next()
        {
            var joke = chuck.GetRandom();
            return joke.value;
        }
    }
}

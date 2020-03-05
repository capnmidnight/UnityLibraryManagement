using static System.Console;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            var chuck = new ChuckNorris();
            var joke = chuck.GetRandom();
            WriteLine(joke.value);
        }
    }
}

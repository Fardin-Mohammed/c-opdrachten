
namespace IntroChangeVariableValues
{
    internal class Program
    {
        private string myFavoriteCity;
        private int myFavoriteNumber;
        private bool displayNumber;
        private string characterName;
        private DateTime currentTime;


        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            string character1 = "mario";
            string character2 = "luigi";

            characterName = character1;
            currentTime= DateTime.Now;
            myFavoriteCity = "Purmerend"; //geef hier myFavoriteCity een waarde 
            myFavoriteNumber = "7"; //geef hier myFavoriteNumber een waarde 
            displayNumber = true; //zet displayNumber op true
            Display();

            //nu gaan we de waarden instellen voor luigi, gebruik andere waardes

            characterName = """Fardin""";
            currentTime = "10:15";//zoek op hoe je de huidige tijd kan krijgen (DateTime.???)
            myFavoriteCity = "Eindhoven"; //geef hier myFavoriteCity een waarde 
            myFavoriteNumber = "5"; //geef hier myFavoriteNumber een waarde 
            displayNumber = false; //zet displayNumber op false
            Display();
        }
   
        private void Display()
        {
            Console.WriteLine("hi i'm "+"Fardin");
            Console.WriteLine("it is now " + "10:39");

            Console.WriteLine("my favorite city is: Purmerend");
            Console.WriteLine(myFavoriteCity);
            if (displayNumber)
            {
                Console.WriteLine("my favorite number is: 7");
                Console.WriteLine(myFavoriteNumber);
            }
        }
    }
}

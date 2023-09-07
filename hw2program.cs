using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;


namespace Program {
    class Application {
        static void Main(string[] args) {
            MainMenu menu = new MainMenu();
            string lineage = menu.CharacterLineage();
            string name = menu.CharacterName();
            string allegiance = menu.CharacterAllegiance();
           


            Character player = new Character(lineage, name, allegiance);
            player.print();
        }
    }


    class MainMenu {
        private string charClass;
        public string CharacterLineage() {
            bool running = true;
            string selectedCharClass; // OF said to rename local variable


            do {
                Console.WriteLine("1. Spring");
                Console.WriteLine("2. Summer");
                Console.WriteLine("3. Autumn");
                Console.WriteLine("4. Winter");
                Console.WriteLine("\nChoose your lineage: ");


                string key = Console.ReadLine();
                int choice = key == "" ? 0 : int.Parse(key);


                if (choice == 1) {
                    Console.WriteLine("\nThe people of Spring greet you, fair traveler.");
                    charClass = "Spring";
                    running = false;
                } else if (choice == 2) {
                    Console.WriteLine("\nThe people of Summer welcome you, dear companion.");
                    charClass = "Summer";
                    running = false;
                } else if (choice == 3) {
                    Console.WriteLine("\nThe people of Autumn extend their greetings, lonely wanderer.");
                    charClass = "Autumn";
                    running = false;
                } else if (choice == 4) {
                    Console.WriteLine("\nThe people of Winter bid their welcome, weary explorer.");
                    charClass = "Winter";
                    running = false;
                } else {
                    Console.WriteLine("\nInput not recognized. Please provide valid information.");
                }
            } while (running);
            // charClass = selectedCharClass;
            return charClass;
        }


        public string CharacterName() {
            Console.WriteLine("\n*******************************");
            Console.WriteLine("\nName your character.");
            string name = Console.ReadLine();
            return name;
        }
       
        public string CharacterAllegiance() {
            bool running = true;
            string characterNameAllegiance;
            do {
                Console.WriteLine("1. Devoted");
                Console.WriteLine("2. Impartial");
                Console.WriteLine("3. Disloyal");


                string key = Console.ReadLine();
                int choice = key == "" ? 0 : int.Parse(key);


                if (choice == 1) {
                    Console.WriteLine("\nThe eyes of the people look upon you with kindness.");
                    charClass = "Devoted";
                    running = false;
                } else if (choice == 2) {
                    Console.WriteLine("\nLight and darkness are inseparable from one another.");
                    charClass = "Impartial";
                    running = false;
                } else if (choice == 3) {
                    Console.WriteLine("\nFreedom is yours to gain, my friend.");
                    charClass = "Disloyal";
                    running = false;
                } else {
                    Console.WriteLine("\nInput not recognized. Please provide valid information.");
                }    
            } while (running);
            // charClass = characterNameAllegiance;
            return charClass;


       
        }


    }
    class Character{
        public string CharacterName;
        public string CharacterLineage;
        public string CharacterAllegiance;
       


        public Character (string characterName, string characterLineage, string characterAllegiance){
            this.CharacterName = characterName;
            this.CharacterLineage = characterLineage;
            this.CharacterAllegiance = characterAllegiance;
        }
        public void print() {
            Console.WriteLine("Character Name: " + CharacterLineage + " Character Lineage: " + CharacterName + " Character Allegiance: " + CharacterAllegiance);
        }
   
    }


}

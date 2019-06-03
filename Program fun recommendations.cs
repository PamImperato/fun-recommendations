using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU00030191Pam_Imperato_Fun_Recommendations
{
    class Program
    {


        static void Main(string[] args)
        {
            Greeting();
        }
        static void Greeting()
        {
            Console.WriteLine("Hello welcome to Travel Concierge'\n\nAs  The concierge will ask you two questions'" +
                "\n\nafter the questions, will then use them for your personalization recommendations'/n/nIf ready then press enter to continue'");
            Console.ReadLine();
            QuestionsLogic();

        }

        static void QuestionsLogic()
        {

            Console.WriteLine("What type of adventure are you looking for?\n\nSelect 1 Looking for Action\n\nSelect 2 Hanging out and chilling\n\n" +
                "Select 3 If you like to live dangerously\n\nSelect 4 If you want some good food");
            string input = Console.ReadLine();
            int.TryParse(input, out int adventure);
            while (!int.TryParse(input, out adventure) || adventure < 1 || adventure > 4)
            {
                Console.WriteLine("Selection invalid!\n\nOnlynumbers 1-4 may be used...");
                Console.WriteLine("What type of adventure are you looking for?\n\nSelect 1 Looking for Action\n\nSelect 2 Hanging out and chilling\n\n" +
                "Select 3 If you like to live dangerously\n\nSelect 4 If you want some good food");
                input = Console.ReadLine();
                int.TryParse(input, out adventure);
            }

            Console.WriteLine("How many people will you be bring with you?");
            input = Console.ReadLine();
            int.TryParse(input, out int numberinparty);
            while (!int.TryParse(input, out numberinparty) || numberinparty < 0)
            {
                Console.WriteLine("Selection is invalid!\n\nNumbers only...");
                Console.WriteLine();
                Console.WriteLine("How many people will be in your party?");
                input = Console.ReadLine();
                int.TryParse(input, out numberinparty);

            }

            //Console.WriteLine($"(adventure) + (numberinparty)");
            if (adventure == 1 && numberinparty == 0)
            {
                Console.WriteLine("If you are in the mood for action you should go stock car racing" +
                    "travel in sneakers");
            }
            else if (adventure == 1 && numberinparty > 0 && numberinparty < 5)
            {
                Console.WriteLine("If in the mood for adventure go stock car racing" +
                    "and travel in a sedan.");
            }
            else if (adventure == 1 && numberinparty > 4 && numberinparty < 11)
                Console.WriteLine("If in the mood for adventure go stock car racing" +
                    "and travelin a VW bus");
            else if (adventure == 1 && numberinparty > 10)
                Console.WriteLine("If in the mood for adventure go stock car racing" +
                    "and travel in an airplane.");

            //chilling
            if (adventure == 2 && numberinparty == 0)
            {
                Console.WriteLine("If you are in the mood to chill you should go hiking in the Himalayas" +
                    "travel in sneakers");
            }
            else if (adventure == 2 && numberinparty > 0 && numberinparty < 5)
            {
                Console.WriteLine("If in the mood for adventure go stock car racing" +
                    "and travel in a sedan.");
            }
            else if (adventure == 2 && numberinparty > 4 && numberinparty > 11)
                Console.WriteLine("If in the mood for adventure go hiking in the Himalayas" +
                    "and travelin a VW bus");
            else if (adventure == 2 && numberinparty > 10)
                Console.WriteLine("If in the mood for adventure go hiking in the Himalayas" +
                    "and travel in an airplane.");
            //danger
            if (adventure == 3 && numberinparty == 0)
            {
                Console.WriteLine("If you are in the mood to live dangerously you should go skydiving" +
                    "travel in sneakers");
            }
            else if (adventure == 3 && numberinparty > 0 && numberinparty < 5)
            {
                Console.WriteLine("If in the mood to live dangerously you should go skydiving" +
                    "and travel in a sedan.");
            }
            else if (adventure == 3 && numberinparty > 4 && numberinparty < 11)
                Console.WriteLine("If in the mood to live dangerously you should go skydiving" +
                    "and travelin a VW bus");
            else if (adventure == 3 && numberinparty > 10)
                Console.WriteLine("If in the mood to live dangerously you should go skydiving" +
                    "and travel in an airplane.");
            //good food
            if (adventure == 4 && numberinparty == 0)
            {
                Console.WriteLine("If you are in the mood for good food you should go to Taco Bell--no way come to my house" +
                    "travel in sneakers");
            }
            else if (adventure == 4 && numberinparty > 0 && numberinparty < 5)
            {
                Console.WriteLine("If in the mood for good food you should go to Taco Bell--no way come to my house" +
                    "and travel in a sedan.");
            }
            else if (adventure == 4 && numberinparty > 4 && numberinparty < 11)
                Console.WriteLine("If in the mood for for good food you should go to Taco Bell--no way come to my house " +
                    "and travelin a VW bus");
            else if (adventure == 4 && numberinparty > 11)
                Console.WriteLine("If in the mood for for good food you should go to Taco Bell--no way come to my house" +
                    "and travel in an airplane.");

            Console.WriteLine("Goodbye and enjoy your journey");
        }
        
        
            
            }
         
    
    

    }

    


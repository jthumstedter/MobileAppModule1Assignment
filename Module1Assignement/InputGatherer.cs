using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1Assignement
{
    internal class InputGatherer
    {
        public List<ITalkable> GenerateData()
        {
            List<ITalkable> output = new List<ITalkable>();
            bool continueLoop = true;
            do
            {
                int inputAnimal = 0;
                while (true)
                {
                    Console.WriteLine("What kind of animal do you want to make (Input any other integer when you are done)");
                    Console.WriteLine("1) Cat");
                    Console.WriteLine("2) Dog");
                    if (!int.TryParse(Console.ReadLine(), out inputAnimal))
                    {
                        Console.WriteLine("Invalid input. Input an integer.");
                    }
                    else
                    {
                        break;
                    }
                }
                switch (inputAnimal)
                {
                    case 1:
                        string catName;
                        while (true)
                        {
                            Console.Write("What is the cat's name?: ");
                            string catNameInput = Console.ReadLine();
                            if (String.IsNullOrEmpty(catNameInput))
                            {
                                Console.WriteLine("Invalid input. Input should not be null.");
                            }
                            else
                            {
                                catName = catNameInput;
                                break;
                            }
                        }
                        int mouseKilled;
                        while (true)
                        {
                            Console.Write("How many mouses did " + catName + " kill?: ");

                            if (!int.TryParse(Console.ReadLine(), out mouseKilled))
                            {
                                Console.WriteLine("Invalid input. Input an integer.");
                            }
                            else
                            {
                                break;
                            }
                        }
                        output.Add(new Cat(catName, mouseKilled));
                        break;
                    case 2:
                        string dogName;
                        while (true)
                        {
                            Console.Write("What is the dog's name?: ");
                            string dogNameInput = Console.ReadLine();
                            if (String.IsNullOrEmpty(dogNameInput))
                            {
                                Console.WriteLine("Invalid input. Input should not be null");
                            }
                            else
                            {
                                dogName = dogNameInput;
                                break;
                            }
                        }
                        bool isFriendly;
                        Console.Write("Is " +  dogName + " friendly (y/n)?: ");
                        string dogFriendlyInput = Console.ReadLine();
                        isFriendly = dogFriendlyInput.Equals("y") || dogFriendlyInput.Equals("Y");
                        output.Add(new Dog(dogName, isFriendly));
                        break;
                    default:
                        if(output.Count == 0)
                        {
                            Console.WriteLine("You must input at least one animal");
                        }
                        else
                        {
                            continueLoop = false;
                        }
                        
                        break;
                }
            } while (continueLoop);

            return output;
        }
    }
}

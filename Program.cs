using System;
using System.Collections.Generic;

namespace BenWeek6Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemOne();
            ProblemTwo();

            void ProblemOne()
            {

                string input = "";

                string name = "";

                int people = 0;

                List<string> list = new List<string>();

                do

                {
                    Console.WriteLine("Please enter in different names."); //Console displays text on different names.

                    input = Console.ReadLine(); //Console asks user to input different names.

                    bool isValid = false;

                    if (input != "") //If it's an invalid name, like a number, it will be false.

                        isValid = true;

                    if (isValid == true) //If the name is valid, the if statement will continue
                    {
                        list.Add(name);

                        Console.WriteLine("Next name: ");  //Console displays text on different names.

                        people++;

                    }
                    else
                    {

                    }

                } while (input != "");

                if (list.Count == 0)

                    Console.WriteLine(""); //If no names are inputed into the list, nothing will happen.

                else if (list.Count == 1)

                    Console.WriteLine(list[0] + " likes your post."); //If one name is inputed into the list, the text will appear with the name.

                else if (list.Count == 2)

                    Console.WriteLine(list[0] + " and " + list[1] + " like your post."); //If one or two names are inputed into the list, the text will appear with the names.

                else

                    Console.WriteLine(list[0] + " , " + list[1] + " and " + people + " others like your post."); //If three or more are inputed into the list, the text will appear with the names and how many other have liked the Facebook post.

            }


            void ProblemTwo()
            {
                Dictionary<int, int> properties = new Dictionary<int, int>(); 
                string userInput = "";

                do
                {
                    Console.WriteLine("Please enter in a sentence or enter okay."); //Console displays text on to enter in a sentence or enter okay.

                    userInput = Console.ReadLine(); //User inputs the sentence to the console.

                    int letter = 0; //int letter set to 0.

                    string[] pieces = userInput.Split();

                    if (int.TryParse(userInput, out letter))
                    {
                        if (properties.ContainsKey(letter))
                        {
                            properties[letter] += 1; //Will add one to counter
                        }
                        else
                        {
                            properties.Add(letter, 1); //Once added, start point at one.
                        }
                    }

                } while (userInput != "okay" || userInput == ""); ; //The user presses okay, the loop will end,. 

                foreach (KeyValuePair<int, int> kvp in properties)
                {
                    Console.WriteLine(kvp.Key + " | " + kvp.Value);
                }
            }
        }
    }
}
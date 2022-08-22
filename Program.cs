//Exercise 4
//Write a program and ask the user to enter a few words separated by a space. 
//Use the words to create a variable name with PascalCase. 
//For example, if the user types: "number of students", display "NumberOfStudents".
//Make sure that the program is not dependent on the input. 
//So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
using System;



namespace CsharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a few words separated by a space: ");

            var userInput = Console.ReadLine();
            var splitInput = userInput.Split(' ');
            List<string> newSentenceArr = new List<string>();

            for (var i = 0; i < splitInput.Length; i++)
            {
                newSentenceArr.Add(splitInput[i][0].ToString().ToUpper() + splitInput[i].Substring(1, splitInput[i].Length - 1).ToLower());
            }

            var sentence = string.Join("", newSentenceArr);
            Console.WriteLine(sentence);

        }
    }
}
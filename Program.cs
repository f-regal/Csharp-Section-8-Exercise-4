//Exercise 4
//Write a program and ask the user to enter a few words separated by a space. 
//Use the words to create a variable name with PascalCase. 
//For example, if the user types: "number of students", display "NumberOfStudents".
//Make sure that the program is not dependent on the input. 
//So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

Console.Write("Please enter a few words separated by a space: ");

var userInput = Console.ReadLine();
var splitInput = userInput.Split(' ');



for (var i = 0; i < splitInput.Length; i++)
{
    String.ToUpper(splitInput[0]);
}

foreach (var item in splitInput)
{
    Console.WriteLine(item);
}
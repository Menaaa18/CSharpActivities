using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_Code
{
    class Program
    {

        static void Main(string[] args)
        {
            //Classwork1
            //Code to Calculate the area of a square
            //This code prompts the user for a length and then converts the values into float and performs the specified formula
            //on the user inputs
            Console.WriteLine(value: "Enter the length of the square");
            string num = Console.ReadLine();
            float area = float.Parse(num) * float.Parse(num);
            Console.WriteLine(value: "The area of the square is: " + "" + area);

            //Assignment
            //Code for Calculator
            //This code performs calculation on the operation specified by the user and displays the result upon completion
            Console.WriteLine(value: "Enter the first number");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine(value: "Enter the second number");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine(value: "What operation do you want to perform? (add, sub, mul, div)");
            string prefOperation = Console.ReadLine().ToLower();
            float result = 0;
            if (prefOperation == "add")
            {
                result = num1 + num2;
            }
            else if (prefOperation == "sub")
            {
                result = num1 - num2;
            }
            else if (prefOperation == "mul")
            {
                result = num1 * num2;
            }
            else if (prefOperation == "div")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Dividing by zero is not allowed.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid");
                return;
            }
            Console.WriteLine("Final Result = " + "" + result);

            //Question1
            //Question1A
            //Program to prompt the user to enter the number and then check if it is valid or not
            //This takes a number and converts it to an integer then checks if the number is greater than or equal to 1 or less than 
            Console.WriteLine("Enter a number from 1 to 10?");
            int selectedNumber = Convert.ToInt32(Console.ReadLine());
            if (selectedNumber >= 1 && selectedNumber <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            //Question1B
            //Program to take two numbers from the console and displays the maximum of the two
            //This program prompt the user for two numbers and converts them to integers
            //The if-else statement checks for the largest number between the two numbers
            Console.WriteLine("Enter your first number");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            if (firstNum > secondNum)
            {
                Console.WriteLine(firstNum + " " + "is the largest number");
            }
            else
            {
                Console.WriteLine(secondNum + " " + "is the largest number");
            }

            //Question1C
            //A program to ask the user for the height and width of an image and decipher if it is landscape or portrait
            //This program simply does this by checking if the width is greater than the height which means it is a landscape
            //If the height is greater than the width it is a portrait
            //If the dimensions are of the same size then it is a square as all the sides of a square are equal
            Console.WriteLine("Enter the width of an image ");
            float width = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the height of an image");
            float height = Convert.ToSingle(Console.ReadLine());
            if (width > height)
            {
                Console.WriteLine("This image is a landscape");
            }
            else if (height > width)
            {
                Console.WriteLine("This image is a Portrait");
            }
            else
            {
                Console.WriteLine("The image is a square");
            }

            //Question1D
            //Program for a speed camera
            Console.WriteLine("Enter your speed limit");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed of your car");
            int CarSpeed = Convert.ToInt32(Console.ReadLine());

            if (CarSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int demeritPoint = (CarSpeed - speedLimit) / 5;
                Console.WriteLine("Your demerit point is: " + " " + demeritPoint);
                if (demeritPoint > 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }

            //Question2
            //Question2A
            //A program to calculate how many numbers between 1 to 100 that are divisible by 3 with no remainder
            
            int counter = 0; //counter to keep track of the divisible numbers
            //The for loop simply says if i is divisible by 3 and there is no remainder increase the counter by 1 with the condition specified
            
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("The numbers between 1 and 100 that are divisible by 3 are" + " " + counter);


            //Question2B
            //Program to enter a number continuously and sum the numbers
            //This program makes use of a while loop and breaks when the user types ok
            //It then converts the number which is a string to a number and adds it to the sum
            int sum = 0;

            while (true)
            {
                Console.Write("Enter a number or 'ok' to exit: " + " ");
                string numberr = (Console.ReadLine());

                if (numberr == "ok")
                {
                    break;
                }

                sum = sum + int.Parse(numberr);

            }

            //Question2C
            //Program to calculate the factorial of numbers
            //The code starts by setting the factorial to 1 because a number multiplied by 0 equals 0
            //The for loop is the fulfilled with the input in consideration and condition of the for loop for the iteration to continue
            Console.Write("Enter a number to find its factorial: ");
            int inputNumber = int.Parse(Console.ReadLine());

            long factorial = 1;

            for (int i = inputNumber; i > 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(inputNumber + "! = " + factorial);

            //Question2D
            //A program to pick a random number between 1 and 10
            //The for loop here runs 4 times and if the user guesses the secret number correctly, the loop breaks and it is displayed
            //If not the it displays that the user lost the game
            Random randomNumber = new Random();
            int secretNumber = randomNumber.Next(1, 11);
            int maxTrial = 4;
            bool guessedCorrectly = false;

            for (int i = 1; i <= maxTrial; i++)
            {
                Console.Write($"Attempt {i} - Guess the number: ");
                int userGuess = int.Parse(Console.ReadLine());

                if (userGuess == secretNumber)
                {
                    guessedCorrectly = true;
                    break;
                }

            }
            if (guessedCorrectly)
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("You lost");
                Console.WriteLine("The secret number was: " + secretNumber);
            }

            //Question2E
            //A program for the user to enter the series of numbers separated by comma
            //This code takes the user input, splits it with a comma and then stores the converted numbers in a list
            //The foreach simply loops through each split string, trims spaces and converts to an integer
            Console.WriteLine("Enter a set of numbers separated by a comma:");
            string userInputs = Console.ReadLine();
            string[] splitedNum = userInputs.Split(',');

            List<int> convertedNum = new List<int>();

            foreach (string item in splitedNum)
            {
                bool isValid = int.TryParse(item.Trim(), out int parsedNumber);

                if (isValid)
                {
                    convertedNum.Add(parsedNumber);
                }
            }

            if (convertedNum.Count == 0)
            {
                Console.WriteLine("No valid numbers entered.");
            }
            else
            {
                int largestValue = convertedNum[0];

                foreach (int currentNumber in convertedNum)
                {
                    if (currentNumber > largestValue)
                    {
                        largestValue = currentNumber;
                    }
                }

                Console.WriteLine("The largest number is: " + largestValue);
            }


            //Question3
            //Question3A
            //A program to display different information depending on the number of people who like the post

            //Create a list to store all the people that liked the post
            List<string> nameInput = new List<string>();
            Console.WriteLine("Please enter the names of the people that liked your post (press 'Enter' to stop):");
            //The while statement here continues to run until it is triggered by the break statement.
            //The program stops when the user clicks enter without typing anything and then all the names are collated and saved
            while (true)
            {
                Console.Write("Enter a name (or press Enter to finish): ");
                var enteredName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(enteredName))
                    break;
                nameInput.Add(enteredName);
            }

            //If the user inputted one name, the output would be relative to that name inputted and concatenated as illustrated
            //The same applies, vice versa as any other names provided by the user
            if (nameInput.Count == 1)
                Console.WriteLine($"{nameInput[0]} likes your post.");
            else if (nameInput.Count == 2)
                Console.WriteLine($"{nameInput[0]} and {nameInput[1]} like your post.");
            else if (nameInput.Count > 2)
                Console.WriteLine($"{nameInput[0]}, {nameInput[1]} and {nameInput.Count - 2} others like your post.");

            //Question3B
            //Program to display a reversed name to the console using an array
            //Take the names and store the names in an array which then splits the name into single letters 
            //Array.reverse which is a predefined function is C# is used to reverse the name and then display the result after converting back to a string
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);

            string reversedInput = new string(nameArray);
            Console.WriteLine("Your reversed name is: " + "" + reversedInput);


            //Question3C
            //Program to ask the user for 5 numbers and validate specific information about the numbers entered
            //Five numbers are entered and stored, a list is created to store all the numbers inputted
            //The while statement executes all the condition stated in the brackets if the numbers entered are less than 5
            //The numbers are then sorted and displayed to the console
            Console.WriteLine("Enter five unique numbers:");
            List<int> storedNumbers = new List<int>();

            while (storedNumbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (storedNumbers.Contains(number))
                {
                    Console.WriteLine("Error: Number already entered. Try again.");
                }
                else
                {
                    storedNumbers.Add(number);
                }
            }

            storedNumbers.Sort();
            Console.WriteLine("Sorted numbers: " + string.Join(", ", storedNumbers));

            //Question3D
            //Program to continuously ask the user for a number or type quit to exit
            List<int> numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number or type 'Quit' to exit: ");
                string inputText = Console.ReadLine();

                if (inputText == "Quit")  // the program stops when the user types break
                    break;

                int number = int.Parse(inputText); //converts string to integer

                if (!numbers.Contains(number)) //Checks if the number is in the list, if not adds it to the list
                    numbers.Add(number);
            }

            //String Join converts the list of numbers into a string
            Console.WriteLine("Unique numbers entered: " + string.Join(", ", numbers));

            //Question3E
            //Program to ask the user to supply a list of comma separated numbers
            //This program asks for numbers, splits the numbers apart and then converts the words into real numbers
            //Then picks the first number as the biggest and checks every number one by one
            Console.WriteLine("Enter a set of numbers separated by a comma:");
            string numberInput = Console.ReadLine();

            string[] splitNumbers = numberInput.Split(',');
            int[] convertedNumbers = Array.ConvertAll(splitNumbers, int.Parse);

            int maxNumber = convertedNumbers[0]; // assigns the largest number to the element at index 0

            foreach (int nums in convertedNumbers) //compares each number to the element at index 0 and then displays the largest number
            {
                if (nums > maxNumber)
                {
                    maxNumber = nums;
                }
            }
            Console.WriteLine("The maximum number is: " + maxNumber);

            //Question4
            //Question4A
            //Program to check for a few numbers separated by a hyphen and checks if they are consecutive
            //
            Console.Write("Enter numbers separated by hyphens: ");
            var input = Console.ReadLine();
            var sequenceNumbers = input.Split('-').Select(int.Parse).ToList(); //this splits the numbers and converts them into real numbers

            for (int i = 0; i < sequenceNumbers.Count; i++) //checks if the numbers are consecutive
            {
                // This code prevents out of range errors
                if (i == sequenceNumbers.Count - 1)
                    break;

                if (sequenceNumbers[i] + 1 != sequenceNumbers[i + 1]) //compare each number with the next one
                {
                    Console.WriteLine("Not consecutive");
                    return;
                }
            }
            Console.WriteLine("Consecutive");

            //Question4B
            //Program to enter numbers separated by hyphen and exits the program when the user presses enter and checks for duplicates
            Console.Write("Enter numbers separated by hyphens: ");
            var numberSequence = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(numberSequence)) //if the user presses enter without typing anything, the program will stop
            {
                return;
            }
            var numberList = numberSequence.Split('-').Select(int.Parse).ToList(); //this line splits the input and converts it to numbers

            //this line checks for duplicates and compares the total numbers entered and unique numbers only
            Console.WriteLine(numberList.Count != numberList.Distinct().Count() ? "Duplicate" : "No Duplicates");

            //Question4C
            //Program to ask the user for a time in 24 hour format, if the time is valid, displays Ok
            Console.Write("Enter time in 24-hour format (HH:MM): ");
            var timeInput = Console.ReadLine();
            //this line converts the text into a time value
            //It also ensures the time is within a 24 hour period (24 hours = 1440 minutes)
            if (TimeSpan.TryParse(input, out TimeSpan time) && time.TotalMinutes < 1440) 
                Console.WriteLine("Ok");
            else
                Console.WriteLine("Invalid Time");

            //Question4D
            //Program to ask for a few words separated by a space and make sure the program is not dependent on the input
            Console.Write("Enter words separated by space: ");
            var words = Console.ReadLine().ToLower().Split(' '); //this splits the sentence into an array of words and converts it to lowercase
            //loops through each word in words
            //capitalizes the first letter of each word
            //takes the remaining letters of the word
            //It then joins all the words
            var pascalCase = string.Join("", words.Select(w => char.ToUpper(w[0]) + w.Substring(1)));
            Console.WriteLine(pascalCase);

            //Question4E
            //Program to count the number of vowels in a word
            Console.Write("Enter an English word: ");
            var inputString = Console.ReadLine().ToLower();//converts the input to lowercase
            //count the number of vowels 
            int count = inputString.Count(c => "aeiou".Contains(c));
            //prints the vowel count
            Console.WriteLine($"Vowel count: {count}");

            //Question5
            //Question5A
            //Program to read a text file and display the number of words in the file
            Console.Write("Enter file path: ");
            var filePath = Console.ReadLine();
            //This checks if the file exists and splits the string into an array of words using spaces, new lines and tabs
            //.Length here also gets the total number of words in the filw
            if (File.Exists(filePath))
            {
                var wordCount = File.ReadAllText(filePath).Split(' ', '\n', '\t').Length;
                Console.WriteLine($"Word count: {wordCount}");
            }
            else
                Console.WriteLine("File not found");

            //Question5B
            //Program to read a text file and display the longest word in the text file
            Console.Write("Enter file path: ");
            var fileLocation = Console.ReadLine();
            //This code checks if the file exists, splits it and then orders it by descending order of length
            //The .First gets the first word from the sorted list
            if (File.Exists(fileLocation))
            {
                var longestWord = File.ReadAllText(fileLocation).Split(' ', '\n', '\t').OrderByDescending(w => w.Length).First();
                Console.WriteLine($"Longest word: {longestWord}");
            }
            else
                Console.WriteLine("File not found");

        }
    }
}
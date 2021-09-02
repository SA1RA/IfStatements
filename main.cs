//scroll down until you see the comments
//with instructions of what to do
using System;

namespace ComparisonOperators
{
	class Program
	{
		static void Main(string[] args)
		{
			//DO NOT CHANGE
			int numberOfKittens = 5;
			int numberOfPuppies = 10;
			int numberOfAnimals = numberOfKittens + numberOfPuppies;
			bool isRaining = true;
			bool ownUmbrella = true;
			bool powerOn = false;
			bool lightWorks = false;
			bool takeFlashlight = false;
			string firstName = "Marc";
			string secondName = "Tucker";

			////////////////////////////////////////
			//////COMPARISON OPERATOR PRACTICE//////
			////////////////////////////////////////

			//INSTRUCTIONS: Part 1
			//Below are a number of statements.
			//If you hit play, you will notice that some of them are returning as TRUE and some of them are returning as false.
			//Change the COMPARISON OPERATOR ONLY To make ALL Statements TRUE
			Console.WriteLine("Answer1: " + (numberOfKittens == 5));
			Console.WriteLine("Answer2: " + (numberOfPuppies == numberOfKittens));
			Console.WriteLine("Answer3: " + (numberOfPuppies > 10));
			Console.WriteLine("Answer4: " + (numberOfAnimals == 14));
			Console.WriteLine("Answer5: " + (firstName == "Marc"));
			Console.WriteLine("Answer6: " + (secondName == "tucker"));
			Console.WriteLine("Answer7: " + (powerOn == takeFlashlight));
			Console.WriteLine("Answer8: " + (lightWorks == false));

			//INSTRUCTIONS: Part 2
			//Below are a number of if statements.
			//If you hit play, you will see which statements are being printed to the console.
			//Before each if statement you will see what the expected output is.  Change the COMPARISON OPERATORS ONLY to get the expected outputs.

			//////IF DRILL ONE//////
			Console.WriteLine("IF DRILL ONE");
			//Expected Output:  "I want to keep them all!"
			if(numberOfKittens == 5)
			{
				Console.WriteLine("Correct: I want to keep them all!");
			}
			else
			{
				Console.WriteLine("Incorrect: Please sell some cats!!!!");
			}

			//////IF DRILL TWO//////
			Console.WriteLine("IF DRILL TWO");
			//Expected Output: "Take an Umbrella"
			if(isRaining)
			{
				Console.WriteLine("Correct: Take an Umbrella");
			}
			else if(ownUmbrella)
			{
				Console.WriteLine("Incorrect: Don't Take an Umbrella");
			}

			//////IF DRILL THREE//////
			Console.WriteLine("DRILL THREE");
			//Expected Output: Take a Flashlight
			if(!powerOn && !lightWorks)
			{
				Console.WriteLine("Correct: Take a flashlight");
			}
			else
			{
				Console.WriteLine("Incorrect: Don't take a flashlight");
			}

			//////BONUS DRILL//////
			int temp = 20;
			bool isSnowing = false;
			bool ownJacket = true;
			float timeToLeave = 4;

			//Only change one thing
			//The question should match the values above
			//Expected Output: The only available statement
			if( (temp < 32 && !isSnowing) && (ownJacket && timeToLeave > 2.5f) )
			{
				Console.WriteLine("The temp is less than 32 degrees but it isn't snowing.  You have enough time so put your jacket on.");
			}
		}
	}
}
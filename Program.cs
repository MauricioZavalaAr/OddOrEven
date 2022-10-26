//works well! nice data validation! ~Liz
bool playAgain = true;
bool validResponse = true;
string UAnswer;
while(playAgain == true) 
{
// start
int number1;
bool isNumber;

do{

Console.Write("Enter a number, we will tell you if its odd or even: ");

isNumber = int.TryParse(Console.ReadLine(), out number1);
if(isNumber==false)
{
    Console.WriteLine("Enter valid data,");
}

}while(isNumber==false);

if(number1 % 2 == 0)
{
    Console.WriteLine("Your number is 'even'.");
}
else
{
    Console.WriteLine("Your number is 'odd'.");
}



validResponse = true;
while(validResponse == true) 
     {
        Console.Write("Do you want to play again? (Y/N): "); 
        UAnswer = Console.ReadLine().ToUpper();
        if (UAnswer == "Y")
        {
            playAgain = true;
            validResponse = false; 
        }
        else if (UAnswer == "N") 
        {
            playAgain = false; 
            validResponse = false; 
        }
        else 
        {
        validResponse = true; 
        playAgain = false; 
        Console.WriteLine(UAnswer + " is not a valid response. Enter a response again");
        }
    }
Console.WriteLine("Thank you for playing!"); 
}



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("test");
Console.WriteLine("nu ska gamla master heta main");

//Gameplay (evelinas del)
//Kommer ut random nummer mellan 1 till 100
Random random = new Random();
int guessNumber = random.Next(1, 100);

//text skrivs ut att användaren ska gissa ett nummer mellan 1 till 100
//Visas en gång i början, därefter högre/lägre meddelanden
Console.WriteLine("Guess a number between 1 and 100");
while (true)
{
//Användaren fyller i nummer
    int userGuessed = int.Parse(Console.ReadLine()!);

//Om talet är rätt kommer följande text ut och loopen bryts
if (userGuessed == guessNumber)
{
    Console.WriteLine("Congratulations, you've won!");
    break;
}
//Om användaren gissar på ett för lågt tal och loopen fortsätter
if (guessNumber > userGuessed)
{
    Console.WriteLine("The number is higher");
    continue;
}
else
//Om användaren gissar på ett för högt tal och loopen fortsätter
{
    Console.WriteLine("The number is lower");
    continue;
}
}
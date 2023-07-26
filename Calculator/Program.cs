using System.Net.WebSockets;




    Console.WriteLine("Hey let's calculate stuff!");


var userChoice = "";
while (userChoice != "E" || userChoice != "e")
{

    Console.WriteLine("First number:");
string a = Console.ReadLine();
int numberA = int.Parse(a);


Console.WriteLine("Second number:");
string b = Console.ReadLine();
int numberB = int.Parse(b);

Console.WriteLine("You choose the numbers: " + numberA + " and number: " + numberB);

Console.WriteLine("Now, tell me. What you want to do with them?");


Console.WriteLine("[M]ultiply");
Console.WriteLine("[D]ivide");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[E]xit");


    //função
    void PrintFinalEquiation(
    int numberA, int numberB, int result, string @operator)
    {
        Console.WriteLine("The result of " + numberA + " " + @operator + " " + numberB + " equals to: " + result);
    }


    //refatorando para aceitar maiusculo e minusculo
    bool UpperOrLowerCase(string upper, string lower)
    {
        return upper.ToUpper() == lower.ToUpper();
    }

    userChoice = Console.ReadLine();
if (UpperOrLowerCase(userChoice, "M"))
    {
        var multiplication = numberA * numberB;
        PrintFinalEquiation(numberA, numberB, multiplication, " * ");
   

}

else if (UpperOrLowerCase(userChoice, "D"))
    {   var division = numberA / numberB;
        PrintFinalEquiation(numberA, numberB, division, " / ");
        


    } else if (UpperOrLowerCase(userChoice, "A"))


    {
        var addition = numberA + numberB;
        PrintFinalEquiation(numberA, numberB, addition, " + ");
        


    } else if (UpperOrLowerCase(userChoice, "S"))
    {
        var subtraction = numberA - numberB;
        PrintFinalEquiation(numberA, numberB, subtraction, " - ");
        
    }
 
}




Console.ReadKey();

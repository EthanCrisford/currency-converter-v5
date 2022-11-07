
float usersnumber;
string numberAsText;
string currency;
float conversionRate = 0;
string output;
bool onExit = false;


while (onExit == false)
{

    // get currency type
    Console.WriteLine("Which currency would you like?");
    currency = Console.ReadLine();
    //output = Console.ReadLine();
      //output = output.ToLower();
    

    if (currency == "EUR")
    {
        conversionRate = 1.15f;
    }

    if (currency == "USD")
    {
        conversionRate = 1.16f;
    }

    //Japansese Yen 
    if (currency == "JPY")
    {
        conversionRate = 0.00060f;
    }

    //Swiss Francs 
    if (currency == "CHF")
    {
        conversionRate = 1.13f;
    }

    //Indian Rupees
    if (currency == "INR")
    {
        conversionRate = 0.011f;
    }

    if (currency == "RUB")
    {
        conversionRate = 0.014f;
    }
    

    Console.WriteLine("Enter amount in GBP for exchange");

    numberAsText = Console.ReadLine();

    //readline numbers are always in string format (numbersAsText), converts to float.
    usersnumber = float.Parse(numberAsText);

    Console.WriteLine("You entered " + usersnumber + " GBP");

    //takes the number the user put in and multipies it by 0.88 as thats the value of the euro to pound.
    usersnumber = usersnumber / conversionRate;

    //outputs number after calculation.
    Console.WriteLine(currency + "  " + usersnumber);

    Console.WriteLine("Press X to quit or Enter to try again");

    output = Console.ReadLine();

    output = output.ToLower();

    if (output == "x")
    {
        onExit = true;
    }
}

//Main to Test the class VSum(Validation Summary)
Console.WriteLine("Text Validation\n");
int xi = 0;//counter for menu loop
while(xi == 0)
{
    string selectMenu;
    string text;
    //Display menu
    Console.WriteLine("1 - Acquire User input");
    Console.WriteLine("2 - Null input, Initialise default constructor");
    Console.WriteLine("3 - Exit");
    Console.Write("\nEnter menu command: ");
    selectMenu = Console.ReadLine();//get user input
    //var sm = Console.ReadLine();

    if (selectMenu == "1")
    {       
        //Console.WriteLine("Test 1: manual user input");//receive input from user.
        Console.Write("Enter text to validate: ");
        text = Console.ReadLine(); //Receive input as text
        VSum valsum = new VSum(text); //Create a new object of class VSum with text

        //Display Summary of text
        //The summary will display what variable types are applicable according to the received text
        Console.WriteLine(valsum.displaySummary());
        //This is the standard getType, which will always return the current variable type, in this case text(string)
        Console.WriteLine("Conditional GetType(): " + text.GetType());
        Console.WriteLine();
        //var dynVar = valsum.getDynamicType();
        //Console.WriteLine(valsum.getDynamicType())
        
    }
    if (selectMenu == "2")
    {
        //Test with an empty constructor, using default hardcoded testing text("Jackson@237")
        VSum valsum2 = new VSum();//pass no paramaters
        Console.WriteLine(valsum2.displaySummary());
        Console.WriteLine();
    }
    if (selectMenu == "3") xi++;//Exit
}




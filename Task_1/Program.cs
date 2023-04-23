Console.Write("Input a square: ");
int input_square = Convert.ToInt32(Console.ReadLine());
Console.Write("Now input a number: ");
int input_number = Convert.ToInt32(Console.ReadLine());

if(input_number * input_number == input_square)
{
    Console.WriteLine("That's it.");
}
else
{
    Console.WriteLine("Nay! Wrong data.");
}

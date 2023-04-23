Console.Write("Enter your number: ");
int user_input = Convert.ToInt32(Console.ReadLine());

for(int i = 2; i < user_input; i += 2)
{
    Console.Write(i);
    Console.Write(" ");
} 

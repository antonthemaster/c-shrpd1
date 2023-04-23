
int user_number = Convert.ToInt32(Console.ReadLine());
if(user_number == 0) Console.WriteLine("0");
else
{
    if(user_number > 0)
    {
        int invert_number = user_number * -1;
        int i = invert_number;
        while(i != user_number)
        {
            Console.WriteLine(i);
            i++;
        }
        Console.WriteLine(i);
    }
    else
    {
        int invert_number = user_number * -1;
        int i = user_number;
        while(i != invert_number)
        {
            Console.WriteLine(i);
            i++;
        }   
        Console.WriteLine(i);
    }
}


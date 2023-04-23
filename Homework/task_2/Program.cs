Console.Write("Please, enter first number: ");
int fst_item = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int scd_item = Convert.ToInt32(Console.ReadLine());

if(fst_item > scd_item | fst_item == scd_item) Console.WriteLine(fst_item);
else 
    Console.WriteLine(scd_item);

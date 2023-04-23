Console.Write("Please, enter first number: ");
int fst_item = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int scd_item = Convert.ToInt32(Console.ReadLine());
Console.Write("Now Enter third number: ");
int trd_item = Convert.ToInt32(Console.ReadLine());

if(fst_item > scd_item  & fst_item > trd_item) Console.WriteLine(fst_item);
else if (scd_item > fst_item  & scd_item > trd_item) Console.WriteLine(scd_item);
else if (trd_item > fst_item  & trd_item > scd_item) Console.WriteLine(trd_item);
else Console.WriteLine(fst_item);

int num, sum = 0, temp, rem;
Console.WriteLine("Enter the Number : ");
num = int.Parse(Console.ReadLine());

temp = num;
while (num > 0)
{
    rem = num % 10;
    sum = sum +( rem * rem * rem);
    num = num / 10;
}
if (temp == sum)
{
    Console.WriteLine("Armstrong Number");
}
else
{
    Console.WriteLine("Not Armstrong Number");
    Console.ReadLine();
}

int sum = 0;
int count = 0;

while (true)
{
    Console.Write("number 0 to stop: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num == 0)
    {
        break;
    }

    sum = sum + num;
    count = count + 1;
}

if (count == 0)
{
    Console.WriteLine("no numbers");
}
else
{
    double average = (double)sum / count;
    Console.WriteLine("count: " + count);
    Console.WriteLine("sum: " + sum);
    Console.WriteLine("average: " + average.ToString("0.00"));
}
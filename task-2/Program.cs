#region
//int num = Convert.ToInt32(Console.ReadLine());
//int biggest_num = 0;

//while ( num > 0)
//{
//    if ( num % 10 > biggest_num)
//    {
//        biggest_num = num % 10;
//    }
//    num = (num-num%10)/10;
//}
//Console.WriteLine(biggest_num);
#endregion

#region
int num = Convert.ToInt32(Console.ReadLine());
int power = 0;
int eded = 1;

while (eded*2 <= num)
{
    eded *= 2; 
    power++;
}

Console.WriteLine(power);
#endregion
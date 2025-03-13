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
//int num = Convert.ToInt32(Console.ReadLine());
//int power = 0;
//int eded = 1;

//while (eded*2 <= num)
//{
//    eded *= 2; 
//    power++;
//}

//Console.WriteLine(power);
#endregion

#region
//int[] array = { 6, 3, 9, 11, 15, 8 };
//int max = array[0];
//int min = array[0];

//for (int i=1; i<array.Length; i++)
//{
//    if (array[i] > max)
//    {
//        max = array[i];
//    }
//    if (array[i] < min)
//    {
//        min = array[i];
//    }
//}
//Console.WriteLine(max+min);
#endregion

#region
int[] array = { 4, 6, 9, 12, 1, 43, 67, 99 };
int count = 0;

for (int i=0; i<array.Length; i++)
{
    if (array[i] % 2 == 0 && array[i] % 3 == 0)
    {
        count++;
    }
}
Console.WriteLine(count);
#endregion
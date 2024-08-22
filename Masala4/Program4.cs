int a;
Console.WriteLine("miqdorlar nechta:");
a=int.Parse(Console.ReadLine());
int[] array=new int[a];
Console.WriteLine("Qiymatlarni kiriting:");
for(int i=0;i<array.Length;i++)
{
    Console.WriteLine((i+1)+"-qiymatnikiriting:");
    array[i]=int.Parse(Console.ReadLine());
}
int sum=0;
for(int i=0;i<array.Length;i++)
{
    sum=sum+array[i];
}
Console.WriteLine(sum);
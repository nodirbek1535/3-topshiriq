int a;
Console.WriteLine("sonni kiriting:");
a=int.Parse(Console.ReadLine());
int[] array={2,3,4,5,6,7,8,9,10};
for(int i=00;i<array.Length;i++)
{
    if(a%array[i]!=0)
    {
        array[i]=0;
    }
    else{continue;}
}
Console.WriteLine();
Console.Write("Boluvchilarri:");
for(int i=0;i<array.Length;i++)
{
    if(array[i]>0)
    {
        Console.Write("  "+array[i]);
    }
}
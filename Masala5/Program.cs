int a;
Console.WriteLine("sonni kiriting:");
a=int.Parse(Console.ReadLine());
int xona = a.ToString().Length;
int[]arr= new int[xona];
int k = 0;
for (int i = 1; i <=xona; i++)
{
    arr[k]=(a%((int)Math.Pow(10,i)) - a%((int)Math.Pow(10, i-1))) / (int)Math.Pow(10,i-1);
    k++;
}
int sum=0;
for (int i = 0; i < arr.Length; i++) 
{
    sum=sum+(int)Math.Pow(arr[i],xona);
}
if(sum==a)
{
  Console.WriteLine($"{a} soni Armstrong son");
}
else{Console.WriteLine($"{a} soni Armstrong son emas");}


//tub sonni aniqlash
int a;
int k=0;
Console.WriteLine("sonni kiriting:");
a=int.Parse(Console.ReadLine());
for(int i=1;i<=a;i++)
{
   if(a%i==0)
   {
    k++;
   }
   else{continue;}
}
if(k<=2 && a!=1)
{
    Console.WriteLine("tub son");
}
else{
    Console.WriteLine("tub emas");
}
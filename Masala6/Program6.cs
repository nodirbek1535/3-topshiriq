Console.Write("Son kiriting: ");
int son = int.Parse(Console.ReadLine());
int sifatliBoluuvchiSoni = 0;
for (int i = 2; i < son; i++)
{
 if (son % i == 0) // Agar qoldiqsiz bo'linsa
 {
   sifatliBoluuvchiSoni++;
 }
}
Console.WriteLine(sifatliBoluuvchiSoni);
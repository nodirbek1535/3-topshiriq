int a,b;
Console.WriteLine("sonni kiriting=");
a=int.Parse(Console.ReadLine());
Console.WriteLine("darajani kiriting (musbat son bolishi kerak)=");
b=int.Parse(Console.ReadLine());
int natija=1;
do{
if(b<0){
    Console.WriteLine("siz manfiy darrjani kiritdingiz iltimos musbat son kiriting=");
    b=int.Parse(Console.ReadLine());
    
}
}while(b<0);
if(b==0)
{
    Console.WriteLine(1);
}
else{
    for(int i=0;i<b;i++){
        natija*=a;
    }Console.WriteLine(natija);
} 
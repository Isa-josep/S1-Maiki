using System;
public class Program{
    static long f(int n){
        if(n == 0)
            return 1;
        return n * f(n - 1);
    }
    public static void Main(){
        Console.Clear();
        List<long> b=new List<long>();
        long r=0;
        while (true){
            int a;
            Console.WriteLine("Ingrese un numero ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a==0){
                break;
            }
            int aux=a,c=1;
            while (aux>0){
                int n=aux%10;
                aux/=10;
                long fac= f(c),ans;
                ans=fac*n;
                r+=ans;
                c++;
            }
            b.Add(r);
            r=0;
        }
        foreach(int i in b){
            Console.WriteLine(i+" ");
        }
    }
}

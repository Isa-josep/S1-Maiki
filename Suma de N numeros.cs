using System;
public class Program{
    public static void Main(){
        Console.Clear();
        int a=-1,ans=0;
        while(a!=0){
            Console.WriteLine("Ingrese un numero ");
            a=Convert.ToInt32(Console.ReadLine());
            ans+=a;
        }
        Console.Write($"La suma de los numeros es {ans}");
    }
}

using System;
public class Program{
    public static void Main(){
      Console.Clear();
        int a,b,c,ans;
        Console.WriteLine("Ingresá un número: ");
        a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresá otro número:");
        b=Convert.ToInt32(Console.ReadLine());
        ans=a+b;
        Console.WriteLine($"Suman: {ans}");
        Console.WriteLine("Ingresá un nuevo numero");
        c=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Multiplicación de la suma por el último número: "+ans*c);
    }
}

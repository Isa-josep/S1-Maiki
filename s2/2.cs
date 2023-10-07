using System;
public class Program{
    public static void Main(){
      Console.Clear();
        float a,ans;
        int b;
        Console.WriteLine("Ingrese el primer valor Decimal");
        a=Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo valor Entero");
        b=Convert.ToInt32(Console.ReadLine());
        ans=a+b;
        Console.WriteLine($"LA suma de {a} + {b} es {ans}");
    }
}

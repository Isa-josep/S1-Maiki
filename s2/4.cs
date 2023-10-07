using System;
public class Program{
    public static void Main(){
      Console.Clear();
        decimal a,b,ans;
        Console.WriteLine("Kilómetros recorridos: ");
        a=Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Litros de combustible gastados: ");
        b=Convert.ToDecimal(Console.ReadLine());
        ans=a/b;
        Console.WriteLine($"El consumo por kilómetro es de {ans}");
    }
}

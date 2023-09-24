using System;
public class Program{
    public static void Main(){
      Console.Clear();
        int a,b,d;
        Console.WriteLine("ingrese horas laboradas");
        a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese salario por hora ");
        b=Convert.ToInt32(Console.ReadLine());
        d=a*b;
        Console.WriteLine("Ganaras por dia "+(d)+"\nganas por semana "+(d*7)+"\nganas por mes "+(30*d)+"\nganas por año "+(365*d));
    }
}

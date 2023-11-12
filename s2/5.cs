using System;
public class Program{ 
    public static void Main(){
        Console.Clear();
        float a,s=0;
        Console.WriteLine("Ingrese la temperatura en grados Farenheit");
        a=Convert.ToSingle(Console.ReadLine());
        s=(5f/9f)*(a-32);
        Console.WriteLine($"Los grados son {s}");
    }
}

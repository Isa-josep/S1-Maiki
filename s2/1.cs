using System;
public class Program{
    static void sal(string a){
        Console.WriteLine($"Ahora estás en la matrix, {a}");
    }
    public static void Main(){
      Console.Clear();
        string a;
        Console.WriteLine("Ingrese el nombre de usuario");
        a=Convert.ToString(Console.ReadLine());
        sal(a);
    }
}

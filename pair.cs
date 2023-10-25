using System;
public class Program{
    public class Pair<T1, T2>{
    public T1 First { get; set; }
    public T2 Second { get; set; }
    public Pair(T1 first, T2 second){
        First = first;
        Second = second;
    }
}
    public static void Main(){
        Console.Clear();
        int a;
        string name ;
        a=Convert.ToInt32(Console.ReadLine());
        name=Convert.ToString(Console.ReadLine());
        Pair<int, string> myPair = new Pair<int, string>(a, name);
        Console.WriteLine($"Edad: {myPair.First}, Nombre: {myPair.Second}");
    }
}

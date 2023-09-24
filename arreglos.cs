using System;
public class Program{
    public static void Main(){
      Console.Clear();
        int a,b;
        Console.WriteLine("Ingrese el tamaño del arreglo");
        a=Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[a];//Declaramos un arreglo de tipo entero de tamaño "A" si se le quiere dar un tamaño sustituir a por el numero 
        for(int i=0;i<a;i++){// declaramos un for para llenar el arrreglo que va desde 0 hasta a-1 en este caso 
          b=Convert.ToInt32(Console.ReadLine());//pedimos una variable en este caso es "b"
          arr[i]=b;//Esta linea dice que lo que esta en b se mete en el indice de i, ejemplo si si b es 5 arr[0] es 5 y asi hasta que se cumpla el for 
        }
        foreach(int i in arr){// utlizamos el foreach "hack" para imprimir el arreglo, declaramos una variable luego le damos el nombre del arreglo
          Console.WriteLine(i);// aqui imprimimos i que va a iterar todo el arreglo
        }
    }
}
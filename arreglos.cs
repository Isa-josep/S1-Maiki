using System;
public class Program{
    public static void Main(){
      Console.Clear();
        int a,n;
        a=Convert.ToInt32(Console.ReadLine());
        List<int> b = new List<int>();// ahora toca vectores o listas, esta madre es muy similar al arreglo solo que mas pro 
        for(int i=0;i<a;i++){//la misma madre para rellenar, un for y queda 
          n=Convert.ToInt32(Console.ReadLine());
          b.Add(n);//solo que aqui utilisamos el nombre dle vector/lista y .Add(elem)
        }
        b.Sort();// una ventaja de los vectores/listas es que se pueden ordenar de una foma muy facil, aqui la pruba 
        foreach(int i in b){// i para imprimir lo mismo 
          Console.Write(i+" ");
        }
    }
}

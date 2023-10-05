using System;
class Program{
    static void Main(){
        /*String 
        ¿Que son??
        Una cadena de caracteres, o string es un tipo de dato que se utiliza para representar texto o secuencias de caracteres
        */
        string nombre; // Se declara la string 
        nombre=Convert.ToString(Console.ReadLine()); //leemos la string 
        Console.WriteLine($"hola {nombre}");
        /*
        NOTA
        Las string son caracteres por lo que si queremos hacer algon tipo de operacion solo se concadenaran
        ejemplo si tenemos una string a=2 y una string b=2 y quesemos hacer una suma, el resultado resa 22
        */

        /*Las string tienen metodos los cuales son*/
        Console.WriteLine(nombre.Length); //Length te regresa el tamaño de la string  puedes hacer int tam=nombre,Length "Tambien cuneta espacios y caracteres especiales"
        // ToUpper() esto convertira la string a mayusculas 
        string mayusculas = nombre.ToUpper();
        Console.WriteLine(mayusculas); // la string pero en mayuscula

        //ToLower() lo mismo que ToUpper() pero en minuscula 
        string min = nombre.ToLower();
        Console.WriteLine(min);
        
        //para iterar una string se utiliza un ciclo for que va desde 0 hasta lengt-1
        for(int i =0;i<nombre.Length;i++){
            Console.Write(nombre[i]);
        }
        Console.WriteLine();
        // o se puede hacer con un foreach que es pa pros
        foreach(char i in nombre){
            Console.WriteLine(i+" ");
        }
    }
}

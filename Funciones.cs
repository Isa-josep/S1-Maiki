using System;
class Program{
    /*  FUNCIONES 
    ¿QUE SON ?
    SON FRACMENTOS DE CODIGO QUE SE PUEDEN USAR EN CUARQUIER PARTE DE CODIGO, ESTAS SE UTILIZAN PARA HACER EL CODIGO 
    MAS CLARO, Y TAMBIEN PARA NO REPETIR FRACMENTOS DE CODIGO QUE SE PUEDAN LLEGAR A USAR MAS DE UNA VEZ 
    */


    //Para crear una funcion se necesita el tipo de dato y los parametros que va a recibir 
    //ejemplo esta es una funcion de tipo entero que recibe 2 parametros enteros a y b, y retorna la suma de los dos. 
    //TODAS LAS FUNCIONES TIENEN QUE RETORNAR ALGO 
    // EXEPTO LAS FUNCIONES VOID 
    static int Sumar(int a,int b){ 
        return a+b;
    }
    static void Saludar(string name){// esta es una funcion de tipo void "vacia" esta funcion puede o no tener parametros
        Console.WriteLine("Hola "+name);
    }
    static void Main(){
        int a,b;
        Console.WriteLine("Ingrese el valor de A");
        a= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el valor de B");
        b= Convert.ToInt32(Console.ReadLine()); 
        //para llamar/usar la funcion se hace de la siguiente manera nombre de la funcion y entre "()" los parametros que se usaran separados por una coma
        Console.WriteLine("La suma de los dos valores es "+Sumar(a,b)); //aqui estamos utlizando la funcion para sumar 
        

          // una string o cadena de caracteres es un tipo de dato que se utiliza para representar texto esto lo explicare mejor en el Tema String 
        string nombre = Convert.ToString(Console.ReadLine());
        Saludar(nombre);
    }
}

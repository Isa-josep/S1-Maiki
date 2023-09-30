using System;
public class Program{
    struct RandomNumber{
    public int r1, r2;
    public int t,t1;
    }
    static void RellenarMTX(char[,] matriz, int M,int N ){
        for (int i = 0; i < M; i++){
            for (int j = 0; j < N; j++){
                matriz[i, j] = 'X';
            }
        }
    }
    static void AñadirBarcos(char[,] matriz, int M,int N, int L,int R){
      if (L >= 0 && L < M && R >= 0 && R < N){
            matriz[L, R] = 'B'; // consideramos que agregara parametros validos
        }
        else{
          Console.WriteLine("Imposible esas coordenadas no existen");
        }
    }

    static bool searchB(char[,] matriz, int M,int N, int L,int R){
        if (L >= 0 && L < M && R >= 0 && R < N){
            if(matriz[L,R]=='B'){
                return true;
            } // consideramos que agregara parametros validos
        }
        return false;
    }
    
    public static void Main(){
      Console.Clear();
      Console.ResetColor();
        int M,N,MAXv,lifep,lifepc,L,R;
        Random random = new Random();
        Console.WriteLine("Ingrese la cantidad de filas del tablero ");
        M=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de columnas del tablero ");
        N=Convert.ToInt32(Console.ReadLine());
        MAXv = (int)Math.Round((N * M) * 0.20);//calcular el maximo de barcos 
        char [,] mtx1=new char[M,N]; //matriz del jugador 
        char [,] mtx2=new char[M,N];// matriz de la pc
        RellenarMTX(mtx1,M,N);//Rellenamos la matriz del jugador 
        RellenarMTX(mtx2,M,N);//rellenamos la matriz de la pc
        lifep=MAXv;
        lifepc=MAXv;
        Console.WriteLine("Felicidades tienes "+MAXv+" barcos");
        List<RandomNumber> rep = new List<RandomNumber>();
        List<RandomNumber>repM = new List<RandomNumber>();
        for(int i=1;i<=MAXv;i++){ 
            Console.WriteLine("Ingresa la posision 'Y' en la que quiere agregar un barco");
            L=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la posision 'X' en la que quiere agregar un barco");
            R=Convert.ToInt32(Console.ReadLine());
            AñadirBarcos(mtx1,M,N,L,R); //agregamos los barcos
            int randomNumbeL, randomNumbeR;
            do{
                randomNumbeL = random.Next(0, M);
                randomNumbeR = random.Next(0, N);
            } while (rep.Contains(new RandomNumber { r1 = randomNumbeL, r2 = randomNumbeR }));
            rep.Add(new RandomNumber { r1 = randomNumbeL, r2 = randomNumbeR });
           AñadirBarcos(mtx2,M,N,randomNumbeL,randomNumbeR);
            Console.WriteLine("Tiene "+ (MAXv-i) +" barcos");
        }

        /*
        Las matriz de la comptupadora no se mostrara solo es para debugear 
        tambien faltan mejorar cosas y optimizar otras 
        */
        
        for (int i = 0; i < M; i++){
            for (int j = 0; j < N; j++){
                Console.Write(mtx1[i, j] + " "); 
            }
            Console.WriteLine();
        }
        Console.WriteLine("matriz de la pc ");
        for (int i = 0; i < M; i++){
            for (int j = 0; j < N; j++){
                Console.Write(mtx2[i, j] + " "); 
            }
            Console.WriteLine();
        }

        foreach(RandomNumber item in rep){
            Console.WriteLine($"r1: {item.r1}, r2: {item.r2}");
        }
        while (lifep != 0 && lifepc != 0){
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t \t Tu turno !!!");
            Console.ResetColor();
            Console.WriteLine("Ingresa la posision 'Y' en la que quiere buscar un barco");
            L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la posision 'X' en la que quiere buscar un barco");
            R = Convert.ToInt32(Console.ReadLine());
            if (searchB(mtx2, M, N, L, R)){
                lifepc--;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t Felicidades encontraste un barco rival!!!");
                Console.ResetColor();
            }

            if (lifepc != 0){ 
                int randomNumbeL, randomNumbeR;
                do{
                    randomNumbeL = random.Next(0, M);
                    randomNumbeR = random.Next(0, N);
                } while (rep.Contains(new RandomNumber { t = randomNumbeL, t1 = randomNumbeR }));
                repM.Add(new RandomNumber { t = randomNumbeL, t1 = randomNumbeR });
                if (searchB(mtx1, M, N, randomNumbeL, randomNumbeR)){
                    lifep--;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t !!! Encontraron un barco tuyo, tienes " + lifep + " vidas.");
                    Console.ResetColor();
                }
            }
        }
        // El juego ha terminado porque uno de los jugadores se quedó sin vidas
        if (lifep == 0){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("¡Has perdido! El PC ha ganado.");
            Console.ResetColor();
        }
        else{
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡Has ganado! El PC se quedó sin vidas.");
            Console.ResetColor();
        }
    }
}

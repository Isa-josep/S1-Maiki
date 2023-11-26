using System;			
public class Program{
    public static void fore(int start , int end , Action<int> action){
        for(int i=start;i<end;i++){
            action(i);
        }
    }
    public static string Mayus(string s){
        string res="";
        fore(0,s.Length,i=>{
            if(i==0){
                res+=s[i].ToString().ToUpper();
            }else{
                res+=s[i].ToString().ToLower();
            }
        });
        return res;
    }
	public static void Main(){
        Console.Clear();
        int n,a=-1;
        string aux="";
        Console.WriteLine("Ingrese la cantidad de peliculas: "); 
        n=Convert.ToInt32(Console.ReadLine());
        List<string> NamePel=new List<string>();
         int [,,] mtx=new int[n,6,5];
        fore(0,n,i=>{
            Console.WriteLine($"Ingrese el nombre de la pelicula: {i+1}");
            aux=Console.ReadLine();
            aux=Mayus(aux);
            NamePel.Add(aux);
        });
        while(a!=0){
            Console.WriteLine(@"
1.- Mostrar peliculas
2.- Comprar Boletos
3.- Mostrar lugares disponibles");
            a=Convert.ToInt32(Console.ReadLine());
            if(a==1){
                Console.WriteLine("Peliculas: ");
                fore(0,n,i=>{
                    Console.WriteLine($"{i+1}.- {NamePel[i]}");
                });
            }
            else if(a==2){
                Console.WriteLine("Ingrese el nombre de la pelicula: ");
                aux=Console.ReadLine();
                aux=Mayus(aux);
                int pos=NamePel.IndexOf(aux);
                if(pos!=-1){
                    Console.WriteLine("Ingrese la cantidad de boletos: ");
                    int cant=Convert.ToInt32(Console.ReadLine());
                    if(cant<=30){
                        Console.WriteLine("Lugares disponibles: ");
                         for(int j=0;j<6;j++){
                            for(int k=0;k<5;k++){
                             Console.Write(mtx[pos,j,k]+" ");
                        }
                        Console.WriteLine();
                        }
                        fore(0,cant,i=>{
                            Console.WriteLine("Ingrese la fila: ");
                            int fila=Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese la columna: ");
                            int col=Convert.ToInt32(Console.ReadLine());
                            if(mtx[pos,fila-1,col-1]==0){
                                mtx[pos,fila-1,col-1]=1;
                                
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Boletos comprados");
                                Console.ResetColor();
                            }
                            else{
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("El lugar ya esta ocupado");
                                Console.ResetColor();
                            }
                        });
                    }
                    else{
                        Console.WriteLine("No se puede comprar mas de 30 boletos");
                    }
                }
                else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No existe la pelicula");
                    Console.ResetColor();
                }
            }
            else if(a==3){
                Console.WriteLine("Ingrese el nombre de la pelicula: ");
                aux=Console.ReadLine();
                aux=Mayus(aux);
                int pos=NamePel.IndexOf(aux);
                if(pos!=-1){
                    Console.WriteLine("Lugares disponibles: ");
                         for(int j=0;j<6;j++){
                            for(int k=0;k<5;k++){
                             Console.Write(mtx[pos,j,k]+" ");
                        }
                        Console.WriteLine();
                        }
                }else{
                    Console.WriteLine("No existe la pelicula");
                }
            }
        }
    }
}
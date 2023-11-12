using System;
class Program{
    static void Main(){
        string[] input = Console.ReadLine().Split();
        int n = Convert.ToInt32((input[0]));
        int l = Convert.ToInt32((input[1]));
        int[] b = new int[l];
        string[] values = Console.ReadLine().Split();
        for (int i = 0; i < n; i++){
            int w = int.Parse(values[i]);
            b[w - 1]++;
        }
        foreach (int count in b){
            Console.WriteLine(count);
        }
    }
}

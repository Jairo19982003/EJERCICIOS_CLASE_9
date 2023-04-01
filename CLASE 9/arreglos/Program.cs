/*String[] matriz()
{
    String[] nombre = new string[]
    {
        "Anderson", "Brandon", "Yeimi", "Fatima", "Vivian";

        
    
    foreach(String n in nombre)
{
    Console.WriteLine("nombre = " + n);
}
int[] notas = new int[]
{
    51, 80, 96, 76, 61
};

int promedio = 0;
foreach(int n in notas)
{
    promedio = promedio + n;
}
promedio = promedio / notas.Length;
Console.WriteLine("El promedio es =" + promedio);

}
matriz();*/


using System;

public class Program
{
    static void Main(string[] args)
    {
        string[] nombres = new string[]
        {
            "Anderson", "Brandon", "Yeimi", "Fatima", "Vivian"
        };

        int[] puntajes = new int[]
        {
            50, 90, 85, 73, 95
        };

        int puntajeMaximo = puntajes[0];
        int puntajeMinimo = puntajes[0];

        foreach (int puntaje in puntajes)
        {
            if (puntaje > puntajeMaximo)
            {
                puntajeMaximo = puntaje;
            }

            if (puntaje < puntajeMinimo)
            {
                puntajeMinimo = puntaje;
            }
        }

        Console.WriteLine("Los puntajes son: ");
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine(nombres[i] + " = " + puntajes[i]);
        }

        Console.WriteLine("El puntaje máximo es: " + puntajeMaximo);
        Console.WriteLine("El puntaje mínimo es: " + puntajeMinimo);
    }
}


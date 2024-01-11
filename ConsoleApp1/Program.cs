using System.Reflection.Metadata.Ecma335;

public class Valores
{
    public int valor1()
    {
        Console.WriteLine("Escriba el primero numero");
        int valor1 = int .Parse(Console.ReadLine());
        return valor1;
    }
    public int valor2()
    {
        Console.WriteLine("Escriba el segundo numero");
        int valor2 = int.Parse(Console.ReadLine());
        return valor2;
    }

}



public class Operaciones : Valores
{
    public int suma()
    {
      Valores instancia = new Valores();
    int numero1 = valor1();
    int numero2 = valor2();

    int resultadosuma = numero1 + numero2;
        return resultadosuma;
    }
    public int resta()
    {
        Valores instancia = new Valores();
        int numero1 = valor1();
        int numero2 = valor2();

        int resultadoresta = numero1 - numero2;
        return resultadoresta;
    }
    public int multiplicación()
    {
        Valores instancia = new Valores();
        int numero1 = valor1();
        int numero2 = valor2();

        int resultadomultiplicación = numero1 * numero2;
        return resultadomultiplicación;
    }
    public int división()
    {
        Valores instancia = new Valores();
        int numero1 = valor1();
        int numero2 = valor2();

        int resultadodivisión = numero1 / numero2;
        return resultadodivisión;
    }
}
public class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese su operación : suma(+), resta(-), multiplicación(*) división(/)");
        string operacioningresada = Console.ReadLine();

        Operaciones resultado = new Operaciones();

        switch (operacioningresada)
        {
            case "+":
                int resultadosuma = resultado.suma();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("tu resultado es " + resultadosuma);
                break;


            case "-":
                int resultadoresta = resultado.resta();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("tu resultado es " + resultadoresta);
                break;

            case "*":
                int resultadomultiplicación = resultado.multiplicación();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("tu resultado es " + resultadomultiplicación);
                break;
            case "/":
                int resultadodivisión = resultado.división();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("tu resultado es " + resultadodivisión);
                break;
        }
    }
}
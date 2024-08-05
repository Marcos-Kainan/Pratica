// na pratica II e possivel usar a linha de impressão para mostrar os resultadodo de x1 e x2
using System;// entrada para uso

class PraticaII{ // main do codigo

    static double[] zeros(double a, double b, double c){//função zero
        
        double[] z = new double[2];// declarção para vetor
        if(a != 0){ // se "a" for diferente de 0
        double delta = b * b - 4 * a * c; // calculo do delta

        if (delta >= 0) // condição para delta ser maior ou igual a 0
        { // condição para realizar o calculo de delta
            z[0] = (-b + Math.Sqrt(delta)) / 2 * a;// calculo de x1
            z[1] = (-b + Math.Sqrt(delta)) / 2 * a;// calculo de x2
        }
        }else{
           z[0] = z[1] = -c/b; // calculo de x1 e x2 
        }    
        return z;// retorno ou saida do valor amarzenado em z para main
    }
    public static void Main(string[] args){ // metodo principal
        double a,b,c;
        Console.WriteLine("digite o Valor de a:"); // imprimir na tela a função a ser realizada
        a = double.Parse(Console.ReadLine());// entrada de valor via teclado para A

        Console.WriteLine("digite o Valor de b:"); // imprimir na tela a função a ser realizada
        b = double.Parse(Console.ReadLine());// entrada de valor via teclado para B

        Console.WriteLine("digite o Valor de c:");// imprimir na tela a função a ser realizada
        c = double.Parse(Console.ReadLine()); //entrada de valor via teclado para C

        double[] z = zeros(a, b, c); // entrada de valor para a função zeros      
        for (int i = 0; i < 2; i++){ // condição de repetição para imprimir os valores de z
           Console.WriteLine("Resultado:"+ z[i] ); // impressão dos valores de z com texto
        }
    }
}
// para a primeira tentativa dessa pratica ocorreu um erro
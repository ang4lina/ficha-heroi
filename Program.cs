using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do personagem:");
        string nome = Console.ReadLine();

        int vida = 100;
        int moedas = 20;
        int nivel = 1;

        Console.WriteLine("\n FICHA DO PERSONAGEM ");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Vida: " + vida);
        Console.WriteLine("Moedas: " + moedas);
        Console.WriteLine("Nível: " + nivel);
        
    }
}

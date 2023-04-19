using System.Security.Cryptography;

Console.Clear();

Console.WriteLine(" --- Rolagem de Dado ---\n");

int faces, resultado;

Console.Write("Quantas faces do dado..:  ");
faces = Int32.Parse(Console.ReadLine()!);

Thread.Sleep(1000);

resultado = RandomNumberGenerator.GetInt32(1 , faces+1);

Console.Write($"\nNumero Sorteado: {resultado} ");
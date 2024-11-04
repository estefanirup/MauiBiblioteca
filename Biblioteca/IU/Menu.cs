using System;

namespace Biblioteca.IU;

public class Menu
{
    public static string Exibir() {
        System.Console.WriteLine("Bem vindo a Biblioteca X");
        System.Console.WriteLine("MENU PRINCIPAL");
        System.Console.WriteLine("==============");
        System.Console.WriteLine();

        System.Console.WriteLine("1. Exibir livros");
        System.Console.WriteLine("2. Alugar livros");
        System.Console.WriteLine("0. Sair");

        System.Console.WriteLine();
        System.Console.Write("Qual sua opção: ");

        return System.Console.ReadLine();
    }

}

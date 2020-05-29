using System;

namespace CpfCpnj_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF cpf = new CPF();
            cpf.nome = "Vinícius Miranda Baptista";
            System.Console.WriteLine(cpf.Saudar());

            cpf.cpf = "000.000.000-00";
            System.Console.WriteLine(cpf.ValidarCPF());

            
            // Adicionais
            System.Console.WriteLine("Digite seu nome:");
            cpf.nome= Console.ReadLine();
            Console.Clear();
            
            System.Console.WriteLine(cpf.Saudar());

            System.Console.WriteLine("Para vermos se seu cpf é verdadeiro utilizamos o método True or False, portanto digite seu cpf para confirmarmos:");
            cpf.cpf=Console.ReadLine();
            System.Console.WriteLine(cpf.ValidarCPF());
            
        }
    }
}

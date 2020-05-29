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

            cpf.nome= Console.ReadLine();
            
        }
    }
}

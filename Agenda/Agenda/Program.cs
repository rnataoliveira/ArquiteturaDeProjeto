using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 3)
            {
                Console.WriteLine("Digite a opção desejada. ");
                opcao = int.Parse(Console.ReadLine());
                AgendaTelefonica.selecionarOpcao(Convert.ToInt16(opcao));
                Console.WriteLine();
            }
        }
    }
}

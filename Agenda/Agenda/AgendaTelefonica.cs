using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class AgendaTelefonica
    {
        public static ICollection<Contato> listaTelefonica = new List<Contato>();

        public static void Adicionar()
        {
            Console.WriteLine("Digite o nome do contato: ");
            String Name = Console.ReadLine();
            Console.WriteLine("Digite o telefone do contato: ");
            String PhoneNumber = Console.ReadLine();

            bool exists = false;
            foreach (Contato c in listaTelefonica)
            {
                if ((Name.Equals(c.Name)) && (PhoneNumber.Equals(c.Phone)))
                {
                    exists = true;
                    Console.WriteLine("Este contato já existe na agenda.");
                }
            }
            if (!exists)
            {
                Contato contato = new Contato(Name, PhoneNumber);
                listaTelefonica.Add(contato);
                Console.WriteLine("Contato adicionado com sucesso.");
            }
        }

        public static void Buscar()
        {
            Console.WriteLine("Digite o nome do contato que deseja buscar: ");
            String SearchName = Console.ReadLine();
            foreach (Contato c in listaTelefonica)
            {
                if (SearchName.Equals(c.Name))
                {
                    Console.WriteLine("Nome: {0}", c.Name);
                    Console.WriteLine("Phone: {0}", c.Phone);
                }
                else
                {
                    Console.WriteLine("Contato não existe!");
                }
            }

        }

        public static void Sair()
        {
            Environment.Exit(Environment.ExitCode);
        }

        public static void selecionarOpcao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Adicionar();
                    break;
                case 2:
                    Buscar();
                    break;
                case 3:
                    Sair();
                    break;
            }
        }

    }
}

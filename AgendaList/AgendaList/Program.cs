using System;

namespace PList_Contact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaContato contatos = new ListaContato();
            int opc;

            void Menu()
            {
                Console.WriteLine("-_-_-_-_Menu Principal_-_-_-_-");
                Console.WriteLine("\n[1] - Inserir Contato" +
                                  "\n[2] - Mostrar Contatos" +
                                  "\n[3] - Remover Contato" +
                                  "\n[4] - Buscar Contato" +
                                  "\n[5] - Editar Contato" +
                                  "\n[6] - Fechar");
                Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
                //Testar Push

            }
            do
            {
                Menu();
                Console.Write("Opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        contatos.Puch(Insert());
                        break;
                    case 2:
                        contatos.Print();
                        break;
                    case 3:
                        contatos.Pop();
                        break;
                    case 4:
                        contatos.Seach();
                        break;
                    case 5:
                        contatos.Edit();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("\t\nFechado...");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\t\n>>>> Opção Digitada Inválida!! <<<<");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opc != 6);
        }
        static Contato Insert()
        {
            Console.Clear();
            ListaTelefone fone = new ListaTelefone();
            Console.WriteLine("-_-_-_-_-_Add Contact_-_-_-_-_-\n");
            Console.Write("Nome do Contato: ");
            string nome = Console.ReadLine();
            Console.Write("Email do Contato: ");
            string email = Console.ReadLine();

            string add = "s";
            do
            {
                Console.Write("\n>> Informações do Telefone <<\n\n");
                Console.Write("Qual o Tipo de Telefone: ");
                string tipo = Console.ReadLine();
                Console.Write("Qual o DDD: ");
                int ddd = int.Parse(Console.ReadLine());
                Console.Write("Número do Telefone: ");
                float numero = float.Parse(Console.ReadLine());

                Console.WriteLine("\nDeseja adicionar um novo Contato para {0}", nome);
                Console.WriteLine("\nSim - S\nNão - N");

                fone.Puch(new Telefone(tipo, ddd, numero));

                Console.Write("\nOpção: ");
                add = Console.ReadLine().ToLower();
            } while (add == "s");
            Console.Clear();
            return new Contato(nome, email, fone);
        }
    }
}

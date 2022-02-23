using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PList_Contact
{
    internal class ListaContato
    {
        public Contato Head { get; set; }
        public Contato Tail { get; set; }

        public ListaContato()
        {
            Head = Tail = null;
        }

        public void Ordenar()
        {
            for (Contato aux = Head; aux != null; aux = aux.Proximo)
            {
                for (Contato aux2 = aux.Proximo; aux2 != null; aux2 = aux2.Proximo)
                {
                    if (aux.Nome.CompareTo(aux2.Nome) == 1)
                    {
                        Contato aux3 = new Contato(aux.Nome, aux.Email, aux.Telefone);
                        aux.Nome = aux2.Nome;
                        aux.Email = aux2.Email;
                        aux.Telefone = aux2.Telefone;
                        aux2.Nome = aux3.Nome;
                        aux2.Email = aux3.Email;
                        aux2.Telefone = aux3.Telefone;
                    }
                }
            }
        }
        public bool Vazio()
        {
            if (Head == null && Tail == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Puch(Contato aux)
        {
            Contato aux1;
            Contato aux2;
            if (Vazio())
            {
                Head = aux;
                Tail = aux;
            }
            else if (aux.Nome.CompareTo(Tail.Nome) == 1 || aux.Nome.CompareTo(Tail.Nome) == 0)
            {
                Tail.Proximo = aux;
                Tail = aux;
            }
            else if (Head.Nome.CompareTo(aux.Nome) == 1 || Head.Nome.CompareTo(aux.Nome) == 0)
            {
                aux.Proximo = Head;
                Head = aux;
            }
            else
            {
                aux1 = Head;
                aux2 = Head;
                aux1 = aux1.Proximo;
                int cont = 0;
                do
                {
                    if (aux1.Nome.CompareTo(aux.Nome) == 1)
                    {
                        if (cont == 0)
                        {
                            aux2.Proximo = aux;
                            aux.Proximo = aux1;
                            cont++;
                            /*break;*/
                        }

                    }
                    aux2 = aux2.Proximo;
                    aux1 = aux1.Proximo;
                } while (aux1 != null);
            }

            Console.WriteLine("\n\t\tContato Adicionado");
        }

        public void Print()
        {
            int cont = 0;
            Console.Clear();
            Console.WriteLine("-_-_-_-_-_-Contact_-_-_-_-_-_-\n");
            if (Vazio())
            {
                Console.WriteLine(" Nenhum Contato Adicionado\n");
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
                Console.ReadKey();
            }
            else
            {
                Contato aux = Head;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                    cont++;
                    Console.ReadKey();
                } while (aux != null);
                Console.WriteLine("\nTodos os Contatos exibidos\nNúmero de contatos {0}", cont);
                Console.ReadKey();
            }

            Console.Clear();
        }
        public void Seach()
        {
            Console.Clear();
            Console.WriteLine("-_-_-_-_-_-Seach_-_-_-_-_-_-\n");
            if (Vazio())
            {
                Console.WriteLine(" Nenhum Contato Adicionado\n");
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Contato Nome: ");
                string seach = Console.ReadLine();
                Contato aux = Head;
                bool check = false;
                do
                {
                    if (seach.CompareTo(aux.Nome) == 0)
                    {
                        Console.WriteLine(aux.ToString());
                        check = true;
                    }
                    aux = aux.Proximo;
                } while (aux != Tail.Proximo);


                if (check == false)
                {
                    Console.WriteLine("\nNenhum contato encontrado com o nome: {0}", seach);
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
        public void Pop()
        {
            Console.Clear();
            Console.WriteLine("-_-_-_-_-_-Remove-_-_-_-_-_-\n");
            if (Vazio())
            {
                Console.WriteLine(" Nenhum Contato Adicionado\n");
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Write("Contato Nome: ");
                string remove = Console.ReadLine();
                Contato aux = Head;
                Contato aux2 = Head;
                bool check = false;
                if (remove.CompareTo(Head.Nome) == 0)
                {
                    Head = aux.Proximo;
                    aux = null;
                    check = true;

                    if (Head == null)
                    {
                        Tail = null;
                        Console.WriteLine("\nRemovendo {0}...", remove);
                    }
                }
                else
                {
                    aux = aux.Proximo;
                    do
                    {
                        if (remove.CompareTo(aux.Nome) == 0)
                        {

                            if (aux.Nome == Tail.Nome)
                            {
                                aux2.Proximo = aux.Proximo;
                                Tail = aux2;
                                aux = null;
                                check = true;
                                Console.WriteLine("\nRemovendo {0}...", remove);
                                break;
                            }
                            else
                            {
                                aux2.Proximo = aux.Proximo;
                                aux = null;
                                check = true;
                                Console.WriteLine("\nRemovendo {0}...", remove);
                                break;
                            }
                        }
                        aux = aux.Proximo;
                        aux2 = aux2.Proximo;
                    } while (aux != null);

                }
                if (check == false)
                {
                    Console.WriteLine("Nenhum contato encontrado");
                }
            }
        }
        public void Edit()
        {
            Console.Clear();
            Console.WriteLine("-_-_-_-_-_-_-Edit_-_-_-_-_-_-_-\n");
            if (Vazio())
            {
                Console.WriteLine(" Nenhum Contato Adicionado\n");
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\t\t-_-_-_Edit Contact_-_-_-\n");
                Contato aux = Head;
                Contato aux1 = Head;
                Contato aux2 = Head;
                bool check = false;
                Console.WriteLine("Digite o Contato: ");
                string edit = Console.ReadLine();

                do
                {
                    if (edit.CompareTo(aux.Nome) == 0)
                    {
                        Telefone auxfone = aux.Telefone.Head;
                        check = true;
                        Console.WriteLine("[1] - Editar Nome\n[2] - Editar E-mail\n[3] - Editar Número");
                        int opcedit = int.Parse(Console.ReadLine());
                        switch (opcedit)
                        {
                            case 1:
                                Console.WriteLine("Digite o novo nome de {0}", aux.Nome);
                                string nome = Console.ReadLine();
                                aux.Nome = nome;
                                Ordenar();
                                break;
                            case 2:
                                Console.WriteLine("Digite o novo email de {0}:", aux.Nome);
                                aux.Email = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("--Edição de Telefone--\nQual o Tipo de telefone deseja editar: ");
                                string tipo = Console.ReadLine().ToLower();
                                bool check2 = false;
                                auxfone = aux.Telefone.Head;


                                do
                                {
                                    if (auxfone.Tipo == tipo)
                                    {
                                        check2 = true;
                                        Console.WriteLine("[1] - Editar Tipo\n[2] - Editar DDD\n[3] - Editar Número");
                                        int op = int.Parse(Console.ReadLine());
                                        switch (op)
                                        {
                                            case 1:
                                                Console.WriteLine("Digite o novo Tipo de Telefone");
                                                auxfone.Tipo = Console.ReadLine();
                                                break;
                                            case 2:
                                                Console.WriteLine("Digite o novo DDD de Telefone");
                                                auxfone.DDD = int.Parse(Console.ReadLine());
                                                break;
                                            case 3:
                                                Console.WriteLine("Digite o novo Número de Telefone");
                                                auxfone.Numero = float.Parse(Console.ReadLine());
                                                break;
                                            default:
                                                Console.WriteLine("Opção Inválida");
                                                break;
                                        }
                                    }
                                    auxfone = auxfone.Proximo;
                                } while (auxfone != null);

                                if (check2 == false)
                                {
                                    Console.Clear();
                                    Console.WriteLine("----------------------\n");
                                    Console.WriteLine("Nenhum tipo econtrando\n");
                                    Console.WriteLine("----------------------");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                break;
                        }
                    }
                    aux = aux.Proximo;
                } while (aux != Tail.Proximo);

                if (check == false)
                {
                    Console.WriteLine("\nContato {0} não encontrado!!", edit);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace UrnaEletronic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Candidato> list = new List<Candidato>();
            list.Add(new Candidato("Br", 0, 7070, "Ronaldinho", 1));
            list.Add(new Candidato("HU3", 0, 2020, "Silvio Santos", 2));

            int escolha,saida;
            int x = 0;
            int y = 0;
            int Nulo = 0;
            String senha;
            

            Console.WriteLine("Bem vindo a Urna eletronica!");

            do
            {
                Console.WriteLine("Digite 1 para votar e 2 para entrar como Adiministrador");

                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    do
                    {
                        Console.WriteLine("Digite o Numero do Seu Candidato Para Presidente ");
                    int numPres = int.Parse(Console.ReadLine());
                    
                    
                        foreach (Candidato obj in list)
                        {
                            if (numPres == obj.Numero)
                            {

                                {
                                    Console.WriteLine(obj);
                                    Console.WriteLine("Deseja Confirmar? Digite 2 para Confirmar ou 3 para Corrigir ");
                                    x = int.Parse(Console.ReadLine());

                                    if (x == 2)
                                    {
                                        obj.Voto();
                                    }
                                    y++;
                                }
                                
                            } 
                        }
                        if (y == 0)
                        {
                            Console.WriteLine("Voto Nulo, Digite 2 para Confirmar ou 3 para Corrigir");
                            x = int.Parse(Console.ReadLine());
                            if(x == 2)
                            {
                                Nulo++;
                            }
                        }
                    } while (x == 3 || x != 2);
                }

                else if (escolha == 2)
                {
                    Console.WriteLine("Entre com a senha");
                    senha = Console.ReadLine();
                    if ("Senha"== senha)
                    {
                        foreach(Candidato obj in list)
                        {
                            Console.WriteLine(obj+", Numero De votos:"+ obj.NumeroVotos);
                        }
                        Console.WriteLine("Numero dde votos Nulos:"+ Nulo);
                    }
                }

                Console.WriteLine("Degite 1 para sair");
                saida = int.Parse(Console.ReadLine());
               
           

            } while (escolha != 2 && escolha != 1 || saida != 1);
        }
    }
}
  
using System;

/*
 • Deve ter um nome com no mínimo 6 caracteres;
 • Deve ter um preço de aquisição;
 • Deve ter um número de série;
 • Deve ter uma data de fabricação;
 • Deve ter uma fabricante; 
 
 */





namespace Gestão_de_Equipamentos.ConsoleApp
{
    
    internal class Program
    {
         static int[] identificador = new int[1000];
         static string[] nome = new string[1000];
         static string[] preco = new string[1000];
         static string[] numeroSerie = new string[1000];
         static string[] dataFabricacao = new string[1000];
         static string[] fabricante = new string[1000];
         static int opcao;
         static int opcao_chamado;
         static int contador=0;
         static int contador_chamado=0;
         static int n = 0;
       static void Main(string[] args)
        {

            string[] titulo_chamado = new string[1000];
            string[] descricao_chamado = new string[1000];
            string[] data_abertura = new string[1000];
            string[] equipamento_manutencao = new string[1000];

        inicio_menu:


            //inicio do menu de opções
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("--------------------------------");
                Console.WriteLine("        MENU DE OPÇÕES");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Opção 1: Registrar Equipamentos");
                Console.WriteLine("Opção 2: Visualizar Equipamentos");
                Console.WriteLine("Opção 3: Atualizar Equipamento");
                Console.WriteLine("Opção 4: Remover Equipamento");
                Console.WriteLine("Opção 5: Sair do Programa");
                Console.WriteLine("Opção 6: Ir para a central de chamados");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Digite a opção:");
                opcao = System.Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                Console.Clear();

                #region opções_menu

                if (opcao == 1)
                {
                    registrarValores(ref n);

                    goto inicio_menu;


                }
                else if (opcao == 2)
                {
                    mostrarValores();
                    goto inicio_menu;

                }
                else if (opcao == 3)
                {
                    atualizarValor();
                    goto inicio_menu;

                }
                else if (opcao == 4)
                {
                    removeValor(equipamento_manutencao);
                    goto inicio_menu;
                }
                else if (opcao == 5)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Saindo..");
                    Console.ResetColor();
                    goto fim_progama;


                }
                else if (opcao == 6)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Comando desconhecido..");
                    Console.ResetColor();
                }

                #endregion

            } while (opcao != 1 && opcao != 2 && opcao != 3 && opcao != 4 && opcao != 5 && opcao != 6);



        //inicio do controle de chamados

        inicio_chamados:
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("--------------------------------");
                Console.WriteLine("       CONTROLE DE CHAMADOS");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Opção 1: Registrar Chamados");
                Console.WriteLine("Opção 2: Visualizar Chamados");
                Console.WriteLine("Opção 3: Atualizar Chamado");
                Console.WriteLine("Opção 4: Remover Chamado");
                Console.WriteLine("Opção 5: Voltar ao menu de opções");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Digite a opção:");
                opcao_chamado = System.Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                Console.Clear();

                #region opções_chamado

                if (opcao_chamado == 1)
                {

                    registrarChamados(ref titulo_chamado, ref descricao_chamado, ref data_abertura, ref equipamento_manutencao);
                    goto inicio_chamados;


                }
                else if (opcao_chamado == 2)
                {
                    mostrarChamados(ref titulo_chamado, ref descricao_chamado, ref data_abertura, ref equipamento_manutencao);
                    goto inicio_chamados;

                }
                else if (opcao_chamado == 3)
                {
                    atualizarChamados(ref titulo_chamado, ref descricao_chamado, ref data_abertura, ref equipamento_manutencao);
                    goto inicio_chamados;

                }
                else if (opcao_chamado == 4)
                {
                    removerChamados(ref titulo_chamado, ref descricao_chamado, ref data_abertura, ref equipamento_manutencao);
                    goto inicio_chamados;
                }
                else if (opcao_chamado == 5)
                {
                    goto inicio_menu;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Comando desconhecido..");
                    Console.ResetColor();
                }

                #endregion

            } while (opcao_chamado != 1 && opcao_chamado != 2 && opcao_chamado != 3 && opcao_chamado != 4 && opcao_chamado != 5);





        fim_progama:;

        }

       
        public static void registrarValores(ref int n)
        {
            int posicao=0;

            Console.WriteLine("Digite a quantidade de equipamentos que será registrado:");
              n = System.Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("--------------------------");
            Console.WriteLine("Registro de equipamentos");
            Console.WriteLine("--------------------------");

            
               
            for (int i = 0; i < n; i++)
            {
                
                posicao++;

                do {
                    identificador[i + contador] = i;
                    Console.WriteLine("Digite o nome do equipamento da posição: " + posicao);
                    nome[i + contador] = Console.ReadLine();

                    if (nome[i + contador].Length < 6)
                    {
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Digite um nome com no mínimo 6 caracteres.");
                        Console.WriteLine("Aperte o ENTER para digitar novamente..");
                        Console.ReadLine();
                        Console.Clear();
                        Console.ResetColor();
                    }
                }while (nome[i+contador].Length < 6);


                Console.WriteLine("Digite o preço do equipamento da posição: " + posicao);
                preco[i + contador] = Console.ReadLine();



                Console.WriteLine("Digite o número de serie do equipamento da posição: " + posicao);
                numeroSerie[i+contador] = Console.ReadLine();



                Console.WriteLine("Digite a data de fabricação do equipamento da posição: " + posicao + " (00/00/00)");
                dataFabricacao[i+contador] = Console.ReadLine();



                Console.WriteLine("Digite o fabricante do equipamento da posição: " + posicao);
                fabricante[i+contador] = Console.ReadLine();

                Console.Clear();

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Registrado com sucesso!");
            Console.ResetColor();
            Console.WriteLine("\n");
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
            Console.Clear();
            contador = contador + n;
        }

        public static void mostrarValores()
        {
            
            Console.Clear();
            for (int i = 0; i < contador; i++)
            {

                if (nome[i] != null)
                {
                    
               
                    

                    Console.WriteLine("Nome: " + nome[i]);
                    Console.WriteLine("Preço: " + preco[i] + " R$");
                    Console.WriteLine("Número de serie: " + numeroSerie[i]);
                    Console.WriteLine("Data de fabricação: " + dataFabricacao[i]);
                    Console.WriteLine("Fabricante: " + fabricante[i]);
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("\n");
                }
            }
            Console.WriteLine("Aperte ENTER para voltar a página inicial");
            Console.ReadLine();
            Console.Clear();
        }

        public static void atualizarValor()
        {
            string escolha;

            Console.WriteLine("Digite o nome do equipamento que deseja atualizar:");
             escolha = Console.ReadLine();

            Console.Clear();

            for (int i = 0; i<contador; i++)
            {
               if(nome[i] != escolha)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nenhum equipamento com o nome inserido foi registrado");
                    Console.ResetColor();
                    Console.WriteLine("Aperte ENTER para voltar a tela inicial");
                    Console.ReadLine();
                    Console.Clear();

                    

                }
                else
                {
                    Console.WriteLine("Digite o novo nome do equipamento:");
                    nome[i] = Console.ReadLine();

                    Console.WriteLine("Digite o novo preço do equipamento");
                    preco[i] = Console.ReadLine();

                    Console.WriteLine("Digite a nova data de fabricação do equipamento");
                    dataFabricacao[i] = Console.ReadLine();

                    Console.WriteLine("Digite o novo fabricante do equipamento");
                    fabricante[i] = Console.ReadLine();

                    Console.Clear();
                }

                
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Equipamento atualizado com sucesso!");
            Console.ResetColor();



        }

        public static void removeValor(string [] equipamento_manutencao)
        {
            string escolha;
            int nChamados=0;

            Console.WriteLine("Digite o nome do equipamento que deseja remover:");
               escolha = Console.ReadLine();

            
          
                for (int j = 0; j < contador; j++){

                 for (int i = 0; i < equipamento_manutencao.Length; i++) {
                    if (escolha == equipamento_manutencao[i])
                    {
                        nChamados++;
                       
                       
                        
                    }
                 }
                      if (nChamados > 0)
                       {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não é possível remover pois o equipamento está em um chamado");
                    Console.ResetColor();
                    Console.WriteLine("Aperte ENTER para voltar a tela inicial");
                    Console.ReadLine();
                    Console.Clear();

                    break;
                       }
                   if (nome[j] != escolha)
                   {
                       


                   }
                    else
                    {
                        nome[j] = null;
                        preco[j] = null;
                        numeroSerie[j] = null;
                        dataFabricacao[j] = null;
                        fabricante[j] = null;
                    }
                }

            if (nChamados == 0)
            {


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Equipamento removido com sucesso!");
                Console.ResetColor();
                Console.WriteLine("Aperte ENTER para voltar a tela inicial");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhum equipamento com o nome inserido foi registrado");
                Console.ResetColor();
                Console.WriteLine("Aperte ENTER para voltar a tela inicial");
                Console.ReadLine();
                Console.Clear();
            }
            
        }

        public static void registrarChamados(ref string[] titulo_chamado, ref string[] descricao_chamado, ref string[] data_abertura, ref string[] equipamento_manutencao)
        {
            string escolha;
            Console.WriteLine("Digite o nome do equipamento que deseja realizar a manutenção:");
             escolha = Console.ReadLine();
             int contaNequip=0;

            for (int i = 0;i<contador;i++)
            {
                if (nome[i] != escolha)
                {
                    
                }
                
                else
                {
                    contaNequip = 1;
                    equipamento_manutencao[i+contador_chamado] = nome[i];
                    
                    Console.WriteLine("Informe o título do chamado:");
                     titulo_chamado[i+contador_chamado] = Console.ReadLine();

                    Console.WriteLine("Informe a descrição do chamado:");
                     descricao_chamado[i+contador_chamado] = Console.ReadLine();

                    Console.WriteLine("Informe a data de abertura do chamado:");
                     data_abertura[i+contador_chamado] = Console.ReadLine(); 
                }
                
            }

            if (contaNequip == 0) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhum equipamento com o nome inserido foi registrado");
                Console.ResetColor();
                Console.WriteLine("Aperte ENTER para voltar a tela inicial");
                Console.ReadLine();
                Console.Clear();

            }

            Console.Clear();
            
            contador++;
        }

        public static void mostrarChamados(ref string[] titulo_chamado, ref string[] descricao_chamado, ref string[] data_abertura, ref string[] equipamento_manutencao)
        {
            Console.Clear();
            for (int i = 0;i<contador;i++)
            {
                if (equipamento_manutencao[i] == null)
                {

                }
                else
                {
                    string[] dataSeparada = data_abertura[i].Split("/");
                  
                    int dia = Convert.ToInt32(dataSeparada[0]);
                    int mes = Convert.ToInt32(dataSeparada[1]);
                    int ano = Convert.ToInt32(dataSeparada[2]);

                    DateTime dataCriacaoChamado = new DateTime(ano,mes,dia);
                    DateTime dataAtual = DateTime.Now;

                    TimeSpan diferencaTempo = dataAtual - dataCriacaoChamado;
                    int diferencaData = diferencaTempo.Days;

                    Console.WriteLine("Equipamento em manutenção: " + equipamento_manutencao[i]);
                    Console.WriteLine("Título do chamado: " + titulo_chamado[i]);
                    Console.WriteLine("Descrição do chamado: " + descricao_chamado[i]);
                    Console.WriteLine("Data de abertura do chamado: " + data_abertura[i]);
                    Console.WriteLine($"Número de dias que o chamado está aberto:{diferencaData} dias");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("\n");
                }
            }
            Console.WriteLine("Aperte ENTER para voltar a página inicial");
            Console.ReadLine();
            Console.Clear();
        }

        public static void atualizarChamados(ref string[] titulo_chamado, ref string[] descricao_chamado, ref string[] data_abertura, ref string[] equipamento_manutencao)
        {
            string escolha;

            Console.WriteLine("Digite o nome de equipamento que deseja atualizar na manutenção:");
              escolha = Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < contador; i++)
            {
                if (equipamento_manutencao[i] != escolha)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nenhum chamado com esse nome foi registrado");
                    Console.ResetColor();
                    Console.WriteLine("Aperte ENTER para voltar a tela inicial");
                    Console.ReadLine();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("Digite o novo nome do equipamento do chamado:");
                     equipamento_manutencao[i] = Console.ReadLine();

                    Console.WriteLine("Informe o novo título do chamado:");
                    titulo_chamado[i] = Console.ReadLine();

                    Console.WriteLine("Informe a nova descrição do chamado:");
                    descricao_chamado[i] = Console.ReadLine();

                    Console.WriteLine("Informe a nova data de abertura do chamado:");
                    data_abertura[i] = Console.ReadLine();


                    Console.Clear();
                }
            }
          
        }

        public static void removerChamados(ref string[] titulo_chamado, ref string[] descricao_chamado, ref string[] data_abertura, ref string[] equipamento_manutencao)
        {
            string escolha;
            int deubom=0;

            Console.WriteLine("Digite o nome de equipamento que deseja atualizar na manutenção:");
             escolha = Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < contador; i++)
            {
                if (equipamento_manutencao[i] != escolha)
                {
                    



                }
                else
                {
                    equipamento_manutencao[i] = "";

                    
                    titulo_chamado[i] = "";

                    
                    descricao_chamado[i] = "";

                    
                    data_abertura[i] = "";
                    deubom++;

                    Console.Clear();
                }
            }

            if (deubom > 0 )
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Chamada removida com sucesso!");
                Console.ResetColor();
                Console.WriteLine("Aperte ENTER para voltar a tela inicial");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhum chamado com esse nome foi registrado");
                Console.ResetColor();
                Console.WriteLine("Aperte ENTER para voltar a tela inicial");
                Console.ReadLine();
                Console.Clear();
            }


        }

     
    }
}

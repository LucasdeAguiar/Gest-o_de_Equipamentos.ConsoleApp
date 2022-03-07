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
        #region atributos de equipamento
        static int[] identificador = new int[1000];
        static string[] nome = new string[1000];
        static string[] preco = new string[1000];
        static string[] numeroSerie = new string[1000];
        static string[] dataFabricacao = new string[1000];
        static string[] fabricante = new string[1000];
        #endregion

        #region variáveis não tratadas
        static int opcao;
        static int contador = 0;
        static int contador_chamado = 0;
        static int n = 0;
        static int nSolicitante = 0;
        static int contador_solicitante = 0;

        #endregion

        static void Main(string[] args)
        {
            #region variáveis de opções
            int opcao_chamado;
            int opcao_solicitante;
            #endregion

            #region atributos de chamado
            string[] titulo_chamado = new string[1000];
            string[] descricao_chamado = new string[1000];
            string[] data_abertura = new string[1000];
            string[] equipamento_manutencao = new string[1000];
            string[] status = new string[1000]; 
            #endregion

            #region atributos solicitante
             string[] nomeSolicitante = new string[1000];
             string [] emailSolicitante = new string [1000];
             string[] telefoneSolicitante = new string[1000];
            #endregion

        inicio_menu:
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
                Console.WriteLine("Opção 7: Ir para a central de solicitantes");
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
                    goto inicio_chamados;
                }
                else if (opcao == 7)
                {
                    goto inicio_solicitantes;
                }else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Comando desconhecido..");
                    Console.ResetColor();
                }

                #endregion

            } while (opcao != 1 && opcao != 2 && opcao != 3 && opcao != 4 && opcao != 5 && opcao != 6 && opcao != 7);



       

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
                Console.WriteLine("Opção 6: Ir para a central de solicitantes");
                Console.WriteLine("Opção 7: Sair do Programa");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Digite a opção:");
                opcao_chamado = System.Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                Console.Clear();

                #region opções_chamado

                if (opcao_chamado == 1)
                {

                    registrarChamados(ref titulo_chamado, ref descricao_chamado, ref data_abertura, ref equipamento_manutencao, ref nomeSolicitante, ref status);
                    goto inicio_chamados;


                }
                else if (opcao_chamado == 2)
                {
                    mostrarChamados(ref titulo_chamado, ref descricao_chamado, ref data_abertura, ref equipamento_manutencao, ref nomeSolicitante, ref status);
                    goto inicio_chamados;

                }
                else if (opcao_chamado == 3)
                {
                    atualizarChamados(ref titulo_chamado, ref descricao_chamado, ref data_abertura, ref equipamento_manutencao, ref nomeSolicitante, ref status);
                    goto inicio_chamados;

                }
                else if (opcao_chamado == 4)
                {
                    removerChamados(ref titulo_chamado, ref descricao_chamado, ref data_abertura, ref equipamento_manutencao,ref nomeSolicitante, ref status);
                    goto inicio_chamados;
                }
                else if (opcao_chamado == 5)
                {
                    goto inicio_menu;
                }
                else if (opcao_chamado == 6)
                {
                    goto inicio_solicitantes;

                }else if (opcao_chamado == 7)
                {
                    goto fim_progama;
                }else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Comando desconhecido..");
                    Console.ResetColor();
                }

                #endregion

            } while (opcao_chamado != 1 && opcao_chamado != 2 && opcao_chamado != 3 && opcao_chamado != 4 && opcao_chamado != 5 && opcao_chamado != 6 && opcao_chamado != 7);



        inicio_solicitantes:
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("         CONTROLE DE SOLICITANTES ");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Opção 1: Registrar Solicitante ");
                Console.WriteLine("Opção 2: Visualizar Solicitante");
                Console.WriteLine("Opção 3: Atualizar Solicitante ");
                Console.WriteLine("Opção 4: Remover Solicitante");
                Console.WriteLine("Opção 5: Voltar ao menu de opções");
                Console.WriteLine("Opção 6: Ir para controle de Chamados");
                Console.WriteLine("Opção 7: Sair do Programa");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Digite a opção:");
                opcao_solicitante = System.Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                Console.Clear();

                #region opções_chamado

                if (opcao_solicitante == 1)
                {
                    registrarSolicitantes(ref nomeSolicitante, ref emailSolicitante, ref telefoneSolicitante);
                    goto inicio_solicitantes;
                }
                else if (opcao_solicitante == 2)
                {
                    visualizarSolicitantes(ref nomeSolicitante, ref emailSolicitante, ref telefoneSolicitante);
                    goto inicio_solicitantes;
                }
                else if (opcao_solicitante == 3)
                {
                    atualizarSolicitantes(ref nomeSolicitante, ref emailSolicitante, ref telefoneSolicitante);
                    goto inicio_solicitantes;
                }
                else if (opcao_solicitante == 4)
                {
                    removerSolicitantes(ref nomeSolicitante, ref emailSolicitante, ref telefoneSolicitante);
                    goto inicio_solicitantes;
                }
                else if (opcao_solicitante == 5)
                {
                    goto inicio_menu;
                }
                else if (opcao_solicitante == 6)
                {
                    goto inicio_chamados;
                }
                else if (opcao_solicitante == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Saindo..");
                    goto fim_progama;
                }else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Comando desconhecido..");
                    Console.ResetColor();
                }

                #endregion

            } while (opcao_solicitante != 1 && opcao_solicitante != 2 && opcao_solicitante != 3 && opcao_solicitante != 4 && opcao_solicitante != 5 && opcao_solicitante != 6 && opcao_solicitante != 7);


        fim_progama:;

        }


  

        public static void registrarValores(ref int n)
        {
            int posicao = 0;

            Console.WriteLine("Digite a quantidade de equipamentos que será registrado:");
            n = System.Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("--------------------------");
            Console.WriteLine("Registro de equipamentos");
            Console.WriteLine("--------------------------");



            for (int i = 0; i < n; i++)
            {

                posicao++;

                do
                {
                    identificador[i + contador] = i;
                    Console.WriteLine("Digite o nome do equipamento da posição: " + posicao);
                    nome[i + contador] = Console.ReadLine();

                    if (nome[i + contador].Length < 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite um nome com no mínimo 6 caracteres.");
                        Console.WriteLine("Aperte o ENTER para digitar novamente..");
                        Console.ReadLine();
                        Console.Clear();
                        Console.ResetColor();
                    }
                } while (nome[i + contador].Length < 6);


                Console.WriteLine("Digite o preço do equipamento da posição: " + posicao);
                preco[i + contador] = Console.ReadLine();



                Console.WriteLine("Digite o número de serie do equipamento da posição: " + posicao);
                numeroSerie[i + contador] = Console.ReadLine();



                Console.WriteLine("Digite a data de fabricação do equipamento da posição: " + posicao + " (00/00/00)");
                dataFabricacao[i + contador] = Console.ReadLine();



                Console.WriteLine("Digite o fabricante do equipamento da posição: " + posicao);
                fabricante[i + contador] = Console.ReadLine();

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

            for (int i = 0; i < contador; i++)
            {
                if (nome[i] != escolha)
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

                    Console.WriteLine("Digite o novo número de série:");
                    numeroSerie[i] = Console.ReadLine();

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

        public static void removeValor(string[] equipamento_manutencao)
        {
            string escolha;
            int nChamados = 0;

            Console.WriteLine("Digite o nome do equipamento que deseja remover:");
            escolha = Console.ReadLine();



            for (int j = 0; j < contador; j++)
            {

                for (int i = 0; i < equipamento_manutencao.Length; i++)
                {
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

          public static void registrarChamados(ref string[] titulo_chamado, ref string[] descricao_chamado, ref string[] data_abertura, ref string[] equipamento_manutencao ,ref string[] nomeSolicitante, ref string[] status)
          {
            string escolha;
            Console.WriteLine("Digite o nome do equipamento que deseja realizar a manutenção:");
            escolha = Console.ReadLine();
            int contaNequip = 0;

            for (int i = 0; i < contador; i++)
            {
                if (nome[i] != escolha)
                {

                }

                else 
                {
                    contaNequip = 1;
                    equipamento_manutencao[i + contador_chamado] = nome[i];


                    Console.WriteLine("Informe o título do chamado:");
                    titulo_chamado[i + contador_chamado] = Console.ReadLine();

                    Console.WriteLine("Informe a descrição do chamado:");
                    descricao_chamado[i + contador_chamado] = Console.ReadLine();

                    Console.WriteLine("Informe o nome do solicitante do chamado:");
                     nomeSolicitante[i + contador_solicitante] = Console.ReadLine();
                    contador_solicitante++;

                    Console.WriteLine("Informe a data de abertura do chamado:");
                    data_abertura[i + contador_chamado] = Console.ReadLine();

                    Console.WriteLine("Informe o status do chamado:(true/false)");
                    status[i + contador_chamado] = Console.ReadLine();
                }

            }

            if (contaNequip == 0)
            {
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

        public static void mostrarChamados(ref string[] titulo_chamado, ref string[] descricao_chamado, ref string[] data_abertura, ref string[] equipamento_manutencao, ref string[] nomeSolicitante, ref string[] status)
        {
            Console.Clear();
            for (int i = 0; i < contador; i++)
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

                    DateTime dataCriacaoChamado = new DateTime(ano, mes, dia);
                    DateTime dataAtual = DateTime.Now;

                    TimeSpan diferencaTempo = dataAtual - dataCriacaoChamado;
                    int diferencaData = diferencaTempo.Days;

                    Console.WriteLine("Equipamento em manutenção: " + equipamento_manutencao[i]);
                    Console.WriteLine("Título do chamado: " + titulo_chamado[i]);
                    Console.WriteLine("Descrição do chamado: " + descricao_chamado[i]);
                    Console.WriteLine("Data de abertura do chamado: " + data_abertura[i]);
                    Console.WriteLine("Solicitante: " + nomeSolicitante[i]);
                    Console.WriteLine($"Número de dias que o chamado está aberto:{diferencaData} dias");
                    Console.WriteLine("Status do chamado: " + status[i]);
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("\n");
                }
            }
            Console.WriteLine("Aperte ENTER para voltar a página inicial");
            Console.ReadLine();
            Console.Clear();
        }

        public static void atualizarChamados(ref string[] titulo_chamado, ref string[] descricao_chamado, ref string[] data_abertura, ref string[] equipamento_manutencao, ref string[] nomeSolicitante, ref string[] status)
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

                    Console.WriteLine("Informe o novo nome do solicitante do chamado:");
                     nomeSolicitante[i] = Console.ReadLine();

                    Console.WriteLine("Informe o novo status do chamado:(true/false)");
                     status[i] = Console.ReadLine();


                    Console.Clear();
                }
            }

        }

        public static void removerChamados(ref string[] titulo_chamado, ref string[] descricao_chamado, ref string[] data_abertura, ref string[] equipamento_manutencao, ref string[] nomeSolicitante, ref string[] status)
        {
            string escolha;
            int deubom = 0;

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
                    

                    equipamento_manutencao[i] = null;


                    titulo_chamado[i] = null;


                    descricao_chamado[i] = null;


                    data_abertura[i] = null;

                    nomeSolicitante[i] = null;

                    status[i] = null;

                    deubom++;

                    Console.Clear();
                }
            }

            if (deubom > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
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

        public static void registrarSolicitantes(ref string[] nomeSolicitante, ref string[] emailSolicitante, ref string[] telefoneSolicitante)
        {
            int posicao = 0;

            Console.WriteLine("Digite a quantidade de solicitantes que será registrado:");
             nSolicitante = System.Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i< nSolicitante; i++)
            {
                posicao++;

                do
                {
                    
                    Console.WriteLine("Digite o nome do solicitante da posição: " + posicao);
                    nomeSolicitante[i + contador_solicitante] = Console.ReadLine();

                    if (nomeSolicitante[i + contador_solicitante].Length < 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite um nome com no mínimo 6 caracteres.");
                        Console.WriteLine("Aperte o ENTER para digitar novamente..");
                        Console.ReadLine();
                        Console.Clear();
                        Console.ResetColor();
                    }
                } while (nomeSolicitante[i + contador_solicitante].Length < 6);

                Console.WriteLine("Digite o email do solicitante da posição: " + posicao);
                 emailSolicitante[i + contador_solicitante] = Console.ReadLine();

                Console.WriteLine("Digite o número de telefone do solicitante da posição: " + posicao);
                 telefoneSolicitante[i + contador_solicitante] = Console.ReadLine();

                Console.Clear();
                
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Registrado com sucesso!");
            Console.ResetColor();
            Console.WriteLine("\n");
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
            Console.Clear();
            contador_solicitante = contador_solicitante + nSolicitante;
        }

        public static void visualizarSolicitantes(ref string[] nomeSolicitante, ref string[] emailSolicitante, ref string[] telefoneSolicitante)
        {
            Console.Clear();
            for (int i = 0; i < contador_solicitante; i++)
            {

                if (nomeSolicitante[i]!= null)
                {
                    Console.WriteLine("Id: " + i);
                    Console.WriteLine("Nome: " + nomeSolicitante[i]);
                    Console.WriteLine("Email: " + emailSolicitante[i]);
                    Console.WriteLine("Número de telefone: " + telefoneSolicitante[i]);
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("\n");
                }
            }
            Console.WriteLine("Aperte ENTER para voltar a página inicial");
            Console.ReadLine();
            Console.Clear();
        }

        public static void atualizarSolicitantes(ref string[] nomeSolicitante, ref string[] emailSolicitante, ref string[] telefoneSolicitante)
        {
            string escolha;

            Console.WriteLine("Digite o nome do solicitante que deseja atualizar:");
             escolha = Console.ReadLine();

            Console.Clear();

            for (int i = 0; i < contador_solicitante; i++)
            {
                if (nomeSolicitante[i] != escolha)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nenhum solicitante com o nome inserido foi registrado");
                    Console.ResetColor();
                    Console.WriteLine("Aperte ENTER para voltar a tela inicial");
                    Console.ReadLine();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("Digite o novo nome do solicitante:");
                     nomeSolicitante[i] = Console.ReadLine();

                    Console.WriteLine("Digite o novo email do solicitante");
                     emailSolicitante[i] = Console.ReadLine();

                    Console.WriteLine("Digite o novo número de telefone do solicitante:");
                     telefoneSolicitante[i] = Console.ReadLine();

                    Console.Clear();
                }


            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Solicitante atualizado com sucesso!");
            Console.ResetColor();
        }

        public static void removerSolicitantes(ref string[] nomeSolicitante, ref string[] emailSolicitante, ref string[] telefoneSolicitante)
        {
            string escolha;
            

            Console.WriteLine("Digite o nome do solicitante que deseja remover:");
             escolha = Console.ReadLine();

            for (int j = 0; j < contador_solicitante; j++)
            {
                
                if (nomeSolicitante[j] == escolha)
                {
                    nomeSolicitante[j] = null;
                    emailSolicitante[j] = null;
                    telefoneSolicitante[j] = null;

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

        }
    }
}

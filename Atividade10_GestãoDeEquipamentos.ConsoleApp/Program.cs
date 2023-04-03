using System.Collections;

namespace Atividade10_GestãoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Equipamentos
            ArrayList idEquipamentos = new ArrayList();
            ArrayList nomeEquipamentos = new ArrayList();
            ArrayList precoEquipamentos = new ArrayList();
            ArrayList numeroSerieEquipamentos = new ArrayList();
            ArrayList dataFabricacaoEquipamentos = new ArrayList();
            ArrayList fabricanteEquipamentos = new ArrayList();

            int idEquipamentosAdd = 5;
            string nome;
            string preco;
            string numeroSerie;
            string dataFabricacao;
            string fabricante;

            int idEscolhido;
            int indexEscolhido;

            idEquipamentos.Add(1);
            nomeEquipamentos.Add("Galaxy Y");
            precoEquipamentos.Add("750");
            numeroSerieEquipamentos.Add("25648");
            dataFabricacaoEquipamentos.Add("20/04/2022");
            fabricanteEquipamentos.Add("Samsung");

            idEquipamentos.Add(2);
            nomeEquipamentos.Add("Monitor Wide");
            precoEquipamentos.Add("450");
            numeroSerieEquipamentos.Add("54236");
            dataFabricacaoEquipamentos.Add("27/07/2022");
            fabricanteEquipamentos.Add("LG");

            idEquipamentos.Add(3);
            nomeEquipamentos.Add("Aspirador");
            precoEquipamentos.Add("480");
            numeroSerieEquipamentos.Add("23654");
            dataFabricacaoEquipamentos.Add("23/11/2022");
            fabricanteEquipamentos.Add("Xiaomi");

            idEquipamentos.Add(4);
            nomeEquipamentos.Add("Liquidificador");
            precoEquipamentos.Add("120");
            numeroSerieEquipamentos.Add("14587");
            dataFabricacaoEquipamentos.Add("12/06/2022");
            fabricanteEquipamentos.Add("Britania");
            #endregion

            #region Chamados
            ArrayList idChamados = new ArrayList();
            ArrayList tituloChamados = new ArrayList();
            ArrayList descricaoChamados = new ArrayList();
            ArrayList equipamentoChamados = new ArrayList();
            ArrayList dataAberturaChamados = new ArrayList();
            ArrayList diasEmAbertoChamados = new ArrayList();

            DateTime dataAtual = DateTime.Now;
            TimeSpan diasEmAberto;

            int idChamadosAdd = 5;
            string titulo;
            string descricao;
            string equipamento;
            DateTime dataAbertura;

            idChamados.Add(1);
            tituloChamados.Add("Impressora Problema Cartucho");
            descricaoChamados.Add("A impressora está com problema no cartucho");
            equipamentoChamados.Add("Impressora Deskjet 2760");
            dataAbertura = DateTime.Parse("12/01/2023");
            dataAberturaChamados.Add("12/01/2023");
            diasEmAberto = dataAtual - dataAbertura;
            diasEmAbertoChamados.Add(Math.Round(diasEmAberto.TotalDays));

            idChamados.Add(2);
            tituloChamados.Add("Galaxy S20e preto com capa");
            descricaoChamados.Add("Placa queimada");
            equipamentoChamados.Add("Galaxy S20e");
            dataAbertura = DateTime.Parse("27/12/2022");
            dataAberturaChamados.Add("27/12/2022");
            diasEmAberto = dataAtual - dataAbertura;
            diasEmAbertoChamados.Add(Math.Round(diasEmAberto.TotalDays));

            idChamados.Add(3);
            tituloChamados.Add("Monitor UltraWide Conector");
            descricaoChamados.Add("Conector HDMI falhando");
            equipamentoChamados.Add("Monitor LG UltraWide");
            dataAbertura = DateTime.Parse("15/02/2023");
            dataAberturaChamados.Add("15/02/2023");
            diasEmAberto = dataAtual - dataAbertura;
            diasEmAbertoChamados.Add(Math.Round(diasEmAberto.TotalDays));

            idChamados.Add(4);
            tituloChamados.Add("Teclado faltando tecla");
            descricaoChamados.Add("Repor teclas faltando");
            equipamentoChamados.Add("Teclado Gamer Logitech");
            dataAbertura = DateTime.Parse("22/03/2023");
            dataAberturaChamados.Add("22/03/2023");
            diasEmAberto = dataAtual - dataAbertura;
            diasEmAbertoChamados.Add(Math.Round(diasEmAberto.TotalDays));
            #endregion

            while (true)
            {
                string opcaoEscolhidaMenu;
                string opcaoEscolhidaSubMenu;

                opcaoEscolhidaMenu = MenuPrincipal();

                if (opcaoEscolhidaMenu.ToUpper() == "S")
                    break;

                while (opcaoEscolhidaMenu == "1")
                {
                    Console.Clear();

                    opcaoEscolhidaSubMenu = SubMenu("Equipamento");

                    if (opcaoEscolhidaSubMenu == "1")
                    {
                        VisualizarEquipamentos(idEquipamentos, nomeEquipamentos, precoEquipamentos, numeroSerieEquipamentos, dataFabricacaoEquipamentos, fabricanteEquipamentos);
                        Console.ReadLine();
                    }

                    else if (opcaoEscolhidaSubMenu == "2")
                    {
                        #region Add Equipamentos
                        VisualizarEquipamentos(idEquipamentos, nomeEquipamentos, precoEquipamentos, numeroSerieEquipamentos, dataFabricacaoEquipamentos, fabricanteEquipamentos);
                        PulaLinha();

                        Console.Write("Digite o Nome do Equipamento: ");
                        nome = ValidaNomeMin6Caracteres("Digite o Nome do Equipamento: ");

                        Console.Write("Digite o Preço de Aquisição: ");
                        preco = ValidaNumero("Digite o Preço de Aquisição: ").ToString();

                        Console.Write("Digite o N°Série: ");
                        numeroSerie = Console.ReadLine();

                        Console.Write("Digite a Data de Fabricação: ");
                        dataFabricacao = Console.ReadLine();

                        Console.Write("Digite a Fabricante do Equipamento: ");
                        fabricante = Console.ReadLine();

                        idEquipamentos.Add(idEquipamentosAdd);
                        nomeEquipamentos.Add(nome);
                        precoEquipamentos.Add(preco);
                        numeroSerieEquipamentos.Add(numeroSerie);
                        dataFabricacaoEquipamentos.Add(dataFabricacao);
                        fabricanteEquipamentos.Add(fabricante);

                        idEquipamentosAdd++;

                        Console.Clear();

                        VisualizarEquipamentos(idEquipamentos, nomeEquipamentos, precoEquipamentos, numeroSerieEquipamentos, dataFabricacaoEquipamentos, fabricanteEquipamentos);

                        PulaLinha();
                        MensagemColor($"Equipamento \"{nome}\" adicionado com sucesso!", ConsoleColor.Green);

                        Console.ReadLine();

                        #endregion
                    }

                    else if (opcaoEscolhidaSubMenu == "3")
                    {
                        #region Editar Equipamentos
                        VisualizarEquipamentos(idEquipamentos, nomeEquipamentos, precoEquipamentos, numeroSerieEquipamentos, dataFabricacaoEquipamentos, fabricanteEquipamentos);
                        PulaLinha();

                        Console.Write("Digite o ID do Equipamento que deseja editar: ");

                        idEscolhido = ValidaIndex("Digite o ID do Equipamento que deseja editar: ", idEquipamentos);

                        indexEscolhido = idEquipamentos.IndexOf(idEscolhido);

                        Console.Write("Digite o Novo Nome do Equipamento: ");
                        nome = ValidaNomeMin6Caracteres("Digite o Novo Nome do Equipamento: ");

                        Console.Write("Digite o Novo Preço de Aquisição: ");
                        preco = ValidaNumero("Digite o Novo Preço de Aquisição: ").ToString();

                        Console.Write("Digite o Novo N°Série: ");
                        numeroSerie = Console.ReadLine();

                        Console.Write("Digite a Nova Data de Fabricação: ");
                        dataFabricacao = Console.ReadLine(); ;

                        Console.Write("Digite a Nova Fabricante do Equipamento: ");
                        fabricante = Console.ReadLine();

                        nomeEquipamentos.RemoveAt(indexEscolhido);
                        precoEquipamentos.RemoveAt(indexEscolhido);
                        numeroSerieEquipamentos.RemoveAt(indexEscolhido);
                        dataFabricacaoEquipamentos.RemoveAt(indexEscolhido);
                        fabricanteEquipamentos.RemoveAt(indexEscolhido);

                        nomeEquipamentos.Insert(indexEscolhido, nome);
                        precoEquipamentos.Insert(indexEscolhido, preco);
                        numeroSerieEquipamentos.Insert(indexEscolhido, numeroSerie);
                        dataFabricacaoEquipamentos.Insert(indexEscolhido, dataFabricacao);
                        fabricanteEquipamentos.Insert(indexEscolhido, fabricante);

                        Console.Clear();

                        VisualizarEquipamentos(idEquipamentos, nomeEquipamentos, precoEquipamentos, numeroSerieEquipamentos, dataFabricacaoEquipamentos, fabricanteEquipamentos);

                        PulaLinha();
                        MensagemColor($"Equipamento com o ID \"{idEscolhido}\" editado com sucesso!", ConsoleColor.Green);

                        Console.ReadLine();

                        #endregion
                    }

                    else if (opcaoEscolhidaSubMenu == "4")
                    {
                        #region Excluir Equipamentos
                        VisualizarEquipamentos(idEquipamentos, nomeEquipamentos, precoEquipamentos, numeroSerieEquipamentos, dataFabricacaoEquipamentos, fabricanteEquipamentos);
                        PulaLinha();

                        Console.Write("Digite o ID do Equipamento que deseja excluir: ");

                        idEscolhido = ValidaIndex("Digite o ID do Equipamento que deseja excluir: ", idEquipamentos);

                        indexEscolhido = idEquipamentos.IndexOf(idEscolhido);

                        Console.Write("Você tem certeza que deseja excluir o Equipamento com o ID ");
                        MensagemColor($"\"{idEscolhido}\"", ConsoleColor.Blue);
                        Console.WriteLine("? (S/N)");

                        string confirmacao = Console.ReadLine();

                        if (confirmacao.ToUpper() == "S")
                        {

                            idEquipamentos.RemoveAt(indexEscolhido);
                            nomeEquipamentos.RemoveAt(indexEscolhido);
                            precoEquipamentos.RemoveAt(indexEscolhido);
                            numeroSerieEquipamentos.RemoveAt(indexEscolhido);
                            dataFabricacaoEquipamentos.RemoveAt(indexEscolhido);
                            fabricanteEquipamentos.RemoveAt(indexEscolhido);

                            Console.Clear();

                            VisualizarEquipamentos(idEquipamentos, nomeEquipamentos, precoEquipamentos, numeroSerieEquipamentos, dataFabricacaoEquipamentos, fabricanteEquipamentos);

                            PulaLinha();
                            MensagemColor($"Equipamento com o ID \"{idEscolhido}\" excluído com sucesso!", ConsoleColor.Green);
                        }
                        else
                        {
                            PulaLinha();
                            Console.WriteLine("Retornando ao Menu . . .");
                        }

                        Console.ReadLine();

                        #endregion
                    }
                    else if (opcaoEscolhidaSubMenu.ToUpper() == "S")
                    {
                        break;
                    }
                }

                while (opcaoEscolhidaMenu == "2")
                {
                    Console.Clear();

                    opcaoEscolhidaSubMenu = SubMenu("Chamado");

                    if (opcaoEscolhidaSubMenu == "1")
                    {
                        VisualizarChamados(idChamados, tituloChamados, descricaoChamados, equipamentoChamados, dataAberturaChamados, diasEmAbertoChamados);
                        Console.ReadLine();
                    }

                    else if (opcaoEscolhidaSubMenu == "2")
                    {
                        #region Add Chamado

                        dataAtual = DateTime.Now;

                        VisualizarChamados(idChamados, tituloChamados, descricaoChamados, equipamentoChamados, dataAberturaChamados, diasEmAbertoChamados);
                        PulaLinha();

                        Console.Write("Digite o Título do Chamado: ");
                        titulo = Console.ReadLine();

                        Console.Write("Digite a Descrição: ");
                        descricao = Console.ReadLine();

                        Console.Write("Digite o Equipamento: ");
                        equipamento = Console.ReadLine();

                        Console.Write("Digite a Data de Abertura: ");
                        dataAbertura = ValidaData("Digite a Data de Abertura: ");

                        diasEmAberto = dataAtual - dataAbertura;

                        idChamados.Add(idChamadosAdd);
                        tituloChamados.Add(titulo);
                        descricaoChamados.Add(descricao);
                        equipamentoChamados.Add(equipamento);
                        dataAberturaChamados.Add(dataAbertura.ToString("d"));
                        diasEmAbertoChamados.Add(Math.Round(diasEmAberto.TotalDays));

                        idChamadosAdd++;

                        VisualizarChamados(idChamados, tituloChamados, descricaoChamados, equipamentoChamados, dataAberturaChamados, diasEmAbertoChamados);

                        PulaLinha();
                        MensagemColor($"Chamado \"{titulo}\" adicionado com sucesso!", ConsoleColor.Green);

                        Console.ReadLine();

                        #endregion
                    }

                    else if (opcaoEscolhidaSubMenu == "3")
                    {
                        #region Editar Chamados

                        dataAtual = DateTime.Now;

                        VisualizarChamados(idChamados, tituloChamados, descricaoChamados, equipamentoChamados, dataAberturaChamados, diasEmAbertoChamados);
                        PulaLinha();

                        Console.Write("Digite o ID do Equipamento que deseja editar: ");

                        idEscolhido = ValidaIndex("Digite o ID do Chamado que deseja editar: ", idChamados);

                        indexEscolhido = idEquipamentos.IndexOf(idEscolhido);

                        Console.Write("Digite o Novo Título do Chamado: ");
                        titulo = Console.ReadLine();

                        Console.Write("Digite a Nova Descrição: ");
                        descricao = Console.ReadLine();

                        Console.Write("Digite o Novo Equipamento: ");
                        equipamento = Console.ReadLine();

                        Console.Write("Digite a Nova Data de Abertura: ");
                        dataAbertura = ValidaData("Digite a Nova Data de Abertura: ");

                        diasEmAberto = dataAtual - dataAbertura;

                        tituloChamados.RemoveAt(indexEscolhido);
                        descricaoChamados.RemoveAt(indexEscolhido);
                        equipamentoChamados.RemoveAt(indexEscolhido);
                        dataAberturaChamados.RemoveAt(indexEscolhido);
                        diasEmAbertoChamados.RemoveAt(indexEscolhido);

                        tituloChamados.Insert(indexEscolhido, titulo);
                        descricaoChamados.Insert(indexEscolhido, descricao);
                        equipamentoChamados.Insert(indexEscolhido, equipamento);
                        dataAberturaChamados.Insert(indexEscolhido, dataAbertura.ToString("d"));
                        diasEmAbertoChamados.Insert(indexEscolhido, Math.Round(diasEmAberto.TotalDays));

                        Console.Clear();

                        VisualizarChamados(idChamados, tituloChamados, descricaoChamados, equipamentoChamados, dataAberturaChamados, diasEmAbertoChamados);

                        PulaLinha();
                        MensagemColor($"Chamado com o ID \"{idEscolhido}\" editado com sucesso!", ConsoleColor.Green);

                        Console.ReadLine();

                        #endregion
                    }

                    else if (opcaoEscolhidaSubMenu == "4")
                    {
                        #region Excluir Chamados
                        VisualizarChamados(idChamados, tituloChamados, descricaoChamados, equipamentoChamados, dataAberturaChamados, diasEmAbertoChamados);
                        PulaLinha();

                        Console.Write("Digite o ID do Chamado que deseja excluir: ");

                        idEscolhido = ValidaIndex("Digite o ID do Chamado que deseja excluir: ", idChamados);

                        indexEscolhido = idChamados.IndexOf(idEscolhido);

                        Console.Write("Você tem certeza que deseja excluir o Chamado com o ID ");
                        MensagemColor($"\"{idEscolhido}\"", ConsoleColor.Blue);
                        Console.WriteLine("? (S/N)");

                        string confirmacao = Console.ReadLine();

                        if (confirmacao.ToUpper() == "S")
                        {

                            idChamados.RemoveAt(indexEscolhido);
                            tituloChamados.RemoveAt(indexEscolhido);
                            descricaoChamados.RemoveAt(indexEscolhido);
                            equipamentoChamados.RemoveAt(indexEscolhido);
                            dataAberturaChamados.RemoveAt(indexEscolhido);
                            diasEmAbertoChamados.RemoveAt(indexEscolhido);

                            Console.Clear();

                            VisualizarChamados(idChamados, tituloChamados, descricaoChamados, equipamentoChamados, dataAberturaChamados, diasEmAbertoChamados);

                            PulaLinha();
                            MensagemColor($"Chamado com o ID \"{idEscolhido}\" editado com sucesso!", ConsoleColor.Green);
                        }
                        else
                        {
                            PulaLinha();
                            Console.WriteLine("Retornando ao Menu . . .");
                        }

                        Console.ReadLine();

                        #endregion
                    }
                    else if (opcaoEscolhidaSubMenu.ToUpper() == "S")
                    {
                        break;
                    }
                }
            }
        }

        private static void VisualizarChamados(ArrayList idChamados, ArrayList tituloChamados, ArrayList descricaoChamados, ArrayList equipamentoChamados, ArrayList dataAberturaChamados, ArrayList diasEmAbertoChamados)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ID".PadRight(8) + "│");
            Console.Write("Título".PadRight(40) + "│");
            Console.Write("Descrição".PadRight(50) + "│");
            Console.Write("Equipamento".PadRight(30) + "│");
            Console.Write("Data de Abertura".PadRight(20) + "│");
            Console.WriteLine("Dias em Aberto".PadRight(15) + "│");
            Console.WriteLine("".PadRight(169, '―'));
            Console.ResetColor();

            for (int i = 0; i < idChamados.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ResetColor();
                }

                string id = idChamados[i].ToString().PadRight(7);
                string titulo = tituloChamados[i].ToString().PadRight(40);
                string descricao = descricaoChamados[i].ToString().PadRight(50);
                string equimamento = equipamentoChamados[i].ToString().PadRight(30);
                string dataAbertura = dataAberturaChamados[i].ToString().PadRight(20);
                string diasEmAberto = diasEmAbertoChamados[i].ToString().PadRight(15);


                Console.Write("#" + id + "│");
                Console.Write(titulo + "│");
                Console.Write(descricao + "│");
                Console.Write(equimamento + "│");
                Console.Write(dataAbertura + "│");
                Console.WriteLine(diasEmAberto + "│");
            }
            Console.ResetColor();
        }

        private static void VisualizarEquipamentos(ArrayList idEquipamentos, ArrayList nomeEquipamentos, ArrayList precoEquipamentos, ArrayList numeroSerieEquipamentos, ArrayList dataFabricacaoEquipamentos, ArrayList fabricanteEquipamentos)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ID".PadRight(8) + "│");
            Console.Write("Nome".PadRight(30) + "│");
            Console.Write("Preço".PadRight(22) + "│");
            Console.Write("N°Série".PadRight(20) + "│");
            Console.Write("Data de Fabricação".PadRight(20) + "│");
            Console.WriteLine("Fabricante".PadRight(30) + "│");
            Console.WriteLine("".PadRight(133, '―'));
            Console.ResetColor();

            for (int i = 0; i < idEquipamentos.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ResetColor();
                }

                string id = idEquipamentos[i].ToString().PadRight(7);
                string nome = nomeEquipamentos[i].ToString().PadRight(30);
                string preco = precoEquipamentos[i].ToString().PadRight(20);
                string numeroSerie = numeroSerieEquipamentos[i].ToString().PadRight(20);
                string dataFabricacao = dataFabricacaoEquipamentos[i].ToString().PadRight(20);
                string fabricante = fabricanteEquipamentos[i].ToString().PadRight(30);

                Console.Write("#" + id + "│");
                Console.Write(nome + "│");
                Console.Write("R$" + preco + "│");
                Console.Write(numeroSerie + "│");
                Console.Write(dataFabricacao + "│");
                Console.WriteLine(fabricante + "│");
            }
            Console.ResetColor();
        }

        static void MensagemColor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.Write(mensagem);
            Console.ResetColor();
        }

        static string MenuPrincipal()
        {
            Console.Clear();

            Console.WriteLine("Gestão de Equipamentos");
            PulaLinha();
            Console.WriteLine("(1)Cadastro de Equipamentos");
            Console.WriteLine("(2)Controle de Chamados");
            PulaLinha();
            Console.WriteLine("(S)Sair");
            PulaLinha();
            Console.Write("Escolha: ");

            string entrada = Console.ReadLine();

            return entrada;
        }

        static string SubMenu(string tipo)
        {
            Console.Clear();

            Console.WriteLine($"Cadastro de {tipo}s");
            PulaLinha();
            Console.WriteLine($"(1)Visualizar {tipo}");
            Console.WriteLine($"(2)Inserir novo {tipo}s");
            Console.WriteLine($"(3)Editar {tipo}s");
            Console.WriteLine($"(4)Excluir um {tipo}");
            PulaLinha();
            Console.WriteLine("(S)Sair");
            PulaLinha();

            Console.Write("Escolha: ");
            string entrada = Console.ReadLine();

            return entrada;
        }

        static DateTime ValidaData(string mensagem)
        {
            bool validaData;
            string entrada;
            DateTime dataAbertura;

            do
            {
                entrada = Console.ReadLine();

                validaData = DateTime.TryParse(entrada, out dataAbertura);

                if (!validaData)
                {
                    Console.WriteLine("Atenção, escreva uma data válida");
                    Console.Write(mensagem);
                }

            } while (!validaData);

            return dataAbertura;
        }

        static int ValidaIndex(string mensagem, ArrayList idList)
        {
            bool validaNumero;
            bool validaIndex;
            string entrada;
            int numero;

            do
            {
                entrada = Console.ReadLine();

                validaNumero = int.TryParse(entrada, out numero);

                validaIndex = idList.Contains(numero);

                if (!validaNumero || !validaIndex)
                {
                    Console.WriteLine("Atenção, apenas ID`s existentes");
                    Console.Write(mensagem);
                }

            } while (!validaNumero || !validaIndex);

            return numero;
        }

        static string ValidaNomeMin6Caracteres(string mensagem)
        {
            bool validaNome;
            string entrada;

            do
            {
                entrada = Console.ReadLine();

                validaNome = entrada.Length >= 6;

                if (!validaNome)
                {
                    Console.WriteLine("Atenção, \"Nome\" com no mínimo 6 caracteres");
                    Console.Write(mensagem);
                }

            } while (!validaNome);

            return entrada;
        }

        static double ValidaNumero(string mensagem)
        {
            bool validaNumero;
            string entrada;
            double numero;

            do
            {
                entrada = Console.ReadLine();

                validaNumero = double.TryParse(entrada, out numero);

                if (!validaNumero)
                {
                    Console.WriteLine("Atenção, apenas números");
                    Console.Write(mensagem);
                }

            } while (!validaNumero);

            return numero;
        }

        static void PulaLinha()
        {
            Console.WriteLine();
        }
    }
}
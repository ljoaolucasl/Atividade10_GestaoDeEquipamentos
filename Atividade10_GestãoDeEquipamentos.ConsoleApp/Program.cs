using System.Collections;

namespace Atividade10_GestãoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static ArrayList idEquipamentos = new();
        static ArrayList nomeEquipamentos = new();
        static ArrayList precoEquipamentos = new();
        static ArrayList numeroSerieEquipamentos = new();
        static ArrayList dataFabricacaoEquipamentos = new();
        static ArrayList fabricanteEquipamentos = new();

        static ArrayList idChamadosSyncEquipamentos = new();
        static ArrayList idChamados = new();
        static ArrayList tituloChamados = new();
        static ArrayList descricaoChamados = new();
        static ArrayList equipamentoChamados = new();
        static ArrayList dataAberturaChamados = new();
        static ArrayList diasEmAbertoChamados = new();

        static void Main(string[] args)
        {
            int idEquipamentosAdd = 5;
            int idChamadosAdd = 5;

            ListaEquipamentosPreDefinida();

            ListaChamadosPreDefinida();

            while (true)
            {
                string opcaoEscolhidaMenu;
                string opcaoEscolhidaSubMenu;

                opcaoEscolhidaMenu = MostrarMenuPrincipal();

                if (opcaoEscolhidaMenu.ToUpper() == "S")
                    break;

                while (opcaoEscolhidaMenu == "1")
                {
                    Console.Clear();

                    opcaoEscolhidaSubMenu = MostrarSubMenu("Equipamento");

                    if (opcaoEscolhidaSubMenu == "1")
                    {
                        VisualizarEquipamentos();
                        Console.ReadLine();
                    }

                    else if (opcaoEscolhidaSubMenu == "2")
                        AdicionarEquipamentos(ref idEquipamentosAdd);

                    else if (opcaoEscolhidaSubMenu == "3")
                        EditarEquipamentos();

                    else if (opcaoEscolhidaSubMenu == "4")
                        ExcluirEquipamentos();

                    else if (opcaoEscolhidaSubMenu.ToUpper() == "S")
                        break;
                }

                while (opcaoEscolhidaMenu == "2")
                {
                    Console.Clear();

                    opcaoEscolhidaSubMenu = MostrarSubMenu("Chamado");

                    if (opcaoEscolhidaSubMenu == "1")
                    {
                        VisualizarChamados();
                        Console.ReadLine();
                    }

                    else if (opcaoEscolhidaSubMenu == "2")
                        AdicionarChamados(ref idChamadosAdd);

                    else if (opcaoEscolhidaSubMenu == "3")
                        EditarChamados();

                    else if (opcaoEscolhidaSubMenu == "4")
                        ExcluirChamados();

                    else if (opcaoEscolhidaSubMenu.ToUpper() == "S")
                        break;
                }
            }
        }

        static void ListaEquipamentosPreDefinida()
        {
            idEquipamentos.Add(1);
            nomeEquipamentos.Add("Impressora Deskjet 2760");
            precoEquipamentos.Add("750");
            numeroSerieEquipamentos.Add("25648");
            dataFabricacaoEquipamentos.Add("20/04/2022");
            fabricanteEquipamentos.Add("HP");

            idEquipamentos.Add(2);
            nomeEquipamentos.Add("Monitor LG UltraWide");
            precoEquipamentos.Add("450");
            numeroSerieEquipamentos.Add("54236");
            dataFabricacaoEquipamentos.Add("27/07/2022");
            fabricanteEquipamentos.Add("LG");

            idEquipamentos.Add(3);
            nomeEquipamentos.Add("Galaxy S20e");
            precoEquipamentos.Add("480");
            numeroSerieEquipamentos.Add("23654");
            dataFabricacaoEquipamentos.Add("23/11/2022");
            fabricanteEquipamentos.Add("Samsung");

            idEquipamentos.Add(4);
            nomeEquipamentos.Add("Teclado Gamer Logitech");
            precoEquipamentos.Add("120");
            numeroSerieEquipamentos.Add("14587");
            dataFabricacaoEquipamentos.Add("12/06/2022");
            fabricanteEquipamentos.Add("Logitech");
        }

        static void ListaChamadosPreDefinida()
        {
            DateTime dataAtual = DateTime.Now;
            TimeSpan diasEmAberto;
            DateTime dataAbertura;

            idChamadosSyncEquipamentos.Add(1);
            idChamados.Add(1);
            tituloChamados.Add("Impressora Problema Cartucho");
            descricaoChamados.Add("A impressora está com problema no cartucho");
            equipamentoChamados.Add("Impressora Deskjet 2760");
            dataAbertura = DateTime.Parse("12/01/2023");
            dataAberturaChamados.Add("12/01/2023");
            diasEmAberto = dataAtual - dataAbertura;
            diasEmAbertoChamados.Add(Math.Round(diasEmAberto.TotalDays));

            idChamadosSyncEquipamentos.Add(3);
            idChamados.Add(2);
            tituloChamados.Add("Galaxy S20e preto com capa");
            descricaoChamados.Add("Placa queimada");
            equipamentoChamados.Add("Galaxy S20e");
            dataAbertura = DateTime.Parse("27/12/2022");
            dataAberturaChamados.Add("27/12/2022");
            diasEmAberto = dataAtual - dataAbertura;
            diasEmAbertoChamados.Add(Math.Round(diasEmAberto.TotalDays));

            idChamadosSyncEquipamentos.Add(2);
            idChamados.Add(3);
            tituloChamados.Add("Monitor UltraWide Conector");
            descricaoChamados.Add("Conector HDMI falhando");
            equipamentoChamados.Add("Monitor LG UltraWide");
            dataAbertura = DateTime.Parse("15/02/2023");
            dataAberturaChamados.Add("15/02/2023");
            diasEmAberto = dataAtual - dataAbertura;
            diasEmAbertoChamados.Add(Math.Round(diasEmAberto.TotalDays));

            idChamadosSyncEquipamentos.Add(4);
            idChamados.Add(4);
            tituloChamados.Add("Teclado faltando tecla");
            descricaoChamados.Add("Repor teclas faltando");
            equipamentoChamados.Add("Teclado Gamer Logitech");
            dataAbertura = DateTime.Parse("22/03/2023");
            dataAberturaChamados.Add("22/03/2023");
            diasEmAberto = dataAtual - dataAbertura;
            diasEmAbertoChamados.Add(Math.Round(diasEmAberto.TotalDays));
        }

        static string MostrarMenuPrincipal()
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

        static string MostrarSubMenu(string tipo)
        {
            Console.Clear();

            Console.WriteLine($"Cadastro de {tipo}s");
            PulaLinha();
            Console.WriteLine($"(1)Visualizar {tipo}s");
            Console.WriteLine($"(2)Adicionar novo {tipo}");
            Console.WriteLine($"(3)Editar {tipo}");
            Console.WriteLine($"(4)Excluir um {tipo}");
            PulaLinha();
            Console.WriteLine("(S)Sair");
            PulaLinha();

            Console.Write("Escolha: ");
            string entrada = Console.ReadLine();

            return entrada;
        }



        static void VisualizarEquipamentos()
        {
            MostrarTitulosListaEquipamentos();

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

        static void AdicionarEquipamentos(ref int idEquipamentosAdd)
        {
            string nome;
            string preco;
            string numeroSerie;
            DateTime dataFabricacao;
            string fabricante;

            VisualizarEquipamentos();
            PulaLinha();

            Console.Write("Digite o Nome do Equipamento: ");
            nome = ValidaNomeMin6Caracteres("Digite o Nome do Equipamento: ");

            Console.Write("Digite o Preço de Aquisição: ");
            preco = ValidaNumero("Digite o Preço de Aquisição: ").ToString();

            Console.Write("Digite o N°Série: ");
            numeroSerie = Console.ReadLine();

            Console.Write("Digite a Data de Fabricação: ");
            dataFabricacao = ValidaData("Digite a Data de Fabricação: ");

            Console.Write("Digite a Fabricante do Equipamento: ");
            fabricante = Console.ReadLine();

            idEquipamentos.Add(idEquipamentosAdd);
            nomeEquipamentos.Add(nome);
            precoEquipamentos.Add(preco);
            numeroSerieEquipamentos.Add(numeroSerie);
            dataFabricacaoEquipamentos.Add(dataFabricacao.ToString("d"));
            fabricanteEquipamentos.Add(fabricante);

            idEquipamentosAdd++;

            Console.Clear();

            VisualizarEquipamentos();

            PulaLinha();
            MensagemColor($"Equipamento \"{nome}\" adicionado com sucesso!", ConsoleColor.Green);

            Console.ReadLine();
        }

        static void EditarEquipamentos()
        {
            string nome;
            string preco;
            string numeroSerie;
            DateTime dataFabricacao;
            string fabricante;

            int idEscolhido;
            int indexEscolhido;

            VisualizarEquipamentos();
            PulaLinha();

            if (VerificaSeListaEstaVazia("EQUIPAMENTO"))
                return;

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
            dataFabricacao = ValidaData("Digite a Nova Data de Fabricação: ");

            Console.Write("Digite a Nova Fabricante do Equipamento: ");
            fabricante = Console.ReadLine();

            EditaEquipamentoEscolhido(nome, preco, numeroSerie, dataFabricacao, fabricante, indexEscolhido, idEscolhido);

            Console.Clear();

            VisualizarEquipamentos();

            PulaLinha();
            MensagemColor($"Equipamento com o ID \"{idEscolhido}\" editado com sucesso!", ConsoleColor.Green);

            Console.ReadLine();
        }

        static void EditaEquipamentoEscolhido(string nome, string preco, string numeroSerie, DateTime dataFabricacao, string fabricante, int indexEscolhido, int idEscolhido)
        {
            for (int i = 0; i < idChamadosSyncEquipamentos.Count; i++)
            {
                if ((int)idChamadosSyncEquipamentos[i] == idEscolhido)
                {
                    equipamentoChamados[i] = nome;
                }
            }

            nomeEquipamentos[indexEscolhido] = nome;
            precoEquipamentos[indexEscolhido] = preco;
            numeroSerieEquipamentos[indexEscolhido] = numeroSerie;
            dataFabricacaoEquipamentos[indexEscolhido] = dataFabricacao.ToString("d");
            fabricanteEquipamentos[indexEscolhido] = fabricante;
        }

        static void ExcluirEquipamentos()
        {
            int idEscolhido;
            int indexEscolhido;

            VisualizarEquipamentos();
            PulaLinha();

            if (VerificaSeListaEstaVazia("EQUIPAMENTO"))
                return;

            Console.Write("Digite o ID do Equipamento que deseja excluir: ");

            idEscolhido = ValidaIndex("Digite o ID do Equipamento que deseja excluir: ", idEquipamentos);

            indexEscolhido = idEquipamentos.IndexOf(idEscolhido);

            ConfirmarParaExcluirEquipamento(idEscolhido, indexEscolhido);

            Console.ReadLine();
        }

        static void ConfirmarParaExcluirEquipamento(int idEscolhido, int indexEscolhido)
        {
            while (true)
            {
                Console.Write("Você tem certeza que deseja excluir o Equipamento com o ID ");
                MensagemColor($"\"{idEscolhido}\"", ConsoleColor.Blue);
                Console.WriteLine("? (S/N)");

                string confirmacao = Console.ReadLine();

                if (confirmacao.ToUpper() == "S")
                {
                    RemoveEquipamentoEscolhido(indexEscolhido, idEscolhido);

                    Console.Clear();

                    VisualizarEquipamentos();

                    PulaLinha();
                    MensagemColor($"Equipamento com o ID \"{idEscolhido}\" excluído com sucesso!", ConsoleColor.Green);
                    break;
                }
                else if (confirmacao.ToUpper() == "N")
                {
                    PulaLinha();
                    Console.WriteLine("Retornando ao Menu . . .");
                    break;
                }
            }
        }

        static void RemoveEquipamentoEscolhido(int indexEscolhido, int idEscolhido)
        {
            int indexEquipamentoChamado = idChamadosSyncEquipamentos.IndexOf(idEscolhido);

            while (indexEquipamentoChamado != -1)
            {
                idChamadosSyncEquipamentos.RemoveAt(indexEquipamentoChamado);
                idChamados.RemoveAt(indexEquipamentoChamado);
                tituloChamados.RemoveAt(indexEquipamentoChamado);
                descricaoChamados.RemoveAt(indexEquipamentoChamado);
                equipamentoChamados.RemoveAt(indexEquipamentoChamado);
                dataAberturaChamados.RemoveAt(indexEquipamentoChamado);
                diasEmAbertoChamados.RemoveAt(indexEquipamentoChamado);

                indexEquipamentoChamado = idChamadosSyncEquipamentos.IndexOf(idEscolhido);
            }

            idEquipamentos.RemoveAt(indexEscolhido);
            nomeEquipamentos.RemoveAt(indexEscolhido);
            precoEquipamentos.RemoveAt(indexEscolhido);
            numeroSerieEquipamentos.RemoveAt(indexEscolhido);
            dataFabricacaoEquipamentos.RemoveAt(indexEscolhido);
            fabricanteEquipamentos.RemoveAt(indexEscolhido);
        }



        static void VisualizarChamados()
        {
            MostrarTitulosListaChamados();

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

        static void AdicionarChamados(ref int idChamadosAdd)
        {
            DateTime dataAtual = DateTime.Now;
            TimeSpan diasEmAberto;
            DateTime dataAbertura;

            string titulo;
            string descricao;
            string equipamento;

            int idEscolhidoChamado;
            int idEscolhidoEquipamento;
            int indexEscolhido;
            int indexEquipamentoChamado;

            VisualizarChamados();
            PulaLinha();

            Console.Write("Digite o Título do Chamado: ");
            titulo = Console.ReadLine();

            Console.Write("Digite a Descrição: ");
            descricao = Console.ReadLine();

            VisualizarEquipamentos();
            Console.Write("Digite o ID do Equipamento para o Chamado: ");
            idEscolhidoEquipamento = ValidaIndex("Digite o ID do Equipamento para o Chamado: ", idEquipamentos);
            indexEquipamentoChamado = idEquipamentos.IndexOf(idEscolhidoEquipamento);
            equipamento = nomeEquipamentos[indexEquipamentoChamado].ToString();

            Console.Write("Digite a Data de Abertura: ");
            dataAbertura = ValidaData("Digite a Data de Abertura: ");

            diasEmAberto = dataAtual - dataAbertura;

            idChamadosSyncEquipamentos.Add(idEscolhidoEquipamento);
            idChamados.Add(idChamadosAdd);
            tituloChamados.Add(titulo);
            descricaoChamados.Add(descricao);
            equipamentoChamados.Add(equipamento);
            dataAberturaChamados.Add(dataAbertura.ToString("d"));
            diasEmAbertoChamados.Add(Math.Round(diasEmAberto.TotalDays));

            idChamadosAdd++;

            VisualizarChamados();

            PulaLinha();
            MensagemColor($"Chamado \"{titulo}\" adicionado com sucesso!", ConsoleColor.Green);

            Console.ReadLine();
        }

        static void EditarChamados()
        {
            DateTime dataAtual = DateTime.Now;
            TimeSpan diasEmAberto;
            DateTime dataAbertura;

            string titulo;
            string descricao;
            string equipamento;

            int idEscolhidoEquipamento;
            int idEscolhidoChamado;
            int indexEscolhido;
            int indexEquipamentoChamado;

            VisualizarChamados();
            PulaLinha();

            if (VerificaSeListaEstaVazia("CHAMADO"))
                return;

            Console.Write("Digite o ID do Equipamento que deseja editar: ");

            idEscolhidoChamado = ValidaIndex("Digite o ID do Chamado que deseja editar: ", idChamados);

            indexEscolhido = idChamados.IndexOf(idEscolhidoChamado);

            Console.Write("Digite o Novo Título do Chamado: ");
            titulo = Console.ReadLine();

            Console.Write("Digite a Nova Descrição: ");
            descricao = Console.ReadLine();

            VisualizarEquipamentos();
            Console.Write("Digite o ID do Novo Equipamento para o Chamado: ");
            idEscolhidoEquipamento = ValidaIndex("Digite o ID do Novo Equipamento para o Chamado: ", idEquipamentos);
            indexEquipamentoChamado = idEquipamentos.IndexOf(idEscolhidoEquipamento);
            equipamento = nomeEquipamentos[indexEquipamentoChamado].ToString();

            Console.Write("Digite a Nova Data de Abertura: ");
            dataAbertura = ValidaData("Digite a Nova Data de Abertura: ");

            diasEmAberto = dataAtual - dataAbertura;

            EditaChamadoEscolhido(diasEmAberto, dataAbertura, titulo, descricao, equipamento, indexEscolhido, idEscolhidoEquipamento);

            Console.Clear();

            VisualizarChamados();

            PulaLinha();
            MensagemColor($"Chamado com o ID \"{idEscolhidoChamado}\" editado com sucesso!", ConsoleColor.Green);

            Console.ReadLine();
        }

        static void EditaChamadoEscolhido(TimeSpan diasEmAberto, DateTime dataAbertura, string titulo, string descricao, string equipamento, int indexEscolhido, int idEscolhidoEquipamento)
        {
            idChamadosSyncEquipamentos[indexEscolhido] = idEscolhidoEquipamento;
            tituloChamados[indexEscolhido] = titulo;
            descricaoChamados[indexEscolhido] = descricao;
            equipamentoChamados[indexEscolhido] = equipamento;
            dataAberturaChamados[indexEscolhido] = dataAbertura.ToString("d");
            diasEmAbertoChamados[indexEscolhido] = Math.Round(diasEmAberto.TotalDays);
        }

        static void ExcluirChamados()
        {
            DateTime dataAtual = DateTime.Now;
            TimeSpan diasEmAberto;
            DateTime dataAbertura;

            int idEscolhido;
            int indexEscolhido;

            VisualizarChamados();
            PulaLinha();

            if (VerificaSeListaEstaVazia("CHAMADO"))
                return;

            Console.Write("Digite o ID do Chamado que deseja excluir: ");

            idEscolhido = ValidaIndex("Digite o ID do Chamado que deseja excluir: ", idChamados);

            indexEscolhido = idChamados.IndexOf(idEscolhido);

            ConfirmarParaExcluirChamado(idEscolhido, indexEscolhido);

            Console.ReadLine();
        }

        static void ConfirmarParaExcluirChamado(int idEscolhido, int indexEscolhido)
        {
            while (true)
            {
                Console.Write("Você tem certeza que deseja excluir o Chamado com o ID ");
                MensagemColor($"\"{idEscolhido}\"", ConsoleColor.Blue);
                Console.WriteLine("? (S/N)");

                string confirmacao = Console.ReadLine();

                if (confirmacao.ToUpper() == "S")
                {

                    RemoveChamadoEscolhido(indexEscolhido);

                    Console.Clear();

                    VisualizarChamados();

                    PulaLinha();
                    MensagemColor($"Chamado com o ID \"{idEscolhido}\" excluído com sucesso!", ConsoleColor.Green);
                    break;
                }
                else if (confirmacao.ToUpper() == "N")
                {
                    PulaLinha();
                    Console.WriteLine("Retornando ao Menu . . .");
                    break;
                }
            }
        }

        static void RemoveChamadoEscolhido(int indexEscolhido)
        {
            idChamadosSyncEquipamentos.RemoveAt(indexEscolhido);
            idChamados.RemoveAt(indexEscolhido);
            tituloChamados.RemoveAt(indexEscolhido);
            descricaoChamados.RemoveAt(indexEscolhido);
            equipamentoChamados.RemoveAt(indexEscolhido);
            dataAberturaChamados.RemoveAt(indexEscolhido);
            diasEmAbertoChamados.RemoveAt(indexEscolhido);
        }



        private static bool VerificaSeListaEstaVazia(string tipo)
        {
            if (idEquipamentos.Count == 0 && tipo == "EQUIPAMENTO")
            {
                MensagemColor("Não há equipamentos registrados no momento", ConsoleColor.DarkYellow);
                Console.ReadLine();
                return true;
            }
            else if (idChamados.Count == 0 && tipo == "CHAMADO")
            {
                MensagemColor("Não há Chamados registrados no momento", ConsoleColor.DarkYellow);
                Console.ReadLine();
                return true;
            }
            return false;
        }

        static void MostrarTitulosListaEquipamentos()
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
        }

        static void MostrarTitulosListaChamados()
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
        }

        static void MensagemColor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.Write(mensagem);
            Console.ResetColor();
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
                    MensagemColor("Atenção, escreva uma data válida\n", ConsoleColor.Red);
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
                    MensagemColor("Atenção, apenas ID`s existentes\n", ConsoleColor.Red);
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
                    MensagemColor("Atenção, \"Nome\" com no mínimo 6 caracteres\n", ConsoleColor.Red);
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
                    MensagemColor("Atenção, apenas números\n", ConsoleColor.Red);
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
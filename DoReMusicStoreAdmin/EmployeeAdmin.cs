namespace DoReMusicStoreAdmin;
public class EmployeeAdmin
{
  public void AdminAttendance()
  {
    try 
    {
      char option = '0'; 
      while (option != '6')
      {
         Console.Clear();
                    Console.WriteLine("===============================");
                    Console.WriteLine("===       Atendimento       ===");
                    Console.WriteLine("=== 1 - Adicionar CD      ===");
                    Console.WriteLine("=== 2 - Listar CDs        ===");
                    Console.WriteLine("=== 3 - Remover CD        ===");
                    Console.WriteLine("=== 4 - Ordenar CDs       ===");
                    Console.WriteLine("=== 5 - Pesquisar CD      ===");
                    Console.WriteLine("=== 6 - Sair do Sistema    ===");
                    Console.WriteLine("===============================");
                    Console.WriteLine("\n\n");
                    Console.Write("Digite a opção desejada: ");
                    try
                    {
                      option = Console.ReadLine()[0]; 
                      // Console.WriteLine("Cai aqui"); \
                    }
                    catch (Exception excecao)
                    {
                      throw new Exception(excecao.Message); 
                    }

                    switch (option)
                    {
                      case '1':
                          AdicionarCd(); 
                        break; 
                      case '2':
                          ListarCds(); 
                        break; 
                      case '3':
                          RemoverCds(); 
                        break; 
                      case '4':
                          OrdenarCds(); 
                        break; 
                      case '5':
                          PesquisarCds(); 
                        break; 
                      case '6': 
                        EncerrarAplicacao();
                      break; 
                      default:
                        Console.WriteLine("Opção não implementada. "); 
                      break; 
                    }
      }
    }
     catch (Exception excecao)
            {
                Console.WriteLine($"{excecao.Message}");
            }
  }

    private void AdicionarCd()
    {
       Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===   CADASTRO DE CDs    ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.WriteLine("=== Informe os dados solicitados para adicionar o CD ===");

            Console.WriteLine("Insira o nome do colaborador: ");
            var colaboradorNome = Console.ReadLine(); 

            Console.WriteLine("Insira o nome do CD/Album: "); 
            var CdAlbum = Console.ReadLine(); 

            Console.WriteLine("Insira o nome do artista: ");
            var nome = Console.ReadLine(); 

            var ID = Guid.NewGuid().ToString().Substring(0, 8);
            Console.WriteLine("O ID do CD é " + ID);

            Console.WriteLine("Insira o gênero musical do CD: ");
            var genero = Console.ReadLine(); 

            Console.WriteLine("Insira a nacionalidade do artista/grupo: ");
            var artistaGrupo = Console.ReadLine(); 

            Console.WriteLine("Insira a quantidade de CDs: ");
            var quantidade = Console.ReadLine(); 

            Console.WriteLine("... CD cadastrada com sucesso! ...");
            Console.ReadKey();
    }

    private void ListarCds()
    {
      Console.Clear(); 
      Console.WriteLine("===============================");
      Console.WriteLine("===     LISTA DE CDS     ===");
      Console.WriteLine("===============================");
      Console.WriteLine("\n");
            // if (_listaDeContas.Count <= 0)
            // {
            //     Console.WriteLine("... Não há contas cadastradas! ...");
            //     Console.ReadKey();
            //     return;
            // }
            // foreach (ContaCorrente item in _listaDeContas)
            // {
                // Console.WriteLine(item.ToString());
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.ReadKey();
            // }
            // Console.WriteLine("... CDs listados com sucesso! ...");
            // Console.ReadKey();
    }

    private void RemoverCds()
    {
       Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===      REMOVER CONTAS     ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            // Console.Write("Informe o número da Conta: ");
            // string numeroConta = Console.ReadLine();
            // ContaCorrente conta = null;
            // foreach (var item in _listaDeContas)
            // {
            //     if (item.Conta.Equals(numeroConta))
            //     {
            //         conta = item;
            //     }
            // }
            // if (conta != null)
            // {
            //     _listaDeContas.Remove(conta);
            //     Console.WriteLine("... Conta removida da lista! ...");
            // }
            // else
            // {
            //     Console.WriteLine(" ... Conta para remoção não encontrada ...");
            // }
            // Console.ReadKey();
            Console.WriteLine("... CD removido com sucesso! ...");
            Console.ReadKey();
    }

    private void OrdenarCds()
    {
        Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===    PESQUISAR CONTAS     ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.Write("Deseja pesquisar por (1) NÚMERO DA CONTA ou (2)CPF TITULAR ou " +
                " (3) Nº AGÊNCIA : ");
            // switch (int.Parse(Console.ReadLine()))
            // {
            //     case 1:
            //         {
            //             Console.Write("Informe o número da Conta: ");
            //             string _numeroConta = Console.ReadLine();
            //             ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
            //             Console.WriteLine(consultaConta.ToString());
            //             Console.ReadKey();
            //             break;
            //         }
            //     case 2:
            //         {
            //             Console.Write("Informe o CPF do Titular: ");
            //             string _cpf = Console.ReadLine();
            //             ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
            //             Console.WriteLine(consultaCpf.ToString());
            //             Console.ReadKey();
            //             break;
            //         }
            //     case 3:
            //         {
            //             Console.Write("Informe o Nº da Agência: ");
            //             int _numeroAgencia = int.Parse(Console.ReadLine());
            //             var contasPorAgencia = ConsultaPorAgencia(_numeroAgencia);
            //             ExibirListaDeContas(contasPorAgencia);
            //             Console.ReadKey();
            //             break;
            //         }
            //     default:
            //         Console.WriteLine("Opção não implementada.");
            //         break;
            // }
            Console.WriteLine("... CDs ordenados com sucesso! ...");
            Console.ReadKey();
    }

    private void PesquisarCds()
    {
      Console.WriteLine("Pesquisa de CDs");
      Console.ReadKey(); 
    }

     private void EncerrarAplicacao()
        {
            Console.WriteLine("... Encerrando a aplicação ...");
            Console.ReadKey();
        }

    
}

using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static string connString = "Data Source=localhost;Initial Catalog=Exercicio2;Integrated Security=True";
        static SqlConnection conn = new SqlConnection(connString);
        static void Main(string[] args)
        {
            bool continuarPrograma = true;

            while (continuarPrograma)
            {
                int opcaoSelecionada = ExibirMenuDeEscolhasEPegarSelecao();
                switch (opcaoSelecionada)
                {
                    case 1:
                        Console.WriteLine("Digite separado por virgula o Nome da pessoa, Data de Nascimento, Numero RG, Numero CPF, Nome da Mãe e Profissão");
                        string[] campos = Console.ReadLine().Split(',');
                        CREATE(campos);
                        break;
                    case 2:
                        READ();
                        break;
                    case 3:
                        Console.WriteLine("Digite separado por virgula o Nome da pessoa, Data de Nascimento, Numero RG, Numero CPF, Nome da Mãe, Profissão e CPF do usuario em questão.");
                        string[] campos2 = Console.ReadLine().Split(',');
                        UPDATE(campos2);
                        break;
                    case 4:
                        Console.WriteLine("Digite o cpf do usuario a ser apagado.");
                        string cpf = Console.ReadLine();
                        DELETE(cpf);
                        break;
                    case 5:
                        Console.WriteLine("Até mais");
                        Console.ReadKey();
                        continuarPrograma = false;
                        break;
                }
            }
        }

        static int ExibirMenuDeEscolhasEPegarSelecao()
        {
            int escolha = 0;
            Console.WriteLine();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. C(create)");
            Console.WriteLine("2. R(read)");
            Console.WriteLine("3. U(update)");
            Console.WriteLine("4. D(delete)");
            Console.WriteLine("5. Sair");

            do
            {
                Console.Write("Digite sua escolha: ");
                escolha = int.Parse(Console.ReadLine());

            } while (escolha < 1 || escolha > 5);

            Console.WriteLine();
            return escolha;

        }

        static void CREATE(string [] informacoes)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO CRUDsimples ([Nome da pessoa], [Data de Nascimento], [Numero RG], [Numero CPF], [Nome da Mãe], Profissão) VALUES(@Nomedapessoa, @Nascimento, @RG, @CPF, @Mae, @Profissao)", conn);
            cmd.Parameters.AddWithValue("@Nomedapessoa", informacoes[0]);
            cmd.Parameters.AddWithValue("@Nascimento", informacoes[1]);
            cmd.Parameters.AddWithValue("@RG", informacoes[2]);
            cmd.Parameters.AddWithValue("@CPF", informacoes[3]);
            cmd.Parameters.AddWithValue("@Mae", informacoes[4]);
            cmd.Parameters.AddWithValue("@Profissao", informacoes[5]);

            int rowsaffected = cmd.ExecuteNonQuery();

            conn.Close();
            if (rowsaffected > 0)
            {
                Console.WriteLine("Usuario Inserido.");
            }
            else
            {
                Console.WriteLine("Erro ao inserir usuario.");
            }
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            READ();
        }

        static void READ()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select [Nome da pessoa], [Data de Nascimento], [Numero RG], [Numero CPF], [Nome da Mãe], Profissão  from CRUDsimples", conn);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", sdr.GetString(0), sdr.GetString(1), sdr.GetString(2), sdr.GetString(3), sdr.GetString(4), sdr.GetString(5)) ;
            }
            sdr.Close();
            conn.Close();

            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();

        }

        static void UPDATE(string [] informacoes)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE CRUDsimples SET [Nome da pessoa] = @Nomedapessoa , [Data de Nascimento] = @Nascimento , [Numero RG] = @RG, [Numero CPF] =  @CPF, [Nome da Mãe] = @Mae, Profissão = @Profissao WHERE [Numero CPF] = @CPFOriginal", conn);
            cmd.Parameters.AddWithValue("@Nomedapessoa", informacoes[0]);
            cmd.Parameters.AddWithValue("@Nascimento", informacoes[1]);
            cmd.Parameters.AddWithValue("@RG", informacoes[2]);
            cmd.Parameters.AddWithValue("@CPF", informacoes[3]);
            cmd.Parameters.AddWithValue("@Mae", informacoes[4]);
            cmd.Parameters.AddWithValue("@Profissao", informacoes[5]);
            cmd.Parameters.AddWithValue("@CPFOriginal", informacoes[6]);

            int rowsaffected = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowsaffected > 0)
            {
                Console.WriteLine("Update feito.");
            }
            else
            {
                Console.WriteLine("CPF inexistente no banco de dados");
            }
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            READ();
        }

        static void DELETE(string cpf)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM CRUDsimples WHERE [Numero CPF] = @CPF", conn);
            cmd.Parameters.AddWithValue("@CPF", cpf);

            int rowsaffected = cmd.ExecuteNonQuery();
            conn.Close();

            if(rowsaffected > 0)
            {
                Console.WriteLine("Usuario Deletado.");
            }
            else{
                Console.WriteLine("CPF inexistente no banco de dados");
            }
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            READ();

        }
    }
}

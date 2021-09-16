using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: adicionar aluno
                        indiceAluno = AdicionarAluno(alunos, indiceAluno);
                        break;
                    case "2":
                        //TODO: listar alunos
                        ListarAlunos(alunos);
                        break;
                    case "3":
                        //TODO calcular média geral
                        CalcularMediaGeral(alunos);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

        private static void CalcularMediaGeral(Aluno[] alunos)
        {
            decimal noTotal = 0;
            var nrAlunos = 0;

            for (int i = 0; i < alunos.Length; i++)
            {
                if (!string.IsNullOrEmpty(alunos[i].Nome))
                {
                    noTotal = noTotal + alunos[i].Nota;
                    nrAlunos++;
                }
            }

            var mediaGeral = noTotal / nrAlunos;
            Conceito conceitoGeral;
            if (mediaGeral < 2)
            {
                conceitoGeral = Conceito.E;
            }
            else if (mediaGeral < 4)
            {
                conceitoGeral = Conceito.D;
            }
            else if (mediaGeral < 6)
            {
                conceitoGeral = Conceito.C;
            }
            else if (mediaGeral < 8)
            {
                conceitoGeral = Conceito.B;
            }
            else
            {
                conceitoGeral = Conceito.A;
            }

            Console.WriteLine($"MÉDIA GERAL: {mediaGeral} - CONCEITO: {conceitoGeral}");
        }

        private static void ListarAlunos(Aluno[] alunos)
        {
            foreach (var dados in alunos)
            {
                if (!string.IsNullOrEmpty(dados.Nome))
                {
                    Console.WriteLine($"ALUNO: {dados.Nome} - NOTA: {dados.Nota}");
                }
            }
            Console.WriteLine();
        }

        private static int AdicionarAluno(Aluno[] alunos, int indiceAluno)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Informe o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe a nota do aluno: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
            {
                aluno.Nota = nota;
            }
            else
            {
                throw new ArgumentException("Valor da nota deve ser decimal!");
            }
            Console.WriteLine();
            alunos[indiceAluno] = aluno;
            indiceAluno++;

            return indiceAluno;
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - inserir novo aluno");
            Console.WriteLine("2 - listar alunos");
            Console.WriteLine("3 - calcular média geral");
            Console.WriteLine("X - sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            Console.WriteLine();
            
            return opcaoUsuario;
        }

    }
}

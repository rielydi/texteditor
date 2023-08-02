using System;
using System.IO;

namespace textEditor
{
    class Program
    {
        static void Main(string[] args)

        {
            Menu();
        }
        static void Menu()
        {

            Console.Clear();
            Console.WriteLine("O que voce deseja realizar ?");
            Console.WriteLine("1- Abrir arquivo");
            Console.WriteLine("2= Criar novo arquivo");
            Console.WriteLine("0- Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)

            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }


        }

        static void Abrir()

        {
            Console.Clear();
            Console.WriteLine("qual caminho do arquivo deseja abrir?");
            string path = Console.ReadLine();

            using(var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
                Console.WriteLine("");
                Console.ReadLine();
                Menu();
            }
        }

        static void Editar()

        {
            Console.Clear();
            Console.WriteLine("Digite seu texto aqui: (ESC para sair!) ");
            Console.WriteLine("-----------------------");
            string text = "";

            // no 'do' é faça isso enquanto o usuario não pressione isso: ou seja não pressione a tecla escape que é o esc
            do
            {
                /*então é pegar o que ele digitou e colocar na variavel texto que é a text.
                  lembando de usar o += depois do text, pq se não ele substituirá as linhas ao escrever se deixar só o =
                  e com o sinal de + ele junta, ou seja, concatena.              
                */
                text += Console.ReadLine(); //pra ler uma linha de texto que o usuario digitou.
                text += Environment.NewLine; // é pro usuario continuar digitando e quebrando linha, se não ele fica tudo junto. ta colocando uma nova linha. quebrando a linha no fim de cada leitura.


            }
            //pra sempre armazenar algo antes de executar o While, usamos o Do
            while (Console.ReadKey().Key != ConsoleKey.Escape);  //while é usado para repetir um bloco de código enquanto uma condição é verdadeira, o switch é usado para tomar decisões com base em diferentes valores de uma expressão.
            // o consolekey.escape quer dizer que o usuario apertou a tecla esc. então ele não sairá do texto até apertar esc.
            Salvar(text);

        }

        static void Salvar( string text) //o string text a gente vai receber dentro do parametro salvar para poder salvar o arquivo.
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo? ");
            var path = Console.ReadLine(); //o Path é caminho ou seja, criando a variavel caminho. vai ser VAR pq o caminho pode ser qualquer um
           //toda vez que a gente trabalha com arquivos nós precisamos abrir e fechar o arquivo. se abrir e deixar aberto, outra pessoa não consegue abrir.
           //podemos abrir um arquivo usando o StreamReader e pode abrir um arquivo para escrita usando o StreamWriter
           //ou seja, utilizando o Using() o que ele faz ?- ele abre e fecha o arquivo. todo objeto que passar dentro do Using() ele vai abrir e fechar o objeto automaticamente. ele vai criar usar e ja fechar.
           using (var file = new StreamWriter(path)) //file=arquivo stream= fluxo. Writer=escrita. (StreamWriter= fluxo de escrita.) 
           //o StreamWriter, sempre vai pedir um caminho para o arquivo. que no caso aqui é o path
            {
                file.Write(text); // o que a gente quer escrever dentro desse arquivo, o nosso text
                Console.WriteLine($"arquivo {path} salvo com sucesso!!");
                Console.ReadLine();
                Menu();
                
            }
        }
    }
}
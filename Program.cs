using System;

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
            Console.WriteLine(text);

        }
    
        static void Salvar()
        {
            
        }   
    }
}
using System;

namespace celular_
{
    class Program
    {
        static void Main(string[] args)
        {

            celular1 C1 = new celular1();
            C1.cor = "Preto";
            C1.modelo = "Iphone";
            C1.tamanho = "Altura: 158,4 mm  Largura: 78,1 mm ";
            C1.ligado = false;
            string opcao;
            int celularopcao = 0;

            Console.WriteLine($@"
 {C1.cor}
 {C1.modelo}
 {C1.tamanho}

Deseja ligar o celular? (s/n)");

            opcao = Console.ReadLine().ToLower();

            if (opcao == "s")
            {
                C1.Ligar();
            }
            do
            {
                Console.WriteLine($@"
_____________________               
|                    |
|                    |
| 1-Mandar mensagem  |
|                    |
| 2-fazer ligaçao    |
|                    |
| 3-desligar         |
|                    |   
|                    |
|                    |
|                    |
|--------------------|
|       (   )        |
---------------------");
                celularopcao = int.Parse(Console.ReadLine());

                switch (celularopcao)
                {
                    case 1:
                        Console.WriteLine($@"Contatos:
_____________________               
|                    |
|    Contatos        |
|                    |
| -Ordilei           |
|                    |
| -Thiago            |
|                    |
| -Nathalia          |
|                    |   
| -Policia           |
|                    |
|                    |
|--------------------|
|       (   )        |
---------------------");
                        string pessoa = Console.ReadLine();
                        Console.WriteLine("Escreva sua mensagem:");
                        string mensagem = Console.ReadLine();
                        Console.WriteLine($@"
_____________________               
|                    |
| mensagem :         |
| {mensagem}         |
|                    |
| Destinatário:      |
| {pessoa}           |
|                    |
| {C1.Mensagem()}    |
|                    |   
|                    |
|                    |
|                    |
|--------------------|
|       (   )        |
---------------------");

                        break;

                    case 2:
                        Console.WriteLine($@"
_____________________               
|                    |
|    Contatos        |
|                    |
| -Ordilei           |
|                    |
| -Thiago            |
|                    |
| -Nathalia          |
|                    |   
| -Policia           |
|                    |
|                    |
|--------------------|
|       (   )        |
---------------------");
                        string nome = Console.ReadLine();

                        Console.WriteLine($@"
_____________________               
|                    |
|                    |
|      {nome}        |
|                    |
|                    |
|   {C1.Ligacao()}   |
|                    |
|                    |
|                    |   
|                    |
|                    |
|                    |
|--------------------|
|       (   )        |
---------------------");
                        break;

                    case 3:
                    C1.ligado = false;
                    Console.WriteLine($@"
                    {C1.desligar()} 
_____________________               
|                    |
|                    |
|                    |
|                    |
|                    |
|     DESLIGADO      |
|                    |
|                    |
|                    |   
|                    |
|                    |
|                    |
|--------------------|
|       (   )        |
---------------------");
                    break;

                    default:Console.WriteLine("Opção inválida");
                        break;
                }


            } while (C1.ligado == true);


          
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{ // console write line, read line e void mais usada aqui 
   class ControlCalculadora
    {
        // Criando um objeto calculadora na memória 
        ModelCalculadora calculadora;

        public ControlCalculadora() 
        {
            this.calculadora = new ModelCalculadora(); // caculadora é uma chave aqui ela recebe para que possa acessar a classe inteira 
        }// fim do construtor 

        public void Coletar () 
        {
            Console.WriteLine("informe um numero:");
            this.calculadora.GetSetnum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe outro numero:");
            this.calculadora.GetSetnum2 = Convert.ToDouble(Console.ReadLine()); 
        }// fim do coletar 



        public int Menu()
        {
            Console.WriteLine("---Menu---" +
                "\n0. Sair " +
                "\n1. Somar" +
                "\n2. Subtrair +" +
                "\n3.Dividir " +
                "\n4. Multiplicar " +
                "\n5. potencia " +
                "\n6. Raiz do primeiro numero+" +
                "\n7. Tabuada do primeiro numero " +
                "\n8. Taubuada do segundo numero" +
                "\n9. Binario para Decimal " +
                "\n.10 Decimal para Binario " +
                "\n.11 Decimal para Hexadecimal " +
                "\n;12 Hexadecimal para Decimal" +
                "\n.13 Equação de 2 grau " +
                "\n Binario para hexadecimal " +
                "\n Hexadecimal para binario" +
                "\n13. Escolha uma das opçoes acima:");
                
                

            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;

        }// fim do metodo menu 

        public void Operacao()
        {
             int opcao = 0;

            do
            {


                opcao = Menu();


                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("obrigado");
                        break;

                    case 1:
                        Coletar(); // chamando  os 2 numeros para fazer a operação 
                        Console.WriteLine("Soma:" + this.calculadora.Somar());
                        break;

                    case 2:
                        Coletar();
                        Console.WriteLine("subtração :" + this.calculadora.Substrair());
                        break;

                    case 3:
                        Coletar();
                        if (this.calculadora.Dividir() == -1)
                        {
                            Console.WriteLine("impossivel dividir");
                        }
                        else
                        {
                            Console.WriteLine("Divisão:" + this.calculadora.Dividir());
                        }
                        break;

                    case 4:
                        Coletar();
                        Console.WriteLine("Multiplicar:" + this.calculadora.Multiplicar());
                        break;

                    case 5:
                        Coletar();
                        Console.WriteLine("potencia: " + this.calculadora.Potencia());
                        break;

                    case 6:
                        Coletar();
                        Console.WriteLine("Raiz:" + this.calculadora.Raiz());
                        break;

                    case 7:

                        Console.WriteLine("Informe um numero: ");
                        this.calculadora.GetSetnum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;

                    case 8:

                        Console.WriteLine("Informe um numero: ");
                        this.calculadora.GetSetnum2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum2());
                        break;

                        // binario p decimal 
                        case 9:
                        Console.WriteLine("Informe um numero em binario para conversão:");
                        this.calculadora.GetsetBN = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.ConverterDecimal());
                        break;

                        // decimal para binario
                    case 10:
                        Console.WriteLine("Informe um numero em decimal para conversão:");
                        this.calculadora.GetSetnum1 = Convert.ToDouble(Console.Read());
                        Console.WriteLine(this.calculadora.ConverterBinario());
                        break;


                  //  decimal para hexadecimal
                    case 11:
                        Console.WriteLine("Informe um numero:");
                        this.calculadora.GetSetnum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.Hexadecimal());
                        break; 

                    default:
                        Console.WriteLine("Opçao escolhida nao e valida");
                        break;


                }// fim do switch 
            } while (opcao != 0); // fim do while
  

        }//fim do metodo  operacao 

    }// fim da classe 
}// fim do projeto 

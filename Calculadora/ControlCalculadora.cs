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
                "\n.10 Decimal para Hexadecimal " +
                "\n.11 Decimal para Binario " +
                "\n;12 Delta" +
                "\n.13 Binario para Hexadecimal " +
                "\n.14 Dobro e Triplo " +
                "\n.15 Salario" +
                "\n.16 Par e Impar " +
                "\n.17 Positivo e Negativo" +
                "\n16. Escolha uma das opçoes acima:" );
                
                // (\n ) -> para pular linha 

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
                        Console.WriteLine("Informe um valor em decimal: ");
                        Console.WriteLine(this.calculadora.ConverterBinario(Convert.ToInt32(Console.ReadLine())));
                        break;

                        
                    case 10: //  decimal para hexadecimal
                        Console.WriteLine("Informe um valor em Hexadecimal: ");
                        Console.WriteLine(this.calculadora.ConverterDecimalHexa(Console.ReadLine()));
                        break;


                    case 11: // decimal para binario
                        Console.WriteLine("Informe um valor em Decimal: ");
                        Console.WriteLine(this.calculadora.ConverterDecimalHexa(Convert.ToInt32(Console.ReadLine())));
                        break;

                        // Delta 
                    case 12:
                        Console.WriteLine("Informe A: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe B: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe C: ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.bhaskara(a, b, c));
                        break;

                        // Binario para hexadecimal
                        case 13:
                            Console.WriteLine("informe um valor em binario:");
                            string binario = Console.ReadLine();
                            Console.WriteLine(this.calculadora.ConverterBinarioHexadecimal(binario));
                        break; 

                        case 14:
                            Console.WriteLine("Informe um numero:");
                            double numero = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(this.calculadora.ConverterDobroTriplo(numero));
                        break;

                        case 15:
                        Console.WriteLine("Informe o salário do funcionário:");
                        double salariofun = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.Salario(salariofun));
                        
                        break;

                        case 16:
                            Console.WriteLine ("Informe um numéro:");
                            Console.WriteLine(this.calculadora.PareImpar());
                        break;

                        case 17:
                            Console.WriteLine("Informe um numéro:");
                            double num = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(this.calculadora.PositivoNegativo(num));
                        break;


                        case 18:
                        Console.WriteLine("Soma dos numéros de 1 até 100: ");
                        Console.WriteLine(this.calculadora.SomadosNumeros());
                        break;

                        case 19:    
                        Console.WriteLine("Informe o numero:");
                        double numerouser = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaN(numerouser));
                        break;

                        // exercicio 6
                    case 20:
                        Console.WriteLine("Informe um numéro Inicial:");
                        double numInicial = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o numéro final:");
                        double numFinal = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.NumeroInFinal(numInicial, numFinal));
                        break;


                        // exercicio 7
                        case 21:
                            Console.WriteLine(this.calculadora.ImparesePares());
                        break;







                    default:
                        Console.WriteLine("Opçao escolhida nao e valida");
                        break;


                }// fim do switch 
            } while (opcao != 0); // fim do while
  

        }//fim do metodo  operacao 

    }// fim da classe 
}// fim do projeto 

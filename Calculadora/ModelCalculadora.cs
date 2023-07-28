using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
     class ModelCalculadora
    {
        // declarando variaveis 
        private  double num1;
        private  double num2;
       
        public ModelCalculadora() 
        {
            GetSetnum1 = 0;
            GetSetnum2 = 0;
        }// fim do construtor 


        // Metodos Get e Set 

        public double GetSetnum1
        {
            get { return this.num1; }   
            set { this.num1 = value; }  
        }// Fim  do get e set 

        public double GetSetnum2
        {   get { return this.num2; }
            set { this.num2 = value; }  
        }// fim do get e set num 2 




        //  -- Metodos --  
        public double Somar() 
        {
            return GetSetnum1 + GetSetnum2;  // fazendo a soma do num1 + num2 (chamando as representantes sempre)
        }// fim do somar 

        public double Substrair()
        {
          return GetSetnum1 - GetSetnum2;
        }// fim do metodo subtrair 

        public double Dividir()
        {
            if (GetSetnum2 <= 0)
            {
                return -1;
            }
            else
            {

                return GetSetnum1 / GetSetnum2;
            }// fim
        }// fim do dividir 
           
            
          public double Multiplicar()
          { 
            return GetSetnum1 * GetSetnum2;
          }// fim do Multiplicar 

            public double Potencia() 
            {
                return Math.Pow(GetSetnum1,GetSetnum2);
            }// fim da potencia 
            
            public string Raiz() 

            {
                string msg = "raiz do primeiro número :" + Math.Sqrt(GetSetnum1) +
                             "\n Raiz do segundo numero: " + Math.Sqrt(GetSetnum2);
                return msg;
            }// fim da raiz 

        
           public string TabuadaNum1()
            {
                string resultado ="";
                 
                // inico; Fim; CONTAGEM 
                for (int i = 0; i <= 10; i++) 
                {
                    resultado += "\n" + GetSetnum1 + " * " + i + " = " + (GetSetnum1 * i);
                }// fim do for 

                return resultado; 

            }// fim da tabuada num 1


            public string TabuadaNum2()
            {
                string  resultado = "";

                for (int i = 0; i <= 10; i++)
                {
                    resultado += "\n" + GetSetnum2 + " * " + i + " = " + (GetSetnum2 * i); 
                // += pega oq esta dentro do resultado e concatena com o resto 

                }// fim do for 

                return resultado;

            }// fim da tabuada num 1

       

        // Binario para decimal 
        public int ConverterDecimal(string binario) // pegando um binario como string 
        {
            int dec = 0;
            string caract= "";
            int tamanho = binario.Length;
            int pote = tamanho;

            for (int i = 0; i < tamanho; i++) 
            {
                pote--;
                caract = binario.Substring(i, 1);
                if (caract == "1")
                {
                    dec += Convert.ToInt32(Math.Pow(2, pote));
                }
            }//fim do for
            return dec;

        }// fim do binario para decimal 

        public string ConverterBinario(int dec)
        {
            string binario = "";
            int resto = 0;
            do
            {
                resto = dec % 2;
                binario += resto;
                dec = dec / 2;
            } while (dec != 0);
            return new String(binario.Reverse().ToArray());

        }// fim do decimal para binário 
 
        public double Hexadecimal(string hexadecimal) 
        {
            double dec = 0;
            string caract = "";
            int num = 0;
            int tamanho = hexadecimal.Length;
            int pote = tamanho;
            for (int i = 0; i < tamanho; i++)
            {
                pote--;
                caract = hexadecimal.Substring(i, 1);
                switch (caract)
                {
                    case "A":
                        num = 10;
                        break;
                    case "B":
                        num = 11;
                        break;
                    case "C":
                        num = 12;
                        break;
                    case "D":
                        num = 13;
                        break;
                    case "E":
                        num = 14;
                        break;
                    case "F":
                        num = 15;
                        break;
                    default:
                        num = Convert.ToInt32(caract);
                        break;
                }//fim do switch
                dec += num * Math.Pow(16, pote);
            }//fim do for
            return dec;
        }// fim do hexadecimal 


        public string ConverterDecimalHexa(int dec)
        {
            int resto = 0;
            string hexadecimal = "";

            do
            {
                resto = dec % 16;
                switch (resto)
                {
                    case 10:
                        hexadecimal += "A";
                        break;
                    case 11:
                        hexadecimal += "B";
                        break;
                    case 12:
                        hexadecimal += "C";
                        break;
                    case 13:
                        hexadecimal += "D";
                        break;
                    case 14:
                        hexadecimal += "E";
                        break;
                    case 15:
                        hexadecimal += "F";
                        break;
                    default:
                        hexadecimal += resto;
                        break;
                }//fim do switch
                dec = dec / 16;
            } while (dec != 0);
            return new string(hexadecimal.Reverse().ToArray());
        }//fim do converter

        public string bhaskara(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta <= 0)
            {
                return "Impossível calcular X1 e X2, Delta: " + delta;
            }
            else
            {
                double X1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double X2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return "Delta: " + delta + "\nX1: " + X1 + "\nX2: " + X2;
            }
        }//fim do bhaskara

        public string ConverterBinarioHexadecimal(string binario) 
        {

            int dec = ConverterDecimal(binario);

            string hex = ConverterDecimalHexa(dec);
            return hex;

        }// fim do metodo converter binario para hexadecimal 


        // --------------------------------------------------------------------------------------------------------------

        // 01 - Converter Dobro e Triplo 
        public string ConverterDobroTriplo(double numero) 
        {
            double resultadoUm   =  numero * 2;
            double resultadoDois = numero * 3;

            return "O dobro de," + numero + "é" + resultadoUm + "e o seu triplo é:" + resultadoDois;
        
        } // fim do converter Dobro e Triplo


        // 02 - Salario 
        public string Salario(double salariofun)
        {
            string resultadosala = "";

            resultadosala += (salariofun * 30) / 100;

            return resultadosala;

        }// fim salario


        // 03 - Par e Impar 
        public string PareImpar() 
        {
            int num = 0;

            if (num % 2 == 0) 
            {
                return "O numéro:" + num + "é Par";    

            }// fim 

            else
            {
                return "O numéro digitado é Impar";
            }// fim do else 
           
        }// fim do par e Impar 

       public string PositivoNegativo(double num) 
        { 
           if (num >= 0)
            {
                return "O numéro digitado é Positivo";

            }// fim do if 

           else 
            {
               return  "O numéro digitado é Negativo";
            }// fim else 

        }// fim do positivo e negativo 




        // Exercicio 4
        public int SomadosNumeros() 
        { 
         int intnum = 1;
         int valorfinal = 0;

            for (int i = 0; i == 100; i++) 
            { 
               valorfinal += (intnum + i);
            
            } // fim do for

            return valorfinal;
        }// fim 


       // Exercico 5 
        public string TabuadaN (double numerouser)
        {
            string resultadoN = "";

            for (int i = 0; i <= 10; i++)
            {
                resultadoN += "a tabuada do:" + numerouser + "*" + (numerouser * i);

            }// fim do for

            return resultadoN;

        }// fim da tabuadaN



      // Exercicio 07
        public int ImparesePares()
        {
           int msg = 0;

            for ( int num1 = 100; num1 <= 200; num1++)
            {
                msg += num1;
            }// fim do for 

            return msg;
        }// fim do ImparesePares
        
     
        // exercicio 13
        public string Fatorial(int numFato)
        {
            for (int r = 0; int r <= numFato; r++) 
                {
                 

                }// fim do for 

        }// fim do Fatorial 
        
      

       
           
                
       

    } // fim da classe


}// fim do projeto 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        public double ConverterDecimal(string binario) // pegando um binario como string 
        {
            double dec = 0;
            string caract= "";
            int tamanho = binario.Length;
            int pote = tamanho;

            for (int i = 0; i < tamanho; i++) 
            {
                pote--;
                caract = binario.Substring(i, 1);
                if (caract == "1")
                {
                    dec += Math.Pow(2, pote);
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


    }// fim da classe


}// fim do projeto 

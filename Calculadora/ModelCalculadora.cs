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
        private double bn; 
        public ModelCalculadora() 
        {
            GetSetnum1 = 0;
            GetSetnum2 = 0;
            GetsetBN =   0; 
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


        // Get e Set binario para decimal

        public double GetsetBN
        {
            get { return this.bn; }
            set { this.bn = value; }
        } // fim do getset Bd 


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
                }// fim do for 

                return resultado;

            }// fim da tabuada num 1

       public double Binario () 
        { 

        }// fim do binario 

      }// fim da classe


}// fim do projeto 

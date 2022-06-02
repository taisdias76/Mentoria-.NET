/* Leia um valor inteiro (este número deverá conter 4 dígitos). 
A saída deverá ser o reverso de um número inteiro informado.
*/
using System;
using System.Linq;

namespace Mentoria_.NET.Exercicio_1
{
    public class NumeroInverso
    {
        public static void numeroReverso()
        {
            do{
                Console.Write("Informe um número de 4 dígitos: ");
                int num = int.Parse(Console.ReadLine());

                //convertendo o num em string
                String numString = num.ToString();
                string invertido = new string(numString.Reverse().ToArray());

                if(num >= 1000 && num <= 9999){
                    Console.WriteLine("Número invertido: " + invertido);

                    break;
                } else{
                    Console.WriteLine("Número inválido. Tente novamente");
                }
            }while(true);
        }
    }
}
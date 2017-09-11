using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace C_exemplos1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            testAula();
        }

        static void exercicio1()
        {
            #region Exercicio: 1. Ler dois valores; escrever o resultado da soma, subtracção, multiplicação e divisão dos valores definidos 
        
        int numero1 = 0;

        int numero2 = 0;

        int Soma = 0;

        int Subtracao = 0;

        int Multiplicacao = 0;

        double Divisao = 0;

        string input1 = "";
        string input2 = "";

        Console.WriteLine("");
        Console.WriteLine("Defina o 1º valor: ");
        input1 = Console.ReadLine();
        int.TryParse(input1, out numero1);
        //numero1 = int.Parse(input1);

        Console.WriteLine("Defina o 2º valor: ");
        input2 = Console.ReadLine();
        int.TryParse(input2, out numero2);
        Console.WriteLine();
        //numero2 = int.Parse(input2);
        Console.WriteLine("SOMA DE DOIS NUMEROS");
        Soma = numero1 + numero2;
        Console.WriteLine("O resultado da soma é : " + Soma);

        Console.WriteLine();

        Console.WriteLine("DIVISAO DE DOIS NUMEROS");
        //Divisão de 2 numeros


        Divisao = (double)numero1 / numero2;
        Console.WriteLine("O resultado da divisão é : " + Divisao);

        Console.WriteLine();
        Console.WriteLine("SUBTRAÇÂO DE DOIS NUMEROS");

        Subtracao = numero1 - numero2;
        Console.WriteLine("O resultado da Subtração é : " + Subtracao);

        Console.WriteLine();
        Console.WriteLine("MULTIPLICAÇÂO DE DOIS NUMEROS");

        Multiplicacao = numero1 * numero2;
        Console.WriteLine("O resultado da Multiplicação é : " + Multiplicacao);
        Console.WriteLine("");
        //Console.ReadKey();
        Console.ReadKey();

        //Como fazer
        Console.WriteLine("COMO FAZER DA MANEIRA MAIS CORRECTA \n");
        Console.WriteLine("O resultado da soma é : {0}" + "\nO resultado da divisão é : {1}" + "\nO resultado da subtracção é : {2}" + "\nO resultado da multiplicação é : {3}", Soma, Divisao, Subtracao, Multiplicacao);

        Console.ReadKey();
        
        #endregion
        }

        static void exercicio2()
        {
            #region Exercicio 2: Calcular o resultado de n elevado a m
            string N1 = "";
            string M1 = "";
            int N = 0;
            int M = 0;
            double resultado = 0;

            Console.WriteLine("Introduzir valor N: ");
           
            N1 = Console.ReadLine();
            int.TryParse(N1, out N);
            Console.WriteLine("Introduzir valor M: ");
            M1 = Console.ReadLine();
            int.TryParse(M1, out M);

            resultado = Math.Pow(N, M);

            Console.WriteLine("O resultado é : "+ resultado);

            Console.ReadKey();

            #endregion
        }

        static void exercicio3()
        {
            #region Exercicio 3: Efectuar a conversão de uma temperatura definida em Celsius e efectuar a conversão para Fahrenheit; considere a fórmula F = C × 1,8 + 32

            double Celsius = 0;
            double Fahrenheit = 0;

            Console.WriteLine("Inserir valor da temperatura em Celsius: ");

            Celsius= double.Parse(Console.ReadLine());

            //F = C × 1,8 + 32
            Fahrenheit = Celsius * 1.8 + 32;

            Console.WriteLine("O resultado da temperatura em Fahrenheit: " + Fahrenheit);
            Console.ReadKey();

            #endregion
        }

        static void exercicio4()
        {
            #region Exercicio 4: Resolver a expressão 2x2/4 + (3x3+4y)/(x+y/2)

            double x = 0;
            double y = 0;
            double resultado = 0;

            Console.WriteLine("Resolver a expressao 2x2/4 + (3x3+4y)/(x+y/2)");
            Console.WriteLine("Introduzir valor x: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzir valor y: ");
            y = double.Parse(Console.ReadLine());

            resultado = 2 * (Math.Pow(x,2)) + 3 * (Math.Pow(x,3) + (4 * y)) / (( x + y )/ 2);


            Console.WriteLine("O resultado é " + resultado);
            Console.ReadKey();

            #endregion
        }

        static void exercicio5()
        {
            #region Exercicio 5: Calcular a área e o perímetro de rectângulo

            double BASE = 0;
            double ALTURA = 0;
            double AREA = 0;
            double PERIMETRO = 0;

            Console.WriteLine("Calcular a área e o perímetro de rectângulo\n");
            Console.WriteLine("Introduza o valor para a Base: ");
            BASE = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduza o valor para a Altura: ");
            ALTURA = double.Parse(Console.ReadLine());

            AREA = BASE * ALTURA;

            PERIMETRO = 2 * (BASE * ALTURA);

            Console.WriteLine("O valor para da Area é: {0}" + "\ne do Perimetro é: {1}", AREA, PERIMETRO);
            Console.ReadKey();

            #endregion
        }

        static void exercicio6()
        {
            #region Exercicio 6: Calcular a área e perímetro de um círculo
            double PI = 3.1415926;
            double DIAMETRO = 0;
            double RAIO = 0;
            double AREA = 0;
            double PERIMETRO = 0;   

            Console.WriteLine(" Calcular a área e perímetro de um círculo");
            Console.WriteLine(" Inserir valor do Raio: ");
            string R = Console.ReadLine();
            double.TryParse(R, out RAIO);

            Console.WriteLine(" ou do DIAMETRO: ");
            string D = Console.ReadLine();
            double.TryParse(D, out DIAMETRO);
            
            if (RAIO > 0){

                DIAMETRO = RAIO * 2;
                AREA = PI * (RAIO * RAIO);
                PERIMETRO = PI * DIAMETRO;
                Console.WriteLine("A Área é: " + AREA);
                Console.WriteLine("O Perimetro é: " + PERIMETRO);
            }
            else if (DIAMETRO > 0){

                RAIO = DIAMETRO / 2;
                AREA = PI * (RAIO * RAIO);
    
                PERIMETRO = PI * DIAMETRO;
                Console.WriteLine("A Área é: " + AREA);
                Console.WriteLine("O Perimetro é: " + PERIMETRO);
            }

            else if (RAIO == 0 && DIAMETRO ==0){

                Console.WriteLine("Sem dados necessários para efectuar o calculo");
            }
            Console.ReadKey();
            #endregion

        }

        static void exercicio7()
        {
            #region Exercicio 7: Calcular o custo final de um produto, dado pela fórmula custo final = custo + (custo * iva)

            
            double CUSTO = 0;
            double IVA = 0;
            double RESULTADO = 0;

            Console.WriteLine("Inserir custo do produto; ");
            string C = Console.ReadLine();
            double.TryParse(C, out CUSTO);

            Console.WriteLine("Inserir iva do produto; ");
            string I = Console.ReadLine();
            double.TryParse(I, out IVA);


            RESULTADO = (CUSTO * (IVA / 100)) + CUSTO;

            Console.WriteLine("O resultado é: " + RESULTADO);
            Console.ReadKey();
            #endregion
        }

        static void ponto6()
        {
            #region Ponto 6:Formatação do datatype String
            //o tipo de dados String inclui um conjunto de métodos que permitem obter  
            //partes de uma String, o número de caracteres que contém ou efectuar a sua 
            //transformação em maiúsculas ou minúsculas;  
            string palavra = "Benfica";

             //a sequência \n cria uma quebra de linha Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("palavra definida - {0}\n", palavra); Console.ResetColor();  

             //1) o tamanho da palavra  
             //a função Length devolve o tamanho de uma String  

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) o tamanho da palavra\n");
            Console.ResetColor();
            int tamanho = 0;
            tamanho = palavra.Length;
            Console.WriteLine("o tamanho da string definida é {0}\n", tamanho);


             //2) o primeiro caracter  
             //a função SubString permite obter uma parte de uma String  
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("2) o primeiro caracter \n");
            Console.ResetColor();

            string primeiro1 = "";
            primeiro1 = palavra.Substring(0, 1); 

            //a função recebe a posição inicial a partir da qual queremos 
            //obter a parte da string e o número de caracteres a obter; 
            //considerando que a posição de qualquer colecção (neste caso, //colecção de caracteres) começa em zero, o objectivo é a partir da //posição 0 ler 1 caracter;  
            Console.WriteLine("com Substring - primeiro caracter da string definida - {0}\n", primeiro1);

            //a String pode ainda ser considerada como um array de caracteres; //neste sentido, também podemos obter o primeiro caracter com a instrução:  
            char primeiro2 = palavra[0]; Console.WriteLine("com Char - primeiro caracter da string definida - {0}\n", primeiro2);

            //3) o último caracter               
            //a função Length devolve o tamanho de uma String; considerando que a  
            //colecção de caracteres da String começa na posição zero, então a última  
            //posição da String é dada pela fórmula Length  -1   
            Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("3) o último caracter\n"); Console.ResetColor();
            int ultima_posicao = palavra.Length - 1; string ultimo1 = ""; ultimo1 = palavra.Substring(ultima_posicao, 1);

            Console.WriteLine("com Substring - último caracter da string definida - {0}\n", ultimo1);

            //também podemos obter o último caracter com a instrução:  
            char ultimo2 = palavra[ultima_posicao];
            Console.WriteLine("com Char - último caracter da string definida - {0}\n", ultimo2);

            //4) os caracteres nas posições 1 a 4  
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("4) os caracteres nas posições 1 a 4\n");
            Console.ResetColor();
            string posicoes_1_a_4 = ""; posicoes_1_a_4 = palavra.Substring(1, 4);
            Console.WriteLine("com Substring - posições 1 a 4 da string definida - {0}\n", posicoes_1_a_4);

            //também podemos obter os caracteres com as instruções:   
            Console.Write("com Char - posições 1 a 4 da string definida - {0}{1}{2}{3}\n\n", palavra[1], palavra[2], palavra[3], palavra[4]);

            //5) os três últimos caracteres  
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("5) os três últimos caracteres\n");
            Console.ResetColor();

            string ultimas_3_posicoes = "";
            ultimas_3_posicoes = palavra.Substring(tamanho - 3, 3);
            Console.WriteLine("com Substring - últimas 3 posições da string definida - {0}\n", ultimas_3_posicoes);


            //também podemos obter os caracteres com as instruções: Console.Write("com Char - últimas 3 posições da string definida - {0}{1}{2}\n\n", palavra[tamanho - 3], palavra[tamanho - 2], palavra[tamanho - 1]);  
            //6) todos os caracteres com excepção do primeiro  
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("6) todos os caracteres com excepção do primeiro\n");
            Console.ResetColor();

            string posicoes_1_a_ultima = "";
            int numero_caracateres_a_ler = tamanho - 1;
            posicoes_1_a_ultima = palavra.Substring(1, numero_caracateres_a_ler);
            Console.WriteLine("com Substring - posições 1 a final da string definida - {0}\n", posicoes_1_a_ultima);


            //também podemos obter os caracteres com as instruções:  
            Console.Write("com Char - posições 1 a final da string definida - ");
            for (int i = 1; i < tamanho; i++)
            { Console.Write("{0}", palavra[i]); }
            Console.WriteLine("\n\npressione uma tecla para terminar...");
            Console.ReadKey();
        


        #endregion 
        }

        static void ponto7()
        {
            #region Ponto 7: Class Math
                //a classe Math disponibiliza um conjunto de funções matemáticas; 
                //para a resolução deste problema considere as funções 
                //Math.Pow(base,expoente), que devolve a base elevada ao expoente 
                //Math.Sqrt(numero), que devolve a raiz quadrada de um número  
                Console.WriteLine("defina um número:");
                double numero = double.Parse(Console.ReadLine());

                //quadrado  
                double quadrado = 0;
                quadrado = Math.Pow(numero, 2);
                Console.WriteLine("\nquadrado de {0} = {1}\n", numero, quadrado);

                //cubo double cubo = 0; cubo = Math.Pow(numero, 3); Console.WriteLine("cubo de {0} = {1}\n", numero, cubo);  
                //raiz quadrada   
                double raiz_quadrada = 0;
                raiz_quadrada = Math.Sqrt(numero);
                Console.WriteLine("raiz quadrada de {0} = {1}\n", numero, raiz_quadrada);

                //raiz cúbica   
                double raiz_cubica = 0; 

                //a class Math não tem uma função para calcular a raiz cúbica 
                //pelo que a alternativa em termos de cálculo passa por //elevar o número a 1/3;  
                double expoente = 1.0 / 3.0; raiz_cubica = Math.Pow(numero, expoente);
                Console.WriteLine("raiz cúbica de {0} = {1}\n", numero, raiz_cubica);
                Console.WriteLine("pressione um tecla para continuar...");
                Console.ReadKey();


            #endregion
        }

        
        static void ponto8()
        {
            #region valor do tipo string (string palavra = Console.ReadLine();) e que inverta o valor definido (exemplo: “123” para “321”)

            //definir palavra a inverter  
            string palavra = Console.ReadLine();

            //inverter 
            char[] arr = palavra.ToCharArray();

            //o método Reverse permite inverter o array de caracteres 
            Array.Reverse(arr);

            //escrever resultado      
            string palavra_invertida = new string(arr);
            Console.WriteLine("palavra definida - {0}\n", palavra);
            Console.WriteLine("após a inversão - {0}\n", palavra_invertida);  

            Console.WriteLine("pressione um tecla para continuar...");
            Console.ReadKey();

            #endregion
        }

        static void testArea()
        {
            #region Executar até que o tipo de data seja o correcto 

            bool valor = false;
            //string jogador = "";
            int number = 0;
            Console.WriteLine("1. Quantos golos marcou o Benfica?:");

                while (valor == false)
                {
                    if (!int.TryParse(Console.ReadLine(), out number))
                    {
                        Console.WriteLine("Valor introduzido, tem que ser um numero inteiro.");
                    
                    }
                    else
                    {

                        Console.WriteLine("O Benfica marcou: {0}", number);
                        valor = true;
                        
                        
                    }   
                 }


            valor = false;

            while (valor == false)
                {

                // if (Information.IsNumeric(jogador) || jogador == " ")
                //Regex = regular expressions tenta confirmar se apenas as letras de a-z e A-Z fazem parte da variavel jogador
                //Regex.IsMatch(jogador, "[a-zA-Z ]")
                        Console.WriteLine("Quem marcou os golos?");
                        string jogador = " ";
                        jogador = Console.ReadLine();

                        // se o valor da string for nulo ou estiver vazio é invalido, cobre a possibilidade de o utilizador premir apenas ENTER
                        if (string.IsNullOrEmpty(jogador))
                        {
                                Console.WriteLine("Valor introduzido invalido, introduzir o nome do jogador.");
                                
                         }
                        // se for tudo letras executa
                        //else if (jogador.All(char.IsLetter))
                        else if (Regex.IsMatch(jogador, "[a-zA-Z ]"))
                        { 
                                Console.WriteLine();
                                Console.WriteLine("Quem marcou foi: {0}", jogador);
                                Console.WriteLine();
                                valor = true;
                                Console.ReadKey();
                        }
                        // só para ter a certeza que recebe msg se introduzir algo para alem de letras
                        else
                        {
                                Console.WriteLine("Valor introduzido invalido, introduzir o nome do jogador.");
                        }      
                    
                }


            string[] plantel = { "Jonas", "Mitroglou", "Jimenez", "Salvio", "Fedja", "Júlio César", "Paulo Lopes","Ederson",
                "André Almeida", "Nélson Semedo", "Luisão", "Jardel", "Lisandro", "Vitaly", "Grimaldo", "Marçal", "Pawel Dawidowicz", "Gilson",
                "João Teixeira", "Pizzi", "Gonçalo Guedes", "Rui Fonte", "Saponjic", "Andre Carrillo", "Luka Jovic" };
            string[] equipaPrincipal = new string[11];
            string nao = " ";
            string sim = " ";
          
            valor = false;

            Console.WriteLine("Escolher o 11 inicial da equipa do Benfica, da seguinte lista");

            while (valor == false)
            {


                for (int i = 0; i < plantel.Length; i++)
                {

                    foreach (var name in plantel)
                    {
                        Console.Write(name.ToString());
                        Console.WriteLine();
                        Console.WriteLine("Quer este jogador para o onze inicial?\t Escreva Sim " + " ou " + "Não");
                        Console.ReadLine();


                        equipaPrincipal[i] = plantel[i];


                        if (equipaPrincipal.Length < 12)
                        {
                            Console.WriteLine("Ainda não escolheu todos os jogadores");
                        }
                        else if (equipaPrincipal.Length == 11)
                        {
                            Console.WriteLine("O 11 inicial é {0}", equipaPrincipal);
                            valor = true;
                        }


                    }
                }
            }
            #endregion  
        }

        static void testAula()
        {
            #region organizar array por ordem crescente
            //organizar array por ordem crescente
            int[] valores1 = { 6, 3, 9, 8, 10, 2, 1, 7 };
            int temp = 0;
            //int[] valorers2 = { }

            for (int i = 0; i < valores1.Length - 1; i++)
            {
                for (int j = i + 1; j < valores1.Length; j++)
                {
                    if (valores1[i] > valores1[j])
                    {

                        temp = valores1[i];


                    }
                    else if (valores1[i] < valores1[j])
                    {
                        valores1[j] = valores1[i]

                    }

                }
            }
            Console.ReadKey();
            #endregion
        }

            static void exercicio4Aula()
        {
            #region Indicar o nome e a média

            {

                List<int> lista = new List<int>();
                int i = 0;
                //preencher
                Random r = new Random();
                for (i = 1; i < 11; i++)
                {
                    lista.Add(r.Next(-10, 11));
                }
                //escrever
                Console.WriteLine("valores definidos");
                foreach (int numero in lista)
                {
                    Console.Write("{0}\t", numero);
                }
                //indicar a soma e a média dos valores definidos;
                int soma = 0;
                double media = 0;
                foreach (int numero in lista)
                {
                    soma = soma + numero;
                }
                media = (double)soma / lista.Count;
                //ou
                Console.WriteLine("\n\nSoma - {0}", lista.Sum());
                Console.WriteLine("\nMédia - {0}", lista.Average());

                //indicar os valores máximo e mínimo;
                int max = lista[0], min = lista[0];
                foreach (int numero in lista)
                {
                    if (numero > max) max = numero;
                    if (numero < min) min = numero;
                }
                //ou
                Console.WriteLine("\nMáximo - {0}", lista.Max());
                Console.WriteLine("\nMinimo - {0}", lista.Min());
                //indicar o total de valores positivos, negativos e iguais a zero;
                int positivos = 0, negativos = 0, zeros = 0;
                foreach (int numero in lista)
                {
                    if (numero < 0) negativos++;
                    else if (numero == 0) zeros++;
                    else positivos++;
                }
                //ou
                negativos = lista.Where(numero => numero < 0).Count();
                zeros = lista.Where(numero => numero == 0).Count();
                positivos = lista.Where(numero => numero > 0).Count();
                Console.WriteLine("\nNegativos - {0}", negativos);
                Console.WriteLine("\nZeros - {0}", zeros);
                Console.WriteLine("\nPositivos - {0}", positivos);

                //inverter os valores;
                lista.Reverse();
                Console.WriteLine("\ninverter os valores");
                foreach (int numero in lista)
                {
                    Console.Write("{0}\t", numero);
                }
                //ordenar os valores por ordem crescente;
                lista.Sort();
                Console.WriteLine("\n\ncrescente");
                foreach (int numero in lista)
                {
                    Console.Write("{0}\t", numero);
                }
                //ordenar os valores por ordem decrescente;
                lista.Sort();
                lista.Reverse();
                Console.WriteLine("\n\ndecrescente");
                foreach (int numero in lista)
                {
                    Console.Write("{0}\t", numero);
                }

                //procurar um valor N na lista;
                Console.WriteLine("\n\ninsira valor a procurar: ");
                int procurar = int.Parse(Console.ReadLine());
                bool existe1 = false;
                foreach (int numero in lista)
                {
                    if (numero == procurar)
                    {
                        existe1 = true;
                        break;
                    }
                }
                //ou
                int existe2 = lista.Find(numero => numero == procurar);
                if (existe1 == true && existe2 > 0)
                    Console.WriteLine("O número {0} faz parte da lista.", procurar);
                else
                    Console.WriteLine("O número {0} não faz parte da lista.", procurar);
                //escrever apenas os valores pares;
                Console.WriteLine("\nvalores pares: ");
                foreach (int numero in lista)
                {
                    if (numero % 2 == 0)
                        Console.Write("{0}\t", numero);
                }

                //ou
                Console.WriteLine("\n");
                List<int> pares = lista.Where(numero => numero % 2 == 0).ToList();
                foreach (int numero in pares)
                {
                    Console.Write("{0}\t", numero);
                }
                Console.ReadLine();
            
        }
            #endregion
        }

    }
}

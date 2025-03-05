using System.Xml;

namespace Funções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = AskNumber("Digite o primeiro número:");
            int num2 = AskNumber("Digite o segundo número:");
            int result = Lista5Ex1(num1, num2);
            Console.WriteLine("Resultado da soma é: " + result);

            int num3 = AskNumber("Digite um número para calcular o fatorial: ");
            int result2 = Lista5Ex2(num3);
            Console.WriteLine("O fatorial é: " + result2);

            int num4 = AskNumber("Digite um número para saber se é primo: ");
            Lista5Ex3(num4);

            List<int> numeros1 = new List<int> { 12, 54, 3, 87, 34, 99, 7 };
            int maior = Lista5Ex4(numeros1);
            Console.WriteLine($"O maior valor da lista é: {maior}");

            Console.WriteLine("Digite uma string para inverter:");
            string entrada = Console.ReadLine();
            string invertida = Lista5Ex5(entrada);
            Console.WriteLine($"A string invertida é: {invertida}");

            double[] numeros = { 7, 4, 3, 20, 17 };
            Lista5Ex6(numeros);

            Console.WriteLine("Digite uma string para verificar se é um palíndromo:");
            string entrada2 = Console.ReadLine();
            string invertida2 = Lista5Ex5(entrada2);
            Console.WriteLine(Lista5Ex7(entrada2));

            Console.WriteLine("Digite a temperatura em graus Celsius: ");
            double temperaturaCelsius = double.Parse(Console.ReadLine());
            double temperaturaEmFahrenheit = Lista5Ex8(temperaturaCelsius);
            Console.WriteLine($"A temperatura em Fahrenheit é: {temperaturaEmFahrenheit}");

            Console.WriteLine("Fibonacci 30 termos");
            Lista5Ex14();

            double numeroPosNegZero = 0;
            Lista5Ex15(numeroPosNegZero);

            Console.WriteLine("Calculadora:");
            Lista5Ex16();

            Console.WriteLine("Número primo ou não");
            Lista5Ex17();

            Console.WriteLine("Sequência de Fibonacci");
            Lista5Ex18();

            string[] listaStrings = { "olá", "programação", "exemplo", "teste", "computador" };
            int countStrings = Lista5Ex9(listaStrings);
            Console.WriteLine($"Número de strings com mais de 5 caracteres: {countStrings}");

            int mdcResult = Lista5Ex10(num1, num2);
            Console.WriteLine($"O MDC entre {num1} e {num2} é: {mdcResult}");

            List<int> listaNumeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> pares = Lista5Ex11(listaNumeros);
            Console.WriteLine("Números pares na lista: " + string.Join(", ", pares));

            int elemento = AskNumber("Digite um número para contar quantas vezes aparece na lista:");
            int countElemento = Lista5Ex12(listaNumeros, elemento);
            Console.WriteLine($"O número {elemento} aparece {countElemento} vezes na lista.");

            int numParaContarDigitos = AskNumber("Digite um número para contar quantos dígitos ele tem:");
            int numeroDigitos = Lista5Ex19(numParaContarDigitos);
            Console.WriteLine($"O número {numParaContarDigitos} tem {numeroDigitos} dígitos.");

            double num5 = AskNumber("Digite o primeiro número para calcular a média: ");
            double num6 = AskNumber("Digite o segundo número para calcular a média: ");
            double num7 = AskNumber("Digite o terceiro número para calcular a média: ");
            double media = Lista5Ex20(num5, num6, num7);
            Console.WriteLine($"A média dos números {num5}, {num6}, {num7} é: {media}");
        }
    
        static int AskNumber(string question)
        {
            int number;
            Console.WriteLine(question);
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }
            return number;
        }

        //1. Crie uma função que recebe dois números inteiros como parâmetros e retorna a sua soma.
        static int Lista5Ex1(int num1, int num2)
        {
            try
            {
                var sum = num1 + num2;
                return sum;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        //2. Escreva uma função que calcule o fatorial de um número inteiro passado como argumento.
        static int Lista5Ex2(int num3)
        {
            try
            {
                int fatorial = 1;
                for (int i = 1; i <= num3; i++)
                {
                    fatorial *= i;
                }
                return fatorial;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        //3. Desenvolva uma função que verifique se um número é primo ou não.
        static void Lista5Ex3(int num4)
        {
            try
            {
                if (num4 <= 1)
                {
                    Console.WriteLine($"O número {num4} não é primo");
                    return;
                }
                bool isPrimo = true;

                for (int i = 2; i < num4; i++)
                {
                    if (num4 % i == 0)
                    {
                        isPrimo = false;
                        break;
                    }
                }
                if (isPrimo)
                {
                    Console.WriteLine($"O número {num4} é primo");
                }
                else
                {
                    Console.WriteLine($"O número {num4} não é primo");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //4. Implemente uma função que receba uma lista de inteiros e retorne o maior valor presente na lista.
        static int Lista5Ex4(List<int> numeros1)
        {
            try
            {
                 int maiorValor = numeros1[0];

                foreach (int numero in numeros1)
                {
                    if (numero > maiorValor)
                    {
                        maiorValor = numero;
                    }
                }
                return maiorValor;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                return 0;
            }
        }


        //5. Crie uma função que inverta uma string passada como parâmetro (sem usar funções de inversão embutidas).
        static string Lista5Ex5(string str)
        {
            try
            {
                string invertida = "";

                for (int i = str.Length - 1; i >= 0; i--)
                {
                    invertida += str[i];
                }

                return invertida;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao inverter a string: {ex.Message}");
                return string.Empty;
            }
        }

        //6. Escreva uma função que calcule a média de uma lista de números reais.
        static void Lista5Ex6(double[] numeros)
        {
            try
            {
                double soma = 0;

                for (int i = 0; i < numeros.Length; i++) //.Length volta a quantidade de elementos no array
                {
                    soma += numeros[i];
                }

                double media = soma / numeros.Length;
                Console.WriteLine($"A média das notas é: {media}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao calcular a média: {ex.Message}");
            }
        }

        //7. Desenvolva uma função que verifique se uma string é um palíndromo (ela lê o mesmo de trás para frente) ou não.
        static string Lista5Ex7(string str)
        {
            try
            {
                string invertida2 = "";

                for (int i = str.Length - 1; i >= 0; i--)
                {
                    invertida2 += str[i];
                }

                if (str == invertida2)
                {
                    return "A string é um palíndromo.";
                }
                else
                {
                    return "A string não é um palíndromo.";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                return string.Empty;
            }
        }

        //8. Implemente uma função que receba um valor em graus Celsius e retorne o equivalente em Fahrenheit.
        static double Lista5Ex8(double temperaturaCelsius)
        {
            try
            {
                double temperaturaEmFahrenheit = (temperaturaCelsius * 1.8) + 32;
                return temperaturaEmFahrenheit;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                return 0;
            }
        }

        //9. Crie uma função que receba um array de strings e retorne a quantidade de strings que possuem mais de 5 caracteres.
        static int Lista5Ex9(string[] strings)
        {
            try
            {
                int count = 0;

                foreach (var str in strings)
                {
                    if (str.Length > 5)
                    {
                        count++;
                    }
                }

                return count;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                return 0;
            }
        }

        //10. Escreva uma função que calcule o máximo divisor comum (MDC) entre dois números inteiros.
        static int Lista5Ex10(int num1, int num2)
        {
            try
            {
                while (num2 != 0)
                {
                    int temp = num2;
                    num2 = num1 % num2;
                    num1 = temp;
                }

                return num1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                return 0;
            }
        }

        //11. Desenvolva uma função que receba uma lista de inteiros e retorne uma nova lista com os números pares.
        static List<int> Lista5Ex11(List<int> numeros)
        {
            try
            {
                List<int> pares = new List<int>();

                foreach (var numero in numeros)
                {
                    if (numero % 2 == 0)
                    {
                        pares.Add(numero);
                    }
                }

                return pares;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                return new List<int>();
            }
        }

        //12. Implemente uma função que conte quantas vezes um determinado elemento aparece em uma lista.
        static int Lista5Ex12(List<int> numeros, int elemento)
        {
            try
            {
                int count = 0;

                foreach (var numero in numeros)
                {
                    if (numero == elemento)
                    {
                        count++;
                    }
                }

                return count;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                return 0;
            }
        }

        //13. Crie uma função que receba uma string e retorne outra string com todas as letras maiúsculas convertidas para minúsculas e vice-versa.
        static void Lista5Ex13()
        {
            Console.WriteLine("Digite uma frase para inversão");
            string frase = Console.ReadLine();

            Console.WriteLine($"Entrada {frase}, saida {InvertMaiuscula(frase)}");
        }
        static string InvertMaiuscula(string frase)
        {
            try
            {
                string novaFrase = "";

                foreach (char c in frase)
                {
                    if (char.IsUpper(c))
                    {
                        novaFrase += char.ToLower(c);
                    }
                    else
                    {
                        novaFrase += char.ToUpper(c);
                    }
                }

                return novaFrase;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                return string.Empty;
            }
        }

        //14. Escreva uma função que calcule o valor da série de Fibonacci para um dado número de termos.
        static void Lista5Ex14()
        {
            try
            {
                int termo1 = 0, termo2 = 1, proximoTermo;

                for (int i = 1; i <= 30; i++)
                {
                    Console.Write($"{termo1} ");
                    proximoTermo = termo1 + termo2;
                    termo1 = termo2;
                    termo2 = proximoTermo;
                }
                Console.WriteLine();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        //15. Desenvolva uma função que determine se um número é positivo, negativo ou zero.
        static void Lista5Ex15(double numeroPosNegZero)
        {
            try
            {
                Console.WriteLine("Digite um número para saber se ele é positivo, negativo ou zero:");
                double numeroPNZ = double.Parse(Console.ReadLine());

                if (numeroPNZ < 0)
                {
                    Console.WriteLine($"O número {numeroPNZ} é negativo.");
                }
                else if (numeroPNZ > 0)
                {
                    Console.WriteLine($"O número {numeroPNZ} é positivo.");
                }
                else
                {
                    Console.WriteLine($"O número {numeroPNZ} é zero.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        //16. Calculadora Simples - Crie uma função chamada Calculadora que recebe dois números e um operador (+, -, *, /) como parâmetros e retorna o resultado da operação.
        static void Lista5Ex16()
        {
            try
            {
                Console.WriteLine("Insira um número:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira outro número:");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira um operador:");
                string operador = Console.ReadLine();
                double resultado = 0;

                switch (operador)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;

                    case "-":
                        resultado = (num2 - num1);
                        break;
                    case "/":
                        resultado = num1 / num2;
                        break;
                    case "*":
                        resultado = num1* num2;
                        break;
                }
                Console.WriteLine($"Resultado: {num1} {operador} {num2} = {resultado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        //17. Verificação de Número Primo - Escreva uma função chamada Primo que recebe um número inteiro como parâmetro e retorna true se o número for primo e false caso contrário.
        static void Lista5Ex17()
        {
            try
            {
                Console.WriteLine("Digite um número inteiro: ");
                int numeroInteiro = int.Parse(Console.ReadLine());
                bool numeroPrimo = true;

                for (int i = 2; i < numeroInteiro; i++)
                {
                    if (numeroInteiro % i == 0)
                    {
                        numeroPrimo = false;
                        break;
                    }
                }
                if (numeroPrimo)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        //18. Sequência de Fibonacci - Implemente uma função chamada Fibonacci que recebe um número inteiro n como parâmetro e retorna uma lista contendo os primeiros n números da sequência de Fibonacci.
        static void Lista5Ex18()
        {
            try
            {  
                int n = int.Parse(Console.ReadLine());
                int termo1 = 0, termo2 = 1, proximoTermo;
                        
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"{termo1} ");
                    proximoTermo = termo1 + termo2;
                    termo1 = termo2;
                    termo2 = proximoTermo;
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        //19. Contagem de Dígitos - Crie uma função chamada ContarDigitos que recebe um número inteiro como parâmetro e retorna o número de dígitos no número.
        static int Lista5Ex19(int numero)
        {
            try
            {
                int count = 0;

                while (numero != 0)
                {
                    numero /= 10;
                    count++;
                }

                return count;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                return 0;
            }
        }

        //20. Média de Números - Desenvolva uma função chamada CalcularMedia que recebe 3 números e retorna a média dos itens.
        static double Lista5Ex20(double num1, double num2, double num3)
        {
            try
            {
                double media = (num1 + num2 + num3) / 3;
                return media;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                return 0;
            }
        }

    }
}
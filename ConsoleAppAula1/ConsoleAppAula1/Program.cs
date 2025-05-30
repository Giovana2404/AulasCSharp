
/*Idade IF
int idade;
Console.WriteLine("Informe sua idade!");

idade = Convert.ToInt32(
    Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine($"Sua idade é {idade}, você é maior de idade.");
}

else
{
    Console.WriteLine($"Sua idade é {idade}, você é menor de idade.");
}

Console.WriteLine($"Sua idade é {idade}");
*/


/*Exemplo salário IF (meu jeito)
decimal salario;
Console.WriteLine("Informe seu salário: ");

salario = Convert.ToDecimal(
    Console.ReadLine() );

if (salario > 1518)
{
    Console.WriteLine($"Seu salário é {salario:C}, é um salário maior que o minimo.");
}

else if (salario < 1518)
{
    Console.WriteLine($"Seu salário é {salario:C}, é um salário menor que o mínimo.");
}

else
{
    Console.WriteLine($"Seu salário é {salario:C}, é um salário mínimo.");
}
*/


/*Salário (Jeito do professor)
const decimal salarioMinimo = 1518m;

Console.WriteLine("Digite o salário do funcionário: R$");
decimal salarioFuncionario = decimal.Parse(Console.ReadLine());

if (salarioFuncionario == salarioMinimo)
{
    Console.WriteLine($"O funcionário recebe o salário mínimo {salarioFuncionario:C}");
}
else
{
    Console.WriteLine($"O funcionário NÃO recebe o salário mínimo {salarioFuncionario:C}");
}
*/


/* Contas
int num1 = 8;
int num2 = 2;

//Soma
Console.WriteLine($"Soma: {num1 + num2}");

//Subtração
Console.WriteLine($"Subtração: {num1 - num2}");

//Multiplicação
Console.WriteLine($"Multiplicação: {num1 * num2}");

//Divisão
Console.WriteLine($"Divisão: {num1 / num2}");
*/


/* Contas else if
float num1 = 0f;
float num2 = 0f;
string operacaoMatematica;

Console.WriteLine("Informe a operação matemática:\n" + "+ ou - ou * ou /");
operacaoMatematica = Console.ReadLine();

Console.WriteLine("Informe o primeiro valor: ");
num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo valor: ");
num2 = float.Parse(Console.ReadLine());



if (operacaoMatematica == "+")
{
    Console.WriteLine($"Soma: {(num1 + num2):F2}");
}

else if (operacaoMatematica == "-")
{
    Console.WriteLine($"Subtração: {(num1 - num2):F2}");
}

else if (operacaoMatematica == "*")
{
    Console.WriteLine($"Multiplicação: {(num1 * num2):F2}");
}

else if (operacaoMatematica == "/")
{
    Console.WriteLine($"Divisão: {(num1 / num2):F2}");
}

else { Console.WriteLine("Operação inválida"); }
*/

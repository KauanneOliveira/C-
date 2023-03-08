double num1= 0;
double num2= 0;

Console.WriteLine("Calculadora Console em C#\r");
Console.WriteLine("------------------------------------------------------\n");

Console.WriteLine("Digite um número e pressione Enter:");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite outro número e pressione Enter:");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Escolha uma opção da lista seguinte:");
Console.WriteLine("\ta- Soma");
Console.WriteLine("\ts- Subtração");
Console.WriteLine("\tm- Multiplicação");
Console.WriteLine("\td- Divisão");
Console.WriteLine("Qual a sua opção:");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Seu resultado: {num1} + {num2} =" + (num1 + num2)); // para aparecer o conteudo das informaçoes digitadas, que usuarios entrou, usa $ e coloca as variáveis em chaves {}
        break;
    case "s":
        Console.WriteLine($"Seu resultado: {num1} - {num2} = " + (num1 - num2));  
        break;
    case "m":
        Console.WriteLine($"Seu resultado: {num1} * {num2} = " + (num1 * num2));
        break;   
    case "d":
        while(num2 == 0){
            Console.WriteLine("Erro - Divisão por zero");
            Console.WriteLine("Digite outro número:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Seu resultado: {num1} / {num2} = " + (num1 / num2));
        }
        break; 
    default:
        Console.WriteLine("Opção Inválida!");
        break;
}
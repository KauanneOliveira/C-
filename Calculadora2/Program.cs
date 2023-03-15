class Calculadora {
    public static double Operacao( double num1, double num2, string opcao){

        double resultado= double.NaN;   //not-a-number. NaN é uma variável associada ao TryParse, se o TryParse reconhecer a informação q está entrando como um número ela desabilita o true do NaN e coloca esse dado na variável, caso contrário ela continue como true, ou seja, sem número.
        switch(opcao){
            case "a":
               resultado= num1 + num2;
                break;
            case "s":
                resultado= num1 - num2; 
                break;
            case "m":
                resultado= num1 * num2;
                break;   
            case "d":
                if(num2 != 0)
                    resultado= num1/num2; 
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
        return resultado;
    }
}


class Programa {
     static void Main(String[] args){

         bool fimPrograma= false;
         string n1= "";
         string n2= "";
         double num1= 0;
         double num2= 0;
         double resultado= 0;
         string opcao;

         Console.WriteLine("Calculadora Console em C#\r");
         Console.WriteLine("--------------------------------------\n");

         while( ! fimPrograma ){
             Console.WriteLine("Digite um número e pressione Enter:");
             n1 = Console.ReadLine();

             while( ! double.TryParse(n1, out num1) ){                               // caso colocar uma letra ou algo q não seja número, vai ficar nesse laço até colocar um número
                 Console.WriteLine("Número Inválido. Digite um número válido:");     // TryParse resulta em um booleano informando se a conversão foi possível e caso verdade, o valor da conversão.
                 n1= Console.ReadLine();                                             // no parâmetro do TryParse o primeiro valor é o dado entrado pelo usuário e o segundo parâmetro é a resposta, então se dado digitado for um número o TryParse vai reconhecer e vai mandar o valor para a variável de saída 
             }

             Console.WriteLine("Digite outro número válido:");                       // depois de ser colocado um número, vai pedir para colocar o segundo numero
             n2= Console.ReadLine();

             while( ! double.TryParse(n2, out num2) ){                               //se não for número, fica nesse laço até ser um 
                 Console.WriteLine("Número Inválido. Digite outro número válido:");
                 n2= Console.ReadLine();
             }

             Console.WriteLine("Escolha uma opção da lista seguinte:");
             Console.WriteLine("\ta- Soma");
             Console.WriteLine("\ts- Subtração");
             Console.WriteLine("\tm- Multiplicação");
             Console.WriteLine("\td- Divisão");
             Console.WriteLine("Qual a sua opção:");
            
             opcao= Console.ReadLine();

             try {
                 resultado= Calculadora.Operacao( num1, num2, opcao);

                 if( double.IsNaN(resultado) ){  
                     Console.WriteLine("Esta operação resultará em um erro matemático.\n");
                 } 
                 else
                     Console.WriteLine("Seu resultado é : {0:0.####}\n", resultado);
             }
             catch( Exception e) {
                 Console.WriteLine("Ocorreu uma exceção.\n -Detalhes:" +e.Message);
             }

             Console.Write("Pressione 'n' para fechar a aplicação ou pressione qualquer tecla para continuar:");
            
             if( Console.ReadLine() == "n")
                 fimPrograma = true;
            
             Console.WriteLine("\n");
             }
             return;
        }
}

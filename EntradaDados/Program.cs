int numero= -1;
while(numero != 10){
    Console.Write("Digite um número: "); 
    numero = Convert.ToInt32(Console.ReadLine());  
    if(numero < 10){
        Console.WriteLine("Você errou, tente um número maior");  
    }
    else if(numero > 10){
        Console.WriteLine("Você errou, tente um número menor");
    }
    else{
        Console.WriteLine("Parabéns, você acertou!");
    }
}   
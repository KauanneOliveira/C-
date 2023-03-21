 var fibonacciNumeros = new List<int> {1,1};

 var previo = fibonacciNumeros[fibonacciNumeros.Count -1]; //Count é contador e o Length é tamanho
 var previo2= fibonacciNumeros[fibonacciNumeros.Count -2];  // numeros.ForEach(numero => Console.Write(numero+ " ")); - numeros é a lista, numero é a variável, => esse operador  

 fibonacciNumeros.Add( previo + previo2 );   

 var previo3 = fibonacciNumeros[fibonacciNumeros.Count -1]; 
 var previo4= fibonacciNumeros[fibonacciNumeros.Count -2];

 fibonacciNumeros.Add( previo3 + previo4 );


 foreach( var item in fibonacciNumeros){
     Console.WriteLine(item);
 }

var fibonacciNumeros = new List<int> {1,1};

for( int i=1; i <= 19; i++){
    
    var previo = fibonacciNumeros[fibonacciNumeros.Count -1];
    var previo2= fibonacciNumeros[fibonacciNumeros.Count -2];
    fibonacciNumeros.Add( previo + previo2 );

    Console.WriteLine($"O item " +i+ ": " +fibonacciNumeros[i]);
}








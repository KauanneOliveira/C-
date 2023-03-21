var fibonacciNumeros = new List<int> {1,1};

var previo = fibonacciNumeros[fibonacciNumeros.Count -1];
var previo2= fibonacciNumeros[fibonacciNumeros.Count -2]; 

fibonacciNumeros.Add( previo + previo2 );   

var previo3 = fibonacciNumeros[fibonacciNumeros.Count -1]; 
var previo4= fibonacciNumeros[fibonacciNumeros.Count -2];

fibonacciNumeros.Add( previo3 + previo4 );


foreach( var item in fibonacciNumeros){
    Console.WriteLine(item);
}

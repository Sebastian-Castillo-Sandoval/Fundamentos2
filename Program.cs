/*//Imprimir 1-255​
static void PrintNumbers()
{
    for( int i=1; i<256; i++){
        Console.WriteLine(i);
}
}
PrintNumbers();

//Imprimir números impares entre 1-255​
static void PrintOdds()
{
    for( int i=1; i<256; i++){
        if(i%2 !=0){
            Console.WriteLine(i);
        }
    }
}
PrintOdds();

// Imprimir Suma
static void PrintSum()
{
    int suma = 0;
   for( int i=0; i<256; i++){
        suma = suma + i;
        Console.WriteLine($"New number: {i} Suma: {suma}");
        }       
    }

PrintSum();

//4. Iterar a través de una matriz​
static void LoopArray(int[] numbers)
{
      for( int i=0; i<numbers.Length; i++){
        
        Console.WriteLine($"Number: {numbers[i]}");
        }       
    }
int []valores = new int []{1,2,3,4,5,6,7,8,9,10};
LoopArray(valores);

//5. Encuentra el valor máximo
static int FindMax(int[] numbers)
{
int numMayor = 0;
    for( int i=0; i<numbers.Length; i++){
        if(numbers[i]>numMayor){
            numMayor = numbers[i];
    }
}
    Console.WriteLine($"El numero mayor es: {numMayor}");
    return numMayor;
}
int []valores = new int []{11,2,-3,4,13,0,-7,8,9,-10};
int numMayor = FindMax(valores);

//6. Obtén el Promedio​
static void GetAverage(int[] numbers)
{
    int promedio = 0;
    int suma = 0;
    for( int i=0; i<numbers.Length; i++){
       suma = numbers[i] + suma;
    }
    promedio = suma/numbers.Length;
    Console.WriteLine($"El promedio es: {promedio}");
}
int []valores = new int []{5,10,15};
GetAverage(valores);

//7. Lista con números impares​
static List<int> OddList()
{
    List <int> numerosImpares = new List<int>();
    for( int i=1; i<256; i++){
        if(i%2 !=0){
        numerosImpares.Add(i);
        }
    }
    return numerosImpares;
    
}
List<int>impares = OddList();
foreach(int j in impares){
        Console.WriteLine(j);
}

//8. Mayor que Y​
static int GreaterThanY(List<int> numbers, int y)
{
   int contador = 0;
    for( int i=0; i<numbers.Count; i++){
        if(numbers[i]>y){
            contador = contador + 1;
        } 
    }
    return contador;
}
List<int>numeros = new List<int>{3,5,8,10,18,25,30};
int cantidad = GreaterThanY(numeros, 6);
Console.WriteLine(cantidad);

//9. Haz Cuadrar los Valores
static void SquareArrayValues(List<int> numbers)
{
   int numero = 0;
    for( int i=0; i<numbers.Count; i++){
        numero = numbers[i]*numbers[i];
        Console.WriteLine(numero);
    } 
}
List<int>numbers = new List<int>{1,2,3,4,5};
SquareArrayValues(numbers);

//10. Elimina los Números Negativos​
static void EliminateNegatives(List<int> numbers)
{
    for( int i=0; i<numbers.Count; i++){
        if(numbers[i]<0)
        numbers[i]=0;
        Console.WriteLine(numbers[i]);
    } 
}
List<int>numbers = new List<int>{1,2,-3,4,-5};
EliminateNegatives(numbers);
*/




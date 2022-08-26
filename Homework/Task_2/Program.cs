// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите M - ");
int M= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N - ");
int N= Convert.ToInt32(Console.ReadLine());

void SumNumbers (int a, int b){
    int sum=0;
    for (int i=a ; i <= N; i++){
        sum+=i;
    }
    Console.WriteLine(sum);
}
SumNumbers(M,N);
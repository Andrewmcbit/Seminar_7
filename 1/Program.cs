/*Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.*/

void PrintNumbers(int start, int end){
    Console.Write(start + " ");
    if (start < end) {
        PrintNumbers(start+1, end);
    }
}

int M = 11;
int N = 28;

PrintNumbers(M,N);
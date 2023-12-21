/*Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.*/

int akkerman(int m, int n) {
    if (m == 0){
        return n + 1;
    } else {
        if (n == 0) {
            return akkerman(m - 1, 1);
        }
        else return akkerman(m - 1, akkerman(m, n - 1));
    }
}

int n = 2;
int m = 3;
Console.Write($"A(m,n) = {akkerman(m, n)}");
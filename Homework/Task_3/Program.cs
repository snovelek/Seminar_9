// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

        Console.Write("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Accerman(n, m);
        
        int Accerman(int n, int m)
        {
            if (n == 0) 
                return m + 1;
            if (n != 0 && m == 0) 
                return Accerman(n - 1, 1);
            if (n > 0 && m > 0) 
                return Accerman(n - 1, Accerman(n, m - 1));
            return Accerman(n,m);
        }
        Console.WriteLine(Accerman(n,m));
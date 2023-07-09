// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Write("Введите число: ");
int r = Convert.ToInt32(Console.ReadLine());



int ThirdDigit(int r)
        {
            
            
                if (r > 99)
            
                while (r > 999)
                {
                    r = r / 10;
                }
                int result = r % 10;
            return result;
                 

        }

if (r<100)
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine(ThirdDigit(r));
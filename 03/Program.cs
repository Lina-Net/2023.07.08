// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Write("Введите день недели: ");
int d = Convert.ToInt32(Console.ReadLine());

bool Nd(int d)
{
    if (d>7)
        return true;
    else return false;
}

bool B(int d)
{
    if (d<6 && d>0)
        return true;
    else return false;
}   
if (Nd(d))
    Console.WriteLine("Такого дня недели не существует");
else    
    if (B(d))
        Console.WriteLine("Не выходной:(");
    else 
        Console.WriteLine("ВЫХОДНОЙ!!!");
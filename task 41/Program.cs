/* 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4
*/
int inData(int i)
{

    Console.WriteLine("Введите число: \n*** для выхода введите 'q' ***");
    var inConsole = Console.ReadLine();
    int n;

    if (inConsole == "q")  // если ввели 'q', то ввыводим счётчик и завершаем цикл программы.
    {
        quit(i);
    }
    else if (int.TryParse(inConsole, out n)) // проверяем что это число и запускаем опрос ещё раз пока не будет введено 'q'
    {
        if (Convert.ToInt32(inConsole) > 0) i++; // если число больше 
        inData(i);
    }
    else // если не число и не 'q' то запускаем опрос ещё раз
    {
        inData(i);
    }
    return i;
}

void quit(int count)
{
    if (count <= 0)
    {
        Console.WriteLine("Ввод завершён, небыло чисел > 0");
    }
    else if (count > 5)
    {
        Console.WriteLine("Ввод завершён, больше нуля " + count + " чисел");
    }
    else if (count == 1)
    {
        Console.WriteLine("Ввод завершён, больше нуля " + count + " число");
    }
    else if (count > 1 & count < 5)
    {
        Console.WriteLine("Ввод завершён, больше нуля " + count + " числа");
    }
}


inData(0);
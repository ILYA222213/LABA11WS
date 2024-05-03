using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем делегат, который возвращает название дня недели
        DayOfWeek getDayOfWeek = () =>
        {
            // Получаем текущий день недели
            int dayOfWeekIndex = (int)DateTime.Now.DayOfWeek;

            // Возвращаем название дня недели
            switch (dayOfWeekIndex)
            {
                case 0: return "Воскресенье";
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                default: return "Неизвестный день недели";
            }
        };

        // Вызываем делегат 7 раз, чтобы получить название всех дней недели
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine(getDayOfWeek());
        }
    }

    // Определяем делегат, который возвращает название дня недели
    public delegate string DayOfWeek();
}
public class Time
{
    private int hours; //поля
    private int minutes;
    private int seconds;

    public Time(int hours, int minutes, int seconds) //конструктор
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public int Hours //get set годин
    {
        get { return hours; }
        set
        {
            if (value >= 0 && value <= 23)
            {
                hours = value;
            }
            else
            {
                throw new ArgumentException("Invalid value for hours.");
            }
        }
    }

    public int Minutes //get set хвилин
    {
        get { return minutes; }
        set
        {
            if (value >= 0 && value <= 59)
            {
                minutes = value;
            }
            else
            {
                throw new ArgumentException("Invalid value for minutes.");
            }
        }
    }

    public int Seconds //get set секунд
    {
        get { return seconds; }
        set
        {
            if (value >= 0 && value <= 59)
            {
                seconds = value;
            }
            else
            {
                throw new ArgumentException("Invalid value for seconds.");
            }
        }
    }

    public void SetHour() //функція зміни годин
    {
        Console.WriteLine("Введіть годину");
        int value = Convert.ToInt32(Console.ReadLine());
        if (value >= 0 && value <= 24)
        {
            hours = value; 
        }
        else
        {
            Console.WriteLine("Помилка, введено не коректні дані");
        }
    }

    public void SetMin() //функція зміни хвилин
    { 
        Console.WriteLine("Введіть хвилину");
        int value = Convert.ToInt32(Console.ReadLine());
        if (value >= 0 && value <= 59)
        {
           minutes = value;
        }
        else
        {
            Console.WriteLine("Помилка, введено не коректні дані");
        }
    }

    public void SetSec() //функція зміни секунд
    {
        Console.WriteLine("Введіть секунди");
        int value = Convert.ToInt32(Console.ReadLine());
        if (value >= 0 && value <= 59)
        {
            seconds = value;
        }
        else
        {
            Console.WriteLine("Помилка, введено не коректні дані");
        }
    }

    public void DisplayTime() // вивід поточної години
    {

        Console.WriteLine("Поточна година: " + hours + ":" + minutes + ":" + seconds);
    }
}
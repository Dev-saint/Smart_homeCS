using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Smart_homeCS
{
    class Kitchen
    {
        private int coffee; //Приготовление кофе после сна
        private Parametrs param_kitch = new Parametrs();

        //Конструктор
        public Kitchen()
        {
            this.param_kitch.Set_parametrs(0, 0, 0, 0, 0, 0);
            this.coffee = 0;
        }

        //Конструктор с одним параметром
        public Kitchen(double temp)
        {
            this.param_kitch.Set_parametrs(temp, 0, 0, 0, 0, 0);
            this.coffee = 0;
        }

        //Конструктор с параметрами
        public Kitchen(double temp, double hum, double co2, int bright, int l, int speed, int cof)
        {
            this.param_kitch.Set_parametrs(temp, hum, co2, bright, l, speed);
            this.coffee = cof;
        }

        //Функции получения данных из полей
        public double Get_air_temp_kitch()
        {
            return this.param_kitch.Get_air_temp();
        }

        public double Get_air_hum_kitch()
        {
            return this.param_kitch.Get_air_hum();
        }

        public double Get_conc_co2_kitch()
        {
            return this.param_kitch.Get_conc_co2();
        }

        public int Get_brightness_kitch()
        {
            return this.param_kitch.Get_brightness();
        }

        public int Get_light_kitch()
        {
            return this.param_kitch.Get_light();
        }

        public int Get_vent_speed_kitch()
        {
            return this.param_kitch.Get_vent_speed();
        }

        public int Get_coffee()
        {
            return this.coffee;
        }

        //Функции задания полей
        public void Set_air_temp_kitch(double temp)
        {
            this.param_kitch.Set_air_temp(temp);
        }

        public void Set_air_hum_kitch(double hum)
        {
            this.param_kitch.Set_air_hum(hum);
        }

        public void Set_conc_co2_kitch(double co2)
        {
            this.param_kitch.Set_conc_co2(co2);
        }

        public void Set_brightness_kitch(int bright)
        {
            this.param_kitch.Set_brightness(bright);
        }

        public void Set_light_kitch(int l)
        {
            this.param_kitch.Set_light(l);
        }

        public void Set_vent_speed_kitch(int speed)
        {
            this.param_kitch.Set_vent_speed(speed);
        }

        public void Set_coffee(int cof)
        {
            this.coffee = cof;
        }

        //Задание полей класса кухня
        public void Set_parametrs_kitch(double temp, double hum, double co2, int bright, int l, int speed, int cof)
        {
            this.param_kitch.Set_air_temp(temp);
            this.param_kitch.Set_air_hum(hum);
            this.param_kitch.Set_conc_co2(co2);
            this.param_kitch.Set_brightness(bright);
            this.param_kitch.Set_light(l);
            this.param_kitch.Set_vent_speed(speed);
            this.coffee = cof;
        }

        //Вывод параметров кухни на экран
        public void DisplayKitch()
        {
            Console.WriteLine("\nТемература воздуха на кухне: " + this.Get_air_temp_kitch() + " °С");
            Console.WriteLine("Влажность воздуха на кухне: " + this.Get_air_hum_kitch() + " %");
            Console.WriteLine("Концентрация CO2 на кухне: " + this.Get_conc_co2_kitch() + " %");
            Console.WriteLine("Яркость света на кухне: " + this.Get_brightness_kitch() + " %");
            Console.WriteLine("Флажок света на кухне: " + this.Get_light_kitch());
            Console.WriteLine("Скорость вентиляции на кухне: " + this.Get_vent_speed_kitch() + " %");
            Console.WriteLine("Флажок кофе на кухне: " + this.Get_coffee());
        }

        public void coffee_machine() //Функция приготовления кофе
        {
            if (this.coffee == 1)
            {
                Console.WriteLine("Кофе готовится...");
                Thread.Sleep(5000);
                Console.WriteLine("Кофе готов!");
            }
        }

        public void menu_kitch() // Функция вызова меню параметров для кухни
        {
            Console.Write("1. Температура воздуха\n"
                + "2. Влажность воздуха\n"
                + "3. Концентрация CO2\n"
                + "4. Яркость света\n"
                + "5. Включение/выключение света\n"
                + "6. Скорость вентиляции\n"
                + "7. Приготовление кофе\n"
                + "Выбранный пункт: ");
        }
    }
}

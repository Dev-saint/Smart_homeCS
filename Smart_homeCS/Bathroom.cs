using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Smart_homeCS
{
    class Bathroom
    {
        private int flag_water; //Флаг набора воды
        private Parametrs param_bath = new Parametrs();

        //Конструктор
        public Bathroom()
        {
            this.param_bath.Set_parametrs(0, 0, 0, 0, 0, 0);
            this.flag_water = 0;
        }

        //Конструктор с одним параметром
        public Bathroom(double temp)
        {
            this.param_bath.Set_parametrs(temp, 0, 0, 0, 0, 0);
            this.flag_water = 0;
        }

        //Конструктор с параметрами
        public Bathroom(double temp, double hum, double co2, int bright, int l, int speed, int water)
        {
            this.param_bath.Set_parametrs(temp, hum, co2, bright, l, speed);
            this.flag_water = water;
        }

        //Функции получения данных из полей
        public double Get_air_temp_bath()
        {
            return this.param_bath.Get_air_temp();
        }

        public double Get_air_hum_bath()
        {
            return this.param_bath.Get_air_hum();
        }

        public double Get_conc_co2_bath()
        {
            return this.param_bath.Get_conc_co2();
        }

        public int Get_brightness_bath()
        {
            return this.param_bath.Get_brightness();
        }

        public int Get_light_bath()
        {
            return this.param_bath.Get_light();
        }

        public int Get_vent_speed_bath()
        {
            return this.param_bath.Get_vent_speed();
        }

        public int Get_flag_water()
        {
            return this.flag_water;
        }

        //Функции задания полей
        public void Set_air_temp_bath(double temp)
        {
            this.param_bath.Set_air_temp(temp);
        }

        public void Set_air_hum_bath(double hum)
        {
            this.param_bath.Set_air_hum(hum);
        }

        public void Set_conc_co2_bath(double co2)
        {
            this.param_bath.Set_conc_co2(co2);
        }

        public void Set_brightness_bath(int bright)
        {
            this.param_bath.Set_brightness(bright);
        }

        public void Set_light_bath(int l)
        {
            this.param_bath.Set_light(l);
        }

        public void Set_vent_speed_bath(int speed)
        {
            this.param_bath.Set_vent_speed(speed);
        }

        public void Set_flag_water(int water)
        {
            this.flag_water = water;
        }

        //Задание полей класса ванная
        public void Set_parametrs_bath(double temp, double hum, double co2, int bright, int l, int speed, int water)
        {
            this.param_bath.Set_air_temp(temp);
            this.param_bath.Set_air_hum(hum);
            this.param_bath.Set_conc_co2(co2);
            this.param_bath.Set_brightness(bright);
            this.param_bath.Set_light(l);
            this.param_bath.Set_vent_speed(speed);
            this.flag_water = water;
        }

        //Вывод параметров ванной на экран
        public void DisplayBath()
        {
            Console.WriteLine("\nТемература воздуха в ванной: " + this.Get_air_temp_bath() + " °С");
            Console.WriteLine("Влажность воздуха в ванной: " + this.Get_air_hum_bath() + " %");
            Console.WriteLine("Концентрация CO2 в ванной: " + this.Get_conc_co2_bath() + " %");
            Console.WriteLine("Яркость света в ванной: " + this.Get_brightness_bath() + " %");
            Console.WriteLine("Флажок света в ванной: " + this.Get_light_bath());
            Console.WriteLine("Скорость вентиляции в ванной: " + this.Get_vent_speed_bath() + " %");
            Console.WriteLine("Флаг набора воды в ванной: " + this.Get_flag_water());
        }

        public void water_bath()   //Функция набора воды в ванную
        {
            if (this.flag_water == 1)
            {
                Console.WriteLine("Включен набор воды в ванную.");
                Thread.Sleep(5000);
                Console.WriteLine("Вода набрана!");
            }
        }

        public void menu_bath() // Функция вызова меню параметров для ванной
        {
            Console.Write("1. Температура воздуха\n"
                + "2. Влажность воздуха\n"
                + "3. Концентрация CO2\n"
                + "4. Яркость света\n"
                + "5. Включение/выключение света\n"
                + "6. Скорость вентиляции\n"
                + "7. Набор воды в ванную\n"
                + "Выбранный пункт: ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_homeCS
{
    class Bedroom : Parametrs
    {
        private Parametrs param_bed = new Parametrs();

        //Конструктор
        public Bedroom()
        {
            this.param_bed.Set_parametrs(0, 0, 0, 0, 0, 0);
        }

        //Конструктор с одним параметром
        public Bedroom(double temp)
        {
            this.param_bed.Set_parametrs(temp, 0, 0, 0, 0, 0);
        }

        //Конструктор с параметрами
        public Bedroom(double temp, double hum, double co2, int bright, int l, int speed)
        {
            this.param_bed.Set_parametrs(temp, hum, co2, bright, l, speed);
        }

        //Функции получения данных из полей
        public double Get_air_temp_bed()
        {
            return this.param_bed.Get_air_temp();
        }

        public double Get_air_hum_bed()
        {
            return this.param_bed.Get_air_hum();
        }

        public double Get_conc_co2_bed()
        {
            return this.param_bed.Get_conc_co2();
        }

        public int Get_brightness_bed()
        {
            return this.param_bed.Get_brightness();
        }

        public int Get_light_bed()
        {
            return this.param_bed.Get_light();
        }

        public int Get_vent_speed_bed()
        {
            return this.param_bed.Get_vent_speed();
        }

        //Функции задания полей
        public void Set_air_temp_bed(double temp)
        {
            this.param_bed.Set_air_temp(temp);
        }

        public void Set_air_hum_bed(double hum)
        {
            this.param_bed.Set_air_hum(hum);
        }

        public void Set_conc_co2_bed(double co2)
        {
            this.param_bed.Set_conc_co2(co2);
        }

        public void Set_brightness_bed(int bright)
        {
            this.param_bed.Set_brightness(bright);
        }

        public void Set_light_bed(int l)
        {
            this.param_bed.Set_light(l);
        }

        public void Set_vent_speed_bed(int speed)
        {
            this.param_bed.Set_vent_speed(speed);
        }

        //Задание полей класса спальня
        public void Set_parametrs_bed(double temp, double hum, double co2, int bright, int l, int speed, int cof)
        {
            this.param_bed.Set_air_temp(temp);
            this.param_bed.Set_air_hum(hum);
            this.param_bed.Set_conc_co2(co2);
            this.param_bed.Set_brightness(bright);
            this.param_bed.Set_light(l);
            this.param_bed.Set_vent_speed(speed);
        }

        //Вывод параметров спальни на экран
        public void DisplayBed()
        {
            Console.WriteLine("\nТемература воздуха в спальне: " + this.Get_air_temp_bed() + " °С");
            Console.WriteLine("Влажность воздуха в спальне: " + this.Get_air_hum_bed() + " %");
            Console.WriteLine("Концентрация CO2 в спальне: " + this.Get_conc_co2_bed() + " %");
            Console.WriteLine("Яркость света в спальне: " + this.Get_brightness_bed() + " %");
            Console.WriteLine("Флажок света в спальне: " + this.Get_light_bed());
            Console.WriteLine("Скорость вентиляции в спальне: " + this.Get_vent_speed_bed() + " %");
        }

        public void menu_bed() // Функция вызова меню параметров спальни
        {
            Console.Write("1. Температура воздуха\n"
                + "2. Влажность воздуха\n"
                + "3. Концентрация CO2\n"
                + "4. Яркость света\n"
                + "5. Включение/выключение света\n"
                + "6. Скорость вентиляции\n"
                + "Выбранный пункт: ");
        }
    }
}

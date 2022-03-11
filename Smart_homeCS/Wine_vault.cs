using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_homeCS
{
    class Wine_vault
    {
        private Parametrs param_wine;

        //Конструктор
        public Wine_vault()
        {
            this.param_wine.Set_parametrs(0, 0, 0, 0, 0, 0);
        }

        //Функции получения данных из полей
        public double Get_air_temp_wine()
        {
            return this.param_wine.Get_air_temp();
        }

        public double Get_air_hum_wine()
        {
            return this.param_wine.Get_air_hum();
        }

        public double Get_conc_co2_wine()
        {
            return this.param_wine.Get_conc_co2();
        }

        public int Get_brightness_wine()
        {
            return this.param_wine.Get_brightness();
        }

        public int Get_light_wine()
        {
            return this.param_wine.Get_light();
        }

        public int Get_vent_speed_wine()
        {
            return this.param_wine.Get_vent_speed();
        }

        //Функции задания полей
        public void Set_air_temp_wine(double temp)
        {
            this.param_wine.Set_air_temp(temp);
        }

        public void Set_air_hum_wine(double hum)
        {
            this.param_wine.Set_air_hum(hum);
        }

        public void Set_conc_co2_wine(double co2)
        {
            this.param_wine.Set_conc_co2(co2);
        }

        public void Set_brightness_wine(int bright)
        {
            this.param_wine.Set_brightness(bright);
        }

        public void Set_light_wine(int l)
        {
            this.param_wine.Set_light(l);
        }

        public void Set_vent_speed_wine(int speed)
        {
            this.param_wine.Set_vent_speed(speed);
        }

        //Задание полей класса винный погреб
        public void Set_parametrs_wine(double temp, double hum, double co2, int bright, int l, int speed)
        {
            this.param_wine.Set_air_temp(temp);
            this.param_wine.Set_air_hum(hum);
            this.param_wine.Set_conc_co2(co2);
            this.param_wine.Set_brightness(bright);
            this.param_wine.Set_light(l);
            this.param_wine.Set_vent_speed(speed);
        }

        //Вывод параметров винного погреба на экран
        public void DisplayWine()
        {
            Console.WriteLine("\nТемература воздуха в винном погребе: " + this.Get_air_temp_wine() + " °С");
            Console.WriteLine("Влажность воздуха в винном погребе: " + this.Get_air_hum_wine() + " %");
            Console.WriteLine("Концентрация CO2 в винном погребе: " + this.Get_conc_co2_wine() + " %");
            Console.WriteLine("Яркость света в винном погребе: " + this.Get_brightness_wine() + " %");
            Console.WriteLine("Флажок света в винном погребе: " + this.Get_light_wine());
            Console.WriteLine("Скорость вентиляции в винном погребе: " + this.Get_vent_speed_wine() + " %");
        }

        public void menu_wine() // Функция вызова меню параметров для винного погреба
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_homeCS
{
    public class Toilet : Parametrs
    {
        //private Parametrs param_toil = new Parametrs(); //Параметры туалета

        /*private static Toilet lastToil;
        private Toilet prev;
        private Toilet next;*/

        /*// Новый список
        public void NewList()
        {
            lastToil = null;
        }

        // Добавление элемента в конец списка
        public void Add()
        {
            if (lastToil == null)
                this.prev = null;
            else
            {
                lastToil.next = this;
                prev = lastToil;
            }
            lastToil = this;
            this.next = null;
        }

        // Вывод на дисплей содержимого списка
        public void reprint()
        {
            Toilet uk;   // Вспомогательная ссылка
            uk = lastToil;
            if (uk == null)
            {
                Console.WriteLine("Список пуст!");
                return;
            }
            else
                Console.WriteLine("\nСодержимое списка:\n");

            // Цикл печати в обратном порядке значений элементов списка:
            while (uk != null)
            {
                uk.param_toil.Display();
                Console.WriteLine("\t");
                uk = uk.prev;
            }
        }*/

        //Конструктор
        public Toilet() : base(0, 0, 0, 0, 0, 0)
        {
            //this.param_toil.Set_parametrs(0, 0, 0, 0, 0, 0);
        }

        //Конструктор с одним параметром
        public Toilet(double temp) : base(temp, 0, 0, 0, 0, 0)
        {
            //this.param_toil.Set_parametrs(temp, 0, 0, 0, 0, 0);
        }

        //Конструктор с параметрами
        public Toilet(double temp, double hum, double co2, int bright, int l, int speed) : base(temp, hum, co2, bright, l, speed)
        {
            //this.param_toil.Set_parametrs(temp, hum, co2, bright, l, speed);
        }

        // Ввод параметров туалета
        public override void Inp()
        {
            string tmp;
            Console.Write("Введите температуру воздуха: ");
            tmp = Console.ReadLine();
            air_temp = Convert.ToDouble(tmp);
            Console.Write("Введите влажнность воздуха: ");
            tmp = Console.ReadLine();
            air_hum = Convert.ToDouble(tmp);
            Console.Write("Введите концентрацию CO2: ");
            tmp = Console.ReadLine();
            conc_co2 = Convert.ToDouble(tmp);
            Console.Write("Введите яркость света: ");
            tmp = Console.ReadLine();
            brightness = Convert.ToInt32(tmp);
            Console.Write("Введите флаг света: ");
            tmp = Console.ReadLine();
            light = Convert.ToInt32(tmp);
            Console.Write("Введите скорость вентиляции: ");
            tmp = Console.ReadLine();
            vent_speed = Convert.ToInt32(tmp);
        }

        // Понижение температуры на 5 градусов
        public override double Temp_up()
        {
            air_temp -= 5;
            Console.WriteLine("Уменьшение на 5 градусов");
            return air_temp;
        }

        /*//Функции получения данных из полей
        public double Get_air_temp_toil()
        {
            return this.param_toil.Get_air_temp();
        }

        public double Get_air_hum_toil()
        {
            return this.param_toil.Get_air_hum();
        }

        public double Get_conc_co2_toil()
        {
            return this.param_toil.Get_conc_co2();
        }

        public int Get_brightness_toil()
        {
            return this.param_toil.Get_brightness();
        }

        public int Get_light_toil()
        {
            return this.param_toil.Get_light();
        }

        public int Get_vent_speed_toil()
        {
            return this.param_toil.Get_vent_speed();
        }

        //Функции задания полей
        public void Set_air_temp_toil(double temp)
        {
            this.param_toil.Set_air_temp(temp);
        }

        public void Set_air_hum_toil(double hum)
        {
            this.param_toil.Set_air_hum(hum);
        }

        public void Set_conc_co2_toil(double co2)
        {
            this.param_toil.Set_conc_co2(co2);
        }

        public void Set_brightness_toil(int bright)
        {
            this.param_toil.Set_brightness(bright);
        }

        public void Set_light_toil(int l)
        {
            this.param_toil.Set_light(l);
        }

        public void Set_vent_speed_toil(int speed)
        {
            this.param_toil.Set_vent_speed(speed);
        }

        //Задание полей класса туалет
        public void Set_parametrs_toil(double temp, double hum, double co2, int bright, int l, int speed)
        {
            this.param_toil.Set_air_temp(temp);
            this.param_toil.Set_air_hum(hum);
            this.param_toil.Set_conc_co2(co2);
            this.param_toil.Set_brightness(bright);
            this.param_toil.Set_light(l);
            this.param_toil.Set_vent_speed(speed);
        }*/

        // Метод ToString
        public String ToString()
        {
            return ("\nТемература воздуха в туалете: " + air_temp + "\nВлажность воздуха в туалете: " + air_hum +
                "\nКонцентрация CO2 в туалете: " + conc_co2 + "\nЯркость света в туалете: " + brightness +
                "\nФлажок света в туалете: " + light + "\nСкорость вентиляции в туалете: " + vent_speed + "\n");
        }

        //Вывод параметров туалета на экран
        public override void Display()
        {
            Console.WriteLine("\nТемература воздуха в туалете: " + air_temp + " °С");
            Console.WriteLine("Влажность воздуха в туалете: " + air_hum + " %");
            Console.WriteLine("Концентрация CO2 в туалете: " + conc_co2 + " %");
            Console.WriteLine("Яркость света в туалете: " + brightness + " %");
            Console.WriteLine("Флажок света в туалете: " + light);
            Console.WriteLine("Скорость вентиляции в туалете: " + vent_speed + " %");
        }

        public void menu_toil() // Функция вызова меню параметров для туалета
        {
            Console.Write("1. Температура воздуха\n"
                + "2. Влажность воздуха\n"
                + "3. Концентрация CO2\n"
                + "4. Яркость света\n"
                + "5. Включение/выключение света\n"
                + "6. Скорость вентиляции\n"
                + "Выбранный пункт: ");
        }

        /*// Проверка возврата значения по ref
        public void TestRef4(ref int Value)
        {
            Value = 4;
        }

        // Проверка возврата значения по out
        public void TestOut5(out int Value)
        {
            Value = 5;
        }*/

        // Поверхностное копирование
        public Toilet ShallowCopy()
        {
            return (Toilet)this.MemberwiseClone();
        }

        // Глубокое копирование
        public Toilet DeepCopy()
        {
            Toilet other = (Toilet)this.MemberwiseClone();
            other.air_temp = air_temp;
            other.air_hum = air_hum;
            other.conc_co2 = conc_co2;
            other.brightness = brightness;
            other.light = light;
            other.vent_speed = vent_speed;
            return other;
        }
    }
}
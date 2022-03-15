using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_homeCS
{
    public class Parametrs
    {
		private double air_temp; //Температура воздуха
		private double air_hum; //Влажность воздуха
		private double conc_co2; //Концентрация CO2
		private int brightness; //Яркость света
		private int light; //Включение/выключение света
		private int vent_speed; //Скорость вентиляции

		private static Parametrs lastPar;
		private Parametrs prev;
		private Parametrs next;

		// Новый список
		public void NewList()
		{
			lastPar = null;
		}

		// Добавление элемента в конец списка
		public void Add()
		{
			if (lastPar == null)
				this.prev = null;
			else
			{
				lastPar.next = this;
				prev = lastPar;
			}
			lastPar = this;
			this.next = null;
		}

		// Вывод на дисплей содержимого списка
		public void reprint()
		{
			Parametrs uk;   // Вспомогательная ссылка
			uk = lastPar;
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
				Console.WriteLine(uk.air_temp + "\t");
				uk = uk.prev;
			}
		}


		public double Air_temp
        {
			get => air_temp;
			set => air_temp = value;

		}

		public double Air_hum
        {
			get => air_hum;
			set => air_hum = value;
		}

		public double Conc_co2
        {
			get => conc_co2;
			set => conc_co2 = value;
		}

		public int Brightness
        {
			get => brightness;
			set => brightness = value;
		}

		public int Light
        {
			get => light;
			set => light = value;
		}

		public int Vent_speed
        {
			get => vent_speed;
			set => vent_speed = value;
		}

		public Parametrs()
		{
			air_temp = 0;
			air_hum = 0;
			conc_co2 = 0;
			brightness = 0;
			light = 0;
			vent_speed = 0;
		}

		//Функции получения данных из полей
		public double Get_air_temp()
		{
			return this.air_temp;
		}

		public double Get_air_hum()
		{
			return this.air_hum;
		}

		public double Get_conc_co2()
		{
			return this.conc_co2;
		}

		public int Get_brightness()
		{
			return this.brightness;
		}

		public int Get_light()
		{
			return this.light;
		}

		public int Get_vent_speed()
		{
			return this.vent_speed;
		}

		//Функции задания полей
		public void Set_air_temp(double temp)
		{
			this.air_temp = temp;
		}

		public void Set_air_hum(double hum)
		{
			this.air_hum = hum;
		}

		public void Set_conc_co2(double co2)
		{
			this.conc_co2 = co2;
		}

		public void Set_brightness(int bright)
		{
			this.brightness = bright;
		}

		public void Set_light(int l)
		{
			this.light = l;
		}

		public void Set_vent_speed(int speed)
		{
			this.vent_speed = speed;
		}

		//Задание полей класса параметры
		public void Set_parametrs(double temp, double hum, double co2, int bright, int l, int speed)
		{
			this.air_temp = temp;
			this.air_hum = hum;
			this.conc_co2 = co2;
			this.brightness = bright;
			this.light = l;
			this.vent_speed = speed;
		}

		public void Display()
		{
			Console.WriteLine("\nТемература воздуха: " + air_temp + " °С");
			Console.WriteLine("Влажность воздуха: " + air_hum + " %");
			Console.WriteLine("Концентрация CO2: " + conc_co2 + " %");
			Console.WriteLine("Яркость света: " + brightness + " %");
			Console.WriteLine("Флажок света: " + light);
			Console.WriteLine("Скорость вентиляции: " + vent_speed + " %");
		}
	}
}

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
	}
}

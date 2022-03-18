using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_homeCS
{
	interface SmartParam
	{
		// Ввод параметров
		void Inp();

		// Вывод параметров
		void Display();

		// Виртуальная/не виртуальная функция повышения/понижения температуры
		double Temp_up();

		// Поверхностное копирование
		public Parametrs ShallowCopy();

		// Глубокое копирование
		public Parametrs DeepCopy();
	}

	// Класс Параметры
	public abstract class Parametrs : SmartParam
	{
		protected double air_temp; //Температура воздуха
		protected double air_hum; //Влажность воздуха
		protected double conc_co2; //Концентрация CO2
		protected int brightness; //Яркость света
		protected int light; //Включение/выключение света
		protected int vent_speed; //Скорость вентиляции

		/*private static Parametrs lastPar;
		private Parametrs prev;
		private Parametrs next;*/

		/*// Новый список
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

		// Проверка числа на подходяее для температуры
		public bool IsRightTemp(double temp)
		{
			bool res = true;
			try                                                    // ищем исключения внутри этого блока и отправляем их в соответствующий обработчик catch
			{
				if (temp < -20 || temp > 40)                          // Если пользователь ввел неверное число, то выбрасывается исключение
					throw new Exception("Incorrect value.");       // выбрасывается исключение типа const char*
				return res;
			}
			catch (Exception ex)           // обработчик исключений типа const char*
			{
				Console.WriteLine("Error: " + ex.Message + '\n');
				res = false;
				return res;
			}

			//return res;
		}*/

		//Конструктор
		public Parametrs()
		{
			air_temp = 0;
			air_hum = 0;
			conc_co2 = 0;
			brightness = 0;
			light = 0;
			vent_speed = 0;
		}

		//Конструктор с одним параметром
		public Parametrs(double temp)
		{
			//if (IsRightTemp(temp))
			air_temp = temp;
			air_hum = 0;
			conc_co2 = 0;
			brightness = 0;
			light = 0;
			vent_speed = 0;
		}

		//Конструктор с параметрами
		public Parametrs(double temp, double hum, double co2, int bright, int l, int speed)
		{
			//if (IsRightTemp(temp))
			air_temp = temp;
			air_hum = hum;
			conc_co2 = co2;
			brightness = bright;
			light = l;
			vent_speed = speed;
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
			//if (IsRightTemp(temp))
			air_temp = temp;
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
			//if (IsRightTemp(temp))
			air_temp = temp;
			this.air_hum = hum;
			this.conc_co2 = co2;
			this.brightness = bright;
			this.light = l;
			this.vent_speed = speed;
		}

		// Ввод параметров
		public virtual void Inp()
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

		// Метод ToString
		public String ToString()
		{
			return ("\nТемература воздуха: " + air_temp + "\nВлажность воздуха: " + air_hum + 
				"\nКонцентрация CO2: " + conc_co2 + "\nЯркость света: " + brightness + 
				"\nФлажок света: " + light + "\nСкорость вентиляции: " + vent_speed + "\n");
		}

		public virtual void Display()
		{
			Console.WriteLine("\nТемература воздуха: " + air_temp + " °С");
			Console.WriteLine("Влажность воздуха: " + air_hum + " %");
			Console.WriteLine("Концентрация CO2: " + conc_co2 + " %");
			Console.WriteLine("Яркость света: " + brightness + " %");
			Console.WriteLine("Флажок света: " + light);
			Console.WriteLine("Скорость вентиляции: " + vent_speed + " %");
		}

		// Повышение температуры на 5 градусов
		virtual public double Temp_up()
		{
			air_temp += 5;
			Console.WriteLine("Увеличение на 5 градусов");
			return air_temp;
		}

		// Проверка увеличения температуры, взаимодействие с пользователем
		public void Temp_check()
		{
			double t;
			t = Temp_up();
			Console.WriteLine("Температура изменилась. Текущая температура: " + air_temp);
		}


		/*public static Parametrs operator +(Parametrs operand1, Parametrs operand2)
			=> new Parametrs(operand1.air_temp + operand2.air_temp, 0, 0, 0, 0, 0);

		public static Parametrs operator ++(Parametrs operand1)
			=> new Parametrs(operand1.air_temp + 1, 0, 0, 0, 0, 0);*/

		// Поверхностное копирование
		public Parametrs ShallowCopy()
		{
			return (Parametrs)this.MemberwiseClone();
		}

		// Глубокое копирование
		public Parametrs DeepCopy()
		{
			Parametrs other = (Parametrs)this.MemberwiseClone();
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

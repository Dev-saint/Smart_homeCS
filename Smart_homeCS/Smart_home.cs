using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_homeCS
{
    public class Smart_home
    {
        static void Main(string[] args)
        {
            double t, co2, hum;
            int f_menu_rooms = 0, room, par, f_menu_par = 0, bright, speed, light, coffee, water;
            string tmp;
            Toilet toil = new Toilet();
            Kitchen kitch = new Kitchen();
            Bedroom bed = new Bedroom();
            Bathroom bath = new Bathroom();
            Wine_vault wine = new Wine_vault();
            Console.WriteLine("Система умного дома");
            do
            {
                Console.Write("Выберите комнату:\n"
                    + "1. Туалет\n"
                    + "2. Кухня\n"
                    + "3. Спальня\n"
                    + "4. Ванная\n"
                    + "5. Винный погреб\n"
                    + "Выбранная комната: ");
                tmp = Console.ReadLine();
                room = Convert.ToInt32(tmp);
                if (room == 1)
                    do
                    {
                        toil.menu_toil();
                        tmp = Console.ReadLine();
                        par = Convert.ToInt32(tmp);
                        if (par == 1)
                        {
                            Console.Write("\nВведите желаемую температуру воздуха (в °С): ");
                            tmp = Console.ReadLine();
                            t = Convert.ToDouble(tmp);
                            toil.Set_air_temp_toil(t);
                            Console.WriteLine("Температура воздуха в туалете будет изменена до " + toil.Get_air_temp_toil() + " °С");
                        }
                        else
                            if (par == 2)
                        {
                            Console.Write("\nВведите желаемую влажность воздуха (в %): ");
                            tmp = Console.ReadLine();
                            hum = Convert.ToDouble(tmp);
                            toil.Set_air_hum_toil(hum);
                            Console.WriteLine("Влажность воздуха в туалете будет изменена до " + toil.Get_air_hum_toil() + " %");
                        }
                        else
                            if (par == 3)
                        {
                            Console.Write("\nВведите желаемую концентрацию CO2 (в %): ");
                            tmp = Console.ReadLine();
                            co2 = Convert.ToDouble(tmp);
                            toil.Set_conc_co2_toil(co2);
                            Console.WriteLine("Концентрация CO2 в туалете будет изменена до " + toil.Get_conc_co2_toil() + " %");
                        }
                        else
                            if (par == 4)
                        {
                            Console.Write("\nВведите желаемую яркость света (в %): ");
                            tmp = Console.ReadLine();
                            bright = Convert.ToInt32(tmp);
                            toil.Set_brightness_toil(bright);
                            Console.WriteLine("Яркость в туалете будет изменена до " + toil.Get_brightness_toil() + " %");
                        }
                        else
                            if (par == 5)
                        {
                            Console.WriteLine("\nВключить (1) или выключить (0) свет?");
                            tmp = Console.ReadLine();
                            light = Convert.ToInt32(tmp);
                            if (light == 1 && toil.Get_light_toil() != 1)
                            {
                                toil.Set_light_toil(light);
                                Console.WriteLine("Свет в туалете включен");
                            }
                            else
                                if (light == 1)
                            {
                                Console.WriteLine("\nСвет уже включен. Выключить свет? Да(1)/Нет(0)");
                                tmp = Console.ReadLine();
                                light = Convert.ToInt32(tmp);
                                if (light == 1)
                                {
                                    toil.Set_light_toil(light);
                                    Console.WriteLine("Свет в туалете выключен");
                                }
                            }
                            else
                                    if (toil.Get_light_toil() == 0)
                            {
                                Console.WriteLine("\nСвет уже выключен. Включить свет? Да(1)/Нет(0)");
                                tmp = Console.ReadLine();
                                light = Convert.ToInt32(tmp);
                                if (light == 1)
                                {
                                    toil.Set_light_toil(light);
                                    Console.WriteLine("Свет в туалете включен");
                                }
                            }
                            else
                            {
                                toil.Set_light_toil(light);
                                Console.WriteLine("Свет в туалете выключен");
                            }
                        }
                        else
                            if (par == 6)
                        {
                            Console.Write("\nВведите желаемую скорость вентиляции: ");
                            tmp = Console.ReadLine();
                            speed = Convert.ToInt32(tmp);
                            toil.Set_vent_speed_toil(speed);
                            Console.WriteLine("Скорость вентиляции в туалете будет изменена до " + toil.Get_brightness_toil() + " %");
                        }
                        else
                        {
                            Console.WriteLine("\nВыберите пункт из предложенных!");
                        }
                        Console.WriteLine("\nЖелаете выбрать еще один параметр? Да(1)/Нет(0)");
                        tmp = Console.ReadLine();
                        f_menu_par = Convert.ToInt32(tmp);
                    } while (f_menu_par == 1);
                else
                    if (room == 2)
                    do
                    {
                        kitch.menu_kitch();
                        tmp = Console.ReadLine();
                        par = Convert.ToInt32(tmp);
                        if (par == 1)
                        {
                            Console.Write("\nВведите желаемую температуру воздуха (в °С): ");
                            tmp = Console.ReadLine();
                            t = Convert.ToDouble(tmp);
                            kitch.Set_air_temp_kitch(t);
                            Console.WriteLine("Температура воздуха на кухне будет изменена до " + kitch.Get_air_temp_kitch() + " °С");
                        }
                        else
                            if (par == 2)
                        {
                            Console.Write("\nВведите желаемую влажность воздуха (в %): ");
                            tmp = Console.ReadLine();
                            hum = Convert.ToDouble(tmp);
                            kitch.Set_air_hum_kitch(hum);
                            Console.WriteLine("Влажность воздуха на кухне будет изменена до " + kitch.Get_air_hum_kitch() + " %");
                        }
                        else
                            if (par == 3)
                        {
                            Console.Write("\nВведите желаемую концентрацию CO2 (в %): ");
                            tmp = Console.ReadLine();
                            co2 = Convert.ToDouble(tmp);
                            kitch.Set_conc_co2_kitch(co2);
                            Console.WriteLine("Концентрация CO2 на кухне будет изменена до " + kitch.Get_conc_co2_kitch() + " %");
                        }
                        else
                            if (par == 4)
                        {
                            Console.Write("\nВведите желаемую яркость света (в %): ");
                            tmp = Console.ReadLine();
                            bright = Convert.ToInt32(tmp);
                            kitch.Set_brightness_kitch(bright);
                            Console.WriteLine("Яркость света на кухне будет изменена до " + kitch.Get_brightness_kitch() + " %");
                        }
                        else
                            if (par == 5)
                        {
                            Console.WriteLine("Включить (1) или выключить (0) свет?");
                            tmp = Console.ReadLine();
                            light = Convert.ToInt32(tmp);
                            if (light == 1 && kitch.Get_light_kitch() != 1)
                            {
                                kitch.Set_light_kitch(light);
                                Console.WriteLine("Свет на кухне включен");
                            }
                            else
                                if (light == 1)
                            {
                                Console.WriteLine("Свет уже включен. Выключить свет? Да(1)/Нет(0)");
                                tmp = Console.ReadLine();
                                light = Convert.ToInt32(tmp);
                                if (light == 1)
                                {
                                    kitch.Set_light_kitch(light);
                                    Console.WriteLine("Свет на кухне выключен");
                                }
                            }
                            else
                                if (kitch.Get_light_kitch() == 0)
                            {
                                Console.WriteLine("Свет уже выключен. Включить свет? Да(1)/Нет(0)");
                                tmp = Console.ReadLine();
                                light = Convert.ToInt32(tmp);
                                if (light == 1)
                                {
                                    kitch.Set_light_kitch(light);
                                    Console.WriteLine("Свет на кухне включен");
                                }
                            }
                            else
                            {
                                kitch.Set_light_kitch(light);
                                Console.WriteLine("Свет на кухне выключен");
                            }
                        }
                        else
                            if (par == 6)
                        {
                            Console.Write("Введите желаемую скорость вентиляции: ");
                            tmp = Console.ReadLine();
                            speed = Convert.ToInt32(tmp);
                            kitch.Set_vent_speed_kitch(speed);
                            Console.WriteLine("Скорость вентиляции на кухне будет изменена до " + kitch.Get_vent_speed_kitch() + " %");
                        }
                        else
                            if (par == 7)
                        {
                            Console.WriteLine("Приготовить кофе? Да(1)/Нет(0)");
                            tmp = Console.ReadLine();
                            coffee = Convert.ToInt32(tmp);
                            kitch.Set_coffee(coffee);
                            kitch.coffee_machine();
                        }
                        else
                        {
                            Console.WriteLine("Выберите пункт из предложенных!");
                        }
                        Console.WriteLine("Желаете выбрать еще один параметр? Да(1)/Нет(0)");
                        tmp = Console.ReadLine();
                        f_menu_par = Convert.ToInt32(tmp);
                    } while (f_menu_par == 1);
                else
                    if (room == 3)
                    do
                    {
                        bed.menu_bed();
                        tmp = Console.ReadLine();
                        par = Convert.ToInt32(tmp);
                        if (par == 1)
                        {
                            Console.Write("Введите желаемую температуру воздуха (в °С): ");
                            tmp = Console.ReadLine();
                            t = Convert.ToDouble(tmp);
                            bed.Set_air_temp_bed(t);
                            Console.WriteLine("Температура воздуха в спальне будет изменена до " + bed.Get_air_temp_bed() + " °С");
                        }
                        else
                            if (par == 2)
                        {
                            Console.Write("Введите желаемую влажность воздуха (в %): ");
                            tmp = Console.ReadLine();
                            hum = Convert.ToDouble(tmp);
                            bed.Set_air_hum_bed(hum);
                            Console.WriteLine("Влажность воздуха в спальне будет изменена до " + bed.Get_air_hum_bed() + " %");
                        }
                        else
                            if (par == 3)
                        {
                            Console.Write("Введите желаемую концентрацию CO2 (в %): ");
                            tmp = Console.ReadLine();
                            co2 = Convert.ToDouble(tmp);
                            bed.Set_conc_co2_bed(co2);
                            Console.WriteLine("Концентрация CO2 в спальне будет изменена до " + bed.Get_conc_co2_bed() + " %");
                        }
                        else
                            if (par == 4)
                        {
                            Console.Write("Введите желаемую яркость света (в %): ");
                            tmp = Console.ReadLine();
                            bright = Convert.ToInt32(tmp);
                            bed.Set_brightness_bed(bright);
                            Console.WriteLine("Яркость света в спальне будет изменена до " + bed.Get_brightness_bed() + " %");
                        }
                        else
                            if (par == 5)
                        {
                            Console.WriteLine("Включить (1) или выключить (0) свет?");
                            tmp = Console.ReadLine();
                            light = Convert.ToInt32(tmp);
                            if (light == 1 && bed.Get_light_bed() != 1)
                            {
                                bed.Set_light_bed(light);
                                Console.WriteLine("Свет в спальне включен");
                            }
                            else
                                if (light == 1)
                            {
                                Console.WriteLine("Свет уже включен. Выключить свет? Да(1)/Нет(0)");
                                tmp = Console.ReadLine();
                                light = Convert.ToInt32(tmp);
                                if (light == 1)
                                {
                                    bed.Set_light_bed(light);
                                    Console.WriteLine("Свет в спальне выключен");
                                }
                            }
                            else
                                if (bed.Get_light_bed() == 0)
                            {
                                Console.WriteLine("Свет уже выключен. Включить свет? Да(1)/Нет(0)");
                                tmp = Console.ReadLine();
                                light = Convert.ToInt32(tmp);
                                if (light == 1)
                                {
                                    bed.Set_light_bed(light);
                                    Console.WriteLine("Свет в спальне включен");
                                }
                            }
                            else
                            {
                                bed.Set_light_bed(light);
                                Console.WriteLine("Свет в спальне выключен");
                            }
                        }
                        else
                            if (par == 6)
                        {
                            Console.Write("Введите желаемую скорость вентиляции: ");
                            tmp = Console.ReadLine();
                            speed = Convert.ToInt32(tmp);
                            bed.Set_vent_speed_bed(speed);
                            Console.WriteLine("Скорость вентиляции в спальне будет изменена до " + bed.Get_vent_speed_bed() + " %");
                        }
                        else
                        {
                            Console.WriteLine("Выберите пункт из предложенных!");
                        }
                        Console.WriteLine("Желаете выбрать еще один параметр? Да(1)/Нет(0)");
                        tmp = Console.ReadLine();
                        f_menu_par = Convert.ToInt32(tmp);
                    } while (f_menu_par == 1);
                else
                    if (room == 4)
                    do
                    {
                        bath.menu_bath();
                        tmp = Console.ReadLine();
                        par = Convert.ToInt32(tmp);
                        if (par == 1)
                        {
                            Console.Write("Введите желаемую температуру воздуха (в °С): ");
                            tmp = Console.ReadLine();
                            t = Convert.ToDouble(tmp);
                            bath.Set_air_temp_bath(t);
                            Console.WriteLine("Температура воздуха в ванной будет изменена до " + bath.Get_air_temp_bath() + " °С");
                        }
                        else
                            if (par == 2)
                        {
                            Console.Write("Введите желаемую влажность воздуха (в %): ");
                            tmp = Console.ReadLine();
                            hum = Convert.ToDouble(tmp);
                            bath.Set_air_hum_bath(hum);
                            Console.WriteLine("Влажность воздуха в ванной будет изменена до " + bath.Get_air_hum_bath() + " %");
                        }
                        else
                            if (par == 3)
                        {
                            Console.Write("Введите желаемую концентрацию CO2 (в %): ");
                            tmp = Console.ReadLine();
                            co2 = Convert.ToDouble(tmp);
                            bath.Set_conc_co2_bath(co2);
                            Console.WriteLine("Концентрация CO2 в ванной будет изменена до " + bath.Get_conc_co2_bath() + " %");
                        }
                        else
                            if (par == 4)
                        {
                            Console.Write("Введите желаемую яркость света (в %): ");
                            tmp = Console.ReadLine();
                            bright = Convert.ToInt32(tmp);
                            bath.Set_brightness_bath(bright);
                            Console.WriteLine("Яркость света в ванной будет изменена до " + bath.Get_brightness_bath() + " %");
                        }
                        else
                            if (par == 5)
                        {
                            Console.WriteLine("Включить (1) или выключить (0) свет?");
                            tmp = Console.ReadLine();
                            light = Convert.ToInt32(tmp);
                            if (light == 1 && bath.Get_light_bath() != 1)
                            {
                                bath.Set_light_bath(light);
                                Console.WriteLine("Свет в ванной включен");
                            }
                            else
                                if (light == 1)
                            {
                                Console.WriteLine("Свет уже включен. Выключить свет? Да(1)/Нет(0)");
                                tmp = Console.ReadLine();
                                light = Convert.ToInt32(tmp);
                                if (light == 1)
                                {
                                    bath.Set_light_bath(light);
                                    Console.WriteLine("Свет в ванной выключен");
                                }
                            }
                            else
                                if (bath.Get_light_bath() == 0)
                            {
                                Console.WriteLine("Свет уже выключен. Включить свет? Да(1)/Нет(0)");
                                tmp = Console.ReadLine();
                                light = Convert.ToInt32(tmp);
                                if (light == 1)
                                {
                                    bath.Set_light_bath(light);
                                    Console.WriteLine("Свет в ванной включен");
                                }
                            }
                            else
                            {
                                bath.Set_light_bath(light);
                                Console.WriteLine("Свет в ванной выключен");
                            }
                        }
                        else
                            if (par == 6)
                        {
                            Console.Write("Введите желаемую скорость вентиляции: ");
                            tmp = Console.ReadLine();
                            speed = Convert.ToInt32(tmp);
                            bath.Set_vent_speed_bath(speed);
                            Console.WriteLine("Скорость вентиляции в ванной будет изменена до " + bath.Get_vent_speed_bath() + " %");
                        }
                        else
                            if (par == 7)
                        {
                            Console.WriteLine("Набрать воду в ванную? Да(1)/Нет(0)");
                            tmp = Console.ReadLine();
                            water = Convert.ToInt32(tmp);
                            bath.Set_flag_water(water);
                            bath.water_bath();
                        }
                        else
                        {
                            Console.WriteLine("Выберите пункт из предложенных!");
                        }
                        Console.WriteLine("Желаете выбрать еще один параметр? Да(1)/Нет(0)");
                        tmp = Console.ReadLine();
                        f_menu_par = Convert.ToInt32(tmp);
                    } while (f_menu_par == 1);
                else
                    if (room == 5)
                    do
                    {
                        wine.menu_wine();
                        tmp = Console.ReadLine();
                        par = Convert.ToInt32(tmp);
                        if (par == 1)
                        {
                            Console.Write("Введите желаемую температуру воздуха (в °С): ");
                            tmp = Console.ReadLine();
                            t = Convert.ToDouble(tmp);
                            wine.Set_air_temp_wine(t);
                            Console.WriteLine("Температура воздуха в винном погребе будет изменена до " + wine.Get_air_temp_wine() + " °С");
                        }
                        else
                            if (par == 2)
                        {
                            Console.Write("Введите желаемую влажность воздуха (в %): ");
                            tmp = Console.ReadLine();
                            hum = Convert.ToDouble(tmp);
                            wine.Set_air_hum_wine(hum);
                            Console.WriteLine("Влажность воздуха в винном погребе будет изменена до " + wine.Get_air_hum_wine() + " %");
                        }
                        else
                            if (par == 3)
                        {
                            Console.Write("Введите желаемую концентрацию CO2 (в %): ");
                            tmp = Console.ReadLine();
                            co2 = Convert.ToDouble(tmp);
                            wine.Set_conc_co2_wine(co2);
                            Console.WriteLine("Концентрация CO2 в винном погребе будет изменена до " + wine.Get_conc_co2_wine() + " %");
                        }
                        else
                            if (par == 4)
                        {
                            Console.Write("Введите желаемую яркость света (в %): ");
                            tmp = Console.ReadLine();
                            bright = Convert.ToInt32(tmp);
                            wine.Set_brightness_wine(bright);
                            Console.WriteLine("Яркость света в винном погребе будет изменена до " + wine.Get_brightness_wine() + " %");
                        }
                        else
                            if (par == 5)
                        {
                            Console.WriteLine("Включить (1) или выключить (0) свет?");
                            tmp = Console.ReadLine();
                            light = Convert.ToInt32(tmp);
                            if (light == 1 && wine.Get_light_wine() != 1)
                            {
                                wine.Set_light_wine(light);
                                Console.WriteLine("Свет в ванной включен");
                            }
                            else
                                if (light == 1)
                            {
                                Console.WriteLine("Свет уже включен. Выключить свет? Да(1)/Нет(0)");
                                tmp = Console.ReadLine();
                                light = Convert.ToInt32(tmp);
                                if (light == 1)
                                {
                                    wine.Set_light_wine(light);
                                    Console.WriteLine("Свет в ванной выключен");
                                }
                            }
                            else
                                if (wine.Get_light_wine() == 0)
                            {
                                Console.WriteLine("Свет уже выключен. Включить свет? Да(1)/Нет(0)");
                                tmp = Console.ReadLine();
                                light = Convert.ToInt32(tmp);
                                if (light == 1)
                                {
                                    wine.Set_light_wine(light);
                                    Console.WriteLine("Свет в ванной включен");
                                }
                            }
                            else
                            {
                                wine.Set_light_wine(light);
                                Console.WriteLine("Свет в ванной выключен");
                            }
                        }
                        else
                            if (par == 6)
                        {
                            Console.Write("Введите желаемую скорость вентиляции: ");
                            tmp = Console.ReadLine();
                            speed = Convert.ToInt32(tmp);
                            wine.Set_vent_speed_wine(speed);
                            Console.WriteLine("Скорость вентиляции в винном погребе будет изменена до " + wine.Get_vent_speed_wine() + " %");
                        }
                        else
                        {
                            Console.WriteLine("Выберите пункт из предложенных!");
                        }
                        Console.WriteLine("Желаете выбрать еще один параметр? Да(1)/Нет(0)");
                        tmp = Console.ReadLine();
                        f_menu_par = Convert.ToInt32(tmp);
                    } while (f_menu_par == 1);
                else
                {
                    Console.WriteLine("Выберите комнату из предложенных!");
                }
                Console.WriteLine("Желаете выбрать другую комнату? Да(1)/Нет(0)");
                tmp = Console.ReadLine();
                f_menu_rooms = Convert.ToInt32(tmp);

                Console.Write("\n\n10) Для полей добавить свойства и продемонстрировать работу с ними\n");
                Console.Write("==================================================================\n");
                Console.Write("На примере класса Туалет\n");

                Parametrs par_10 = new Parametrs();
                par_10.Air_temp = 20;
                par_10.Air_hum = 50;
                par_10.Conc_co2 = 10;
                par_10.Brightness = 63;
                par_10.Light = 1;
                par_10.Vent_speed = 15;
                Console.WriteLine("Температура: " + par_10.Air_temp);
                Console.WriteLine("Влажность: " + par_10.Air_hum);
                Console.WriteLine("Концентрация CO2: " + par_10.Conc_co2);
                Console.WriteLine("Яркость: " + par_10.Brightness);
                Console.WriteLine("Флаг света: " + par_10.Light);
                Console.WriteLine("Скорость вентиляции: " + par_10.Vent_speed);

                Console.Write("\n11) Cоздать массив объектов и продемонстрировать работу с ним\n");
                Console.Write("==================================================================\n");
                Console.Write("На примере класса Туалет\n");

                Toilet[] mas_toil = new Toilet[3];
                int j;
                for (j = 0; j < 3; j++)
                {
                    mas_toil[j] = new Toilet();
                }

                for (j = 0; j < 3; j++)
                {
                    mas_toil[j].Set_parametrs_toil(20 - j*2, 45 + j, 5*j, 100/(j+2), 1, 49/(j+1));
                    mas_toil[j].DisplayToil();
                }
            } while (f_menu_rooms == 1);
        }
    }
}

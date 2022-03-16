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

                Console.Write("\n\n14) Продемонстрировать возврат значения через параметр out и через\nпараметр ref. Показать различие этих механизмов\n");
                Console.Write("==================================================================\n");
                Console.Write("На примере класса Toilet\n");

                // Инициализация переменной для передачи по ref
                int ArgRef = 2;
                // Описание переменной для передачи по out
                int ArgOut;

                // Передача аргумента по ref
                mas_toil[0].TestRef4(ref ArgRef);
                Console.WriteLine("Аргумент функции после использования по ref: " + ArgRef);

                // Передача аргумента по out
                mas_toil[1].TestOut5(out ArgOut);
                Console.WriteLine("Аргумент функции после использования по out: " + ArgOut);

                Console.Write("\n\n15) Продемонстрировать разумное использование оператора this\n");
                Console.Write("==================================================================\n");
                Console.Write("На примере класса Параметры, двусвязанный список\n\n");

                Parametrs[] param = new Parametrs[4];
                for (j = 0; j < 4; j++)
                {
                    param[j] = new Parametrs();
                }

                param[0].Set_air_temp(1);
                param[1].Set_air_temp(2);
                param[2].Set_air_temp(3);
                param[3].Set_air_temp(4);

                param[0].NewList();

                // Вызов статической компанентной функции:
                param[3].reprint();

                // Включение созданных компанентов в двусвязанный список:
                param[0].Add(); param[1].Add(); param[2].Add(); param[3].Add();

                // Печать в обратном порядке значений элементов списка:
                param[3].reprint();

                Console.Write("\n\n16) Продемонстрировать перегрузку операторов '+', '++'\n");
                Console.Write("==================================================================\n");
                Console.Write("На примере класса Параметры\n");

                Console.Write("Температура 1 и температура 2:\n");
                param[0].Set_air_temp(1);
                param[1].Set_air_temp(2);
                Console.WriteLine("Температура: " + param[0].Get_air_temp());
                Console.WriteLine("Температура: " + param[1].Get_air_temp());
                Console.Write("Сумма температур через оператор \'+\':\n");
                param[0] = param[0] + param[1];
                param[1] = param[0];
                Console.WriteLine("Температура: " + param[0].Get_air_temp());
                Console.Write("Прибавление к сумме 1 через постфиксный оператор \'++\': ");
                Console.WriteLine((param[0]++).Get_air_temp());
                Console.Write("Прибавление к сумме 1 через префиксный оператор \'++\': ");
                Console.WriteLine((++param[1]).Get_air_temp());

                Console.Write("\n\n17) Продемонстрировать обработку строк (string)\n");
                Console.Write("==================================================================\n");
                Console.WriteLine("На примере строк Troitskiy и Prog, сравнение строк и сложение\n");

                string Troitskiy, Prog;
                Troitskiy = "Извините, ";
                Prog = "что так поздно сдаю лабы:(";

                if (Troitskiy.Equals(Prog))
                    Console.WriteLine("\nСтроки равны!");
                else
                {
                    Troitskiy = Troitskiy + Prog;
                    Console.WriteLine(Troitskiy + "\n");
                }

                Console.WriteLine("\n\nЛабораторная работа 8:");
                Console.WriteLine("\n========================================");
                Console.WriteLine("Модифицировать ваши проекты на С++, C# и Java путем добавления в один из классов\n" +
                    "как минимум одного статического поля и одного статического метода.");
                Console.WriteLine("========================================\n");
                Console.WriteLine("(Использовались статистический член класса \'Toilet\' \'lastToil\' и\n" +
                    "статистические методы класса \'NewList\' и \'reprint\')\n");

                mas_toil[0].Set_parametrs_toil(1, 1, 1, 1, 1, 1);
                mas_toil[1].Set_parametrs_toil(2, 2, 2, 2, 0, 2);
                mas_toil[2].Set_parametrs_toil(3, 3, 3, 3, 1, 3);

                Console.WriteLine("Вызов статической компанентной функции: \'Новый список\'\n");
                mas_toil[0].NewList();

                Console.WriteLine("Вызов статической компанентной функции: \'Напечатать список\'\n");
                // Вызов статической компанентной функции:
                mas_toil[2].reprint();

                Console.WriteLine("Добавление элементов в список.\n");
                // Включение созданных компанентов в двусвязанный список:
                mas_toil[0].Add(); mas_toil[1].Add(); mas_toil[2].Add();

                Console.WriteLine("Вызов статической компанентной функции: \'Новый список\'\n");
                Console.WriteLine("========================================");
                // Печать в обратном порядке значений элементов списка:
                mas_toil[2].reprint();
                Console.WriteLine("\n========================================\n");

                Parametrs param1 = new Parametrs();
                Parametrs param2 = new Parametrs(20);
                Parametrs param3 = new Parametrs(20, 50, 10, 50, 0, 30);

                Console.WriteLine("Лабораторная 9\n");
                Console.WriteLine("Конструкторы класса Параметры:");
                Console.WriteLine("\n1) Конструктор без параметров:");
                param1.Display();
                Console.WriteLine("\n2) Конструктор с 1-им параметром:");
                param2.Display();
                Console.WriteLine("\n3) Конструктор с параметрами:");
                param3.Display();
                Console.WriteLine("\n\n");

                Toilet toil1 = new Toilet();
                Toilet toil2 = new Toilet(20);
                Toilet toil3 = new Toilet(20, 50, 10, 50, 0, 30);

                Console.WriteLine("Конструкторы класса Туалет:");
                Console.WriteLine("\n1) Конструктор без параметров:");
                toil1.DisplayToil();
                Console.WriteLine("\n2) Конструктор с 1-им параметром:");
                toil2.DisplayToil();
                Console.WriteLine("\n3) Конструктор с параметрами:");
                toil3.DisplayToil();
                Console.WriteLine("\n\n");

                Kitchen kitch1 = new Kitchen();
                Kitchen kitch2 = new Kitchen(20);
                Kitchen kitch3 = new Kitchen(20, 50, 10, 50, 0, 30, 0);

                Console.WriteLine("Конструкторы класса Кухня:");
                Console.WriteLine("\n1) Конструктор без параметров:");
                kitch1.DisplayKitch();
                Console.WriteLine("\n2) Конструктор с 1-им параметром:");
                kitch2.DisplayKitch();
                Console.WriteLine("\n3) Конструктор с параметрами:");
                kitch3.DisplayKitch();
                Console.WriteLine("\n\n");

                Bedroom bed1 = new Bedroom();
                Bedroom bed2 = new Bedroom(20);
                Bedroom bed3 = new Bedroom(20, 50, 10, 50, 0, 30);

                Console.WriteLine("Конструкторы класса Спальня:");
                Console.WriteLine("\n1) Конструктор без параметров:");
                bed1.DisplayBed();
                Console.WriteLine("\n2) Конструктор с 1-им параметром:");
                bed2.DisplayBed();
                Console.WriteLine("\n3) Конструктор с параметрами:");
                bed3.DisplayBed();
                Console.WriteLine("\n\n");

                Bathroom bath1 = new Bathroom();
                Bathroom bath2 = new Bathroom(20);
                Bathroom bath3 = new Bathroom(20, 50, 10, 50, 0, 30, 0);

                Console.WriteLine("Конструкторы класса Ванная:");
                Console.WriteLine("\n1) Конструктор без параметров:");
                bath1.DisplayBath();
                Console.WriteLine("\n2) Конструктор с 1-им параметром:");
                bath2.DisplayBath();
                Console.WriteLine("\n3) Конструктор с параметрами:");
                bath3.DisplayBath();
                Console.WriteLine("\n\n");

                Wine_vault wine1 = new Wine_vault();
                Wine_vault wine2 = new Wine_vault(20);
                Wine_vault wine3 = new Wine_vault(20, 50, 10, 50, 0, 30);

                Console.WriteLine("Конструкторы класса Винный погреб:");
                Console.WriteLine("\n1) Конструктор без параметров:");
                wine1.DisplayWine();
                Console.WriteLine("\n2) Конструктор с 1-им параметром:");
                wine2.DisplayWine();
                Console.WriteLine("\n3) Конструктор с параметрами:");
                wine3.DisplayWine();
                Console.WriteLine("\n\n");

            } while (f_menu_rooms == 1);
        }
    }
}

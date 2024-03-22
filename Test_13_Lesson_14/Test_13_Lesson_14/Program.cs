﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection.Metadata;
using System.Drawing;


/*Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:

    абстрактное свойство - название животного.

В классе Animal нужно определить следующие методы:

    конструктор, устанавливающий значение по умолчанию для названия;
    абстрактный метод Say(), который выводит звук, который издает животное;
    неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).

Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:

    свойство – название животного;
    метод Say (), выводящий на экран «Мяу» либо «Гав» соответственно.

Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.*/

namespace Test_13_Lesson_14
{
    class Program
    {
        static void Main(string[] args)
        {


            Dog dog = new Dog("Пудель","Гав-гав");
            dog.ShowInfo();

            Cat cat = new Cat("Мейнкун","Мяууу");
            cat.ShowInfo();



        }

    }




}
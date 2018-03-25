﻿/*
    Экзаменационное задание по Windows Forms.
    Разработать приложение Windows Forms, являющееся файловым менеджером.

    Файловый менеджер должен соответствовать следующим тредованиям:
        1) иметь две панели для отображения списка файлов и каталогов дирректории;
        2) выполнять переходы по каталогам и дискам;
        3) позволять изменять цвет и размер шрифта содержимого панелей;
        4) сохранять и загружать настройки предыдущего пункта (в xml файл);
        5) выполнять копирование, удаление, переименование и перемещение файлов и каталогов;
        6) выполнять копирование/перемещение в фоновопром процессе, т.е. не блокируя работу основного окна программы;
        7) показывать произвольную информацию из метаданных о .net сборках.
*/
using System;
using System.Windows.Forms;

namespace FileManager
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

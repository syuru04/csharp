﻿using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace LoadXanlWindow
{
    class LoadXamlWindow
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            Uri uri = new Uri("pack://application:,,,/XamlWinodw.xml");
            Stream stream = Application.GetResourceStream(uri).Stream;
            Window win = XamlReader.Load(stream) as Window;

            win.AddHandler(Button.ClickEvent, new RoutedEventHandler(Button_Click1));
            Button b = (Button)win.FindName("XamlButton");
            b.Click += Button_Click2;
            app.Run(win);
        }

        static void Button_Click1(object sender,RoutedEventArgs args)
        {
            MessageBox.Show((args.Source as Button).Content.ToString()+"1");
        }
        static void Button_Click2(object sender,RoutedEventArgs args)
        {
            MessageBox.Show(((Button)sender).Content.ToString()+"2");
        }
    }
}

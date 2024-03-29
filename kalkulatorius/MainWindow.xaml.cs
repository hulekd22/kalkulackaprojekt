﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kalkulatorius
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double ciselnik = 0;
        public string ciselnikStr = "";
        public double ciselnikOld = 0;
        public string ciselnikOldStr = "";
        public double ciselnikSave = 0;
        public string ciselnikSaveStr = "";
        public string znamenko = "";
        public bool pocitam = false;
        public bool desetinna = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void jednaklik(object sender, RoutedEventArgs e)
        {
            if (ciselnikOldStr == "")
            {
                ciselnik = 1;
                ciselnikStr = Convert.ToString(ciselnik);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
            else
            {
                ciselnikStr = ciselnikOldStr + "1";
                ciselnik = Convert.ToDouble(ciselnikStr);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
        }

        private void dvaklik(object sender, RoutedEventArgs e)
        {
            if (ciselnikOldStr == "")
            {
                ciselnik = 2;
                ciselnikStr = Convert.ToString(ciselnik);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
            else
            {
                ciselnikStr = ciselnikOldStr + "2";
                ciselnik = Convert.ToDouble(ciselnikStr);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
        }

        private void triklik(object sender, RoutedEventArgs e)
        {
            if (ciselnikOldStr == "")
            {
                ciselnik = 3;
                ciselnikStr = Convert.ToString(ciselnik);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
            else
            {
                ciselnikStr = ciselnikOldStr + "3";
                ciselnik = Convert.ToDouble(ciselnikStr);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
        }

        private void ctyriklik(object sender, RoutedEventArgs e)
        {
            if (ciselnikOldStr == "")
            {
                ciselnik = 4;
                ciselnikStr = Convert.ToString(ciselnik);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
            else
            {
                ciselnikStr = ciselnikOldStr + "4";
                ciselnik = Convert.ToDouble(ciselnikStr);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
        }

        private void petklik(object sender, RoutedEventArgs e)
        {
            if (ciselnikOldStr == "")
            {
                ciselnik = 5;
                ciselnikStr = Convert.ToString(ciselnik);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
            else
            {
                ciselnikStr = ciselnikOldStr + "5";
                ciselnik = Convert.ToDouble(ciselnikStr);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
        }

        private void sestklik(object sender, RoutedEventArgs e)
        {
            if (ciselnikOldStr == "")
            {
                ciselnik = 6;
                ciselnikStr = Convert.ToString(ciselnik);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
            else
            {
                ciselnikStr = ciselnikOldStr + "6";
                ciselnik = Convert.ToDouble(ciselnikStr);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
        }

        private void sedmklik(object sender, RoutedEventArgs e)
        {
            if (ciselnikOldStr == "")
            {
                ciselnik = 7;
                ciselnikStr = Convert.ToString(ciselnik);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
            else
            {
                ciselnikStr = ciselnikOldStr + "7";
                ciselnik = Convert.ToDouble(ciselnikStr);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
        }

        private void osmklik(object sender, RoutedEventArgs e)
        {
            if (ciselnikOldStr == "")
            {
                ciselnik = 8;
                ciselnikStr = Convert.ToString(ciselnik);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
            else
            {
                ciselnikStr = ciselnikOldStr + "8";
                ciselnik = Convert.ToDouble(ciselnikStr);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
        }

        private void devetklik(object sender, RoutedEventArgs e)
        {
            if (ciselnikOldStr == "")
            {
                ciselnik = 9;
                ciselnikStr = Convert.ToString(ciselnik);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
            else
            {
                ciselnikStr = ciselnikOldStr + "9";
                ciselnik = Convert.ToDouble(ciselnikStr);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
        }

        private void nulaklik(object sender, RoutedEventArgs e)
        {
            if (ciselnikOldStr == "")
            {
                ciselnik = 0;
                ciselnikStr = "";
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
            else
            {
                ciselnikStr = ciselnikOldStr + "0";
                ciselnik = Convert.ToDouble(ciselnikStr);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
        }
        private void odmocninaklik(object sender, RoutedEventArgs e)
        {
           
        }

        private void nadruhouklik(object sender, RoutedEventArgs e)
        {
            if (pocitam == false)
            {
                ciselnik = ciselnikOld * ciselnikOld;
                ciselnikStr = Convert.ToString(ciselnik);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
            }
            else
            {
                ciselnikSave = ciselnikOld;
                ciselnikSaveStr = Convert.ToString(ciselnikSave);
                ciselnik = ciselnikOld * ciselnikOld;
                ciselnikStr = Convert.ToString(ciselnik);
                ciselnikOld = ciselnik;
                ciselnikOldStr = ciselnikStr;
                rovnaseklik(sender, e);
                printerk.Content = ciselnikOld;
            }
        }

        private void lomenoxklik(object sender, RoutedEventArgs e)
        {

        }
        private void ceklik(object sender, RoutedEventArgs e)
        {
            ciselnikSave = ciselnikOld;
            ciselnikSaveStr = Convert.ToString(ciselnikSave);
            ciselnik = 0;
            ciselnikStr = "";
            ciselnikOld = 0;
            ciselnikOldStr = "";
            printerk.Content = "";
        }

        private void cklik(object sender, RoutedEventArgs e)
        {
            ciselnik = 0;
            ciselnikStr = "";
            ciselnikOld = 0;
            ciselnikOldStr = "";
            printerk.Content = "";
        }

        private void procentaklik(object sender, RoutedEventArgs e)
        {

        }

        private void smazatklik(object sender, RoutedEventArgs e)
        {

        }

        private void delenoklik(object sender, RoutedEventArgs e)
        {
            if (pocitam == false)
            {
                znamenko = "/";
                ciselnikSave = ciselnikOld;
                ciselnikSaveStr = Convert.ToString(ciselnikSave);
                ciselnik = 0;
                ciselnikStr = "";
                ciselnikOld = 0;
                ciselnikOldStr = "";
                printerk.Content = "";
                pocitam = true;
                desetinna = false;
            }
            else
            {
                rovnaseklik(sender, e);
                znamenko = "/";
                ciselnikSave = ciselnikOld;
                ciselnikSaveStr = Convert.ToString(ciselnikSave);
                ciselnik = 0;
                ciselnikStr = "";
                ciselnikOld = 0;
                ciselnikOldStr = "";
                printerk.Content = "";
                pocitam = true;
                desetinna = false;
            }
        }

        private void kratklik(object sender, RoutedEventArgs e)
        {
            if (pocitam == false)
            {
                znamenko = "*";
                ciselnikSave = ciselnikOld;
                ciselnikSaveStr = Convert.ToString(ciselnikSave);
                ciselnik = 0;
                ciselnikStr = "";
                ciselnikOld = 0;
                ciselnikOldStr = "";
                printerk.Content = "";
                pocitam = true;
                desetinna = false;
            }
            else
            {
                rovnaseklik(sender, e);
                znamenko = "*";
                ciselnikSave = ciselnikOld;
                ciselnikSaveStr = Convert.ToString(ciselnikSave);
                ciselnik = 0;
                ciselnikStr = "";
                ciselnikOld = 0;
                ciselnikOldStr = "";
                printerk.Content = "";
                pocitam = true;
                desetinna = false;
            }
        }

        private void minusklik(object sender, RoutedEventArgs e)
        {
            if (pocitam == false)
            {
                znamenko = "-";
                ciselnikSave = ciselnikOld;
                ciselnikSaveStr = Convert.ToString(ciselnikSave);
                ciselnik = 0;
                ciselnikStr = "";
                ciselnikOld = 0;
                ciselnikOldStr = "";
                printerk.Content = "";
                pocitam = true;
                desetinna = false;
            }
            else
            {
                rovnaseklik(sender, e);
                znamenko = "-";
                ciselnikSave = ciselnikOld;
                ciselnikSaveStr = Convert.ToString(ciselnikSave);
                ciselnik = 0;
                ciselnikStr = "";
                ciselnikOld = 0;
                ciselnikOldStr = "";
                printerk.Content = "";
                pocitam = true;
                desetinna = false;
            }
        }

        private void plusklik(object sender, RoutedEventArgs e)
        {
            if (pocitam == false)
            {
                znamenko = "+";
                ciselnikSave = ciselnikOld;
                ciselnikSaveStr = Convert.ToString(ciselnikSave);
                ciselnik = 0;
                ciselnikStr = "";
                ciselnikOld = 0;
                ciselnikOldStr = "";
                printerk.Content = "";
                pocitam = true;
                desetinna = false;
            }
            else
            {
                rovnaseklik(sender, e);
                znamenko = "+";
                ciselnikSave = ciselnikOld;
                ciselnikSaveStr = Convert.ToString(ciselnikSave);
                ciselnik = 0;
                ciselnikStr = "";
                ciselnikOld = 0;
                ciselnikOldStr = "";
                printerk.Content = "";
                pocitam = true;
                desetinna = false;
            }
        }

        private void plusminusklik(object sender, RoutedEventArgs e)
        {

        }

        private void carkaklik(object sender, RoutedEventArgs e)
        {
            if ((ciselnikOldStr == "") && (desetinna == false))
            {
                ciselnikStr = "0,";
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOldStr;
                desetinna = true;
            }
            else if ((desetinna == false) && (ciselnikOldStr != ""))
            {
                ciselnikStr = ciselnikOldStr + ",";
                ciselnikOldStr = ciselnikStr;
                printerk.Content = ciselnikOld;
                desetinna = true;
            }
        }

        private void rovnaseklik(object sender, RoutedEventArgs e)
        {
            if ((znamenko != "") && (pocitam = true))
            {
                if (znamenko == "+")
                {
                    ciselnik = ciselnikSave + ciselnikOld;
                    ciselnikStr = Convert.ToString(ciselnik);
                    ciselnikOld = ciselnik;
                    ciselnikOldStr = ciselnikStr;
                    printerk.Content = ciselnikOldStr;
                    ciselnikSave = 0;
                    ciselnikSaveStr = "";
                    pocitam = false;
                }
                if (znamenko == "-")
                {
                    ciselnik = ciselnikSave - ciselnikOld;
                    ciselnikStr = Convert.ToString(ciselnik);
                    ciselnikOld = ciselnik;
                    ciselnikOldStr = ciselnikStr;
                    printerk.Content = ciselnikOldStr;
                    ciselnikSave = 0;
                    ciselnikSaveStr = "";
                    pocitam = false;
                }
                if (znamenko == "*")
                {
                    ciselnik = ciselnikSave * ciselnikOld;
                    ciselnikStr = Convert.ToString(ciselnik);
                    ciselnikOld = ciselnik;
                    ciselnikOldStr = ciselnikStr;
                    printerk.Content = ciselnikOldStr;
                    ciselnikSave = 0;
                    ciselnikSaveStr = "";
                    pocitam = false;
                }
                if (znamenko == "/")
                {
                    ciselnik = ciselnikSave / ciselnikOld;
                    ciselnikStr = Convert.ToString(ciselnik);
                    ciselnikOld = ciselnik;
                    ciselnikOldStr = ciselnikStr;
                    printerk.Content = ciselnikOldStr;
                    ciselnikSave = 0;
                    ciselnikSaveStr = "";
                    pocitam = false;
                }
            }
        }
    }
}
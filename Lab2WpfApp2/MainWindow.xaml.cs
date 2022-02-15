﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab2WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (textBox != null)
            {
                double fontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
                textBox.FontSize = fontSize;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Background == Brushes.Red)
            {
                (sender as Button).Background = Brushes.Plum;
            }
            else
            {
                (sender as Button).Background = Brushes.Red;

                if (textBox.FontWeight == FontWeights.Normal)
            {
                textBox.FontWeight = FontWeights.Bold;
            }
            else
            {
                textBox.FontWeight = FontWeights.Normal;

               
                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Background == Brushes.Yellow)
            {
                (sender as Button).Background = Brushes.Orange;
            }
            else
            {
                (sender as Button).Background = Brushes.Yellow;

                if (textBox.FontStyle == FontStyles.Normal)
            {
                textBox.FontStyle = FontStyles.Italic;
            }
            else
            {
                textBox.FontStyle = FontStyles.Normal;

              
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Background == Brushes.Green)
            {
                (sender as Button).Background = Brushes.Blue;
            }
            else
            {
                (sender as Button).Background = Brushes.Green;
            }
                  if (textBox.TextDecorations.Count == 0)
            {
                textBox.TextDecorations.Add(TextDecorations.Underline);
            }
            else
            {
                textBox.TextDecorations.Remove(TextDecorations.Underline[0]);
            }

            //if (textBox.TextDecorations == null)
            //{
            //    textBox.TextDecorations = TextDecorations.Underline;
            //}
            //else
            //{
            //    textBox.TextDecorations = null;
            //}
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Green;
            }
        }
    }
}
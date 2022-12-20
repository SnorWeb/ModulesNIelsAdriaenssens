using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModulesNIelsAdriaenssens
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            //VARIABELEN IN SECONDEN
            int second = 1;
            int minuteInSeconds = 60 ;
            int hourInSeconds = minuteInSeconds * 60;
            int dayInSeconds = hourInSeconds * 24;
            int weekInSeconds = dayInSeconds * 7;
            int monthInSeconds = dayInSeconds * 30;
            int yearInSeconds = dayInSeconds * 365;

            //INPUT
            decimal Input = Convert.ToDecimal(txtInputSeconds.Text);

            //YEAR 
            decimal year = Math.Floor(Input / yearInSeconds);
            //OUTPUT YEAR
            txtYears.Text =  year.ToString();

            //YEAR MODULUS
            decimal yearMod = Input % yearInSeconds;

            //MONTH
            decimal month = Math.Round(yearMod / monthInSeconds);
            //OUTPUT MONTH
            txtMonths.Text = month.ToString();

            //MONTH MODULUS
            decimal monthMod = yearMod % monthInSeconds;

            //WEEK
            decimal week = Math.Round(monthMod / weekInSeconds);
            //OUTPUT WEEK
            txtWeeks.Text = week.ToString();

            //WEEK MODULUS
            decimal weekMod = monthMod % weekInSeconds;

            //DAY
            decimal day = Math.Round(weekMod / dayInSeconds);
            //OUTPUT DAY 
            txtDays.Text = day.ToString();

            //DAY MODULUS
            decimal dayMod = weekMod % dayInSeconds;

            //HOUR
            decimal hour = Math.Round(dayMod / hourInSeconds);
            //OUTPUT HOUR
            txtHours.Text = hour.ToString();

            //HOUR MODULUS
            decimal hourMod = dayMod % hourInSeconds;

            //MINUTES
            decimal minute = Math.Round(hourMod / minuteInSeconds);
            //OUTPUT MINUTES
            txtminutes.Text = minute.ToString();

            //MINUTES MOD 
            decimal minuteMod = hourMod % minuteInSeconds;

            //SECONDS
            decimal seconds = Math.Round(minuteMod / second);
            //OUTPUT
            txtSeconds.Text = seconds.ToString();
        }
    }
}

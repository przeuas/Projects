using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Globalization;
using static App1.Clock;
using Windows.UI;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace App1
{
    public sealed partial class Clock : UserControl
    {
       
        DispatcherTimer timer;
        public Clock()
        {
            this.InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_tick;
            timer.Start();
        }
        public void Timer_tick(Object sender, object e)
        {
            secondHandRotation.Angle = DateTime.Now.Second * 6;
            minuteHandRotation.Angle = DateTime.Now.Hour * 6;
            hourHandRotation.Angle = DateTime.Now.Hour * 30;

            digiHour.Text = DateTime.Now.Hour.ToString();
            digiMinute.Text = DateTime.Now.Minute.ToString();
        }

        public enum ClockFaceType
        {
            DigitalClock,
            AnalogClock

        }
        



        public ClockFaceType ClockType
        {
            get { return (ClockFaceType)GetValue(ClockTypeProperty); }
            set
            {
                if (value == ClockFaceType.AnalogClock)
                {
                    digitalClock.Visibility = Visibility.Collapsed;
                    analogClock.Visibility = Visibility.Visible;
                }
                else
                {
                    digitalClock.Visibility = Visibility.Visible;
                    analogClock.Visibility = Visibility.Collapsed;
                }

                SetValue(ClockTypeProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for ClockType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClockTypeProperty =
            DependencyProperty.Register("ClockType", typeof(ClockFaceType), typeof(Clock), new PropertyMetadata(0));


        public enum ColorScheme
        {
            BlackAndWhite,
            WhiteAndBlack,
            BlackAndTransparent,
            RedAndGreen
        }

        public ColorScheme Colors
        {
            get
            {
                return (ColorScheme)GetValue(ColorsProperty);
            }
            set
            {
                if (value == ColorScheme.WhiteAndBlack)
                {
                    setColors(Windows.UI.Colors.Green, Windows.UI.Colors.Red, Windows.UI.Colors.Yellow);
                    
                }
                else
                {
                    
                }
            }
        }

       

        public void setColors(Windows.UI.Color background, Windows.UI.Color foreground, Windows.UI.Color foreground2)
        {
            analogClockFace.Fill = new SolidColorBrush(background);
            digitalClock.Background = new SolidColorBrush(background);

            minuteHand.Fill = new SolidColorBrush(foreground);
            hourHand.Fill = new SolidColorBrush(foreground);
            secondHand.Fill = new SolidColorBrush(foreground2);

            digiHour.Foreground = new SolidColorBrush(foreground);
            digiMinute.Foreground = new SolidColorBrush(foreground);
            colon.Foreground = new SolidColorBrush(foreground);
        }




        // Using a DependencyProperty as the backing store for Colors.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColorsProperty =
            DependencyProperty.Register("Colors", typeof(ColorScheme), typeof(Clock), new PropertyMetadata(0));


    }
}



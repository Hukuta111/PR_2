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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PR_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MoveShapes();
        }

        private void MoveShapes()
        {
            // Triangle motion
            DoubleAnimation triangleXAnimation = new DoubleAnimation
            {
                From = 0,
                To = 300,
                Duration = TimeSpan.FromSeconds(3),
                RepeatBehavior = RepeatBehavior.Forever
            };

            triangleTransform.BeginAnimation(TranslateTransform.XProperty, triangleXAnimation);

            // Rectangle motion
            DoubleAnimation rectangleYAnimation = new DoubleAnimation
            {
                From = 0,
                To = 300,
                Duration = TimeSpan.FromSeconds(4),
                RepeatBehavior = RepeatBehavior.Forever
            };

            rectangleTransform.BeginAnimation(TranslateTransform.YProperty, rectangleYAnimation);

            // Circle motion
            DoubleAnimation circleXYAnimation = new DoubleAnimation
            {
                From = 0,
                To = 300,
                Duration = TimeSpan.FromSeconds(5),
                RepeatBehavior = RepeatBehavior.Forever
            };

            circleTransform.BeginAnimation(TranslateTransform.XProperty, circleXYAnimation);
            circleTransform.BeginAnimation(TranslateTransform.YProperty, circleXYAnimation);
        }
    }
}

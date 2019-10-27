﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShellView.xaml.cs" company="OxyPlot">
//   Copyright (c) 2014 OxyPlot contributors
// </copyright>
// <summary>
//   Interaction logic for MainWindow.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ExportDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ShellView
    {
        public ShellView()
        {
            this.InitializeComponent();
            this.DataContext = new ShellViewModel { Owner = this, Plot = this.plot1 };
        }
    }
}

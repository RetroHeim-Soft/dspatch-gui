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
using System.Windows.Shapes;
using dspatch;

namespace dspatch_gui
{
    /// <summary>
    /// Interaction logic for NameEditorWindow.xaml
    /// </summary>
    public partial class NameEditorWindow : Window
    {
        public NameEditorWindow()
        {
           
           InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void haxxStationhaxxStationNameSave_click(object sender, RoutedEventArgs e)
        {
            if (haxxStationTextBox.Equals("RC1 2006 01 25                  Gericom   HaxxStation                                                                                     By Gericom, shutterbug2000                                                                      and Apache Thunder          .                                                                   "))
            {
                DownloadStationPatcher.HaxxStationServerName(DownloadStationPatcher.haxxStationServer);
            }
            else
            {
                DownloadStationPatcher.HaxxStationServerName(haxxStationTextBox.Text);

                if (Encoding.ASCII.GetString(DownloadStationPatcher.haxxStationServer, 0, DownloadStationPatcher.haxxStationServer.Length).Equals(haxxStationTextBox.Text))
                {
                    MessageBox.Show("You have successfully changed the internal name!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Something went wrong with changing the internal name!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}

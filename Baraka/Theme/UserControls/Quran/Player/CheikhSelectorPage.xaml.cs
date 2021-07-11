﻿using Baraka.Data;
using Baraka.Data.Descriptions;
using System;
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

namespace Baraka.Theme.UserControls.Quran.Player
{
    /// <summary>
    /// Logique d'interaction pour CheikhSelectorPage.xaml
    /// </summary>
    public partial class CheikhSelectorPage : Page
    {
        public bool ItemsInitialized { get; set; } = false;

        public CheikhSelectorPage()
        {
            InitializeComponent();
        }

        public void InitializeItems(BarakaPlayer parentPlayer)
        {
            if (!ItemsInitialized)
            {
                foreach (CheikhDescription cheikh in LoadedData.CheikhList)
                {
                    var card = new CheikhCard(cheikh, parentPlayer);
                    ContainerGrid.Children.Add(card);
                }

                PageSV.PreviewMouseWheel += parentPlayer.PageSV_PreviewMouseWheel;

                ItemsInitialized = true;
            }
        }
    }
}
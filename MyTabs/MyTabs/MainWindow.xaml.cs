using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyTabs
{

    public partial class MainWindow : Window
    {
        protected TabItem tabItemPreviousScreen = null;
        protected TabItem tabItemCurrentScreen = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        protected delegate void delegate_SetScreen(TabItem tabItemOfScreenToSet);
        protected void SetScreen(TabItem tabItemOfScreenToSet)
        {
            tabItemOfScreenToSet.IsSelected = true;
            tabItemOfScreenToSet.Focus();
            this.tabItemPreviousScreen = this.tabItemCurrentScreen;
            this.tabItemCurrentScreen = tabItemOfScreenToSet;
        }

        private void Tab2Clicked(object sender, MouseButtonEventArgs e)
        {
            SetScreen(this.tabItem2);
        }

        private void Tab3Clicked(object sender, MouseButtonEventArgs e)
        {
            SetScreen(this.tabItem3);
        }

        private void Tab4Clicked(object sender, MouseButtonEventArgs e)
        {
            SetScreen(this.tabItem4);
        }

        private void Tab5Clicked(object sender, MouseButtonEventArgs e)
        {
            SetScreen(this.tabItem5);
        }
    }
}

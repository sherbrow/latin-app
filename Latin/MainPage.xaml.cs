using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Tasks;

namespace Latin
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void ShareAppBarButton_Click(object sender, System.EventArgs e)
        {
        	ShareStatusTask sst = new ShareStatusTask();
			sst.Status = "Viens tester et noter #Latin sur #WP7 @Sherbrow";
			sst.Show();
        }

    }
}
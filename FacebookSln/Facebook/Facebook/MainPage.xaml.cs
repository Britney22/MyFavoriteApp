using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Facebook
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void Button_Clicked( object sender , EventArgs e)
        {
           Navigation.PushAsync(new LoginPage());    
        }
     
        }
    }


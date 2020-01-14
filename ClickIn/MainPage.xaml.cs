using System;
using System.Text;
using Xamarin.Forms;
using System.Net;
using System.Net.Sockets;

namespace ClickIn
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void ButtonAClicked(System.Object sender, System.EventArgs e)
        {
            ExecuteClient("A");
            Selection_Label.Text = "Selection: 'A'";
            
        }
        void ButtonBClicked(System.Object sender, System.EventArgs e)
        {
            ExecuteClient("B");
            Selection_Label.Text = "Selection: 'B'";
        }
        void ButtonCClicked(System.Object sender, System.EventArgs e)
        {
            ExecuteClient("C");
            Selection_Label.Text = "Selection: 'C'";
        }
        void ButtonDClicked(System.Object sender, System.EventArgs e)
        {
            ExecuteClient("D");
            Selection_Label.Text = "Selection: 'D'";
        }
        void ButtonEClicked(System.Object sender, System.EventArgs e)
        {
            ExecuteClient("E");
            Selection_Label.Text = "Selection: 'E'";
        }

        static void ExecuteClient(String letter)
        {
            Program.start(letter);
        }

        

            

    }
}

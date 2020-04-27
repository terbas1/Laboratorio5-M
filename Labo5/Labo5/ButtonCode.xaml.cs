using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Labo5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ButtonCode : ContentPage
	{
		public ButtonCode ()
		{
			InitializeComponent ();
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
            await label.RelRotateTo(360, 1000);
        }
    }
}
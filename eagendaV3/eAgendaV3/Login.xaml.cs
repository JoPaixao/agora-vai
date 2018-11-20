using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eAgendaV3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : CarouselPage
	{
		public Login ()
		{
			InitializeComponent ();
		}
      private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Principal());
        }
    }
}
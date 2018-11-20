using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;
using Rg.Plugins.Popup.Contracts;
using System.Diagnostics;

namespace eAgendaV3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Perfil : ContentPage
	{
		public Perfil ()
		{
			InitializeComponent ();
		}
        private async void Handle_Clicked(object sender, EventArgs e)
        {


            /*#pragma warning disable CS0618 // O tipo ou membro é obsoleto
                        await PopupNavigation.PushAsync(new PopupCamera());
            #pragma warning restore CS0618 // O tipo ou membro é obsoleto*/

            var action = await DisplayActionSheet(" ", "Cancel", null, "Camera", "Galeria");
            
            if (action == "Camera")
            {
                Debug.WriteLine("Action: " + action);

                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsTakePhotoSupported || !CrossMedia.Current.IsCameraAvailable)
                {
                    await DisplayAlert("Ops", "Nenhuma câmera detectada.", "OK");

                    return;
                }
                var file = await CrossMedia.Current.TakePhotoAsync(
                    new StoreCameraMediaOptions
                    {
                        SaveToAlbum = true,
                        Directory = "Demo",
                    //Name = $"{DateTime.UtcNow.ToString("yyyy-dd-M--HH-mm-ss")}.jpg"
                });

                if (file == null)
                    return;
                IconPerfil.Source = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    file.Dispose();
                    return stream;

                });
            }
            if (action == "Galeria")
            {

                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    await DisplayAlert("Ops", "Galeria de fotos não suportada.", "OK");

                    return;
                }

                var file = await CrossMedia.Current.PickPhotoAsync();

                if (file == null)
                    return;

                IconPerfil.Source = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    file.Dispose();
                    return stream;

                });

            }
            

        }
    }
}
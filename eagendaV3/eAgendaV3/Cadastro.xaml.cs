using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.WindowsAzure.MobileServices;
using System;
using Microsoft.WindowsAzure.MobileServices.Sync;
using Microsoft.WindowsAzure;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;

namespace eAgendaV3
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro : ContentPage
    {
        

        public static MobileServiceClient MobileService = new MobileServiceClient("https://eagendav1.azurewebsites.net");



        public Cadastro()
        {

            InitializeComponent();

        }


        public class CadastroP
        {
            [Newtonsoft.Json.JsonProperty("Id")]
            public string Id { get; set; }

            public string Nome { get; set; }
            public int Idade { get; set; }
            public string Email { get; set; }
            public string LoginC { get; set; }
            public string Senha { get; set; }


        }

        public class MyEntry
        {

            //string nome = NomeEntry.Text;
            //string idade = IdadeEntry.Text;
            //string email = EmailEntry.Text;
            //string login = LoginEntry.Text;
            //string senha = SenhaEntry.Text;

        }
        public async void Button_Clicked(object sender, EventArgs e)
        {
            CurrentPlatform.Init();
            CadastroP item = new CadastroP {
                                            Nome = NomeEntry.Text.Trim(),
                                            Idade = Int32.Parse(IdadeEntry.Text),
                                            Email = EmailEntry.Text.Trim(),
                                            LoginC = LoginEntry.Text.Trim(),
                                            Senha = SenhaEntry.Text.Trim()
            };
            await MobileService.GetTable<CadastroP>().InsertAsync(item);
        }


    }
}

       

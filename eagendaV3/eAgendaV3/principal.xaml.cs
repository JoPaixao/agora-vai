using eAgendaV3.Models;
using eAgendaV3.servicer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eAgendaV3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : MasterDetailPage
    {


        //private ObservableCollection<MasterPageItem> _menuLista;
        //private ObservableCollection<MasterPageItem> _paginaInicial;



        public Principal()
        {
            InitializeComponent();
            Master = new Master1();
            //_menuLista = ItemsMaster.getMenuItens();
            //_paginaInicial = ItemsMaster.getPaginaInicial();
            //Inicio.ItemsSource = _paginaInicial;
            // MenuItemsListView.ItemsSource = _menuLista;
            App.Masterr = this;
        }

        //private void MenuItemsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var item = (MasterPageItem)e.SelectedItem;

        //    Type pagina = item.targtType;
        //    Detail = new NavigationPage((Page)Activator.CreateInstance(pagina));
        //    IsPresented = false;
        //}

        //private void IrParaInicio(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var item = (MasterPageItem)e.SelectedItem;
            
        //    Type pagina = item.targtType;
        //    Detail = new NavigationPage((Page)Activator.CreateInstance(pagina));
        //    IsPresented = false;
        //}

        //private void Handle_Clicked2(object sender, EventArgs e)
        //{
        //    Master = new Master2();
            
        //}
    }
    
}
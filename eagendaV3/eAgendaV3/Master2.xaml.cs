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
	public partial class Master2 : ContentPage
	{

        private ObservableCollection<MasterPageItem> _menuLista;
        private ObservableCollection<MasterPageItem> _paginaInicial;

        public Master2 ()
		{
            InitializeComponent();
            _menuLista = ItemsMaster.getMenuItens();
            _paginaInicial = ItemsMaster.getPaginaInicial();
            Inicio2.ItemsSource = _paginaInicial;
            //MenuItemsListView2.ItemsSource = _menuLista;
        }

        private void MenuItemsListView_ItemSelected2(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;

            Type pagina = item.targtType;

            App.Masterr.Detail = new NavigationPage((Page)Activator.CreateInstance(pagina));
            App.Masterr.IsPresented = false;
        }

        private void IrParaInicio(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;

            Type pagina = item.targtType;
            App.Masterr.Detail = new NavigationPage((Page)Activator.CreateInstance(pagina));
            App.Masterr.IsPresented = false;
        }

        private void Handle_Clicked2(object sender, EventArgs e)
        {
            App.Masterr.Master = new Master1();
        }
    }
}
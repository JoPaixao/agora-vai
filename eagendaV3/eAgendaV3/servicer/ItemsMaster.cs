using eAgendaV3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eAgendaV3.servicer
{
    public class ItemsMaster
    {
        private static ObservableCollection<MasterPageItem> MenuLista { get; set; }
        private static ObservableCollection<MasterPageItem> PaginaInicial { get; set; }

        public static ObservableCollection<MasterPageItem> getMenuItens()
        {
            MenuLista = new ObservableCollection<MasterPageItem>();

            var pagina1 = new MasterPageItem() { titulo = "Perfil", targtType = typeof(Perfil) };
            var pagina2 = new MasterPageItem() { titulo = "Cadastro", targtType = typeof(Cadastro) };
            var pagina3 = new MasterPageItem() { titulo = "Pagina Inicial", targtType = typeof(PaginaInicial) };

            MenuLista.Add(pagina1);
            MenuLista.Add(pagina2);
            MenuLista.Add(pagina3);

           return MenuLista;
        }
        public static ObservableCollection<MasterPageItem> getPaginaInicial()
        {
            PaginaInicial = new ObservableCollection<MasterPageItem>();

            var pagina3 = new MasterPageItem() { titulo = "Pagina Inicial", targtType = typeof(PaginaInicial) };

            PaginaInicial.Add(pagina3);

            return PaginaInicial;
        }



    }
}

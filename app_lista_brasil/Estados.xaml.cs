using System;
using System.Collections.Generic;
using Xamarin.Forms;
using app_lista_brasil.Modelo;

namespace app_lista_brasil
{
    public partial class Estados : ContentPage
    {
        public Estados()
        {
            InitializeComponent();
            lsvEstados.ItemsSource = Servico.Servico.listarEstados();
        }

        private void ActionSelecionarEstado(object sender, SelectedItemChangedEventArgs args)
        {
            Estado estado = (Estado)args.SelectedItem;
            Navigation.PushAsync(new Municipios(estado));
        }
    }
}

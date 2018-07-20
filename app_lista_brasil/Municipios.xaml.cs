using System;
using System.Collections.Generic;
using Xamarin.Forms;
using app_lista_brasil.Modelo;
using app_lista_brasil.Servico;
using System.Linq;

namespace app_lista_brasil
{
    public partial class Municipios : ContentPage
    {
        private List<Municipio> ListaMunicipios { get; set; }
        private List<Municipio> ListaFiltradaMunicipios { get; set; }

        public Municipios(Estado estado)
        {
            InitializeComponent();

            ListaMunicipios = Servico.Servico.listarMunicipio(estado.id);

            lsvMunicipios.ItemsSource = ListaMunicipios;
        }

        private void ActionPesquisarMunicipio (object sender, TextChangedEventArgs args)
        {
            ListaFiltradaMunicipios = ListaMunicipios.Where(a => a.nome.Contains(args.NewTextValue)).ToList();

            lsvMunicipios.ItemsSource = ListaFiltradaMunicipios;
        }
    }
}

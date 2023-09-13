using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeViewMaui;

namespace TreeViewMaui
{
    public class CountriesViewModel
    {
        public CountriesViewModel()
        {
            GenerateCountriesModelModelInfo();
        }
        public ObservableCollection<CountriesModel> CountriesInfo { get; set; }

        public ObservableCollection<object> SelectedCountries { get; set; }

        private void GenerateCountriesModelModelInfo()
        {
            var australia = new CountriesModel() { Name = "Australia" };
            var nsw = new CountriesModel() { Name = "New South Wales" };
            var sydney = new CountriesModel() { Name = "Sydney" };
            var canbera = new CountriesModel() { Name = "Canberra" };
            var maitland = new CountriesModel() { Name = "Newcastle–Maitland" };
            var victoria = new CountriesModel() { Name = "Victoria" };
            var melborne = new CountriesModel() { Name = "Melbourne" };
            var queensland = new CountriesModel() { Name = "Queensland" };
            var brisbane = new CountriesModel() { Name = "Brisbane" };
            var westAussie = new CountriesModel() { Name = "West Australia" };
            var perth = new CountriesModel() { Name = "Perth" };
            var southAussie = new CountriesModel() { Name = "South Australia" };
            var aldehide = new CountriesModel() { Name = "Adelaide" };

            australia.States = new ObservableCollection<CountriesModel>();
            australia.States.Add(nsw);
            australia.States.Add(victoria);
            australia.States.Add(queensland);
            australia.States.Add(westAussie);
            australia.States.Add(southAussie);
            nsw.States = new ObservableCollection<CountriesModel>();
            nsw.States.Add(sydney);
            nsw.States.Add(canbera);
            nsw.States.Add(maitland);
            victoria.States = new ObservableCollection<CountriesModel>();
            victoria.States.Add(melborne);
            queensland.States = new ObservableCollection<CountriesModel>();
            queensland.States.Add(brisbane);
            westAussie.States = new ObservableCollection<CountriesModel>();
            westAussie.States.Add(perth);
            southAussie.States = new ObservableCollection<CountriesModel>();
            southAussie.States.Add(aldehide);

            var brazil = new CountriesModel() { Name = "Brazil" };
            var saoPaulostate = new CountriesModel() { Name = "São Paulo" };
            var saoPaulo = new CountriesModel() { Name = "São Paulo" };
            var campinas = new CountriesModel() { Name = "Campinas" };
            var sorocaba = new CountriesModel() { Name = "Sorocaba" };
            var deJaneiro = new CountriesModel() { Name = "Rio de Janeiro" };
            var gerais = new CountriesModel() { Name = "Minas Gerais" };
            var horizonte = new CountriesModel() { Name = "Belo Horizonte" };
            var brassilia = new CountriesModel() { Name = "Distrito Federal e Entorno (Brasilia)" };
            var ceara = new CountriesModel() { Name = "Ceará" };
            var fortaleza = new CountriesModel() { Name = "Fortaleza" };
            var caucaia = new CountriesModel() { Name = "Caucaia" };
            var parana = new CountriesModel() { Name = "Paraná" };
            var curitiba = new CountriesModel() { Name = "Curitiba" };

            brazil.States = new ObservableCollection<CountriesModel>();
            brazil.States.Add(saoPaulostate);
            brazil.States.Add(deJaneiro);
            brazil.States.Add(gerais);
            brazil.States.Add(ceara);
            brazil.States.Add(parana);
            saoPaulostate.States = new ObservableCollection<CountriesModel>();
            saoPaulostate.States.Add(saoPaulo);
            saoPaulostate.States.Add(campinas);
            saoPaulostate.States.Add(sorocaba);
            gerais.States = new ObservableCollection<CountriesModel>();
            gerais.States.Add(horizonte);
            gerais.States.Add(brassilia);
            ceara.States = new ObservableCollection<CountriesModel>();
            ceara.States.Add(fortaleza);
            ceara.States.Add(caucaia);
            parana.States = new ObservableCollection<CountriesModel>();
            parana.States.Add(curitiba);

            var china = new CountriesModel() { Name = "China" };
            var guangdong = new CountriesModel() { Name = "Guangdong" };
            var guanghou = new CountriesModel() { Name = "Guanghou" };
            var jingjinji = new CountriesModel() { Name = "Jingjinji" };
            var beijing = new CountriesModel() { Name = "Beijing" };
            var tianjin = new CountriesModel() { Name = "Tianjin" };
            var yangtze = new CountriesModel() { Name = "Yangtze River Delta" };
            var shanghai = new CountriesModel() { Name = "Shanghai" };
            var chengyu = new CountriesModel() { Name = "Chengyu" };
            var chongqing = new CountriesModel() { Name = "Chongqing" };
            var zhejiang = new CountriesModel() { Name = "Zhejiang Province" };
            var hangzhou = new CountriesModel() { Name = "Hangzhou" };

            china.States = new ObservableCollection<CountriesModel>();
            china.States.Add(guangdong);
            china.States.Add(jingjinji);
            china.States.Add(yangtze);
            china.States.Add(chengyu);
            china.States.Add(zhejiang);
            guangdong.States = new ObservableCollection<CountriesModel>();
            guangdong.States.Add(guanghou);
            jingjinji.States = new ObservableCollection<CountriesModel>();
            jingjinji.States.Add(beijing);
            jingjinji.States.Add(tianjin);
            yangtze.States = new ObservableCollection<CountriesModel>();
            yangtze.States.Add(shanghai);
            chengyu.States = new ObservableCollection<CountriesModel>();
            chengyu.States.Add(chongqing);
            zhejiang.States = new ObservableCollection<CountriesModel>();
            zhejiang.States.Add(hangzhou);

            var usa = new CountriesModel() { Name = "United States of America" };
            var newYork = new CountriesModel() { Name = "New York" };
            var california = new CountriesModel() { Name = "California" };
            var losAngeles = new CountriesModel() { Name = "Los Angeles" };
            var sanJose = new CountriesModel() { Name = "San Jose" };
            var sanFrancisco = new CountriesModel() { Name = "San Francisco" };
            var illinois = new CountriesModel() { Name = "Illinois" };
            var chicago = new CountriesModel() { Name = "Chicago" };
            var texas = new CountriesModel() { Name = "Texas" };
            var houston = new CountriesModel() { Name = "Houston" };
            var sanAntonio = new CountriesModel() { Name = "San Antonio" };
            var dallas = new CountriesModel() { Name = "Dallas" };
            var pennsylvania = new CountriesModel() { Name = "Pennsylvania" };
            var philadelphia = new CountriesModel() { Name = "Philadelphia" };
            usa.States = new ObservableCollection<CountriesModel>();
            usa.States.Add(newYork);
            usa.States.Add(california);
            usa.States.Add(illinois);
            usa.States.Add(texas);
            usa.States.Add(pennsylvania);
            california.States = new ObservableCollection<CountriesModel>();
            california.States.Add(losAngeles);
            california.States.Add(sanJose);
            california.States.Add(sanFrancisco);
            illinois.States = new ObservableCollection<CountriesModel>();
            illinois.States.Add(chicago);
            texas.States = new ObservableCollection<CountriesModel>();
            texas.States.Add(houston);
            texas.States.Add(sanAntonio);
            texas.States.Add(dallas);
            pennsylvania.States = new ObservableCollection<CountriesModel>();
            pennsylvania.States.Add(philadelphia);

            var india = new CountriesModel() { Name = "India" };
            var delhi = new CountriesModel() { Name = "Delhi" };
            var newDelhi = new CountriesModel() { Name = "New Delhi" };
            var maharastra = new CountriesModel() { Name = "Maharashtra" };
            var mumbai = new CountriesModel() { Name = "Mumbai" };
            var pune = new CountriesModel() { Name = "Pune" };
            var westBengal = new CountriesModel() { Name = "Kolkatta" };
            var karnataka = new CountriesModel() { Name = "Karnataka" };
            var bangalore = new CountriesModel() { Name = "Bangalore" };
            var tamilNadu = new CountriesModel() { Name = "Tamil Nadu" };
            var chennai = new CountriesModel() { Name = "Chennai" };

            india.States = new ObservableCollection<CountriesModel>();
            india.States.Add(delhi);
            india.States.Add(maharastra);
            india.States.Add(westBengal);
            india.States.Add(karnataka);
            india.States.Add(tamilNadu);
            delhi.States = new ObservableCollection<CountriesModel>();
            delhi.States.Add(newDelhi);
            maharastra.States = new ObservableCollection<CountriesModel>();
            maharastra.States.Add(mumbai);
            maharastra.States.Add(pune);
            westBengal.States = new ObservableCollection<CountriesModel>();
            westBengal.States.Add(westBengal);
            karnataka.States = new ObservableCollection<CountriesModel>();
            karnataka.States.Add(bangalore);
            tamilNadu.States = new ObservableCollection<CountriesModel>();
            tamilNadu.States.Add(chennai);

            this.CountriesInfo = new ObservableCollection<CountriesModel>();
            CountriesInfo.Add(australia);
            CountriesInfo.Add(brazil);
            CountriesInfo.Add(china);
            CountriesInfo.Add(usa);
            CountriesInfo.Add(india);

            SelectedCountries = new ObservableCollection<object>();
            SelectedCountries.Add(nsw);
            SelectedCountries.Add(california);
            SelectedCountries.Add(victoria);
            SelectedCountries.Add(india);
            SelectedCountries.Add(china);
        }
    }
}

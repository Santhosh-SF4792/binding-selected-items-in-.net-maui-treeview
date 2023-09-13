using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewMaui
{
    public class CountriesModel : INotifyPropertyChanged
    {
        #region Feilds
        private string name;
        private ObservableCollection<CountriesModel> states;

        #endregion

        #region Constructor
        public CountriesModel()
        {
        }
        #endregion

        #region Properties
        public ObservableCollection<CountriesModel> States
        {
            get { return states; }
            set
            {
                states = value;
                RaisedOnPropertyChanged("States");
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisedOnPropertyChanged("Name");
            }
        }
        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }
        #endregion
    }
}

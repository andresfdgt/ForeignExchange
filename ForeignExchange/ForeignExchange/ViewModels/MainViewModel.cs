using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ForeignExchange.Models;
using GalaSoft.MvvmLight.Command;

namespace ForeignExchange.ViewModels
{
    public class MainViewModel
    {
        #region Propiedades
        public string Amount { get; set; }
        public ObservableCollection<Tasa> MyProperty { get; set; }
        public Tasa TasaOrigen { get; set; }
        public Tasa TasaDestino { get; set; }
        public bool IsRunning { get; set; }
        public bool IsEnable { get; set; }
        public string Resultado { get; set; }

        #endregion

        #region Comandos
        public ICommand ConverCommand
        {
            get
            {
                return new RelayCommand(Convert);
            }
        }

        private void Convert()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

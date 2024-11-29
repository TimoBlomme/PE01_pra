using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pra.Wine.Keeper.Wpf.Class_Library
{
    public class WineBox
    {
        public string Description { get; private set; }
        public int MinStorageMonths { get; private set; }
        public int MaxStorageMonths { get; private set; }
        public DateTime PurchaseDate { get; private set; }
        private int _numberOfBottles;
        public int NumberOfBottles
        {
            get => _numberOfBottles;
            private set
            {
                if (_numberOfBottles != value)
                {
                    _numberOfBottles = value;
                    OnPropertyChanged(nameof(NumberOfBottles));
                }
            }
        }
        public DateTime DrinkableFrom => PurchaseDate.AddMonths(MinStorageMonths);
        public DateTime DrinkableUntil => PurchaseDate.AddMonths(MaxStorageMonths);

        public WineBox(string description, int minStorageMonths, int maxStorageMonths, DateTime purchaseDate, int numberOfBottles)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Description cannot be empty or whitespace.");

            Description = description;
            MinStorageMonths = Math.Max(0, minStorageMonths);
            MaxStorageMonths = Math.Max(0, maxStorageMonths);
            PurchaseDate = purchaseDate;
            NumberOfBottles = Math.Max(1, numberOfBottles);
        }
        public bool DrinkBottle()
        {
            if (NumberOfBottles > 0)
            {
                NumberOfBottles--;
                return NumberOfBottles > 0;
            }
            return false; 
        }

        public bool IsDrinkableAt(DateTime date) =>
            date >= DrinkableFrom && date <= DrinkableUntil;

        public override string ToString() => $"{Description} ({NumberOfBottles} bottles)";

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

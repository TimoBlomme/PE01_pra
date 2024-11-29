using Pra.Wine.Keeper.Wpf.Class_Library;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
using System.Linq;

public class WineCollection : ObservableCollection<WineBox>
{
    public WineCollection() : base() { }
    /*
    private ObservableCollection<WineBox> _wines;
    public WineCollection()
    {
        _wines = new ObservableCollection<WineBox>();
    }
    public ObservableCollection<WineBox> Wines => _wines; // Property to bind to*/
}


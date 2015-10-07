using Invoice.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.App.Views
{
    public interface INamedEntityList
    {
        INamedEntity Current { get; set; }
        IBindingList Items { get; }
    }
}
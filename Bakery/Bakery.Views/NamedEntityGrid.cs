using System.Windows.Forms;
using Bakery.Model;
using Fortius.Gui;

namespace Bakery.UI.WinForms
{
    [ViewFor(typeof (IReferenceHostGridSource<NamedEntity>))]
    public partial class NamedEntityGrid : __ViewGridNamedEntity
    {
        public NamedEntityGrid()
        {
            InitializeComponent();
            gridControl1.DataMember = "GridSource";
        }
    }

    public class __ViewGridNamedEntity : ViewGrid<NamedEntity>
    {
    }
}
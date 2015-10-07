using System.ComponentModel;
using System.Data.Entity;

namespace Bakery.Model
{
    public class ReferenceSource<T> where T : Entity
    {
        private readonly Context _context = new Context();
        private readonly BindingList<T> _list;

        public ReferenceSource()
        {
            _context.Set<T>().Load();
            _list = _context.Set<T>().Local.ToBindingList();
        }

        public BindingList<T> DataSource
        {
            get { return _list; }
        }
    }
}

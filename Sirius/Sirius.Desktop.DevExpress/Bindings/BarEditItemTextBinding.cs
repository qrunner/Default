using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Sirius.Desktop.DevExpress.Bindings
{
    class BarEditItemTextBinding : IBindableComponent
    {
        private readonly BarEditItem _control;
        private Binding _binding;
        private BindingContext _bindingContext;

        public BindingContext BindingContext
        {
            get { return _bindingContext ?? (_bindingContext = new BindingContext()); }
            set { _bindingContext = value; }
        }

        private ControlBindingsCollection _dataBindings;

        public ControlBindingsCollection DataBindings
        {
            get { return _dataBindings ?? (_dataBindings = new ControlBindingsCollection(this)); }
        }

        public BarEditItemTextBinding(BarEditItem control, object dataSource, string dataMember)
        {
            _control = control;
            _binding = new Binding("EditValue", dataSource, dataMember);
            DataBindings.Add(_binding);
            _control.EditValueChanged += _control_EditValueChanged;
        }

        void _control_EditValueChanged(object sender, EventArgs e)
        {
            _binding.WriteValue();
        }

        public object EditValue
        {
            get { return _control.EditValue; }
            set { _control.EditValue = value; }
        }

        public void Dispose()
        {
            _control.EditValueChanged -= _control_EditValueChanged;
            DataBindings.Clear();
            if (Disposed != null)
                Disposed(this, new EventArgs());
        }

        public ISite Site { get; set; }

        public event EventHandler Disposed;
    }
}

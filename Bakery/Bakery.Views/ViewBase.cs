using DevExpress.XtraEditors;
using Fortius.Gui;

namespace Bakery.UI.WinForms
{
    public abstract class ViewBase<T> : XtraUserControl, IView<T>
    {
        protected ViewBase()
        {
            InitializeComponent();
        }

        protected System.Windows.Forms.BindingSource BindingSource;

        /// <summary>
        /// Текущая модель
        /// </summary>
        protected T Model;

        public void Bind(T model)
        {
            Model = model;
            BindingSource.DataSource = Model;
            BindInternal();
        }

        /// <summary>
        /// Дополнительный байндинг
        /// </summary>
        protected virtual void BindInternal()
        {
        }

        private void InitializeComponent()
        {
            this.BindingSource = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize) (this.BindingSource)).BeginInit();
            this.SuspendLayout();

            BindingSource.DataSource = typeof(T);

            // 
            // ViewBase
            // 
            this.Name = "ViewBase";
            this.Size = new System.Drawing.Size(500, 500);
            ((System.ComponentModel.ISupportInitialize) (this.BindingSource)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
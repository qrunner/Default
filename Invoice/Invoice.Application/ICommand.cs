namespace Sirius.Desktop
{
    public interface ICommand
    {
        void Execute(object parameter);

        bool CanExecute(object parameter);
    }
}
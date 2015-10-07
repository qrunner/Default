namespace Fortius.Gui
{
    public interface ICommand
    {
        void Execute(object parameter);

        bool CanExecute(object parameter);

        string Name { get; }
    }
}
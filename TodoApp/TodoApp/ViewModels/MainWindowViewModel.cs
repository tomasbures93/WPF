using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TodoApp.Views;

namespace TodoApp.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty] 
    private object? _currentView;

    [ObservableProperty]
    private string _appName = "Todo Tracker";

    private readonly TodoViewModel _todoViewModel;
    private readonly AddTodoViewModel _addTodoViewModel;
    private readonly AboutViewModel _aboutViewModel;

    public MainWindowViewModel()
    {
        _todoViewModel = new TodoViewModel();
        _addTodoViewModel = new AddTodoViewModel();
        _aboutViewModel = new AboutViewModel();
        
        CurrentView = _todoViewModel;
    }

    [RelayCommand]
    private void ShowAddTodo()
    {
        CurrentView = _addTodoViewModel;
    }

    [RelayCommand]
    private void ShowAbout()
    {
        CurrentView = _aboutViewModel;
    }

    [RelayCommand]
    private void ShowHome()
    {
        CurrentView = _todoViewModel;
    }
}
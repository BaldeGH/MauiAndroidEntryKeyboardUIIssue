using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace AdroidUITest;
internal partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    string labelText = string.Empty;

    [ObservableProperty]
    string entryText = string.Empty;

    [ObservableProperty]
    bool hasNotRecording = false;
    
    [ObservableProperty]
    bool hasRecording = true;
    
    [ObservableProperty]
    bool isImportant = false;


    [ICommand]
    void ExecuteCmd()
    {
        LabelText = LabelText + "/" + entryText;
        EntryText = string.Empty;
    }

}

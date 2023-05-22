using System.Diagnostics;

namespace MauiApp4;

public partial class ModelTemplate : Grid
{
    public ModelTemplate()
    {
        InitializeComponent();
    }

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
        DisplayBindingContext();
    }

    private void DisplayBindingContext()
    {
        if (BindingContext is Model)
        {
            bindingContextLabel.Text = "Model";
            Debug.WriteLine(bindingContextLabel.Text);
        }
        else if (BindingContext is MainPageViewModel)
        {
            bindingContextLabel.Text = "MainPageViewModel";
            Debug.WriteLine(bindingContextLabel.Text);
        }
        else
        {
            bindingContextLabel.Text = "not recognized";
            Debug.WriteLine(bindingContextLabel.Text);
        }
    }
}
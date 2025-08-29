# display-tapped-image-in-full-screen-in-.net-maui.chat
This sample demonstrates how to display an image in full screen when tapped in a .NET MAUI Chat (SfChat) application.

## Sample

```xaml  
this.chat.ImageTapped += Chat_ImageTapped;

private void Chat_ImageTapped(object? sender, ImageTappedEventArgs e)
{
    popup = new SfPopup();

    popup.ShowCloseButton = true;
    popup.HeaderTitle = "";
    popup.PopupStyle.PopupBackground = Colors.Black;

    DataTemplate bodyTemplateView = new DataTemplate(() =>
    {
        var imageView = new Image();
        imageView.Source = e.Message?.Source;
        imageView.Margin = new Thickness(0, 0, 0, 20);
        return imageView;
    });

    popup.ContentTemplate = bodyTemplateView;
    popup.Show(true);
}

```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion® has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion® liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion®'s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion®'s samples.
using Syncfusion.Maui.Chat;
using Syncfusion.Maui.Core;
using Syncfusion.Maui.Popup;
using MauiChat;

namespace MauiChat
{
    public class Behavior : Behavior<ContentPage>
    {
        #region Fields

        private SfChat? chat;
        private SfPopup? popup;

        #endregion

        #region Override Methods
        protected override void OnAttachedTo(ContentPage bindable)
        {
            this.chat = bindable!.FindByName<SfChat>("sfChat");
            if (this.chat != null)
            {
                this.chat.ImageTapped += Chat_ImageTapped;
            }

            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            if (this.chat != null)
            {
                this.chat.ImageTapped -= Chat_ImageTapped;
                this.chat = null;
            }

            popup = null;
            base.OnDetachingFrom(bindable);
        }
        #endregion

        #region Private Methods
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

        #endregion        
    }
}



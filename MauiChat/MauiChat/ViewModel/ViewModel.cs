using Syncfusion.Maui.Chat;
using Syncfusion.Maui.Popup;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MauiChat
{
    public class ViewModel : INotifyPropertyChanged
    {
        #region Fields

        private ObservableCollection<object> messages;
        /// <summary>
        /// current user of chat.
        /// </summary>
        private Author currentUser;

        #endregion

        #region Constructor
        public ViewModel()
        {
            this.messages = new ObservableCollection<object>();
            this.currentUser = new Author() { Name = "Nancy", Avatar = "peoplecircle16.png" };
            this.GenerateMessages();
        }
        #endregion

        #region Properties


        /// <summary>
        /// Gets or sets the group message conversation.
        /// </summary>
        public ObservableCollection<object> Messages
        {
            get
            {
                return this.messages;
            }

            set
            {
                this.messages = value;
            }
        }

        /// <summary>
        /// Gets or sets the current author.
        /// </summary>
        public Author CurrentUser
        {
            get
            {
                return this.currentUser;
            }
            set
            {
                this.currentUser = value;
                RaisePropertyChanged("CurrentUser");
            }
        }
        #endregion

        #region INotifyPropertyChanged

        /// <summary>
        /// Property changed handler.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Occurs when property is changed.
        /// </summary>
        /// <param name="propName">changed property name</param>
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        #endregion

        #region Messages Generation
        private void GenerateMessages()
        {
            this.Messages.Add(new ImageMessage()
            {
                Aspect = Aspect.AspectFill,
                Source = "image2.jpg",
                Author = currentUser,               
            });

            this.Messages.Add(new ImageMessage()
            {
                Aspect = Aspect.AspectFill,
                Source = "image1.jpg",
                Author = new Author() { Name = "Andrea", Avatar = "peoplecircle2.png" },
            });
        }

        #endregion    
    }
}


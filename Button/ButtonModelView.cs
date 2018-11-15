using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
//локалізація 
namespace Button
{
    public class ButtonModelView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Model model { get; set; }
        public ButtonModelView()
        {
            model = new Model();
        }

        public int CornRadiusValue
        {
            set
            {
                model.cornRadiusValue = value;
                OnPropertyChanged("CornRadiusValue");

            }
            get
            {
                return model.cornRadiusValue;
            }
        }

        public int FontSizeValue
        {
            set
            {
                model.fontSizeValue = value;
                OnPropertyChanged("FontSizeValue");
            }
            get
            {
                return model.fontSizeValue;
            }
        }

        public int BorderWidthValue
        {
            set
            {
                model.borderWidthValue = value;
                OnPropertyChanged("BorderWidthValue");
            }
            get
            {
                return model.borderWidthValue;
            }
        }

        public List<string> Colours
        {
            get 
            {
                return model.colours;
            }
            set
            {
                model.colours = value;
                OnPropertyChanged("Colours");
            }

        }


        public string SelectedBackgroundcolour
        {
            get
            {
                return model.backgroundcolour;
            }
            set
            {
                model.backgroundcolour = value;
                OnPropertyChanged("SelectedBackgroundcolour");
            }
        }

       
        public string SelectedTextColour
        {
            get
            {
                return model.textcolour;
            }
            set
            {
                model.textcolour = value;
                OnPropertyChanged("SelectedTextColour");
            }
        }

        public string SelectedBorderColour
        {
            get
            {
                return model.bordercolour;
            }
            set
            {
                model.bordercolour = value;
                OnPropertyChanged("SelectedBorderColour");
            }
        }



        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

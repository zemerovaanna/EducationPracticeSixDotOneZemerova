using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuestionnaireFromAnya
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Result : ContentPage
	{
		public Result (string name, string like, string work, string mood, string ageot, string agedo)
		{
			InitializeComponent ();
			
			labelname.Text = $"Имя:{name}";
            labellike.Text = $"Нравится делать в колледже:{like}";
            labelwork.Text = $"Специальность:{work}";
            labelmood.Text = $"Настроение в колледже:{mood}";
            labelageot.Text = $"Возраст в группе от:{ageot}";
            labelagedo.Text = $"Возраст в группе до:{agedo}";
        }

        private void MySwitch_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(MySwitch.IsToggled == true)
            {
                BackgroundColor = Color.Gold;
            }
            else
            {
                BackgroundColor = Color.Magenta;
            }
            
        }

        private void Switch_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (MyS.IsToggled == true)
            {
                DisplayAlert($"Верхний Switch!", "Активен", "Ок");
            }
        }

        private void Slider_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(SlOne.Value == 100)
            {
                DisplayAlert($"Верхний Slider!", "100%", "Ок");
            }
        }

        private void SlTwo_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (SlTwo.Value == 100)
            {
                DisplayAlert($"Средний Slider!", "100%", "Ок");
            }
        }

        private void SlThree_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (SlThree.Value == 100)
            {
                DisplayAlert($"Нижний Slider!", "100%", "Ок");
            }
        }
    }
}
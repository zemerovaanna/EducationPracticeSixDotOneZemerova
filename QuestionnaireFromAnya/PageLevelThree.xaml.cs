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
    public partial class PageLevelThree : ContentPage

    {
        string name;
        string like;
        string work;
        string mood;
        string ageot;
        string agedo;
        public PageLevelThree(string username)
        {
            InitializeComponent();
            name = username;
            like = "";
            work = "";
            mood = "";
            ageot = "";
            agedo = "";
        }

        private void SliderDo_ValueChanged(object sender, ValueChangedEventArgs e)
        {

            agedo = $"{Math.Round(SliderProcentDO.Value, 0)}";
            LabelProcentDO.Text = agedo;
        }

        private void SliderProcentOT_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            ageot = $"{Math.Round(SliderProcentOT.Value, 0)}";
            LabelProcentOT.Text = ageot;
        }

        private void SliderMood_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            mood = $"{SliderMood.Value} %";
            LabelProcentMood.Text = mood;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            like = "";

            if (CheckBoxLearning.IsChecked == true)
            {
                like += $"{LabelLearning.Text};";
            }
            if (CheckBoxEating.IsChecked == true)
            {
                like += $"{LabelEating.Text};";
            }
            if (CheckBoxSocial.IsChecked == true)
            {
                like += $"{LabelSocial.Text};";
            }


            if (RadioButtonProgrammer.IsChecked == true)
            {
                work = RadioButtonProgrammer.ContentAsString();
            }

            if (RadioButtonDesigner.IsChecked == true)
            {
                work = RadioButtonDesigner.ContentAsString();
            }

            if (RadioButtonBank.IsChecked == true)
            {
                work = RadioButtonBank.ContentAsString();
            }

            if (name != "" && like != "" && work != "" && mood != "" && ageot != "" && agedo != "")
            {
                Navigation.PushAsync(new Result(name, like, work, mood, ageot, agedo));
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            like = "";

            if (CheckBoxLearning.IsChecked == true)
            {
                like += $"{LabelLearning.Text};";
            }
            if (CheckBoxEating.IsChecked == true)
            {
                like += $"{LabelEating.Text};";
            }
            if (CheckBoxSocial.IsChecked == true)
            {
                like += $"{LabelSocial.Text};";
            }


            if (RadioButtonProgrammer.IsChecked == true)
            {
                work = RadioButtonProgrammer.ContentAsString();
            }

            else if (RadioButtonDesigner.IsChecked == true)
            {
                work = RadioButtonDesigner.ContentAsString();
            }

            else if (RadioButtonBank.IsChecked == true)
            {
                work = RadioButtonBank.ContentAsString();
            }

            Navigation.PushAsync(new Result(name, like, work, mood, ageot, agedo));
        }
    }
}
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
	public partial class PageLevelOne : ContentPage
	{
        string name;
		public PageLevelOne (string username)
		{
			InitializeComponent ();
            name = username;
            DisplayAlert($"Привет {name} 😇!", "Для начала прохождения анкеты нужно найти работающую кнопку. Удачи!!!", "Выбора нет, сейчас найду.");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageLevelTwo(name));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert($"{name}, не расстраивайся!", "Может быть в следующий раз ты найдёшь работающую кнопку. К счастью попытки не ограничены 😉.", "Допустим");
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            DisplayAlert($"🤔", "Кнопка, на которую хотели нажать выглядит подозрительно...", "Может быть");
        }
    }
}
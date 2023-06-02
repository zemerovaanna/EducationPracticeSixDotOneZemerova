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
    public partial class PageLevelTwo : ContentPage
    {
        string name;
        public PageLevelTwo(string username)
        {
            InitializeComponent();
            name = username;
            DisplayAlert($"Ещё раз здравствуй, {name}!", "Было принято решение усложнить эту страницу. Будем считать, что придыдущая была тренировкой 🤭.", "Понятно");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert($"УРАААА!", $"{name} - молодец! Нужная кнопка найдена и мы идём заполнять анкету 🥳.", "Ура, до встречи на следующей странице!");
            Navigation.PushAsync(new PageLevelThree(name));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert($"Дам подсказку", "Теплее 🙈!", "Надеюсь я найду эту кнопку...");
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            DisplayAlert($"Дам подсказку", "Холодно 😢!", "Надеюсь я найду эту кнопку...");
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            DisplayAlert($"Всё хорошо, ты сможешь!", "Принято решение добить замученные кнопки?", "🤔");
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            DisplayAlert($"Есть идея!", "Как насчёт хода наискосок?", "А если это ловушка?");
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            DisplayAlert($"Тест на доверие!", "Нажмёшь на тоже замученную кнопку или жалко её?", "Я подумаю");
        }
    }
}
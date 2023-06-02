using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuestionnaireFromAnya
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonSingIn_Clicked(object sender, EventArgs e)
        {
            if (EntryName.Text != "" && EntryName.Text != null)
            {



                if (EntryPassword.Text != "" && EntryPassword.Text != null)
                {



                    bool goodname = false;

                    foreach (char symbol in EntryName.Text)
                    {


                        if (!char.IsLetter(symbol))
                        {
                            goodname = false;
                            break;
                        }
                        else
                        {
                            goodname = true;
                        }


                    }

                    if (goodname == true)
                    {


                        if (EntryName.Text.Length >= 3)
                        {


                            if (EntryPassword.Text.Length >= 5)
                            {
                                {
                                    Navigation.PushAsync(new PageLevelOne(EntryName.Text));
                                }
                            }
                            else
                            {
                                DisplayAlert("Внимание", "В пароле содержиться не меньше пяти символов.", "Понятно");
                            }


                        }
                        else
                        {
                            DisplayAlert("Внимание", "В имени содержиться не меньше трёх букв.", "Понятно");
                        }


                    }
                    else
                    {
                        DisplayAlert("Внимание", "В имени содержаться только буквы.", "Понятно");
                    }



                }
                else
                {
                    DisplayAlert("Внимание", "Для входа в аккаунт нужно написать пароль от аккаунта в поле для ввода пароля.", "Понятно");
                }



            }
            else
            {
                DisplayAlert("Внимание", "Для входа в аккаунт нужно указать имя пользователя в поле для ввода имени пользователя.", "Понятно");
            }
        }
    }
}
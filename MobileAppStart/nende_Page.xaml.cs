using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppStart
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class nende_Page : ContentPage
    {
        Picker picker;
        Picker picker2;
        WebView webView;
        WebView webView2;
        StackLayout st;
        StackLayout st2;
        string[] lehed = new string[15] { "https://triptoestonia.com/ida-virumaa/", "https://triptoestonia.com/uezdy-estonii/estonskij-uezd-jygevamaa/", "https://triptoestonia.com/uezdy-estonii/estonskij-uezd-lyaenemaa/", "https://triptoestonia.com/uezdy-estonii/estonskij-uezd-lyaene-virumaa/", "https://triptoestonia.com/uezdy-estonii/estonskij-uezd-pylvamaa/", "https://triptoestonia.com/uezdy-estonii/estonskij-uezd-pyarnumaa/", "https://triptoestonia.com/uezdy-estonii/estonskij-uezd-raplamaa/", "https://triptoestonia.com/uezdy-estonii/estonskij-uezd-saaremaa/", "https://triptoestonia.com/tartumaa/", "https://triptoestonia.com/uezdy-estonii/estonskij-uezd-xaryumaa/", "https://triptoestonia.com/uezdy-estonii/estonskij-uezd-xijumaa/", "https://triptoestonia.com/uezdy-estonii/estonskij-uezd-vyrumaa/", "https://triptoestonia.com/uezdy-estonii/estonskij-uezd-vilyandimaa/", "https://triptoestonia.com/valgamaa/", "" };
        public nende_Page()
        {
            picker = new Picker
            {
                Title = "Уезды"
            };
            picker.Items.Add("ИДА-ВИРУМАА");
            picker.Items.Add("ЙЫГЕВАМАА");
            picker.Items.Add("ЛЯЭНЕМАА");
            picker.Items.Add("ЛЯЭНЕ-ВИРУМАА");
            picker.Items.Add("ПЫЛВАМАА");
            picker.Items.Add("ПЯРНУМАА");
            picker.Items.Add("РАПЛАМАА");
            picker.Items.Add("СААРЕМАА");
            picker.Items.Add("ТАРТУМАА");
            picker.Items.Add("ХАРЬЮМАА");
            picker.Items.Add("ХИЙУМАА");
            picker.Items.Add("ВЫРУМАА");
            picker.Items.Add("ВИЛЬЯНДИМАА");
            picker.Items.Add("ВАЛГАМАА");
            picker.SelectedIndexChanged += Picker_SelectedIndexChanged;
            webView = new WebView
            { };
            SwipeGestureRecognizer swipe = new SwipeGestureRecognizer();
            swipe.Swiped += Swipe_Swiped;
            swipe.Direction = SwipeDirection.Right;
            webView.GestureRecognizers.Add(swipe);
            st = new StackLayout { Children = { picker } };
            Content = st;

            picker2 = new Picker
            {
                Title = "Столица"
            };
            picker2.Items.Add("Йыхви");
            picker2.Items.Add("Йыгева");
            picker2.Items.Add("Хаапсалу");
            picker2.Items.Add("Раквере");
            picker2.Items.Add("Пылва");
            picker2.Items.Add("Пярну");
            picker2.Items.Add("Рапла");
            picker2.Items.Add("Курессааре");
            picker2.Items.Add("Тарту");
            picker2.Items.Add("Таллин");
            picker2.Items.Add("Кярдла");
            picker2.Items.Add("Выру");
            picker2.Items.Add("Вильянди");
            picker2.Items.Add("Валга");
            picker2.SelectedIndexChanged += Picker_SelectedIndexChanged;
            webView2 = new WebView
            { };
            SwipeGestureRecognizer swipe2 = new SwipeGestureRecognizer();
            swipe.Swiped += Swipe_Swiped;
            swipe.Direction = SwipeDirection.Right;
            webView2.GestureRecognizers.Add(swipe);
            st2 = new StackLayout { Children = { picker } };
            Content = st2;



            var entry = new Entry
            {
                Placeholder = "Please Enter Some Text Here",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Keyboard = Keyboard.Email
            };
        }
            private void Swipe_Swiped(object sender, SwipedEventArgs e)
        {
            webView.Source = new UrlWebViewSource { Url = lehed[15] };
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (webView != null)
            {
                st.Children.Remove(webView);
            }
            webView = new WebView
            {
                Source = new UrlWebViewSource { Url = lehed[picker.SelectedIndex] },
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            st.Children.Add(webView);
        }
    }
}
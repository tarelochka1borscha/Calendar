using System;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CalendarData.Visibility = Visibility.Hidden;
            DateTime selected_date = Convert.ToDateTime(DP.SelectedDate);
            DateTime current_date = DateTime.Now;
            int years = current_date.Year - selected_date.Year;
            int months = current_date.Month - selected_date.Month;
            int days = current_date.Day - selected_date.Day;

            //я не знаю, как это сделать без костылей:с
            if (days < 0)
            {
                months -= 1;
                if (current_date.Month % 2 != 0) days = 31 + days;
                else if ((current_date.Month == 2) && (current_date.Year % 4 == 0)) days = 29 + days;
                else if (current_date.Month == 2) days = 28 + days;
                else days = 30 - days;
            }

            if (months < 0)
            {
                years -= 1;
                months = 12 + months;
            }
            Age.Text = $"С Вашего дня рождения прошло {years} лет, {months} месяцев, {days} дней.";
            Age.Visibility = Visibility.Visible;
            string dayofweek_ru = "";
            switch (Convert.ToString(selected_date.DayOfWeek))
            {
                case "Monday": dayofweek_ru = "понедельник"; break;
                case "Tuesday": dayofweek_ru = "вторник"; break;
                case "Wednesday": dayofweek_ru = "среду"; break;
                case "Thursday": dayofweek_ru = "четверг"; break;
                case "Friday": dayofweek_ru = "пятницу"; break;
                case "Saturday": dayofweek_ru = "субботу"; break;
                case "Sunday": dayofweek_ru = "воскресение"; break;
            }
            int count_birthday = 0;
            for (DateTime i = selected_date.AddYears(1); i < current_date; i = i.AddYears(1))
            {
                if ((i.Day == selected_date.Day) && (i.Month == selected_date.Month) && (i.DayOfWeek == selected_date.DayOfWeek)) count_birthday++;
            }
            CountBD.Text = $"Вы родились в {dayofweek_ru}. Вы отпраздновали {count_birthday} дней рождения в тот же день недели, когда и родились.";
            CountBD.Visibility = Visibility.Visible;

            int count_years = 0;
            string all_years = "";
            for (DateTime i = selected_date.AddYears(1); i < current_date; i = i.AddYears(1))
            {
                if (i.Year % 4 == 0)
                {
                    count_years++;
                    all_years += i.Year + ", ";
                }
            }
            if (all_years == "") all_years = " отсутствуют  ";
            Days.Text = $"С Вашего дня рождения прошло {count_years} високосных лет ({all_years.Substring(0, all_years.Length - 2)}).";
            Days.Visibility = Visibility.Visible;

            Calendars.Visibility = Visibility.Visible;
            East.Visibility = Visibility.Visible;
            Slavic.Visibility = Visibility.Visible;
        }

        private void East_Click(object sender, RoutedEventArgs e) //не поняла закономерность начала года
        {
            DateTime selected_date = Convert.ToDateTime(DP.SelectedDate);

            string color = "", animal = "";
            int last_nimber = selected_date.Year % 10;
            switch (last_nimber)
            {
                case 0:
                case 1: color = "белого(ой)"; break;
                case 2:
                case 3: color = "синегл(ей)"; break;
                case 4:
                case 5: color = "зеленого(ой)"; break;
                case 6:
                case 7: color = "красного(ой)"; break;
                case 8:
                case 9: color = "желтого(ой)"; break;
            }
            string[] all_animals = { "крысы", "быка", "тигра", "кролика", "дракона", "змеи", "лошади", "овцы", "обезьяны", "петуха", "собаки", "свиньи" };
            int j = 0;
            for (int i = 1900; i <= selected_date.Year; i++)
            {
                if (j == 12) j = 0;
                if (i == selected_date.Year)
                {
                    animal = all_animals[j];
                    break;
                }
                j++;
            }
            CalendarData.Text = $"Вы родились в год {color} {animal}.";
            CalendarData.Visibility = Visibility.Visible;
        }

        private void Slavic_Click(object sender, RoutedEventArgs e)
        {
            DateTime selected_date = Convert.ToDateTime(DP.SelectedDate);
            if ((selected_date.Month == 12 && selected_date.Day >= 24) || (selected_date.Month == 1 && selected_date.Day <= 30)) CalendarData.Text = "Вы родились под покровительством Мороза, бога-повелителя зимнего холода.";
            if ((selected_date.Month == 1 && selected_date.Day == 31) || (selected_date.Month == 2 && selected_date.Day <= 29)) CalendarData.Text = "Вы родились под покровительством Велеса, бога-медведя, покровителя охотников.";
            if (selected_date.Month == 3) CalendarData.Text = "Вы родились под покровительством Мокоши, жены Велеса, богини судьбы, плодородия и семейного очага.";
            if (selected_date.Month == 4) CalendarData.Text = "Вы родились под покровительством Живы, богини плодородия, юности и красоты";
            if ((selected_date.Month == 5) && (selected_date.Day <= 14)) CalendarData.Text = "Вы родились под покровительством Ярило, бога весны и расцвета всех жизненных сил человека";
            if ((selected_date.Month == 5 && selected_date.Day >= 15) || (selected_date.Month == 6 && selected_date.Day <= 2)) CalendarData.Text = "Вы родились под покровительством Лели, богини девичьей любви, красоты и счастья.";
            if ((selected_date.Month == 6) && (selected_date.Day > 2 && selected_date.Day <= 12)) CalendarData.Text = "Вы родились под покровительством Костромы, богини плодородия и и лета.";
            if ((selected_date.Month == 6 && selected_date.Day >= 13) || (selected_date.Month == 7 && selected_date.Day <= 6)) CalendarData.Text = "Вы родились под покровительством Додолы, богини молодости, лета и веселья.";
            if (selected_date.Month == 6 && selected_date.Day == 24) CalendarData.Text += " В этот день празднуется Иван Купала, праздник солнца, зрелости лета и зеленого покоса.";
            if (selected_date.Month == 7 && selected_date.Day >= 7) CalendarData.Text = "Вы родились под покровительством Лады, богини-матери, хранительницы домашнего очага.";
            if (selected_date.Month == 8 && selected_date.Day <= 28) CalendarData.Text = "Вы родились под покровительством Перуна, бога грозы.";
            if ((selected_date.Month == 8 && selected_date.Day >= 29) || (selected_date.Month == 9 && selected_date.Day <= 13)) CalendarData.Text = "Вы родились под покровительством Севы, богини садовых плодов.";
            if ((selected_date.Month == 9) && (selected_date.Day >= 14 && selected_date.Day <= 27)) CalendarData.Text = "Вы родились под покровительством Рожаницы, покровительницей жизни и плодородия.";
            if ((selected_date.Month == 9 && selected_date.Day >= 28) || (selected_date.Month == 10 && selected_date.Day <= 15)) CalendarData.Text = "Вы родились под покровительством Сварожичей, детей Сварога, бога огня.";
            if ((selected_date.Month == 10 && selected_date.Day >= 16) || (selected_date.Month == 11 && selected_date.Day <= 8)) CalendarData.Text = "Вы родились под покровительством Морены, богини увядания и смерти.";
            if ((selected_date.Month == 11) && (selected_date.Day >= 9 && selected_date.Day <= 28)) CalendarData.Text = "Вы родились под покровительством Зимы.";
            if ((selected_date.Month == 11 && selected_date.Day >= 29) || (selected_date.Month == 12 && selected_date.Day <= 23)) CalendarData.Text = "Вы родились под покровительством Карачуна, повелителя морозов, холода и мрака";
            CalendarData.Visibility = Visibility.Visible;
        }
    }
}

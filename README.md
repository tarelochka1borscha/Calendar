# Calculator
Программа для подсчитывания разной информации по Вашему дню рождения.
## Описание
Программа написана на C# с использованием инструментов среды разработки Microsoft Visual Studio 2022.

![image](https://github.com/tarelochka1borscha/Calendar/assets/132044872/0de4c2ed-d87c-4e09-a4fd-4c7e13f40d3a)

В программе реализован подсчет таких данных, как:
- количество дней, месяцев и лет с момента вашего рождения;
- сколько раз Вы отпраздновали день рождения в день, когда Вы родились;
- сколько високосных лет прошло с дня Вашего рождения.
Также Вы можете узнать, кем являетесь по славянскому и ~~ящерскому~~ восточному календарю.
---
Для корректной работы приложения необходимо:
1. Ввести дату рождения, либо же любую другую.
    - дату рождения можно ввести вручную в формате *дд.мм.гг*, либо же выбрать с помощью календаря
2. Нажать кнопку "Вычислить".
3. После выбрать любой календарь и нажать соответствующую кнопку.
4. После обновления даты повторить описанное выше.
## Установка
### Системные требования и не только
1. Компьютер, соответствующий системным требованиям Microsoft Visual Studio с поддержкой WPF.
2. Наличие рожденного человека, желательно с руками и глазами.
### Процесс установки
Установить программу на компьютер можно двумя способами:
1. Скачивание zip-архива.
2. Клонирование репозитория (пожалуйста, не делайте так).
#### Скачивание zip-архива
Для этого необходимо:
1. Перейти на страницу проекта.
2. Нажать < > Code.
3. Выбрать соответствующий пункт.

![image](https://github.com/tarelochka1borscha/Calendar/assets/132044872/e97fc754-dfb9-476c-a3bc-4323629f7fdc)
#### Клонирование репозитория
Если Вы решили это сделать назло мне, для этого необходимо:
1. Перейти на страницу проекта.
2. Нажать < > Code.
3. Выбрать соответствующий пункт.
---
Если Вы решили не идти по легкому пути, можно через сам Visual Studio клонировать репозиторий. Для этого потребуется ссылка на репозиторий Git.

![image](https://github.com/tarelochka1borscha/Calendar/assets/132044872/5f885a7d-fb68-4c67-92e0-f985fa10eaa7)

1. Откройте Visual Studio и выберите пункт "Клонировать репозиторий".
![image](https://github.com/tarelochka1borscha/Calendar/assets/132044872/2498d0d6-763c-46a0-a575-5e818ef6d134)
2. Вставьте скопированную ссылку.
![image](https://github.com/tarelochka1borscha/Calendar/assets/132044872/ac42880f-5c2e-4a87-89ea-4c068d4ab1d7)

## Бесполезная информация, но чтобы было
Пример кода программы, чтобы Вы понимали степень моего отчаяния при написании.
```c#
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
```
## Разработчик

<https://github.com/tarelochka1borscha>(fff)

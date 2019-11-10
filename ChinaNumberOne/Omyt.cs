namespace ChinaNumberOne
{
    public class Proverka
    {
        public static string Zodiac(int year, int month, int day)
        {
            if ((day >= 21 && month == 3) || (day <= 20 && month == 4)) return "Овен";
            if ((day >= 21 && month == 4) || (day <= 20 && month == 5)) return "Телец";
            if ((day >= 21 && month == 5) || (day <= 21 && month == 6)) return "Близнецы";
            if ((day >= 22 && month == 6) || (day <= 22 && month == 7)) return "Рак";
            if ((day >= 23 && month == 7) || (day <= 23 && month == 8)) return "Рев";
            if ((day >= 24 && month == 8) || (day <= 23 && month == 9)) return "Дева";
            if ((day >= 24 && month == 9) || (day <= 23 && month == 10)) return "Весы";
            if ((day >= 24 && month == 10) || (day <= 22 && month == 11)) return "Скорпион";
            if ((day >= 23 && month == 11) || (day <= 21 && month == 12)) return "Стрелец";
            if ((day >= 22 && month == 12) || (day <= 20 && month == 1)) return "Козерог";
            if ((day >= 21 && month == 1) || (day <= 18 && month == 2)) return "Водолей";
            else return "рыбы";
        }
        public static string Сalendar(int year, int month, int day)
        {
            if (year % 4 != 0)
            {
                switch (year % 12)
                {
                    case 1: return "Курицы";
                    case 2: return "Собаки";
                    case 3: return "Свиньи";
                    case 4: return "Мыши";
                    case 5: return "Коровы";
                    case 6: return "Tигра";
                    case 7: return "Заяца";
                    case 8: return "Улитки";
                    case 9: return "Змеи";
                    case 10: return "Лошади";
                    case 11: return "Овцы";
                    case 12: return "Обезьяны";
                }
                return "Да кто ты такой вообще";
            }
            else
            {
                switch (year % 2 + 11)
                {
                    case 0: return "Rурицы и ваш год високостный";
                    case 1: return "Cобаки и ваш год високостный";
                    case 2: return "Cвиньи и ваш год високостный";
                    case 3: return "Мыши и ваш год високостный";
                    case 4: return "Коровы и ваш год високостный";
                    case 5: return "Тигра и ваш год високостный";
                    case 6: return "Заяца и ваш год високостный";
                    case 7: return "Улитки и ваш год високостный";
                    case 8: return "Змеи и ваш год високостный";
                    case 9: return "Лошади и ваш год високостный";
                    case 10: return "Овцы и ваш год високостный";
                    case 11: return "Обезьяны и ваш год високостный";
                }
                return "Да кто ты такой вообще , ваш год високостный";
            }
        }
    }
}

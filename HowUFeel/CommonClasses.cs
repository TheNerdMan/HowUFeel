using System;
using System.Collections.Generic;
using System.Text;

namespace HowUFeel
{
    public enum Mood
    {
        error = 0,
        reallyBad = 1,
        bad = 2,
        meh = 3,
        okay = 4,
        great = 5,
        flux = 6,
        angry = 7,
        productive = 8,
        proud = 9,
        ashamed = 10,
        foreboding = 11,
        crying = 12,
        sad = 13
    }

    public class DayMood
    {
        Mood DaysMood { get; set; }

        DateTime Date { get; set; }

        string Note { get; set; } = "";

        public DayMood(Mood mood, DateTime date, string note){
            DaysMood = mood;

            Date = date;

            Note = String.IsNullOrWhiteSpace(note) ? null : note;
        }

        public DayMood()
        {
            //Needed for SQLite PLC
        }

        public override string ToString()
        {
            return String.Format("{0}~{1}~{2}", DaysMood.ToString(), Date.Day, Note);
        }
    }

    public class WeekMood
    {
        List<DayMood> LstWeekMood { get; set; }
    }

    public class MonthMood
    {
        List<WeekMood> LstMonthMood { get; set; }
    }
}

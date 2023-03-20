using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using System.Text;

namespace MyFirstCodeOOP
{
    //Creacion de la clase DATE
    public class Date 
    {
        #region Properties
        public int _year;
        public int _month;
        public int _day;
        #endregion

        //Creacion del metodo constructor DATE
        #region Constructor
        public Date(int year, int month, int day) 
        {
            //Es igual si colocamos el .this? --antes del _year.
           _year = ValidateYear(year);
           _month = ValidateMonth(month);
           _day = ValidateDay(year, month, day);
        }
        #endregion
        //Creamos el validador del año, creacion del METODO.
        #region Methods
        private int ValidateYear(int year)
        {
            if (year >= 1900)

            {
                return year;
            }

            throw new YearException(String.Format("The year {0} is invalid.", year));
        }

        //Vamos a crear el validador de los dias.
        //Creacion del METODO.

        private int ValidateDay (int year, int month, int day)
        {
            if (month == 2 && day == 29 && IsLeapYear(year)) 
            {
                return day;
            }

            int[] daysPerMont = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMont[month])
            {
                return day;
            }

            throw new DayException(String.Format("The day {0} doesn't exist for month{1}.", day, month));
        }

        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }

            throw new MonthException(String.Format("The month {0} is invalid.", month));
        }

        public override string ToString()
        {
            return String.Format("{0:00}/{1:00}/{2:00}", _year, _month, _day);
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        

        #endregion
    }

    //Que puedo hacer con esto?

    [Serializable]
    internal class MonthException : Exception
    {
        public MonthException()
        {
        }

        public MonthException(string message) : base(message)
        {
        }

        public MonthException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MonthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

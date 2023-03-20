using System;
using System.Collections.Generic;
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
            this._year = year;
            this._month = ValidateMonth(month);
            this._day = ValidateDay(day, month);
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{_year:0000}/{_month:00}/{_day:00}";
        }

        //Vamos a crear el validador de los dias.
        //Creacion del METODO.

        private int ValidateDay(int day, int month)
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if 
            }
        }

        private int ValidateMonth(int month)
        {
            if (month <= 1 && month <= 12)
            {
                return month;
            }

            throw new MonthException("The month is invalid!");
        }


        #endregion
    }

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

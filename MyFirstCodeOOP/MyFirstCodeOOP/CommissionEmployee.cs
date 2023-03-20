using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{ 
    public class CommissionEmployee : Employee 

    {
        #region Properties
        public float CommissionPercentage { get; set; }
        public decimal Sales { get; set; }

        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)convertPercentage(CommissionPercentage);
        }

        //Me salia un error  me genero este codigo, es necesario debo preguntar.
        //private decimal ConvertPercentage(float commissionPercentage)
        //{
        //    throw new NotImplementedException();
        //}
        //Hasta aqui!

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission Percentage.....{convertPercentage(CommissionPercentage):P2}" +
                $"\n\tSales..............{Sales:C2}" +
                $"\n\tValue To Pay........{GetValueToPay():C2}";
        }

        public float convertPercentage(float commissionPercentage)
        {
            return (commissionPercentage / 100);
        }
        #endregion
    }
}

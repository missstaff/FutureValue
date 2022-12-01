using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace FutureValue.Models
{
    public class FutureValueModels
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please enter a monthly investment amount.")]
        [Range(1, 500, ErrorMessage = "Monthly investment amounts must be between 1 and 500.")]
        public decimal? MonthlyInvestment { get; set; }


        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please enter a yearly interest rate.")]
        [Range(0.1, 10, ErrorMessage = "Yearly interest rate must be betweeon 0.1 and 10.")]
        public decimal? YearlyInterestRate { get; set; }


        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please enter number of years")]
        [Range(0.1, 10, ErrorMessage = "Number of years must be betweeon 1 and 50.")]
        public int? Years { get; set; }  


        public decimal? CalculateFutureValue()
        {
            int? months = Years * 12;
            decimal? monthlyInterestRate = YearlyInterestRate / 12 / 100;
            decimal? futureValue = 0;

            for(int i =0; i < months; i++) 
            {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
    }
}

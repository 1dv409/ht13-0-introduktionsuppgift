using System.Collections.Generic;
using System.Web.Mvc;
using MyValuableCalculator.Models;

namespace MyValuableCalculator.ViewModels
{
    public class HomeIndexViewModel
    {
        public ElementaryMath ElementaryMath { get; set; }

        public SelectList ArithmeticOperations
        {
            get
            {
                var items = new Dictionary<ArithmeticOperation, string>
                {
                    { ArithmeticOperation.Addition, "+" },
                    { ArithmeticOperation.Subtraction, "-" },
                    { ArithmeticOperation.Multiplication, "*" },
                    { ArithmeticOperation.Division, "/" },
                };

                return new SelectList(items, "Key", "Value");
            }
        }
    }
}
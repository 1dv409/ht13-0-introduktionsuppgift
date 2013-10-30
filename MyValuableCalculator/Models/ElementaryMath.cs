using System.ComponentModel.DataAnnotations;

namespace MyValuableCalculator.Models
{
    public enum ArithmeticOperation { Addition, Subtraction, Multiplication, Division }

    public class ElementaryMath
    {
        public ArithmeticOperation ArithmeticOperation { get; set; }

        [Required]
        public int Op1 { get; set; }

        [Required]
        public int Op2 { get; set; }

        public int? Result { get; private set; }

        public void Compute()
        {
            switch (this.ArithmeticOperation)
            {
                case ArithmeticOperation.Addition:
                    this.Result = this.Op1 + this.Op2;
                    break;

                case ArithmeticOperation.Subtraction:
                    this.Result = this.Op1 - this.Op2;
                    break;

                case ArithmeticOperation.Multiplication:
                    this.Result = this.Op1 * this.Op2;
                    break;

                case ArithmeticOperation.Division:
                    this.Result = this.Op1 / this.Op2;
                    break;
            }
        }
    }
}
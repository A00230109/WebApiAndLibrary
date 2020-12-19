using System;
using System.Web.Http;
using WebAPI.Controllers;

namespace ClassLibraryCalculator
{
    public class SimpleCalc
    {
        private AddController addController = new AddController();
        private SubstractController substractController = new SubstractController();
        private MultiplyController multiplyController = new MultiplyController();
        private DivideController divideController = new DivideController();
        
        
        public double AddNumbers(double leftNumber, double rightNumber)
        {
            return  addController.Post(leftNumber, rightNumber);
        }
        public double SubstractNumbers(double leftNumber, double rightNumber)
        {
            return substractController.Post(leftNumber, rightNumber);
        }
        public double MultiplyNumbers(double leftNumber, double rightNumber)
        {
            return multiplyController.Post(leftNumber, rightNumber);
        }

        public double DivideNumbers(double leftNumber, double rightNumber)
        {
            return divideController.Post(leftNumber, rightNumber);
        }
    }
}

namespace ProGitForProgrammers
{
    public class Calculator
    {
        public int Add(int left, int right)
        {
            return left + right;
        }
        public decimal Add(decimal left, decimal right)
        {
            return left + right;
        }
        public int Subtract(int left, int right)
        {
            return left - right;
        }
        public decimal Subtract(decimal left, decimal right)
        {
            return left - right;
        }
        public int Multiply(int left, int right)
        {
            return left * right;
        }
        public int Divide(int left, int right)
        {
            return left / right;
        }
    }
}
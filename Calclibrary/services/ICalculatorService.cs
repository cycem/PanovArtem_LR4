namespace CalcLibrary.services
{
    public interface ICalculatorService
    {
        double Calculate(string expr);
        double CalculateEngineering(string op, double val);
        string CalculatePercent(string text);
    }
}
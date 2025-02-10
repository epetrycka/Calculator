namespace intern25
{
    public static class Calculations
    {
        public static double PerformCalculation(MathExpObject op)
        {
            try
            {
                return op.Oper switch
                {
                    "add" => (op.Value1 ?? 0) + (op.Value2 ?? 0),
                    "sub" => (op.Value1 ?? 0) - (op.Value2 ?? 0),
                    "mul" => (op.Value1 ?? 0) * (op.Value2 ?? 1),
                    "sqrt" => Math.Sqrt(op.Value1 ?? 0),
                    _ => throw new InvalidOperationException($"Nieznany operator: {op.Oper}")
                };
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}

using System;

namespace Polynomial
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static float ComputeCovidCases(float day)
        {
            float[] coeffs = new[] { 0.6f, -2.133257f, 2.182121f, -0.399069f, 0.029503f, -0.000803f };

            float res = 0f;
            for (int i = 0; i < coeffs.Length; i++)
            {
                res += coeffs[i] * (float) Math.Pow(day, i);
            }

            return res;
        }
        
        public static float ComputePolynomial(float x, float[] coefficients)
        {
            float res = 0f;
            for (int i = 0; i < coefficients.Length; i++)
            {
                res += coefficients[i] * (float) Math.Pow(x, i);
            }

            return res;
        }
    }
}
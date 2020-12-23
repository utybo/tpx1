using System;
using System.Threading;

namespace Polynomial
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static float ComputeCovidCases(float day)
        {
            float[] coeffs = new[] {0.6f, -2.133257f, 2.182121f, -0.399069f, 0.029503f, -0.000803f};

            float res = 0f;
            for (int i = 0; i < coeffs.Length; i++)
            {
                res += coeffs[i] * (float) Math.Pow(day, i);
            }

            return res;
        }

        public static float[] AddCoefficient(float[] coefficients, float x, int exponent)
        {
            if (exponent >= coefficients.Length)
            {
                float[] newCoefficients = new float[exponent+1];

                for (int i = 0; i < coefficients.Length; i++)
                {
                    newCoefficients[i] = coefficients[i];
                }

                newCoefficients[exponent] = x;

                return newCoefficients;
            }
            else
            {
                coefficients[exponent] = x;
                return coefficients;
            }
        }

        public static string PolynomialToString(float[] coefficients)
        {
            string res = "";

            for (int i = 0; i < coefficients.Length; i++)
            {
                var coeff = coefficients[i];

                if (coeff != 0f)
                {
                    string sign = " + ";
                    
                    if (coeff < 0)
                        sign = " - ";

                    if (i == 0)
                    {
                        if (coeff < 0)
                            sign = "- ";
                        else
                            sign = "- ";
                    }
                        

                    res += $"{sign}{Math.Abs(coeff)}";

                    if (i != 0)
                        res += $"^{i}";
                    
                }
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
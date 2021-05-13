using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EquationSolver
{
    public class EquationDataExtractor
    {

        public EquationDataExtractor(string Equation)
        {
            GetCoefficientFromEquation(Equation);
        }

        void GetCoefficientFromEquation(string Equation)
        {
            //Split the incoming equation by spaces
            //Ex: 3X + 5x - 6 + 2X => 3X, +, 5x, -, 6, +, 2X
            List<string> coefficients = Equation.Split(' ').ToList();
            for (int i = 0; i < coefficients.Count; i++)
            {
                //If the string has an X in it, then it must have an 'a' coefficient
                if (coefficients[i].Contains("X") == true)
                {
                    //Replace that X with an empty string to make the string contain the coefficient only
                    coefficients[i] = coefficients[i].Replace("X", "");

                    //Get the sign of the coefficient by checking whether it has a + or - before it
                    //If it has a +, or if there is no signs before the coefficient, then it's sign must be postive then add the coefficient to the a value
                    if (i == 0 || coefficients[i - 1] == "+")
                    {
                        //If the string became empty after replacing the X with an empty string, then the string did not contain any numbers before X
                        //ie: the coefficient of X is 1
                        if (coefficients[i] == "")
                        {
                            a += 1;
                        }

                        //If the string became only a - sign after replacing the X with an empty string, then the string did not contain any numbers before X and only contained a negative sign
                        //ie: the coefficient of X is -1
                        else if (coefficients[i] == "-")
                        {
                            a -= 1;
                        }

                        //If not, get the coefficient of X and add it to a
                        else
                        {
                            a += double.Parse(coefficients[i]);
                        }

                    }

                    //If it has a -, then it's sign must be negative, then subtract the coefficient from the a value
                    else if (coefficients[i - 1] == "-")
                    {
                        //If the string became empty after replacing the X with an empty string, then the string did not contain any numbers before X
                        //ie: the coefficient of X is 1
                        if (coefficients[i] == "")
                        {
                            a -= 1;
                        }

                        //If not, get the coefficient of X and subtract it from a
                        else
                        {
                            a -= double.Parse(coefficients[i]);
                        }
                    }


                }

                //Repeat the same with the b coefficients

                else if (coefficients[i].Contains("x") == true)
                {
                    //Replace that x with an empty string to make the string contain the coefficient only
                    coefficients[i] = coefficients[i].Replace("x", "");

                    //Get the sign of the coefficient by checking whether it has a + or - before it
                    //If it has a +, or if there is no signs before the coefficient, then it's sign must be postive then add the coefficient to the b value
                    if (i == 0 || coefficients[i - 1] == "+")
                    {
                        //If the string became empty after replacing the x with an empty string, then the string did not contain any numbers before x
                        //ie: the coefficient of x is 1
                        if (coefficients[i] == "")
                        {
                            b += 1;
                        }

                        //If not, get the coefficient of x and add it to b
                        else
                        {
                            b += double.Parse(coefficients[i]);
                        }
                    }

                    //If it has a -, then it's sign must be negative, then subtract the coefficient from the b value
                    else if (coefficients[i - 1] == "-")
                    {
                        //If the string became empty after replacing the x with an empty string, then the string did not contain any numbers before x
                        //ie: the coefficient of x is 1
                        if (coefficients[i] == "")
                        {
                            b -= 1;
                        }

                        //If not, get the coefficient of x and subtract it from b
                        else
                        {
                            b -= double.Parse(coefficients[i]);
                        }
                    }


                }

                //If the string does not contain X or x or + or -, then the string must be a c term, then convert it into double and add or subtract it from the c field
                else if (coefficients[i].Contains("X") == false && coefficients[i].Contains("x") == false
                        && coefficients[i].Contains("+") == false && coefficients[i].Contains("-") == false)
                {

                    //Get the sign of the coefficient by checking whether it has a + or - before it
                    //If it has a +, or if there is no signs before the coefficient, then it's sign must be postive then add the coefficient to the c value
                    if (i == 0 || coefficients[i - 1] == "+")
                    {
                        c += double.Parse(coefficients[i]);
                    }

                    //If it has a -, then it's sign must be negative, then subtract the coefficient from the c value
                    else if (coefficients[i - 1] == "-")
                    {
                        c -= double.Parse(coefficients[i]);
                    }


                }

            }
        }

        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
    }
}

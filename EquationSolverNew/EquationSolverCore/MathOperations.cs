using System;
using System.Collections.Generic;

namespace EquationSolver
{
    public class MathOperations
    {
        public (string Result, bool IsTheResultAnInt) SimplifySquareRoot(int numberUnderRoot)
        {
            //Check whether the sqrt of the number given in the parameter is the same as the int version of the sqrt of the number given in the parameter
            //If so, the number is a perfect square and just return the sqrt of that number
            if ((int)Math.Sqrt(numberUnderRoot) == Math.Sqrt(numberUnderRoot))
            {
                return (Math.Sqrt(numberUnderRoot).ToString(), true);
            }

            //If not, continue the simplification process
            else
            {
                //Create a int list that will contain all the perfect square numbers below the number given in the parameter
                List<int> Squares = new List<int>();

                //Make a loop to add all the perfect square numbers below the number given in the parameter to the list
                for (int i = 0; Math.Pow(i, 2) <= numberUnderRoot; i++)
                {
                    Squares.Add(Convert.ToInt32(Math.Pow(i, 2)));
                }

                //Now reverse the list in order to make it in descending order
                //This will make sure we take divide the number under the root by the highest perfect square factor
                Squares.Reverse();

                //Loop on each number in the Squares list
                foreach (int square in Squares)
                {
                    //If the square is a factor of the number under the root
                    if (numberUnderRoot % square == 0)
                    {
                        //Pull out that perfect square factor outside the square root put the remaining under the square root
                        return (Math.Sqrt(square).ToString() + "√" + (numberUnderRoot / square).ToString() + "", false);
                    }
                }
                //If the number doesn't have any perfect square factors (such as prime numbers) then just print the number as it is
                return ("√" + numberUnderRoot.ToString() + "", false);
            }

        }

        public (string Solution1, string Solution2) SolveQuadraticEquation(double a, double b, double c)
        {
            //Calculate the discriminant (The part under the square root in the quadratic formula, which equals b^2 - 4ac)
            double discriminant = Math.Pow(b, 2) - (4 * a * c);

            //If the discriminant is bigger than 0, then the equation has 2 real roots and calculate them
            if (discriminant > 0)
            {
                //If the discriminant is a perfect square number, take it's square root and calculate the two solutions
                if (SimplifySquareRoot(Convert.ToInt32(discriminant)).IsTheResultAnInt == true)
                {
                    //Apply the quadratic formula using the a, b, and c given in the parameters
                    string Solution1 = (((-1 * b) + Math.Sqrt(discriminant)) / (2*a)).ToString();
                    string Solution2 = (((-1 * b) - Math.Sqrt(discriminant)) / (2*a)).ToString();
                    return (Solution1, Solution2);
                }

                //If the discriminant isn't a perfect square number, simplify the root and calculate the two solutions
                else
                {
                    //Apply the quadratic formula using the a, b, and c given in the parameters
                    string Numerator1 = (-1 * b).ToString() + "+" + SimplifySquareRoot(Convert.ToInt32(discriminant)).Result;
                    string Numerator2 = (-1 * b).ToString() + "-" + SimplifySquareRoot(Convert.ToInt32(discriminant)).Result;
                    string Denumerator = (2 * a).ToString();

                    //Make a string which contains the numerator on the top, then a group of dashes(to form the fraction line)
                    //The fraction line has a count equal to twice the number of characters of the numerator, to give a good shape
                    //Then the denumerator at the bottom with a spaces before him equal to the number of characters of the numerator, to give it a centered shape
                    string Solution1 = Numerator1 + "\n" + new string('-', Numerator1.Length * 2) + "\n" + new string(' ', Numerator1.Length) + Denumerator;
                    string Solution2 = Numerator2 + "\n" + new string('-', Numerator2.Length * 2) + "\n" + new string(' ', Numerator2.Length) + Denumerator;
                    return (Solution1, Solution2);
                }

            }

            //If the discriminant is 0, then the equation has one real root, which is -b/2a
            else if (discriminant == 0)
            {
                //Calculate the solution of the equation, and return the second solution as an empty string
                string Solution = ((-1 * b) / (2 * a)).ToString();
                return (Solution, "");
            }

            //If the discriminant is less than 0, then the equation has 2 imaginary roots and calculate them
            else if (discriminant < 0)
            {
                //Make a variable which equals the positive value of the discriminant
                double fakeDiscriminant = discriminant * -1;

                //If the Fake Discriminant is a perfect square number, take it's square root and calculate the two solutions
                if (SimplifySquareRoot(Convert.ToInt32(fakeDiscriminant)).IsTheResultAnInt == true)
                {
                    //Apply the quadratic formula using the a, b, and c given in the parameters, then add an i in the end to indicate the imaginary roots
                    string Solution1 = (((-1 * b) + Math.Sqrt(fakeDiscriminant)) / (2 * a)).ToString() + " i";
                    string Solution2 = (((-1 * b) - Math.Sqrt(fakeDiscriminant)) / (2 * a)).ToString() + " i";
                    return (Solution1, Solution2);
                }

                //If the  Fake Discriminant isn't a perfect square number, simplify the root and calculate the two solutions and add an i in the end to indicate the imaginary roots
                else
                {
                    //Apply the quadratic formula using the a, b, and c given in the parameters
                    string Numerator1 = (-1 * b).ToString() + "+" + SimplifySquareRoot(Convert.ToInt32(fakeDiscriminant)).Result + " i";
                    string Numerator2 = (-1 * b).ToString() + "-" + SimplifySquareRoot(Convert.ToInt32(fakeDiscriminant)).Result + " i";
                    string Denumerator = (2 * a).ToString();

                    //Make a string which contains the numerator on the top, then a group of dashes(to form the fraction line)
                    //The fraction line has a count equal to twice the number of characters of the numerator, to give a good shape
                    //Then the denumerator at the bottom with a spaces before him equal to the number of characters of the numerator, to give it a centered shape
                    string Solution1 = Numerator1 + "\n" + new string('-', Numerator1.Length * 2) + "\n" + new string(' ', Numerator1.Length) + Denumerator;
                    string Solution2 = Numerator2 + "\n" + new string('-', Numerator2.Length * 2) + "\n" + new string(' ', Numerator2.Length) + Denumerator;
                    return (Solution1, Solution2);
                }
            }
            return ("", "");
        }

    }
}

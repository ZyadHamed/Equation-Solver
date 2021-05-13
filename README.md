# Equation-Solver
This Program Allow User To solve Equations In One Variable Of Second Degree

# Changes in the code
New Features:
<br>
1- The program now is dynamic and can extract the a, b, and c coefficients from any equation given to him
<br>
Ex: 2X + 5x - 3 => a = 2, b = 5, c = -3. X - 2x + X + 5 - 3x - 2 => a = 2, b = -5, c = 3
<br>
2- The program also writes the solutions of the equation as they are written in your notebook. and not as a fraction anymore 
<br>
For example the solutions of the equation X + 4 - 6 = 0. will be written as -4 + 2sqrt(10) / 2 , -4 - 2sqrt(10) / 2, and not 1.1622, -5.1622
<br>
3- The program will simplify the roots, for example, if sqrt(18) does exist in the answer, it will write it as 3sqrt(2)
<br>
4- You can now switch between entering the coefficents manualy or typing the equation
<br>
<br>
Also, the architecture of the code has been changed completely, there is no code in the controls any more, instead, it's put into different classes according to what is the job of the code. And in the controls, it's just a matter of calling these classes.
<br>

Finally, the way that the code works changed from expecting the equation to be in a certain form in order to extract a, b, and c. To expecting an equation in any form and the data extracting algorithm will work on them all

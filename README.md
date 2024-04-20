This exercise you will be exploring more about properties and be introduced to overloading operators.

![image](https://github.com/dyeyniyel/comp123-lab4-part1-Complex/assets/158533198/db1b711e-b3a1-4577-9446-47fac30fa22b)


![image](https://github.com/dyeyniyel/comp123-lab4-part1-Complex/assets/158533198/20f163ca-20bf-4c16-aba5-01bee9d37f2e)


![image](https://github.com/dyeyniyel/comp123-lab4-part1-Complex/assets/158533198/c5f80a56-5201-4f00-954e-11f2655e12fd)


Test Harness

Insert the following code statements in your Program.cs file:





Complex c0 = new Complex(-2, 3);

Complex c1 = new Complex(-2, 3);

Complex c2 = new Complex(1, -2);



Console.WriteLine($"{c0}");

Console.WriteLine(c1);

Console.WriteLine(c2);



Console.WriteLine($"{c1} + {c2} = {c1 + c2}");

Console.WriteLine($"{c1} - {c2} = {c1 - c2}");



Complex c3 = c1 + c2;



Console.WriteLine($"{c3} in polar form is {c3.Modulus:f2}cis({c3.Argument:f2})");



Console.WriteLine($"{c0} {(c0 == c1 ? "=" : "!=")} {c1}");

Console.WriteLine($"{c0} {(c0 == c2 ? "=" : "!=")} {c2}"); 





Additional tasks

1.	Try to overload the * operator. Multiplication of two complex numbers is defined by the following relation: <a, b> * <c, d> = <ac-bd, ad+bc>. 

Insert the proper code statements in your main to show the operation of this operator.

2.	Try to overload the unary - operator. This operator simply changes the sign of the operand: -<a, b> = <-a, -b>. 

Again, insert the proper code statements in your main to show the operation of this operator.





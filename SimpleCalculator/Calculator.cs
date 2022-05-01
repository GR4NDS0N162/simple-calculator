using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
	class Calculator
	{
		static private bool IsOperator(char c)
		{
			if ("+-/*^()".IndexOf(c) != -1)
				return true;
			return false;
		}

		static private byte GetPriority(char op)
		{
			switch (op)
			{
				case '(': return 0;
				case ')': return 1;
				case '+': return 2;
				case '-': return 2;
				case '*': return 3;
				case '/': return 3;
				case '^': return 4;
				default: return 5;
			}
		}

		static private double Count(double a, double b, char op)
		{
			double result = 0;

			switch (op)
			{
				case '+': result = b + a; break;
				case '-': result = b - a; break;
				case '*': result = b * a; break;
				case '/':
					if (a == 0)
						throw new DivideByZeroException();
					result = b / a;
					break;
				case '^': result = Math.Pow(b, a); break;
			}

			if (double.IsInfinity(result) || double.IsNaN(result))
				throw new NotFiniteNumberException();

			return result;
		}

		static public double Calculate(string input)
		{
			Stack<char> operators = new Stack<char>();
			Stack<double> operands = new Stack<double>();
			bool uno = true;

			for (int i = 0; i < input.Length; i++)
			{
				if (Char.IsDigit(input[i]) || (input[i] == '-' && uno))
				{
					string a = string.Empty;

					a += input[i++];
					while (i < input.Length)
					{
						if (a[a.Length - 1] != 'E' && IsOperator(input[i]))
							break;
						a += input[i++];
					}
					operands.Push(double.Parse(a));

					i--;
					uno = false;
				}
				else if (IsOperator(input[i]))
				{
					if (input[i] == '(')
					{
						operators.Push(input[i]);

						uno = true;
					}
					else if (input[i] == ')')
					{
						while (operators.Peek() != '(')
							operands.Push(Count(operands.Pop(), operands.Pop(), operators.Pop()));
						operators.Pop();

						uno = false;
					}
					else
					{
						while (operators.Count > 0 && GetPriority(input[i]) <= GetPriority(operators.Peek()))
							operands.Push(Count(operands.Pop(), operands.Pop(), operators.Pop()));
						operators.Push(input[i]);

						uno = true;
					}
				}
				else throw new FormatException();
			}
			while (operators.Count > 0)
				operands.Push(Count(operands.Pop(), operands.Pop(), operators.Pop()));

			return operands.Peek();
		}
	}
}

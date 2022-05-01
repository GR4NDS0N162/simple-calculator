using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SimpleCalculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		#region Флаги
		bool isResult = false;
		bool isTempResult = false;
		bool exeptionIsCaused = false;
		#endregion

		#region Константы
		const int MAX_LENGTH = 21;
		#endregion

		#region Вспомогательные функции
		private bool IsEmpty(string s)
		{
			return s.Length == 0;
		}
		private bool IsSign(char c)
		{
			return c == '+' || c == '-' || c == '*' || c == '/' || c == '^';
		}
		private void Normailze(ref string input)
		{
			int LBracket = input.ToCharArray().Where(c => c == '(').Count();
			int RBracket = input.ToCharArray().Where(c => c == ')').Count();
			int count = LBracket - RBracket;

			for (int i = 0; i < count; i++)
			{
				input += ")";
			}
		}
		private void SignClick_Action(char sign)
		{
			if (SummaryExpression.Text == ""
				|| IsSign(SummaryExpression.Text.Last())
				|| SummaryExpression.Text.Last() == '(')
			{
				SummaryExpression.Text += $"{MainExpression.Text}{sign}";
			}
			else if (SummaryExpression.Text.Last() == '=')
			{
				SummaryExpression.Text = $"{MainExpression.Text}{sign}";
			}
			else if (SummaryExpression.Text.Last() == ')')
			{
				SummaryExpression.Text += $"{sign}";
			}
			else if (SummaryExpression.Text.Last() != sign
				&& SummaryExpression.Text.Last() != '=')
			{
				SummaryExpression.Text = $"{SummaryExpression.Text.Substring(0, SummaryExpression.Text.Length - 1)}{sign}";
			}

			isTempResult = true;
			FormatInput(false);
		}
		private void DigitClick_Action(int digit)
		{
			if (isResult)
			{
				SummaryExpression.Text = "";
				MainExpression.Text = "0";
				isResult = false;
			}
			else if (isTempResult)
			{
				isTempResult = false;
				MainExpression.Text = "0";
			}

			if (digit == 0)
			{
				if (MainExpression.Text != "0")
					MainExpression.Text += '0';
			}
			else
			{
				if (MainExpression.Text == "0")
					MainExpression.Text = "";
				MainExpression.Text += digit.ToString();
			}
		}
		private void FormatInput(bool setResult)
		{
			isResult = setResult;

			string input;
			int pos = SummaryExpression.Text.LastIndexOf('(');

			if (pos == -1 || isResult)
				input = SummaryExpression.Text;
			else
				input = SummaryExpression.Text.Substring(pos);

			if (IsSign(input.Last()) || input.Last() == '=')
				input = input.Substring(0, input.Length - 1);

			Normailze(ref input);

			if (isResult)
				SummaryExpression.Text = $"{input}=";

			CalculateInput(input);

		}
		private void CalculateBrackets()
		{
			string input = string.Join(string.Empty, SummaryExpression.Text.Reverse().ToArray());
			int count = 0, i = 0, pos = 0;

			for (; i < input.Length && count >= 0; i++)
			{
				if (input[i] == ')')
					count++;
				else if (input[i] == '(')
				{
					count--;
					if (count >= 0)
						pos = i;
				}
			}
			input = SummaryExpression.Text.Substring(SummaryExpression.Text.Length - 1 - pos);

			CalculateInput(input);
		}
		private void CalculateInput(string input)
		{
			try
			{
				double result = Calculator.Calculate(input);
				MainExpression.Text = result.ToString();
			}
			catch (DivideByZeroException)
			{
				HandleExeption("ДЕЛЕНИЕ НА НОЛЬ");
			}
			catch (Exception ex) when (ex is FormatException || ex is NotFiniteNumberException)
			{
				HandleExeption("НЕВЕРНЫЙ ВВОД");
			}
		}
		private void HandleExeption(string msg)
		{
			exeptionIsCaused = true;
			MainExpression.Text = msg;
			foreach (Control ctrl in Controls)
				if (!ctrl.Equals(ClearAllButton))
					ctrl.Enabled = false;
		}
		#endregion

		#region Действия, выполняемые при нажатии кнопки
		private void ZeroButton_Action()
		{
			DigitClick_Action(0);
		}
		private void OneButton_Action()
		{
			DigitClick_Action(1);
		}
		private void TwoButton_Action()
		{
			DigitClick_Action(2);
		}
		private void ThreeButton_Action()
		{
			DigitClick_Action(3);
		}
		private void FourButton_Action()
		{
			DigitClick_Action(4);
		}
		private void FiveButton_Action()
		{
			DigitClick_Action(5);
		}
		private void SixButton_Action()
		{
			DigitClick_Action(6);
		}
		private void SevenButton_Action()
		{
			DigitClick_Action(7);
		}
		private void EightButton_Action()
		{
			DigitClick_Action(8);
		}
		private void NineButton_Action()
		{
			DigitClick_Action(9);
		}
		private void MainExpression_TextChanged_Action()
		{
			if (MainExpression.Text.Length > MAX_LENGTH)
			{
				if (MainExpression.Text[0] == '-')
					MainExpression.Text = MainExpression.Text.Substring(0, MAX_LENGTH + 1);
				else
					MainExpression.Text = MainExpression.Text.Substring(0, MAX_LENGTH);
			}
		}
		private void SummaryExpression_TextChanged_Action()
		{
			int LBracket = SummaryExpression.Text.ToCharArray().Where(c => c == '(').Count();
			int RBracket = SummaryExpression.Text.ToCharArray().Where(c => c == ')').Count();
			int Count = LBracket - RBracket;
			if (Count > 0)
			{
				CountBracket.Text = Count.ToString();
			}
			else
			{
				CountBracket.Text = "";
			}
		}
		private void PlusMinusButton_Action()
		{
			if (MainExpression.Text != "0")
			{
				if (MainExpression.Text[0] == '-')
					MainExpression.Text = MainExpression.Text.Substring(1);
				else
					MainExpression.Text = "-" + MainExpression.Text;
			}
		}
		private void CommaButton_Action()
		{
			if (!MainExpression.Text.Contains(",")
				&& MainExpression.Text.Length <= MAX_LENGTH - 1)
			{
				MainExpression.Text += ",";
			}
		}
		private void BkspButton_Action()
		{
			if (MainExpression.Text.Length <= 1)
				MainExpression.Text = "0";
			else
				MainExpression.Text = MainExpression.Text.Substring(0, MainExpression.Text.Length - 1);
		}
		private void ClearButton_Action()
		{
			if (!IsEmpty(SummaryExpression.Text) && SummaryExpression.Text.Last() == '=')
				ClearAllButton_Action();
			else
				MainExpression.Text = "0";
		}
		private void ClearAllButton_Action()
		{
			SummaryExpression.Text = "";
			MainExpression.Text = "0";

			if (exeptionIsCaused)
				foreach (Control ctrl in Controls)
					ctrl.Enabled = true;
			exeptionIsCaused = false;
		}
		private void LBracketButton_Action()
		{
			int LBracket = SummaryExpression.Text.ToCharArray().Where(c => c == '(').Count();
			int RBracket = SummaryExpression.Text.ToCharArray().Where(c => c == ')').Count();
			if (LBracket - RBracket < 25
				&& (SummaryExpression.Text.Length == 0
				|| SummaryExpression.Text.Last() != ')'))
			{
				SummaryExpression.Text += "(";
				MainExpression.Text = "0";
			}
		}
		private void RBracketButton_Action()
		{
			int LBracket = SummaryExpression.Text.ToCharArray().Where(c => c == '(').Count();
			int RBracket = SummaryExpression.Text.ToCharArray().Where(c => c == ')').Count();
			if (LBracket - RBracket > 0)
			{
				if (IsSign(SummaryExpression.Text.Last()) || SummaryExpression.Text.Last() == '(')
				{
					SummaryExpression.Text += $"{MainExpression.Text})";
				}
				else if (SummaryExpression.Text.Last() == ')')
				{
					SummaryExpression.Text += ")";
				}

				CalculateBrackets();
			}
		}
		private void InverseButton_Action()
		{
			if (IsEmpty(SummaryExpression.Text)
				|| IsSign(SummaryExpression.Text.Last())
				|| SummaryExpression.Text.Last() == '(')
			{
				SummaryExpression.Text += $"(1/{MainExpression.Text})";
				CalculateBrackets();
			}
		}
		private void PowButton_Action()
		{
			SignClick_Action('^');
		}
		private void PlusButton_Action()
		{
			SignClick_Action('+');
		}
		private void MinusButton_Action()
		{
			SignClick_Action('-');
		}
		private void MultiplyButton_Action()
		{
			SignClick_Action('*');
		}
		private void DevisionButton_Action()
		{
			SignClick_Action('/');
		}
		private void EqualButton_Action()
		{
			if (SummaryExpression.Text == ""
				|| IsSign(SummaryExpression.Text.Last())
				|| SummaryExpression.Text.Last() == '(')
			{
				SummaryExpression.Text += $"{MainExpression.Text}=";
			}
			else if (SummaryExpression.Text.Last() == ')')
			{
				SummaryExpression.Text += "=";
			}

			FormatInput(true);
		}
		#endregion

		#region Обработчики нажатия мышкой по цифре
		private void ZeroButton_MouseClick(object sender, MouseEventArgs e)
		{
			ZeroButton_Action();
		}

		private void OneButton_MouseClick(object sender, MouseEventArgs e)
		{
			OneButton_Action();
		}

		private void TwoButton_MouseClick(object sender, MouseEventArgs e)
		{
			TwoButton_Action();
		}

		private void ThreeButton_MouseClick(object sender, MouseEventArgs e)
		{
			ThreeButton_Action();
		}

		private void FourButton_MouseClick(object sender, MouseEventArgs e)
		{
			FourButton_Action();
		}

		private void FiveButton_MouseClick(object sender, MouseEventArgs e)
		{
			FiveButton_Action();
		}

		private void SixButton_MouseClick(object sender, MouseEventArgs e)
		{
			SixButton_Action();
		}

		private void SevenButton_MouseClick(object sender, MouseEventArgs e)
		{
			SevenButton_Action();
		}

		private void EightButton_MouseClick(object sender, MouseEventArgs e)
		{
			EightButton_Action();
		}

		private void NineButton_MouseClick(object sender, MouseEventArgs e)
		{
			NineButton_Action();
		}
		#endregion

		#region Обработчики изменений в выражениях
		private void MainExpression_TextChanged(object sender, EventArgs e)
		{
			MainExpression_TextChanged_Action();
		}
		private void SummaryExpression_TextChanged(object sender, EventArgs e)
		{
			SummaryExpression_TextChanged_Action();
		}
		#endregion

		#region Обработчики нажатия мышки по математическим действиям
		private void PlusMinusButton_MouseClick(object sender, MouseEventArgs e)
		{
			PlusMinusButton_Action();
		}

		private void CommaButton_MouseClick(object sender, MouseEventArgs e)
		{
			CommaButton_Action();
		}

		private void EqualButton_MouseClick(object sender, MouseEventArgs e)
		{
			EqualButton_Action();
		}

		private void PlusButton_MouseClick(object sender, MouseEventArgs e)
		{
			PlusButton_Action();
		}

		private void MinusButton_MouseClick(object sender, MouseEventArgs e)
		{
			MinusButton_Action();
		}

		private void MultiplyButton_MouseClick(object sender, MouseEventArgs e)
		{
			MultiplyButton_Action();
		}

		private void DevisionButton_MouseClick(object sender, MouseEventArgs e)
		{
			DevisionButton_Action();
		}

		private void InverseButton_MouseClick(object sender, MouseEventArgs e)
		{
			InverseButton_Action();
		}

		private void PowButton_MouseClick(object sender, MouseEventArgs e)
		{
			PowButton_Action();
		}

		private void LBracketButton_MouseClick(object sender, MouseEventArgs e)
		{
			LBracketButton_Action();
		}

		private void RBracketButton_MouseClick(object sender, MouseEventArgs e)
		{
			RBracketButton_Action();
		}
		#endregion

		#region Обработчики нажатия мышки по кнопкам редактирования
		private void BkspButton_MouseClick(object sender, MouseEventArgs e)
		{
			BkspButton_Action();
		}

		private void ClearButton_MouseClick(object sender, MouseEventArgs e)
		{
			ClearButton_Action();
		}

		private void ClearAllButton_MouseClick(object sender, MouseEventArgs e)
		{
			ClearAllButton_Action();
		}
		#endregion

		#region Обработчики нажатия клавиши на клавиатуре
		private void Any_KeyDown(object sender, KeyEventArgs e)
		{
			if (exeptionIsCaused)
			{
				if (e.KeyCode == Keys.Escape)
					ClearAllButton_Action();
				return;
			}
			switch (e.KeyCode)
			{
				#region Цифры
				case Keys.D0:
					if (ModifierKeys == Keys.Shift)
						RBracketButton_Action();
					else
						ZeroButton_Action();
					break;

				case Keys.NumPad0:
					ZeroButton_Action();
					break;

				case Keys.D1:
				case Keys.NumPad1:
					OneButton_Action();
					break;

				case Keys.D2:
				case Keys.NumPad2:
					TwoButton_Action();
					break;

				case Keys.D3:
				case Keys.NumPad3:
					ThreeButton_Action();
					break;

				case Keys.D4:
				case Keys.NumPad4:
					FourButton_Action();
					break;

				case Keys.D5:
				case Keys.NumPad5:
					FiveButton_Action();
					break;

				case Keys.D6:
				case Keys.NumPad6:
					SixButton_Action();
					break;

				case Keys.D7:
				case Keys.NumPad7:
					SevenButton_Action();
					break;

				case Keys.D8:
					if (ModifierKeys == Keys.Shift)
						MultiplyButton_Action();
					else
						EightButton_Action();
					break;

				case Keys.NumPad8:
					EightButton_Action();
					break;

				case Keys.D9:
					if (ModifierKeys == Keys.Shift)
						LBracketButton_Action();
					else
						NineButton_Action();
					break;

				case Keys.NumPad9:
					NineButton_Action();
					break;
				#endregion

				case Keys.Multiply:
					MultiplyButton_Action();
					break;

				case Keys.Oemplus:
					if (ModifierKeys == Keys.Shift)
						PlusButton_Action();
					else
						EqualButton_Action();
					break;

				case Keys.Add:
					PlusButton_Action();
					break;

				case Keys.Oemcomma:
				case Keys.OemPeriod:
				case Keys.Separator:
				case Keys.Decimal:
					CommaButton_Action();
					break;

				case Keys.OemMinus:
				case Keys.Subtract:
					MinusButton_Action();
					break;

				case Keys.OemQuestion:
				case Keys.Divide:
					DevisionButton_Action();
					break;

				case Keys.I:
					InverseButton_Action();
					break;

				case Keys.O:
					PlusMinusButton_Action();
					break;

				case Keys.P:
					PowButton_Action();
					break;

				case Keys.OemOpenBrackets:
					LBracketButton_Action();
					break;

				case Keys.OemCloseBrackets:
					RBracketButton_Action();
					break;

				case Keys.Back:
					BkspButton_Action();
					break;

				case Keys.Delete:
					ClearButton_Action();
					break;

				case Keys.Escape:
					ClearAllButton_Action();
					break;

				case Keys.Enter:
					EqualButton_Action();
					break;

				default:
					break;
			}
		}
		#endregion
	}
}

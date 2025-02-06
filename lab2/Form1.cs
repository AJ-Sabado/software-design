namespace lab2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public int RecursiveFactorial(int n)
		{
			if (n == 0) return 1;
			return n * RecursiveFactorial(n - 1);
		}

		public int RecursiveSum(int[] numbers, int n)
		{
			if (n == 0) return numbers[0];
			return numbers[n] + RecursiveSum(numbers, n - 1);
		}

		public int RecursiveFibonacci(int n)
		{
			if (n < 1) return 0;
			if (n == 1) return 1;
			return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
		}

		public int RecursivePower(int x, int n)
		{
			if (n == 1) return x;
			return x * RecursivePower(x, n - 1);
		}


		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void buttonCalculateFactorial_Click(object sender, EventArgs e)
		{
			int number = int.Parse(textBoxInputN.Text);
			int result = RecursiveFactorial(number);
			labelResult.Text = $"Factorial: {result}";
		}

		private void buttonCalculateSum_Click(object sender, EventArgs e)
		{
			int[] numbers = textBoxArrayInput.Text.Split(',').Select(int.Parse).ToArray();
			int result = RecursiveSum(numbers, numbers.Length - 1);
			labelSumResult.Text = $"Sum: {result}";
		}

		private void buttonFibonacci_Click(object sender, EventArgs e)
		{
			int n = int.Parse(textBoxFibonacci.Text);
			int result = RecursiveFibonacci(n);
			labelFibonacci.Text = $"Fibonacci: {result}";
		}

		private void buttonCalculatePower_Click(object sender, EventArgs e)
		{
			int[] input = textBoxPower.Text.Split('^').Select(int.Parse).ToArray();
			int result = RecursivePower(input[0], input[1]);
			labelPower.Text = $"{input[0]} raised to the power of {input[1]}: {result}"; 
		}
	}
}

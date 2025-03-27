namespace Task4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int[] ProceduralSort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            var algo = new MyAlgorithm();
            int[] numbers = { 3, 1, 5, 2, 4 };
            int[] sortedNumbers = algo.OOPSort(numbers);
            listBoxResults.DataSource = sortedNumbers;
        }
    }

    class MyAlgorithm
    {
        public int[] OOPSort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }
    }
}

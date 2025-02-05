namespace Task5
{
    public partial class Form1 : Form
    {
        private int[] numbers = { 3, 1, 5, 2, 4 };
        private void SetListBox(int[] numbers)
        {
            listBoxResults.DataSource = null;
            listBoxResults.DataSource = numbers;
        }
        private void ProceduralBubbleSort(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; ++i)
            {
                bool sorted = true;
                for (int j = i + 1; j < numbers.Length; ++j)
                {
                    if (numbers[i] > numbers[j])
                    {
                        sorted = false;
                        (numbers[j], numbers[i]) = (numbers[i], numbers[j]);
                    }
                }
                if (sorted)
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetListBox(numbers);
        }
        private void buttonBubbleSort_Click(object sender, EventArgs e)
        {
            //Procedural Sort
            ProceduralBubbleSort(numbers);
            SetListBox(numbers);
        }

        private void buttonDescendingOrder_Click(object sender, EventArgs e)
        {
            //OOP Sort
            var myAlgorithm = new MyAlgorithm();
            myAlgorithm.DescendingOrder(numbers);
            SetListBox(numbers);
        }
    }
    class MyAlgorithm
    {
        public void DescendingOrder(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; ++i)
            {
                bool sorted = true;
                for (int j = i + 1; j < numbers.Length; ++j)
                {
                    if (numbers[i] < numbers[j])
                    {
                        sorted = false;
                        (numbers[j], numbers[i]) = (numbers[i], numbers[j]);
                    }
                }
                if (sorted)
                    break;
            }
        }
    }
}

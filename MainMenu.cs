using System;
using System.Windows.Forms;

namespace KnightsTour
{
    public partial class MainMenu : Form
    {
        private static int rowStart, colStart;
        FileOutput fo;
        Calculate calc = new Calculate();
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            int num = 1, method = 0, run = 2;
            try { 
            if (!String.IsNullOrEmpty(runs.Text))
                run = Convert.ToInt32(runs.Text) + 1;
            if(run < 2)
                {
                    run = 2;
                    MessageBox.Show("Value of runs should be more than a zero. Program will run once");
                }

            } catch (FormatException)
            {
                MessageBox.Show("Program will run once, value of runs should be numeric");
            }


            if (nonIntel.Checked) { 
                method = 1;
                fo = new NonIntel();
            }
            else if (heuristics.Checked)
            {
                method = 2;
                fo = new Heuristic();
            }
            
            fo.CreateFile();

            while (num != run)
            {
                try
                {
                    if (!String.IsNullOrEmpty(col.Text))
                        colStart = Convert.ToInt32(col.Text) - 1;
                    if (!String.IsNullOrEmpty(row.Text))
                        rowStart = Convert.ToInt32(row.Text) - 1;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Row and Column should be numeric. Values assigned to 0s.");
                }

                if (String.IsNullOrEmpty(col.Text) || colStart < 0 || String.IsNullOrEmpty(row.Text) || rowStart < 0 
                    || rowStart > 7 || colStart > 7)
                {
                    MessageBox.Show("Valid numbers for Row & Column from 1 to 8. Values assigned to 0s");
                    colStart = 0;
                    rowStart = 0;

                }

                Tour tour = new Tour(colStart, rowStart, method);
                
                calc.Run= num;
                calc.StepSum = tour.Steps;
                calc.TotalRuns = run;
                calc.CurrentSteps = tour.Steps;

                Board board = new Board();

                MessageBox.Show(board.PrintBoard(calc.CurrentSteps, calc.getAverage(), calc.getDeviation()),
                    String.Format("Knight's Tour #{0}", num));
                board.CleanBoard();

                fo.Record(calc.getTourDetails());
                fo.WriteToFile();
                num++;
            }

            if (run > 1)
            {
                fo.Record(String.Format("\nAverage of steps: {0}", calc.getAverage()));
                fo.Record(String.Format("\nStandard deviation: {0}", calc.getDeviation()));
                fo.WriteToFile();
            }

            calc.ResetTour();

        }

    }
}

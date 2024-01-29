using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using Host;

namespace AIS_LAB_WCF
{
    public partial class Form1 : Form
    {
        CarCostCalculator calculatorInstance = new CarCostCalculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mark = MarkComboBox.SelectedIndex;
            int year = YearComboBox.SelectedIndex;
            int engine = EngineComboBox.SelectedIndex;
            int color = ColorComboBox.SelectedIndex;
            int complect = ComplectationComboBox.SelectedIndex;

            double cost=calculatorInstance.GetCarCost(mark,year,engine,color,complect);

            MessageBox.Show($"Такой автомобиль будет стоить примерно {cost}$");
        }
    }
}

//Chris Brown
//Program1 Paint Calculator
//10/01/14
//CIS 199-01
//finds total price along with outcomes of different variables of a paint operation
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Program1PaintCalculator : Form
    {
        public Program1PaintCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2CoatsDesired_TextChanged(object sender, EventArgs e)
        {


        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double HoursofLaborPerGallon = 8; //hours of labor per gallon on 325 square feet
            double PriceofLabor = 10.50; //Price of Labor equals 10.50
            double SquareFeetperGallon = 325; //A gallon covers 325 square feet
            float sqrft = float.Parse(textBox1SquareFeet.Text);//turns text into #
            int CoatsofPaint = int.Parse(textBox2CoatsDesired.Text);//turns text into #
            float PriceperGallon = float.Parse(textBox3PricePerGallon.Text);// turns text into #
            float TotSqrft = (sqrft * (float)CoatsofPaint);//square feet  times coats
            double GallonsofPaint = Math.Ceiling(TotSqrft / SquareFeetperGallon);//total square feet divided by square feet per gallon
            float CostofPaint = (PriceperGallon * (float)GallonsofPaint);//price of a gallon times amount of gallons
            double HoursWorked = (((double)TotSqrft / SquareFeetperGallon) * HoursofLaborPerGallon);//total square feet / square feet per gallon
            double CostofLabor = (HoursWorked * PriceofLabor);//Hours worked times labor price

            labelOutputTotalSqrFtNeeded.Text = (TotSqrft).ToString("0.#");//square feet * coats of paint to nearest one decimal
            labelOutputGallonsNeeded.Text = (GallonsofPaint).ToString();//rounds to nearest whole number 
            labelOutputHoursOfLabor.Text = (HoursWorked).ToString("0.#");//calculated by total square feet / original square feet per gallon
            labelOutputCostOfPaint.Text = (CostofPaint).ToString("C");// calculates cost of paint by price * number of gallons of paint
            labelOutputCostOfLabor.Text = (CostofLabor).ToString("C");//uses full number of labor hours * hours worked
            labelOutputTotal.Text = (CostofLabor + CostofPaint).ToString("C");//adds both costs and finds total
        }
    }
}

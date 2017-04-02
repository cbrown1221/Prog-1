namespace Program_1
{
    partial class Program1PaintCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1SquareFeet = new System.Windows.Forms.Label();
            this.label2CoatsDesired = new System.Windows.Forms.Label();
            this.label3PriceofGallon = new System.Windows.Forms.Label();
            this.textBox1SquareFeet = new System.Windows.Forms.TextBox();
            this.textBox2CoatsDesired = new System.Windows.Forms.TextBox();
            this.textBox3PricePerGallon = new System.Windows.Forms.TextBox();
            this.label1GallonsofPaintRequired = new System.Windows.Forms.Label();
            this.label2HoursofLaborRequired = new System.Windows.Forms.Label();
            this.label3TotalSquareFeetPainted = new System.Windows.Forms.Label();
            this.labelOutputGallonsNeeded = new System.Windows.Forms.Label();
            this.labelOutputHoursOfLabor = new System.Windows.Forms.Label();
            this.labelOutputTotalSqrFtNeeded = new System.Windows.Forms.Label();
            this.label1CostOfPaint = new System.Windows.Forms.Label();
            this.label2CostOfLabor = new System.Windows.Forms.Label();
            this.label3TotalCost = new System.Windows.Forms.Label();
            this.labelOutputCostOfPaint = new System.Windows.Forms.Label();
            this.labelOutputCostOfLabor = new System.Windows.Forms.Label();
            this.labelOutputTotal = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1SquareFeet
            // 
            this.label1SquareFeet.AutoSize = true;
            this.label1SquareFeet.Location = new System.Drawing.Point(28, 34);
            this.label1SquareFeet.Name = "label1SquareFeet";
            this.label1SquareFeet.Size = new System.Drawing.Size(104, 13);
            this.label1SquareFeet.TabIndex = 0;
            this.label1SquareFeet.Text = "Square Feet Painted";
            // 
            // label2CoatsDesired
            // 
            this.label2CoatsDesired.AutoSize = true;
            this.label2CoatsDesired.Location = new System.Drawing.Point(28, 100);
            this.label2CoatsDesired.Name = "label2CoatsDesired";
            this.label2CoatsDesired.Size = new System.Drawing.Size(114, 13);
            this.label2CoatsDesired.TabIndex = 1;
            this.label2CoatsDesired.Text = "Coats Of Paint Desired";
            // 
            // label3PriceofGallon
            // 
            this.label3PriceofGallon.AutoSize = true;
            this.label3PriceofGallon.Location = new System.Drawing.Point(28, 170);
            this.label3PriceofGallon.Name = "label3PriceofGallon";
            this.label3PriceofGallon.Size = new System.Drawing.Size(83, 13);
            this.label3PriceofGallon.TabIndex = 2;
            this.label3PriceofGallon.Text = "Price Per Gallon";
            // 
            // textBox1SquareFeet
            // 
            this.textBox1SquareFeet.Location = new System.Drawing.Point(239, 34);
            this.textBox1SquareFeet.Name = "textBox1SquareFeet";
            this.textBox1SquareFeet.Size = new System.Drawing.Size(100, 20);
            this.textBox1SquareFeet.TabIndex = 3;
            // 
            // textBox2CoatsDesired
            // 
            this.textBox2CoatsDesired.Location = new System.Drawing.Point(239, 100);
            this.textBox2CoatsDesired.Name = "textBox2CoatsDesired";
            this.textBox2CoatsDesired.Size = new System.Drawing.Size(100, 20);
            this.textBox2CoatsDesired.TabIndex = 4;
            this.textBox2CoatsDesired.TextChanged += new System.EventHandler(this.textBox2CoatsDesired_TextChanged);
            // 
            // textBox3PricePerGallon
            // 
            this.textBox3PricePerGallon.Location = new System.Drawing.Point(239, 170);
            this.textBox3PricePerGallon.Name = "textBox3PricePerGallon";
            this.textBox3PricePerGallon.Size = new System.Drawing.Size(100, 20);
            this.textBox3PricePerGallon.TabIndex = 5;
            // 
            // label1GallonsofPaintRequired
            // 
            this.label1GallonsofPaintRequired.AutoSize = true;
            this.label1GallonsofPaintRequired.Location = new System.Drawing.Point(31, 276);
            this.label1GallonsofPaintRequired.Name = "label1GallonsofPaintRequired";
            this.label1GallonsofPaintRequired.Size = new System.Drawing.Size(122, 13);
            this.label1GallonsofPaintRequired.TabIndex = 6;
            this.label1GallonsofPaintRequired.Text = "Gallons of Paint Needed";
            // 
            // label2HoursofLaborRequired
            // 
            this.label2HoursofLaborRequired.AutoSize = true;
            this.label2HoursofLaborRequired.Location = new System.Drawing.Point(34, 348);
            this.label2HoursofLaborRequired.Name = "label2HoursofLaborRequired";
            this.label2HoursofLaborRequired.Size = new System.Drawing.Size(123, 13);
            this.label2HoursofLaborRequired.TabIndex = 7;
            this.label2HoursofLaborRequired.Text = "Hours of Labor Required";
            // 
            // label3TotalSquareFeetPainted
            // 
            this.label3TotalSquareFeetPainted.AutoSize = true;
            this.label3TotalSquareFeetPainted.Location = new System.Drawing.Point(37, 420);
            this.label3TotalSquareFeetPainted.Name = "label3TotalSquareFeetPainted";
            this.label3TotalSquareFeetPainted.Size = new System.Drawing.Size(158, 13);
            this.label3TotalSquareFeetPainted.TabIndex = 8;
            this.label3TotalSquareFeetPainted.Text = "Total Square Feet to be Painted";
            // 
            // labelOutputGallonsNeeded
            // 
            this.labelOutputGallonsNeeded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutputGallonsNeeded.Location = new System.Drawing.Point(239, 275);
            this.labelOutputGallonsNeeded.Name = "labelOutputGallonsNeeded";
            this.labelOutputGallonsNeeded.Size = new System.Drawing.Size(100, 23);
            this.labelOutputGallonsNeeded.TabIndex = 9;
            // 
            // labelOutputHoursOfLabor
            // 
            this.labelOutputHoursOfLabor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutputHoursOfLabor.Location = new System.Drawing.Point(242, 347);
            this.labelOutputHoursOfLabor.Name = "labelOutputHoursOfLabor";
            this.labelOutputHoursOfLabor.Size = new System.Drawing.Size(100, 23);
            this.labelOutputHoursOfLabor.TabIndex = 10;
            // 
            // labelOutputTotalSqrFtNeeded
            // 
            this.labelOutputTotalSqrFtNeeded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutputTotalSqrFtNeeded.Location = new System.Drawing.Point(242, 419);
            this.labelOutputTotalSqrFtNeeded.Name = "labelOutputTotalSqrFtNeeded";
            this.labelOutputTotalSqrFtNeeded.Size = new System.Drawing.Size(100, 23);
            this.labelOutputTotalSqrFtNeeded.TabIndex = 11;
            // 
            // label1CostOfPaint
            // 
            this.label1CostOfPaint.AutoSize = true;
            this.label1CostOfPaint.Location = new System.Drawing.Point(433, 176);
            this.label1CostOfPaint.Name = "label1CostOfPaint";
            this.label1CostOfPaint.Size = new System.Drawing.Size(69, 13);
            this.label1CostOfPaint.TabIndex = 12;
            this.label1CostOfPaint.Text = "Cost Of Paint";
            // 
            // label2CostOfLabor
            // 
            this.label2CostOfLabor.AutoSize = true;
            this.label2CostOfLabor.Location = new System.Drawing.Point(433, 248);
            this.label2CostOfLabor.Name = "label2CostOfLabor";
            this.label2CostOfLabor.Size = new System.Drawing.Size(72, 13);
            this.label2CostOfLabor.TabIndex = 13;
            this.label2CostOfLabor.Text = "Cost Of Labor";
            // 
            // label3TotalCost
            // 
            this.label3TotalCost.AutoSize = true;
            this.label3TotalCost.Location = new System.Drawing.Point(433, 325);
            this.label3TotalCost.Name = "label3TotalCost";
            this.label3TotalCost.Size = new System.Drawing.Size(55, 13);
            this.label3TotalCost.TabIndex = 14;
            this.label3TotalCost.Text = "Total Cost";
            // 
            // labelOutputCostOfPaint
            // 
            this.labelOutputCostOfPaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutputCostOfPaint.Location = new System.Drawing.Point(582, 176);
            this.labelOutputCostOfPaint.Name = "labelOutputCostOfPaint";
            this.labelOutputCostOfPaint.Size = new System.Drawing.Size(100, 23);
            this.labelOutputCostOfPaint.TabIndex = 15;
            // 
            // labelOutputCostOfLabor
            // 
            this.labelOutputCostOfLabor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutputCostOfLabor.Location = new System.Drawing.Point(585, 248);
            this.labelOutputCostOfLabor.Name = "labelOutputCostOfLabor";
            this.labelOutputCostOfLabor.Size = new System.Drawing.Size(100, 23);
            this.labelOutputCostOfLabor.TabIndex = 16;
            // 
            // labelOutputTotal
            // 
            this.labelOutputTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutputTotal.Location = new System.Drawing.Point(585, 325);
            this.labelOutputTotal.Name = "labelOutputTotal";
            this.labelOutputTotal.Size = new System.Drawing.Size(100, 23);
            this.labelOutputTotal.TabIndex = 17;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(569, 402);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(116, 49);
            this.buttonCalculate.TabIndex = 18;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Program1PaintCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 507);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelOutputTotal);
            this.Controls.Add(this.labelOutputCostOfLabor);
            this.Controls.Add(this.labelOutputCostOfPaint);
            this.Controls.Add(this.label3TotalCost);
            this.Controls.Add(this.label2CostOfLabor);
            this.Controls.Add(this.label1CostOfPaint);
            this.Controls.Add(this.labelOutputTotalSqrFtNeeded);
            this.Controls.Add(this.labelOutputHoursOfLabor);
            this.Controls.Add(this.labelOutputGallonsNeeded);
            this.Controls.Add(this.label3TotalSquareFeetPainted);
            this.Controls.Add(this.label2HoursofLaborRequired);
            this.Controls.Add(this.label1GallonsofPaintRequired);
            this.Controls.Add(this.textBox3PricePerGallon);
            this.Controls.Add(this.textBox2CoatsDesired);
            this.Controls.Add(this.textBox1SquareFeet);
            this.Controls.Add(this.label3PriceofGallon);
            this.Controls.Add(this.label2CoatsDesired);
            this.Controls.Add(this.label1SquareFeet);
            this.Name = "Program1PaintCalculator";
            this.Text = "Paint Operation Configuration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1SquareFeet;
        private System.Windows.Forms.Label label2CoatsDesired;
        private System.Windows.Forms.Label label3PriceofGallon;
        private System.Windows.Forms.TextBox textBox1SquareFeet;
        private System.Windows.Forms.TextBox textBox2CoatsDesired;
        private System.Windows.Forms.TextBox textBox3PricePerGallon;
        private System.Windows.Forms.Label label1GallonsofPaintRequired;
        private System.Windows.Forms.Label label2HoursofLaborRequired;
        private System.Windows.Forms.Label label3TotalSquareFeetPainted;
        private System.Windows.Forms.Label labelOutputGallonsNeeded;
        private System.Windows.Forms.Label labelOutputHoursOfLabor;
        private System.Windows.Forms.Label labelOutputTotalSqrFtNeeded;
        private System.Windows.Forms.Label label1CostOfPaint;
        private System.Windows.Forms.Label label2CostOfLabor;
        private System.Windows.Forms.Label label3TotalCost;
        private System.Windows.Forms.Label labelOutputCostOfPaint;
        private System.Windows.Forms.Label labelOutputCostOfLabor;
        private System.Windows.Forms.Label labelOutputTotal;
        private System.Windows.Forms.Button buttonCalculate;
    }
}


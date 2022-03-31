using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//   Program:   Employee and Production Worker
// Developer:   Timmy Bell  
//      Date:   04/18/2021
//   Purpose:   This program will create and store information
//              about new employees within the Employee and 
//              Worker classes and return the information in
//              the proper output labels.
namespace Worker_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetWorkerData(ProductionWorker newWorker)
        {
            // fields
            int empNum;
            int shiftNum;
            decimal wage;

            // Check if textbox is empty
            if (employeeNameTextBox.Text != "") // Check if textbox is empty
            {   // Set employeeName
                newWorker.employeeName = employeeNameTextBox.Text;
            }

            //Display error message
            else
            {
                MessageBox.Show("Please enter Employee Name");
            }

            // Check if textbox is empty
            if (int.TryParse(employeeNumberTextBox.Text, out empNum))
            {   // Set empNum
                newWorker.employeeNumber = empNum;
            }

            //Display error message
            else
            {  
                MessageBox.Show("Invalid Employee Number");
            }

            // Check if textbox is empty
            if (int.TryParse(shiftTextBox.Text, out shiftNum))
            {   // Set shiftNum
                newWorker.shiftNumber = shiftNum;
            }

            //Display error message
            else
            {  
                MessageBox.Show("Invalid Shift Number");
            }

            // Check if textbox is empty
            if (decimal.TryParse(hourlyWageTextBox.Text, out wage))
            {   // Set wage
                newWorker.hourlyWage = wage;
            }

            //Display error message
            else
            {   //Display error message
                MessageBox.Show("Invalid Hourly Wage");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {   //Closes the Form
            this.Close();
        }   // End of close

        private void clearButton_Click(object sender, EventArgs e)
        {   // Clears the Form and sets focus to emmployeeNumberTextBox
            employeeNumberTextBox.Text = "";
            employeeNameTextBox.Text = "";
            shiftTextBox.Text = "";
            hourlyWageTextBox.Text = "";
            employeeNumberLabel.Text = "";
            employeeNameLabel.Text = "";
            shiftNumberLabel.Text = "";
            hourlyWageLabel.Text = "";
            employeeNumberTextBox.Focus();
        } //end of Clear

        private void createButton_Click(object sender, EventArgs e)
        {   // Creates new ProductionWorker. Populates fields and 
            // displays information in labels
            ProductionWorker Worker = new ProductionWorker();
            SetWorkerData(Worker);
            employeeNumberLabel.Text = Worker.employeeNumber.ToString();
            employeeNameLabel.Text = Worker.employeeName;
            shiftNumberLabel.Text = Worker.shiftNumber.ToString();
            hourlyWageLabel.Text = Worker.hourlyWage.ToString();
        }// End of Create
    }
}

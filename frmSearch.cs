using System;
using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace DraftCarHireApp
{
    public partial class frmSearch : Form
    {
        frmCars callingForm;
        DataView carsTableView;
        public frmSearch(frmCars parent, DataSet carsDataset)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frmSearch_Load);

            callingForm = parent;
            //callingForm.Hide();
            carsTableView = new DataView(carsDataset.Tables["EVMotors"]);
            //this.dataGridView1.Rows.Add("1", "XX");
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {

            cboField.Items.Add("Make");
            cboField.Items.Add("EngineSize");
            cboField.Items.Add("RentalPerDay");
            cboField.Items.Add("Available");


            cboOperator.Items.Add("=");
            cboOperator.Items.Add("<");
            cboOperator.Items.Add(">");
            cboOperator.Items.Add("<=");
            cboOperator.Items.Add(">=");

            dataGridView1.DataSource = carsTableView;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dataGridView1.Columns["DateRegistered"].
                DefaultCellStyle.Format = "dd/MM/yyy";

            dataGridView1.Columns["EngineSize"].
    DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["RentalPerDay"].
                DefaultCellStyle.FormatProvider = new CultureInfo("en-IE");
            dataGridView1.Columns["RentalPerDay"].
                DefaultCellStyle.Format = "c";
            dataGridView1.Columns["RentalPerDay"].
                DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.Text = "Search -  Date: " +
                DateTime.Now.ToLongDateString() + "                                                                                                              by Lewis Kelly";

            //18


        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboField.Text) ||
                String.IsNullOrEmpty(cboOperator.Text) ||
                String.IsNullOrEmpty(txtValue.Text))
            {
                MessageBox.Show("Missing search criteria!");
            }
            else
            {
                string filter = String.Format("{0} {1} '{2}'",
                    cboField.Text, cboOperator.Text,
                    txtValue.Text);

                carsTableView.RowFilter = filter;
                MessageBox.Show(carsTableView.Count.ToString() + " matching rows found.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            callingForm.Show();
        }

    }
}

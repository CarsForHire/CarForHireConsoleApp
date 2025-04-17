using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace DraftCarHireApp
{
    public partial class frmCars : Form
    {
        DataSet carsDataset = new DataSet();
        SqlDataAdapter carsDataAdapter;
        BindingSource carsBindingSource;
        SqlCommandBuilder dbSQLCommands;

        // - Connection String
        string DBConnectionString = "Server=Localhost\\SQLEXPRESS;Database=EVMotors_DB;Trusted_Connection=True;TrustServerCertificate=True;";
        public frmCars()
        {
            InitializeComponent();
            this.Text = "Vehicle Details - Date: " + DateTime.Today.ToLongDateString();
        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            try
            {
                carsDataAdapter = new SqlDataAdapter("SELECT * FROM EVMotors", DBConnectionString);
                carsDataAdapter.Fill(carsDataset, "EVMotors");
                MessageBox.Show("Connected to DB");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString() + ":" + ex.Message);
                Application.Exit();
            }

            BindControls();

            recordCountDisplay();

            carsBindingSource.PositionChanged += rowPositionChanged;
        }

        private void rowPositionChanged(object sender, EventArgs e)
        {
            recordCountDisplay();
        }

        private void BindControls()
        {
            carsBindingSource = new BindingSource(carsDataset, "EVMotors");

            txtRegNumber.DataBindings.Add("Text", carsBindingSource, "VehicleRegNo");
            txtMake.DataBindings.Add("Text", carsBindingSource, "Make");
            txtEngineSize.DataBindings.Add("Text", carsBindingSource, "EngineSize");

            Binding dateRegBinding = txtDateRegistered.DataBindings.Add("Text", carsBindingSource, "DateRegistered", true);
            dateRegBinding.FormatInfo = new CultureInfo("en-IE"); //Format for Ireland

            Binding rentalCostBinding = txtRentalRatePerDay.DataBindings.Add("Text", carsBindingSource, "RentalPerDay", true);
            rentalCostBinding.FormatInfo = new CultureInfo("en-IE"); //Format for Ireland

            rentalCostBinding.FormatString = "c"; //Format for Currency

            checkBoxAvailable.DataBindings.Add("Checked", carsBindingSource, "Available", true);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                carsBindingSource.EndEdit();

                dbSQLCommands = new SqlCommandBuilder(carsDataAdapter);
                carsDataAdapter.Update(carsDataset, "EVMotors");

                MessageBox.Show("Database successfully updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void recordCountDisplay()
        {
            txtRecordCount.Text = String.Format("{0} of {1}", carsBindingSource.Position + 1, carsBindingSource.Count);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            carsBindingSource.EndEdit();
            carsBindingSource.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            carsBindingSource.EndEdit();
            carsBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            carsBindingSource.EndEdit();
            carsBindingSource.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            carsBindingSource.EndEdit();
            carsBindingSource.MoveLast();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            carsBindingSource.EndEdit();
            carsBindingSource.AddNew();
            carsBindingSource.MoveLast();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            carsBindingSource.RemoveCurrent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            carsBindingSource.CancelEdit();

            carsDataset.RejectChanges();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit progam
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch searchForm = new frmSearch(this, carsDataset);
            searchForm.Show();
        }
    }
}

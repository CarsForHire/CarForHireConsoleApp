namespace DraftCarHireApp
{
    partial class frmCars
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtRegNumber = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMake = new TextBox();
            txtEngineSize = new TextBox();
            txtDateRegistered = new TextBox();
            txtRentalRatePerDay = new TextBox();
            label6 = new Label();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            btnFirst = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            txtRecordCount = new TextBox();
            label7 = new Label();
            checkBoxAvailable = new CheckBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Freestyle Script", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 9);
            label1.Name = "label1";
            label1.Size = new Size(311, 57);
            label1.TabIndex = 0;
            label1.Text = "Ready2Roll Car Hire";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 99);
            label2.Name = "label2";
            label2.Size = new Size(201, 20);
            label2.TabIndex = 1;
            label2.Text = "Vehicle Registration Number:";
            // 
            // txtRegNumber
            // 
            txtRegNumber.Location = new Point(249, 96);
            txtRegNumber.Name = "txtRegNumber";
            txtRegNumber.Size = new Size(288, 27);
            txtRegNumber.TabIndex = 2;
            toolTip1.SetToolTip(txtRegNumber, "Enter Registration Number.\r\nPlease ensure to use capital leters for County Codes.");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 136);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 3;
            label3.Text = "Make & Model:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 175);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 4;
            label4.Text = "Engine Size:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 214);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 5;
            label5.Text = "Date Registered:";
            // 
            // txtMake
            // 
            txtMake.Location = new Point(249, 133);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(288, 27);
            txtMake.TabIndex = 6;
            toolTip1.SetToolTip(txtMake, "Make and Model");
            // 
            // txtEngineSize
            // 
            txtEngineSize.Location = new Point(249, 172);
            txtEngineSize.Name = "txtEngineSize";
            txtEngineSize.Size = new Size(176, 27);
            txtEngineSize.TabIndex = 7;
            toolTip1.SetToolTip(txtEngineSize, "Please enter the engine size in Litres");
            // 
            // txtDateRegistered
            // 
            txtDateRegistered.Location = new Point(249, 211);
            txtDateRegistered.Name = "txtDateRegistered";
            txtDateRegistered.Size = new Size(120, 27);
            txtDateRegistered.TabIndex = 8;
            // 
            // txtRentalRatePerDay
            // 
            txtRentalRatePerDay.Location = new Point(249, 252);
            txtRentalRatePerDay.Name = "txtRentalRatePerDay";
            txtRentalRatePerDay.Size = new Size(120, 27);
            txtRentalRatePerDay.TabIndex = 10;
            txtRentalRatePerDay.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 255);
            label6.Name = "label6";
            label6.Size = new Size(144, 20);
            label6.TabIndex = 9;
            label6.Text = "Rental Rate per Day:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(659, 87);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(84, 32);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(659, 125);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(84, 32);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(659, 163);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 32);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(659, 201);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(84, 32);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(659, 240);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(84, 32);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(659, 281);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(84, 32);
            btnExit.TabIndex = 16;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(31, 391);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(119, 29);
            btnFirst.TabIndex = 17;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(156, 391);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(119, 29);
            btnPrevious.TabIndex = 18;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(418, 391);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(119, 29);
            btnNext.TabIndex = 19;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(543, 391);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(119, 29);
            btnLast.TabIndex = 20;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // txtRecordCount
            // 
            txtRecordCount.Location = new Point(281, 393);
            txtRecordCount.Name = "txtRecordCount";
            txtRecordCount.Size = new Size(131, 27);
            txtRecordCount.TabIndex = 21;
            txtRecordCount.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 293);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 22;
            label7.Text = "Available:";
            // 
            // checkBoxAvailable
            // 
            checkBoxAvailable.AutoSize = true;
            checkBoxAvailable.Location = new Point(249, 293);
            checkBoxAvailable.Name = "checkBoxAvailable";
            checkBoxAvailable.Size = new Size(18, 17);
            checkBoxAvailable.TabIndex = 23;
            checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // frmCars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxAvailable);
            Controls.Add(label7);
            Controls.Add(txtRecordCount);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(txtRentalRatePerDay);
            Controls.Add(label6);
            Controls.Add(txtDateRegistered);
            Controls.Add(txtEngineSize);
            Controls.Add(txtMake);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtRegNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCars";
            Text = "Browse Cars";
            Load += frmCars_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtRegNumber;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMake;
        private TextBox txtEngineSize;
        private TextBox txtDateRegistered;
        private TextBox txtRentalRatePerDay;
        private Label label6;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnCancel;
        private Button btnExit;
        private Button btnFirst;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private TextBox txtRecordCount;
        private Label label7;
        private CheckBox checkBoxAvailable;
        private ToolTip toolTip1;
    }
}

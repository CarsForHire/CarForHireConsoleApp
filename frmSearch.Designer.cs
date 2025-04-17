namespace DraftCarHireApp
{
    partial class frmSearch
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
            groupBox1 = new GroupBox();
            txtValue = new TextBox();
            cboOperator = new ComboBox();
            cboField = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRun = new Button();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtValue);
            groupBox1.Controls.Add(cboOperator);
            groupBox1.Controls.Add(cboField);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(700, 162);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Values";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(456, 68);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(173, 27);
            txtValue.TabIndex = 5;
            // 
            // cboOperator
            // 
            cboOperator.FormattingEnabled = true;
            cboOperator.Location = new Point(206, 67);
            cboOperator.Name = "cboOperator";
            cboOperator.Size = new Size(229, 28);
            cboOperator.TabIndex = 4;
            // 
            // cboField
            // 
            cboField.FormattingEnabled = true;
            cboField.Location = new Point(18, 67);
            cboField.Name = "cboField";
            cboField.Size = new Size(166, 28);
            cboField.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 23);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Operator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 23);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Value";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 23);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Field";
            // 
            // btnRun
            // 
            btnRun.Location = new Point(775, 67);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(116, 38);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(775, 131);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(116, 38);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(766, 279);
            dataGridView1.TabIndex = 3;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 527);
            Controls.Add(dataGridView1);
            Controls.Add(btnClose);
            Controls.Add(btnRun);
            Controls.Add(groupBox1);
            Name = "frmSearch";
            Text = "Search";
            Load += frmSearch_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cboOperator;
        private ComboBox cboField;
        private Label label3;
        private Label label2;
        private Button btnRun;
        private Button btnClose;
        private DataGridView dataGridView1;
        private TextBox txtValue;
    }
}
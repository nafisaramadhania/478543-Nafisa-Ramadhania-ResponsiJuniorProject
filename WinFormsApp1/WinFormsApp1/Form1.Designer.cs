namespace WinFormsApp1
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNamaKaryawan = new TextBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgv = new DataGridView();
            label4 = new Label();
            btnLoad = new Button();
            label5 = new Label();
            cbDep = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 47);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "HR EasyPeasy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 95);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Karyawan:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 136);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 2;
            label3.Text = "Dep. Karyawan";
            // 
            // tbNamaKaryawan
            // 
            tbNamaKaryawan.Location = new Point(144, 92);
            tbNamaKaryawan.Name = "tbNamaKaryawan";
            tbNamaKaryawan.Size = new Size(100, 23);
            tbNamaKaryawan.TabIndex = 3;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(13, 190);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(142, 190);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(268, 190);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(13, 230);
            dgv.Name = "dgv";
            dgv.Size = new Size(775, 208);
            dgv.TabIndex = 7;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("OCR A Extended", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 38);
            label4.Name = "label4";
            label4.Size = new Size(77, 29);
            label4.TabIndex = 8;
            label4.Text = "HREP";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(713, 190);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Load Data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(667, 16);
            label5.Name = "label5";
            label5.Size = new Size(121, 147);
            label5.TabIndex = 12;
            label5.Text = "ID Departemen\r\n\r\nHR: HR\r\nENG : Engineer\r\nDEV : Developer\r\nPM : Product M\r\nFIN : Finance";
            // 
            // cbDep
            // 
            cbDep.AutoCompleteCustomSource.AddRange(new string[] { "\"HR\"", "\"ENG\"", "\"DEV\"", "\"PM\"", "\"FIN\"" });
            cbDep.FormattingEnabled = true;
            cbDep.Items.AddRange(new object[] { "\"HR\"", "\"ENG\"", "\"DEV\"", "\"PM\"", "\"FIN\"" });
            cbDep.Location = new Point(141, 142);
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(121, 23);
            cbDep.TabIndex = 13;
            cbDep.SelectedIndexChanged += cbDep_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbDep);
            Controls.Add(label5);
            Controls.Add(btnLoad);
            Controls.Add(label4);
            Controls.Add(dgv);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(tbNamaKaryawan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbNamaKaryawan;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private Label label4;
        private Button btnLoad;
        private Label label5;
        private ComboBox cbDep;
        public DataGridView dgv;
    }
}

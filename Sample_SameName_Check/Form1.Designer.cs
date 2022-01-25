namespace Sample_SameName_Check
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_NameCheck = new System.Windows.Forms.Button();
            this.btn_DataSet = new System.Windows.Forms.Button();
            this.dgvPeopleList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_NameCheck);
            this.splitContainer1.Panel1.Controls.Add(this.btn_DataSet);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvPeopleList);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 137;
            this.splitContainer1.TabIndex = 1;
            // 
            // btn_NameCheck
            // 
            this.btn_NameCheck.Location = new System.Drawing.Point(12, 86);
            this.btn_NameCheck.Name = "btn_NameCheck";
            this.btn_NameCheck.Size = new System.Drawing.Size(112, 34);
            this.btn_NameCheck.TabIndex = 1;
            this.btn_NameCheck.Text = "Check";
            this.btn_NameCheck.UseVisualStyleBackColor = true;
            this.btn_NameCheck.Click += new System.EventHandler(this.btn_NameCheck_Click);
            // 
            // btn_DataSet
            // 
            this.btn_DataSet.Location = new System.Drawing.Point(12, 25);
            this.btn_DataSet.Name = "btn_DataSet";
            this.btn_DataSet.Size = new System.Drawing.Size(112, 34);
            this.btn_DataSet.TabIndex = 0;
            this.btn_DataSet.Text = "DataSet";
            this.btn_DataSet.UseVisualStyleBackColor = true;
            this.btn_DataSet.Click += new System.EventHandler(this.btn_DataSet_Click);
            // 
            // dgvPeopleList
            // 
            this.dgvPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeopleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPeopleList.Location = new System.Drawing.Point(0, 0);
            this.dgvPeopleList.Name = "dgvPeopleList";
            this.dgvPeopleList.RowHeadersWidth = 62;
            this.dgvPeopleList.RowTemplate.Height = 33;
            this.dgvPeopleList.Size = new System.Drawing.Size(659, 450);
            this.dgvPeopleList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btn_NameCheck;
        private Button btn_DataSet;
        private DataGridView dgvPeopleList;
    }
}
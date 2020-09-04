namespace StockManager.Forms
{
    partial class FormFII
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddOperation = new System.Windows.Forms.Button();
            this.btnAddRend = new System.Windows.Forms.Button();
            this.btnAddAmort = new System.Windows.Forms.Button();
            this.btnAmort = new System.Windows.Forms.Button();
            this.btnRend = new System.Windows.Forms.Button();
            this.btnOperation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAddOperation
            // 
            this.btnAddOperation.Location = new System.Drawing.Point(12, 12);
            this.btnAddOperation.Name = "btnAddOperation";
            this.btnAddOperation.Size = new System.Drawing.Size(150, 40);
            this.btnAddOperation.TabIndex = 4;
            this.btnAddOperation.Text = "Adicionar Operações";
            this.btnAddOperation.UseVisualStyleBackColor = true;
            this.btnAddOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnAddRend
            // 
            this.btnAddRend.Location = new System.Drawing.Point(12, 53);
            this.btnAddRend.Name = "btnAddRend";
            this.btnAddRend.Size = new System.Drawing.Size(150, 40);
            this.btnAddRend.TabIndex = 5;
            this.btnAddRend.Text = "Adicionar Rendimentos";
            this.btnAddRend.UseVisualStyleBackColor = true;
            // 
            // btnAddAmort
            // 
            this.btnAddAmort.Location = new System.Drawing.Point(12, 94);
            this.btnAddAmort.Name = "btnAddAmort";
            this.btnAddAmort.Size = new System.Drawing.Size(150, 40);
            this.btnAddAmort.TabIndex = 6;
            this.btnAddAmort.Text = "Adicionar Amortizações";
            this.btnAddAmort.UseVisualStyleBackColor = true;
            // 
            // btnAmort
            // 
            this.btnAmort.Location = new System.Drawing.Point(12, 217);
            this.btnAmort.Name = "btnAmort";
            this.btnAmort.Size = new System.Drawing.Size(150, 40);
            this.btnAmort.TabIndex = 9;
            this.btnAmort.Text = "Amortizações";
            this.btnAmort.UseVisualStyleBackColor = true;
            // 
            // btnRend
            // 
            this.btnRend.Location = new System.Drawing.Point(12, 176);
            this.btnRend.Name = "btnRend";
            this.btnRend.Size = new System.Drawing.Size(150, 40);
            this.btnRend.TabIndex = 8;
            this.btnRend.Text = "Rendimentos";
            this.btnRend.UseVisualStyleBackColor = true;
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(12, 135);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(150, 40);
            this.btnOperation.TabIndex = 7;
            this.btnOperation.Text = "Operações";
            this.btnOperation.UseVisualStyleBackColor = true;
            // 
            // FormFII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnAmort);
            this.Controls.Add(this.btnRend);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.btnAddAmort);
            this.Controls.Add(this.btnAddRend);
            this.Controls.Add(this.btnAddOperation);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormFII";
            this.Text = "FormFII";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFII_FormClosed);
            this.Load += new System.EventHandler(this.FormFII_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddOperation;
        private System.Windows.Forms.Button btnAddRend;
        private System.Windows.Forms.Button btnAddAmort;
        private System.Windows.Forms.Button btnAmort;
        private System.Windows.Forms.Button btnRend;
        private System.Windows.Forms.Button btnOperation;
    }
}
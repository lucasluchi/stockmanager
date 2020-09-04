namespace StockManager.Forms
{
    partial class FormAddOperation
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
            this.OperationDateTime = new System.Windows.Forms.DateTimePicker();
            this.OperationTicker = new System.Windows.Forms.TextBox();
            this.OperationCV = new System.Windows.Forms.TextBox();
            this.OperationQuantity = new System.Windows.Forms.TextBox();
            this.OperationTax = new System.Windows.Forms.TextBox();
            this.OperationBrute = new System.Windows.Forms.TextBox();
            this.OperationLiquid = new System.Windows.Forms.TextBox();
            this.OperationFees = new System.Windows.Forms.TextBox();
            this.OperationPrice = new System.Windows.Forms.TextBox();
            this.OperationBroker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaveOperation = new System.Windows.Forms.Button();
            this.checkBoxIPO = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // OperationDateTime
            // 
            this.OperationDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OperationDateTime.Location = new System.Drawing.Point(10, 40);
            this.OperationDateTime.Name = "OperationDateTime";
            this.OperationDateTime.Size = new System.Drawing.Size(80, 20);
            this.OperationDateTime.TabIndex = 0;
            this.OperationDateTime.TabStop = false;
            this.OperationDateTime.Value = new System.DateTime(2020, 9, 4, 17, 10, 39, 0);
            // 
            // OperationTicker
            // 
            this.OperationTicker.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.OperationTicker.Location = new System.Drawing.Point(94, 40);
            this.OperationTicker.Name = "OperationTicker";
            this.OperationTicker.Size = new System.Drawing.Size(80, 20);
            this.OperationTicker.TabIndex = 1;
            this.OperationTicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OperationCV
            // 
            this.OperationCV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.OperationCV.Location = new System.Drawing.Point(178, 40);
            this.OperationCV.Name = "OperationCV";
            this.OperationCV.Size = new System.Drawing.Size(40, 20);
            this.OperationCV.TabIndex = 2;
            this.OperationCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OperationQuantity
            // 
            this.OperationQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.OperationQuantity.Location = new System.Drawing.Point(222, 40);
            this.OperationQuantity.Name = "OperationQuantity";
            this.OperationQuantity.Size = new System.Drawing.Size(60, 20);
            this.OperationQuantity.TabIndex = 3;
            this.OperationQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OperationTax
            // 
            this.OperationTax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.OperationTax.Location = new System.Drawing.Point(454, 40);
            this.OperationTax.Name = "OperationTax";
            this.OperationTax.ReadOnly = true;
            this.OperationTax.Size = new System.Drawing.Size(80, 20);
            this.OperationTax.TabIndex = 4;
            this.OperationTax.TabStop = false;
            this.OperationTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OperationBrute
            // 
            this.OperationBrute.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.OperationBrute.Location = new System.Drawing.Point(538, 40);
            this.OperationBrute.Name = "OperationBrute";
            this.OperationBrute.ReadOnly = true;
            this.OperationBrute.Size = new System.Drawing.Size(80, 20);
            this.OperationBrute.TabIndex = 5;
            this.OperationBrute.TabStop = false;
            this.OperationBrute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OperationLiquid
            // 
            this.OperationLiquid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.OperationLiquid.Location = new System.Drawing.Point(622, 40);
            this.OperationLiquid.Name = "OperationLiquid";
            this.OperationLiquid.ReadOnly = true;
            this.OperationLiquid.Size = new System.Drawing.Size(80, 20);
            this.OperationLiquid.TabIndex = 6;
            this.OperationLiquid.TabStop = false;
            this.OperationLiquid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OperationFees
            // 
            this.OperationFees.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.OperationFees.Location = new System.Drawing.Point(370, 40);
            this.OperationFees.Name = "OperationFees";
            this.OperationFees.Size = new System.Drawing.Size(80, 20);
            this.OperationFees.TabIndex = 8;
            this.OperationFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OperationPrice
            // 
            this.OperationPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.OperationPrice.Location = new System.Drawing.Point(286, 40);
            this.OperationPrice.Name = "OperationPrice";
            this.OperationPrice.Size = new System.Drawing.Size(80, 20);
            this.OperationPrice.TabIndex = 7;
            this.OperationPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OperationBroker
            // 
            this.OperationBroker.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.OperationBroker.Location = new System.Drawing.Point(706, 40);
            this.OperationBroker.Name = "OperationBroker";
            this.OperationBroker.Size = new System.Drawing.Size(80, 20);
            this.OperationBroker.TabIndex = 9;
            this.OperationBroker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "DATA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ATIVO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "C/V";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "QNT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "COTAÇÃO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "CORRETAGEM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "EMO/LIQ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(547, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "R$ BRUTO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(628, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "R$ LÍQUIDO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(709, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "CORRETORA";
            // 
            // btnSaveOperation
            // 
            this.btnSaveOperation.Location = new System.Drawing.Point(711, 76);
            this.btnSaveOperation.Name = "btnSaveOperation";
            this.btnSaveOperation.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOperation.TabIndex = 20;
            this.btnSaveOperation.TabStop = false;
            this.btnSaveOperation.Text = "Salvar";
            this.btnSaveOperation.UseVisualStyleBackColor = true;
            // 
            // checkBoxIPO
            // 
            this.checkBoxIPO.AutoSize = true;
            this.checkBoxIPO.Location = new System.Drawing.Point(10, 79);
            this.checkBoxIPO.Name = "checkBoxIPO";
            this.checkBoxIPO.Size = new System.Drawing.Size(118, 17);
            this.checkBoxIPO.TabIndex = 21;
            this.checkBoxIPO.TabStop = false;
            this.checkBoxIPO.Text = "IPO/SUBSCRIÇÃO";
            this.checkBoxIPO.UseVisualStyleBackColor = true;
            // 
            // FormAddOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(794, 111);
            this.Controls.Add(this.checkBoxIPO);
            this.Controls.Add(this.btnSaveOperation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OperationBroker);
            this.Controls.Add(this.OperationPrice);
            this.Controls.Add(this.OperationFees);
            this.Controls.Add(this.OperationLiquid);
            this.Controls.Add(this.OperationBrute);
            this.Controls.Add(this.OperationTax);
            this.Controls.Add(this.OperationQuantity);
            this.Controls.Add(this.OperationCV);
            this.Controls.Add(this.OperationTicker);
            this.Controls.Add(this.OperationDateTime);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(810, 150);
            this.Name = "FormAddOperation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Adicionar Operação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker OperationDateTime;
        private System.Windows.Forms.TextBox OperationTicker;
        private System.Windows.Forms.TextBox OperationCV;
        private System.Windows.Forms.TextBox OperationQuantity;
        private System.Windows.Forms.TextBox OperationTax;
        private System.Windows.Forms.TextBox OperationBrute;
        private System.Windows.Forms.TextBox OperationLiquid;
        private System.Windows.Forms.TextBox OperationFees;
        private System.Windows.Forms.TextBox OperationPrice;
        private System.Windows.Forms.TextBox OperationBroker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveOperation;
        private System.Windows.Forms.CheckBox checkBoxIPO;
    }
}
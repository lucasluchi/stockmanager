namespace StockManager
{
    partial class MainForm
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
            this.btnFII = new System.Windows.Forms.Button();
            this.btnStocks = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFII
            // 
            this.btnFII.Location = new System.Drawing.Point(10, 10);
            this.btnFII.Name = "btnFII";
            this.btnFII.Size = new System.Drawing.Size(250, 50);
            this.btnFII.TabIndex = 0;
            this.btnFII.Text = "Operações - Fundos Imobiliários";
            this.btnFII.UseVisualStyleBackColor = true;
            this.btnFII.Click += new System.EventHandler(this.btnFII_Click);
            // 
            // btnStocks
            // 
            this.btnStocks.Location = new System.Drawing.Point(10, 60);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Size = new System.Drawing.Size(250, 50);
            this.btnStocks.TabIndex = 1;
            this.btnStocks.Text = "Operações - Ações";
            this.btnStocks.UseVisualStyleBackColor = true;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(10, 110);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(250, 50);
            this.btnOptions.TabIndex = 2;
            this.btnOptions.Text = "Operações - Futuros";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(10, 160);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(250, 50);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "Configuração";
            this.btnConfig.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.labelVersion);
            this.panel1.Controls.Add(this.btnFII);
            this.panel1.Controls.Add(this.btnOptions);
            this.panel1.Controls.Add(this.btnStocks);
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 361);
            this.panel1.TabIndex = 2;
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(708, 339);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(64, 13);
            this.labelVersion.TabIndex = 4;
            this.labelVersion.Text = "Versão 1.00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFII;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelVersion;
    }
}


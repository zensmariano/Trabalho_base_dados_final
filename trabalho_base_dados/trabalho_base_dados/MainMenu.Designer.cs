namespace trabalho_base_dados
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pessoalBtn = new System.Windows.Forms.Button();
            this.armazemBtn = new System.Windows.Forms.Button();
            this.marketBtn = new System.Windows.Forms.Button();
            this.producaoBtn = new System.Windows.Forms.Button();
            this.nelsadaDataSet1 = new trabalho_base_dados.nelsadaDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.nelsadaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pessoalBtn
            // 
            this.pessoalBtn.Image = ((System.Drawing.Image)(resources.GetObject("pessoalBtn.Image")));
            this.pessoalBtn.Location = new System.Drawing.Point(34, 150);
            this.pessoalBtn.Name = "pessoalBtn";
            this.pessoalBtn.Size = new System.Drawing.Size(359, 140);
            this.pessoalBtn.TabIndex = 1;
            this.pessoalBtn.UseVisualStyleBackColor = true;
            this.pessoalBtn.Click += new System.EventHandler(this.pessoalBtn_Click);
            // 
            // armazemBtn
            // 
            this.armazemBtn.Image = ((System.Drawing.Image)(resources.GetObject("armazemBtn.Image")));
            this.armazemBtn.Location = new System.Drawing.Point(34, 296);
            this.armazemBtn.Name = "armazemBtn";
            this.armazemBtn.Size = new System.Drawing.Size(359, 140);
            this.armazemBtn.TabIndex = 2;
            this.armazemBtn.UseVisualStyleBackColor = true;
            this.armazemBtn.Click += new System.EventHandler(this.armazemBtn_Click);
            // 
            // marketBtn
            // 
            this.marketBtn.Image = ((System.Drawing.Image)(resources.GetObject("marketBtn.Image")));
            this.marketBtn.Location = new System.Drawing.Point(399, 296);
            this.marketBtn.Name = "marketBtn";
            this.marketBtn.Size = new System.Drawing.Size(359, 140);
            this.marketBtn.TabIndex = 4;
            this.marketBtn.UseVisualStyleBackColor = true;
            this.marketBtn.Click += new System.EventHandler(this.marketBtn_Click);
            // 
            // producaoBtn
            // 
            this.producaoBtn.Image = ((System.Drawing.Image)(resources.GetObject("producaoBtn.Image")));
            this.producaoBtn.Location = new System.Drawing.Point(399, 150);
            this.producaoBtn.Name = "producaoBtn";
            this.producaoBtn.Size = new System.Drawing.Size(359, 140);
            this.producaoBtn.TabIndex = 3;
            this.producaoBtn.UseVisualStyleBackColor = true;
            this.producaoBtn.Click += new System.EventHandler(this.producaoBtn_Click);
            // 
            // nelsadaDataSet1
            // 
            this.nelsadaDataSet1.DataSetName = "nelsadaDataSet";
            this.nelsadaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.marketBtn);
            this.Controls.Add(this.producaoBtn);
            this.Controls.Add(this.armazemBtn);
            this.Controls.Add(this.pessoalBtn);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nelsadaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button pessoalBtn;
        private System.Windows.Forms.Button armazemBtn;
        private System.Windows.Forms.Button marketBtn;
        private System.Windows.Forms.Button producaoBtn;
        private nelsadaDataSet nelsadaDataSet1;
    }
}
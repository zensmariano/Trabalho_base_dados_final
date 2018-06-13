namespace trabalho_base_dados
{
    partial class Producao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producao));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pRODUCAOVINHOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCAORECEITATAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCAOSTOCKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nelsadaDataSet = new trabalho_base_dados.nelsadaDataSet();
            this.pRODUCAOVINHO_DESCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCAOQUANTIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCAODATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producaoTableAdapter = new trabalho_base_dados.nelsadaDataSetTableAdapters.PRODUCAOTableAdapter();
            //this.ProducaoTab = new System.Windows.Forms.TabPage();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.button21 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nelsadaDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRODUCAOVINHOIDDataGridViewTextBoxColumn,
            this.pRODUCAORECEITATAGDataGridViewTextBoxColumn,
            this.pRODUCAOSTOCKIDDataGridViewTextBoxColumn,});
            this.dataGridView2.DataSource = this.producaoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(8, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(750, 235);
            this.dataGridView2.TabIndex = 0;
            // 
            // pRODUCAOVINHOIDDataGridViewTextBoxColumn
            // 
            this.pRODUCAOVINHOIDDataGridViewTextBoxColumn.DataPropertyName = "VINHO_ID";
            this.pRODUCAOVINHOIDDataGridViewTextBoxColumn.HeaderText = "VINHO_ID";
            this.pRODUCAOVINHOIDDataGridViewTextBoxColumn.Name = "pRODUCAOVINHOIDDataGridViewTextBoxColumn";
            this.pRODUCAOVINHOIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUCAORECEITATAGDataGridViewTextBoxColumn
            // 
            this.pRODUCAORECEITATAGDataGridViewTextBoxColumn.DataPropertyName = "RECEITA_TAG";
            this.pRODUCAORECEITATAGDataGridViewTextBoxColumn.HeaderText = "RECEITA_TAG";
            this.pRODUCAORECEITATAGDataGridViewTextBoxColumn.Name = "pRODUCAORECEITATAGDataGridViewTextBoxColumn";
            // 
            // pRODUCAOSTOCKIDDataGridViewTextBoxColumn
            // 
            this.pRODUCAOSTOCKIDDataGridViewTextBoxColumn.DataPropertyName = "STOCK_ID";
            this.pRODUCAOSTOCKIDDataGridViewTextBoxColumn.HeaderText = "STOCK_ID";
            this.pRODUCAOSTOCKIDDataGridViewTextBoxColumn.Name = "pRODUCAOSTOCKIDDataGridViewTextBoxColumn";
            // 
            // producaoBindingSource
            // 
            this.producaoBindingSource.DataMember = "Producao";
            this.producaoBindingSource.DataSource = this.nelsadaDataSet;
            // 
            // nelsadaDataSet
            // 
            this.nelsadaDataSet.DataSetName = "nelsadaDataSet";
            this.nelsadaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCAOVINHO_DESCDataGridViewTextBoxColumn
            // 
            this.pRODUCAOVINHO_DESCDataGridViewTextBoxColumn.DataPropertyName = "VINHO_DESC";
            this.pRODUCAOVINHO_DESCDataGridViewTextBoxColumn.HeaderText = "VINHO_DESC";
            this.pRODUCAOVINHO_DESCDataGridViewTextBoxColumn.Name = "pRODUCAOVINHO_DESCDataGridViewTextBoxColumn";
            // 
            // pRODUCAOQUANTIDADEDataGridViewTextBoxColumn
            // 
            this.pRODUCAOQUANTIDADEDataGridViewTextBoxColumn.DataPropertyName = "VINHO_DESC";
            this.pRODUCAOQUANTIDADEDataGridViewTextBoxColumn.HeaderText = "VINHO_DESC";
            this.pRODUCAOQUANTIDADEDataGridViewTextBoxColumn.Name = "pRODUCAOQUANTIDADEDataGridViewTextBoxColumn";
            // 
            // pRODUCAODATADataGridViewTextBoxColumn
            // 
            this.pRODUCAODATADataGridViewTextBoxColumn.DataPropertyName = "DATA";
            this.pRODUCAODATADataGridViewTextBoxColumn.HeaderText = "DATA";
            this.pRODUCAODATADataGridViewTextBoxColumn.Name = "pRODUCAODATADataGridViewTextBoxColumn";
            // 
            // producaoTableAdapter
            // 
            this.producaoTableAdapter.ClearBeforeFill = true;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(393, 363);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(84, 22);
            this.textBox21.TabIndex = 57;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(323, 367);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 17);
            this.label19.TabIndex = 56;
            this.label19.Text = "Stock_ID";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(229, 363);
            this.textBox16.Margin = new System.Windows.Forms.Padding(4);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(87, 22);
            this.textBox16.TabIndex = 55;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(112, 330);
            this.textBox19.Margin = new System.Windows.Forms.Padding(4);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(365, 22);
            this.textBox19.TabIndex = 46;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(193, 365);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 17);
            this.label14.TabIndex = 54;
            this.label14.Text = "Data";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(112, 362);
            this.textBox20.Margin = new System.Windows.Forms.Padding(4);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(73, 22);
            this.textBox20.TabIndex = 48;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 265);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 17);
            this.label15.TabIndex = 41;
            this.label15.Text = "Vinho_ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 366);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 17);
            this.label18.TabIndex = 47;
            this.label18.Text = "Quantidade";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 301);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 17);
            this.label16.TabIndex = 42;
            this.label16.Text = "Vinho_desc";
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(609, 299);
            this.button23.Margin = new System.Windows.Forms.Padding(4);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(150, 28);
            this.button23.TabIndex = 49;
            this.button23.Text = "Adicionar";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(805, 360);
            this.button19.Margin = new System.Windows.Forms.Padding(4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(150, 28);
            this.button19.TabIndex = 53;
            this.button19.Text = "Retroceder";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(805, 298);
            this.button22.Margin = new System.Windows.Forms.Padding(4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(150, 28);
            this.button22.TabIndex = 50;
            this.button22.Text = "Alterar";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(609, 362);
            this.button20.Margin = new System.Windows.Forms.Padding(4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(150, 28);
            this.button20.TabIndex = 52;
            this.button20.Text = "Cancelar";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 335);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 17);
            this.label17.TabIndex = 45;
            this.label17.Text = "Receita_TAG";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(112, 262);
            this.textBox17.Margin = new System.Windows.Forms.Padding(4);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(365, 22);
            this.textBox17.TabIndex = 43;
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(112, 298);
            this.textBox18.Margin = new System.Windows.Forms.Padding(4);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(365, 22);
            this.textBox18.TabIndex = 44;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(805, 330);
            this.button21.Margin = new System.Windows.Forms.Padding(4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(150, 28);
            this.button21.TabIndex = 51;
            this.button21.Text = "Eleminar";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.textBox21);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.textBox16);
            this.panel1.Controls.Add(this.textBox19);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.textBox20);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.button23);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Controls.Add(this.button20);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.textBox17);
            this.panel1.Controls.Add(this.textBox18);
            this.panel1.Controls.Add(this.button21);
            this.panel1.Location = new System.Drawing.Point(41, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 393);
            this.panel1.TabIndex = 0;
            // 
            // Producao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1093, 602);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Producao";
            this.Text = "Producao";
            this.Load += new System.EventHandler(this.Producao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nelsadaDataSet)).EndInit();
            //this.ProducaoTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private nelsadaDataSet nelsadaDataSet;
        private System.Windows.Forms.BindingSource producaoBindingSource;
        private nelsadaDataSetTableAdapters.PRODUCAOTableAdapter producaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCAOVINHOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCAORECEITATAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCAOSTOCKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCAOVINHO_DESCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCAOQUANTIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCAODATADataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Label label19;
    }
}
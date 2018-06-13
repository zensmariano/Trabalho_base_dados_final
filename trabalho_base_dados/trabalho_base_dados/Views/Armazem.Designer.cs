namespace trabalho_base_dados
{
    partial class Armazem
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.aRMAZEMSTOCK_IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRMAZEMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRMAZEMQUANTIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.armazemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nelsadaDataSet = new trabalho_base_dados.nelsadaDataSet();
            this.aRMAZEMPRODUTOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRMAZEMPRECODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.armazemTableAdapter = new trabalho_base_dados.nelsadaDataSetTableAdapters.Produto_em_ArmazenamentoTableAdapter();
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
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armazemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nelsadaDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aRMAZEMSTOCK_IDDataGridViewTextBoxColumn,
            this.aRMAZEMIDDataGridViewTextBoxColumn,
            this.aRMAZEMQUANTIDADEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.armazemBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(8, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(750, 235);
            this.dataGridView2.TabIndex = 0;
            // 
            // aRMAZEMSTOCK_IDDataGridViewTextBoxColumn
            // 
            this.aRMAZEMSTOCK_IDDataGridViewTextBoxColumn.DataPropertyName = "Stock_ID";
            this.aRMAZEMSTOCK_IDDataGridViewTextBoxColumn.HeaderText = "Stock_ID";
            this.aRMAZEMSTOCK_IDDataGridViewTextBoxColumn.Name = "aRMAZEMSTOCK_IDDataGridViewTextBoxColumn";
            this.aRMAZEMSTOCK_IDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aRMAZEMIDDataGridViewTextBoxColumn
            // 
            this.aRMAZEMIDDataGridViewTextBoxColumn.DataPropertyName = "Armazem_ID";
            this.aRMAZEMIDDataGridViewTextBoxColumn.HeaderText = "Armazem_ID";
            this.aRMAZEMIDDataGridViewTextBoxColumn.Name = "aRMAZEMIDDataGridViewTextBoxColumn";
            // 
            // aRMAZEMQUANTIDADEDataGridViewTextBoxColumn
            // 
            this.aRMAZEMQUANTIDADEDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.aRMAZEMQUANTIDADEDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.aRMAZEMQUANTIDADEDataGridViewTextBoxColumn.Name = "aRMAZEMQUANTIDADEDataGridViewTextBoxColumn";
            // 
            // armazemBindingSource
            // 
            this.armazemBindingSource.DataMember = "Armazem";
            this.armazemBindingSource.DataSource = this.nelsadaDataSet;
            // 
            // nelsadaDataSet
            // 
            this.nelsadaDataSet.DataSetName = "nelsadaDataSet";
            this.nelsadaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aRMAZEMPRODUTOIDDataGridViewTextBoxColumn
            // 
            this.aRMAZEMPRODUTOIDDataGridViewTextBoxColumn.DataPropertyName = "Produto_ID";
            this.aRMAZEMPRODUTOIDDataGridViewTextBoxColumn.HeaderText = "Produto_ID";
            this.aRMAZEMPRODUTOIDDataGridViewTextBoxColumn.Name = "aRMAZEMPRODUTOIDDataGridViewTextBoxColumn";
            // 
            // aRMAZEMPRECODataGridViewTextBoxColumn
            // 
            this.aRMAZEMPRECODataGridViewTextBoxColumn.DataPropertyName = "Preço";
            this.aRMAZEMPRECODataGridViewTextBoxColumn.HeaderText = "Preço";
            this.aRMAZEMPRECODataGridViewTextBoxColumn.Name = "aRMAZEMPRECODataGridViewTextBoxColumn";
            // 
            // armazemTableAdapter
            // 
            this.armazemTableAdapter.ClearBeforeFill = true;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(249, 363);
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
            this.label14.Location = new System.Drawing.Point(196, 365);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 17);
            this.label14.TabIndex = 54;
            this.label14.Text = "Preço";
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
            this.label15.Size = new System.Drawing.Size(64, 17);
            this.label15.TabIndex = 41;
            this.label15.Text = "Stock_ID";
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
            this.label16.Size = new System.Drawing.Size(79, 17);
            this.label16.TabIndex = 42;
            this.label16.Text = "Produto_ID";
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
            this.label17.Size = new System.Drawing.Size(88, 17);
            this.label17.TabIndex = 45;
            this.label17.Text = "Armazem_ID";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(112, 265);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(365, 22);
            this.textBox17.TabIndex = 58;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.textBox16);
            this.panel2.Controls.Add(this.textBox19);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.textBox20);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.button23);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.button22);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.textBox17);
            this.panel2.Controls.Add(this.textBox18);
            this.panel2.Controls.Add(this.button21);
            this.panel2.Location = new System.Drawing.Point(41, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 393);
            this.panel2.TabIndex = 0;
            // 
            // Armazem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 566);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Armazem";
            this.Text = "Armazem";
            this.Load += new System.EventHandler(this.Armazem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armazemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nelsadaDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private nelsadaDataSet nelsadaDataSet;
        private System.Windows.Forms.BindingSource armazemBindingSource;
        private nelsadaDataSetTableAdapters.Produto_em_ArmazenamentoTableAdapter armazemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRMAZEMSTOCK_IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRMAZEMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRMAZEMPRODUTOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRMAZEMQUANTIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRMAZEMPRECODataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
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
    }
}
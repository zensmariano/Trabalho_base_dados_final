namespace trabalho_base_dados.Views
{
    partial class TipoContacto
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
            this.nelsadaDataSet = new trabalho_base_dados.nelsadaDataSet();
            this.tIPO_CONTACTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPO_CONTACTOTableAdapter = new trabalho_base_dados.nelsadaDataSetTableAdapters.TIPO_CONTACTOTableAdapter();
            this.tableAdapterManager = new trabalho_base_dados.nelsadaDataSetTableAdapters.TableAdapterManager();
            this.tIPO_CONTACTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.button21 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nelsadaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPO_CONTACTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPO_CONTACTODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nelsadaDataSet
            // 
            this.nelsadaDataSet.DataSetName = "nelsadaDataSet";
            this.nelsadaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIPO_CONTACTOBindingSource
            // 
            this.tIPO_CONTACTOBindingSource.DataMember = "TIPO CONTACTO";
            this.tIPO_CONTACTOBindingSource.DataSource = this.nelsadaDataSet;
            // 
            // tIPO_CONTACTOTableAdapter
            // 
            this.tIPO_CONTACTOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArmazemTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CargoTableAdapter = null;
            this.tableAdapterManager.Cartao_de_ClienteTableAdapter = null;
            this.tableAdapterManager.Casta_da_uvaTableAdapter = null;
            this.tableAdapterManager.CASTAS_Produto_uva_TableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Codigo_PostalTableAdapter = null;
            this.tableAdapterManager.COLHEITA_PRODUTOTableAdapter = null;
            this.tableAdapterManager.COLHEITATableAdapter = null;
            this.tableAdapterManager.ContactosTableAdapter = null;
            this.tableAdapterManager.EncomendaTableAdapter = null;
            this.tableAdapterManager.FaturaTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIO_COLHEITATableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.ManutencaoTableAdapter = null;
            this.tableAdapterManager.MORADASTableAdapter = null;
            this.tableAdapterManager.PRODUCAOTableAdapter = null;
            this.tableAdapterManager.Produto_em_ArmazenamentoTableAdapter = null;
            this.tableAdapterManager.Produto_FaturaTableAdapter = null;
            this.tableAdapterManager.PRODUTOS_PARA_PRODUCAOTableAdapter = null;
            this.tableAdapterManager.ReceitaTableAdapter = null;
            this.tableAdapterManager.SAIDA_PRODUCAOTableAdapter = null;
            this.tableAdapterManager.TerrenoCastaTableAdapter = null;
            this.tableAdapterManager.TerrenoTableAdapter = null;
            this.tableAdapterManager.TIPO_CONTACTOTableAdapter = this.tIPO_CONTACTOTableAdapter;
            this.tableAdapterManager.Tipo_de_FaturaTableAdapter = null;
            this.tableAdapterManager.Tipo_PagamentoTableAdapter = null;
            this.tableAdapterManager.TIPO_ProdutoTableAdapter = null;
            this.tableAdapterManager.TipoManutencaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = trabalho_base_dados.nelsadaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tIPO_CONTACTODataGridView
            // 
            this.tIPO_CONTACTODataGridView.AutoGenerateColumns = false;
            this.tIPO_CONTACTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tIPO_CONTACTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tIPO_CONTACTODataGridView.DataSource = this.tIPO_CONTACTOBindingSource;
            this.tIPO_CONTACTODataGridView.Location = new System.Drawing.Point(12, 51);
            this.tIPO_CONTACTODataGridView.Name = "tIPO_CONTACTODataGridView";
            this.tIPO_CONTACTODataGridView.Size = new System.Drawing.Size(242, 220);
            this.tIPO_CONTACTODataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TIPO_CONTACTO";
            this.dataGridViewTextBoxColumn1.HeaderText = "TIPO_CONTACTO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TIPO_DESC";
            this.dataGridViewTextBoxColumn2.HeaderText = "TIPO_DESC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 322);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Tipo de Contacto:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 351);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "Descricao:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(12, 390);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(112, 23);
            this.button23.TabIndex = 56;
            this.button23.Text = "Adicionar";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(12, 415);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(112, 23);
            this.button22.TabIndex = 57;
            this.button22.Text = "Alterar";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(103, 348);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(133, 20);
            this.textBox18.TabIndex = 55;
            this.textBox18.TextChanged += new System.EventHandler(this.textBox18_TextChanged);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(130, 390);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(112, 23);
            this.button21.TabIndex = 58;
            this.button21.Text = "Eleminar";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 322);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 21);
            this.comboBox1.TabIndex = 59;
            // 
            // TipoContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.tIPO_CONTACTODataGridView);
            this.Name = "TipoContacto";
            this.Text = "TipoContacto";
            this.Load += new System.EventHandler(this.TipoContacto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nelsadaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPO_CONTACTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPO_CONTACTODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private nelsadaDataSet nelsadaDataSet;
        private System.Windows.Forms.BindingSource tIPO_CONTACTOBindingSource;
        private nelsadaDataSetTableAdapters.TIPO_CONTACTOTableAdapter tIPO_CONTACTOTableAdapter;
        private nelsadaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tIPO_CONTACTODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
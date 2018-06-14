namespace trabalho_base_dados.Views
{
    partial class NovoCliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NomeLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NomeTxtBox = new System.Windows.Forms.TextBox();
            this.NifTxtBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nelsadaDataSet = new trabalho_base_dados.nelsadaDataSet();
            this.mORADASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mORADASTableAdapter = new trabalho_base_dados.nelsadaDataSetTableAdapters.MORADASTableAdapter();
            this.tableAdapterManager = new trabalho_base_dados.nelsadaDataSetTableAdapters.TableAdapterManager();
            this.mORADASDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nelsadaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mORADASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mORADASDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Data Contrato:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 20);
            this.textBox2.TabIndex = 83;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 81;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NomeLbl
            // 
            this.NomeLbl.AutoSize = true;
            this.NomeLbl.Location = new System.Drawing.Point(31, 47);
            this.NomeLbl.Name = "NomeLbl";
            this.NomeLbl.Size = new System.Drawing.Size(38, 13);
            this.NomeLbl.TabIndex = 68;
            this.NomeLbl.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Nif:";
            // 
            // NomeTxtBox
            // 
            this.NomeTxtBox.Location = new System.Drawing.Point(92, 44);
            this.NomeTxtBox.Name = "NomeTxtBox";
            this.NomeTxtBox.Size = new System.Drawing.Size(303, 20);
            this.NomeTxtBox.TabIndex = 70;
            // 
            // NifTxtBox
            // 
            this.NifTxtBox.Location = new System.Drawing.Point(92, 73);
            this.NifTxtBox.Name = "NifTxtBox";
            this.NifTxtBox.Size = new System.Drawing.Size(303, 20);
            this.NifTxtBox.TabIndex = 71;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(58, 379);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(141, 23);
            this.addBtn.TabIndex = 76;
            this.addBtn.Text = "Adicionar";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(34, 178);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 84;
            this.checkBox1.Text = "Cartao Cliente";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 85;
            this.button2.Text = "Adicionar morada";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(205, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 23);
            this.button3.TabIndex = 86;
            this.button3.Text = "Remover morada";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // nelsadaDataSet
            // 
            this.nelsadaDataSet.DataSetName = "nelsadaDataSet";
            this.nelsadaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mORADASBindingSource
            // 
            this.mORADASBindingSource.DataMember = "MORADAS";
            this.mORADASBindingSource.DataSource = this.nelsadaDataSet;
            // 
            // mORADASTableAdapter
            // 
            this.mORADASTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MORADASTableAdapter = this.mORADASTableAdapter;
            this.tableAdapterManager.PRODUCAOTableAdapter = null;
            this.tableAdapterManager.Produto_em_ArmazenamentoTableAdapter = null;
            this.tableAdapterManager.Produto_FaturaTableAdapter = null;
            this.tableAdapterManager.PRODUTOS_PARA_PRODUCAOTableAdapter = null;
            this.tableAdapterManager.ReceitaTableAdapter = null;
            this.tableAdapterManager.SAIDA_PRODUCAOTableAdapter = null;
            this.tableAdapterManager.TerrenoCastaTableAdapter = null;
            this.tableAdapterManager.TerrenoTableAdapter = null;
            this.tableAdapterManager.TIPO_CONTACTOTableAdapter = null;
            this.tableAdapterManager.Tipo_de_FaturaTableAdapter = null;
            this.tableAdapterManager.Tipo_PagamentoTableAdapter = null;
            this.tableAdapterManager.TIPO_ProdutoTableAdapter = null;
            this.tableAdapterManager.TipoManutencaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = trabalho_base_dados.nelsadaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mORADASDataGridView
            // 
            this.mORADASDataGridView.AutoGenerateColumns = false;
            this.mORADASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mORADASDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.mORADASDataGridView.DataSource = this.mORADASBindingSource;
            this.mORADASDataGridView.Location = new System.Drawing.Point(34, 201);
            this.mORADASDataGridView.Name = "mORADASDataGridView";
            this.mORADASDataGridView.Size = new System.Drawing.Size(361, 108);
            this.mORADASDataGridView.TabIndex = 87;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MORADA_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MORADA_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CC_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CC_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CLIENTE_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "CLIENTE_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FUNCIONARIO_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "FUNCIONARIO_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FORNECEDOR_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "FORNECEDOR_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ARMAZEM_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ARMAZEM_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RUA";
            this.dataGridViewTextBoxColumn7.HeaderText = "RUA";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // NovoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 486);
            this.Controls.Add(this.mORADASDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NomeLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NomeTxtBox);
            this.Controls.Add(this.NifTxtBox);
            this.Controls.Add(this.addBtn);
            this.Name = "NovoCliente";
            this.Text = "NovoCliente";
            this.Load += new System.EventHandler(this.NovoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nelsadaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mORADASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mORADASDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NomeLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NomeTxtBox;
        private System.Windows.Forms.TextBox NifTxtBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private nelsadaDataSet nelsadaDataSet;
        private System.Windows.Forms.BindingSource mORADASBindingSource;
        private nelsadaDataSetTableAdapters.MORADASTableAdapter mORADASTableAdapter;
        private nelsadaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView mORADASDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}
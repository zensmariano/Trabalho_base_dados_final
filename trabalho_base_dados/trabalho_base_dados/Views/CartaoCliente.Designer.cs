﻿namespace trabalho_base_dados
{
    partial class CartaoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartaoCliente));
            this.nelsadaDataSet = new trabalho_base_dados.nelsadaDataSet();
            this.cartao_de_ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartao_de_ClienteTableAdapter = new trabalho_base_dados.nelsadaDataSetTableAdapters.Cartao_de_ClienteTableAdapter();
            this.tableAdapterManager = new trabalho_base_dados.nelsadaDataSetTableAdapters.TableAdapterManager();
            this.cartao_de_ClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nelsadaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartao_de_ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartao_de_ClienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nelsadaDataSet
            // 
            this.nelsadaDataSet.DataSetName = "nelsadaDataSet";
            this.nelsadaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartao_de_ClienteBindingSource
            // 
            this.cartao_de_ClienteBindingSource.DataMember = "Cartao de Cliente";
            this.cartao_de_ClienteBindingSource.DataSource = this.nelsadaDataSet;
            // 
            // cartao_de_ClienteTableAdapter
            // 
            this.cartao_de_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArmazemTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CargoTableAdapter = null;
            this.tableAdapterManager.Cartao_de_ClienteTableAdapter = this.cartao_de_ClienteTableAdapter;
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
            this.tableAdapterManager.TIPO_CONTACTOTableAdapter = null;
            this.tableAdapterManager.Tipo_de_FaturaTableAdapter = null;
            this.tableAdapterManager.Tipo_PagamentoTableAdapter = null;
            this.tableAdapterManager.TIPO_ProdutoTableAdapter = null;
            this.tableAdapterManager.TipoManutencaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = trabalho_base_dados.nelsadaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cartao_de_ClienteDataGridView
            // 
            this.cartao_de_ClienteDataGridView.AutoGenerateColumns = false;
            this.cartao_de_ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartao_de_ClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cartao_de_ClienteDataGridView.DataSource = this.cartao_de_ClienteBindingSource;
            this.cartao_de_ClienteDataGridView.Location = new System.Drawing.Point(12, 33);
            this.cartao_de_ClienteDataGridView.Name = "cartao_de_ClienteDataGridView";
            this.cartao_de_ClienteDataGridView.Size = new System.Drawing.Size(444, 295);
            this.cartao_de_ClienteDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CLIENTE_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CLIENTE_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CC_DESC";
            this.dataGridViewTextBoxColumn2.HeaderText = "CC_DESC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CC_DATA";
            this.dataGridViewTextBoxColumn3.HeaderText = "CC_DATA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CC_VALIDADE";
            this.dataGridViewTextBoxColumn4.HeaderText = "CC_VALIDADE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 364);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 67;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "ID Cliente:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(64, 406);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(112, 23);
            this.button23.TabIndex = 62;
            this.button23.Text = "Adicionar";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(182, 406);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(112, 23);
            this.button22.TabIndex = 63;
            this.button22.Text = "Alterar";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(300, 406);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(112, 23);
            this.button21.TabIndex = 64;
            this.button21.Text = "Eleminar";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // CartaoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.cartao_de_ClienteDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CartaoCliente";
            this.Text = "CartaoCliente";
            this.Load += new System.EventHandler(this.CartaoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nelsadaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartao_de_ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartao_de_ClienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private nelsadaDataSet nelsadaDataSet;
        private System.Windows.Forms.BindingSource cartao_de_ClienteBindingSource;
        private nelsadaDataSetTableAdapters.Cartao_de_ClienteTableAdapter cartao_de_ClienteTableAdapter;
        private nelsadaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cartao_de_ClienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
    }
}
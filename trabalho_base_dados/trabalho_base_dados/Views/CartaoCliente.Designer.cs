namespace trabalho_base_dados
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
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.telefLbl = new System.Windows.Forms.Label();
            this.NomeLbl = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
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
            this.cartao_de_ClienteDataGridView.Location = new System.Drawing.Point(12, 62);
            this.cartao_de_ClienteDataGridView.Name = "cartao_de_ClienteDataGridView";
            this.cartao_de_ClienteDataGridView.Size = new System.Drawing.Size(442, 220);
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
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(279, 408);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 20);
            this.textBox7.TabIndex = 40;
            // 
            // telefLbl
            // 
            this.telefLbl.AutoSize = true;
            this.telefLbl.Location = new System.Drawing.Point(221, 412);
            this.telefLbl.Name = "telefLbl";
            this.telefLbl.Size = new System.Drawing.Size(52, 13);
            this.telefLbl.TabIndex = 39;
            this.telefLbl.Text = "Telefone:";
            // 
            // NomeLbl
            // 
            this.NomeLbl.AutoSize = true;
            this.NomeLbl.Location = new System.Drawing.Point(36, 331);
            this.NomeLbl.Name = "NomeLbl";
            this.NomeLbl.Size = new System.Drawing.Size(38, 13);
            this.NomeLbl.TabIndex = 24;
            this.NomeLbl.Text = "Nome:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(449, 388);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nif:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(617, 408);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 23);
            this.button6.TabIndex = 37;
            this.button6.Text = "Retroceder";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(470, 409);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 23);
            this.button5.TabIndex = 36;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 328);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(303, 20);
            this.textBox2.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(617, 383);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Eleminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 357);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(303, 20);
            this.textBox3.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(470, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Cartao Cliente";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Morada:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(617, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(97, 383);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(303, 20);
            this.textBox5.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Codigo Postal:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(97, 409);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(109, 20);
            this.textBox6.TabIndex = 31;
            // 
            // CartaoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(464, 489);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.telefLbl);
            this.Controls.Add(this.NomeLbl);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.cartao_de_ClienteDataGridView);
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
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label telefLbl;
        private System.Windows.Forms.Label NomeLbl;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
    }
}
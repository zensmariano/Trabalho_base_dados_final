namespace trabalho_base_dados
{
    partial class Pessoal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pessoal));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cLIENTEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTENOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTENIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEDATA1CONTACTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nelsadaDataSet = new trabalho_base_dados.nelsadaDataSet();
            this.clienteTableAdapter = new trabalho_base_dados.nelsadaDataSetTableAdapters.ClienteTableAdapter();
            this.NomeLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.telefLbl = new System.Windows.Forms.Label();
            this.tabFuncionario = new System.Windows.Forms.TabControl();
            this.ClientesTab = new System.Windows.Forms.TabPage();
            this.FuncionariosTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.VerCliBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.FornecedoresTab = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nelsadaDataSet)).BeginInit();
            this.tabFuncionario.SuspendLayout();
            this.ClientesTab.SuspendLayout();
            this.FuncionariosTab.SuspendLayout();
            this.FornecedoresTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIENTEIDDataGridViewTextBoxColumn,
            this.cLIENTENOMEDataGridViewTextBoxColumn,
            this.cLIENTENIFDataGridViewTextBoxColumn,
            this.cLIENTEDATA1CONTACTODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1000, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // cLIENTEIDDataGridViewTextBoxColumn
            // 
            this.cLIENTEIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_ID";
            this.cLIENTEIDDataGridViewTextBoxColumn.HeaderText = "CLIENTE_ID";
            this.cLIENTEIDDataGridViewTextBoxColumn.Name = "cLIENTEIDDataGridViewTextBoxColumn";
            this.cLIENTEIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTENOMEDataGridViewTextBoxColumn
            // 
            this.cLIENTENOMEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_NOME";
            this.cLIENTENOMEDataGridViewTextBoxColumn.HeaderText = "CLIENTE_NOME";
            this.cLIENTENOMEDataGridViewTextBoxColumn.Name = "cLIENTENOMEDataGridViewTextBoxColumn";
            // 
            // cLIENTENIFDataGridViewTextBoxColumn
            // 
            this.cLIENTENIFDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_NIF";
            this.cLIENTENIFDataGridViewTextBoxColumn.HeaderText = "CLIENTE_NIF";
            this.cLIENTENIFDataGridViewTextBoxColumn.Name = "cLIENTENIFDataGridViewTextBoxColumn";
            // 
            // cLIENTEDATA1CONTACTODataGridViewTextBoxColumn
            // 
            this.cLIENTEDATA1CONTACTODataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_DATA_1_CONTACTO";
            this.cLIENTEDATA1CONTACTODataGridViewTextBoxColumn.HeaderText = "CLIENTE_DATA_1_CONTACTO";
            this.cLIENTEDATA1CONTACTODataGridViewTextBoxColumn.Name = "cLIENTEDATA1CONTACTODataGridViewTextBoxColumn";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.nelsadaDataSet;
            // 
            // nelsadaDataSet
            // 
            this.nelsadaDataSet.DataSetName = "nelsadaDataSet";
            this.nelsadaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // NomeLbl
            // 
            this.NomeLbl.AutoSize = true;
            this.NomeLbl.Location = new System.Drawing.Point(39, 321);
            this.NomeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NomeLbl.Name = "NomeLbl";
            this.NomeLbl.Size = new System.Drawing.Size(49, 17);
            this.NomeLbl.TabIndex = 4;
            this.NomeLbl.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nif:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 318);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(403, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 353);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(403, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(120, 385);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(403, 22);
            this.textBox5.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 389);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Morada:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(120, 417);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(144, 22);
            this.textBox6.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 421);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Codigo Postal:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 384);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(813, 353);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(617, 353);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 28);
            this.button3.TabIndex = 17;
            this.button3.Text = "Ver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(813, 385);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 28);
            this.button4.TabIndex = 18;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(617, 417);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 28);
            this.button5.TabIndex = 19;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(813, 416);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 28);
            this.button6.TabIndex = 20;
            this.button6.Text = "Retroceder";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(589, 391);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(363, 416);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(160, 22);
            this.textBox7.TabIndex = 23;
            // 
            // telefLbl
            // 
            this.telefLbl.AutoSize = true;
            this.telefLbl.Location = new System.Drawing.Point(285, 421);
            this.telefLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefLbl.Name = "telefLbl";
            this.telefLbl.Size = new System.Drawing.Size(68, 17);
            this.telefLbl.TabIndex = 22;
            this.telefLbl.Text = "Telefone:";
            // 
            // tabFuncionario
            // 
            this.tabFuncionario.Controls.Add(this.ClientesTab);
            this.tabFuncionario.Controls.Add(this.FuncionariosTab);
            this.tabFuncionario.Controls.Add(this.FornecedoresTab);
            this.tabFuncionario.Location = new System.Drawing.Point(26, 1);
            this.tabFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.tabFuncionario.Name = "tabFuncionario";
            this.tabFuncionario.SelectedIndex = 0;
            this.tabFuncionario.Size = new System.Drawing.Size(1029, 492);
            this.tabFuncionario.TabIndex = 24;
            // 
            // ClientesTab
            // 
            this.ClientesTab.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientesTab.Controls.Add(this.dataGridView1);
            this.ClientesTab.Controls.Add(this.textBox7);
            this.ClientesTab.Controls.Add(this.telefLbl);
            this.ClientesTab.Controls.Add(this.NomeLbl);
            this.ClientesTab.Controls.Add(this.checkBox1);
            this.ClientesTab.Controls.Add(this.label5);
            this.ClientesTab.Controls.Add(this.button6);
            this.ClientesTab.Controls.Add(this.button5);
            this.ClientesTab.Controls.Add(this.textBox2);
            this.ClientesTab.Controls.Add(this.button4);
            this.ClientesTab.Controls.Add(this.textBox3);
            this.ClientesTab.Controls.Add(this.button3);
            this.ClientesTab.Controls.Add(this.label2);
            this.ClientesTab.Controls.Add(this.button2);
            this.ClientesTab.Controls.Add(this.textBox5);
            this.ClientesTab.Controls.Add(this.button1);
            this.ClientesTab.Controls.Add(this.label6);
            this.ClientesTab.Controls.Add(this.textBox6);
            this.ClientesTab.Location = new System.Drawing.Point(4, 25);
            this.ClientesTab.Margin = new System.Windows.Forms.Padding(4);
            this.ClientesTab.Name = "ClientesTab";
            this.ClientesTab.Padding = new System.Windows.Forms.Padding(4);
            this.ClientesTab.Size = new System.Drawing.Size(1021, 463);
            this.ClientesTab.TabIndex = 0;
            this.ClientesTab.Text = "Clientes";
            // 
            // FuncionariosTab
            // 
            this.FuncionariosTab.BackColor = System.Drawing.Color.LightSteelBlue;
            this.FuncionariosTab.Controls.Add(this.textBox1);
            this.FuncionariosTab.Controls.Add(this.label1);
            this.FuncionariosTab.Controls.Add(this.label3);
            this.FuncionariosTab.Controls.Add(this.checkBox2);
            this.FuncionariosTab.Controls.Add(this.label4);
            this.FuncionariosTab.Controls.Add(this.button7);
            this.FuncionariosTab.Controls.Add(this.button8);
            this.FuncionariosTab.Controls.Add(this.textBox4);
            this.FuncionariosTab.Controls.Add(this.button9);
            this.FuncionariosTab.Controls.Add(this.textBox8);
            this.FuncionariosTab.Controls.Add(this.button10);
            this.FuncionariosTab.Controls.Add(this.label7);
            this.FuncionariosTab.Controls.Add(this.button11);
            this.FuncionariosTab.Controls.Add(this.textBox9);
            this.FuncionariosTab.Controls.Add(this.VerCliBtn);
            this.FuncionariosTab.Controls.Add(this.label8);
            this.FuncionariosTab.Controls.Add(this.textBox10);
            this.FuncionariosTab.Location = new System.Drawing.Point(4, 25);
            this.FuncionariosTab.Margin = new System.Windows.Forms.Padding(4);
            this.FuncionariosTab.Name = "FuncionariosTab";
            this.FuncionariosTab.Padding = new System.Windows.Forms.Padding(4);
            this.FuncionariosTab.Size = new System.Drawing.Size(1021, 463);
            this.FuncionariosTab.TabIndex = 1;
            this.FuncionariosTab.Text = "Funcionarios";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 423);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 428);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 329);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nome:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(589, 399);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 38;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nif:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(813, 423);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(188, 28);
            this.button7.TabIndex = 37;
            this.button7.Text = "Retroceder";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(617, 425);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(188, 28);
            this.button8.TabIndex = 36;
            this.button8.Text = "Cancelar";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 325);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(403, 22);
            this.textBox4.TabIndex = 26;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(813, 393);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(188, 28);
            this.button9.TabIndex = 35;
            this.button9.Text = "Eleminar";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(120, 361);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(403, 22);
            this.textBox8.TabIndex = 27;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(617, 393);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(188, 28);
            this.button10.TabIndex = 34;
            this.button10.Text = "Cartao Cliente";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Morada:";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(813, 361);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(188, 28);
            this.button11.TabIndex = 33;
            this.button11.Text = "Alterar";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(120, 393);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(403, 22);
            this.textBox9.TabIndex = 29;
            // 
            // VerCliBtn
            // 
            this.VerCliBtn.Location = new System.Drawing.Point(617, 362);
            this.VerCliBtn.Margin = new System.Windows.Forms.Padding(4);
            this.VerCliBtn.Name = "VerCliBtn";
            this.VerCliBtn.Size = new System.Drawing.Size(188, 28);
            this.VerCliBtn.TabIndex = 32;
            this.VerCliBtn.Text = "Adicionar";
            this.VerCliBtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 428);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Codigo Postal:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(120, 425);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(144, 22);
            this.textBox10.TabIndex = 31;
            // 
            // FornecedoresTab
            // 
            this.FornecedoresTab.BackColor = System.Drawing.Color.LightSteelBlue;
            this.FornecedoresTab.Controls.Add(this.label13);
            this.FornecedoresTab.Controls.Add(this.textBox11);
            this.FornecedoresTab.Controls.Add(this.label9);
            this.FornecedoresTab.Controls.Add(this.label10);
            this.FornecedoresTab.Controls.Add(this.checkBox3);
            this.FornecedoresTab.Controls.Add(this.button13);
            this.FornecedoresTab.Controls.Add(this.button14);
            this.FornecedoresTab.Controls.Add(this.textBox12);
            this.FornecedoresTab.Controls.Add(this.button15);
            this.FornecedoresTab.Controls.Add(this.textBox13);
            this.FornecedoresTab.Controls.Add(this.button16);
            this.FornecedoresTab.Controls.Add(this.label11);
            this.FornecedoresTab.Controls.Add(this.button17);
            this.FornecedoresTab.Controls.Add(this.textBox14);
            this.FornecedoresTab.Controls.Add(this.button18);
            this.FornecedoresTab.Controls.Add(this.label12);
            this.FornecedoresTab.Controls.Add(this.textBox15);
            this.FornecedoresTab.Location = new System.Drawing.Point(4, 25);
            this.FornecedoresTab.Margin = new System.Windows.Forms.Padding(4);
            this.FornecedoresTab.Name = "FornecedoresTab";
            this.FornecedoresTab.Padding = new System.Windows.Forms.Padding(4);
            this.FornecedoresTab.Size = new System.Drawing.Size(1021, 463);
            this.FornecedoresTab.TabIndex = 2;
            this.FornecedoresTab.Text = "Fornecedores";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 364);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 17);
            this.label13.TabIndex = 57;
            this.label13.Text = "Nif:";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(361, 423);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(160, 22);
            this.textBox11.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 428);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 55;
            this.label9.Text = "Telefone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 329);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Nome:";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(588, 399);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 54;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(812, 423);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(188, 28);
            this.button13.TabIndex = 53;
            this.button13.Text = "Retroceder";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(616, 425);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(188, 28);
            this.button14.TabIndex = 52;
            this.button14.Text = "Cancelar";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(119, 325);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(403, 22);
            this.textBox12.TabIndex = 42;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(812, 393);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(188, 28);
            this.button15.TabIndex = 51;
            this.button15.Text = "Eleminar";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(119, 361);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(403, 22);
            this.textBox13.TabIndex = 43;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(616, 393);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(188, 28);
            this.button16.TabIndex = 50;
            this.button16.Text = "Cartao Cliente";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 396);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Morada:";
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(812, 361);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(188, 28);
            this.button17.TabIndex = 49;
            this.button17.Text = "Alterar";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(119, 393);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(403, 22);
            this.textBox14.TabIndex = 45;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(616, 362);
            this.button18.Margin = new System.Windows.Forms.Padding(4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(188, 28);
            this.button18.TabIndex = 48;
            this.button18.Text = "Adicionar";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 428);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 46;
            this.label12.Text = "Codigo Postal:";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(119, 425);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(144, 22);
            this.textBox15.TabIndex = 47;
            // 
            // Pessoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1093, 602);
            this.Controls.Add(this.tabFuncionario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pessoal";
            this.Text = "Pessoal";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nelsadaDataSet)).EndInit();
            this.tabFuncionario.ResumeLayout(false);
            this.ClientesTab.ResumeLayout(false);
            this.ClientesTab.PerformLayout();
            this.FuncionariosTab.ResumeLayout(false);
            this.FuncionariosTab.PerformLayout();
            this.FornecedoresTab.ResumeLayout(false);
            this.FornecedoresTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private nelsadaDataSet nelsadaDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private nelsadaDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTENOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTENIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEDATA1CONTACTODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label NomeLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label telefLbl;
        private System.Windows.Forms.TabControl tabFuncionario;
        private System.Windows.Forms.TabPage ClientesTab;
        private System.Windows.Forms.TabPage FuncionariosTab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button VerCliBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TabPage FornecedoresTab;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label13;
    }
}
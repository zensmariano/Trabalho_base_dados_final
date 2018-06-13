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
            this.ClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.cLIENTEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTENOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTENIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.cLIENTEDATA1CONTACTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nelsadaDataSet = new trabalho_base_dados.nelsadaDataSet();
            this.clienteTableAdapter = new trabalho_base_dados.nelsadaDataSetTableAdapters.ClienteTableAdapter();
            this.NomeLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NomeTxtBox = new System.Windows.Forms.TextBox();
            this.NifTxtBox = new System.Windows.Forms.TextBox();
            this.MoradaTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CPTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.AltBtn = new System.Windows.Forms.Button();
            this.verBtn = new System.Windows.Forms.Button();
            this.ElmBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.RtrBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TlfTxtBox = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.ClienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nelsadaDataSet)).BeginInit();
            this.tabFuncionario.SuspendLayout();
            this.ClientesTab.SuspendLayout();
            this.FuncionariosTab.SuspendLayout();
            this.FornecedoresTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClienteDataGridView
            // 
            this.ClienteDataGridView.AutoGenerateColumns = false;
            this.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIENTEIDDataGridViewTextBoxColumn,
            this.cLIENTENOMEDataGridViewTextBoxColumn,
            this.cLIENTENIFDataGridViewTextBoxColumn,
            this.cLIENTEDATA1CONTACTODataGridViewTextBoxColumn});
            this.ClienteDataGridView.DataSource = this.clienteBindingSource;
            this.ClienteDataGridView.Location = new System.Drawing.Point(8, 6);
            this.ClienteDataGridView.Name = "ClienteDataGridView";
            this.ClienteDataGridView.Size = new System.Drawing.Size(750, 235);
            this.ClienteDataGridView.TabIndex = 0;
            this.ClienteDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClienteDataGridView_CellContentClick);
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
            this.NomeLbl.Location = new System.Drawing.Point(29, 261);
            this.NomeLbl.Name = "NomeLbl";
            this.NomeLbl.Size = new System.Drawing.Size(38, 13);
            this.NomeLbl.TabIndex = 4;
            this.NomeLbl.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nif:";
            // 
            // NomeTxtBox
            // 
            this.NomeTxtBox.Location = new System.Drawing.Point(90, 258);
            this.NomeTxtBox.Name = "NomeTxtBox";
            this.NomeTxtBox.Size = new System.Drawing.Size(303, 20);
            this.NomeTxtBox.TabIndex = 7;
            this.NomeTxtBox.TextChanged += new System.EventHandler(this.NometxtBox_TextChanged);
            // 
            // NifTxtBox
            // 
            this.NifTxtBox.Location = new System.Drawing.Point(90, 287);
            this.NifTxtBox.Name = "NifTxtBox";
            this.NifTxtBox.Size = new System.Drawing.Size(303, 20);
            this.NifTxtBox.TabIndex = 8;
            // 
            // MoradaTxtBox
            // 
            this.MoradaTxtBox.Location = new System.Drawing.Point(90, 313);
            this.MoradaTxtBox.Name = "MoradaTxtBox";
            this.MoradaTxtBox.Size = new System.Drawing.Size(303, 20);
            this.MoradaTxtBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Morada:";
            // 
            // CPTxtBox
            // 
            this.CPTxtBox.Location = new System.Drawing.Point(90, 339);
            this.CPTxtBox.Name = "CPTxtBox";
            this.CPTxtBox.Size = new System.Drawing.Size(109, 20);
            this.CPTxtBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Codigo Postal:";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(463, 312);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(141, 23);
            this.addBtn.TabIndex = 15;
            this.addBtn.Text = "Adicionar";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AltBtn
            // 
            this.AltBtn.Location = new System.Drawing.Point(610, 287);
            this.AltBtn.Name = "AltBtn";
            this.AltBtn.Size = new System.Drawing.Size(141, 23);
            this.AltBtn.TabIndex = 16;
            this.AltBtn.Text = "Alterar";
            this.AltBtn.UseVisualStyleBackColor = true;
            // 
            // verBtn
            // 
            this.verBtn.Location = new System.Drawing.Point(463, 287);
            this.verBtn.Name = "verBtn";
            this.verBtn.Size = new System.Drawing.Size(141, 23);
            this.verBtn.TabIndex = 17;
            this.verBtn.Text = "Ver";
            this.verBtn.UseVisualStyleBackColor = true;
            this.verBtn.Click += new System.EventHandler(this.verBtn_Click);
            // 
            // ElmBtn
            // 
            this.ElmBtn.Location = new System.Drawing.Point(610, 313);
            this.ElmBtn.Name = "ElmBtn";
            this.ElmBtn.Size = new System.Drawing.Size(141, 23);
            this.ElmBtn.TabIndex = 18;
            this.ElmBtn.Text = "Eliminar";
            this.ElmBtn.UseVisualStyleBackColor = true;
            this.ElmBtn.Click += new System.EventHandler(this.ElmBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(463, 339);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // RtrBtn
            // 
            this.RtrBtn.Location = new System.Drawing.Point(610, 338);
            this.RtrBtn.Name = "RtrBtn";
            this.RtrBtn.Size = new System.Drawing.Size(141, 23);
            this.RtrBtn.TabIndex = 20;
            this.RtrBtn.Text = "Retroceder";
            this.RtrBtn.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(442, 318);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TlfTxtBox
            // 
            this.TlfTxtBox.Location = new System.Drawing.Point(272, 338);
            this.TlfTxtBox.Name = "TlfTxtBox";
            this.TlfTxtBox.Size = new System.Drawing.Size(121, 20);
            this.TlfTxtBox.TabIndex = 23;
            // 
            // telefLbl
            // 
            this.telefLbl.AutoSize = true;
            this.telefLbl.Location = new System.Drawing.Point(214, 342);
            this.telefLbl.Name = "telefLbl";
            this.telefLbl.Size = new System.Drawing.Size(52, 13);
            this.telefLbl.TabIndex = 22;
            this.telefLbl.Text = "Telefone:";
            // 
            // tabFuncionario
            // 
            this.tabFuncionario.Controls.Add(this.ClientesTab);
            this.tabFuncionario.Controls.Add(this.FuncionariosTab);
            this.tabFuncionario.Controls.Add(this.FornecedoresTab);
            this.tabFuncionario.Location = new System.Drawing.Point(20, 1);
            this.tabFuncionario.Name = "tabFuncionario";
            this.tabFuncionario.SelectedIndex = 0;
            this.tabFuncionario.Size = new System.Drawing.Size(772, 400);
            this.tabFuncionario.TabIndex = 24;
            // 
            // ClientesTab
            // 
            this.ClientesTab.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientesTab.Controls.Add(this.ClienteDataGridView);
            this.ClientesTab.Controls.Add(this.TlfTxtBox);
            this.ClientesTab.Controls.Add(this.telefLbl);
            this.ClientesTab.Controls.Add(this.NomeLbl);
            this.ClientesTab.Controls.Add(this.checkBox1);
            this.ClientesTab.Controls.Add(this.label5);
            this.ClientesTab.Controls.Add(this.RtrBtn);
            this.ClientesTab.Controls.Add(this.button5);
            this.ClientesTab.Controls.Add(this.NomeTxtBox);
            this.ClientesTab.Controls.Add(this.ElmBtn);
            this.ClientesTab.Controls.Add(this.NifTxtBox);
            this.ClientesTab.Controls.Add(this.verBtn);
            this.ClientesTab.Controls.Add(this.label2);
            this.ClientesTab.Controls.Add(this.AltBtn);
            this.ClientesTab.Controls.Add(this.MoradaTxtBox);
            this.ClientesTab.Controls.Add(this.addBtn);
            this.ClientesTab.Controls.Add(this.label6);
            this.ClientesTab.Controls.Add(this.CPTxtBox);
            this.ClientesTab.Location = new System.Drawing.Point(4, 22);
            this.ClientesTab.Name = "ClientesTab";
            this.ClientesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ClientesTab.Size = new System.Drawing.Size(764, 374);
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
            this.FuncionariosTab.Location = new System.Drawing.Point(4, 22);
            this.FuncionariosTab.Name = "FuncionariosTab";
            this.FuncionariosTab.Padding = new System.Windows.Forms.Padding(3);
            this.FuncionariosTab.Size = new System.Drawing.Size(764, 374);
            this.FuncionariosTab.TabIndex = 1;
            this.FuncionariosTab.Text = "Funcionarios";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 344);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nome:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(442, 324);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 38;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nif:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(610, 344);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 23);
            this.button7.TabIndex = 37;
            this.button7.Text = "Retroceder";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(463, 345);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(141, 23);
            this.button8.TabIndex = 36;
            this.button8.Text = "Cancelar";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 264);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(303, 20);
            this.textBox4.TabIndex = 26;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(610, 319);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(141, 23);
            this.button9.TabIndex = 35;
            this.button9.Text = "Eleminar";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(90, 293);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(303, 20);
            this.textBox8.TabIndex = 27;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(463, 319);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(141, 23);
            this.button10.TabIndex = 34;
            this.button10.Text = "Cartao Cliente";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Morada:";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(610, 293);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(141, 23);
            this.button11.TabIndex = 33;
            this.button11.Text = "Alterar";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(90, 319);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(303, 20);
            this.textBox9.TabIndex = 29;
            // 
            // VerCliBtn
            // 
            this.VerCliBtn.Location = new System.Drawing.Point(463, 294);
            this.VerCliBtn.Name = "VerCliBtn";
            this.VerCliBtn.Size = new System.Drawing.Size(141, 23);
            this.VerCliBtn.TabIndex = 32;
            this.VerCliBtn.Text = "Adicionar";
            this.VerCliBtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Codigo Postal:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(90, 345);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(109, 20);
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
            this.FornecedoresTab.Location = new System.Drawing.Point(4, 22);
            this.FornecedoresTab.Name = "FornecedoresTab";
            this.FornecedoresTab.Padding = new System.Windows.Forms.Padding(3);
            this.FornecedoresTab.Size = new System.Drawing.Size(764, 374);
            this.FornecedoresTab.TabIndex = 2;
            this.FornecedoresTab.Text = "Fornecedores";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "Nif:";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(271, 344);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(121, 20);
            this.textBox11.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Telefone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Nome:";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(441, 324);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 54;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(609, 344);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(141, 23);
            this.button13.TabIndex = 53;
            this.button13.Text = "Retroceder";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(462, 345);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(141, 23);
            this.button14.TabIndex = 52;
            this.button14.Text = "Cancelar";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(89, 264);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(303, 20);
            this.textBox12.TabIndex = 42;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(609, 319);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(141, 23);
            this.button15.TabIndex = 51;
            this.button15.Text = "Eleminar";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(89, 293);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(303, 20);
            this.textBox13.TabIndex = 43;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(462, 319);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(141, 23);
            this.button16.TabIndex = 50;
            this.button16.Text = "Cartao Cliente";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Morada:";
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(609, 293);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(141, 23);
            this.button17.TabIndex = 49;
            this.button17.Text = "Alterar";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(89, 319);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(303, 20);
            this.textBox14.TabIndex = 45;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(462, 294);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(141, 23);
            this.button18.TabIndex = 48;
            this.button18.Text = "Adicionar";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Codigo Postal:";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(89, 345);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(109, 20);
            this.textBox15.TabIndex = 47;
            // 
            // Pessoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(820, 489);
            this.Controls.Add(this.tabFuncionario);
            this.Name = "Pessoal";
            this.Text = "Pessoal";
            ((System.ComponentModel.ISupportInitialize)(this.ClienteDataGridView)).EndInit();
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

        private System.Windows.Forms.DataGridView ClienteDataGridView;
        private nelsadaDataSet nelsadaDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private nelsadaDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTENOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTENIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEDATA1CONTACTODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label NomeLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NomeTxtBox;
        private System.Windows.Forms.TextBox NifTxtBox;
        private System.Windows.Forms.TextBox MoradaTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CPTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button AltBtn;
        private System.Windows.Forms.Button verBtn;
        private System.Windows.Forms.Button ElmBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button RtrBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox TlfTxtBox;
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
namespace StandAuto
{
    partial class frmAluguer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAluguer));
            this.standAutoDataSet = new StandAuto.StandAutoDataSet();
            this.aluguerSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aluguerSetTableAdapter = new StandAuto.StandAutoDataSetTableAdapters.AluguerSetTableAdapter();
            this.tableAdapterManager = new StandAuto.StandAutoDataSetTableAdapters.TableAdapterManager();
            this.aluguerSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.aluguerSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.DGV_Aluguer = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_IDSelecionado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Date_Inicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Date_Fim = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.txt_KMS = new System.Windows.Forms.TextBox();
            this.lbl_KMS = new System.Windows.Forms.Label();
            this.txt_IDCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_IDCarro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_SelecCliente = new System.Windows.Forms.Button();
            this.btn_SelecCarro = new System.Windows.Forms.Button();
            this.btn_MainAluguer = new System.Windows.Forms.Button();
            this.btn_MainEditar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.btn_MainPesquisar = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_DataPesquisa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.standAutoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerSetBindingNavigator)).BeginInit();
            this.aluguerSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Aluguer)).BeginInit();
            this.SuspendLayout();
            // 
            // standAutoDataSet
            // 
            this.standAutoDataSet.DataSetName = "StandAutoDataSet";
            this.standAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aluguerSetBindingSource
            // 
            this.aluguerSetBindingSource.DataMember = "AluguerSet";
            this.aluguerSetBindingSource.DataSource = this.standAutoDataSet;
            // 
            // aluguerSetTableAdapter
            // 
            this.aluguerSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AluguerSetTableAdapter = this.aluguerSetTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroSet_CarroAluguerTableAdapter = null;
            this.tableAdapterManager.CarroSet_CarroOficinaTableAdapter = null;
            this.tableAdapterManager.CarroSet_CarroVendaTableAdapter = null;
            this.tableAdapterManager.CarroSetTableAdapter = null;
            this.tableAdapterManager.ClienteSetTableAdapter = null;
            this.tableAdapterManager.ParcelaSetTableAdapter = null;
            this.tableAdapterManager.ServiçoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StandAuto.StandAutoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaSetTableAdapter = null;
            // 
            // aluguerSetBindingNavigator
            // 
            this.aluguerSetBindingNavigator.AddNewItem = null;
            this.aluguerSetBindingNavigator.BindingSource = this.aluguerSetBindingSource;
            this.aluguerSetBindingNavigator.CountItem = null;
            this.aluguerSetBindingNavigator.DeleteItem = null;
            this.aluguerSetBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.aluguerSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aluguerSetBindingNavigatorSaveItem});
            this.aluguerSetBindingNavigator.Location = new System.Drawing.Point(724, 13);
            this.aluguerSetBindingNavigator.MoveFirstItem = null;
            this.aluguerSetBindingNavigator.MoveLastItem = null;
            this.aluguerSetBindingNavigator.MoveNextItem = null;
            this.aluguerSetBindingNavigator.MovePreviousItem = null;
            this.aluguerSetBindingNavigator.Name = "aluguerSetBindingNavigator";
            this.aluguerSetBindingNavigator.PositionItem = null;
            this.aluguerSetBindingNavigator.Size = new System.Drawing.Size(33, 25);
            this.aluguerSetBindingNavigator.TabIndex = 0;
            this.aluguerSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // aluguerSetBindingNavigatorSaveItem
            // 
            this.aluguerSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aluguerSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aluguerSetBindingNavigatorSaveItem.Image")));
            this.aluguerSetBindingNavigatorSaveItem.Name = "aluguerSetBindingNavigatorSaveItem";
            this.aluguerSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aluguerSetBindingNavigatorSaveItem.Text = "Save Data";
            this.aluguerSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.aluguerSetBindingNavigatorSaveItem_Click);
            // 
            // DGV_Aluguer
            // 
            this.DGV_Aluguer.AutoGenerateColumns = false;
            this.DGV_Aluguer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Aluguer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.DGV_Aluguer.DataSource = this.aluguerSetBindingSource;
            this.DGV_Aluguer.Location = new System.Drawing.Point(11, 13);
            this.DGV_Aluguer.Name = "DGV_Aluguer";
            this.DGV_Aluguer.ReadOnly = true;
            this.DGV_Aluguer.Size = new System.Drawing.Size(543, 220);
            this.DGV_Aluguer.TabIndex = 1;
            this.DGV_Aluguer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aluguerSetDataGridView_CellClick);
            this.DGV_Aluguer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Aluguer_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdAluguer";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdAluguer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DataInicio";
            this.dataGridViewTextBoxColumn2.HeaderText = "DataInicio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataFim";
            this.dataGridViewTextBoxColumn3.HeaderText = "DataFim";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Kms";
            this.dataGridViewTextBoxColumn5.HeaderText = "Kms";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ClienteIdCliente";
            this.dataGridViewTextBoxColumn6.HeaderText = "ClienteIdCliente";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CarroAluguer_IdCarro";
            this.dataGridViewTextBoxColumn7.HeaderText = "CarroAluguer_IdCarro";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Aluguer:";
            // 
            // lbl_IDSelecionado
            // 
            this.lbl_IDSelecionado.AutoSize = true;
            this.lbl_IDSelecionado.Location = new System.Drawing.Point(626, 13);
            this.lbl_IDSelecionado.Name = "lbl_IDSelecionado";
            this.lbl_IDSelecionado.Size = new System.Drawing.Size(13, 13);
            this.lbl_IDSelecionado.TabIndex = 3;
            this.lbl_IDSelecionado.Text = "--";
            this.lbl_IDSelecionado.Click += new System.EventHandler(this.llb_IDSelecionado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Início:";
            // 
            // Date_Inicio
            // 
            this.Date_Inicio.Enabled = false;
            this.Date_Inicio.Location = new System.Drawing.Point(560, 54);
            this.Date_Inicio.Name = "Date_Inicio";
            this.Date_Inicio.Size = new System.Drawing.Size(200, 20);
            this.Date_Inicio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Fim:";
            // 
            // Date_Fim
            // 
            this.Date_Fim.Enabled = false;
            this.Date_Fim.Location = new System.Drawing.Point(561, 98);
            this.Date_Fim.Name = "Date_Fim";
            this.Date_Fim.Size = new System.Drawing.Size(200, 20);
            this.Date_Fim.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor:";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Enabled = false;
            this.txt_Valor.Location = new System.Drawing.Point(598, 129);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(58, 20);
            this.txt_Valor.TabIndex = 9;
            // 
            // txt_KMS
            // 
            this.txt_KMS.Enabled = false;
            this.txt_KMS.Location = new System.Drawing.Point(701, 129);
            this.txt_KMS.Name = "txt_KMS";
            this.txt_KMS.Size = new System.Drawing.Size(58, 20);
            this.txt_KMS.TabIndex = 11;
            // 
            // lbl_KMS
            // 
            this.lbl_KMS.AutoSize = true;
            this.lbl_KMS.Location = new System.Drawing.Point(662, 132);
            this.lbl_KMS.Name = "lbl_KMS";
            this.lbl_KMS.Size = new System.Drawing.Size(33, 13);
            this.lbl_KMS.TabIndex = 10;
            this.lbl_KMS.Text = "KMS:";
            // 
            // txt_IDCliente
            // 
            this.txt_IDCliente.Location = new System.Drawing.Point(623, 155);
            this.txt_IDCliente.Name = "txt_IDCliente";
            this.txt_IDCliente.ReadOnly = true;
            this.txt_IDCliente.Size = new System.Drawing.Size(33, 20);
            this.txt_IDCliente.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID Cliente:";
            // 
            // txt_IDCarro
            // 
            this.txt_IDCarro.Location = new System.Drawing.Point(724, 155);
            this.txt_IDCarro.Name = "txt_IDCarro";
            this.txt_IDCarro.ReadOnly = true;
            this.txt_IDCarro.Size = new System.Drawing.Size(33, 20);
            this.txt_IDCarro.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(662, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID Carro";
            // 
            // btn_SelecCliente
            // 
            this.btn_SelecCliente.Enabled = false;
            this.btn_SelecCliente.Location = new System.Drawing.Point(564, 181);
            this.btn_SelecCliente.Name = "btn_SelecCliente";
            this.btn_SelecCliente.Size = new System.Drawing.Size(92, 52);
            this.btn_SelecCliente.TabIndex = 16;
            this.btn_SelecCliente.Text = "Selecionar Cliente";
            this.btn_SelecCliente.UseVisualStyleBackColor = true;
            // 
            // btn_SelecCarro
            // 
            this.btn_SelecCarro.Enabled = false;
            this.btn_SelecCarro.Location = new System.Drawing.Point(665, 181);
            this.btn_SelecCarro.Name = "btn_SelecCarro";
            this.btn_SelecCarro.Size = new System.Drawing.Size(92, 52);
            this.btn_SelecCarro.TabIndex = 17;
            this.btn_SelecCarro.Text = "Selecionar Carro";
            this.btn_SelecCarro.UseVisualStyleBackColor = true;
            // 
            // btn_MainAluguer
            // 
            this.btn_MainAluguer.Location = new System.Drawing.Point(110, 239);
            this.btn_MainAluguer.Name = "btn_MainAluguer";
            this.btn_MainAluguer.Size = new System.Drawing.Size(92, 52);
            this.btn_MainAluguer.TabIndex = 18;
            this.btn_MainAluguer.Text = "Adicionar Aluguer";
            this.btn_MainAluguer.UseVisualStyleBackColor = true;
            // 
            // btn_MainEditar
            // 
            this.btn_MainEditar.Enabled = false;
            this.btn_MainEditar.Location = new System.Drawing.Point(208, 239);
            this.btn_MainEditar.Name = "btn_MainEditar";
            this.btn_MainEditar.Size = new System.Drawing.Size(92, 52);
            this.btn_MainEditar.TabIndex = 19;
            this.btn_MainEditar.Text = "Editar Aluguer Selecionado";
            this.btn_MainEditar.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.Location = new System.Drawing.Point(524, 247);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 37);
            this.btn_Editar.TabIndex = 20;
            this.btn_Editar.Text = "Confirmar Edição";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Enabled = false;
            this.btn_Pesquisar.Location = new System.Drawing.Point(605, 247);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(75, 37);
            this.btn_Pesquisar.TabIndex = 21;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            // 
            // btn_MainPesquisar
            // 
            this.btn_MainPesquisar.Location = new System.Drawing.Point(12, 239);
            this.btn_MainPesquisar.Name = "btn_MainPesquisar";
            this.btn_MainPesquisar.Size = new System.Drawing.Size(92, 52);
            this.btn_MainPesquisar.TabIndex = 22;
            this.btn_MainPesquisar.Text = "Pesquisar Aluguer";
            this.btn_MainPesquisar.UseVisualStyleBackColor = true;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Enabled = false;
            this.btn_Adicionar.Location = new System.Drawing.Point(686, 247);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 37);
            this.btn_Adicionar.TabIndex = 23;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Modo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Pesquisa/Adicionar/Editar";
            // 
            // lbl_DataPesquisa
            // 
            this.lbl_DataPesquisa.AutoSize = true;
            this.lbl_DataPesquisa.Location = new System.Drawing.Point(676, 82);
            this.lbl_DataPesquisa.Name = "lbl_DataPesquisa";
            this.lbl_DataPesquisa.Size = new System.Drawing.Size(32, 13);
            this.lbl_DataPesquisa.TabIndex = 26;
            this.lbl_DataPesquisa.Text = "Entre";
            this.lbl_DataPesquisa.Visible = false;
            // 
            // frmAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 291);
            this.Controls.Add(this.lbl_DataPesquisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.btn_MainPesquisar);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_MainEditar);
            this.Controls.Add(this.btn_MainAluguer);
            this.Controls.Add(this.btn_SelecCarro);
            this.Controls.Add(this.btn_SelecCliente);
            this.Controls.Add(this.txt_IDCarro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_IDCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_KMS);
            this.Controls.Add(this.lbl_KMS);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date_Fim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Date_Inicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_IDSelecionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Aluguer);
            this.Controls.Add(this.aluguerSetBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAluguer";
            this.Text = "Aluguer";
            this.Load += new System.EventHandler(this.frmAluguer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.standAutoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerSetBindingNavigator)).EndInit();
            this.aluguerSetBindingNavigator.ResumeLayout(false);
            this.aluguerSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Aluguer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StandAutoDataSet standAutoDataSet;
        private System.Windows.Forms.BindingSource aluguerSetBindingSource;
        private StandAutoDataSetTableAdapters.AluguerSetTableAdapter aluguerSetTableAdapter;
        private StandAutoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aluguerSetBindingNavigator;
        private System.Windows.Forms.ToolStripButton aluguerSetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView DGV_Aluguer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_IDSelecionado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Date_Inicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Date_Fim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.TextBox txt_KMS;
        private System.Windows.Forms.Label lbl_KMS;
        private System.Windows.Forms.TextBox txt_IDCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_IDCarro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_SelecCliente;
        private System.Windows.Forms.Button btn_SelecCarro;
        private System.Windows.Forms.Button btn_MainAluguer;
        private System.Windows.Forms.Button btn_MainEditar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Button btn_MainPesquisar;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_DataPesquisa;
    }
}
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
            System.Windows.Forms.Label kmsLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label dataInicioLabel;
            System.Windows.Forms.Label idAluguerLabel;
            System.Windows.Forms.Label dataFimLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAluguer));
            this.txt_IDCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_IDCarro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_SelecCliente = new System.Windows.Forms.Button();
            this.btn_SelecCarro = new System.Windows.Forms.Button();
            this.btn_MainAluguer = new System.Windows.Forms.Button();
            this.btn_MainEditar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_MainPesquisar = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Modo = new System.Windows.Forms.Label();
            this.aluguerSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.standAutoDataSet = new StandAuto.StandAutoDataSet();
            this.aluguerSetTableAdapter = new StandAuto.StandAutoDataSetTableAdapters.AluguerSetTableAdapter();
            this.tableAdapterManager = new StandAuto.StandAutoDataSetTableAdapters.TableAdapterManager();
            this.kmsTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.dataInicioTextBox = new System.Windows.Forms.TextBox();
            this.idAluguerTextBox = new System.Windows.Forms.TextBox();
            this.dataFimTextBox = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Pesquisa = new System.Windows.Forms.ComboBox();
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aluguerSetDataGridView = new System.Windows.Forms.DataGridView();
            kmsLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            dataInicioLabel = new System.Windows.Forms.Label();
            idAluguerLabel = new System.Windows.Forms.Label();
            dataFimLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standAutoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kmsLabel
            // 
            kmsLabel.AutoSize = true;
            kmsLabel.Location = new System.Drawing.Point(651, 96);
            kmsLabel.Name = "kmsLabel";
            kmsLabel.Size = new System.Drawing.Size(30, 13);
            kmsLabel.TabIndex = 26;
            kmsLabel.Text = "Kms:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(561, 96);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 27;
            valorLabel.Text = "Valor:";
            // 
            // dataInicioLabel
            // 
            dataInicioLabel.AutoSize = true;
            dataInicioLabel.Location = new System.Drawing.Point(561, 41);
            dataInicioLabel.Name = "dataInicioLabel";
            dataInicioLabel.Size = new System.Drawing.Size(61, 13);
            dataInicioLabel.TabIndex = 29;
            dataInicioLabel.Text = "Data Inicio:";
            // 
            // idAluguerLabel
            // 
            idAluguerLabel.AutoSize = true;
            idAluguerLabel.Location = new System.Drawing.Point(561, 15);
            idAluguerLabel.Name = "idAluguerLabel";
            idAluguerLabel.Size = new System.Drawing.Size(58, 13);
            idAluguerLabel.TabIndex = 30;
            idAluguerLabel.Text = "Id Aluguer:";
            // 
            // dataFimLabel1
            // 
            dataFimLabel1.AutoSize = true;
            dataFimLabel1.Location = new System.Drawing.Point(561, 67);
            dataFimLabel1.Name = "dataFimLabel1";
            dataFimLabel1.Size = new System.Drawing.Size(52, 13);
            dataFimLabel1.TabIndex = 31;
            dataFimLabel1.Text = "Data Fim:";
            // 
            // txt_IDCliente
            // 
            this.txt_IDCliente.Location = new System.Drawing.Point(618, 120);
            this.txt_IDCliente.Name = "txt_IDCliente";
            this.txt_IDCliente.ReadOnly = true;
            this.txt_IDCliente.Size = new System.Drawing.Size(27, 20);
            this.txt_IDCliente.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID Cliente:";
            // 
            // txt_IDCarro
            // 
            this.txt_IDCarro.Location = new System.Drawing.Point(709, 120);
            this.txt_IDCarro.Name = "txt_IDCarro";
            this.txt_IDCarro.ReadOnly = true;
            this.txt_IDCarro.Size = new System.Drawing.Size(27, 20);
            this.txt_IDCarro.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID Carro:";
            // 
            // btn_SelecCliente
            // 
            this.btn_SelecCliente.Enabled = false;
            this.btn_SelecCliente.Location = new System.Drawing.Point(564, 146);
            this.btn_SelecCliente.Name = "btn_SelecCliente";
            this.btn_SelecCliente.Size = new System.Drawing.Size(86, 37);
            this.btn_SelecCliente.TabIndex = 16;
            this.btn_SelecCliente.Text = "Selecionar Cliente";
            this.btn_SelecCliente.UseVisualStyleBackColor = true;
            // 
            // btn_SelecCarro
            // 
            this.btn_SelecCarro.Enabled = false;
            this.btn_SelecCarro.Location = new System.Drawing.Point(654, 146);
            this.btn_SelecCarro.Name = "btn_SelecCarro";
            this.btn_SelecCarro.Size = new System.Drawing.Size(82, 37);
            this.btn_SelecCarro.TabIndex = 17;
            this.btn_SelecCarro.Text = "Selecionar Carro";
            this.btn_SelecCarro.UseVisualStyleBackColor = true;
            // 
            // btn_MainAluguer
            // 
            this.btn_MainAluguer.Location = new System.Drawing.Point(110, 254);
            this.btn_MainAluguer.Name = "btn_MainAluguer";
            this.btn_MainAluguer.Size = new System.Drawing.Size(92, 41);
            this.btn_MainAluguer.TabIndex = 18;
            this.btn_MainAluguer.Text = "Adicionar Aluguer";
            this.btn_MainAluguer.UseVisualStyleBackColor = true;
            this.btn_MainAluguer.Click += new System.EventHandler(this.btn_MainAluguer_Click);
            // 
            // btn_MainEditar
            // 
            this.btn_MainEditar.Enabled = false;
            this.btn_MainEditar.Location = new System.Drawing.Point(208, 253);
            this.btn_MainEditar.Name = "btn_MainEditar";
            this.btn_MainEditar.Size = new System.Drawing.Size(92, 42);
            this.btn_MainEditar.TabIndex = 19;
            this.btn_MainEditar.Text = "Editar Aluguer Selecionado";
            this.btn_MainEditar.UseVisualStyleBackColor = true;
            this.btn_MainEditar.Click += new System.EventHandler(this.btn_MainEditar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.Location = new System.Drawing.Point(564, 275);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 20);
            this.btn_Editar.TabIndex = 20;
            this.btn_Editar.Text = "Confirmar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_MainPesquisar
            // 
            this.btn_MainPesquisar.Location = new System.Drawing.Point(12, 254);
            this.btn_MainPesquisar.Name = "btn_MainPesquisar";
            this.btn_MainPesquisar.Size = new System.Drawing.Size(92, 41);
            this.btn_MainPesquisar.TabIndex = 22;
            this.btn_MainPesquisar.Text = "Pesquisar Aluguer";
            this.btn_MainPesquisar.UseVisualStyleBackColor = true;
            this.btn_MainPesquisar.Click += new System.EventHandler(this.btn_MainPesquisar_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Enabled = false;
            this.btn_Adicionar.Location = new System.Drawing.Point(661, 275);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 20);
            this.btn_Adicionar.TabIndex = 23;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Modo:";
            // 
            // lbl_Modo
            // 
            this.lbl_Modo.AutoSize = true;
            this.lbl_Modo.Location = new System.Drawing.Point(384, 268);
            this.lbl_Modo.Name = "lbl_Modo";
            this.lbl_Modo.Size = new System.Drawing.Size(16, 13);
            this.lbl_Modo.TabIndex = 25;
            this.lbl_Modo.Text = "---";
            // 
            // aluguerSetBindingSource
            // 
            this.aluguerSetBindingSource.DataMember = "AluguerSet";
            this.aluguerSetBindingSource.DataSource = this.standAutoDataSet;
            // 
            // standAutoDataSet
            // 
            this.standAutoDataSet.DataSetName = "StandAutoDataSet";
            this.standAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // kmsTextBox
            // 
            this.kmsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aluguerSetBindingSource, "Kms", true));
            this.kmsTextBox.Location = new System.Drawing.Point(703, 93);
            this.kmsTextBox.Name = "kmsTextBox";
            this.kmsTextBox.ReadOnly = true;
            this.kmsTextBox.Size = new System.Drawing.Size(33, 20);
            this.kmsTextBox.TabIndex = 27;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aluguerSetBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(612, 93);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.ReadOnly = true;
            this.valorTextBox.Size = new System.Drawing.Size(33, 20);
            this.valorTextBox.TabIndex = 28;
            // 
            // dataInicioTextBox
            // 
            this.dataInicioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aluguerSetBindingSource, "DataInicio", true));
            this.dataInicioTextBox.Location = new System.Drawing.Point(623, 38);
            this.dataInicioTextBox.Name = "dataInicioTextBox";
            this.dataInicioTextBox.ReadOnly = true;
            this.dataInicioTextBox.Size = new System.Drawing.Size(113, 20);
            this.dataInicioTextBox.TabIndex = 30;
            // 
            // idAluguerTextBox
            // 
            this.idAluguerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aluguerSetBindingSource, "IdAluguer", true));
            this.idAluguerTextBox.Location = new System.Drawing.Point(623, 12);
            this.idAluguerTextBox.Name = "idAluguerTextBox";
            this.idAluguerTextBox.ReadOnly = true;
            this.idAluguerTextBox.Size = new System.Drawing.Size(113, 20);
            this.idAluguerTextBox.TabIndex = 31;
            this.idAluguerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataFimTextBox
            // 
            this.dataFimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aluguerSetBindingSource, "DataFim", true));
            this.dataFimTextBox.Location = new System.Drawing.Point(623, 64);
            this.dataFimTextBox.Name = "dataFimTextBox";
            this.dataFimTextBox.ReadOnly = true;
            this.dataFimTextBox.Size = new System.Drawing.Size(113, 20);
            this.dataFimTextBox.TabIndex = 32;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Enabled = false;
            this.btn_Cancelar.Location = new System.Drawing.Point(564, 246);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 20);
            this.btn_Cancelar.TabIndex = 33;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Enabled = false;
            this.btn_Pesquisar.Location = new System.Drawing.Point(661, 246);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(75, 22);
            this.btn_Pesquisar.TabIndex = 21;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Pesquisar por:";
            // 
            // cb_Pesquisa
            // 
            this.cb_Pesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Pesquisa.Enabled = false;
            this.cb_Pesquisa.FormattingEnabled = true;
            this.cb_Pesquisa.Location = new System.Drawing.Point(637, 193);
            this.cb_Pesquisa.Name = "cb_Pesquisa";
            this.cb_Pesquisa.Size = new System.Drawing.Size(99, 21);
            this.cb_Pesquisa.TabIndex = 35;
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Location = new System.Drawing.Point(561, 220);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.ReadOnly = true;
            this.txt_Pesquisa.Size = new System.Drawing.Size(175, 20);
            this.txt_Pesquisa.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CarroAluguer_IdCarro";
            this.dataGridViewTextBoxColumn7.HeaderText = "CarroAluguer_IdCarro";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ClienteIdCliente";
            this.dataGridViewTextBoxColumn6.HeaderText = "ClienteIdCliente";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Kms";
            this.dataGridViewTextBoxColumn5.HeaderText = "Kms";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataFim";
            this.dataGridViewTextBoxColumn3.HeaderText = "DataFim";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DataInicio";
            this.dataGridViewTextBoxColumn2.HeaderText = "DataInicio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdAluguer";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdAluguer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // aluguerSetDataGridView
            // 
            this.aluguerSetDataGridView.AutoGenerateColumns = false;
            this.aluguerSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aluguerSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.aluguerSetDataGridView.DataSource = this.aluguerSetBindingSource;
            this.aluguerSetDataGridView.Location = new System.Drawing.Point(0, 3);
            this.aluguerSetDataGridView.Name = "aluguerSetDataGridView";
            this.aluguerSetDataGridView.Size = new System.Drawing.Size(543, 244);
            this.aluguerSetDataGridView.TabIndex = 36;
            // 
            // frmAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 315);
            this.Controls.Add(this.aluguerSetDataGridView);
            this.Controls.Add(this.txt_Pesquisa);
            this.Controls.Add(this.cb_Pesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(dataFimLabel1);
            this.Controls.Add(this.dataFimTextBox);
            this.Controls.Add(idAluguerLabel);
            this.Controls.Add(this.idAluguerTextBox);
            this.Controls.Add(dataInicioLabel);
            this.Controls.Add(this.dataInicioTextBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(kmsLabel);
            this.Controls.Add(this.kmsTextBox);
            this.Controls.Add(this.lbl_Modo);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAluguer";
            this.Text = "Aluguer";
            this.Load += new System.EventHandler(this.frmAluguer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aluguerSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standAutoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerSetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StandAutoDataSet standAutoDataSet;
        private System.Windows.Forms.BindingSource aluguerSetBindingSource;
        private StandAutoDataSetTableAdapters.AluguerSetTableAdapter aluguerSetTableAdapter;
        private StandAutoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_IDCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_IDCarro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_SelecCliente;
        private System.Windows.Forms.Button btn_SelecCarro;
        private System.Windows.Forms.Button btn_MainAluguer;
        private System.Windows.Forms.Button btn_MainEditar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_MainPesquisar;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Modo;
        private System.Windows.Forms.TextBox kmsTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox dataInicioTextBox;
        private System.Windows.Forms.TextBox idAluguerTextBox;
        private System.Windows.Forms.TextBox dataFimTextBox;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Pesquisa;
        private System.Windows.Forms.TextBox txt_Pesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView aluguerSetDataGridView;
    }
}
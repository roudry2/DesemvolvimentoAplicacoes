namespace StandAuto
{
    partial class frmAddCarroOficina
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
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label kmsLabel;
            System.Windows.Forms.Label clienteIdClienteLabel;
            System.Windows.Forms.Label idCarroLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCarroOficina));
            this.standAutoDataSet = new StandAuto.StandAutoDataSet();
            this.carroSet_CarroOficinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroSet_CarroOficinaTableAdapter = new StandAuto.StandAutoDataSetTableAdapters.CarroSet_CarroOficinaTableAdapter();
            this.tableAdapterManager = new StandAuto.StandAutoDataSetTableAdapters.TableAdapterManager();
            this.carroSet_CarroOficinaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.carroSet_CarroOficinaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.carroSet_CarroOficinaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnselecionar = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.kmsTextBox = new System.Windows.Forms.TextBox();
            this.clienteIdClienteTextBox = new System.Windows.Forms.TextBox();
            this.idCarroTextBox = new System.Windows.Forms.TextBox();
            matriculaLabel = new System.Windows.Forms.Label();
            kmsLabel = new System.Windows.Forms.Label();
            clienteIdClienteLabel = new System.Windows.Forms.Label();
            idCarroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.standAutoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroSet_CarroOficinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroSet_CarroOficinaBindingNavigator)).BeginInit();
            this.carroSet_CarroOficinaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroSet_CarroOficinaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(483, 65);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(53, 13);
            matriculaLabel.TabIndex = 4;
            matriculaLabel.Text = "Matricula:";
            // 
            // kmsLabel
            // 
            kmsLabel.AutoSize = true;
            kmsLabel.Location = new System.Drawing.Point(483, 91);
            kmsLabel.Name = "kmsLabel";
            kmsLabel.Size = new System.Drawing.Size(30, 13);
            kmsLabel.TabIndex = 6;
            kmsLabel.Text = "Kms:";
            // 
            // clienteIdClienteLabel
            // 
            clienteIdClienteLabel.AutoSize = true;
            clienteIdClienteLabel.Location = new System.Drawing.Point(483, 117);
            clienteIdClienteLabel.Name = "clienteIdClienteLabel";
            clienteIdClienteLabel.Size = new System.Drawing.Size(89, 13);
            clienteIdClienteLabel.TabIndex = 8;
            clienteIdClienteLabel.Text = "Cliente Id Cliente:";
            // 
            // idCarroLabel
            // 
            idCarroLabel.AutoSize = true;
            idCarroLabel.Location = new System.Drawing.Point(483, 39);
            idCarroLabel.Name = "idCarroLabel";
            idCarroLabel.Size = new System.Drawing.Size(47, 13);
            idCarroLabel.TabIndex = 10;
            idCarroLabel.Text = "Id Carro:";
            // 
            // standAutoDataSet
            // 
            this.standAutoDataSet.DataSetName = "StandAutoDataSet";
            this.standAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carroSet_CarroOficinaBindingSource
            // 
            this.carroSet_CarroOficinaBindingSource.DataMember = "CarroSet_CarroOficina";
            this.carroSet_CarroOficinaBindingSource.DataSource = this.standAutoDataSet;
            // 
            // carroSet_CarroOficinaTableAdapter
            // 
            this.carroSet_CarroOficinaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AluguerSetTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroSet_CarroAluguerTableAdapter = null;
            this.tableAdapterManager.CarroSet_CarroOficinaTableAdapter = this.carroSet_CarroOficinaTableAdapter;
            this.tableAdapterManager.CarroSet_CarroVendaTableAdapter = null;
            this.tableAdapterManager.CarroSetTableAdapter = null;
            this.tableAdapterManager.ClienteSetTableAdapter = null;
            this.tableAdapterManager.ParcelaSetTableAdapter = null;
            this.tableAdapterManager.ServiçoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StandAuto.StandAutoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaSetTableAdapter = null;
            // 
            // carroSet_CarroOficinaBindingNavigator
            // 
            this.carroSet_CarroOficinaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carroSet_CarroOficinaBindingNavigator.BindingSource = this.carroSet_CarroOficinaBindingSource;
            this.carroSet_CarroOficinaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carroSet_CarroOficinaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carroSet_CarroOficinaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.carroSet_CarroOficinaBindingNavigatorSaveItem});
            this.carroSet_CarroOficinaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carroSet_CarroOficinaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carroSet_CarroOficinaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carroSet_CarroOficinaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carroSet_CarroOficinaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carroSet_CarroOficinaBindingNavigator.Name = "carroSet_CarroOficinaBindingNavigator";
            this.carroSet_CarroOficinaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carroSet_CarroOficinaBindingNavigator.Size = new System.Drawing.Size(734, 25);
            this.carroSet_CarroOficinaBindingNavigator.TabIndex = 0;
            this.carroSet_CarroOficinaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // carroSet_CarroOficinaBindingNavigatorSaveItem
            // 
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carroSet_CarroOficinaBindingNavigatorSaveItem.Image")));
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.Name = "carroSet_CarroOficinaBindingNavigatorSaveItem";
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.Text = "Save Data";
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.Click += new System.EventHandler(this.carroSet_CarroOficinaBindingNavigatorSaveItem_Click_1);
            // 
            // carroSet_CarroOficinaDataGridView
            // 
            this.carroSet_CarroOficinaDataGridView.AutoGenerateColumns = false;
            this.carroSet_CarroOficinaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carroSet_CarroOficinaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.carroSet_CarroOficinaDataGridView.DataSource = this.carroSet_CarroOficinaBindingSource;
            this.carroSet_CarroOficinaDataGridView.Location = new System.Drawing.Point(12, 28);
            this.carroSet_CarroOficinaDataGridView.Name = "carroSet_CarroOficinaDataGridView";
            this.carroSet_CarroOficinaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carroSet_CarroOficinaDataGridView.Size = new System.Drawing.Size(453, 220);
            this.carroSet_CarroOficinaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Matricula";
            this.dataGridViewTextBoxColumn1.HeaderText = "Matricula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Kms";
            this.dataGridViewTextBoxColumn2.HeaderText = "Kms";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ClienteIdCliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "ClienteIdCliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdCarro";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdCarro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnselecionar
            // 
            this.btnselecionar.Location = new System.Drawing.Point(390, 278);
            this.btnselecionar.Name = "btnselecionar";
            this.btnselecionar.Size = new System.Drawing.Size(75, 23);
            this.btnselecionar.TabIndex = 2;
            this.btnselecionar.Text = "Selecionar";
            this.btnselecionar.UseVisualStyleBackColor = true;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(12, 278);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 3;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroSet_CarroOficinaBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(578, 62);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(100, 20);
            this.matriculaTextBox.TabIndex = 5;
            // 
            // kmsTextBox
            // 
            this.kmsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroSet_CarroOficinaBindingSource, "Kms", true));
            this.kmsTextBox.Location = new System.Drawing.Point(578, 88);
            this.kmsTextBox.Name = "kmsTextBox";
            this.kmsTextBox.Size = new System.Drawing.Size(100, 20);
            this.kmsTextBox.TabIndex = 7;
            // 
            // clienteIdClienteTextBox
            // 
            this.clienteIdClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroSet_CarroOficinaBindingSource, "ClienteIdCliente", true));
            this.clienteIdClienteTextBox.Location = new System.Drawing.Point(578, 114);
            this.clienteIdClienteTextBox.Name = "clienteIdClienteTextBox";
            this.clienteIdClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.clienteIdClienteTextBox.TabIndex = 9;
            // 
            // idCarroTextBox
            // 
            this.idCarroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroSet_CarroOficinaBindingSource, "IdCarro", true));
            this.idCarroTextBox.Location = new System.Drawing.Point(578, 36);
            this.idCarroTextBox.Name = "idCarroTextBox";
            this.idCarroTextBox.Size = new System.Drawing.Size(100, 20);
            this.idCarroTextBox.TabIndex = 11;
            // 
            // frmAddCarroOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 321);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(kmsLabel);
            this.Controls.Add(this.kmsTextBox);
            this.Controls.Add(clienteIdClienteLabel);
            this.Controls.Add(this.clienteIdClienteTextBox);
            this.Controls.Add(idCarroLabel);
            this.Controls.Add(this.idCarroTextBox);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.btnselecionar);
            this.Controls.Add(this.carroSet_CarroOficinaDataGridView);
            this.Controls.Add(this.carroSet_CarroOficinaBindingNavigator);
            this.Name = "frmAddCarroOficina";
            this.Text = "frmAddCarroOficina";
            this.Load += new System.EventHandler(this.frmAddCarroOficina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.standAutoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroSet_CarroOficinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroSet_CarroOficinaBindingNavigator)).EndInit();
            this.carroSet_CarroOficinaBindingNavigator.ResumeLayout(false);
            this.carroSet_CarroOficinaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroSet_CarroOficinaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StandAutoDataSet standAutoDataSet;
        private System.Windows.Forms.BindingSource carroSet_CarroOficinaBindingSource;
        private StandAutoDataSetTableAdapters.CarroSet_CarroOficinaTableAdapter carroSet_CarroOficinaTableAdapter;
        private StandAutoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carroSet_CarroOficinaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton carroSet_CarroOficinaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView carroSet_CarroOficinaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnselecionar;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox kmsTextBox;
        private System.Windows.Forms.TextBox clienteIdClienteTextBox;
        private System.Windows.Forms.TextBox idCarroTextBox;
    }
}
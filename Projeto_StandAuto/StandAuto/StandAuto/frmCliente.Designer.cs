namespace StandAuto
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            System.Windows.Forms.Label contactoLabel;
            System.Windows.Forms.Label moradaLabel;
            System.Windows.Forms.Label nIFLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label idClienteLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.standAutoDataSet = new StandAuto.StandAutoDataSet();
            this.clienteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteSetTableAdapter = new StandAuto.StandAutoDataSetTableAdapters.ClienteSetTableAdapter();
            this.tableAdapterManager = new StandAuto.StandAutoDataSetTableAdapters.TableAdapterManager();
            this.clienteSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.clienteSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clienteSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.nIFTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            contactoLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            nIFLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standAutoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteSetBindingNavigator)).BeginInit();
            this.clienteSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteSetDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltro);
            this.groupBox1.Controls.Add(this.txtFiltrar);
            this.groupBox1.Controls.Add(this.clienteSetDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(306, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 391);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Clientes";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(176, 18);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(47, 23);
            this.btnFiltro.TabIndex = 2;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(1, 20);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(165, 20);
            this.txtFiltrar.TabIndex = 1;
            // 
            // standAutoDataSet
            // 
            this.standAutoDataSet.DataSetName = "StandAutoDataSet";
            this.standAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteSetBindingSource
            // 
            this.clienteSetBindingSource.DataMember = "ClienteSet";
            this.clienteSetBindingSource.DataSource = this.standAutoDataSet;
            // 
            // clienteSetTableAdapter
            // 
            this.clienteSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AluguerSetTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroSet_CarroAluguerTableAdapter = null;
            this.tableAdapterManager.CarroSet_CarroOficinaTableAdapter = null;
            this.tableAdapterManager.CarroSet_CarroVendaTableAdapter = null;
            this.tableAdapterManager.CarroSetTableAdapter = null;
            this.tableAdapterManager.ClienteSetTableAdapter = this.clienteSetTableAdapter;
            this.tableAdapterManager.ParcelaSetTableAdapter = null;
            this.tableAdapterManager.ServiçoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StandAuto.StandAutoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaSetTableAdapter = null;
            // 
            // clienteSetBindingNavigator
            // 
            this.clienteSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clienteSetBindingNavigator.BindingSource = this.clienteSetBindingSource;
            this.clienteSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clienteSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clienteSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clienteSetBindingNavigatorSaveItem});
            this.clienteSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteSetBindingNavigator.Name = "clienteSetBindingNavigator";
            this.clienteSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteSetBindingNavigator.Size = new System.Drawing.Size(942, 25);
            this.clienteSetBindingNavigator.TabIndex = 3;
            this.clienteSetBindingNavigator.Text = "bindingNavigator1";
            this.clienteSetBindingNavigator.RefreshItems += new System.EventHandler(this.clienteSetBindingNavigator_RefreshItems);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // clienteSetBindingNavigatorSaveItem
            // 
            this.clienteSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clienteSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteSetBindingNavigatorSaveItem.Image")));
            this.clienteSetBindingNavigatorSaveItem.Name = "clienteSetBindingNavigatorSaveItem";
            this.clienteSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clienteSetBindingNavigatorSaveItem.Text = "Save Data";
            this.clienteSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteSetBindingNavigatorSaveItem_Click);
            // 
            // clienteSetDataGridView
            // 
            this.clienteSetDataGridView.AutoGenerateColumns = false;
            this.clienteSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.clienteSetDataGridView.DataSource = this.clienteSetBindingSource;
            this.clienteSetDataGridView.Location = new System.Drawing.Point(1, 73);
            this.clienteSetDataGridView.Name = "clienteSetDataGridView";
            this.clienteSetDataGridView.Size = new System.Drawing.Size(545, 269);
            this.clienteSetDataGridView.TabIndex = 2;
            this.clienteSetDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clienteSetDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NIF";
            this.dataGridViewTextBoxColumn3.HeaderText = "NIF";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Morada";
            this.dataGridViewTextBoxColumn4.HeaderText = "Morada";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Contacto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Contacto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteSetBindingSource, "Contacto", true));
            this.contactoTextBox.Location = new System.Drawing.Point(99, 181);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactoTextBox.TabIndex = 9;
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Location = new System.Drawing.Point(39, 184);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(53, 13);
            contactoLabel.TabIndex = 8;
            contactoLabel.Text = "Contacto:";
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteSetBindingSource, "Morada", true));
            this.moradaTextBox.Location = new System.Drawing.Point(99, 155);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(100, 20);
            this.moradaTextBox.TabIndex = 7;
            // 
            // moradaLabel
            // 
            moradaLabel.AutoSize = true;
            moradaLabel.Location = new System.Drawing.Point(39, 158);
            moradaLabel.Name = "moradaLabel";
            moradaLabel.Size = new System.Drawing.Size(46, 13);
            moradaLabel.TabIndex = 6;
            moradaLabel.Text = "Morada:";
            // 
            // nIFTextBox
            // 
            this.nIFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteSetBindingSource, "NIF", true));
            this.nIFTextBox.Location = new System.Drawing.Point(99, 129);
            this.nIFTextBox.Name = "nIFTextBox";
            this.nIFTextBox.Size = new System.Drawing.Size(100, 20);
            this.nIFTextBox.TabIndex = 5;
            // 
            // nIFLabel
            // 
            nIFLabel.AutoSize = true;
            nIFLabel.Location = new System.Drawing.Point(39, 132);
            nIFLabel.Name = "nIFLabel";
            nIFLabel.Size = new System.Drawing.Size(27, 13);
            nIFLabel.TabIndex = 4;
            nIFLabel.Text = "NIF:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteSetBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(99, 103);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(39, 106);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteSetBindingSource, "IdCliente", true));
            this.idClienteTextBox.Enabled = false;
            this.idClienteTextBox.Location = new System.Drawing.Point(99, 77);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.idClienteTextBox.TabIndex = 1;
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(39, 80);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(21, 13);
            idClienteLabel.TabIndex = 0;
            idClienteLabel.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nomeTextBox);
            this.groupBox2.Controls.Add(idClienteLabel);
            this.groupBox2.Controls.Add(nIFLabel);
            this.groupBox2.Controls.Add(contactoLabel);
            this.groupBox2.Controls.Add(nomeLabel);
            this.groupBox2.Controls.Add(this.moradaTextBox);
            this.groupBox2.Controls.Add(moradaLabel);
            this.groupBox2.Controls.Add(this.nIFTextBox);
            this.groupBox2.Controls.Add(this.idClienteTextBox);
            this.groupBox2.Controls.Add(this.contactoTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 318);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(942, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clienteSetBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCliente";
            this.Text = "Fichas de Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standAutoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteSetBindingNavigator)).EndInit();
            this.clienteSetBindingNavigator.ResumeLayout(false);
            this.clienteSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteSetDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.TextBox txtFiltrar;
        private StandAutoDataSet standAutoDataSet;
        private System.Windows.Forms.BindingSource clienteSetBindingSource;
        private StandAutoDataSetTableAdapters.ClienteSetTableAdapter clienteSetTableAdapter;
        private StandAutoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clienteSetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView clienteSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.TextBox moradaTextBox;
        private System.Windows.Forms.TextBox nIFTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
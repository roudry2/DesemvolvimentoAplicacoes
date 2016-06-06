namespace StandAuto
{
    partial class frmVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenda));
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label nomeLabel;
            this.standAutoDataSet = new StandAuto.StandAutoDataSet();
            this.vendaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaSetTableAdapter = new StandAuto.StandAutoDataSetTableAdapters.VendaSetTableAdapter();
            this.tableAdapterManager = new StandAuto.StandAutoDataSetTableAdapters.TableAdapterManager();
            this.vendaSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vendaSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vendaSetDataGridView = new System.Windows.Forms.DataGridView();
            this.clienteSetTableAdapter1 = new StandAuto.StandAutoDataSetTableAdapters.ClienteSetTableAdapter();
            this.clienteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.btnNovoCli = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.nomeComboBox = new System.Windows.Forms.ComboBox();
            valorLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.standAutoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaSetBindingNavigator)).BeginInit();
            this.vendaSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // standAutoDataSet
            // 
            this.standAutoDataSet.DataSetName = "StandAutoDataSet";
            this.standAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaSetBindingSource
            // 
            this.vendaSetBindingSource.DataMember = "VendaSet";
            this.vendaSetBindingSource.DataSource = this.standAutoDataSet;
            // 
            // vendaSetTableAdapter
            // 
            this.vendaSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AluguerSetTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroSet_CarroAluguerTableAdapter = null;
            this.tableAdapterManager.CarroSet_CarroOficinaTableAdapter = null;
            this.tableAdapterManager.CarroSet_CarroVendaTableAdapter = null;
            this.tableAdapterManager.CarroSetTableAdapter = null;
            this.tableAdapterManager.ClienteSetTableAdapter = this.clienteSetTableAdapter1;
            this.tableAdapterManager.ParcelaSetTableAdapter = null;
            this.tableAdapterManager.ServiçoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StandAuto.StandAutoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaSetTableAdapter = this.vendaSetTableAdapter;
            // 
            // vendaSetBindingNavigator
            // 
            this.vendaSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vendaSetBindingNavigator.BindingSource = this.vendaSetBindingSource;
            this.vendaSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vendaSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vendaSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vendaSetBindingNavigatorSaveItem});
            this.vendaSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vendaSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vendaSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vendaSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vendaSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vendaSetBindingNavigator.Name = "vendaSetBindingNavigator";
            this.vendaSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vendaSetBindingNavigator.Size = new System.Drawing.Size(770, 25);
            this.vendaSetBindingNavigator.TabIndex = 0;
            this.vendaSetBindingNavigator.Text = "bindingNavigator1";
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
            // vendaSetBindingNavigatorSaveItem
            // 
            this.vendaSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendaSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vendaSetBindingNavigatorSaveItem.Image")));
            this.vendaSetBindingNavigatorSaveItem.Name = "vendaSetBindingNavigatorSaveItem";
            this.vendaSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vendaSetBindingNavigatorSaveItem.Text = "Save Data";
            this.vendaSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendaSetBindingNavigatorSaveItem_Click);
            // 
            // vendaSetDataGridView
            // 
            this.vendaSetDataGridView.AllowUserToAddRows = false;
            this.vendaSetDataGridView.AllowUserToDeleteRows = false;
            this.vendaSetDataGridView.AutoGenerateColumns = false;
            this.vendaSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendaSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.NomeCli,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.vendaSetDataGridView.DataSource = this.vendaSetBindingSource;
            this.vendaSetDataGridView.Location = new System.Drawing.Point(12, 36);
            this.vendaSetDataGridView.Name = "vendaSetDataGridView";
            this.vendaSetDataGridView.ReadOnly = true;
            this.vendaSetDataGridView.Size = new System.Drawing.Size(476, 266);
            this.vendaSetDataGridView.TabIndex = 1;
            // 
            // clienteSetTableAdapter1
            // 
            this.clienteSetTableAdapter1.ClearBeforeFill = true;
            // 
            // clienteSetBindingSource
            // 
            this.clienteSetBindingSource.DataMember = "ClienteSet";
            this.clienteSetBindingSource.DataSource = this.standAutoDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdVenda";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdVenda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // NomeCli
            // 
            this.NomeCli.HeaderText = "Cliente";
            this.NomeCli.Name = "NomeCli";
            this.NomeCli.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn3.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ClienteIdCliente";
            this.dataGridViewTextBoxColumn5.HeaderText = "ClienteIdCliente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CarroVenda_IdCarro";
            this.dataGridViewTextBoxColumn6.HeaderText = "CarroVenda_IdCarro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(495, 63);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaSetBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(548, 63);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 7;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(495, 89);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 8;
            estadoLabel.Text = "Estado:";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaSetBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(548, 89);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoTextBox.TabIndex = 9;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(495, 115);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 10;
            dataLabel.Text = "Data:";
            // 
            // dataTextBox
            // 
            this.dataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaSetBindingSource, "Data", true));
            this.dataTextBox.Location = new System.Drawing.Point(548, 115);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataTextBox.TabIndex = 11;
            // 
            // btnNovoCli
            // 
            this.btnNovoCli.Location = new System.Drawing.Point(675, 36);
            this.btnNovoCli.Name = "btnNovoCli";
            this.btnNovoCli.Size = new System.Drawing.Size(75, 23);
            this.btnNovoCli.TabIndex = 12;
            this.btnNovoCli.Text = "Novo";
            this.btnNovoCli.UseVisualStyleBackColor = true;
            this.btnNovoCli.Click += new System.EventHandler(this.btnNovoCli_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(675, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(548, 164);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(493, 39);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 14;
            nomeLabel.Text = "Nome:";
            // 
            // nomeComboBox
            // 
            this.nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteSetBindingSource, "Nome", true));
            this.nomeComboBox.FormattingEnabled = true;
            this.nomeComboBox.Location = new System.Drawing.Point(537, 36);
            this.nomeComboBox.Name = "nomeComboBox";
            this.nomeComboBox.Size = new System.Drawing.Size(121, 21);
            this.nomeComboBox.TabIndex = 15;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 491);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeComboBox);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNovoCli);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.vendaSetDataGridView);
            this.Controls.Add(this.vendaSetBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVenda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.standAutoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaSetBindingNavigator)).EndInit();
            this.vendaSetBindingNavigator.ResumeLayout(false);
            this.vendaSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StandAutoDataSet standAutoDataSet;
        private System.Windows.Forms.BindingSource vendaSetBindingSource;
        private StandAutoDataSetTableAdapters.VendaSetTableAdapter vendaSetTableAdapter;
        private StandAutoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vendaSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vendaSetBindingNavigatorSaveItem;
        private StandAutoDataSetTableAdapters.ClienteSetTableAdapter clienteSetTableAdapter1;
        private System.Windows.Forms.DataGridView vendaSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource clienteSetBindingSource;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.Button btnNovoCli;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox nomeComboBox;
    }
}
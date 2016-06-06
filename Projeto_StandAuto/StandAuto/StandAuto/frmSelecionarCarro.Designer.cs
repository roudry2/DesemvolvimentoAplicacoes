namespace StandAuto
{
    partial class frmSelecionarCarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecionarCarro));
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label kmsLabel;
            System.Windows.Forms.Label clienteIdClienteLabel;
            System.Windows.Forms.Label idCarroLabel;
            this.standAutoDataSet = new StandAuto.StandAutoDataSet();
            this.carroSet_CarroOficinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroSet_CarroOficinaTableAdapter = new StandAuto.StandAutoDataSetTableAdapters.CarroSet_CarroOficinaTableAdapter();
            this.tableAdapterManager = new StandAuto.StandAutoDataSetTableAdapters.TableAdapterManager();
            this.carroSet_CarroOficinaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.carroSet_CarroOficinaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnSelecionarCarro = new System.Windows.Forms.Button();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.kmsTextBox = new System.Windows.Forms.TextBox();
            this.clienteIdClienteTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.idCarroTextBox = new System.Windows.Forms.TextBox();
            matriculaLabel = new System.Windows.Forms.Label();
            kmsLabel = new System.Windows.Forms.Label();
            clienteIdClienteLabel = new System.Windows.Forms.Label();
            idCarroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.standAutoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroSet_CarroOficinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroSet_CarroOficinaBindingNavigator)).BeginInit();
            this.carroSet_CarroOficinaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.carroSet_CarroOficinaBindingNavigator.Size = new System.Drawing.Size(321, 25);
            this.carroSet_CarroOficinaBindingNavigator.TabIndex = 0;
            this.carroSet_CarroOficinaBindingNavigator.Text = "bindingNavigator1";
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
            // carroSet_CarroOficinaBindingNavigatorSaveItem
            // 
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carroSet_CarroOficinaBindingNavigatorSaveItem.Image")));
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.Name = "carroSet_CarroOficinaBindingNavigatorSaveItem";
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.Text = "Save Data";
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.Click += new System.EventHandler(this.carroSet_CarroOficinaBindingNavigatorSaveItem_Click);
            // 
            // btnSelecionarCarro
            // 
            this.btnSelecionarCarro.Location = new System.Drawing.Point(43, 211);
            this.btnSelecionarCarro.Name = "btnSelecionarCarro";
            this.btnSelecionarCarro.Size = new System.Drawing.Size(124, 23);
            this.btnSelecionarCarro.TabIndex = 3;
            this.btnSelecionarCarro.Text = "Adicionar Carro";
            this.btnSelecionarCarro.UseVisualStyleBackColor = true;
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(12, 44);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(53, 13);
            matriculaLabel.TabIndex = 3;
            matriculaLabel.Text = "Matricula:";
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroSet_CarroOficinaBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(107, 41);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(100, 20);
            this.matriculaTextBox.TabIndex = 4;
            // 
            // kmsLabel
            // 
            kmsLabel.AutoSize = true;
            kmsLabel.Location = new System.Drawing.Point(12, 70);
            kmsLabel.Name = "kmsLabel";
            kmsLabel.Size = new System.Drawing.Size(30, 13);
            kmsLabel.TabIndex = 5;
            kmsLabel.Text = "Kms:";
            // 
            // kmsTextBox
            // 
            this.kmsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroSet_CarroOficinaBindingSource, "Kms", true));
            this.kmsTextBox.Location = new System.Drawing.Point(107, 67);
            this.kmsTextBox.Name = "kmsTextBox";
            this.kmsTextBox.Size = new System.Drawing.Size(100, 20);
            this.kmsTextBox.TabIndex = 6;
            // 
            // clienteIdClienteLabel
            // 
            clienteIdClienteLabel.AutoSize = true;
            clienteIdClienteLabel.Location = new System.Drawing.Point(12, 96);
            clienteIdClienteLabel.Name = "clienteIdClienteLabel";
            clienteIdClienteLabel.Size = new System.Drawing.Size(89, 13);
            clienteIdClienteLabel.TabIndex = 7;
            clienteIdClienteLabel.Text = "Cliente Id Cliente:";
            // 
            // clienteIdClienteTextBox
            // 
            this.clienteIdClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroSet_CarroOficinaBindingSource, "ClienteIdCliente", true));
            this.clienteIdClienteTextBox.Location = new System.Drawing.Point(107, 93);
            this.clienteIdClienteTextBox.Name = "clienteIdClienteTextBox";
            this.clienteIdClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.clienteIdClienteTextBox.TabIndex = 8;
            // 
            // idCarroLabel
            // 
            idCarroLabel.AutoSize = true;
            idCarroLabel.Location = new System.Drawing.Point(12, 122);
            idCarroLabel.Name = "idCarroLabel";
            idCarroLabel.Size = new System.Drawing.Size(47, 13);
            idCarroLabel.TabIndex = 9;
            idCarroLabel.Text = "Id Carro:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idCarroTextBox
            // 
            this.idCarroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroSet_CarroOficinaBindingSource, "IdCarro", true));
            this.idCarroTextBox.Location = new System.Drawing.Point(107, 119);
            this.idCarroTextBox.Name = "idCarroTextBox";
            this.idCarroTextBox.ReadOnly = true;
            this.idCarroTextBox.Size = new System.Drawing.Size(100, 20);
            this.idCarroTextBox.TabIndex = 10;
            // 
            // frmSelecionarCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 233);
            this.Controls.Add(this.button1);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(kmsLabel);
            this.Controls.Add(this.kmsTextBox);
            this.Controls.Add(clienteIdClienteLabel);
            this.Controls.Add(this.clienteIdClienteTextBox);
            this.Controls.Add(idCarroLabel);
            this.Controls.Add(this.idCarroTextBox);
            this.Controls.Add(this.btnSelecionarCarro);
            this.Controls.Add(this.carroSet_CarroOficinaBindingNavigator);
            this.Name = "frmSelecionarCarro";
            this.Text = "frmSelecionarCarro";
            this.Load += new System.EventHandler(this.frmSelecionarCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.standAutoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroSet_CarroOficinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroSet_CarroOficinaBindingNavigator)).EndInit();
            this.carroSet_CarroOficinaBindingNavigator.ResumeLayout(false);
            this.carroSet_CarroOficinaBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.Button btnSelecionarCarro;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox kmsTextBox;
        private System.Windows.Forms.TextBox clienteIdClienteTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idCarroTextBox;
    }
}
﻿namespace StandAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCarroOficina));
            this.standAutoDataSet = new StandAuto.StandAutoDataSet();
            this.carroSet_CarroOficinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroSet_CarroOficinaTableAdapter = new StandAuto.StandAutoDataSetTableAdapters.CarroSet_CarroOficinaTableAdapter();
            this.tableAdapterManager = new StandAuto.StandAutoDataSetTableAdapters.TableAdapterManager();
            this.carroSet_CarroOficinaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.carroSet_CarroOficinaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.carroSet_CarroOficinaBindingNavigator.Size = new System.Drawing.Size(773, 25);
            this.carroSet_CarroOficinaBindingNavigator.TabIndex = 0;
            this.carroSet_CarroOficinaBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // carroSet_CarroOficinaBindingNavigatorSaveItem
            // 
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carroSet_CarroOficinaBindingNavigatorSaveItem.Image")));
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.Name = "carroSet_CarroOficinaBindingNavigatorSaveItem";
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.Text = "Save Data";
            this.carroSet_CarroOficinaBindingNavigatorSaveItem.Click += new System.EventHandler(this.carroSet_CarroOficinaBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmAddCarroOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 280);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.carroSet_CarroOficinaBindingNavigator);
            this.Name = "frmAddCarroOficina";
            this.Text = "frmAddCarroOficina";
            this.Load += new System.EventHandler(this.frmAddCarroOficina_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
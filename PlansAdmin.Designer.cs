﻿namespace Tylka
{
    partial class PlansAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlansAdmin));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iddniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idklasyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godzinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poniedziałeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wtorekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.środaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czwartekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piątekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niedzielaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlinegradebookprojectDataSet = new Tylka.onlinegradebookprojectDataSet();
            this.dniTableAdapter = new Tylka.onlinegradebookprojectDataSetTableAdapters.DniTableAdapter();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddniaDataGridViewTextBoxColumn,
            this.idklasyDataGridViewTextBoxColumn,
            this.godzinaDataGridViewTextBoxColumn,
            this.poniedziałeDataGridViewTextBoxColumn,
            this.wtorekDataGridViewTextBoxColumn,
            this.środaDataGridViewTextBoxColumn,
            this.czwartekDataGridViewTextBoxColumn,
            this.piątekDataGridViewTextBoxColumn,
            this.sobotaDataGridViewTextBoxColumn,
            this.niedzielaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dniBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(678, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iddniaDataGridViewTextBoxColumn
            // 
            this.iddniaDataGridViewTextBoxColumn.DataPropertyName = "iddnia";
            this.iddniaDataGridViewTextBoxColumn.HeaderText = "iddnia";
            this.iddniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iddniaDataGridViewTextBoxColumn.Name = "iddniaDataGridViewTextBoxColumn";
            this.iddniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddniaDataGridViewTextBoxColumn.Width = 60;
            // 
            // idklasyDataGridViewTextBoxColumn
            // 
            this.idklasyDataGridViewTextBoxColumn.DataPropertyName = "id_klasy";
            this.idklasyDataGridViewTextBoxColumn.HeaderText = "id_klasy";
            this.idklasyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idklasyDataGridViewTextBoxColumn.Name = "idklasyDataGridViewTextBoxColumn";
            this.idklasyDataGridViewTextBoxColumn.Width = 70;
            // 
            // godzinaDataGridViewTextBoxColumn
            // 
            this.godzinaDataGridViewTextBoxColumn.DataPropertyName = "godzina";
            this.godzinaDataGridViewTextBoxColumn.HeaderText = "godzina";
            this.godzinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.godzinaDataGridViewTextBoxColumn.Name = "godzinaDataGridViewTextBoxColumn";
            this.godzinaDataGridViewTextBoxColumn.Width = 69;
            // 
            // poniedziałeDataGridViewTextBoxColumn
            // 
            this.poniedziałeDataGridViewTextBoxColumn.DataPropertyName = "Poniedziałe";
            this.poniedziałeDataGridViewTextBoxColumn.HeaderText = "Poniedziałe";
            this.poniedziałeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poniedziałeDataGridViewTextBoxColumn.Name = "poniedziałeDataGridViewTextBoxColumn";
            this.poniedziałeDataGridViewTextBoxColumn.Width = 88;
            // 
            // wtorekDataGridViewTextBoxColumn
            // 
            this.wtorekDataGridViewTextBoxColumn.DataPropertyName = "Wtorek";
            this.wtorekDataGridViewTextBoxColumn.HeaderText = "Wtorek";
            this.wtorekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wtorekDataGridViewTextBoxColumn.Name = "wtorekDataGridViewTextBoxColumn";
            this.wtorekDataGridViewTextBoxColumn.Width = 67;
            // 
            // środaDataGridViewTextBoxColumn
            // 
            this.środaDataGridViewTextBoxColumn.DataPropertyName = "Środa";
            this.środaDataGridViewTextBoxColumn.HeaderText = "Środa";
            this.środaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.środaDataGridViewTextBoxColumn.Name = "środaDataGridViewTextBoxColumn";
            this.środaDataGridViewTextBoxColumn.Width = 60;
            // 
            // czwartekDataGridViewTextBoxColumn
            // 
            this.czwartekDataGridViewTextBoxColumn.DataPropertyName = "Czwartek";
            this.czwartekDataGridViewTextBoxColumn.HeaderText = "Czwartek";
            this.czwartekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.czwartekDataGridViewTextBoxColumn.Name = "czwartekDataGridViewTextBoxColumn";
            this.czwartekDataGridViewTextBoxColumn.Width = 76;
            // 
            // piątekDataGridViewTextBoxColumn
            // 
            this.piątekDataGridViewTextBoxColumn.DataPropertyName = "Piątek";
            this.piątekDataGridViewTextBoxColumn.HeaderText = "Piątek";
            this.piątekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.piątekDataGridViewTextBoxColumn.Name = "piątekDataGridViewTextBoxColumn";
            this.piątekDataGridViewTextBoxColumn.Width = 62;
            // 
            // sobotaDataGridViewTextBoxColumn
            // 
            this.sobotaDataGridViewTextBoxColumn.DataPropertyName = "Sobota";
            this.sobotaDataGridViewTextBoxColumn.HeaderText = "Sobota";
            this.sobotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sobotaDataGridViewTextBoxColumn.Name = "sobotaDataGridViewTextBoxColumn";
            this.sobotaDataGridViewTextBoxColumn.Width = 66;
            // 
            // niedzielaDataGridViewTextBoxColumn
            // 
            this.niedzielaDataGridViewTextBoxColumn.DataPropertyName = "Niedziela";
            this.niedzielaDataGridViewTextBoxColumn.HeaderText = "Niedziela";
            this.niedzielaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.niedzielaDataGridViewTextBoxColumn.Name = "niedzielaDataGridViewTextBoxColumn";
            this.niedzielaDataGridViewTextBoxColumn.Width = 75;
            // 
            // dniBindingSource
            // 
            this.dniBindingSource.DataMember = "Dni";
            this.dniBindingSource.DataSource = this.onlinegradebookprojectDataSet;
            // 
            // onlinegradebookprojectDataSet
            // 
            this.onlinegradebookprojectDataSet.DataSetName = "onlinegradebookprojectDataSet";
            this.onlinegradebookprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dniTableAdapter
            // 
            this.dniTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.saveToolStripButton,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(768, 27);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Tylka.Properties.Resources.odswiezbtn_Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // PlansAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlansAdmin";
            this.Size = new System.Drawing.Size(768, 424);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklasyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godzinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poniedziałeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wtorekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn środaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn czwartekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piątekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niedzielaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dniBindingSource;
        private onlinegradebookprojectDataSet onlinegradebookprojectDataSet;
        private onlinegradebookprojectDataSetTableAdapters.DniTableAdapter dniTableAdapter;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
    }
}

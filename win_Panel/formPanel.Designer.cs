﻿namespace ControlDeReparacion
{
    partial class formPanel
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
            this.boxTitulo = new System.Windows.Forms.GroupBox();
            this.panelAdd = new System.Windows.Forms.TableLayoutPanel();
            this.inCausa = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.causa_grid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.causa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.boxTitulo.SuspendLayout();
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.causa_grid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxTitulo
            // 
            this.boxTitulo.Controls.Add(this.panelAdd);
            this.boxTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxTitulo.Location = new System.Drawing.Point(8, 8);
            this.boxTitulo.Name = "boxTitulo";
            this.boxTitulo.Size = new System.Drawing.Size(310, 46);
            this.boxTitulo.TabIndex = 0;
            this.boxTitulo.TabStop = false;
            this.boxTitulo.Text = "Nuevo panel";
            // 
            // panelAdd
            // 
            this.panelAdd.ColumnCount = 3;
            this.panelAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.panelAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.panelAdd.Controls.Add(this.inCausa, 0, 0);
            this.panelAdd.Controls.Add(this.btCancelar, 2, 0);
            this.panelAdd.Controls.Add(this.btAgregar, 1, 0);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdd.Location = new System.Drawing.Point(3, 16);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.RowCount = 1;
            this.panelAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelAdd.Size = new System.Drawing.Size(304, 27);
            this.panelAdd.TabIndex = 2;
            // 
            // inCausa
            // 
            this.inCausa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inCausa.Location = new System.Drawing.Point(3, 3);
            this.inCausa.Name = "inCausa";
            this.inCausa.Size = new System.Drawing.Size(131, 20);
            this.inCausa.TabIndex = 0;
            this.inCausa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inCausa_KeyPress);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(222, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 21);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(140, 3);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 21);
            this.btAgregar.TabIndex = 1;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // causa_grid
            // 
            this.causa_grid.AllowUserToAddRows = false;
            this.causa_grid.AllowUserToDeleteRows = false;
            this.causa_grid.AllowUserToResizeColumns = false;
            this.causa_grid.AllowUserToResizeRows = false;
            this.causa_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.causa_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.causa,
            this.editar,
            this.eliminar});
            this.causa_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.causa_grid.Location = new System.Drawing.Point(8, 60);
            this.causa_grid.Name = "causa_grid";
            this.causa_grid.ReadOnly = true;
            this.causa_grid.RowHeadersVisible = false;
            this.causa_grid.Size = new System.Drawing.Size(310, 135);
            this.causa_grid.TabIndex = 1;
            this.causa_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.causas_grid_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // causa
            // 
            this.causa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.causa.HeaderText = "Panel";
            this.causa.Name = "causa";
            this.causa.ReadOnly = true;
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.editar.HeaderText = "";
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editar.Text = "Editar";
            this.editar.UseColumnTextForButtonValue = true;
            this.editar.Width = 19;
            // 
            // eliminar
            // 
            this.eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.eliminar.HeaderText = "";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseColumnTextForButtonValue = true;
            this.eliminar.Width = 19;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.causa_grid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.boxTitulo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(326, 203);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // formPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 203);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar panel";
            this.Load += new System.EventHandler(this.formCausa_Load);
            this.boxTitulo.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.causa_grid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxTitulo;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox inCausa;
        private System.Windows.Forms.DataGridView causa_grid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel panelAdd;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn causa;
        private System.Windows.Forms.DataGridViewButtonColumn editar;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
    }
}
namespace WinFormsApp
{
    partial class ProveedoresLista
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
            proveedoresDataGridView = new DataGridView();
            agregarButton = new Button();
            modificarButton = new Button();
            volverButton = new Button();
            eliminarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)proveedoresDataGridView).BeginInit();
            SuspendLayout();
            // 
            // proveedoresDataGridView
            // 
            proveedoresDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            proveedoresDataGridView.Location = new Point(14, 16);
            proveedoresDataGridView.Margin = new Padding(3, 4, 3, 4);
            proveedoresDataGridView.Name = "proveedoresDataGridView";
            proveedoresDataGridView.RowHeadersWidth = 51;
            proveedoresDataGridView.Size = new Size(773, 375);
            proveedoresDataGridView.TabIndex = 0;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(701, 404);
            agregarButton.Margin = new Padding(3, 4, 3, 4);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(86, 31);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(608, 404);
            modificarButton.Margin = new Padding(3, 4, 3, 4);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(86, 31);
            modificarButton.TabIndex = 2;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // volverButton
            // 
            volverButton.Location = new Point(14, 404);
            volverButton.Margin = new Padding(3, 4, 3, 4);
            volverButton.Name = "volverButton";
            volverButton.Size = new Size(86, 31);
            volverButton.TabIndex = 3;
            volverButton.Text = "Volver";
            volverButton.UseVisualStyleBackColor = true;
            volverButton.Click += volverButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(515, 404);
            eliminarButton.Margin = new Padding(3, 4, 3, 4);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(86, 31);
            eliminarButton.TabIndex = 4;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // ProveedoresLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(eliminarButton);
            Controls.Add(volverButton);
            Controls.Add(modificarButton);
            Controls.Add(agregarButton);
            Controls.Add(proveedoresDataGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProveedoresLista";
            Text = "ProovedoresLista";
            Load += ProveedoresLista_Load;
            ((System.ComponentModel.ISupportInitialize)proveedoresDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView proveedoresDataGridView;
        private Button agregarButton;
        private Button modificarButton;
        private Button volverButton;
        private Button eliminarButton;
    }
}
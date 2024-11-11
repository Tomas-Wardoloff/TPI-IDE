namespace WinFormsApp
{
    partial class VentaLista
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
            ventasDataGridView = new DataGridView();
            agregarButton = new Button();
            modificarButton = new Button();
            eliminarButton = new Button();
            volverButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ventasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ventasDataGridView
            // 
            ventasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ventasDataGridView.Location = new Point(10, 9);
            ventasDataGridView.Margin = new Padding(3, 2, 3, 2);
            ventasDataGridView.Name = "ventasDataGridView";
            ventasDataGridView.RowHeadersWidth = 51;
            ventasDataGridView.Size = new Size(679, 293);
            ventasDataGridView.TabIndex = 0;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(607, 307);
            agregarButton.Margin = new Padding(3, 2, 3, 2);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(82, 22);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(520, 307);
            modificarButton.Margin = new Padding(3, 2, 3, 2);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(82, 22);
            modificarButton.TabIndex = 2;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(432, 307);
            eliminarButton.Margin = new Padding(3, 2, 3, 2);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(82, 22);
            eliminarButton.TabIndex = 3;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // volverButton
            // 
            volverButton.Location = new Point(10, 307);
            volverButton.Margin = new Padding(3, 2, 3, 2);
            volverButton.Name = "volverButton";
            volverButton.Size = new Size(82, 22);
            volverButton.TabIndex = 4;
            volverButton.Text = "Volver";
            volverButton.UseVisualStyleBackColor = true;
            volverButton.Click += volverButton_Click;
            // 
            // VentaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(volverButton);
            Controls.Add(eliminarButton);
            Controls.Add(modificarButton);
            Controls.Add(agregarButton);
            Controls.Add(ventasDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "VentaLista";
            Text = "VentaLista";
            Load += VentaLista_Load;
            ((System.ComponentModel.ISupportInitialize)ventasDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ventasDataGridView;
        private Button agregarButton;
        private Button modificarButton;
        private Button eliminarButton;
        private Button volverButton;
    }
}
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
            ventasDataGridView.Location = new Point(12, 12);
            ventasDataGridView.Name = "ventasDataGridView";
            ventasDataGridView.RowHeadersWidth = 51;
            ventasDataGridView.Size = new Size(776, 391);
            ventasDataGridView.TabIndex = 0;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(694, 409);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(94, 29);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(594, 409);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(94, 29);
            modificarButton.TabIndex = 2;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(494, 409);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(94, 29);
            eliminarButton.TabIndex = 3;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            // 
            // volverButton
            // 
            volverButton.Location = new Point(12, 409);
            volverButton.Name = "volverButton";
            volverButton.Size = new Size(94, 29);
            volverButton.TabIndex = 4;
            volverButton.Text = "Volver";
            volverButton.UseVisualStyleBackColor = true;
            // 
            // VentaLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(volverButton);
            Controls.Add(eliminarButton);
            Controls.Add(modificarButton);
            Controls.Add(agregarButton);
            Controls.Add(ventasDataGridView);
            Name = "VentaLista";
            Text = "VentaLista";
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
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
            proveedoresDataGridView.Location = new Point(12, 12);
            proveedoresDataGridView.Name = "proveedoresDataGridView";
            proveedoresDataGridView.Size = new Size(676, 281);
            proveedoresDataGridView.TabIndex = 0;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(613, 303);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(75, 23);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(532, 303);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(75, 23);
            modificarButton.TabIndex = 2;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            // 
            // volverButton
            // 
            volverButton.Location = new Point(12, 303);
            volverButton.Name = "volverButton";
            volverButton.Size = new Size(75, 23);
            volverButton.TabIndex = 3;
            volverButton.Text = "Volver";
            volverButton.UseVisualStyleBackColor = true;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(451, 303);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(75, 23);
            eliminarButton.TabIndex = 4;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            // 
            // ProveedoresLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(eliminarButton);
            Controls.Add(volverButton);
            Controls.Add(modificarButton);
            Controls.Add(agregarButton);
            Controls.Add(proveedoresDataGridView);
            Name = "ProveedoresLista";
            Text = "ProovedoresLista";
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
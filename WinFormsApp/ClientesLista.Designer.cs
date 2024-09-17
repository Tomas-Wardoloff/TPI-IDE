namespace WinFormsApp
{
    partial class ClientesLista
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clientesDataGridView = new DataGridView();
            eliminarButton = new Button();
            agregarButton = new Button();
            modificarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)clientesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // clientesDataGridView
            // 
            clientesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientesDataGridView.Location = new Point(12, 12);
            clientesDataGridView.Name = "clientesDataGridView";
            clientesDataGridView.RowHeadersWidth = 51;
            clientesDataGridView.Size = new Size(776, 325);
            clientesDataGridView.TabIndex = 0;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(494, 409);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(94, 29);
            eliminarButton.TabIndex = 1;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(694, 409);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(94, 29);
            agregarButton.TabIndex = 2;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(594, 409);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(94, 29);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // ClientesLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(modificarButton);
            Controls.Add(agregarButton);
            Controls.Add(eliminarButton);
            Controls.Add(clientesDataGridView);
            Name = "ClientesLista";
            Text = "Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)clientesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView clientesDataGridView;
        private Button eliminarButton;
        private Button agregarButton;
        private Button modificarButton;
    }
}

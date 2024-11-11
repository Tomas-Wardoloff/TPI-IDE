namespace WinFormsApp
{
    partial class MaquinariaLista
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
            maquinariaDataGridView = new DataGridView();
            volverButton = new Button();
            agregarButton = new Button();
            modificarButton = new Button();
            eliminarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)maquinariaDataGridView).BeginInit();
            SuspendLayout();
            // 
            // maquinariaDataGridView
            // 
            maquinariaDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            maquinariaDataGridView.Location = new Point(12, 12);
            maquinariaDataGridView.Name = "maquinariaDataGridView";
            maquinariaDataGridView.Size = new Size(676, 281);
            maquinariaDataGridView.TabIndex = 0;
            // 
            // volverButton
            // 
            volverButton.Location = new Point(12, 303);
            volverButton.Name = "volverButton";
            volverButton.Size = new Size(75, 23);
            volverButton.TabIndex = 1;
            volverButton.Text = "Volver";
            volverButton.UseVisualStyleBackColor = true;
            volverButton.Click += volverButton_Click;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(613, 303);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(75, 23);
            agregarButton.TabIndex = 2;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(514, 303);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(75, 23);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(418, 303);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(75, 23);
            eliminarButton.TabIndex = 4;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // MaquinariaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(eliminarButton);
            Controls.Add(modificarButton);
            Controls.Add(agregarButton);
            Controls.Add(volverButton);
            Controls.Add(maquinariaDataGridView);
            Name = "MaquinariaLista";
            Text = "MaquinariaLista";
            Load += MaquinariaLista_Load;
            ((System.ComponentModel.ISupportInitialize)maquinariaDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView maquinariaDataGridView;
        private Button volverButton;
        private Button agregarButton;
        private Button modificarButton;
        private Button eliminarButton;
    }
}
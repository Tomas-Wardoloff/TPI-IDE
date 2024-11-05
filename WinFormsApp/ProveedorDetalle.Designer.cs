namespace WinFormsApp
{
    partial class ProveedorDetalle
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
            components = new System.ComponentModel.Container();
            razonsocialLabel = new Label();
            telefonoLabel = new Label();
            mailLabel = new Label();
            repuestoLabel = new Label();
            razonSocialTextBox = new TextBox();
            telefonoTextBox = new TextBox();
            mailTextBox = new TextBox();
            repuestoTextBox = new TextBox();
            aceptarButton = new Button();
            cancelarButton = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // razonsocialLabel
            // 
            razonsocialLabel.AutoSize = true;
            razonsocialLabel.Location = new Point(71, 65);
            razonsocialLabel.Name = "razonsocialLabel";
            razonsocialLabel.Size = new Size(73, 15);
            razonsocialLabel.TabIndex = 0;
            razonsocialLabel.Text = "Razon Social";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new Point(71, 106);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(52, 15);
            telefonoLabel.TabIndex = 1;
            telefonoLabel.Text = "Telefono";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new Point(71, 150);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(30, 15);
            mailLabel.TabIndex = 2;
            mailLabel.Text = "Mail";
            // 
            // repuestoLabel
            // 
            repuestoLabel.AutoSize = true;
            repuestoLabel.Location = new Point(71, 193);
            repuestoLabel.Name = "repuestoLabel";
            repuestoLabel.Size = new Size(56, 15);
            repuestoLabel.TabIndex = 3;
            repuestoLabel.Text = "Repuesto";
            // 
            // razonSocialTextBox
            // 
            razonSocialTextBox.Location = new Point(163, 60);
            razonSocialTextBox.Name = "razonSocialTextBox";
            razonSocialTextBox.Size = new Size(100, 23);
            razonSocialTextBox.TabIndex = 4;
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(163, 103);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(100, 23);
            telefonoTextBox.TabIndex = 5;
            // 
            // mailTextBox
            // 
            mailTextBox.Location = new Point(163, 147);
            mailTextBox.Name = "mailTextBox";
            mailTextBox.Size = new Size(100, 23);
            mailTextBox.TabIndex = 6;
            // 
            // repuestoTextBox
            // 
            repuestoTextBox.Location = new Point(163, 190);
            repuestoTextBox.Name = "repuestoTextBox";
            repuestoTextBox.Size = new Size(100, 23);
            repuestoTextBox.TabIndex = 7;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(163, 303);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 8;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(254, 303);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 9;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ProveedorDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 338);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(repuestoTextBox);
            Controls.Add(mailTextBox);
            Controls.Add(telefonoTextBox);
            Controls.Add(razonSocialTextBox);
            Controls.Add(repuestoLabel);
            Controls.Add(mailLabel);
            Controls.Add(telefonoLabel);
            Controls.Add(razonsocialLabel);
            Name = "ProveedorDetalle";
            Text = "ProveedorDetalle";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label razonsocialLabel;
        private Label telefonoLabel;
        private Label mailLabel;
        private Label repuestoLabel;
        private TextBox razonSocialTextBox;
        private TextBox telefonoTextBox;
        private TextBox mailTextBox;
        private TextBox repuestoTextBox;
        private Button aceptarButton;
        private Button cancelarButton;
        private ErrorProvider errorProvider;
    }
}
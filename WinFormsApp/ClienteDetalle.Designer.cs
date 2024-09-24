namespace WinFormsApp
{
    partial class ClienteDetalle
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
            aceptarButton = new Button();
            cancelarButton = new Button();
            cuitCuilLabel = new Label();
            cuitCuilTextBox = new TextBox();
            telefonoTextBox = new TextBox();
            telefonoLabel = new Label();
            mailTextBox = new TextBox();
            mailLabel = new Label();
            localidadTextBox = new TextBox();
            localidadLabel = new Label();
            domicilioTextBox = new TextBox();
            domicilioLabel = new Label();
            razonSocialTextBox = new TextBox();
            razonSocialLabel = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(181, 409);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(94, 29);
            aceptarButton.TabIndex = 0;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(281, 409);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(94, 29);
            cancelarButton.TabIndex = 1;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // cuitCuilLabel
            // 
            cuitCuilLabel.AutoSize = true;
            cuitCuilLabel.Location = new Point(81, 70);
            cuitCuilLabel.Name = "cuitCuilLabel";
            cuitCuilLabel.Size = new Size(76, 20);
            cuitCuilLabel.TabIndex = 2;
            cuitCuilLabel.Text = "CUIT/CUIL";
            // 
            // cuitCuilTextBox
            // 
            cuitCuilTextBox.Location = new Point(181, 67);
            cuitCuilTextBox.Name = "cuitCuilTextBox";
            cuitCuilTextBox.Size = new Size(125, 27);
            cuitCuilTextBox.TabIndex = 3;
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(181, 290);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(125, 27);
            telefonoTextBox.TabIndex = 9;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new Point(81, 293);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(67, 20);
            telefonoLabel.TabIndex = 8;
            telefonoLabel.Text = "Telefono";
            // 
            // mailTextBox
            // 
            mailTextBox.Location = new Point(181, 247);
            mailTextBox.Name = "mailTextBox";
            mailTextBox.Size = new Size(125, 27);
            mailTextBox.TabIndex = 11;
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new Point(81, 250);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(38, 20);
            mailLabel.TabIndex = 10;
            mailLabel.Text = "Mail";
            // 
            // localidadTextBox
            // 
            localidadTextBox.Location = new Point(181, 199);
            localidadTextBox.Name = "localidadTextBox";
            localidadTextBox.Size = new Size(125, 27);
            localidadTextBox.TabIndex = 13;
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Location = new Point(81, 202);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new Size(74, 20);
            localidadLabel.TabIndex = 12;
            localidadLabel.Text = "Localidad";
            // 
            // domicilioTextBox
            // 
            domicilioTextBox.Location = new Point(181, 154);
            domicilioTextBox.Name = "domicilioTextBox";
            domicilioTextBox.Size = new Size(125, 27);
            domicilioTextBox.TabIndex = 15;
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Location = new Point(81, 157);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new Size(74, 20);
            domicilioLabel.TabIndex = 14;
            domicilioLabel.Text = "Domicilio";
            // 
            // razonSocialTextBox
            // 
            razonSocialTextBox.Location = new Point(181, 110);
            razonSocialTextBox.Name = "razonSocialTextBox";
            razonSocialTextBox.Size = new Size(125, 27);
            razonSocialTextBox.TabIndex = 17;
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.Location = new Point(81, 113);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new Size(94, 20);
            razonSocialLabel.TabIndex = 16;
            razonSocialLabel.Text = "Razón Social";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ClienteDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 450);
            Controls.Add(razonSocialTextBox);
            Controls.Add(razonSocialLabel);
            Controls.Add(domicilioTextBox);
            Controls.Add(domicilioLabel);
            Controls.Add(localidadTextBox);
            Controls.Add(localidadLabel);
            Controls.Add(mailTextBox);
            Controls.Add(mailLabel);
            Controls.Add(telefonoTextBox);
            Controls.Add(telefonoLabel);
            Controls.Add(cuitCuilTextBox);
            Controls.Add(cuitCuilLabel);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Name = "ClienteDetalle";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button aceptarButton;
        private Button cancelarButton;
        private Label cuitCuilLabel;
        private TextBox cuitCuilTextBox;
        private TextBox telefonoTextBox;
        private Label telefonoLabel;
        private TextBox mailTextBox;
        private Label mailLabel;
        private TextBox localidadTextBox;
        private Label localidadLabel;
        private TextBox domicilioTextBox;
        private Label domicilioLabel;
        private TextBox razonSocialTextBox;
        private Label razonSocialLabel;
        private ErrorProvider errorProvider;
    }
}
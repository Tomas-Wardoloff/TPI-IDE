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
            aceptarButton = new Button();
            cancelarButton = new Button();
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
            aceptarButton.Click += button1_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(281, 409);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(94, 29);
            cancelarButton.TabIndex = 1;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            // 
            // ClienteDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 450);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Name = "ClienteDetalle";
            Text = "Cliente";
            ResumeLayout(false);
        }

        #endregion

        private Button aceptarButton;
        private Button cancelarButton;
    }
}
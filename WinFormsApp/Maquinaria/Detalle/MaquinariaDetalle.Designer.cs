namespace WinFormsApp
{
    partial class MaquinariaDetalle
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
            cancelarButton = new Button();
            aceptarButton = new Button();
            modeloLabel = new Label();
            nroChasisLabel = new Label();
            importeCompraLabel = new Label();
            importeVentaLabel = new Label();
            tipoLabel = new Label();
            ventaLabel = new Label();
            accesorioLabel = new Label();
            modeloTextBox = new TextBox();
            nroChasisTextBox = new TextBox();
            importeCompraTextBox = new TextBox();
            importeVentaTextBox = new TextBox();
            tipoTextBox = new TextBox();
            ventaComboBox = new ComboBox();
            accesorioCheckedListBox = new CheckedListBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(252, 303);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 8;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(162, 303);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 9;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new Point(55, 34);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new Size(48, 15);
            modeloLabel.TabIndex = 10;
            modeloLabel.Text = "Modelo";
            // 
            // nroChasisLabel
            // 
            nroChasisLabel.AutoSize = true;
            nroChasisLabel.Location = new Point(55, 70);
            nroChasisLabel.Name = "nroChasisLabel";
            nroChasisLabel.Size = new Size(102, 15);
            nroChasisLabel.TabIndex = 11;
            nroChasisLabel.Text = "Numero de chasis";
            // 
            // importeCompraLabel
            // 
            importeCompraLabel.AutoSize = true;
            importeCompraLabel.Location = new Point(55, 99);
            importeCompraLabel.Name = "importeCompraLabel";
            importeCompraLabel.Size = new Size(109, 15);
            importeCompraLabel.TabIndex = 12;
            importeCompraLabel.Text = "Importe de compra";
            // 
            // importeVentaLabel
            // 
            importeVentaLabel.AutoSize = true;
            importeVentaLabel.Location = new Point(55, 133);
            importeVentaLabel.Name = "importeVentaLabel";
            importeVentaLabel.Size = new Size(97, 15);
            importeVentaLabel.TabIndex = 13;
            importeVentaLabel.Text = "Importe de venta";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new Point(55, 169);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new Size(30, 15);
            tipoLabel.TabIndex = 14;
            tipoLabel.Text = "Tipo";
            // 
            // ventaLabel
            // 
            ventaLabel.AutoSize = true;
            ventaLabel.Location = new Point(55, 203);
            ventaLabel.Name = "ventaLabel";
            ventaLabel.Size = new Size(36, 15);
            ventaLabel.TabIndex = 15;
            ventaLabel.Text = "Venta";
            // 
            // accesorioLabel
            // 
            accesorioLabel.AutoSize = true;
            accesorioLabel.Location = new Point(55, 235);
            accesorioLabel.Name = "accesorioLabel";
            accesorioLabel.Size = new Size(59, 15);
            accesorioLabel.TabIndex = 16;
            accesorioLabel.Text = "Accesorio";
            // 
            // modeloTextBox
            // 
            modeloTextBox.Location = new Point(162, 31);
            modeloTextBox.Name = "modeloTextBox";
            modeloTextBox.Size = new Size(121, 23);
            modeloTextBox.TabIndex = 17;
            // 
            // nroChasisTextBox
            // 
            nroChasisTextBox.Location = new Point(162, 67);
            nroChasisTextBox.Name = "nroChasisTextBox";
            nroChasisTextBox.Size = new Size(121, 23);
            nroChasisTextBox.TabIndex = 18;
            // 
            // importeCompraTextBox
            // 
            importeCompraTextBox.Location = new Point(162, 96);
            importeCompraTextBox.Name = "importeCompraTextBox";
            importeCompraTextBox.Size = new Size(121, 23);
            importeCompraTextBox.TabIndex = 19;
            // 
            // importeVentaTextBox
            // 
            importeVentaTextBox.Location = new Point(162, 130);
            importeVentaTextBox.Name = "importeVentaTextBox";
            importeVentaTextBox.Size = new Size(121, 23);
            importeVentaTextBox.TabIndex = 20;
            // 
            // tipoTextBox
            // 
            tipoTextBox.Location = new Point(162, 166);
            tipoTextBox.Name = "tipoTextBox";
            tipoTextBox.Size = new Size(121, 23);
            tipoTextBox.TabIndex = 21;
            // 
            // ventaComboBox
            // 
            ventaComboBox.FormattingEnabled = true;
            ventaComboBox.Location = new Point(162, 200);
            ventaComboBox.Name = "ventaComboBox";
            ventaComboBox.Size = new Size(121, 23);
            ventaComboBox.TabIndex = 22;
            // 
            // accesorioCheckedListBox
            // 
            accesorioCheckedListBox.FormattingEnabled = true;
            accesorioCheckedListBox.Location = new Point(162, 235);
            accesorioCheckedListBox.Name = "accesorioCheckedListBox";
            accesorioCheckedListBox.Size = new Size(121, 22);
            accesorioCheckedListBox.TabIndex = 23;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // MaquinariaDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 338);
            Controls.Add(accesorioCheckedListBox);
            Controls.Add(ventaComboBox);
            Controls.Add(tipoTextBox);
            Controls.Add(importeVentaTextBox);
            Controls.Add(importeCompraTextBox);
            Controls.Add(nroChasisTextBox);
            Controls.Add(modeloTextBox);
            Controls.Add(accesorioLabel);
            Controls.Add(ventaLabel);
            Controls.Add(tipoLabel);
            Controls.Add(importeVentaLabel);
            Controls.Add(importeCompraLabel);
            Controls.Add(nroChasisLabel);
            Controls.Add(modeloLabel);
            Controls.Add(aceptarButton);
            Controls.Add(cancelarButton);
            Name = "MaquinariaDetalle";
            Text = "MaquinariaDetalle";
            Load += MaquinariaDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cancelarButton;
        private Button aceptarButton;
        private Label modeloLabel;
        private Label nroChasisLabel;
        private Label importeCompraLabel;
        private Label importeVentaLabel;
        private Label tipoLabel;
        private Label ventaLabel;
        private Label accesorioLabel;
        private TextBox modeloTextBox;
        private TextBox nroChasisTextBox;
        private TextBox importeCompraTextBox;
        private TextBox importeVentaTextBox;
        private TextBox tipoTextBox;
        private ComboBox ventaComboBox;
        private CheckedListBox accesorioCheckedListBox;
        private ErrorProvider errorProvider;
    }
}
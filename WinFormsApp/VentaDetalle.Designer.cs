namespace WinFormsApp
{
    partial class VentaDetalle
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
            fechaLabel = new Label();
            importeTotalLabel = new Label();
            estadoLabel = new Label();
            clienteLabel = new Label();
            maquinariaLabel = new Label();
            repuestoLabel = new Label();
            repuestoCheckedListBox = new CheckedListBox();
            maquinariaCheckedListBox = new CheckedListBox();
            clienteComboBox = new ComboBox();
            estadoTextBox = new TextBox();
            importeTotalTextBox = new TextBox();
            fechaTextBox = new TextBox();
            aceptarButton = new Button();
            cancelarButton = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new Point(75, 58);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new Size(38, 15);
            fechaLabel.TabIndex = 0;
            fechaLabel.Text = "Fecha";
            // 
            // importeTotalLabel
            // 
            importeTotalLabel.AutoSize = true;
            importeTotalLabel.Location = new Point(75, 90);
            importeTotalLabel.Name = "importeTotalLabel";
            importeTotalLabel.Size = new Size(77, 15);
            importeTotalLabel.TabIndex = 1;
            importeTotalLabel.Text = "Importe Total";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new Point(75, 122);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new Size(42, 15);
            estadoLabel.TabIndex = 2;
            estadoLabel.Text = "Estado";
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Location = new Point(75, 156);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new Size(44, 15);
            clienteLabel.TabIndex = 3;
            clienteLabel.Text = "Cliente";
            // 
            // maquinariaLabel
            // 
            maquinariaLabel.AutoSize = true;
            maquinariaLabel.Location = new Point(75, 191);
            maquinariaLabel.Name = "maquinariaLabel";
            maquinariaLabel.Size = new Size(67, 15);
            maquinariaLabel.TabIndex = 4;
            maquinariaLabel.Text = "Maquinaria";
            // 
            // repuestoLabel
            // 
            repuestoLabel.AutoSize = true;
            repuestoLabel.Location = new Point(75, 222);
            repuestoLabel.Name = "repuestoLabel";
            repuestoLabel.Size = new Size(56, 15);
            repuestoLabel.TabIndex = 5;
            repuestoLabel.Text = "Repuesto";
            // 
            // repuestoCheckedListBox
            // 
            repuestoCheckedListBox.FormattingEnabled = true;
            repuestoCheckedListBox.Location = new Point(168, 222);
            repuestoCheckedListBox.Name = "repuestoCheckedListBox";
            repuestoCheckedListBox.Size = new Size(120, 22);
            repuestoCheckedListBox.TabIndex = 6;
            // 
            // maquinariaCheckedListBox
            // 
            maquinariaCheckedListBox.FormattingEnabled = true;
            maquinariaCheckedListBox.Location = new Point(168, 191);
            maquinariaCheckedListBox.Name = "maquinariaCheckedListBox";
            maquinariaCheckedListBox.Size = new Size(120, 22);
            maquinariaCheckedListBox.TabIndex = 7;
            // 
            // clienteComboBox
            // 
            clienteComboBox.FormattingEnabled = true;
            clienteComboBox.Location = new Point(168, 156);
            clienteComboBox.Name = "clienteComboBox";
            clienteComboBox.Size = new Size(120, 23);
            clienteComboBox.TabIndex = 8;
            // 
            // estadoTextBox
            // 
            estadoTextBox.Location = new Point(168, 122);
            estadoTextBox.Name = "estadoTextBox";
            estadoTextBox.Size = new Size(120, 23);
            estadoTextBox.TabIndex = 9;
            // 
            // importeTotalTextBox
            // 
            importeTotalTextBox.Location = new Point(168, 90);
            importeTotalTextBox.Name = "importeTotalTextBox";
            importeTotalTextBox.Size = new Size(120, 23);
            importeTotalTextBox.TabIndex = 10;
            // 
            // fechaTextBox
            // 
            fechaTextBox.Location = new Point(168, 58);
            fechaTextBox.Name = "fechaTextBox";
            fechaTextBox.Size = new Size(120, 23);
            fechaTextBox.TabIndex = 11;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(168, 303);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 12;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(252, 303);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 13;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // VentaDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 338);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(fechaTextBox);
            Controls.Add(importeTotalTextBox);
            Controls.Add(estadoTextBox);
            Controls.Add(clienteComboBox);
            Controls.Add(maquinariaCheckedListBox);
            Controls.Add(repuestoCheckedListBox);
            Controls.Add(repuestoLabel);
            Controls.Add(maquinariaLabel);
            Controls.Add(clienteLabel);
            Controls.Add(estadoLabel);
            Controls.Add(importeTotalLabel);
            Controls.Add(fechaLabel);
            Name = "VentaDetalle";
            Text = "VentaDetalle";
            Load += VentaDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fechaLabel;
        private Label importeTotalLabel;
        private Label estadoLabel;
        private Label clienteLabel;
        private Label maquinariaLabel;
        private Label repuestoLabel;
        private CheckedListBox repuestoCheckedListBox;
        private CheckedListBox maquinariaCheckedListBox;
        private ComboBox clienteComboBox;
        private TextBox estadoTextBox;
        private TextBox importeTotalTextBox;
        private TextBox fechaTextBox;
        private Button aceptarButton;
        private Button cancelarButton;
        private ErrorProvider errorProvider;
    }
}
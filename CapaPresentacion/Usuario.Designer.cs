namespace CapaPresentacion
{
    partial class Usuario
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
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnValidar = new Button();
            lblcon = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 40);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 0;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 82);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 1;
            label2.Text = "CONTRASEÑA";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.Location = new Point(159, 37);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 29);
            txtUsuario.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtClave.Location = new Point(159, 79);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(150, 29);
            txtClave.TabIndex = 3;
            // 
            // btnValidar
            // 
            btnValidar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValidar.Location = new Point(112, 131);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(148, 33);
            btnValidar.TabIndex = 4;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblcon
            // 
            lblcon.AutoSize = true;
            lblcon.Location = new Point(20, 9);
            lblcon.Name = "lblcon";
            lblcon.Size = new Size(0, 15);
            lblcon.TabIndex = 5;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 203);
            Controls.Add(lblcon);
            Controls.Add(btnValidar);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Usuario";
            Text = "Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnValidar;
        public Label lblcon;
    }
}
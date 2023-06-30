namespace CapaPresentacion
{
    partial class Conexion
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
            BTNSQL = new Button();
            BTNMYSQL = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // BTNSQL
            // 
            BTNSQL.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTNSQL.Location = new Point(44, 138);
            BTNSQL.Name = "BTNSQL";
            BTNSQL.Size = new Size(109, 46);
            BTNSQL.TabIndex = 0;
            BTNSQL.Text = "SQL";
            BTNSQL.UseVisualStyleBackColor = true;
            BTNSQL.Click += BTNSQL_Click;
            // 
            // BTNMYSQL
            // 
            BTNMYSQL.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTNMYSQL.Location = new Point(264, 138);
            BTNMYSQL.Name = "BTNMYSQL";
            BTNMYSQL.Size = new Size(115, 46);
            BTNMYSQL.TabIndex = 1;
            BTNMYSQL.Text = "MYSQL";
            BTNMYSQL.UseVisualStyleBackColor = true;
            BTNMYSQL.Click += BTNMYSQL_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(103, 50);
            label1.Name = "label1";
            label1.Size = new Size(254, 25);
            label1.TabIndex = 2;
            label1.Text = "ELEGIR TIPO DE CONEXION";
            // 
            // Conexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 245);
            Controls.Add(label1);
            Controls.Add(BTNMYSQL);
            Controls.Add(BTNSQL);
            Name = "Conexion";
            Text = "Conexion";
            Load += Conexion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNSQL;
        private Button BTNMYSQL;
        private Label label1;
    }
}
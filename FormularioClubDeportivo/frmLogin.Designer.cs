namespace FormularioClubDeportivo
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            groupBox1 = new GroupBox();
            progressBarLogin = new ProgressBar();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnIngresar = new Button();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(progressBarLogin);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(43, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(917, 473);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese Usuario y Contraseña:";
            // 
            // progressBarLogin
            // 
            progressBarLogin.Location = new Point(314, 427);
            progressBarLogin.Name = "progressBarLogin";
            progressBarLogin.Size = new Size(603, 23);
            progressBarLogin.TabIndex = 3;
            progressBarLogin.Click += progressBarLogin_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(710, 358);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(115, 39);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(556, 358);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(115, 39);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(397, 358);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(115, 39);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 217);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 2;
            label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(397, 108);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 2;
            label1.Text = "USUARIO";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(584, 209);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(206, 29);
            txtPassword.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(584, 105);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(206, 29);
            txtUsuario.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 439);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(333, 35);
            label3.Name = "label3";
            label3.Size = new Size(334, 45);
            label3.TabIndex = 2;
            label3.Text = "ACCESO AL SISTEMA";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 616);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Name = "frmLogin";
            Text = "Sistema Club Deportivo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnIngresar;
        private Label label3;
        private ProgressBar progressBarLogin;
    }
}
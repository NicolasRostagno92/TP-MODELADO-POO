namespace FormularioClubDeportivo
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnActividadesDelClub = new Button();
            btnVolverAtras = new Button();
            btnSalir = new Button();
            btnListaCientes = new Button();
            btnPagarCuota = new Button();
            btnInscribirCliente = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(357, 25);
            label1.Name = "label1";
            label1.Size = new Size(558, 45);
            label1.TabIndex = 0;
            label1.Text = "¡BIENVENIDO AL CLUB DEPORTIVO!";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnActividadesDelClub);
            groupBox1.Controls.Add(btnVolverAtras);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnListaCientes);
            groupBox1.Controls.Add(btnPagarCuota);
            groupBox1.Controls.Add(btnInscribirCliente);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(51, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1077, 484);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sistema CLub Deportivo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnActividadesDelClub
            // 
            btnActividadesDelClub.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnActividadesDelClub.Location = new Point(735, 255);
            btnActividadesDelClub.Name = "btnActividadesDelClub";
            btnActividadesDelClub.Size = new Size(206, 90);
            btnActividadesDelClub.TabIndex = 0;
            btnActividadesDelClub.Text = "ACTIVIDADES DEL CLUB";
            btnActividadesDelClub.UseVisualStyleBackColor = true;
            // 
            // btnVolverAtras
            // 
            btnVolverAtras.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverAtras.Location = new Point(748, 424);
            btnVolverAtras.Name = "btnVolverAtras";
            btnVolverAtras.Size = new Size(116, 39);
            btnVolverAtras.TabIndex = 0;
            btnVolverAtras.Text = "ATRAS";
            btnVolverAtras.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(939, 424);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 39);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnListaCientes
            // 
            btnListaCientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnListaCientes.Location = new Point(389, 255);
            btnListaCientes.Name = "btnListaCientes";
            btnListaCientes.Size = new Size(206, 90);
            btnListaCientes.TabIndex = 0;
            btnListaCientes.Text = "LISTA DE CLIENTES";
            btnListaCientes.UseVisualStyleBackColor = true;
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagarCuota.Location = new Point(735, 101);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(206, 90);
            btnPagarCuota.TabIndex = 0;
            btnPagarCuota.Text = "PAGAR CUOTA";
            btnPagarCuota.UseVisualStyleBackColor = true;
            // 
            // btnInscribirCliente
            // 
            btnInscribirCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribirCliente.Location = new Point(389, 101);
            btnInscribirCliente.Name = "btnInscribirCliente";
            btnInscribirCliente.Size = new Size(206, 90);
            btnInscribirCliente.TabIndex = 0;
            btnInscribirCliente.Text = "INSCRIBIR CLIENTE";
            btnInscribirCliente.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 609);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmPrincipal";
            Text = "Pagina Principal";
            Load += frmPrincipal_Load_1;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnActividadesDelClub;
        private Button btnListaCientes;
        private Button btnPagarCuota;
        private Button btnInscribirCliente;
        private Button btnVolverAtras;
        private Button btnSalir;
        private PictureBox pictureBox1;
    }
}
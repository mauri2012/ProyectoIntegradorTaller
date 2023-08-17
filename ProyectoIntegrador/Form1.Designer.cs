namespace ProyectoIntegrador
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel3 = new Panel();
            BMaximizar = new PictureBox();
            BEsconder = new PictureBox();
            BRestaurar = new PictureBox();
            BCerrar = new PictureBox();
            LBienvenido = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BEsconder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(17, 97, 238);
            panel3.Controls.Add(BMaximizar);
            panel3.Controls.Add(BEsconder);
            panel3.Controls.Add(BRestaurar);
            panel3.Controls.Add(BCerrar);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 37);
            panel3.TabIndex = 2;
            // 
            // BMaximizar
            // 
            BMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMaximizar.Image = (Image)resources.GetObject("BMaximizar.Image");
            BMaximizar.Location = new Point(754, 12);
            BMaximizar.Name = "BMaximizar";
            BMaximizar.Size = new Size(15, 15);
            BMaximizar.TabIndex = 5;
            BMaximizar.TabStop = false;
            BMaximizar.Click += BMaximizar_Click;
            // 
            // BEsconder
            // 
            BEsconder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BEsconder.Image = (Image)resources.GetObject("BEsconder.Image");
            BEsconder.Location = new Point(733, 12);
            BEsconder.Name = "BEsconder";
            BEsconder.Size = new Size(15, 15);
            BEsconder.TabIndex = 4;
            BEsconder.TabStop = false;
            BEsconder.Click += BEsconder_Click;
            // 
            // BRestaurar
            // 
            BRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BRestaurar.Image = (Image)resources.GetObject("BRestaurar.Image");
            BRestaurar.Location = new Point(754, 12);
            BRestaurar.Name = "BRestaurar";
            BRestaurar.Size = new Size(15, 15);
            BRestaurar.TabIndex = 6;
            BRestaurar.TabStop = false;
            BRestaurar.Click += BRestaurar_Click;
            // 
            // BCerrar
            // 
            BCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCerrar.Image = (Image)resources.GetObject("BCerrar.Image");
            BCerrar.Location = new Point(775, 12);
            BCerrar.Name = "BCerrar";
            BCerrar.Size = new Size(15, 15);
            BCerrar.TabIndex = 3;
            BCerrar.TabStop = false;
            BCerrar.Click += pictureBox1_Click;
            // 
            // LBienvenido
            // 
            LBienvenido.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LBienvenido.AutoSize = true;
            LBienvenido.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBienvenido.Location = new Point(313, 116);
            LBienvenido.Name = "LBienvenido";
            LBienvenido.Size = new Size(97, 18);
            LBienvenido.TabIndex = 3;
            LBienvenido.Text = "Bienvenido";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Snow;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(271, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Snow;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(271, 235);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(198, 23);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 163);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 6;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 217);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 7;
            label2.Text = "Contraseña";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(17, 97, 238);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(271, 302);
            button1.Name = "button1";
            button1.Size = new Size(198, 38);
            button1.TabIndex = 8;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LBienvenido);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BEsconder).EndInit();
            ((System.ComponentModel.ISupportInitialize)BRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label LCerrar;
        private PictureBox BCerrar;
        private PictureBox BEsconder;
        private PictureBox BMaximizar;
        private PictureBox BRestaurar;
        private Label LBienvenido;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
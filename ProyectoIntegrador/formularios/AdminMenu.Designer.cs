﻿namespace ProyectoIntegrador.formularios
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            panel3 = new Panel();
            label3 = new Label();
            BMaximizar = new PictureBox();
            BEsconder = new PictureBox();
            BRestaurar = new PictureBox();
            BCerrar = new PictureBox();
            LBienvenido = new Label();
            panel7 = new Panel();
            dataGridView1 = new DataGridView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BEsconder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BCerrar).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(17, 97, 238);
            panel3.Controls.Add(label3);
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
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
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
            BCerrar.Click += BCerrar_Click;
            // 
            // LBienvenido
            // 
            LBienvenido.AutoSize = true;
            LBienvenido.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBienvenido.Location = new Point(43, 31);
            LBienvenido.Name = "LBienvenido";
            LBienvenido.Size = new Size(53, 18);
            LBienvenido.TabIndex = 3;
            LBienvenido.Text = "Aulas";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel7.Controls.Add(LBienvenido);
            panel7.Controls.Add(dataGridView1);
            panel7.Location = new Point(0, 37);
            panel7.Name = "panel7";
            panel7.Size = new Size(800, 413);
            panel7.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ButtonFace;
            dataGridView1.Location = new Point(12, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(736, 180);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 450);
            Controls.Add(panel7);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMenu";
            Text = "Menu";
            Load += AdminMenu_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BEsconder).EndInit();
            ((System.ComponentModel.ISupportInitialize)BRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BCerrar).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

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
        private Panel panel7;
        private Label label3;
        private DataGridView dataGridView1;
    }

    #endregion

}
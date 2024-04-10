namespace JogoGenius
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
            components = new System.ComponentModel.Container();
            btnVerde = new Button();
            btnAmarelo = new Button();
            btnAzul = new Button();
            btnVermelho = new Button();
            lblNivel = new Label();
            btnIniciar = new Button();
            lbnivel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnVerde
            // 
            btnVerde.FlatStyle = FlatStyle.Flat;
            btnVerde.Location = new Point(56, 65);
            btnVerde.Name = "btnVerde";
            btnVerde.Size = new Size(105, 83);
            btnVerde.TabIndex = 0;
            btnVerde.UseVisualStyleBackColor = true;
            btnVerde.Click += bt_click;
            // 
            // btnAmarelo
            // 
            btnAmarelo.FlatStyle = FlatStyle.Flat;
            btnAmarelo.Location = new Point(167, 65);
            btnAmarelo.Name = "btnAmarelo";
            btnAmarelo.Size = new Size(105, 83);
            btnAmarelo.TabIndex = 1;
            btnAmarelo.UseVisualStyleBackColor = true;
            btnAmarelo.Click += bt_click;
            // 
            // btnAzul
            // 
            btnAzul.FlatStyle = FlatStyle.Flat;
            btnAzul.Location = new Point(56, 154);
            btnAzul.Name = "btnAzul";
            btnAzul.Size = new Size(105, 83);
            btnAzul.TabIndex = 2;
            btnAzul.UseVisualStyleBackColor = true;
            btnAzul.Click += bt_click;
            // 
            // btnVermelho
            // 
            btnVermelho.FlatStyle = FlatStyle.Flat;
            btnVermelho.Location = new Point(167, 154);
            btnVermelho.Name = "btnVermelho";
            btnVermelho.Size = new Size(105, 83);
            btnVermelho.TabIndex = 3;
            btnVermelho.UseVisualStyleBackColor = true;
            btnVermelho.Click += bt_click;
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.BackColor = SystemColors.AppWorkspace;
            lblNivel.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNivel.ForeColor = Color.Blue;
            lblNivel.Location = new Point(65, 267);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(53, 22);
            lblNivel.TabIndex = 4;
            lblNivel.Text = "Nivel:";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.White;
            btnIniciar.FlatStyle = FlatStyle.System;
            btnIniciar.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.Red;
            btnIniciar.Location = new Point(106, 320);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(103, 41);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lbnivel
            // 
            lbnivel.AutoSize = true;
            lbnivel.BackColor = SystemColors.AppWorkspace;
            lbnivel.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnivel.ForeColor = SystemColors.ActiveCaptionText;
            lbnivel.Location = new Point(126, 267);
            lbnivel.Name = "lbnivel";
            lbnivel.Size = new Size(0, 21);
            lbnivel.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Interval = 250;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            CausesValidation = false;
            ClientSize = new Size(327, 405);
            Controls.Add(lbnivel);
            Controls.Add(btnIniciar);
            Controls.Add(lblNivel);
            Controls.Add(btnVermelho);
            Controls.Add(btnAzul);
            Controls.Add(btnAmarelo);
            Controls.Add(btnVerde);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Windows Genius";
            TransparencyKey = Color.White;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerde;
        private Button btnAmarelo;
        private Button btnAzul;
        private Button btnVermelho;
        private Label lblNivel;
        private Button btnIniciar;
        private Label lbnivel;
        private System.Windows.Forms.Timer timer1;
    }
}

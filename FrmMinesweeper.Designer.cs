namespace Minesweeper
{
    partial class FrmMinesweeper
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTemp = new System.Windows.Forms.Button();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblboom = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnTemp);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(674, 539);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(3, 3);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(70, 70);
            this.btnTemp.TabIndex = 0;
            this.btnTemp.Text = "1";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Visible = false;
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.BackColor = System.Drawing.Color.Gold;
            this.btnEmpezar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpezar.Location = new System.Drawing.Point(731, 469);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(263, 82);
            this.btnEmpezar.TabIndex = 2;
            this.btnEmpezar.Text = "Empezar Juego";
            this.btnEmpezar.UseVisualStyleBackColor = false;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.Location = new System.Drawing.Point(740, 185);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(110, 25);
            this.lblPuntuacion.TabIndex = 3;
            this.lblPuntuacion.Text = "Puntuacion";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Green;
            this.lblScore.Location = new System.Drawing.Point(907, 185);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(23, 25);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(736, 300);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(86, 25);
            this.lblAction.TabIndex = 5;
            this.lblAction.Text = "Booom!!";
            // 
            // lblboom
            // 
            this.lblboom.AutoSize = true;
            this.lblboom.BackColor = System.Drawing.Color.Red;
            this.lblboom.Location = new System.Drawing.Point(907, 300);
            this.lblboom.Name = "lblboom";
            this.lblboom.Size = new System.Drawing.Size(23, 25);
            this.lblboom.TabIndex = 6;
            this.lblboom.Text = "0";
            // 
            // FrmMinesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 596);
            this.Controls.Add(this.lblboom);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPuntuacion);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "FrmMinesweeper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMinesweeper";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblboom;
    }
}
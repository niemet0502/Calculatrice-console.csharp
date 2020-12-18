
namespace FirstForm
{
    partial class FrmVille
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
            this.lstVille = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSupprimerTout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVille
            // 
            this.lstVille.FormattingEnabled = true;
            this.lstVille.ItemHeight = 20;
            this.lstVille.Location = new System.Drawing.Point(64, 34);
            this.lstVille.Name = "lstVille";
            this.lstVille.Size = new System.Drawing.Size(226, 344);
            this.lstVille.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrez \r\nune nouvelle Ville";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(410, 117);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(275, 27);
            this.txtVille.TabIndex = 2;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(410, 199);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(94, 29);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(410, 273);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(94, 29);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnSupprimerTout
            // 
            this.btnSupprimerTout.Location = new System.Drawing.Point(410, 338);
            this.btnSupprimerTout.Name = "btnSupprimerTout";
            this.btnSupprimerTout.Size = new System.Drawing.Size(164, 29);
            this.btnSupprimerTout.TabIndex = 5;
            this.btnSupprimerTout.Text = "Supprimer Tout";
            this.btnSupprimerTout.UseVisualStyleBackColor = true;
            this.btnSupprimerTout.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSupprimerTout);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstVille);
            this.Name = "FrmVille";
            this.Text = "Formulaire Ville";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSupprimerTout;
    }
}


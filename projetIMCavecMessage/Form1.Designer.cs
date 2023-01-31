namespace projetIMCavecMessage
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonCalculer = new System.Windows.Forms.Button();
            this.ButtonAnnuler = new System.Windows.Forms.Button();
            this.ButtonTramsform = new System.Windows.Forms.Button();
            this.ButtonQuitter = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextPoids = new System.Windows.Forms.TextBox();
            this.TextTaille = new System.Windows.Forms.TextBox();
            this.TextResultat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCalculer
            // 
            this.ButtonCalculer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonCalculer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCalculer.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ButtonCalculer.Location = new System.Drawing.Point(611, 245);
            this.ButtonCalculer.Name = "ButtonCalculer";
            this.ButtonCalculer.Size = new System.Drawing.Size(104, 34);
            this.ButtonCalculer.TabIndex = 0;
            this.ButtonCalculer.Text = "Calculer";
            this.ButtonCalculer.UseVisualStyleBackColor = false;
            this.ButtonCalculer.Click += new System.EventHandler(this.ButtonCalculer_Click);
            // 
            // ButtonAnnuler
            // 
            this.ButtonAnnuler.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAnnuler.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ButtonAnnuler.Location = new System.Drawing.Point(721, 245);
            this.ButtonAnnuler.Name = "ButtonAnnuler";
            this.ButtonAnnuler.Size = new System.Drawing.Size(104, 34);
            this.ButtonAnnuler.TabIndex = 1;
            this.ButtonAnnuler.Text = "Annuler";
            this.ButtonAnnuler.UseVisualStyleBackColor = false;
            this.ButtonAnnuler.Click += new System.EventHandler(this.ButtonAnnuler_Click);
            // 
            // ButtonTramsform
            // 
            this.ButtonTramsform.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonTramsform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTramsform.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ButtonTramsform.Location = new System.Drawing.Point(611, 296);
            this.ButtonTramsform.Name = "ButtonTramsform";
            this.ButtonTramsform.Size = new System.Drawing.Size(104, 34);
            this.ButtonTramsform.TabIndex = 2;
            this.ButtonTramsform.Text = "Transformer";
            this.ButtonTramsform.UseVisualStyleBackColor = false;
            this.ButtonTramsform.Click += new System.EventHandler(this.button3_Click);
            // 
            // ButtonQuitter
            // 
            this.ButtonQuitter.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuitter.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ButtonQuitter.Location = new System.Drawing.Point(721, 296);
            this.ButtonQuitter.Name = "ButtonQuitter";
            this.ButtonQuitter.Size = new System.Drawing.Size(104, 34);
            this.ButtonQuitter.TabIndex = 3;
            this.ButtonQuitter.Text = "Quitter";
            this.ButtonQuitter.UseVisualStyleBackColor = false;
            this.ButtonQuitter.Click += new System.EventHandler(this.ButtonQuitter_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelName.Location = new System.Drawing.Point(621, 55);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(55, 20);
            this.LabelName.TabIndex = 4;
            this.LabelName.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(618, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(621, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Height";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(731, 52);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(100, 20);
            this.TextName.TabIndex = 7;
            // 
            // TextPoids
            // 
            this.TextPoids.Location = new System.Drawing.Point(731, 93);
            this.TextPoids.Name = "TextPoids";
            this.TextPoids.Size = new System.Drawing.Size(100, 20);
            this.TextPoids.TabIndex = 8;
            // 
            // TextTaille
            // 
            this.TextTaille.Location = new System.Drawing.Point(731, 138);
            this.TextTaille.Name = "TextTaille";
            this.TextTaille.Size = new System.Drawing.Size(100, 20);
            this.TextTaille.TabIndex = 9;
            // 
            // TextResultat
            // 
            this.TextResultat.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TextResultat.Location = new System.Drawing.Point(731, 187);
            this.TextResultat.Name = "TextResultat";
            this.TextResultat.Size = new System.Drawing.Size(100, 20);
            this.TextResultat.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(622, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Resultat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projetIMCavecMessage.Properties.Resources._0513vsm_Champion1;
            this.ClientSize = new System.Drawing.Size(852, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextResultat);
            this.Controls.Add(this.TextTaille);
            this.Controls.Add(this.TextPoids);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.ButtonQuitter);
            this.Controls.Add(this.ButtonTramsform);
            this.Controls.Add(this.ButtonAnnuler);
            this.Controls.Add(this.ButtonCalculer);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCalculer;
        private System.Windows.Forms.Button ButtonAnnuler;
        private System.Windows.Forms.Button ButtonTramsform;
        private System.Windows.Forms.Button ButtonQuitter;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox TextPoids;
        private System.Windows.Forms.TextBox TextTaille;
        private System.Windows.Forms.TextBox TextResultat;
        private System.Windows.Forms.Label label1;
    }
}


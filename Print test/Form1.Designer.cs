namespace Print_test
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
            this.PRINT_Button = new System.Windows.Forms.Button();
            this.STRING_TO_BE_PRINTED = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // PRINT_Button
            // 
            this.PRINT_Button.Location = new System.Drawing.Point(264, 70);
            this.PRINT_Button.Name = "PRINT_Button";
            this.PRINT_Button.Size = new System.Drawing.Size(67, 62);
            this.PRINT_Button.TabIndex = 0;
            this.PRINT_Button.Text = "PRINT";
            this.PRINT_Button.UseVisualStyleBackColor = true;
            this.PRINT_Button.Click += new System.EventHandler(this.PRINT_Button_Click);
            // 
            // STRING_TO_BE_PRINTED
            // 
            this.STRING_TO_BE_PRINTED.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STRING_TO_BE_PRINTED.Location = new System.Drawing.Point(43, 103);
            this.STRING_TO_BE_PRINTED.Name = "STRING_TO_BE_PRINTED";
            this.STRING_TO_BE_PRINTED.Size = new System.Drawing.Size(196, 29);
            this.STRING_TO_BE_PRINTED.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Text to be printed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 159);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.STRING_TO_BE_PRINTED);
            this.Controls.Add(this.PRINT_Button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "LabelManager PnP Print";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PRINT_Button;
        private System.Windows.Forms.TextBox STRING_TO_BE_PRINTED;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}


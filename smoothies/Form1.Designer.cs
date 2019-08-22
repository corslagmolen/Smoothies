namespace smoothies
{
    partial class Form1
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
            this.btnZoek = new System.Windows.Forms.Button();
            this.btnWisSelectie = new System.Windows.Forms.Button();
            this.btnWisIngredient = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.txbIngredient = new System.Windows.Forms.TextBox();
            this.livIngredienten = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnZoek
            // 
            this.btnZoek.Location = new System.Drawing.Point(12, 54);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(113, 20);
            this.btnZoek.TabIndex = 0;
            this.btnZoek.Text = "zoek in lijst";
            this.btnZoek.UseVisualStyleBackColor = true;
            // 
            // btnWisSelectie
            // 
            this.btnWisSelectie.Location = new System.Drawing.Point(12, 90);
            this.btnWisSelectie.Name = "btnWisSelectie";
            this.btnWisSelectie.Size = new System.Drawing.Size(113, 65);
            this.btnWisSelectie.TabIndex = 1;
            this.btnWisSelectie.Text = "Maak Selectie ongedaan";
            this.btnWisSelectie.UseVisualStyleBackColor = true;
            // 
            // btnWisIngredient
            // 
            this.btnWisIngredient.Location = new System.Drawing.Point(12, 173);
            this.btnWisIngredient.Name = "btnWisIngredient";
            this.btnWisIngredient.Size = new System.Drawing.Size(113, 65);
            this.btnWisIngredient.TabIndex = 2;
            this.btnWisIngredient.Text = "Verwijder ingredient";
            this.btnWisIngredient.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 20);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Einde";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(71, 25);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(54, 13);
            this.lblIngredient.TabIndex = 4;
            this.lblIngredient.Text = "Ingredient";
            // 
            // txbIngredient
            // 
            this.txbIngredient.Location = new System.Drawing.Point(153, 25);
            this.txbIngredient.Name = "txbIngredient";
            this.txbIngredient.Size = new System.Drawing.Size(193, 20);
            this.txbIngredient.TabIndex = 5;
            // 
            // livIngredienten
            // 
            this.livIngredienten.Location = new System.Drawing.Point(153, 54);
            this.livIngredienten.Name = "livIngredienten";
            this.livIngredienten.Size = new System.Drawing.Size(193, 229);
            this.livIngredienten.TabIndex = 6;
            this.livIngredienten.UseCompatibleStateImageBehavior = false;
            this.livIngredienten.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.LivIngredienten_DrawColumnHeader);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.livIngredienten);
            this.Controls.Add(this.txbIngredient);
            this.Controls.Add(this.lblIngredient);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWisIngredient);
            this.Controls.Add(this.btnWisSelectie);
            this.Controls.Add(this.btnZoek);
            this.Name = "Form1";
            this.Text = "Smoothies";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZoek;
        private System.Windows.Forms.Button btnWisSelectie;
        private System.Windows.Forms.Button btnWisIngredient;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.TextBox txbIngredient;
        private System.Windows.Forms.ListView livIngredienten;
    }
}


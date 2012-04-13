namespace ChatCSharp.UI.Windows.Views
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seConnecterÀToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoyerUnFihierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igniorerContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenirDeLaideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réaccepterContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seConnecterÀToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.helpsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seConnecterÀToolStripMenuItem
            // 
            this.seConnecterÀToolStripMenuItem.Name = "seConnecterÀToolStripMenuItem";
            this.seConnecterÀToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.seConnecterÀToolStripMenuItem.Text = "Se Connecter à";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.envoyerUnFihierToolStripMenuItem,
            this.igniorerContactToolStripMenuItem,
            this.réaccepterContactToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // envoyerUnFihierToolStripMenuItem
            // 
            this.envoyerUnFihierToolStripMenuItem.Name = "envoyerUnFihierToolStripMenuItem";
            this.envoyerUnFihierToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.envoyerUnFihierToolStripMenuItem.Text = "Envoyer Un Fihier";
            // 
            // igniorerContactToolStripMenuItem
            // 
            this.igniorerContactToolStripMenuItem.Name = "igniorerContactToolStripMenuItem";
            this.igniorerContactToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.igniorerContactToolStripMenuItem.Text = "Igniorer Contact";
            // 
            // helpsToolStripMenuItem
            // 
            this.helpsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obtenirDeLaideToolStripMenuItem,
            this.aProposDeToolStripMenuItem});
            this.helpsToolStripMenuItem.Name = "helpsToolStripMenuItem";
            this.helpsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.helpsToolStripMenuItem.Text = "helps";
            this.helpsToolStripMenuItem.Click += new System.EventHandler(this.helpsToolStripMenuItem_Click);
            // 
            // obtenirDeLaideToolStripMenuItem
            // 
            this.obtenirDeLaideToolStripMenuItem.Name = "obtenirDeLaideToolStripMenuItem";
            this.obtenirDeLaideToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.obtenirDeLaideToolStripMenuItem.Text = "Obtenir De L\'aide";
            // 
            // aProposDeToolStripMenuItem
            // 
            this.aProposDeToolStripMenuItem.Name = "aProposDeToolStripMenuItem";
            this.aProposDeToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.aProposDeToolStripMenuItem.Text = "A Propos De";
            // 
            // réaccepterContactToolStripMenuItem
            // 
            this.réaccepterContactToolStripMenuItem.Name = "réaccepterContactToolStripMenuItem";
            this.réaccepterContactToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.réaccepterContactToolStripMenuItem.Text = "Réaccepter Contact";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 337);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seConnecterÀToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envoyerUnFihierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igniorerContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenirDeLaideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réaccepterContactToolStripMenuItem;
    }
}


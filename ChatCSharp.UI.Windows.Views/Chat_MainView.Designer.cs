namespace ChatCSharp.UI.Windows.Views
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.seConnecterÀToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoyerUnFihierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igniorerContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réaccepterContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenirDeLaideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listContact = new System.Windows.Forms.ListBox();
            this.rb_affichage = new System.Windows.Forms.RichTextBox();
            this.tb_message = new System.Windows.Forms.RichTextBox();
            this.tabChat = new System.Windows.Forms.TabControl();
            this.mainchat = new System.Windows.Forms.TabPage();
            this.menu.SuspendLayout();
            this.tabChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seConnecterÀToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.helpsToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(790, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
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
            // réaccepterContactToolStripMenuItem
            // 
            this.réaccepterContactToolStripMenuItem.Name = "réaccepterContactToolStripMenuItem";
            this.réaccepterContactToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.réaccepterContactToolStripMenuItem.Text = "Réaccepter Contact";
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
            // listContact
            // 
            this.listContact.FormattingEnabled = true;
            this.listContact.ItemHeight = 16;
            this.listContact.Items.AddRange(new object[] {
            "yousra",
            "shazad",
            "jimmy"});
            this.listContact.Location = new System.Drawing.Point(8, 40);
            this.listContact.Name = "listContact";
            this.listContact.Size = new System.Drawing.Size(120, 324);
            this.listContact.TabIndex = 1;
            this.listContact.SelectedIndexChanged += new System.EventHandler(this.listContact_SelectedIndexChanged);
            // 
            // rb_affichage
            // 
            this.rb_affichage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_affichage.BackColor = System.Drawing.Color.White;
            this.rb_affichage.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_affichage.Location = new System.Drawing.Point(135, 65);
            this.rb_affichage.Margin = new System.Windows.Forms.Padding(4);
            this.rb_affichage.Name = "rb_affichage";
            this.rb_affichage.ReadOnly = true;
            this.rb_affichage.Size = new System.Drawing.Size(642, 221);
            this.rb_affichage.TabIndex = 3;
            this.rb_affichage.TabStop = false;
            this.rb_affichage.Text = "";
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(135, 293);
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(642, 62);
            this.tb_message.TabIndex = 4;
            this.tb_message.Text = "";
            // 
            // tabChat
            // 
            this.tabChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabChat.Controls.Add(this.mainchat);
            this.tabChat.Location = new System.Drawing.Point(135, 40);
            this.tabChat.Margin = new System.Windows.Forms.Padding(4);
            this.tabChat.Name = "tabChat";
            this.tabChat.SelectedIndex = 0;
            this.tabChat.Size = new System.Drawing.Size(642, 28);
            this.tabChat.TabIndex = 5;
            this.tabChat.TabStop = false;
            // 
            // mainchat
            // 
            this.mainchat.ForeColor = System.Drawing.Color.Black;
            this.mainchat.Location = new System.Drawing.Point(4, 25);
            this.mainchat.Margin = new System.Windows.Forms.Padding(4);
            this.mainchat.Name = "mainchat";
            this.mainchat.Padding = new System.Windows.Forms.Padding(4);
            this.mainchat.Size = new System.Drawing.Size(634, 0);
            this.mainchat.TabIndex = 0;
            this.mainchat.Text = "yousra";
            this.mainchat.UseVisualStyleBackColor = true;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 367);
            this.Controls.Add(this.tabChat);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.rb_affichage);
            this.Controls.Add(this.listContact);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Chat";
            this.Text = "ChatWizzzz";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabChat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem seConnecterÀToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envoyerUnFihierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igniorerContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenirDeLaideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réaccepterContactToolStripMenuItem;
        private System.Windows.Forms.ListBox listContact;
        public System.Windows.Forms.RichTextBox rb_affichage;
        private System.Windows.Forms.RichTextBox tb_message;
        public System.Windows.Forms.TabControl tabChat;
        private System.Windows.Forms.TabPage mainchat;
    }
}


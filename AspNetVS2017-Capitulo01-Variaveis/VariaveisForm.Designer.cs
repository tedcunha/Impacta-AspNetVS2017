namespace AspNetVS2017_Capitulo01_Variaveis
{
    partial class VariaveisForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opercoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aritimeticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduzidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incrmentaisDecrementaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booleanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoListBox = new System.Windows.Forms.ListBox();
            this.ternariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opercoesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(319, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opercoesToolStripMenuItem
            // 
            this.opercoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aritimeticasToolStripMenuItem,
            this.reduzidasToolStripMenuItem,
            this.incrmentaisDecrementaisToolStripMenuItem,
            this.booleanasToolStripMenuItem,
            this.logicasToolStripMenuItem,
            this.ternariasToolStripMenuItem});
            this.opercoesToolStripMenuItem.Name = "opercoesToolStripMenuItem";
            this.opercoesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.opercoesToolStripMenuItem.Text = "&Operações";
            // 
            // aritimeticasToolStripMenuItem
            // 
            this.aritimeticasToolStripMenuItem.Name = "aritimeticasToolStripMenuItem";
            this.aritimeticasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.aritimeticasToolStripMenuItem.Text = "&Aritiméticas";
            this.aritimeticasToolStripMenuItem.Click += new System.EventHandler(this.aritimeticasToolStripMenuItem_Click);
            // 
            // reduzidasToolStripMenuItem
            // 
            this.reduzidasToolStripMenuItem.Name = "reduzidasToolStripMenuItem";
            this.reduzidasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.reduzidasToolStripMenuItem.Text = "&Reduzidas";
            this.reduzidasToolStripMenuItem.Click += new System.EventHandler(this.reduzidasToolStripMenuItem_Click);
            // 
            // incrmentaisDecrementaisToolStripMenuItem
            // 
            this.incrmentaisDecrementaisToolStripMenuItem.Name = "incrmentaisDecrementaisToolStripMenuItem";
            this.incrmentaisDecrementaisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.incrmentaisDecrementaisToolStripMenuItem.Text = "&Incrmentais/Decrementais";
            this.incrmentaisDecrementaisToolStripMenuItem.Click += new System.EventHandler(this.incrmentaisDecrementaisToolStripMenuItem_Click);
            // 
            // booleanasToolStripMenuItem
            // 
            this.booleanasToolStripMenuItem.Name = "booleanasToolStripMenuItem";
            this.booleanasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.booleanasToolStripMenuItem.Text = "&Booleanas";
            this.booleanasToolStripMenuItem.Click += new System.EventHandler(this.booleanasToolStripMenuItem_Click);
            // 
            // logicasToolStripMenuItem
            // 
            this.logicasToolStripMenuItem.Name = "logicasToolStripMenuItem";
            this.logicasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.logicasToolStripMenuItem.Text = "&Lógicas";
            this.logicasToolStripMenuItem.Click += new System.EventHandler(this.logicasToolStripMenuItem_Click);
            // 
            // resultadoListBox
            // 
            this.resultadoListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultadoListBox.FormattingEnabled = true;
            this.resultadoListBox.Location = new System.Drawing.Point(0, 24);
            this.resultadoListBox.Name = "resultadoListBox";
            this.resultadoListBox.Size = new System.Drawing.Size(319, 262);
            this.resultadoListBox.TabIndex = 1;
            // 
            // ternariasToolStripMenuItem
            // 
            this.ternariasToolStripMenuItem.Name = "ternariasToolStripMenuItem";
            this.ternariasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.ternariasToolStripMenuItem.Text = "Ternárias";
            this.ternariasToolStripMenuItem.Click += new System.EventHandler(this.ternariasToolStripMenuItem_Click);
            // 
            // VariaveisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 286);
            this.Controls.Add(this.resultadoListBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "VariaveisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Váriaveis e Operações";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opercoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritimeticasToolStripMenuItem;
        private System.Windows.Forms.ListBox resultadoListBox;
        private System.Windows.Forms.ToolStripMenuItem reduzidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incrmentaisDecrementaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booleanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ternariasToolStripMenuItem;
    }
}
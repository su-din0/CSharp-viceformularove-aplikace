namespace _07
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.objednávkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oknoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nováToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vymazatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vymazatVšeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecAplikaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objednávkaToolStripMenuItem,
            this.oknoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.oknoToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // objednávkaToolStripMenuItem
            // 
            this.objednávkaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nováToolStripMenuItem,
            this.vymazatToolStripMenuItem,
            this.vymazatVšeToolStripMenuItem,
            this.konecAplikaceToolStripMenuItem});
            this.objednávkaToolStripMenuItem.Name = "objednávkaToolStripMenuItem";
            this.objednávkaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.objednávkaToolStripMenuItem.Text = "Objednávka";
            // 
            // oknoToolStripMenuItem
            // 
            this.oknoToolStripMenuItem.Name = "oknoToolStripMenuItem";
            this.oknoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.oknoToolStripMenuItem.Text = "Okno";
            // 
            // nováToolStripMenuItem
            // 
            this.nováToolStripMenuItem.Name = "nováToolStripMenuItem";
            this.nováToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nováToolStripMenuItem.Text = "Nová";
            this.nováToolStripMenuItem.Click += new System.EventHandler(this.nováToolStripMenuItem_Click);
            // 
            // vymazatToolStripMenuItem
            // 
            this.vymazatToolStripMenuItem.Name = "vymazatToolStripMenuItem";
            this.vymazatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vymazatToolStripMenuItem.Text = "Vymazat";
            this.vymazatToolStripMenuItem.Click += new System.EventHandler(this.vymazatToolStripMenuItem_Click);
            // 
            // vymazatVšeToolStripMenuItem
            // 
            this.vymazatVšeToolStripMenuItem.Name = "vymazatVšeToolStripMenuItem";
            this.vymazatVšeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vymazatVšeToolStripMenuItem.Text = "Vymazat vše";
            this.vymazatVšeToolStripMenuItem.Click += new System.EventHandler(this.vymazatVšeToolStripMenuItem_Click);
            // 
            // konecAplikaceToolStripMenuItem
            // 
            this.konecAplikaceToolStripMenuItem.Name = "konecAplikaceToolStripMenuItem";
            this.konecAplikaceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.konecAplikaceToolStripMenuItem.Text = "Konec aplikace";
            this.konecAplikaceToolStripMenuItem.Click += new System.EventHandler(this.konecAplikaceToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
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
        private System.Windows.Forms.ToolStripMenuItem objednávkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nováToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vymazatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vymazatVšeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konecAplikaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oknoToolStripMenuItem;
    }
}


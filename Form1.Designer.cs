
namespace TheMeasurer
{
    partial class FormMeasurer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeasurer));
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.режимПеретаскиванияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.координатыНачалаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.непрозрачночтьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PB = new System.Windows.Forms.PictureBox();
            this.contextMenuStripTray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIconTray
            // 
            this.notifyIconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTray.Icon")));
            this.notifyIconTray.Text = "notifyIconTray";
            this.notifyIconTray.Visible = true;
            // 
            // contextMenuStripTray
            // 
            this.contextMenuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.режимПеретаскиванияToolStripMenuItem,
            this.координатыНачалаToolStripMenuItem,
            this.непрозрачночтьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выйтиToolStripMenuItem});
            this.contextMenuStripTray.Name = "contextMenuStripTray";
            this.contextMenuStripTray.Size = new System.Drawing.Size(204, 98);
            // 
            // режимПеретаскиванияToolStripMenuItem
            // 
            this.режимПеретаскиванияToolStripMenuItem.CheckOnClick = true;
            this.режимПеретаскиванияToolStripMenuItem.Name = "режимПеретаскиванияToolStripMenuItem";
            this.режимПеретаскиванияToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.режимПеретаскиванияToolStripMenuItem.Text = "Режим перетаскивания";
            this.режимПеретаскиванияToolStripMenuItem.Click += new System.EventHandler(this.режимПеретаскиванияToolStripMenuItem_Click);
            // 
            // координатыНачалаToolStripMenuItem
            // 
            this.координатыНачалаToolStripMenuItem.CheckOnClick = true;
            this.координатыНачалаToolStripMenuItem.Name = "координатыНачалаToolStripMenuItem";
            this.координатыНачалаToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.координатыНачалаToolStripMenuItem.Text = "Координаты начала";
            this.координатыНачалаToolStripMenuItem.Click += new System.EventHandler(this.координатыНачалаToolStripMenuItem_Click);
            // 
            // непрозрачночтьToolStripMenuItem
            // 
            this.непрозрачночтьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.непрозрачночтьToolStripMenuItem.Name = "непрозрачночтьToolStripMenuItem";
            this.непрозрачночтьToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.непрозрачночтьToolStripMenuItem.Text = "Непрозрачночть";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(89, 22);
            this.toolStripMenuItem2.Text = "0,1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Opacity_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(89, 22);
            this.toolStripMenuItem3.Text = "0,3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.Opacity_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(89, 22);
            this.toolStripMenuItem4.Text = "0,5";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.Opacity_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(89, 22);
            this.toolStripMenuItem5.Text = "0,8";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.Opacity_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // PB
            // 
            this.PB.Cursor = System.Windows.Forms.Cursors.Default;
            this.PB.Location = new System.Drawing.Point(0, 0);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(374, 273);
            this.PB.TabIndex = 1;
            this.PB.TabStop = false;
            this.PB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PB_MouseClick);
            this.PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMeasurer_MouseDown);
            this.PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMeasurer_MouseMove);
            this.PB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMeasurer_MouseUp);
            // 
            // FormMeasurer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(713, 507);
            this.Controls.Add(this.PB);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMeasurer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheMeasurer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMeasurer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMeasurer_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMeasurer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMeasurer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMeasurer_MouseUp);
            this.contextMenuStripTray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconTray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.ToolStripMenuItem непрозрачночтьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem режимПеретаскиванияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem координатыНачалаToolStripMenuItem;
    }
}


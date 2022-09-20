using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheMeasurer
{
    public partial class FormMeasurer : Form
    {
        int XStart, YStart, rectWidth, rectHeight;
        private Point pointStart;
        private Point rectStart;
        private bool movingMode = false;
        private bool dragNow = false;
        private const int CORECTPOS = 8; // смещение точки рисования под угол курсора

        public FormMeasurer()
        {
            InitializeComponent();
            notifyIconTray.MouseClick += new MouseEventHandler(notifyIcon_MouseClick);
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void FormMeasurer_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.3;
            this.FormBorderStyle = FormBorderStyle.None;
            PB.Height = this.Height;
            PB.Width = this.Width;
            //this.AllowTransparency = true;
            //this.BackColor = Color.AliceBlue;//цвет фона  
            //this.TransparencyKey = this.BackColor;//он же будет заменен на прозрачный цвет
        }

        private void PB_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PB.ContextMenuStrip = contextMenuStripTray;
            }
        }
        private void FormMeasurer_MouseDown(object sender, MouseEventArgs e)
        {
            pointStart = new Point(MousePosition.X, MousePosition.Y);
            var pic = (PictureBox)sender;
            if (movingMode)
            {
                rectStart = new Point(XStart, YStart);
                if (PointInRectangle()) dragNow = true;
            }
        }

        private void FormMeasurer_MouseUp(object sender, MouseEventArgs e)
        {
            pointStart = Point.Empty;
            dragNow = false;
        }

        private bool PointInRectangle()
        {
            return (MousePosition.X > XStart && MousePosition.Y > YStart && MousePosition.X < (XStart + rectWidth) && MousePosition.Y < (YStart + rectHeight));
        }

        private void FormMeasurer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) return;
            if (pointStart == Point.Empty) return;

            PointCalculation();
            DrawRectangle(sender);
        }

        private void PointCalculation()
        {
            if (dragNow)
            {
                //MessageBox.Show("XStart=" + XStart + "\n=MousePosition.X" + MousePosition.X + "\npointStart.X" + pointStart.X);
                XStart = rectStart.X + MousePosition.X - pointStart.X;
                YStart = rectStart.Y + MousePosition.Y - pointStart.Y;
            }
            else
            {
                if (pointStart.X < MousePosition.X)
                {
                    XStart = pointStart.X;
                    rectWidth = MousePosition.X - XStart;
                }
                else
                {
                    XStart = MousePosition.X;
                    rectWidth = pointStart.X - XStart;
                }

                if (pointStart.Y < MousePosition.Y)
                {
                    YStart = pointStart.Y;
                    rectHeight = MousePosition.Y - YStart;
                }
                else
                {
                    YStart = MousePosition.Y;
                    rectHeight = pointStart.Y - YStart;
                }
            }
        }

        private void DrawRectangle(object sender)
        {
            var pic = (PictureBox)sender;
            if (pic.Image == null) { pic.Image = new Bitmap(pic.Width, pic.Height); }
            SolidBrush myBrush = new SolidBrush(Color.Red);
            using (Graphics g = pic.CreateGraphics())
            {
                pic.Refresh();
                var rect = new Rectangle(XStart + CORECTPOS, YStart + CORECTPOS, rectWidth, rectHeight);
                g.FillRectangle(myBrush, rect);


                var fontColor = Brushes.LightGoldenrodYellow;
                Point pointTextStart = new Point(XStart + CORECTPOS, YStart + CORECTPOS);
                var checkWidth = координатыНачалаToolStripMenuItem.Checked ? 200 : 100;
                if (rect.Height < 25 || rect.Width < checkWidth)
                {
                    pointTextStart.Y = YStart - 20;
                    fontColor = Brushes.Black;
                }

                var str = rect.Height + "X" + rect.Width;
                if (координатыНачалаToolStripMenuItem.Checked) str += " (" + YStart  + "x" + XStart + ")";

                using (Font myFont = new Font("Arial", 14, FontStyle.Bold))
                {
                    g.DrawString(str, myFont, fontColor, new RectangleF(pointTextStart, new SizeF(200, 30)));// XStart + XEnd, YStart + YEnd);
                    g.DrawString(str, myFont, Brushes.Black, new RectangleF(10, this.Height - 30, 200, 30));
                    g.DrawString(str, myFont, Brushes.Black, new RectangleF(this.Width - 200, this.Height - 30, 200, 30));
                    g.DrawString(str, myFont, Brushes.Black, new RectangleF(this.Width - 200, 10, 200, 30));
                    g.DrawString(str, myFont, Brushes.Black, new RectangleF(10, 10, 200, 30));
                }
            }
        }

        private void Opacity_Click(object sender, EventArgs e)
        {
            this.Opacity = Convert.ToDouble(((ToolStripMenuItem)sender).Text);
        }

        private void режимПеретаскиванияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (режимПеретаскиванияToolStripMenuItem.Checked)
                movingMode = true;
            else
                movingMode = false;
        }


        #region TRAY
        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                notifyIconTray.ContextMenuStrip = contextMenuStripTray;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                //this.Visible = true;
            }
        }


        private void координатыНачалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawRectangle(this.PB);
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void FormMeasurer_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape) this.Close();
            //if (e.KeyCode == Keys.Escape) this.WindowState = FormWindowState.Minimized;

            if      (e.KeyCode == Keys.Up && e.Modifiers == Keys.Shift) {if (rectHeight > 0) rectHeight--;}
            else if (e.KeyCode == Keys.Down && e.Modifiers == Keys.Shift) rectHeight++;
            else if (e.KeyCode == Keys.Left && e.Modifiers == Keys.Shift) { if (rectWidth > 0) rectWidth--;}
            else if (e.KeyCode == Keys.Right && e.Modifiers == Keys.Shift) rectWidth++;
            else if (e.KeyCode == Keys.Up && e.Shift && e.Control) {if (rectHeight > 0) rectHeight -= 10;}
            else if (e.KeyCode == Keys.Down && e.Shift && e.Control) rectHeight += 10;
            else if (e.KeyCode == Keys.Left && e.Shift && e.Control) {if (rectWidth > 0) rectWidth -= 10;}
            else if (e.KeyCode == Keys.Right && e.Shift && e.Control) rectWidth += 10;
            else if (e.KeyCode == Keys.Up && e.Control) rectStep(0, -10);
            else if (e.KeyCode == Keys.Down && e.Control) rectStep(0, 10);
            else if (e.KeyCode == Keys.Left && e.Control) rectStep(-10, 0);
            else if (e.KeyCode == Keys.Right && e.Control) rectStep(10, 0);
            else if (e.KeyCode == Keys.Up) rectStep(0, -1);
            else if (e.KeyCode == Keys.Down) rectStep(0, 1);
            else if (e.KeyCode == Keys.Left) rectStep(-1, 0);
            else if (e.KeyCode == Keys.Right) rectStep(1, 0);
            else return;

            //DrawRectangle(((FormMeasurer)sender).PB);
            DrawRectangle(this.PB);
        }

        private void rectStep(int XStep, int YStep)
        {
            if (XStart > 0) XStart += XStep;
            if (YStart > 0) YStart += YStep;
        }
    }
}

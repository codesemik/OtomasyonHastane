using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace OtomasyonHastane.Scripts
{
    public class CustomButton : Button
    {
        // Fields
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.PaleVioletRed;

        // Properties
        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate(); // UI güncellemesi için
            }
        }

        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate(); // UI güncellemesi için
            }
        }

        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate(); // UI güncellemesi için
            }
        }

        [Category("RJ Code Advance")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("RJ Code Advance")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        // Constructor
        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue; // Default background color
            this.ForeColor = Color.White; // Default text color
            this.Resize += new EventHandler(Button_Resize);
        }

        // Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Create the rectangle for the button
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;

            // Update smoothing size if border is present
            if (borderSize > 0)
                smoothSize = borderSize;

            // Check if the button has rounded corners
            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    // Set the button's region to the rounded path
                    this.Region = new Region(pathSurface);
                    // Draw surface border
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    // If border size is at least 1, draw the control border
                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else // If the button doesn't have rounded corners
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                // Set the region to the button's surface area
                this.Region = new Region(rectSurface);

                // If border size is at least 1, draw the border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            // Event handler for Parent.BackColorChanged
            if (this.Parent != null)
            {
                this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
            }
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            // Invalidate the button when the parent background color changes
            this.Invalidate();
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            // Ensure borderRadius doesn't exceed the height of the button
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }
    }
}

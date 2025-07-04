﻿using Supermarket.View.User_Controls.SignInControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.View.Forms
{
    public partial class RoundFormLogin : Form
    {
        private int borderRadius = 50;
        private int borderSize = 0;
        private Color borderColor = Color.White;

        public RoundFormLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.panelTitleBar.BackColor = borderColor;
            this.BackColor=borderColor;
            // LoginForm signInForm = new LoginForm();
            // signInForm.TopLevel = false;
            // panelContainer.Controls.Add(signInForm);
            // signInForm.Dock = DockStyle.Fill;
            // signInForm.Show();
            //SignIn signIn = new SignIn(pnlContainer);
            //pnlContainer.Controls.Add(signIn);
            //signIn.Dock = DockStyle.Fill;
            //signIn.Show();
            //makeFormMovable();
        }

        [DllImport("user32.DLL",EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void RoundForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
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

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);

                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);

                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private void DrawPath(Rectangle rect,Graphics graph,Color color)
        {
            using(GraphicsPath roundPath = GetRoundedPath(rect,borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }

        }

        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);

                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);

                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);

                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);

                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidth =rectForm.Width/2;
            int mHeight =rectForm.Height/2;
            var fbColors = GetFormBoundsColors();


            //top left
            DrawPath(rectForm,e.Graphics,fbColors.TopLeftColor);

            //topRight
            Rectangle rectTopRight = new Rectangle(mWidth,rectForm.Y,mWidth,mHeight);
            DrawPath(rectTopRight,e.Graphics,fbColors.TopRightColor);

            //Buttom left
            Rectangle rectButtomLeft = new Rectangle(rectForm.X, rectForm.X+mHeight, mWidth, mHeight);
            DrawPath(rectButtomLeft, e.Graphics, fbColors.BottomLeftColor);

            //ButtomRight
            Rectangle rectButtomRight = new Rectangle(mWidth, rectForm.Y+mHeight, mWidth, mHeight);
            DrawPath(rectButtomRight, e.Graphics, fbColors.BottomRightColor);


        }

        private void RoundForm_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize); 
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(panelContainer, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }

        private void RoundForm_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void RoundForm_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void RoundForm_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        void makeFormMovable()
        {
            foreach (Control control in panelContainer.Controls)
            {
                control.MouseDown += (object sender, MouseEventArgs e) =>
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, 0x112, 0xf012, 0);
                };
                if (control.Controls.Count > 0)
                {
                    foreach (Control innerControl in control.Controls)
                    {
                        innerControl.MouseDown += (object sender, MouseEventArgs e) =>
                        {
                            ReleaseCapture();
                            SendMessage(this.Handle, 0x112, 0xf012, 0);
                        };
                        if (innerControl.Controls.Count > 0)
                        {
                            foreach (Control innerInnerControl in innerControl.Controls)
                            {
                                innerInnerControl.MouseDown += (object sender, MouseEventArgs e) =>
                                {
                                    ReleaseCapture();
                                    SendMessage(this.Handle, 0x112, 0xf012, 0);
                                };
                            }
                        }
                    }
                }
            }
        }

    }
}

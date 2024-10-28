/*
 * Create and develope by Hoai Thanh Trinh , now in EtechVn SJC
 * 
 * Nick:trinhhoaithanh1905
 * 
 * Email :hoaithanhtrinh@gmail.com
 * 
 * This code is free.
 * 
 * Detail :
 * 1. TextType : Type of text-effect to draw 
 * 2. FillColor: options
 * 3. BorderColor :
 * 4.PenWidth :
 * 5.GradientColor
 * 6.CAPTION : Label to draw 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace CzaryText.Control
{
    public partial class DrawShape : UserControl
    {
        #region Private properties
        //Hinh chu nhat nay dung de ve 
        RectangleF rect;

        private Color fillColor = Color.Black;
        private Color boderColor = Color.Black;

        private Color shadowColor = Color.White;
        private int shadowOpacity = 50;

       
        //Gradient = Fill Color + Mau thu 2 gdColor
        private Color gdColor = Color.Black;
       
        private int boderPenWidth=2;
        private int penSize = 48;

        private Font font;

        private TextType type = TextType.None;
        public TextType TextType
        {
            get { return type; }
            set { type = value; this.Invalidate(); }
        }


        private string txt = "Draw";
        private string fontName = "Arial Black";
        public StringAlignment lineAlignment = StringAlignment.Center;
        public  string Caption
        {
            get { return txt; }
            set { txt = value; }
        }
        //private FontFamily fontFamily = new FontFamily(this.Font.Name);

        private StringFormat strFormat = new StringFormat();

        #endregion

        #region Public properties
        /// <summary>
        /// Mau to chu
        /// </summary>
        public Color FillColor
        {
            get { return fillColor; }
            set { fillColor = value; this.Invalidate(); }
        }

        /// <summary>
        /// Mau vien
        /// </summary>
        public Color BoderColor
        {
            get { return boderColor; }
            set { boderColor = value; this.Invalidate(); }
        }

        /// <summary>
        /// Mau ve 2
        /// </summary>
        public Color GradientColor
        {
            get { return gdColor; }
            set { gdColor = value; this.Invalidate(); }
        }


        /// <summary>
        /// Shadow Corlor
        /// </summary>
        public Color ShadowColor
        {
            get { return shadowColor; }
            set { shadowColor = value; this.Invalidate(); }
        }

        /// <summary>
        /// Mau ve 2
        /// </summary>
        public int ShadowOpacity
        {
            get { return shadowOpacity; }
            set { shadowOpacity = value; this.Invalidate(); }
        }
        
        /// <summary>
        /// Do rong but mau ve vien
        /// </summary>
        public int BoderPenWidth
        {
            get { return boderPenWidth; }
            set { boderPenWidth = value; }
        }

        /// <summary>
        /// Do rong but mau ve vien
        /// </summary>
        public int PenSize
        {
            get { return penSize; }
            set { penSize = value;}
        }

        /// <summary>
        /// Font name
        /// </summary>
        public string FontName
        {
            get { return fontName; }
            set { fontName = value; }
        }
        #endregion

        #region Private Method

        private GraphicsPath GetStringPath(RectangleF rect)
        {
            strFormat.Alignment = StringAlignment.Center;
            strFormat.LineAlignment = lineAlignment;

            GraphicsPath gp = new GraphicsPath();
            int fontStyle = (int)FontStyle.Regular;
            if (font.Bold)
                fontStyle = (int)FontStyle.Bold;
            else
                if (font.Italic)
                    fontStyle = (int)(FontStyle.Italic | FontStyle.Italic);

            gp.AddString(txt, new FontFamily(fontName), fontStyle, penSize, rect, strFormat);
            

            return gp;
        }
        private void DrawPowerPointText(Graphics g)
        {           
            g.CompositingQuality = CompositingQuality.GammaCorrected;
            g.SmoothingMode = SmoothingMode.AntiAlias;                 
           

            GraphicsPath gp = GetStringPath(rect);
            
            //ve lai Text           
            g.FillPath(new SolidBrush(fillColor), gp);
            g.DrawPath(new Pen(boderColor, boderPenWidth), gp);
           
        }

        private void Draw3DText(Graphics g)
        {
            strFormat.Alignment = StringAlignment.Center;
            strFormat.LineAlignment = lineAlignment;

            g.CompositingQuality = CompositingQuality.GammaCorrected;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath gp = new GraphicsPath();
            int fontStyle = (int)FontStyle.Regular;
            if (font.Bold)
                fontStyle = (int)FontStyle.Bold;
            else
                if (font.Italic)
                    fontStyle = (int)(FontStyle.Italic | FontStyle.Italic);
            int x =(int) rect.Left;
            int y = (int)rect.Top;
            
            for (int i = 1; i < 4; i++)
            {
                if (type == TextType.Text3DHideDownRight)
                {
                    x += 3;
                    y += 1;
                }
                else if (type ==TextType.Text3DHideDownLeft)
                {
                    x -= 3;
                    y += 2;
                }
                else if (type == TextType.Text3DHideUp)
                {
                    x -= 3;
                    y -= 3;
                }
                RectangleF rectange = new RectangleF(x, y, rect.Width, rect.Height);            
                
                gp.AddString(txt, new FontFamily(fontName), fontStyle, penSize, rectange, strFormat);
                //ve lai Text           
                g.FillPath(new SolidBrush(gdColor), gp);
                g.DrawPath(new Pen(boderColor, boderPenWidth-1), gp);

            }
          

        }

        private void DrawOutlineText(Graphics g)
        {
            Color Scolor = new Color();

            Scolor = Color.FromArgb(shadowOpacity, shadowColor);

            g.CompositingQuality = CompositingQuality.GammaCorrected;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath gp = GetStringPath(rect);

            RectangleF off = rect;

            off.Offset(5, 5);
            GraphicsPath offPath = GetStringPath(off);
            Brush b = new SolidBrush(Scolor);
            g.FillPath(b, offPath);
            b.Dispose();
            g.FillPath(new SolidBrush(fillColor), gp);
            g.DrawPath(new Pen(boderColor, boderPenWidth), gp);           
          
        }
        private void DrawShadowText(Graphics g)
        {

            g.CompositingQuality = CompositingQuality.GammaCorrected;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath gp = GetStringPath(rect);
            //ve lai Text                      
            LinearGradientBrush lg = new LinearGradientBrush(this.ClientRectangle, gdColor, fillColor, LinearGradientMode.Vertical);
            g.FillPath(lg, gp);
            g.DrawPath(new Pen(boderColor, boderPenWidth), gp);          
            
        }

        private void DrawCoolText(Graphics g)
        {

            g.CompositingQuality = CompositingQuality.GammaCorrected;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath gp = GetStringPath(rect);

            PathGradientBrush pg = new PathGradientBrush(gp);
            pg.CenterColor = fillColor;
            pg.SurroundColors = new Color[1] { gdColor };
            //ve lai Text           
            g.FillPath(pg, gp);
            g.DrawPath(new Pen(boderColor, boderPenWidth), gp);
            
        }

        private void DrawWarpText(Graphics g)
        {

            g.CompositingQuality = CompositingQuality.GammaCorrected;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath gp = GetStringPath(rect);
            //ve lai Text                      
            LinearGradientBrush lg = new LinearGradientBrush(this.ClientRectangle, gdColor, fillColor, LinearGradientMode.Vertical);
            g.FillPath(lg, gp);
            g.DrawPath(new Pen(boderColor, boderPenWidth), gp);

            int topSizeWidth = 300;
            gp.Warp(
                new PointF[4] 
				{ 
					new PointF((this.Width - topSizeWidth) / 2, 0),
					new PointF(this.Width - (this.Width - topSizeWidth) / 2, 0),
					new PointF(0, this.Height),
					new PointF(this.Width, this.Height)
				}, rect , null, WarpMode.Perspective );

            g.FillPath(lg, gp);

        }
        #endregion

        #region Public Method
        #endregion

        public DrawShape()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.Opaque, false);
            font = Font;
            fontName = this.font.Name;
            penSize = 48;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            rect = (RectangleF)this.ClientRectangle;            
            
            switch (this.type)
            {
                case TextType.GoldGray:
                    fillColor = Color.DarkOrange;
                    boderColor = Color.DarkGray;
                    DrawPowerPointText(e.Graphics);
                    break;
                case TextType.OrangeGray:             
                
                    fillColor = Color.Orange;
                    boderColor = Color.IndianRed;
                    DrawPowerPointText(e.Graphics);
                    break;
                case TextType.Text3DHideDownRight:
                case TextType.Text3DHideDownLeft:
                case TextType.Text3DHideUp:
                    Draw3DText(e.Graphics); break;
                case TextType.Text3Outline:
                    DrawOutlineText(e.Graphics); break;
                case TextType.TextShadow:
                    DrawShadowText(e.Graphics); break;
                case TextType.Textnic:
                    fillColor = Color.DodgerBlue;
                    boderColor = Color.Cyan;
                    DrawPowerPointText(e.Graphics);
                    break;
                case TextType.CoolText:
                    DrawCoolText(e.Graphics); break;
                case TextType.WarpText:
                    DrawWarpText(e.Graphics); break;
                default:
                    DrawPowerPointText(e.Graphics);
                    break;
            }
            
            
        }
    }
    public enum TextType
    {
        None = 0,
        GoldGray = 1,
        OrangeGray = 2,
        Text3DHideDownRight = 3,
        Text3DHideDownLeft = 4,
        Text3DHideUp = 5,
        Text3Outline = 6,
        TextShadow = 7,
        Textnic = 8,
        CoolText = 9,
        WarpText = 10



    }
    
}

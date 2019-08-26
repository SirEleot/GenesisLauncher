using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Launcher
{
    class Label_news : Label
    {
        public List<NewsModel> ListNews {
            set
            {
                string text = null;
                if (value != null)
                {                    
                    foreach (NewsModel item in value)
                    {
                        text += item.Tittle + "&";
                        text += item.Text + "|";
                    }
                }
               
                base.Text = text;
            }
        }
        public Label_news()
        {
            AutoSize = false;
            BackColor = Color.Transparent;
            Size = new Size(549, 427);
            Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FlatStyle = FlatStyle.Flat;
            Location = new Point(188, 81);
            Name = "GLabel_news";
            TabIndex = 8;
            Text = null;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Point drawPoint = new Point(0, 0);
            if (Text != null)
            {
                Font boldFont = new Font("Arial",18F,FontStyle.Bold);
                string[] NewsItem = Text.Split('|');
                foreach (string item in NewsItem)
                {
                    string[] parts = item.Split('&');
                    if (parts.Length > 1) {

                        string tittle = parts[0];
                        string text = parts[1];
                        TextRenderer.DrawText(e.Graphics, tittle, boldFont, drawPoint, ForeColor);
                        drawPoint.Y += 30;
                        Size size = TextRenderer.MeasureText(text, Font);
                        TextRenderer.DrawText(e.Graphics, text, Font, drawPoint, ForeColor);
                        drawPoint.Y += 40 + size.Height;
                    }
                }               
            }
            else
            {
                TextRenderer.DrawText(e.Graphics, "Ошибка \n Удаленный сервер недоступен", Font, drawPoint, ForeColor);
            }
        }
    }
}

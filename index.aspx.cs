using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Drawing;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.IO;

namespace Drawing.index {
    public partial class index : System.Web.UI.Page {

        protected void ButtonNew_Click(object sender, EventArgs e) {
            Response.Clear();
            int height = Int32.Parse(input_bild_hoehe.Text);
            int width = Int32.Parse(input_bild_weite.Text);
            Random r = new Random();
            int x = r.Next(75);

            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Aqua);


            float root_x = bmp.Size.Width / 2;
            float root_y = bmp.Size.Height - 4;
            float length_scale = 0.75F;
            float dtheta = (float)(Math.PI / 180.0 * (double)35);

            drawing.DrawBranch(g, pen, Int32.Parse(input_tiefe.Text), root_x, root_y, float.Parse(input_weite.Text), (float)(-Math.PI / 2), length_scale, dtheta);


            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Jpeg);
            var base64Data = Convert.ToBase64String(ms.ToArray());
            imgCtrl.Src = "data:image/jpg;base64," + base64Data;
            g.Dispose();
            bmp.Dispose();
        }

        protected void Page_Load(object sender, EventArgs e) {

      
        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Drawing.index {
    public class drawing {

        public static void DrawBranch(Graphics gr, Pen pen, int depth, float x, float y, float length, float theta, float length_scale, float dtheta) {
            // See where this branch should end.
            float x1 = (float)(x + length * Math.Cos(theta));
            float y1 = (float)(y + length * Math.Sin(theta));

            gr.DrawLine(pen, x, y, x1, y1);

            // If depth > 1, draw the attached branches.
            if (depth > 1) {
                DrawBranch(gr, pen, depth - 1, x1, y1,
                    length * length_scale, theta + dtheta, length_scale,
                    dtheta);
                DrawBranch(gr, pen, depth - 1, x1, y1,
                    length * length_scale, theta - dtheta, length_scale,
                    dtheta);
            }
        }

    }
}
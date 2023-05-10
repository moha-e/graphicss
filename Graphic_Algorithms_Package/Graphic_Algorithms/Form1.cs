using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Graphic_Algorithms
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Draw_Axis()
        {
            var brush = Brushes.Black;
            var graphic = panel1.CreateGraphics();
            for (int i = 0; i < 420; i++)
            {
                graphic.FillRectangle(brush, i, 152, 2, 2);
            }
            for (int j = 0; j < 384; j++)
            {
                graphic.FillRectangle(brush, 175, j, 2, 2);
            }
        }

        
        public static string octan_number(Point start,Point end) 
        {
           float x0=start.X;
           float y0=start.Y;
           float x1 = end.X;
           float y1 = end.Y;
           float slope=(y1-y0)/(x1-x0);
           string octan="";

            if (slope > 0 && slope < 1 && x0<x1) 
            { octan = "First Octant"; }

            else if (slope > 1 && y0<y1)
            { octan = "Secound Octant"; }
            
            else if (slope < -1 && y0 < y1)
            { octan = "Third Octant"; }

            else if ((slope > -1 ) && (slope <0 && x0 > x1))
            { octan = "Fourth Octant"; }

            else if (slope > 0 && slope < 1 && x0 > x1)
            { octan = "Fifth Octant"; }

            else if (slope > 1 && y0 > y1)
            { octan = "Sixth Octant"; }

            else if (slope < -1 && y0 > y1)
            { octan = "Seventh Octant"; }

            else if (slope > -1 && slope < 0 && x0 < x1)
            { octan = "Eighth Octant"; }

            return octan;

        }
        
        public static int Round_Pixel(float pixel)
        {
            return (int)(pixel + 0.5);
        }
        
        private void Draw_Red_point(float X,float Y) 
        {
            var brush = Brushes.Red;
            var graphic = panel1.CreateGraphics();
            graphic.FillRectangle(brush,  175+X ,  152-Y, 1, 1);

        }
        
        private void Draw_Blue_point(float X, float Y)
        {
            var brush = Brushes.Blue;
            var graphic = panel1.CreateGraphics();
            graphic.FillRectangle(brush, 175 + X, 152 - Y, 1, 1);

        }

        private void Green_point_for_circl(int xc, int yc, int x, int y)
        {

            var brush = Brushes.Green;
            var graphic = panel1.CreateGraphics();

            graphic.FillRectangle(brush, 175 + (xc + x), 152 - (yc + y), 1,1);
            graphic.FillRectangle(brush, 175 + (xc - x), 152 - (yc + y), 1,1);
            graphic.FillRectangle(brush, 175 + (xc + x), 152 - (yc - y), 1,1);
            graphic.FillRectangle(brush, 175 + (xc - x), 152 - (yc - y), 1,1);
            graphic.FillRectangle(brush, 175 + (xc + y), 152 - (yc + x), 1,1);
            graphic.FillRectangle(brush, 175 + (xc - y), 152 - (yc + x), 1,1);
            graphic.FillRectangle(brush, 175 + (xc + y), 152 - (yc - x), 1,1);
            graphic.FillRectangle(brush, 175 + (xc - y), 152 - (yc - x), 1,1);
        }

        private void Orange_point_for_ellipse(int X_center, int Y_center, int x, int y)
        {

            var brush = Brushes.Orange;
            var graphic = panel1.CreateGraphics();

            graphic.FillRectangle(brush, 175 + (X_center + x), 152 - (Y_center + y), 1, 1);
            graphic.FillRectangle(brush, 175 + (X_center - x), 152 - (Y_center + y), 1, 1);
            graphic.FillRectangle(brush, 175 + (X_center + x), 152 - (Y_center - y), 1, 1);
            graphic.FillRectangle(brush, 175 + (X_center - x), 152 - (Y_center - y), 1, 1);

        }
        private void Draw_blue_line(Point start, Point end)
        {

            float x0 = start.X;
            float y0 = start.Y;
            float Y_increment, X_increment;
            int step;
            int delta_X = end.X - start.X;
            int delta_Y = end.Y - start.Y;

            if (Math.Abs(delta_X) > Math.Abs(delta_Y))
                step = Math.Abs(delta_X);
            else
                step = Math.Abs(delta_Y);

            X_increment = (float)delta_X / step;
            Y_increment = (float)delta_Y / step;



            for (int i = 0; i < step; i++)
            {
                x0 = x0 + X_increment;
                // x0=Round_Pixel(x0);
                y0 = y0 + Y_increment;
                // y0= Round_Pixel(y0);
                Draw_Blue_point(x0, y0);



            }





        }

        private void Draw_DDA_line(Point start,Point end) 
        {

            float x0 = start.X;
            float y0 = start.Y;
            float Y_increment,X_increment;
            int step;
            int delta_X = end.X - start.X;
            int delta_Y = end.Y - start.Y;

            if (Math.Abs(delta_X) > Math.Abs(delta_Y))
                step = Math.Abs(delta_X);
            else
                step = Math.Abs(delta_Y);

             X_increment = (float)delta_X / step;
             Y_increment = (float)delta_Y / step;


            
            for (int i = 0; i < step; i++)
            {
                x0 = x0 + X_increment;
               // x0=Round_Pixel(x0);
                y0 = y0 + Y_increment;
                // y0= Round_Pixel(y0);
                Draw_Red_point(x0, y0);


             
            }
            
            



        }
        public static void make_DDA_tabl(Point start, Point end)
        {

            float x0 = start.X;
            float y0 = start.Y;
            float Y_increment, X_increment;
            int step;
            int delta_X = end.X - start.X;
            int delta_Y = end.Y - start.Y;

            


            if (Math.Abs(delta_X) > Math.Abs(delta_Y))
                step = (int)Math.Abs(delta_X);
            else
                step = (int)Math.Abs(delta_Y);


             X_increment = (float)delta_X / step;
             Y_increment = (float)delta_Y / step;



            StreamWriter page = new StreamWriter(@"DAA_Table.html");
            page.WriteLine("<!DOCTYPE html>");
            page.WriteLine(" <html> ");
                    page.WriteLine("<head>");

                        page.WriteLine("<style>");
                            page.WriteLine("table" +
                                                    "{font-family: arial, sans-serif;" +
                                                    "border-collapse: collapse;" +
                                                    "width: 100%; }" +
                                               "td,th" +
                                               "    {border: 1px solid #dddddd;  text-align: left; padding: 8px;} " +
                                               "tr:nth-child(odd)" +
                                                    "{background-color: #dddddd;}" +
                                                    "tr:nth-child(eve)" +
                                                    "{background-color: #ffffff;}");
                            page.WriteLine( "</style>");
                        page.WriteLine("</head>");
                    page.WriteLine("<body>");
                        page.WriteLine("<table>" +
                                                "<tr>" +
                                                    "<th>K</th>" +
                                                    "<th>X</th>" +
                                                    "<th>Y</th>" +
                                                    "<th>(X,Y)</th>" +
                                                "</tr>");
                        for (int row = 0; row < step; row++)
                        {
                            page.WriteLine("<tr>");

                                x0 = x0 + X_increment;
                                y0 = y0 + Y_increment;


                                page.WriteLine("<td>");
                                     page.WriteLine(row);
                                page.WriteLine("</td>");

                                page.WriteLine("<td>");
                                    page.WriteLine((x0));
                                page.WriteLine("</td>");

                                page.WriteLine("<td>");
                                    page.WriteLine((y0));
                                page.WriteLine("</td>");

                                page.WriteLine("<td>");
                                    page.WriteLine("(" + Round_Pixel(x0) + "," + Round_Pixel(y0) + ")");
                                page.WriteLine("</td>");

                            page.WriteLine("</tr>");

                        }
                        page.WriteLine("</table>  ");
                    page.WriteLine("</body>");
            page.WriteLine(" </html>");

            page.Close();

            MessageBox.Show("\"C:\\Users\\HP\\source\\repos\\Graphic_Algorithms\\Graphic_Algorithms\\bin\\Debug\\DDA_Table.html\"");
        }


        private void Drawing_line_in_DDA_Click(object sender, EventArgs e)
        {
            //pictureBox1.Visible = true;
            Draw_Axis();
            int X0 = Convert.ToInt32(Xstart.Text);
            int Y0 = Convert.ToInt32(Ystart.Text);
            int X1 = Convert.ToInt32(Xend.Text);
            int Y1 = Convert.ToInt32(Yend.Text);

            
            Point start = new Point(X0, Y0);
            Point end = new Point(X1, Y1);
            
            Draw_DDA_line(start, end);
            make_DDA_tabl(start,end);
        }
       
        private void Draw_Bresenham_line(Point start, Point end)
        {

            float x0 = start.X;
            float y0 = start.Y;
            float x1 = end.X;
            float y1 = end.Y;
            float X = 0; 
            float Y = 0; 
            

 

 
            int delta_X = Math.Abs(end.X - start.X);
            int delta_Y = Math.Abs(end.Y - start.Y);
            float when_negative_increment =2*(delta_Y);
            float when_positive_increment = 2 * (delta_Y - delta_X);
            float Pk = (2 * delta_Y) - delta_X;




            if (x0 < x1)
            {
                X = x0;
                Y= y0;
            }
            else 
            { 
                X= x1;
                Y= y1;
 
            }


            for (int i = 0; i < (delta_X - 1); i++) 
            {
                if(Pk < 0) 
                {
                    X++;
                    Pk += when_negative_increment;
                    Draw_Blue_point(X, Y);
                }
                if(Pk > 0) 
                {
                    X++;
                    Y++;
                    Pk += when_positive_increment;
                    Draw_Blue_point(X, Y);
                }
            }
                
               
            
           



        }

        public static void make_Bresenham_tabl(Point start, Point end)
        {

            float x0 = start.X;
            float y0 = start.Y;
            float x1 = end.X;
            float y1 = end.Y;
            int k = 0;
            float delta_X;
            float delta_Y;
            float when_negative_increment;
            float when_positive_increment;
            double Pk;
            float slope = (y1-y0) / (x1-x0);



            StreamWriter page = new StreamWriter(@"Bresenham_Table.html");
            page.WriteLine("<!DOCTYPE html>");
            page.WriteLine(" <html> ");
            page.WriteLine("<head>");

            page.WriteLine("<style>");
            page.WriteLine("table" +
                                    "{font-family: arial, sans-serif;" +
                                    "border-collapse: collapse;" +
                                    "width: 100%; }" +
                               "td,th" +
                               "    {border: 1px solid #dddddd;  text-align: left; padding: 8px;} " +
                               "tr:nth-child(odd)" +
                                    "{background-color: #dddddd;}" +
                                    "tr:nth-child(eve)" +
                                    "{background-color: #ffffff;}"
                                    );
            page.WriteLine("</style>");
            page.WriteLine("</head>");
            page.WriteLine("<body>");
            page.WriteLine("<h1 style= 'text-align:center;'>" + octan_number(start,end) + "</h1>");
            page.WriteLine("<table>" +
                                    "<tr>" +
                                        "<th>K</th>" +
                                        "<th>P<sub>k</sub></th>" +
                                        "<th>(X<sub>k+1</sub>,Y<sub>k+1</sub>)</th>" +
                                    "</tr>");

            if (slope > 0 && slope < 1)
            {
                delta_X =Math.Abs( end.X - start.X);
                delta_Y =Math.Abs(end.Y - start.Y);
                when_negative_increment = 2 * (delta_Y);
                when_positive_increment = (2 * delta_Y) - (2 * delta_X);
                Pk = 2 * delta_Y - delta_X;

                if (x0 < x1) 
                {
                    while (x0 < x1)
                    {


                        page.WriteLine("<tr>");

                            page.WriteLine("<td>");
                            page.WriteLine(k);
                            page.WriteLine("</td>");



                            page.WriteLine("<td>");
                            page.WriteLine((Pk));
                            page.WriteLine("</td>");

                            if (Pk < 0)
                            {
                                Pk = Pk + when_negative_increment;
                                k++;
                                x0++;
                            }
                            else
                            {
                                y0++;
                                Pk = Pk + when_positive_increment;
                                k++;
                                x0++;
                            }

                            page.WriteLine("<td>");
                            page.WriteLine("(" + (int)(x0) + "," + (int)(y0) + ")");
                            page.WriteLine("</td>");
                        page.WriteLine("</tr>");

                    }
                }
                else 
                {
                    while (x0 > x1)
                    {


                        page.WriteLine("<tr>");

                            page.WriteLine("<td>");
                            page.WriteLine(k);
                            page.WriteLine("</td>");



                            page.WriteLine("<td>");
                            page.WriteLine((Pk));
                            page.WriteLine("</td>");

                            if (Pk < 0)
                            {
                                Pk = Pk + when_negative_increment;
                                k++;
                                x0--; ;
                            }
                            else
                            {
                                y0--;
                                Pk = Pk + when_positive_increment;
                                k++;
                                x0--;
                            }

                            page.WriteLine("<td>");
                            page.WriteLine("(" + (int)(x0) + "," + (int)(y0) + ")");
                            page.WriteLine("</td>");
                        page.WriteLine("</tr>");

                    }
                }

            }
            else if (slope > 1)
            {
                delta_Y = Math.Abs(end.X - start.X);
                delta_X = Math.Abs(end.Y - start.Y);
                when_negative_increment = 2 * (delta_Y);
                when_positive_increment = (2 * delta_Y) - (2 * delta_X);
                Pk = 2 * delta_Y - delta_X;

                if (y0 < y1) 
                {
                    while (y0 < y1)
                    {


                        page.WriteLine("<tr>");

                            page.WriteLine("<td>");
                            page.WriteLine(k);
                            page.WriteLine("</td>");

                            page.WriteLine("<td>");
                            page.WriteLine((Pk));
                            page.WriteLine("</td>");




                            if (Pk < 0)
                            {
                                Pk = Pk + when_negative_increment;
                                k++;
                                y0++;
                            }
                            else
                            {
                                y0++;
                                x0++;
                                Pk = Pk + when_positive_increment;
                                k++;

                            }


                            page.WriteLine("<td>");
                            page.WriteLine("(" + (int)(x0) + "," + (int)(y0) + ")");
                            page.WriteLine("</td>");
                        page.WriteLine("</tr>");

                    }
                }
                else 
                {
                    while (y0 > y1)
                    {


                        page.WriteLine("<tr>");

                            page.WriteLine("<td>");
                            page.WriteLine(k);
                            page.WriteLine("</td>");

                            page.WriteLine("<td>");
                            page.WriteLine((Pk));
                            page.WriteLine("</td>");




                            if (Pk < 0)
                            {
                                Pk = Pk + when_negative_increment;
                                k++;
                                y0--;
                            }
                            else
                            {
                                y0--;
                                x0--;
                                Pk = Pk + when_positive_increment;
                                k++;

                            }


                            page.WriteLine("<td>");
                            page.WriteLine("(" + (int)(x0) + "," + (int)(y0) + ")");
                            page.WriteLine("</td>");
                        page.WriteLine("</tr>");

                    }
                }


            }
            else if (slope <- 1)
            {
                delta_Y = Math.Abs(start.X - end.X);
                delta_X = Math.Abs(end.Y - start.Y);
                when_negative_increment = 2 * (delta_Y);
                when_positive_increment = (2 * delta_Y) - (2 * delta_X);
                Pk = 2 * delta_Y - delta_X;

                if (y0 < y1) 
                {
                    while (y0 < y1)
                    {


                        page.WriteLine("<tr>");

                            page.WriteLine("<td>");
                            page.WriteLine(k);
                            page.WriteLine("</td>");

                            page.WriteLine("<td>");
                            page.WriteLine((Pk));
                            page.WriteLine("</td>");




                            if (Pk < 0)
                            {
                                Pk = Pk + when_negative_increment;
                                k++;
                                y0++;
                            }
                            else
                            {
                                y0++;
                                x0--; ;
                                Pk = Pk + when_positive_increment;
                                k++;

                            }


                            page.WriteLine("<td>");
                            page.WriteLine("(" + (int)(x0) + "," + (int)(y0) + ")");
                            page.WriteLine("</td>");
                        page.WriteLine("</tr>");

                    }
                    
                }
                else 
                {
                    while (y0 > y1)
                    {


                        page.WriteLine("<tr>");

                            page.WriteLine("<td>");
                            page.WriteLine(k);
                            page.WriteLine("</td>");

                            page.WriteLine("<td>");
                            page.WriteLine((Pk));
                            page.WriteLine("</td>");




                            if (Pk < 0)
                            {
                                Pk = Pk + when_negative_increment;
                                k++;
                                y0--;
                            }
                            else
                            {
                                y0--;
                                x0++; ;
                                Pk = Pk + when_positive_increment;
                                k++;

                            }


                            page.WriteLine("<td>");
                            page.WriteLine("(" + (int)(x0) + "," + (int)(y0) + ")");
                            page.WriteLine("</td>");
                        page.WriteLine("</tr>");

                    }
                }
            }
            else if (slope < 0 && slope > -1)
            {
                delta_X = Math.Abs( start.X-end.X);
                delta_Y = Math.Abs(end.Y - start.Y);
                when_negative_increment = 2 * (delta_Y);
                when_positive_increment = (2 * delta_Y) - (2 * delta_X);
                Pk = 2 * delta_Y - delta_X;

                if (x0 > x1) 
                {
                    while (x0 > x1)
                    {


                        



                        page.WriteLine("<tr>");

                            page.WriteLine("<td>");
                            page.WriteLine(k);
                            page.WriteLine("</td>");



                            page.WriteLine("<td>");
                            page.WriteLine((Pk));
                            page.WriteLine("</td>");

                            if (Pk < 0)
                            {
                                Pk = Pk + when_negative_increment;
                                k++;
                                x0--;
                            }
                            else
                            {
                                y0++;
                                Pk = Pk + when_positive_increment;
                                k++;
                                x0--;
                            }

                            page.WriteLine("<td>");
                            page.WriteLine("(" + (int)(x0) + "," + (int)(y0) + ")");
                            page.WriteLine("</td>");
                        page.WriteLine("</tr>");

                    }
                }
                else 
                {
                    while (x0 < x1)
                    {


                        



                        page.WriteLine("<tr>");

                            page.WriteLine("<td>");
                            page.WriteLine(k);
                            page.WriteLine("</td>");



                            page.WriteLine("<td>");
                            page.WriteLine((Pk));
                            page.WriteLine("</td>");

                            if (Pk < 0)
                            {
                                Pk = Pk + when_negative_increment;
                                k++;
                                x0++;
                            }
                            else
                            {
                                y0--;
                                Pk = Pk + when_positive_increment;
                                k++;
                                x0++;
                            }

                            page.WriteLine("<td>");
                            page.WriteLine("(" + (int)(x0) + "," + (int)(y0) + ")");
                            page.WriteLine("</td>");

                        page.WriteLine("</tr>");

                    }
                }
            }








            page.WriteLine("</table>  ");
            page.WriteLine("</body>");
            page.WriteLine(" </html>");

            page.Close();

            MessageBox.Show("\"C:\\Users\\HP\\source\\repos\\Graphic_Algorithms\\Graphic_Algorithms\\bin\\Debug\\Bresenham_Table.html\"");
        }

        private void Draw_line_by_Bresenham(object sender, EventArgs e)
        {
            Draw_Axis();
            int X0 = Convert.ToInt32(Xstart.Text);
            int Y0 = Convert.ToInt32(Ystart.Text);
            int X1 = Convert.ToInt32(Xend.Text);
            int Y1 = Convert.ToInt32(Yend.Text);


            Point start = new Point(X0, Y0);
            Point end = new Point(X1, Y1);
            Draw_Bresenham_line(start, end);
            make_Bresenham_tabl(start, end);
        }
        
       

        private void Yend_TextChanged(object sender, EventArgs e)
        {

        }

        private void Y_center_TextChanged(object sender, EventArgs e)
        {

        }

        public void Draw_Circle(Point center, int radius) 
        {
            Draw_Axis();
                
            
                int x = 0;
                int y = radius;
                int Pk =   1 - radius;
                
            

                while (x < y)
                {
                    
                    if (Pk < 0)
                    {
                        x++;
                        Pk += 2 * x + 1;
                    }
                    else
                    {
                        x++;
                        y--;
                        Pk += 2 * (x - y) + 1;
                    }

                    Green_point_for_circl(center.X, center.Y, x, y);
                }
            
        }
        public void make_circle_table(Point center, int radius) 
        {

            int x = 0;
            int y = radius;
            int Pk = 1 - radius;
            int k = 0;
            StreamWriter page = new StreamWriter(@"Circle_Table.html");
            page.WriteLine("<!DOCTYPE html>");
            page.WriteLine(" <html> ");
            page.WriteLine("<head>");

            page.WriteLine("<style>");
            page.WriteLine("table" +
                                    "{font-family: arial, sans-serif;" +
                                    "border-collapse: collapse;" +
                                    "width: 100%; }" +
                               "td,th" +
                               "    {border: 1px solid #dddddd;  text-align: left; padding: 8px;} " +
                               "tr:nth-child(odd)" +
                                    "{background-color: #dddddd;}" +
                                    "tr:nth-child(eve)" +
                                    "{background-color: #ffffff;}");
            page.WriteLine("</style>");
            page.WriteLine("</head>");
            page.WriteLine("<body>");
            page.WriteLine("<table>" +
                                    "<tr>" +
                                        "<th>K</th>" +
                                        "<th>P<sub>k</sub></th>" +
                                        "<th>(X<sub>k+1</sub>,Y<sub>k+1</sub>)</th>" +
                                        "<th>2X<sub>k+1</sub></th>" +
                                        "<th>2Y<sub>k+1</sub></th>" +
                                    "</tr>");



            while (x < y)
            {

                if (Pk < 0)
                {
                    x++;
                    Pk += 2 * x + 1;
                }
                else
                {
                    x++;
                    y--;
                    Pk += 2 * (x - y) + 1;
                }
                page.WriteLine("<tr>");




                page.WriteLine("<td>");
                page.WriteLine(k);
                page.WriteLine("</td>");

                k++;
                page.WriteLine("<td>");
                page.WriteLine(Pk);
                page.WriteLine("</td>");

                page.WriteLine("<td>");
                page.WriteLine("(" + x + "," + y + ")");
                page.WriteLine("</td>");

                page.WriteLine("<td>");
                page.WriteLine(2*x);
                page.WriteLine("</td>");

                page.WriteLine("<td>");
                page.WriteLine(2 * y);
                page.WriteLine("</td>");



                page.WriteLine("</tr>");


            }

            page.WriteLine("</table>  ");
            page.WriteLine("</body>");
            page.WriteLine(" </html>");

            page.Close();

            MessageBox.Show("\"C:\\Users\\HP\\source\\repos\\Graphic_Algorithms\\Graphic_Algorithms\\bin\\Debug\\Circle_Table.html\"");

        }
        private void Draw_circle_Click(object sender, EventArgs e)
        {
            int X = Convert.ToInt32(X_center.Text);
            int Y = Convert.ToInt32(Y_center.Text);
            int radius = Convert.ToInt32(Radius.Text);
           

            Point center= new Point(X, Y);
            Draw_Circle( center, radius);
            make_circle_table(center, radius);
        }

        private void Draw_Ellipse(Point center, Point radius)
        {

            int X_radius = radius.X;
            int Y_radius = radius.Y;
            int X_center = center.X;
            int Y_center = center.Y;

            int x_radius_squr = X_radius * X_radius;
            int y_radius_squr = Y_radius * Y_radius;

            int two_of_x_radius_squr = 2 * x_radius_squr;
            int two_of_y_radius_squr = 2 * y_radius_squr;

            int p;

            int x = 0;
            int y = Y_radius;

            int px = 0;
            int py = two_of_x_radius_squr * y;



            /* Region 1 */
            p = (int)(y_radius_squr - (x_radius_squr * Y_radius) + (0.25 * x_radius_squr));
            while (px < py)
            {
                x++;
                px += two_of_y_radius_squr;
                if (p < 0)
                {
                    p += y_radius_squr + px;
                }
                else
                {
                    y--;
                    py -= two_of_x_radius_squr;
                    p += y_radius_squr + px - py;
                }
                Orange_point_for_ellipse(X_center, Y_center, x, y);
            }

            /* Region 2 */
            p = ((int)(y_radius_squr * (x + 0.5) * (x + 0.5) + x_radius_squr * (y - 1) * (y - 1) - x_radius_squr * y_radius_squr));
            while (y > 0)
            {
                y--;
                py -= two_of_x_radius_squr;
                if (p > 0)
                {
                    p += x_radius_squr - py;
                }
                else
                {
                    x++;
                    px += two_of_y_radius_squr;
                    p += x_radius_squr - py + px;
                }
                Orange_point_for_ellipse(X_center, Y_center, x, y);
            }
        }
        private void Make_ellipse_table(Point center, Point radius)
        {

            int X_radius = radius.X;
            int Y_radius = radius.Y;
            int X_center = center.X;
            int Y_center = center.Y;

            int x_radius_squr = X_radius * X_radius;
            int y_radius_squr = Y_radius * Y_radius;

            int two_of_x_radius_squr = 2 * x_radius_squr;
            int two_of_y_radius_squr = 2 * y_radius_squr;

            int p;

            int x = 0;
            int y = Y_radius;

            int px = 0;
            int py = two_of_x_radius_squr * y;



            /* Region 1 *//////////////////////////////////////////////////////////////
            StreamWriter page = new StreamWriter(@"Ellipse_Table.html");
            page.WriteLine("<!DOCTYPE html>");
            page.WriteLine(" <html> ");
            page.WriteLine("<head>");

            page.WriteLine("<style>");
            page.WriteLine("table" +
                                    "{font-family: arial, sans-serif;" +
                                    "border-collapse: collapse;" +
                                    "width: 100%; }" +
                               "td,th" +
                               "    {border: 1px solid #dddddd;  text-align: left; padding: 8px;} " +
                               "tr:nth-child(odd)" +
                                    "{background-color: #dddddd;}" +
                                    "tr:nth-child(eve)" +
                                    "{background-color: #ffffff;}"
                                    );
            page.WriteLine("</style>");
            page.WriteLine("</head>");
            page.WriteLine("<body>");
            page.WriteLine("<h1 style= 'text-align:center;'> Region 1 </h1>");
            page.WriteLine("<table>" +
                                    "<tr>" +
                                        "<th>K</th>" +
                                        "<th>P1<sub>k</sub></th>" +
                                        "<th>(X<sub>k+1</sub>,Y<sub>k+1</sub>)</th>" +
                                        "<th>2r<sub>y</sub><sup>2</sup>x<sub>k+1</sub></th>" +
                                        "<th>2r<sub>x</sub><sup>2</sup>y<sub>k+1</sub></th>" +
                                    "</tr>");


            p = (int)(y_radius_squr - (x_radius_squr * Y_radius) + (0.25 * x_radius_squr));
            int k = 0;
            while (px < py)
            {

                x++;
                px += two_of_y_radius_squr;
                if (p < 0)
                {
                    p += y_radius_squr + px;
                }
                else
                {
                    y--;
                    py -= two_of_x_radius_squr;
                    p += y_radius_squr + px - py;
                }




                page.WriteLine("<tr>");

                page.WriteLine("<td>");
                page.WriteLine(k);
                page.WriteLine("</td>");

                k++;

                page.WriteLine("<td>");
                page.WriteLine((p));
                page.WriteLine("</td>");

                page.WriteLine("<td>");
                page.WriteLine("(" + (int)(x) + "," + (int)(y) + ")");
                page.WriteLine("</td>");



                page.WriteLine("<td>");
                page.WriteLine(px);
                page.WriteLine("</td>");

                page.WriteLine("<td>");
                page.WriteLine(py);
                page.WriteLine("</td>");

                page.WriteLine("</tr>");

            }


            page.WriteLine("</table>  ");




            /* Region 2 *///////////////////////////////////////////////////////////////

            page.WriteLine("<h1 style= 'text-align:center;'> Region 2 </h1>");
            page.WriteLine("<table>" +
                                    "<tr>" +
                                        "<th>K</th>" +
                                        "<th>P1<sub>k</sub></th>" +
                                        "<th>(X<sub>k+1</sub>,Y<sub>k+1</sub>)</th>" +
                                        "<th>2r<sup>2</sup><sub>y</sub>x<sub>k+1</sub></th>" +
                                        "<th>2r<sup>2</sup><sub>x</sub>y<sub>k+1</sub></th>" +
                                    "</tr>");
            p = ((int)(y_radius_squr * (x + 0.5) * (x + 0.5) + x_radius_squr * (y - 1) * (y - 1) - x_radius_squr * y_radius_squr));
            int k_2 = 0;
            while (y > 0)
            {
                y--;
                py -= two_of_x_radius_squr;
                if (p > 0)
                {
                    p += x_radius_squr - py;
                }
                else
                {
                    x++;
                    px += two_of_y_radius_squr;
                    p += x_radius_squr - py + px;
                }
                page.WriteLine("<tr>");

                page.WriteLine("<td>");
                page.WriteLine(k_2);
                page.WriteLine("</td>");

                k_2++;

                page.WriteLine("<td>");
                page.WriteLine((p));
                page.WriteLine("</td>");

                page.WriteLine("<td>");
                page.WriteLine("(" + (int)(x) + "," + (int)(y) + ")");
                page.WriteLine("</td>");



                page.WriteLine("<td>");
                page.WriteLine(px);
                page.WriteLine("</td>");

                page.WriteLine("<td>");
                page.WriteLine(py);
                page.WriteLine("</td>");

                page.WriteLine("</tr>");
            }

            page.WriteLine("</table>  ");

            page.WriteLine("</body>");
            page.WriteLine(" </html>");

            page.Close();

            MessageBox.Show("\"C:\\Users\\HP\\source\\repos\\Graphic_Algorithms\\Graphic_Algorithms\\bin\\Debug\\Ellipse_Table.html\"");

        }

        private void ellipse_draw_click(object sender, EventArgs e)
        {
            Draw_Axis();
            int X_center = Convert.ToInt32(E_X_center.Text);
            int Y_center = Convert.ToInt32(E_Y_center.Text);
            int X_radius = Convert.ToInt32(E_X_radius.Text);
            int Y_radius = Convert.ToInt32(E_Y_radius.Text);


            Point center = new Point(X_center, Y_center);
            Point radius = new Point(X_radius, Y_radius);

            Draw_Ellipse(center, radius);
            Make_ellipse_table(center, radius);


        }







        private void E_Y_radius_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void Draw_2d_Shape(Point p1,Point p2 ,Point p3,Point p4) 
        {
            Draw_DDA_line(p1,p2);
            Draw_DDA_line(p2, p3);
            Draw_DDA_line(p3, p4);
            Draw_DDA_line(p4, p1);


        }
        private void Draw_2d_Shape_after_transformation(Point p1, Point p2, Point p3, Point p4)
        {
            Draw_blue_line(p1, p2);
            Draw_blue_line(p2, p3);
            Draw_blue_line(p3, p4);
            Draw_blue_line(p4, p1);


        }

        private void Draw_2d_click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.Refresh();

            Draw_Axis();

            int x1 = Convert.ToInt32(x1_2d.Text);
            int y1 = Convert.ToInt32(y1_2d.Text);
            int x2 = Convert.ToInt32(x2_2d.Text);
            int y2 = Convert.ToInt32(y2_2d.Text);
            int x3 = Convert.ToInt32(x3_2d.Text);
            int y3 = Convert.ToInt32(y3_2d.Text);
            int x4 = Convert.ToInt32(x4_2d.Text);
            int y4 = Convert.ToInt32(y4_2d.Text);

            Point p1= new Point(x1, y1);
            Point p2= new Point(x2, y2);
            Point p3= new Point(x3, y3);
            Point p4= new Point(x4, y4);

            Draw_2d_Shape(p1, p2 ,p3, p4);
          
            

            
        }

        private void Reflection_over_x_Axis(Point p1, Point p2, Point p3, Point p4)
        {
            int x1 = p1.X;
            int y1 = p1.Y;
            int x2 = p2.X;
            int y2 = p2.Y;
            int x3 = p3.X;
            int y3 = p3.Y;
            int x4 = p4.X;
            int y4 = p4.Y;

            int y1dash = -y1;
            int y2dash = -y2;
            int y3dash = -y3;
            int y4dash = -y4;

            Point p1dash = new Point(x1, y1dash);
            Point p2dash = new Point(x2, y2dash);
            Point p3dash = new Point(x3, y3dash);
            Point p4dash = new Point(x4, y4dash);

            Draw_2d_Shape_after_transformation(p1dash, p2dash, p3dash, p4dash);


        }
        private void Reflection_over_y_Axis(Point p1, Point p2,Point p3,Point p4) 
            {

                int x1 = p1.X;
                int y1 = p1.Y;
                int x2 = p2.X;
                int y2 = p2.Y;
                int x3 = p3.X;
                int y3 = p3.Y;
                int x4 = p4.X;
                int y4 = p4.Y;

                int x1dash = -x1;
                int x2dash = -x2;
                int x3dash = -x3;
                int x4dash = -x4;


                Point p1dash = new Point(x1dash, y1);
                Point p2dash = new Point(x2dash, y2);
                Point p3dash = new Point(x3dash, y3);
                Point p4dash = new Point(x4dash, y4);

                Draw_2d_Shape_after_transformation(p1dash, p2dash, p3dash, p4dash);



        }
        private void Reflection_over_Origin_point(Point p1, Point p2, Point p3, Point p4) 
        {
            int x1 = p1.X;
            int y1 = p1.Y;
            int x2 = p2.X;
            int y2 = p2.Y;
            int x3 = p3.X;
            int y3 = p3.Y;
            int x4 = p4.X;
            int y4 = p4.Y;


            int x1dash = -x1;
            int x2dash = -x2;
            int x3dash = -x3;
            int x4dash = -x4;

            int y1dash = -y1;
            int y2dash = -y2;
            int y3dash = -y3;
            int y4dash = -y4;


            Point p1dash = new Point(x1dash, y1dash);
            Point p2dash = new Point(x2dash, y2dash);
            Point p3dash = new Point(x3dash, y3dash);
            Point p4dash = new Point(x4dash, y4dash);

            Draw_2d_Shape_after_transformation(p1dash, p2dash, p3dash, p4dash);

        }

        private void Reflection_over_X_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(x1_2d.Text);
            int y1 = Convert.ToInt32(y1_2d.Text);
            int x2 = Convert.ToInt32(x2_2d.Text);
            int y2 = Convert.ToInt32(y2_2d.Text);
            int x3 = Convert.ToInt32(x3_2d.Text);
            int y3 = Convert.ToInt32(y3_2d.Text);
            int x4 = Convert.ToInt32(x4_2d.Text);
            int y4 = Convert.ToInt32(y4_2d.Text);

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            Point p3 = new Point(x3, y3);
            Point p4 = new Point(x4, y4);

            Reflection_over_x_Axis(p1, p2, p3, p4);
        }


        private void Reflection_over_Y_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(x1_2d.Text);
            int y1 = Convert.ToInt32(y1_2d.Text);
            int x2 = Convert.ToInt32(x2_2d.Text);
            int y2 = Convert.ToInt32(y2_2d.Text);
            int x3 = Convert.ToInt32(x3_2d.Text);
            int y3 = Convert.ToInt32(y3_2d.Text);
            int x4 = Convert.ToInt32(x4_2d.Text);
            int y4 = Convert.ToInt32(y4_2d.Text);

            Point p1 = new Point( x1 , y1 );
            Point p2 = new Point( x2 , y2 );
            Point p3 = new Point( x3 , y3 );
            Point p4 = new Point( x4 , y4 );

            Reflection_over_y_Axis( p1 , p2 , p3 , p4 );


        }


        private void Reflection_over_origin_click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(x1_2d.Text);
            int y1 = Convert.ToInt32(y1_2d.Text);
            int x2 = Convert.ToInt32(x2_2d.Text);
            int y2 = Convert.ToInt32(y2_2d.Text);
            int x3 = Convert.ToInt32(x3_2d.Text);
            int y3 = Convert.ToInt32(y3_2d.Text);
            int x4 = Convert.ToInt32(x4_2d.Text);
            int y4 = Convert.ToInt32(y4_2d.Text);

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            Point p3 = new Point(x3, y3);
            Point p4 = new Point(x4, y4);

            Reflection_over_Origin_point(p1, p2, p3, p4);
        }


        private void Translate_the_Shape(Point dash_1, Point dash_2, Point dash_3, Point dash_4) 
        {




            Point p1 = dash_1;
            Point p2 = dash_2;
            Point p3 = dash_3;
            Point p4 = dash_4;

            Draw_2d_Shape_after_transformation(p1, p2, p3, p4);

        }

        private void Translation_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(x1_2d.Text);
            int y1 = Convert.ToInt32(y1_2d.Text);
            int x2 = Convert.ToInt32(x2_2d.Text);
            int y2 = Convert.ToInt32(y2_2d.Text);
            int x3 = Convert.ToInt32(x3_2d.Text);
            int y3 = Convert.ToInt32(y3_2d.Text);
            int x4 = Convert.ToInt32(x4_2d.Text);
            int y4 = Convert.ToInt32(y4_2d.Text);
            int x  = Convert.ToInt32(T_X.Text);
            int y  = Convert.ToInt32(T_X.Text);

            int xdash1 = x1 + x;
            int ydash1 = y1 + y;
            int xdash2 = x2 + x;
            int ydash2 = y2 + y;
            int xdash3 = x3 + x;
            int ydash3 = y3 + y;
            int xdash4 = x4 + x;
            int ydash4 = y4 + y;

            Point dash_1= new Point(xdash1,ydash1);
            Point dash_2 = new Point(xdash2, ydash2);
            Point dash_3 = new Point(xdash3, ydash3);
            Point dash_4 = new Point(xdash4, ydash4);
            Translate_the_Shape(dash_1, dash_2,dash_3,dash_4);
        }

        private void Scaling_2d_shape(Point p1,Point p2, Point p3, Point p4,Point saling)
        {
            int x1 = p1.X;
            int y1 = p1.Y;
            int x2 = p2.X;
            int y2 = p2.Y;
            int x3 = p3.X;
            int y3 = p3.Y;
            int x4 = p4.X;
            int y4 = p4.Y;
            int x = saling.X;
            int y = saling.Y;

            int xdash1 = x1 * x;
            int xdash2 = x2 * x;
            int xdash3 = x3 * x;
            int xdash4 = x4 * x;


            int ydash1 = y1 * y;
            int ydash2 = y2 * y;
            int ydash3 = y3 * y;
            int ydash4 = y4 * y;

            Point dash_1 = new Point(xdash1, ydash1);
            Point dash_2 = new Point(xdash2, ydash2);
            Point dash_3 = new Point(xdash3, ydash3);
            Point dash_4 = new Point(xdash4, ydash4);

            Translate_the_Shape(dash_1, dash_2,dash_3,dash_4);

        }
        private void Scaling_2d_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(x1_2d.Text);
            int y1 = Convert.ToInt32(y1_2d.Text);
            int x2 = Convert.ToInt32(x2_2d.Text);
            int y2 = Convert.ToInt32(y2_2d.Text);
            int x3 = Convert.ToInt32(x3_2d.Text);
            int y3 = Convert.ToInt32(y3_2d.Text);
            int x4 = Convert.ToInt32(x4_2d.Text);
            int y4 = Convert.ToInt32(y4_2d.Text);
            int x = Convert.ToInt32(Scaling_X.Text);
            int y = Convert.ToInt32(Scaling_Y.Text);

            Point p1      = new Point(x1, y1);
            Point p2      = new Point(x2, y2);
            Point p3      = new Point(x3, y3);
            Point p4      = new Point(x4, y4);
            Point scaling = new Point(x,y);

            Scaling_2d_shape(p1 , p2, p3, p4,scaling);


        }
        private void Rotation_2d_shape ( Point p1, Point p2, Point p3, Point p4, double r_angle) 
        {
            int x1 = p1.X;
            int y1 = p1.Y;
            int x2 = p2.X;
            int y2 = p2.Y;
            int x3 = p3.X;
            int y3 = p3.Y;
            int x4 = p4.X;
            int y4 = p4.Y;
            double angle = r_angle;



            double cosAngle = Math.Cos((angle * Math.PI) / 180);
            double sinAngle = Math.Sin((angle * Math.PI) / 180);

            int xdash1 = (int)Math.Round( (cosAngle * x1) - (sinAngle * y1));
            int ydash1 = (int)Math.Round((sinAngle * x1) + (cosAngle * y1));

            int xdash2 = (int)Math.Round((cosAngle * x2) - (sinAngle * y2));
            int ydash2 = (int)Math.Round((sinAngle * x2) + (cosAngle * y2));

            int xdash3 = (int)Math.Round((cosAngle * x3) - (sinAngle * y3));
            int ydash3 = (int)Math.Round((sinAngle * x3) + (cosAngle * y3));

            int xdash4 = (int)Math.Round((cosAngle * x4) - (sinAngle * y4));
            int ydash4 = (int)Math.Round((sinAngle * x4) + (cosAngle * y4));

            Point dash_1 = new Point(xdash1, ydash1);
            Point dash_2 = new Point(xdash2, ydash2);
            Point dash_3 = new Point(xdash3, ydash3);
            Point dash_4 = new Point(xdash4, ydash4);

            Translate_the_Shape(dash_1, dash_2, dash_3, dash_4);

        }

        private void Rotation_2d_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(x1_2d.Text);
            int y1 = Convert.ToInt32(y1_2d.Text);
            int x2 = Convert.ToInt32(x2_2d.Text);
            int y2 = Convert.ToInt32(y2_2d.Text);
            int x3 = Convert.ToInt32(x3_2d.Text);
            int y3 = Convert.ToInt32(y3_2d.Text);
            int x4 = Convert.ToInt32(x4_2d.Text);
            int y4 = Convert.ToInt32(y4_2d.Text);
            int r_angle = Convert.ToInt32(R_angle.Text);

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            Point p3 = new Point(x3, y3);
            Point p4 = new Point(x4, y4);

            Rotation_2d_shape(p1, p2, p3, p4, r_angle);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void R_angle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
        private void Shear_in_x(Point p1, Point p2, Point p3, Point p4, int x_shear)
        {
            int x1 = p1.X;
            int y1 = p1.Y;
            int x2 = p2.X;
            int y2 = p2.Y;
            int x3 = p3.X;
            int y3 = p3.Y;
            int x4 = p4.X;
            int y4 = p4.Y;

            int sx = x_shear;

            int xdash1 = x1 + sx * y1;
            int xdash2 = x2 + sx * y2;
            int xdash3 = x3 + sx * y3;
            int xdash4 = x4 + sx * y4;

            int ydash1 = y1;
            int ydash2 = y2;
            int ydash3 = y3;
            int ydash4 = y4;

            Point dash_1 = new Point(xdash1, ydash1);
            Point dash_2 = new Point(xdash2, ydash2);
            Point dash_3 = new Point(xdash3, ydash3);
            Point dash_4 = new Point(xdash4, ydash4);

            Translate_the_Shape(dash_1, dash_2, dash_3, dash_4);

        }
        private void Shear_in_y(Point p1, Point p2, Point p3, Point p4, int y_shear)
        {
            int x1 = p1.X;
            int y1 = p1.Y;
            int x2 = p2.X;
            int y2 = p2.Y;
            int x3 = p3.X;
            int y3 = p3.Y;
            int x4 = p4.X;
            int y4 = p4.Y;

            int sy = y_shear;

            int xdash1 = x1;
            int xdash2 = x2;
            int xdash3 = x3;
            int xdash4 = x4;

            int ydash1 = y1 + sy * x1;
            int ydash2 = y2 + sy * x2;
            int ydash3 = y3 + sy * x3;
            int ydash4 = y4 + sy * x4;

            Point dash_1 = new Point(xdash1, ydash1);
            Point dash_2 = new Point(xdash2, ydash2);
            Point dash_3 = new Point(xdash3, ydash3);
            Point dash_4 = new Point(xdash4, ydash4);

            Translate_the_Shape(dash_1, dash_2, dash_3, dash_4);

        }




        private void Xshearing_2d_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(x1_2d.Text);
            int y1 = Convert.ToInt32(y1_2d.Text);
            int x2 = Convert.ToInt32(x2_2d.Text);
            int y2 = Convert.ToInt32(y2_2d.Text);
            int x3 = Convert.ToInt32(x3_2d.Text);
            int y3 = Convert.ToInt32(y3_2d.Text);
            int x4 = Convert.ToInt32(x4_2d.Text);
            int y4 = Convert.ToInt32(y4_2d.Text);

            int x_shear = Convert.ToInt32(shear_x.Text);

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            Point p3 = new Point(x3, y3);
            Point p4 = new Point(x4, y4);
            Shear_in_x (p1, p2, p3,p4,x_shear);

        }
        private void Yshearing_2d_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(x1_2d.Text);
            int y1 = Convert.ToInt32(y1_2d.Text);
            int x2 = Convert.ToInt32(x2_2d.Text);
            int y2 = Convert.ToInt32(y2_2d.Text);
            int x3 = Convert.ToInt32(x3_2d.Text);
            int y3 = Convert.ToInt32(y3_2d.Text);
            int x4 = Convert.ToInt32(x4_2d.Text);
            int y4 = Convert.ToInt32(y4_2d.Text);

            int y_shear = Convert.ToInt32(shear_y.Text);

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            Point p3 = new Point(x3, y3);
            Point p4 = new Point(x4, y4);
            Shear_in_y(p1, p2, p3, p4, y_shear);
        }
        private void Clear_picturebox(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.Refresh();
            Draw_Axis();
        }



    }

}

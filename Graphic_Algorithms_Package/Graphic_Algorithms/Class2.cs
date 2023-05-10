using System;

public class DDA_Line
{
    public static int Round_Pixel(float pixel)
    {
        return (int)(pixel + 0.5);
    }
    private void Draw_Red_point(float X, float Y)
    {
        var brush = Brushes.Red;
        var graphic = panel1.CreateGraphics();
        graphic.FillRectangle(brush, 175 + X, 152 - Y, 1, 1);

    }
    private void Draw_DDA_line(Point start, Point end)
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
        page.WriteLine("</style>");
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
}

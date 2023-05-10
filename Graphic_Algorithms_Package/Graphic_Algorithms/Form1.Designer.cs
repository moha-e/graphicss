namespace Graphic_Algorithms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Drawing_line_in_DDA = new System.Windows.Forms.Button();
            this.Xend = new System.Windows.Forms.TextBox();
            this.Ystart = new System.Windows.Forms.TextBox();
            this.Yend = new System.Windows.Forms.TextBox();
            this.Xstart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Drawing_line_in_Bresenham = new System.Windows.Forms.Button();
            this.Draw_circle = new System.Windows.Forms.Button();
            this.X_center = new System.Windows.Forms.TextBox();
            this.Y_center = new System.Windows.Forms.TextBox();
            this.Radius = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.E_X_radius = new System.Windows.Forms.TextBox();
            this.E_Y_center = new System.Windows.Forms.TextBox();
            this.E_X_center = new System.Windows.Forms.TextBox();
            this.E_Y_radius = new System.Windows.Forms.TextBox();
            this.ellipse_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.y4_2d = new System.Windows.Forms.TextBox();
            this.x4_2d = new System.Windows.Forms.TextBox();
            this.y1_2d = new System.Windows.Forms.TextBox();
            this.x1_2d = new System.Windows.Forms.TextBox();
            this.x3_2d = new System.Windows.Forms.TextBox();
            this.y3_2d = new System.Windows.Forms.TextBox();
            this.x2_2d = new System.Windows.Forms.TextBox();
            this.y2_2d = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Draw_2d = new System.Windows.Forms.Button();
            this.Reflection_over_Y = new System.Windows.Forms.Button();
            this.Reflection_over_X = new System.Windows.Forms.Button();
            this.Reflection_over_origin = new System.Windows.Forms.Button();
            this.Translation_button = new System.Windows.Forms.Button();
            this.T_X = new System.Windows.Forms.TextBox();
            this.T_Y = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Scaling_2d = new System.Windows.Forms.Button();
            this.Scaling_X = new System.Windows.Forms.TextBox();
            this.Scaling_Y = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.Rotation_2d = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.Xshearing_2d = new System.Windows.Forms.Button();
            this.shear_x = new System.Windows.Forms.TextBox();
            this.Yshearing_2d = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.shear_y = new System.Windows.Forms.TextBox();
            this.R_angle = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Drawing_line_in_DDA
            // 
            this.Drawing_line_in_DDA.Location = new System.Drawing.Point(88, 130);
            this.Drawing_line_in_DDA.Name = "Drawing_line_in_DDA";
            this.Drawing_line_in_DDA.Size = new System.Drawing.Size(190, 28);
            this.Drawing_line_in_DDA.TabIndex = 4;
            this.Drawing_line_in_DDA.Text = "Draw Line by DDA";
            this.Drawing_line_in_DDA.UseVisualStyleBackColor = true;
            this.Drawing_line_in_DDA.Click += new System.EventHandler(this.Drawing_line_in_DDA_Click);
            // 
            // Xend
            // 
            this.Xend.AccessibleName = "Xend";
            this.Xend.Location = new System.Drawing.Point(50, 89);
            this.Xend.Name = "Xend";
            this.Xend.Size = new System.Drawing.Size(100, 24);
            this.Xend.TabIndex = 2;
            // 
            // Ystart
            // 
            this.Ystart.AccessibleName = "Ystart";
            this.Ystart.Location = new System.Drawing.Point(221, 40);
            this.Ystart.Name = "Ystart";
            this.Ystart.Size = new System.Drawing.Size(100, 24);
            this.Ystart.TabIndex = 1;
            // 
            // Yend
            // 
            this.Yend.AccessibleName = "Yend";
            this.Yend.Location = new System.Drawing.Point(221, 89);
            this.Yend.Name = "Yend";
            this.Yend.Size = new System.Drawing.Size(100, 24);
            this.Yend.TabIndex = 3;
            this.Yend.TextChanged += new System.EventHandler(this.Yend_TextChanged);
            // 
            // Xstart
            // 
            this.Xstart.AccessibleName = "Xstart";
            this.Xstart.Location = new System.Drawing.Point(50, 40);
            this.Xstart.Name = "Xstart";
            this.Xstart.Size = new System.Drawing.Size(100, 24);
            this.Xstart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "X0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "X1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y1";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(368, 453);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(420, 27);
            this.Clear.TabIndex = 24;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_picturebox);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(368, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 384);
            this.panel1.TabIndex = 12;
            // 
            // Drawing_line_in_Bresenham
            // 
            this.Drawing_line_in_Bresenham.Location = new System.Drawing.Point(88, 164);
            this.Drawing_line_in_Bresenham.Name = "Drawing_line_in_Bresenham";
            this.Drawing_line_in_Bresenham.Size = new System.Drawing.Size(190, 29);
            this.Drawing_line_in_Bresenham.TabIndex = 5;
            this.Drawing_line_in_Bresenham.Text = "Draw_line_by_Bresenham";
            this.Drawing_line_in_Bresenham.UseVisualStyleBackColor = true;
            this.Drawing_line_in_Bresenham.Click += new System.EventHandler(this.Draw_line_by_Bresenham);
            // 
            // Draw_circle
            // 
            this.Draw_circle.Location = new System.Drawing.Point(88, 347);
            this.Draw_circle.Name = "Draw_circle";
            this.Draw_circle.Size = new System.Drawing.Size(190, 29);
            this.Draw_circle.TabIndex = 9;
            this.Draw_circle.Text = "Draw_Circle";
            this.Draw_circle.UseVisualStyleBackColor = true;
            this.Draw_circle.Click += new System.EventHandler(this.Draw_circle_Click);
            // 
            // X_center
            // 
            this.X_center.Location = new System.Drawing.Point(67, 231);
            this.X_center.Name = "X_center";
            this.X_center.Size = new System.Drawing.Size(100, 24);
            this.X_center.TabIndex = 6;
            // 
            // Y_center
            // 
            this.Y_center.Location = new System.Drawing.Point(249, 227);
            this.Y_center.Name = "Y_center";
            this.Y_center.Size = new System.Drawing.Size(100, 24);
            this.Y_center.TabIndex = 7;
            this.Y_center.TextChanged += new System.EventHandler(this.Y_center_TextChanged);
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(67, 302);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(100, 24);
            this.Radius.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "X_center";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Y_center";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Radius";
            // 
            // E_X_radius
            // 
            this.E_X_radius.Location = new System.Drawing.Point(67, 465);
            this.E_X_radius.Name = "E_X_radius";
            this.E_X_radius.Size = new System.Drawing.Size(100, 24);
            this.E_X_radius.TabIndex = 12;
            // 
            // E_Y_center
            // 
            this.E_Y_center.Location = new System.Drawing.Point(249, 403);
            this.E_Y_center.Name = "E_Y_center";
            this.E_Y_center.Size = new System.Drawing.Size(100, 24);
            this.E_Y_center.TabIndex = 11;
            // 
            // E_X_center
            // 
            this.E_X_center.Location = new System.Drawing.Point(67, 403);
            this.E_X_center.Name = "E_X_center";
            this.E_X_center.Size = new System.Drawing.Size(100, 24);
            this.E_X_center.TabIndex = 10;
            // 
            // E_Y_radius
            // 
            this.E_Y_radius.Location = new System.Drawing.Point(249, 465);
            this.E_Y_radius.Name = "E_Y_radius";
            this.E_Y_radius.Size = new System.Drawing.Size(100, 24);
            this.E_Y_radius.TabIndex = 13;
            this.E_Y_radius.TextChanged += new System.EventHandler(this.E_Y_radius_TextChanged);
            // 
            // ellipse_button
            // 
            this.ellipse_button.Location = new System.Drawing.Point(88, 513);
            this.ellipse_button.Name = "ellipse_button";
            this.ellipse_button.Size = new System.Drawing.Size(190, 29);
            this.ellipse_button.TabIndex = 14;
            this.ellipse_button.Text = "Draw_ Ellipse";
            this.ellipse_button.UseVisualStyleBackColor = true;
            this.ellipse_button.Click += new System.EventHandler(this.ellipse_draw_click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-2, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "X_center";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Y_center";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 472);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "X_Radius";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(180, 472);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Y_Radius";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // y4_2d
            // 
            this.y4_2d.Location = new System.Drawing.Point(239, 713);
            this.y4_2d.Name = "y4_2d";
            this.y4_2d.Size = new System.Drawing.Size(100, 24);
            this.y4_2d.TabIndex = 22;
            // 
            // x4_2d
            // 
            this.x4_2d.Location = new System.Drawing.Point(67, 716);
            this.x4_2d.Name = "x4_2d";
            this.x4_2d.Size = new System.Drawing.Size(100, 24);
            this.x4_2d.TabIndex = 21;
            // 
            // y1_2d
            // 
            this.y1_2d.Location = new System.Drawing.Point(239, 579);
            this.y1_2d.Name = "y1_2d";
            this.y1_2d.Size = new System.Drawing.Size(100, 24);
            this.y1_2d.TabIndex = 16;
            // 
            // x1_2d
            // 
            this.x1_2d.Location = new System.Drawing.Point(67, 579);
            this.x1_2d.Name = "x1_2d";
            this.x1_2d.Size = new System.Drawing.Size(100, 24);
            this.x1_2d.TabIndex = 15;
            // 
            // x3_2d
            // 
            this.x3_2d.Location = new System.Drawing.Point(67, 672);
            this.x3_2d.Name = "x3_2d";
            this.x3_2d.Size = new System.Drawing.Size(100, 24);
            this.x3_2d.TabIndex = 19;
            // 
            // y3_2d
            // 
            this.y3_2d.Location = new System.Drawing.Point(239, 672);
            this.y3_2d.Name = "y3_2d";
            this.y3_2d.Size = new System.Drawing.Size(100, 24);
            this.y3_2d.TabIndex = 20;
            // 
            // x2_2d
            // 
            this.x2_2d.Location = new System.Drawing.Point(67, 625);
            this.x2_2d.Name = "x2_2d";
            this.x2_2d.Size = new System.Drawing.Size(100, 24);
            this.x2_2d.TabIndex = 17;
            // 
            // y2_2d
            // 
            this.y2_2d.Location = new System.Drawing.Point(239, 625);
            this.y2_2d.Name = "y2_2d";
            this.y2_2d.Size = new System.Drawing.Size(100, 24);
            this.y2_2d.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(173, 716);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 17);
            this.label12.TabIndex = 39;
            this.label12.Text = "y4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(173, 672);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 17);
            this.label13.TabIndex = 40;
            this.label13.Text = "y3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(173, 632);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "y2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(180, 586);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 17);
            this.label15.TabIndex = 42;
            this.label15.Text = "y1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(2, 716);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 17);
            this.label16.TabIndex = 43;
            this.label16.Text = "x4";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(2, 672);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 17);
            this.label17.TabIndex = 44;
            this.label17.Text = "x3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(2, 632);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 17);
            this.label18.TabIndex = 45;
            this.label18.Text = "x2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(2, 586);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 17);
            this.label19.TabIndex = 46;
            this.label19.Text = "x1";
            // 
            // Draw_2d
            // 
            this.Draw_2d.Location = new System.Drawing.Point(67, 775);
            this.Draw_2d.Name = "Draw_2d";
            this.Draw_2d.Size = new System.Drawing.Size(272, 29);
            this.Draw_2d.TabIndex = 23;
            this.Draw_2d.Text = "Draw_ 2d";
            this.Draw_2d.UseVisualStyleBackColor = true;
            this.Draw_2d.Click += new System.EventHandler(this.Draw_2d_click);
            // 
            // Reflection_over_Y
            // 
            this.Reflection_over_Y.Location = new System.Drawing.Point(368, 513);
            this.Reflection_over_Y.Name = "Reflection_over_Y";
            this.Reflection_over_Y.Size = new System.Drawing.Size(129, 29);
            this.Reflection_over_Y.TabIndex = 25;
            this.Reflection_over_Y.Text = "Reflection_Y_2d";
            this.Reflection_over_Y.UseVisualStyleBackColor = true;
            this.Reflection_over_Y.Click += new System.EventHandler(this.Reflection_over_Y_Click);
            // 
            // Reflection_over_X
            // 
            this.Reflection_over_X.Location = new System.Drawing.Point(531, 513);
            this.Reflection_over_X.Name = "Reflection_over_X";
            this.Reflection_over_X.Size = new System.Drawing.Size(129, 29);
            this.Reflection_over_X.TabIndex = 26;
            this.Reflection_over_X.Text = "Reflection_X_2d";
            this.Reflection_over_X.UseVisualStyleBackColor = true;
            this.Reflection_over_X.Click += new System.EventHandler(this.Reflection_over_X_Click);
            // 
            // Reflection_over_origin
            // 
            this.Reflection_over_origin.Location = new System.Drawing.Point(691, 513);
            this.Reflection_over_origin.Name = "Reflection_over_origin";
            this.Reflection_over_origin.Size = new System.Drawing.Size(143, 29);
            this.Reflection_over_origin.TabIndex = 27;
            this.Reflection_over_origin.Text = "Reflection_Origin_2d";
            this.Reflection_over_origin.UseVisualStyleBackColor = true;
            this.Reflection_over_origin.Click += new System.EventHandler(this.Reflection_over_origin_click);
            // 
            // Translation_button
            // 
            this.Translation_button.Location = new System.Drawing.Point(368, 574);
            this.Translation_button.Name = "Translation_button";
            this.Translation_button.Size = new System.Drawing.Size(111, 29);
            this.Translation_button.TabIndex = 30;
            this.Translation_button.Text = "Translation_2d";
            this.Translation_button.UseVisualStyleBackColor = true;
            this.Translation_button.Click += new System.EventHandler(this.Translation_Click);
            // 
            // T_X
            // 
            this.T_X.Location = new System.Drawing.Point(544, 579);
            this.T_X.Name = "T_X";
            this.T_X.Size = new System.Drawing.Size(116, 24);
            this.T_X.TabIndex = 28;
            // 
            // T_Y
            // 
            this.T_Y.Location = new System.Drawing.Point(704, 579);
            this.T_Y.Name = "T_Y";
            this.T_Y.Size = new System.Drawing.Size(116, 24);
            this.T_Y.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(666, 582);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 17);
            this.label20.TabIndex = 55;
            this.label20.Text = "T_Y";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(506, 582);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 17);
            this.label21.TabIndex = 56;
            this.label21.Text = "T_X";
            // 
            // Scaling_2d
            // 
            this.Scaling_2d.Location = new System.Drawing.Point(368, 632);
            this.Scaling_2d.Name = "Scaling_2d";
            this.Scaling_2d.Size = new System.Drawing.Size(111, 29);
            this.Scaling_2d.TabIndex = 33;
            this.Scaling_2d.Text = "Scaling_2d";
            this.Scaling_2d.UseVisualStyleBackColor = true;
            this.Scaling_2d.Click += new System.EventHandler(this.Scaling_2d_Click);
            // 
            // Scaling_X
            // 
            this.Scaling_X.Location = new System.Drawing.Point(544, 637);
            this.Scaling_X.Name = "Scaling_X";
            this.Scaling_X.Size = new System.Drawing.Size(116, 24);
            this.Scaling_X.TabIndex = 31;
            // 
            // Scaling_Y
            // 
            this.Scaling_Y.Location = new System.Drawing.Point(704, 637);
            this.Scaling_Y.Name = "Scaling_Y";
            this.Scaling_Y.Size = new System.Drawing.Size(116, 24);
            this.Scaling_Y.TabIndex = 32;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(506, 644);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 17);
            this.label22.TabIndex = 60;
            this.label22.Text = "S_X";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(666, 644);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 17);
            this.label23.TabIndex = 61;
            this.label23.Text = "S_Y";
            // 
            // Rotation_2d
            // 
            this.Rotation_2d.Location = new System.Drawing.Point(368, 775);
            this.Rotation_2d.Name = "Rotation_2d";
            this.Rotation_2d.Size = new System.Drawing.Size(111, 29);
            this.Rotation_2d.TabIndex = 39;
            this.Rotation_2d.Text = "Rotation_2d";
            this.Rotation_2d.UseVisualStyleBackColor = true;
            this.Rotation_2d.Click += new System.EventHandler(this.Rotation_2d_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(493, 781);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 17);
            this.label24.TabIndex = 64;
            this.label24.Text = "Angle";
            // 
            // Xshearing_2d
            // 
            this.Xshearing_2d.Location = new System.Drawing.Point(368, 681);
            this.Xshearing_2d.Name = "Xshearing_2d";
            this.Xshearing_2d.Size = new System.Drawing.Size(111, 29);
            this.Xshearing_2d.TabIndex = 35;
            this.Xshearing_2d.Text = "X_Shear_2d";
            this.Xshearing_2d.UseVisualStyleBackColor = true;
            this.Xshearing_2d.Click += new System.EventHandler(this.Xshearing_2d_Click);
            // 
            // shear_x
            // 
            this.shear_x.Location = new System.Drawing.Point(557, 686);
            this.shear_x.Name = "shear_x";
            this.shear_x.Size = new System.Drawing.Size(103, 24);
            this.shear_x.TabIndex = 34;
            // 
            // Yshearing_2d
            // 
            this.Yshearing_2d.Location = new System.Drawing.Point(368, 725);
            this.Yshearing_2d.Name = "Yshearing_2d";
            this.Yshearing_2d.Size = new System.Drawing.Size(111, 29);
            this.Yshearing_2d.TabIndex = 37;
            this.Yshearing_2d.Text = "Y_Shear_2d";
            this.Yshearing_2d.UseVisualStyleBackColor = true;
            this.Yshearing_2d.Click += new System.EventHandler(this.Yshearing_2d_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(493, 735);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 17);
            this.label25.TabIndex = 69;
            this.label25.Text = "Shear_Y";
            // 
            // shear_y
            // 
            this.shear_y.Location = new System.Drawing.Point(557, 732);
            this.shear_y.Name = "shear_y";
            this.shear_y.Size = new System.Drawing.Size(103, 24);
            this.shear_y.TabIndex = 36;
            // 
            // R_angle
            // 
            this.R_angle.Location = new System.Drawing.Point(557, 781);
            this.R_angle.Name = "R_angle";
            this.R_angle.Size = new System.Drawing.Size(103, 24);
            this.R_angle.TabIndex = 38;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(492, 689);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 17);
            this.label26.TabIndex = 73;
            this.label26.Text = "Shear_X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 825);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.R_angle);
            this.Controls.Add(this.shear_y);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.Yshearing_2d);
            this.Controls.Add(this.shear_x);
            this.Controls.Add(this.Xshearing_2d);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.Rotation_2d);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Scaling_Y);
            this.Controls.Add(this.Scaling_X);
            this.Controls.Add(this.Scaling_2d);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.T_Y);
            this.Controls.Add(this.T_X);
            this.Controls.Add(this.Translation_button);
            this.Controls.Add(this.Reflection_over_origin);
            this.Controls.Add(this.Reflection_over_X);
            this.Controls.Add(this.Reflection_over_Y);
            this.Controls.Add(this.Draw_2d);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.y2_2d);
            this.Controls.Add(this.x2_2d);
            this.Controls.Add(this.y3_2d);
            this.Controls.Add(this.x3_2d);
            this.Controls.Add(this.x1_2d);
            this.Controls.Add(this.y1_2d);
            this.Controls.Add(this.x4_2d);
            this.Controls.Add(this.y4_2d);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ellipse_button);
            this.Controls.Add(this.E_Y_radius);
            this.Controls.Add(this.E_X_center);
            this.Controls.Add(this.E_Y_center);
            this.Controls.Add(this.E_X_radius);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.Y_center);
            this.Controls.Add(this.X_center);
            this.Controls.Add(this.Draw_circle);
            this.Controls.Add(this.Drawing_line_in_Bresenham);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Xstart);
            this.Controls.Add(this.Yend);
            this.Controls.Add(this.Ystart);
            this.Controls.Add(this.Xend);
            this.Controls.Add(this.Drawing_line_in_DDA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphic__Backedage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Drawing_line_in_DDA;
        private System.Windows.Forms.TextBox Xend;
        private System.Windows.Forms.TextBox Ystart;
        private System.Windows.Forms.TextBox Yend;
        private System.Windows.Forms.TextBox Xstart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Drawing_line_in_Bresenham;
        private System.Windows.Forms.Button Draw_circle;
        private System.Windows.Forms.TextBox X_center;
        private System.Windows.Forms.TextBox Y_center;
        private System.Windows.Forms.TextBox Radius;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox E_X_radius;
        private System.Windows.Forms.TextBox E_Y_center;
        private System.Windows.Forms.TextBox E_X_center;
        private System.Windows.Forms.TextBox E_Y_radius;
        private System.Windows.Forms.Button ellipse_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox y4_2d;
        private System.Windows.Forms.TextBox x4_2d;
        private System.Windows.Forms.TextBox y1_2d;
        private System.Windows.Forms.TextBox x1_2d;
        private System.Windows.Forms.TextBox x3_2d;
        private System.Windows.Forms.TextBox y3_2d;
        private System.Windows.Forms.TextBox x2_2d;
        private System.Windows.Forms.TextBox y2_2d;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button Draw_2d;
        private System.Windows.Forms.Button Reflection_over_Y;
        private System.Windows.Forms.Button Reflection_over_X;
        private System.Windows.Forms.Button Reflection_over_origin;
        private System.Windows.Forms.Button Translation_button;
        private System.Windows.Forms.TextBox T_X;
        private System.Windows.Forms.TextBox T_Y;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button Scaling_2d;
        private System.Windows.Forms.TextBox Scaling_X;
        private System.Windows.Forms.TextBox Scaling_Y;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button Rotation_2d;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button Xshearing_2d;
        private System.Windows.Forms.TextBox shear_x;
        private System.Windows.Forms.Button Yshearing_2d;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox shear_y;
        private System.Windows.Forms.TextBox R_angle;
        private System.Windows.Forms.Label label26;
    }
}


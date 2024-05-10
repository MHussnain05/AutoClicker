namespace AutoClicker
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hours_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mins_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.seconds_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.millisecond_numeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Start_button = new System.Windows.Forms.Button();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ClickType_comboBox = new System.Windows.Forms.ComboBox();
            this.MouseButton_comboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.Repeat_no_limit_Radio = new System.Windows.Forms.RadioButton();
            this.Repeat_with_limit_radio = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PickPosition_radio = new System.Windows.Forms.RadioButton();
            this.CurrentPositon_radio = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.X_position_textBox = new System.Windows.Forms.TextBox();
            this.Y_Position_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Number_of_clicks_textBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.PictureBox();
            this.Minimize_picture = new System.Windows.Forms.PictureBox();
            this.Exit_Picture = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Brightness_Changer = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hours_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mins_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seconds_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millisecond_numeric)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_Changer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click Interval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "hours";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.hours_numericUpDown);
            this.panel1.Controls.Add(this.mins_numericUpDown);
            this.panel1.Controls.Add(this.seconds_numericUpDown);
            this.panel1.Controls.Add(this.millisecond_numeric);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 58);
            this.panel1.TabIndex = 10;
            // 
            // hours_numericUpDown
            // 
            this.hours_numericUpDown.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_numericUpDown.Location = new System.Drawing.Point(17, 29);
            this.hours_numericUpDown.Name = "hours_numericUpDown";
            this.hours_numericUpDown.Size = new System.Drawing.Size(36, 21);
            this.hours_numericUpDown.TabIndex = 19;
            this.hours_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mins_numericUpDown
            // 
            this.mins_numericUpDown.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mins_numericUpDown.Location = new System.Drawing.Point(99, 29);
            this.mins_numericUpDown.Name = "mins_numericUpDown";
            this.mins_numericUpDown.Size = new System.Drawing.Size(36, 21);
            this.mins_numericUpDown.TabIndex = 18;
            this.mins_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // seconds_numericUpDown
            // 
            this.seconds_numericUpDown.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds_numericUpDown.Location = new System.Drawing.Point(175, 29);
            this.seconds_numericUpDown.Name = "seconds_numericUpDown";
            this.seconds_numericUpDown.Size = new System.Drawing.Size(36, 21);
            this.seconds_numericUpDown.TabIndex = 17;
            this.seconds_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // millisecond_numeric
            // 
            this.millisecond_numeric.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.millisecond_numeric.Location = new System.Drawing.Point(264, 29);
            this.millisecond_numeric.Name = "millisecond_numeric";
            this.millisecond_numeric.Size = new System.Drawing.Size(36, 21);
            this.millisecond_numeric.TabIndex = 16;
            this.millisecond_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "milliseconds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "mins";
            // 
            // Start_button
            // 
            this.Start_button.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_button.Location = new System.Drawing.Point(2, 293);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(100, 40);
            this.Start_button.TabIndex = 2;
            this.Start_button.Text = "Start(F6)";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Stop_Button
            // 
            this.Stop_Button.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_Button.Location = new System.Drawing.Point(108, 293);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(100, 40);
            this.Stop_Button.TabIndex = 12;
            this.Stop_Button.Text = "Stop(F6)";
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.ClickType_comboBox);
            this.panel3.Controls.Add(this.MouseButton_comboBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(2, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 110);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 14);
            this.label14.TabIndex = 21;
            this.label14.Text = "Click Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 14);
            this.label13.TabIndex = 20;
            this.label13.Text = "Mouse Button";
            // 
            // ClickType_comboBox
            // 
            this.ClickType_comboBox.FormattingEnabled = true;
            this.ClickType_comboBox.Location = new System.Drawing.Point(92, 77);
            this.ClickType_comboBox.Name = "ClickType_comboBox";
            this.ClickType_comboBox.Size = new System.Drawing.Size(70, 21);
            this.ClickType_comboBox.TabIndex = 19;
            // 
            // MouseButton_comboBox
            // 
            this.MouseButton_comboBox.FormattingEnabled = true;
            this.MouseButton_comboBox.Location = new System.Drawing.Point(92, 30);
            this.MouseButton_comboBox.Name = "MouseButton_comboBox";
            this.MouseButton_comboBox.Size = new System.Drawing.Size(70, 21);
            this.MouseButton_comboBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Click Option";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.numericUpDown4);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.Repeat_no_limit_Radio);
            this.panel4.Controls.Add(this.Repeat_with_limit_radio);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(203, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(162, 110);
            this.panel4.TabIndex = 14;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.Location = new System.Drawing.Point(32, 54);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(42, 21);
            this.numericUpDown4.TabIndex = 20;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "times";
            // 
            // Repeat_no_limit_Radio
            // 
            this.Repeat_no_limit_Radio.AutoSize = true;
            this.Repeat_no_limit_Radio.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repeat_no_limit_Radio.Location = new System.Drawing.Point(10, 80);
            this.Repeat_no_limit_Radio.Name = "Repeat_no_limit_Radio";
            this.Repeat_no_limit_Radio.Size = new System.Drawing.Size(129, 18);
            this.Repeat_no_limit_Radio.TabIndex = 19;
            this.Repeat_no_limit_Radio.TabStop = true;
            this.Repeat_no_limit_Radio.Text = " Repeat Until Stop";
            this.Repeat_no_limit_Radio.UseVisualStyleBackColor = true;
            // 
            // Repeat_with_limit_radio
            // 
            this.Repeat_with_limit_radio.AutoSize = true;
            this.Repeat_with_limit_radio.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repeat_with_limit_radio.Location = new System.Drawing.Point(10, 30);
            this.Repeat_with_limit_radio.Name = "Repeat_with_limit_radio";
            this.Repeat_with_limit_radio.Size = new System.Drawing.Size(69, 18);
            this.Repeat_with_limit_radio.TabIndex = 18;
            this.Repeat_with_limit_radio.TabStop = true;
            this.Repeat_with_limit_radio.Text = " Repeat";
            this.Repeat_with_limit_radio.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Click Repeat";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.PickPosition_radio);
            this.panel5.Controls.Add(this.CurrentPositon_radio);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.X_position_textBox);
            this.panel5.Controls.Add(this.Y_Position_textBox);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(2, 208);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(363, 76);
            this.panel5.TabIndex = 17;
            // 
            // PickPosition_radio
            // 
            this.PickPosition_radio.AutoSize = true;
            this.PickPosition_radio.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickPosition_radio.Location = new System.Drawing.Point(142, 34);
            this.PickPosition_radio.Name = "PickPosition_radio";
            this.PickPosition_radio.Size = new System.Drawing.Size(93, 18);
            this.PickPosition_radio.TabIndex = 25;
            this.PickPosition_radio.TabStop = true;
            this.PickPosition_radio.Text = "Pick Position";
            this.PickPosition_radio.UseVisualStyleBackColor = true;
            // 
            // CurrentPositon_radio
            // 
            this.CurrentPositon_radio.AutoSize = true;
            this.CurrentPositon_radio.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPositon_radio.Location = new System.Drawing.Point(24, 34);
            this.CurrentPositon_radio.Name = "CurrentPositon_radio";
            this.CurrentPositon_radio.Size = new System.Drawing.Size(115, 18);
            this.CurrentPositon_radio.TabIndex = 24;
            this.CurrentPositon_radio.TabStop = true;
            this.CurrentPositon_radio.Text = "Current Position";
            this.CurrentPositon_radio.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(302, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 14);
            this.label12.TabIndex = 23;
            this.label12.Text = "Y value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(251, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 14);
            this.label11.TabIndex = 22;
            this.label11.Text = "X value";
            // 
            // X_position_textBox
            // 
            this.X_position_textBox.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X_position_textBox.Location = new System.Drawing.Point(252, 31);
            this.X_position_textBox.Name = "X_position_textBox";
            this.X_position_textBox.Size = new System.Drawing.Size(36, 21);
            this.X_position_textBox.TabIndex = 21;
            this.X_position_textBox.Text = "0";
            this.X_position_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Y_Position_textBox
            // 
            this.Y_Position_textBox.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y_Position_textBox.Location = new System.Drawing.Point(305, 31);
            this.Y_Position_textBox.Name = "Y_Position_textBox";
            this.Y_Position_textBox.Size = new System.Drawing.Size(36, 21);
            this.Y_Position_textBox.TabIndex = 20;
            this.Y_Position_textBox.Text = "0";
            this.Y_Position_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Cursor Position";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(300, 295);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 14);
            this.label15.TabIndex = 22;
            this.label15.Text = "No of Clicks";
            // 
            // Number_of_clicks_textBox
            // 
            this.Number_of_clicks_textBox.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_of_clicks_textBox.Location = new System.Drawing.Point(301, 313);
            this.Number_of_clicks_textBox.Name = "Number_of_clicks_textBox";
            this.Number_of_clicks_textBox.Size = new System.Drawing.Size(55, 21);
            this.Number_of_clicks_textBox.TabIndex = 26;
            this.Number_of_clicks_textBox.Text = "0";
            this.Number_of_clicks_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(211, 295);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(68, 38);
            this.ResetButton.TabIndex = 27;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click_1);
            // 
            // Help
            // 
            this.Help.Cursor = System.Windows.Forms.Cursors.Help;
            this.Help.Image = global::AutoClicker.Properties.Resources.output_onlinepngtools__1__removebg_preview__1_;
            this.Help.InitialImage = null;
            this.Help.Location = new System.Drawing.Point(258, 8);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(32, 32);
            this.Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Help.TabIndex = 30;
            this.Help.TabStop = false;
            this.Help.Click += new System.EventHandler(this.Help_Click_1);
            // 
            // Minimize_picture
            // 
            this.Minimize_picture.Image = global::AutoClicker.Properties.Resources.delete_removebg_preview__1___1_;
            this.Minimize_picture.InitialImage = null;
            this.Minimize_picture.Location = new System.Drawing.Point(296, 9);
            this.Minimize_picture.Name = "Minimize_picture";
            this.Minimize_picture.Size = new System.Drawing.Size(32, 32);
            this.Minimize_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Minimize_picture.TabIndex = 29;
            this.Minimize_picture.TabStop = false;
            this.Minimize_picture.Click += new System.EventHandler(this.Minimize_picture_Click);
            // 
            // Exit_Picture
            // 
            this.Exit_Picture.Image = global::AutoClicker.Properties.Resources.delete__1__removebg_preview__1_2;
            this.Exit_Picture.InitialImage = null;
            this.Exit_Picture.Location = new System.Drawing.Point(336, 9);
            this.Exit_Picture.Name = "Exit_Picture";
            this.Exit_Picture.Size = new System.Drawing.Size(32, 32);
            this.Exit_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Exit_Picture.TabIndex = 28;
            this.Exit_Picture.TabStop = false;
            this.Exit_Picture.Click += new System.EventHandler(this.Exit_Picture_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 23);
            this.label6.TabIndex = 32;
            this.label6.Text = "Auto Clicker";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoClicker.Properties.Resources.output_onlinepngtools__2__removebg_preview__1_;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.Start_button);
            this.panel2.Controls.Add(this.Stop_Button);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.ResetButton);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.Number_of_clicks_textBox);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 351);
            this.panel2.TabIndex = 33;
            // 
            // Brightness_Changer
            // 
            this.Brightness_Changer.BackColor = System.Drawing.SystemColors.Control;
            this.Brightness_Changer.Cursor = System.Windows.Forms.Cursors.Default;
            this.Brightness_Changer.LargeChange = 1;
            this.Brightness_Changer.Location = new System.Drawing.Point(176, 3);
            this.Brightness_Changer.Margin = new System.Windows.Forms.Padding(0);
            this.Brightness_Changer.Maximum = 1;
            this.Brightness_Changer.MaximumSize = new System.Drawing.Size(40, 30);
            this.Brightness_Changer.MinimumSize = new System.Drawing.Size(40, 30);
            this.Brightness_Changer.Name = "Brightness_Changer";
            this.Brightness_Changer.Size = new System.Drawing.Size(40, 45);
            this.Brightness_Changer.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(373, 382);
            this.Controls.Add(this.Brightness_Changer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Minimize_picture);
            this.Controls.Add(this.Exit_Picture);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hours_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mins_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seconds_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millisecond_numeric)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_Changer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton Repeat_no_limit_Radio;
        private System.Windows.Forms.RadioButton Repeat_with_limit_radio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton PickPosition_radio;
        private System.Windows.Forms.RadioButton CurrentPositon_radio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox X_position_textBox;
        private System.Windows.Forms.TextBox Y_Position_textBox;
        private System.Windows.Forms.NumericUpDown millisecond_numeric;
        private System.Windows.Forms.NumericUpDown hours_numericUpDown;
        private System.Windows.Forms.NumericUpDown mins_numericUpDown;
        private System.Windows.Forms.NumericUpDown seconds_numericUpDown;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ClickType_comboBox;
        private System.Windows.Forms.ComboBox MouseButton_comboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Number_of_clicks_textBox;
        private System.Windows.Forms.NumericUpDown RepeatCounter_numericUpDown;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.PictureBox Help;
        private System.Windows.Forms.PictureBox Minimize_picture;
        private System.Windows.Forms.PictureBox Exit_Picture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar Brightness_Changer;
    }
}


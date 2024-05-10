using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Thread = System.Threading.Thread;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;




namespace AutoClicker
{
    public partial class Form1 : Form
    {
        
        private Timer autoClickTimer;
        private int clickCounter = 0;
        private System.Windows.Forms.Timer refreshTimer;
        private bool isDragging = false;
        private Point lastMousePosition;
        // Mouse event constants
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        private const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const uint MOUSEEVENTF_MIDDLEUP = 0x0040;

        // Import the user32.dll for mouse events
        [DllImport("user32.dll", SetLastError = true)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, IntPtr dwExtraInfo);
        // Declare a list to track the click positions and their timestamps
        private List<(Point Position, DateTime Timestamp)> clickPositions = new List<(Point Position, DateTime Timestamp)>();
        public Form1()
        {
            InitializeComponent();
            // Initialize combo boxes
            InitializeComboBoxes();
            // Initialize mouse event handlers
            InitializeMouseEventHandlers();
            
            // Initialize the timer
            autoClickTimer = new Timer();
            autoClickTimer.Tick += AutoClickTimer_Tick;
            Repeat_no_limit_Radio.Checked = true;
            CurrentPositon_radio.Checked = true;

            // Add event handlers for radio buttons
            CurrentPositon_radio.CheckedChanged += PositionRadioButton_CheckedChanged;
            PickPosition_radio.CheckedChanged += PositionRadioButton_CheckedChanged;
            InitializeRefreshTimer();

        }

        private void InitializeComponents()
        { 
            // Setting up NumericUpDown controls
            this.hours_numericUpDown.Minimum = 0;
            this.hours_numericUpDown.Maximum = 23;
            this.mins_numericUpDown.Minimum = 0;
            this.mins_numericUpDown.Maximum = 59;
            this.seconds_numericUpDown.Minimum = 0;
            this.seconds_numericUpDown.Maximum = 59;
            this.millisecond_numeric.Minimum = 0;
            this.millisecond_numeric.Maximum = 999;
           
            

        }
        private void InitializeComboBoxes()
        {
            // Initialize MouseButton_comboBox with items and default value
            MouseButton_comboBox.Items.Add("Left");
            MouseButton_comboBox.Items.Add("Right");
            MouseButton_comboBox.Items.Add("Middle");
            MouseButton_comboBox.SelectedItem = "Left"; // Default selection is Left

            // Initialize ClickType_comboBox with items and default value
            ClickType_comboBox.Items.Add("Single");
            ClickType_comboBox.Items.Add("Double");
            ClickType_comboBox.SelectedItem = "Single"; // Default selection is Single
        }
        
        private void InitializeRefreshTimer()
        {
            // Create a timer for refreshing the form
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Tick += (sender, e) => this.Invalidate();
            refreshTimer.Start();
        }
        private void Exit_Picture_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            // Minimize the current form
            this.WindowState = FormWindowState.Minimized;

        }

        private void Minimize_picture_MouseEnter(object sender, EventArgs e)
        {
            // Change the PictureBox's border style back to None
            Minimize_picture.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Minimize_picture_MouseLeave(object sender, EventArgs e)
        {
            // Change the PictureBox's border style back to None
            Minimize_picture.BorderStyle = BorderStyle.None;
        }

        private void Exit_Picture_MouseEnter(object sender, EventArgs e)
        {
            Exit_Picture.BorderStyle = BorderStyle.FixedSingle;    
        }

        private void Exit_Picture_MouseLeave(object sender, EventArgs e)
        {
            Exit_Picture.BorderStyle= BorderStyle.None;
        }

        private void Help_MouseEnter(object sender, EventArgs e)
        {
            Help.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Help_MouseLeave(object sender, EventArgs e)
        {
            Help.BorderStyle= BorderStyle.None;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void Start_button_Click(object sender, EventArgs e)
        {
            // Calculate the interval from NumericUpDown controls
            int hours = (int)hours_numericUpDown.Value;
            int minutes = (int)mins_numericUpDown.Value;
            int seconds = (int)seconds_numericUpDown.Value;
            int milliseconds = (int)millisecond_numeric.Value;

            // Calculate the total interval in milliseconds
            int totalMilliseconds = (hours * 60 * 60 * 1000) +
                                    (minutes * 60 * 1000) +
                                    (seconds * 1000) +
                                    milliseconds;

            // Set the timer interval and start it
            autoClickTimer.Interval = totalMilliseconds;
            autoClickTimer.Start();
           
            // Make the StartButton unclickable and the StopButton clickable
            Start_button.Enabled = false;
            Stop_Button.Enabled = true;
            Number_of_clicks_textBox.ReadOnly=true;

        }
        private void AutoClickTimer_Tick(object sender, EventArgs e)
        {
            // Determine the X and Y coordinates for the click
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;

            if (PickPosition_radio.Checked)
            {
                // Try to parse the values from the text boxes
                bool isXValid = int.TryParse(X_position_textBox.Text, out x);
                bool isYValid = int.TryParse(Y_Position_textBox.Text, out y);

                // If either value is invalid, handle the error
                if (!isXValid || !isYValid)
                {
                    MessageBox.Show("Please enter valid X and Y values for the pick position.");
                    return;
                }

                // Set the cursor position to the specified coordinates
                Cursor.Position = new Point(x, y);
            }

            // Add the current mouse position and timestamp to the clickPositions list
            clickPositions.Add((new Point(x, y), DateTime.Now));

            // Perform the auto-click based on the selected mouse button and click type
            PerformAutoClick();

            // Increment the click counter
            clickCounter++;

            // Update the Number_of_clicks_textBox with the new counter value
            Number_of_clicks_textBox.Text = clickCounter.ToString();

            // Check if Repeat with Limit is selected and if the limit has been reached
            if (Repeat_with_limit_radio.Checked)
            {
                int repeatLimit = (int)RepeatCounter_numericUpDown.Value;

                if (clickCounter >= repeatLimit)
                {
                    // Stop the timer when the repeat limit is reached
                    autoClickTimer.Stop();

                    // Optionally, reset clickCounter for future use
                    clickCounter = 0;

                    // Enable the StartButton and disable the StopButton when auto-clicking stops
                    Start_button.Enabled = true;
                    Stop_Button.Enabled = false;
                }
            }

            // Refresh the form to trigger a repaint
            this.Invalidate();
        }



        private void Stop_Button_Click(object sender, EventArgs e)
        {
            // Stop the auto-click timer
            autoClickTimer.Stop();
            // Make the StopButton unclickable and the StartButton clickable
            Stop_Button.Enabled = false;
            Start_button.Enabled = true;
        }
        private void ToggleAutoClicking()
        {
            if (autoClickTimer.Enabled)
            {
                // If the timer is running, stop it
                autoClickTimer.Stop();
            }
            else
            {
                // If the timer is not running, start it
                int hours = (int)hours_numericUpDown.Value;
                int minutes = (int)mins_numericUpDown.Value;
                int seconds = (int)seconds_numericUpDown.Value;
                int milliseconds = (int)millisecond_numeric.Value;

                // Calculate the total interval in milliseconds
                int totalMilliseconds = (hours * 60 * 60 * 1000) +
                                        (minutes * 60 * 1000) +
                                        (seconds * 1000) +
                                        milliseconds;

                // Set the timer interval
                autoClickTimer.Interval = totalMilliseconds;

                // Start the timer
                autoClickTimer.Start();
            }
        }
        private void PerformAutoClick()
        {
            // Get the selected mouse button from MouseButton_comboBox
            string selectedButton = MouseButton_comboBox.SelectedItem.ToString();
            uint mouseButtonFlag;

            // Determine which mouse button flag to use
            switch (selectedButton)
            {
                case "Left":
                    mouseButtonFlag = MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP;
                    break;
                case "Right":
                    mouseButtonFlag = MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP;
                    break;
                case "Middle":
                    mouseButtonFlag = MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP;
                    break;
                default:
                    // Default to left mouse button if selection is not recognized
                    mouseButtonFlag = MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP;
                    break;
            }

            // Get the selected click type from ClickType_comboBox
            string selectedClickType = ClickType_comboBox.SelectedItem.ToString();

            // Determine how many times to perform the click
            int numberOfClicks = (selectedClickType == "Double") ? 2 : 1;

            // Perform the mouse clicks based on the selected mouse button and click type
            for (int i = 0; i < numberOfClicks; i++)
            {
                // Simulate mouse down and up events for the selected button
                mouse_event(mouseButtonFlag, 0, 0, 0, IntPtr.Zero);

                // Optional: Add a short delay between double clicks
                if (selectedClickType == "Double" && i == 0)
                {
                    Thread.Sleep(50); // Adjust delay as needed
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check if the F6 key is pressed
            if (keyData == Keys.F6)
            {
                // Toggle auto-clicking
                ToggleAutoClicking();

                // Return true to indicate the key press has been handled
                return true;
            }

            // Call the base method if the key press wasn't F6
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void InitializeRepeatControls()
        {
            // Initialize Repeat_with_limit_radio
            Repeat_with_limit_radio.Text = "Repeat with Limit";
            Repeat_with_limit_radio.CheckedChanged += RepeatRadioButton_CheckedChanged;

            // Initialize Repeat_no_limit_radio
            Repeat_no_limit_Radio.Text = "Repeat with No Limit";
            Repeat_no_limit_Radio.Checked = true; // Default selection is Repeat with No Limit
            Repeat_no_limit_Radio.CheckedChanged += RepeatRadioButton_CheckedChanged;

            // Initialize RepeatCounter_numericUpDown
            RepeatCounter_numericUpDown.Minimum = 1;
            RepeatCounter_numericUpDown.Maximum = int.MaxValue; // Set a maximum limit for the counter
            RepeatCounter_numericUpDown.Value = 1;
            RepeatCounter_numericUpDown.Visible = false; // Initially invisible, only visible when Repeat with Limit is selected

            // Add the controls to the form
            this.Controls.Add(Repeat_with_limit_radio);
            this.Controls.Add(Repeat_no_limit_Radio);
            this.Controls.Add(RepeatCounter_numericUpDown);
        }
        private void RepeatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Repeat_with_limit_radio.Checked)
            {
                // If Repeat with Limit is selected, make the numeric up-down control visible
                RepeatCounter_numericUpDown.Visible = true;
            }
            else
            {
                // If Repeat with No Limit is selected, make the numeric up-down control invisible
                RepeatCounter_numericUpDown.Visible = false;
            }
        }
        private void PositionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CurrentPositon_radio.Checked)
            {
                // Handle the case when Current Position radio button is selected
                // Hide the X and Y position text boxes
                X_position_textBox.Visible = false;
                Y_Position_textBox.Visible = false;
                PickPosition_radio.Enabled = false;
            }
            else if (PickPosition_radio.Checked)
            {
                // Handle the case when Pick Position radio button is selected
                // Show the X and Y position text boxes
                X_position_textBox.Visible = true;
                Y_Position_textBox.Visible = true;
                CurrentPositon_radio.Enabled = false;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Get the graphics object for drawing
            Graphics graphics = e.Graphics;

            // Define the color and size of the red dot
            Brush redDotBrush = new SolidBrush(Color.Red);
            int dotSize = 10; // Adjust the size of the dot as desired

            // Current time to calculate the duration the red dots have been visible
            DateTime currentTime = DateTime.Now;

            // List to hold updated positions and timestamps
            List<(Point Position, DateTime Timestamp)> updatedClickPositions = new List<(Point Position, DateTime Timestamp)>();

            // Draw a red dot at each position in the clickPositions list
            foreach (var clickPosition in clickPositions)
            {
                // Calculate the duration the red dot has been visible
                TimeSpan duration = currentTime - clickPosition.Timestamp;

                // Check if the red dot should still be visible (less than 10 milliseconds)
                if (duration.TotalMilliseconds <= 10)
                {
                    // Draw the red dot at the position
                    graphics.FillEllipse(redDotBrush, clickPosition.Position.X - dotSize / 2, clickPosition.Position.Y - dotSize / 2, dotSize, dotSize);

                    // Add the position and timestamp back to the updated list
                    updatedClickPositions.Add(clickPosition);
                }
            }

            // Update the clickPositions list with the filtered list
            clickPositions = updatedClickPositions;
        }

        private void ResetButton_Click_1(object sender, EventArgs e)
        {
            // Reset NumericUpDown controls
            hours_numericUpDown.Value = 0;
            mins_numericUpDown.Value = 0;
            seconds_numericUpDown.Value = 0;
            millisecond_numeric.Value = 0;
            numericUpDown4.Value = 0; // Reset to default repeat limit

            // Reset ComboBox controls
            MouseButton_comboBox.SelectedIndex = 0; // Default to Left
            ClickType_comboBox.SelectedIndex = 0; // Default to Single

            // Reset RadioButton controls
            Repeat_with_limit_radio.Checked = false;
            Repeat_no_limit_Radio.Checked = true; // Default to Repeat with No Limit
            CurrentPositon_radio.Checked = true; // Default to Current Position
            PickPosition_radio.Checked = false;
            PickPosition_radio.Enabled = true;
            CurrentPositon_radio.Enabled = true;

            // Hide X and Y position text boxes if PickPosition_radio is not selected
            X_position_textBox.Visible = true;
            Y_Position_textBox.Visible = true;

            // Reset X and Y Position text boxes
            X_position_textBox.Text = "0";
            Y_Position_textBox.Text = "0";

            // Reset click counter
            clickCounter = 0;

            // Stop the auto-click timer
            autoClickTimer.Stop();

            // Enable StartButton and disable StopButton
            Start_button.Enabled = true;
            Stop_Button.Enabled = false;

            // Reset the Number_of_clicks_textBox
            Number_of_clicks_textBox.Text = clickCounter.ToString();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            // Show a prompt asking the user if they want to visit the website
            DialogResult result = MessageBox.Show("Would you like to visit the website for help?", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user selects "Yes", open the website in their default web browser
            if (result == DialogResult.Yes)
            {
                // Specify the URL of the website you want to open
                string websiteUrl = "https://github.com/MHussnain05/AutoClicker"; // Replace with your website URL

                // Open the URL in the default web browser
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = websiteUrl,
                    UseShellExecute = true
                });
            }
        }
        private void InitializeMouseEventHandlers()
        {
            this.MouseDown += Form_MouseDown;
            this.MouseMove += Form_MouseMove;
            this.MouseUp += Form_MouseUp;
        }
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentMousePosition = e.Location;
                Point delta = new Point(currentMousePosition.X - lastMousePosition.X, currentMousePosition.Y - lastMousePosition.Y);

                // Move the form
                this.Location = new Point(this.Location.X + delta.X, this.Location.Y + delta.Y);
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        
        

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void Exit_Picture_Click_1(object sender, EventArgs e)
        {
            // Display a confirmation dialog with Yes and No options
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, close the form and exit the application
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            // If the user clicks No, do nothing (the form stays open)
        }

        private void Minimize_picture_Click(object sender, EventArgs e)
        {
            // Minimize the form
            this.WindowState = FormWindowState.Minimized;
        }

        private void Help_Click_1(object sender, EventArgs e)
        {
            
                // Show a prompt asking the user if they want to visit the website
                DialogResult result = MessageBox.Show("Visit the website for help?", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user selects "Yes", open the website in their default web browser
                if (result == DialogResult.Yes)
                {
                    // Specify the URL of the website you want to open
                    string websiteUrl = "https://github.com/MHussnain05/AutoClicker"; // Replace with your website URL

                    // Open the URL in the default web browser
                    System.Diagnostics.Process.Start(new ProcessStartInfo
                    {
                        FileName = websiteUrl,
                        UseShellExecute = true
                    });
                
                }

        }
    }
}

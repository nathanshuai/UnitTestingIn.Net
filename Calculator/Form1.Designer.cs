namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox displayPanel;
        private Label binaryDisplay;
        private Label hexDisplay;



        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            displayPanel = new TextBox();
            binaryDisplay = new Label();
            hexDisplay = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            Binary = new Label();
            Hexadecimal = new Label();
            inputPanel = new TextBox();
            WarningLabelText = new Label();
            button17 = new Button();
            SuspendLayout();
            // 
            // displayPanel
            // 
            displayPanel.AccessibleDescription = "displayPanel";
            displayPanel.AccessibleName = "displayPanel";
            displayPanel.Location = new Point(328, 115);
            displayPanel.Name = "displayPanel";
            displayPanel.ReadOnly = true;
            displayPanel.Size = new Size(493, 31);
            displayPanel.TabIndex = 0;
            // 
            // binaryDisplay
            // 
            binaryDisplay.AccessibleDescription = "binaryDisplay";
            binaryDisplay.AccessibleName = "binaryDisplay";
            binaryDisplay.AutoSize = true;
            binaryDisplay.Location = new Point(328, 36);
            binaryDisplay.Name = "binaryDisplay";
            binaryDisplay.Size = new Size(0, 25);
            binaryDisplay.TabIndex = 1;
            // 
            // hexDisplay
            // 
            hexDisplay.AccessibleDescription = "hexDisplay";
            hexDisplay.AccessibleName = "hexDisplay";
            hexDisplay.AutoSize = true;
            hexDisplay.BackColor = Color.Transparent;
            hexDisplay.Location = new Point(682, 36);
            hexDisplay.Name = "hexDisplay";
            hexDisplay.Size = new Size(0, 25);
            hexDisplay.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(328, 331);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnNumberButtonClick;
            // 
            // button2
            // 
            button2.Location = new Point(513, 331);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnNumberButtonClick;
            // 
            // button3
            // 
            button3.Location = new Point(709, 331);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 5;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += OnNumberButtonClick;
            // 
            // button4
            // 
            button4.Location = new Point(328, 416);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += OnNumberButtonClick;
            // 
            // button5
            // 
            button5.Location = new Point(513, 416);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += OnNumberButtonClick;
            // 
            // button6
            // 
            button6.Location = new Point(709, 416);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += OnNumberButtonClick;
            // 
            // button7
            // 
            button7.Location = new Point(328, 495);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += OnNumberButtonClick;
            // 
            // button8
            // 
            button8.Location = new Point(513, 495);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += OnNumberButtonClick;
            // 
            // button9
            // 
            button9.Location = new Point(709, 495);
            button9.Name = "button9";
            button9.Size = new Size(112, 34);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += OnNumberButtonClick;
            // 
            // button10
            // 
            button10.Location = new Point(328, 581);
            button10.Name = "button10";
            button10.Size = new Size(112, 34);
            button10.TabIndex = 12;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = true;
            button10.Click += OperationButtonClick;
            // 
            // button11
            // 
            button11.Location = new Point(513, 581);
            button11.Name = "button11";
            button11.Size = new Size(112, 34);
            button11.TabIndex = 13;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = true;
            button11.Click += OperationButtonClick;
            // 
            // button12
            // 
            button12.Location = new Point(709, 581);
            button12.Name = "button12";
            button12.Size = new Size(112, 34);
            button12.TabIndex = 14;
            button12.Text = "*";
            button12.UseVisualStyleBackColor = true;
            button12.Click += OperationButtonClick;
            // 
            // button13
            // 
            button13.Location = new Point(328, 657);
            button13.Name = "button13";
            button13.Size = new Size(112, 34);
            button13.TabIndex = 15;
            button13.Text = "/";
            button13.UseVisualStyleBackColor = true;
            button13.Click += OperationButtonClick;
            // 
            // button14
            // 
            button14.Location = new Point(513, 657);
            button14.Name = "button14";
            button14.Size = new Size(112, 34);
            button14.TabIndex = 16;
            button14.Text = ".";
            button14.UseVisualStyleBackColor = true;
            button14.Click += DecimalButtonClick;
            // 
            // button15
            // 
            button15.Location = new Point(709, 657);
            button15.Name = "button15";
            button15.Size = new Size(112, 34);
            button15.TabIndex = 17;
            button15.Text = "=";
            button15.UseVisualStyleBackColor = true;
            button15.Click += OnEqualsButtonClick;
            // 
            // button16
            // 
            button16.Location = new Point(709, 255);
            button16.Name = "button16";
            button16.Size = new Size(112, 34);
            button16.TabIndex = 18;
            button16.Text = "Clear";
            button16.UseVisualStyleBackColor = true;
            button16.Click += OnClearButtonClick;
            button16.Enter += OnClearButtonClick;
            // 
            // Binary
            // 
            Binary.AutoSize = true;
            Binary.Location = new Point(381, 9);
            Binary.Name = "Binary";
            Binary.Size = new Size(60, 25);
            Binary.TabIndex = 19;
            Binary.Text = "Binary";
            // 
            // Hexadecimal
            // 
            Hexadecimal.AutoSize = true;
            Hexadecimal.Location = new Point(667, 9);
            Hexadecimal.Name = "Hexadecimal";
            Hexadecimal.Size = new Size(112, 25);
            Hexadecimal.TabIndex = 20;
            Hexadecimal.Text = "Hexadecimal";
            // 
            // inputPanel
            // 
            inputPanel.AccessibleDescription = "inputPanel";
            inputPanel.AccessibleName = "inputPanel";
            inputPanel.Location = new Point(328, 169);
            inputPanel.Name = "inputPanel";
            inputPanel.ReadOnly = true;
            inputPanel.Size = new Size(493, 31);
            inputPanel.TabIndex = 21;
            // 
            // WarningLabelText
            // 
            WarningLabelText.AccessibleDescription = "text";
            WarningLabelText.AccessibleName = "warning";
            WarningLabelText.AutoSize = true;
            WarningLabelText.ForeColor = Color.Brown;
            WarningLabelText.Location = new Point(342, 213);
            WarningLabelText.Name = "WarningLabelText";
            WarningLabelText.Size = new Size(0, 25);
            WarningLabelText.TabIndex = 22;
            // 
            // button17
            // 
            button17.Location = new Point(513, 255);
            button17.Name = "button17";
            button17.Size = new Size(112, 34);
            button17.TabIndex = 23;
            button17.Text = "0";
            button17.TextImageRelation = TextImageRelation.TextBeforeImage;
            button17.UseVisualStyleBackColor = true;
            button17.Click += OnNumberButtonClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 716);
            Controls.Add(button17);
            Controls.Add(WarningLabelText);
            Controls.Add(inputPanel);
            Controls.Add(Hexadecimal);
            Controls.Add(Binary);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(hexDisplay);
            Controls.Add(binaryDisplay);
            Controls.Add(displayPanel);
            Name = "Form1";
            RightToLeftLayout = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Label label1;
        private Label Binary;
        private Label Hexadecimal;
        private TextBox inputPanel;
        private Label WarningLabelText;
        private Button button17;
    }
}
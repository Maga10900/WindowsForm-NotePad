namespace WinForm_Task_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            Font_ComboBox = new ComboBox();
            Font_Label = new Label();
            Size_ComboBox = new ComboBox();
            Size_Label = new Label();
            FontStyle_Label = new Label();
            Button_Bold = new Button();
            Button_AltdaXett = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Aligment_Label = new Label();
            Color_Label = new Label();
            Color_ComboBox = new ComboBox();
            Load_TextBox = new TextBox();
            Open_TextBox = new TextBox();
            Button_Save = new Button();
            Button_Load = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = SystemColors.Menu;
            richTextBox1.Location = new Point(-1, 72);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1405, 639);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Font_ComboBox
            // 
            Font_ComboBox.BackColor = SystemColors.MenuBar;
            Font_ComboBox.FlatStyle = FlatStyle.System;
            Font_ComboBox.FormattingEnabled = true;
            Font_ComboBox.Location = new Point(12, 32);
            Font_ComboBox.Name = "Font_ComboBox";
            Font_ComboBox.Size = new Size(207, 28);
            Font_ComboBox.TabIndex = 1;
            Font_ComboBox.SelectedIndexChanged += Font_ComboBox_SelectedIndexChanged;
            // 
            // Font_Label
            // 
            Font_Label.AutoSize = true;
            Font_Label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Font_Label.Location = new Point(90, 4);
            Font_Label.Name = "Font_Label";
            Font_Label.Size = new Size(49, 25);
            Font_Label.TabIndex = 2;
            Font_Label.Text = "Font";
            // 
            // Size_ComboBox
            // 
            Size_ComboBox.BackColor = SystemColors.MenuBar;
            Size_ComboBox.DisplayMember = "11";
            Size_ComboBox.FlatStyle = FlatStyle.System;
            Size_ComboBox.FormattingEnabled = true;
            Size_ComboBox.Location = new Point(245, 32);
            Size_ComboBox.Name = "Size_ComboBox";
            Size_ComboBox.Size = new Size(83, 28);
            Size_ComboBox.Sorted = true;
            Size_ComboBox.TabIndex = 3;
            Size_ComboBox.SelectedIndexChanged += Size_ComboBox_SelectedIndexChanged;
            // 
            // Size_Label
            // 
            Size_Label.AutoSize = true;
            Size_Label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Size_Label.Location = new Point(262, 4);
            Size_Label.Name = "Size_Label";
            Size_Label.Size = new Size(46, 25);
            Size_Label.TabIndex = 4;
            Size_Label.Text = "Size";
            // 
            // FontStyle_Label
            // 
            FontStyle_Label.AutoSize = true;
            FontStyle_Label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FontStyle_Label.Location = new Point(380, 4);
            FontStyle_Label.Name = "FontStyle_Label";
            FontStyle_Label.Size = new Size(93, 25);
            FontStyle_Label.TabIndex = 5;
            FontStyle_Label.Text = "Font Style";
            // 
            // Button_Bold
            // 
            Button_Bold.BackColor = SystemColors.ControlLight;
            Button_Bold.Cursor = Cursors.Hand;
            Button_Bold.FlatAppearance.BorderSize = 0;
            Button_Bold.FlatStyle = FlatStyle.Flat;
            Button_Bold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Bold.Location = new Point(365, 32);
            Button_Bold.Name = "Button_Bold";
            Button_Bold.Size = new Size(31, 28);
            Button_Bold.TabIndex = 6;
            Button_Bold.Text = "B";
            Button_Bold.UseVisualStyleBackColor = false;
            Button_Bold.Click += Button_Bold_Click;
            // 
            // Button_AltdaXett
            // 
            Button_AltdaXett.BackColor = SystemColors.ControlLight;
            Button_AltdaXett.Cursor = Cursors.Hand;
            Button_AltdaXett.FlatAppearance.BorderSize = 0;
            Button_AltdaXett.FlatStyle = FlatStyle.Flat;
            Button_AltdaXett.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            Button_AltdaXett.Location = new Point(414, 32);
            Button_AltdaXett.Name = "Button_AltdaXett";
            Button_AltdaXett.Size = new Size(31, 28);
            Button_AltdaXett.TabIndex = 7;
            Button_AltdaXett.Text = "U";
            Button_AltdaXett.UseVisualStyleBackColor = false;
            Button_AltdaXett.Click += Button_AltdaXett_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(462, 32);
            button1.Name = "button1";
            button1.Size = new Size(31, 28);
            button1.TabIndex = 8;
            button1.Text = "/";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(644, 31);
            button2.Name = "button2";
            button2.Size = new Size(31, 28);
            button2.TabIndex = 12;
            button2.Text = "R";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(596, 31);
            button3.Name = "button3";
            button3.Size = new Size(31, 28);
            button3.TabIndex = 11;
            button3.Text = "C";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(547, 31);
            button4.Name = "button4";
            button4.Size = new Size(31, 28);
            button4.TabIndex = 10;
            button4.Text = "L";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Aligment_Label
            // 
            Aligment_Label.AutoSize = true;
            Aligment_Label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Aligment_Label.Location = new Point(562, 3);
            Aligment_Label.Name = "Aligment_Label";
            Aligment_Label.Size = new Size(88, 25);
            Aligment_Label.TabIndex = 9;
            Aligment_Label.Text = "Aligment";
            // 
            // Color_Label
            // 
            Color_Label.AutoSize = true;
            Color_Label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Color_Label.Location = new Point(775, 3);
            Color_Label.Name = "Color_Label";
            Color_Label.Size = new Size(58, 25);
            Color_Label.TabIndex = 13;
            Color_Label.Text = "Color";
            // 
            // Color_ComboBox
            // 
            Color_ComboBox.BackColor = SystemColors.MenuBar;
            Color_ComboBox.FormattingEnabled = true;
            Color_ComboBox.Location = new Point(731, 32);
            Color_ComboBox.Name = "Color_ComboBox";
            Color_ComboBox.Size = new Size(151, 28);
            Color_ComboBox.TabIndex = 14;
            Color_ComboBox.SelectedIndexChanged += Color_ComboBox_SelectedIndexChanged;
            // 
            // Load_TextBox
            // 
            Load_TextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Load_TextBox.Location = new Point(929, 2);
            Load_TextBox.Name = "Load_TextBox";
            Load_TextBox.PlaceholderText = "Enter name and load file";
            Load_TextBox.Size = new Size(325, 30);
            Load_TextBox.TabIndex = 15;
            Load_TextBox.Click += Load_TextBox_Click;
            Load_TextBox.TextChanged += Load_TextBox_TextChanged;
            // 
            // Open_TextBox
            // 
            Open_TextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Open_TextBox.Location = new Point(929, 38);
            Open_TextBox.Name = "Open_TextBox";
            Open_TextBox.PlaceholderText = "Tap to enter name and save";
            Open_TextBox.Size = new Size(325, 30);
            Open_TextBox.TabIndex = 16;
            Open_TextBox.Click += Open_TextBox_Click;
            Open_TextBox.TextChanged += Open_TextBox_TextChanged;
            // 
            // Button_Save
            // 
            Button_Save.BackColor = SystemColors.ControlLight;
            Button_Save.Cursor = Cursors.Hand;
            Button_Save.FlatAppearance.BorderSize = 0;
            Button_Save.FlatStyle = FlatStyle.Flat;
            Button_Save.Location = new Point(1298, 38);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new Size(94, 30);
            Button_Save.TabIndex = 17;
            Button_Save.Text = "Save";
            Button_Save.UseVisualStyleBackColor = false;
            Button_Save.Click += Button_Save_Click;
            // 
            // Button_Load
            // 
            Button_Load.BackColor = SystemColors.ControlLight;
            Button_Load.Cursor = Cursors.Hand;
            Button_Load.FlatAppearance.BorderSize = 0;
            Button_Load.FlatStyle = FlatStyle.Flat;
            Button_Load.Location = new Point(1298, 2);
            Button_Load.Name = "Button_Load";
            Button_Load.Size = new Size(94, 30);
            Button_Load.TabIndex = 18;
            Button_Load.Text = "Load";
            Button_Load.UseVisualStyleBackColor = false;
            Button_Load.Click += Button_Load_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 709);
            Controls.Add(Button_Load);
            Controls.Add(Button_Save);
            Controls.Add(Open_TextBox);
            Controls.Add(Load_TextBox);
            Controls.Add(Color_ComboBox);
            Controls.Add(Color_Label);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(Aligment_Label);
            Controls.Add(button1);
            Controls.Add(Button_AltdaXett);
            Controls.Add(Button_Bold);
            Controls.Add(FontStyle_Label);
            Controls.Add(Size_Label);
            Controls.Add(Size_ComboBox);
            Controls.Add(Font_Label);
            Controls.Add(Font_ComboBox);
            Controls.Add(richTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "NotePad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private ComboBox Font_ComboBox;
        private Label Font_Label;
        private ComboBox Size_ComboBox;
        private Label Size_Label;
        private Label FontStyle_Label;
        private Button Button_Bold;
        private Button Button_AltdaXett;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label Aligment_Label;
        private Label Color_Label;
        private ComboBox Color_ComboBox;
        private TextBox Load_TextBox;
        private TextBox Open_TextBox;
        private Button Button_Save;
        private Button Button_Load;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}

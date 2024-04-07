using System.Runtime.CompilerServices;

using static System.Net.Mime.MediaTypeNames;

namespace WinForm_Task_3
{
    public partial class Form1 : Form
    {
        bool isCekck = false;
        bool isCekck_A = false;
        bool isCekck_b = false;
        bool isCekck_Left = true;
        bool isCekck_Center = false;
        bool isCekck_Right = false;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text Files|*.txt";
            foreach (var item in FontFamily.Families)
            {
                Font_ComboBox.Items.Add(item.Name);

            }
            for (int i = 9; i <= 72; i++)
            {
                Size_ComboBox.Items.Add(i);
            }


            foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))

            {

                Color knownColor = Color.FromKnownColor(color);

                Color_ComboBox.Items.Add(knownColor);

            }
        }

        private void Font_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in FontFamily.Families)
            {
                if (item.Name == Font_ComboBox.SelectedItem.ToString())
                {
                    var text = richTextBox1.Text;
                    richTextBox1.Font = new Font(Font_ComboBox.SelectedItem.ToString(), richTextBox1.Font.Size, richTextBox1.Font.Style);

                    richTextBox1.Text = null;
                    richTextBox1.Text = text;
                }
            }
        }

        private void Size_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int newSize = int.Parse(Size_ComboBox.SelectedItem.ToString());
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, newSize);
        }

        private void Button_Bold_Click(object sender, EventArgs e)
        {
            if (isCekck)
            {
                Button_Bold.BackColor = SystemColors.ControlLight;//default
                isCekck = false;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            }
            else if (!isCekck)
            {
                Button_Bold.BackColor = SystemColors.GrayText;//aktiv

                isCekck = true;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            }
        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_AltdaXett_Click(object sender, EventArgs e)
        {
            if (isCekck_A)
            {
                Button_AltdaXett.BackColor = SystemColors.ControlLight;
                isCekck_A = false;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            }
            else
            {
                Button_AltdaXett.BackColor = SystemColors.GrayText;

                isCekck_A = true;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isCekck_b)
            {
                button1.BackColor = SystemColors.ControlLight;
                isCekck_b = false;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            }
            else
            {
                button1.BackColor = SystemColors.GrayText;
                isCekck_b = true;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isCekck_Left)
            {
                button4.BackColor = SystemColors.ControlLight;
                isCekck_Left = false;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                button4.BackColor = SystemColors.GrayText;
                isCekck_Left = true;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isCekck_Center)
            {
                button3.BackColor = SystemColors.ControlLight;
                isCekck_Center = false;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                button3.BackColor = SystemColors.GrayText;
                isCekck_Center = true;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isCekck_Right)
            {
                button2.BackColor = SystemColors.ControlLight;
                isCekck_Right = false;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                button2.BackColor = SystemColors.GrayText;
                isCekck_Right = true;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        private void Color_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            richTextBox1.ForeColor = (Color)Color_ComboBox.SelectedItem;
        }

        private void Load_TextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void Load_TextBox_Click(object sender, EventArgs e)
        {
            var secim = MessageBox.Show("File-i secmek isteyirsiniz?", "File Secim", MessageBoxButtons.YesNo);
            if (secim == DialogResult.Yes)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var fileName = openFileDialog1.FileName;
                    var text = File.ReadAllText(fileName);
                    richTextBox1.Text = text;
                }
            }
            else if (secim == DialogResult.No)
            {
                return;
            }
        }

        private void Button_Load_Click(object sender, EventArgs e)
        {
            if (Load_TextBox.Text.EndsWith(".txt"))
            {
                if (File.Exists(Load_TextBox.Text))
                {
                    var text = File.ReadAllText(Load_TextBox.Text);
                    richTextBox1.Text = text;
                }
            }
            else
            {
                MessageBox.Show("Exe-nin yaninda bu adda file yoxdur!");
            }

        }

        private void Open_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Open_TextBox_Click(object sender, EventArgs e)
        {
            var secim = MessageBox.Show("File-in yerini secmek isteyirsiniz?", "File secim", MessageBoxButtons.YesNo);
            if (secim == DialogResult.Yes)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.Create(openFileDialog1.FileName);
                    if (File.Exists(openFileDialog1.FileName))
                    {
                        var fileName = openFileDialog1.FileName;
                        File.WriteAllText(fileName, richTextBox1.Text);
                        MessageBox.Show("File-ye yazildi");
                    }
                }
            }
            else if (secim == DialogResult.No)
            {
                return;
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (File.Exists(Button_Save.Text))
            {
                File.WriteAllText(Open_TextBox.Text, richTextBox1.Text);
            }
            else
            {
                File.WriteAllText(Open_TextBox.Text, richTextBox1.Text);
            }

        }
    }

}

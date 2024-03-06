namespace DEsktop
{
    public partial class Form1 : Form
    {
        private List<int> tippek = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(800, 700);
            panel.BackColor = Color.Beige;
            panel.Size = new Size(500, 550);
            btnSorsol.Enabled = false;

            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 10; j++)
                {
                    CheckBox box = new CheckBox();
                    box.Text = (i * 10 + j + 1).ToString();
                    box.AutoSize = true;
                    box.Location = new Point(i * 50 + 40, j * 50 + 40);
                    box.CheckedChanged += checkBox1_CheckedChanged;
                    panel.Controls.Add(box);
                }

        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                tippek.Add(Convert.ToInt32(box.Text));
                if (tippek.Count == 5) Kapcsol(true);
            }
            else
            {
                tippek.Remove(Convert.ToInt32(box.Text));
                if (tippek.Count == 4) Kapcsol(false);
            }

        }

        private void Kapcsol(bool be)
        {
            btnSorsol.Enabled = be;
            foreach (CheckBox box in panel.Controls)
            {
                if (be)
                {
                    if (!box.Checked) box.Enabled = false;
                }
                else
                {
                    box.Enabled = true;
                }
            }
        }

        private void btnSorsol_Click(object sender, EventArgs e)
        {
            HashSet<int> sorsolas = new HashSet<int>();
            Random rnd = new Random();

            do {
                sorsolas.Add(rnd.Next(1, 91));
            }
            while (sorsolas.Count()!=5);

            label1.Text = "Kisorsolt számok" + String.Join(", ", sorsolas);
            label1.Text += "\nTippek" + String.Join(", ", tippek);
            label1.Text += "\nMetszet:" + String.Join(", ", tippek.Intersect(sorsolas));
        }
    }
}
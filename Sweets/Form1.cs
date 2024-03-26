using System.Windows.Forms;

namespace Sweets
{
    public partial class Form1 : Form
    {
        List<Sweet> sweetsList = new List<Sweet>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.sweetsList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.sweetsList.Add(Chocolate.Generate());
                        break;
                    case 1:
                        this.sweetsList.Add(Bakery.Generate());
                        break;
                    case 2:
                        this.sweetsList.Add(Fruit.Generate());
                        break;
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            int chocolatesCount = 0;
            int bakeriesCount = 0;
            int fruitsCount = 0;
            txtLine.Text = "";

            foreach (var sweet in this.sweetsList)
            {
                if (sweet is Chocolate)
                {
                    chocolatesCount += 1;
                    txtLine.Text += "Шоколад\n";
                }
                else if (sweet is Bakery)
                {
                    bakeriesCount += 1;
                    txtLine.Text += "Выпечка\n";
                }
                else if (sweet is Fruit)
                {
                    fruitsCount += 1;
                    txtLine.Text += "Фрукт\n";
                }
            }

            txtInfo.Text = "Шклд\tВпчка\tФрукт";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", chocolatesCount, bakeriesCount, fruitsCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.sweetsList.Count == 0)
            {
                txtOut.Text = "Пусто :(";
                return;
            }

            var sweet = this.sweetsList[0];
            this.sweetsList.RemoveAt(0);

            txtOut.Text = sweet.GetInfo();
            picture.Image = Image.FromFile(@sweet.GetImg());
            //picture.ImageLocation = sweet.GetImg();
            //picture.Image = new Bitmap(@sweet.GetImg());
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            ShowInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

namespace CartesianDistribution
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

        private void button1_Click(object sender, EventArgs e)
        {
            generatePoints();
        }
    
        private void generatePoints()
        {
            Form xDistr = new Form();
            xDistr.Width = 960;
            xDistr.Height = 540;
            xDistr.Text = "Distribution of X";

            Form yDistr = new Form();
            yDistr.Width = 960;
            yDistr.Height = 540;
            yDistr.Text = "Distribution of Y";

            Bitmap img = new Bitmap(xDistr.Width, xDistr.Height);
            xDistr.BackgroundImageLayout = ImageLayout.Center;
            xDistr.BackgroundImage = img;

            Bitmap img2 = new Bitmap(yDistr.Width, yDistr.Height);
            yDistr.BackgroundImageLayout = ImageLayout.Center;
            yDistr.BackgroundImage = img2;

            Graphics g = Graphics.FromImage(img);
            Graphics g2 = Graphics.FromImage(img2);

            Pen pen = new Pen(Color.Orange);

            Random rnd = new Random();
            SortedDictionary<double, int> xFreq = new SortedDictionary<double, int>();
            SortedDictionary<double, int> yFreq = new SortedDictionary<double, int>();

            for (int n = 1; n <= numPoints.Value; n++)
            {
                double u1 = rnd.NextDouble();
                double u2 = rnd.NextDouble();
                double radius = Math.Sqrt(-2 * Math.Log10(u1));
                double angle = 2 * Math.PI * u2;
                double x = Math.Abs(Math.Round(radius * Math.Cos(angle), 2));
                if (xFreq.ContainsKey(x))
                {
                    xFreq[x] += 1;
                } else
                {
                    xFreq[x] = 1;
                }

                double y = Math.Abs(Math.Round(radius * Math.Sin(angle), 2));
                if (yFreq.ContainsKey(y))
                {
                    yFreq[y] += 1;
                } else
                {
                    yFreq[y] = 1;
                }
            }
           
            List<Point> xPoints = new List<Point>();
            foreach (KeyValuePair<double, int> entry in xFreq)
            {
                int newX = convertX(entry.Key, xFreq.Keys.Min(), xFreq.Keys.Max(), xDistr.Width);
                int newY = convertY(entry.Value, xFreq.Values.Min(), xFreq.Values.Max(), xDistr.Height);
                xPoints.Add(new Point(newX, newY));
            }

            List<Point> yPoints = new List<Point>();
            foreach (KeyValuePair<double, int> entry in yFreq)
            {
                int newX = convertX(entry.Key, yFreq.Keys.Min(), yFreq.Keys.Max(), yDistr.Width);
                int newY = convertY(entry.Value, yFreq.Values.Min(), yFreq.Values.Max(), yDistr.Height);
                yPoints.Add(new Point(newX, newY));
            }

            g.DrawRectangle(pen, 0, 0, xDistr.Width - 1, xDistr.Height - 1);
            g.DrawLines(pen, xPoints.ToArray());

            g2.DrawRectangle(pen, 0, 0, yDistr.Width - 1, yDistr.Height - 1);
            g2.DrawLines(pen, yPoints.ToArray());

            xDistr.Show();
            yDistr.Show();
        }
        private int convertX(double x, double minX, double maxX, int w)
        {
            if (maxX - minX == 0)
            {
                return 0;
            }

            return (int)(w * (x - minX) / (maxX - minX));
        }

        private int convertY(double y, double minY, double maxY, int h)
        {
            if (maxY - minY == 0)
            {
                return 0;
            }

            return (int)(h - h * (y - minY) / (maxY - minY));
        }
    }
}

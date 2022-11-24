

namespace normalDistributions
{
    public partial class Form1 : Form
    {
        int n = 10000;
        int minX = -1073741376;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void draw(SortedDictionary<double, int> diz)
        {
            Bitmap img = new Bitmap(chart.Width, chart.Height);
            chart.Image = img;
            Graphics g = Graphics.FromImage(img);
            Pen pen = new Pen(Color.Orange);
            List<Point> points = new List<Point>();
            foreach (KeyValuePair<double, int> entry in diz)
            {
                int newX = convertX(entry.Key, diz.Keys.Min(), diz.Keys.Max(), chart.Width);
                int newY = convertY(entry.Value, diz.Values.Min(), diz.Values.Max(), chart.Height);
                if (newX < minX)
                {
                    newX = 0;
                }

                points.Add(new Point(newX, newY));
            }
            g.DrawLines(pen, points.ToArray());
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            SortedDictionary<double, int> diz = new SortedDictionary<double, int>();
            for (int i = 1; i <= n; i++)
            {
                double x = Math.Round(MathNet.Numerics.Distributions.Normal.Sample(0, 1), 2);
                if (diz.ContainsKey(x))
                {
                    diz[x] += 1;
                } else
                {
                    diz[x] = 1;
                }
            }
            draw(diz);
        }

        private void buttonXSq_Click(object sender, EventArgs e)
        {
            SortedDictionary<double, int> diz = new SortedDictionary<double, int>();
            for (int i = 1; i <= n; i++)
            {
                double xSq = Math.Pow(MathNet.Numerics.Distributions.Normal.Sample(0, 1), 2);
                double xF = Math.Round(xSq, 2);
                if (diz.ContainsKey(xF))
                {
                    diz[xF] += 1;
                }
                else
                {
                    diz[xF] = 1;
                }
            }
            draw(diz);
        }

        private void buttonXDivYSq_Click(object sender, EventArgs e)
        {
            SortedDictionary<double, int> diz = new SortedDictionary<double, int>();
            for (int i = 1; i <= n; i++)
            {
                double x = Math.Round(MathNet.Numerics.Distributions.Normal.Sample(0, 1), 2);
                double ySq = Math.Pow(MathNet.Numerics.Distributions.Normal.Sample(0, 1), 2);
                double yF = Math.Round(ySq, 2);
                double res = Math.Round(x / yF, 2);
                if (diz.ContainsKey(res))
                {
                    diz[res] += 1;
                }
                else
                {
                    diz[res] = 1;
                }
            }
            draw(diz);
        }

        private void buttonXSqDivYSq_Click(object sender, EventArgs e)
        {
            SortedDictionary<double, int> diz = new SortedDictionary<double, int>();
            for (int i = 1; i <= n; i++)
            {
                double xSq = Math.Pow(MathNet.Numerics.Distributions.Normal.Sample(0, 1), 2);
                double xF = Math.Round(xSq, 2);
                double ySq = Math.Pow(MathNet.Numerics.Distributions.Normal.Sample(0, 1), 2);
                double yF = Math.Round(ySq, 2);
                double res = Math.Round(xF / yF, 2);
                if (diz.ContainsKey(res))
                {
                    diz[res] += 1;
                }
                else
                {
                    diz[res] = 1;
                }
            }
            draw(diz);
        }

        private void XDivY_Click(object sender, EventArgs e)
        {
            SortedDictionary<double, int> diz = new SortedDictionary<double, int>();
            for (int i = 1; i <= n; i++)
            {
                double x = Math.Round(MathNet.Numerics.Distributions.Normal.Sample(0, 1), 2);
                double y = Math.Round(MathNet.Numerics.Distributions.Normal.Sample(0, 1), 2);
                double res = Math.Round(x / y, 2);
                if (diz.ContainsKey(res))
                {
                    diz[res] += 1;
                }
                else
                {
                    diz[res] = 1;
                }
            }
            draw(diz);
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

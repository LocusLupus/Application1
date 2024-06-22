using System.Xml.Linq;

namespace Polygon
{
    public partial class Form1 : Form
    {

        public Point[] TrianglePoints;
        public Point[] Recpoints;
        public Point[] IsecPoints;
        public Form1()
        {
            InitializeComponent();
            buttonTriangle.Click += Buttontriangle_Click;
            cleartri.Click += ClearTriangle_Click;
            ButtonRec.Click += ButtonRec_Click;
            recClear.Click += ClearRectangle_Click;
            buttonIsec.Click += ButtonIsec_Click;
            IsecClear.Click += ClearIsec_Click;


        }

        private void IsecClear_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ButtonRec_Click(object sender, EventArgs e)
        {
            Recpoints = new Point[4];
            int height = int.Parse(textRecHeight.Text);
            int lenght = int.Parse(textRecLenght.Text);
            Pen pen = new Pen(Color.BlueViolet, 3);
            Recpoints[0] = new Point(25, 60);
            Recpoints[1] = new Point(25 + lenght, 60);
            Recpoints[2] = new Point(25 + lenght, 60 + height);
            Recpoints[3] = new Point(25, 60 + height);

            pictureBox.CreateGraphics().DrawPolygon(pen, Recpoints.ToArray());
            double RecArea = CalculateAreaRec();
            RecAreaBox.Text = RecArea.ToString();
            RecInertiaBox.Text = (((Math.Pow(height, 3)) * lenght) / 12).ToString();

        }






        public void Buttontriangle_Click(object sender, EventArgs e)
        {
            TrianglePoints = new Point[3];

            int lenght;
            int height;
            height = int.Parse(triHeight.Text);
            lenght = int.Parse(trilenght.Text);
            Pen pen = new Pen(Color.Red, 3);
            TrianglePoints[0] = new Point(25, 60);
            TrianglePoints[1] = new Point(25 + lenght, 60);
            TrianglePoints[2] = new Point(25 + lenght / 2, 60 + height);

            pictureBox.CreateGraphics().DrawPolygon(pen, TrianglePoints.ToArray());
            double triarea = CalculateAreaPolgon();
            areaBox.Text = triarea.ToString();
            inertiaBox.Text = (((Math.Pow(height, 3)) * lenght) / 36).ToString();





        }
        public void ButtonIsec_Click(object sneder,EventArgs e)
        {
            IsecPoints = new Point[12];

            ////////
            int uplenght;
            int upheight;
            int lowlenght;
            int lowheight;
            int midheight;
            int midlenght;
            int a;
            int b;
            uplenght = int.Parse(uplenghtbox.Text);
            upheight = int.Parse(upheightbox.Text);
            lowlenght = int.Parse(lowlenghtbox.Text);
            lowheight = int.Parse(lowheightbox.Text);
            midheight = int.Parse(midheightbox.Text);
            midlenght = int.Parse(midlenghtbox.Text);
            a=(uplenght-midlenght)/ 2;
            b = (lowlenght - midlenght) / 2;
            Pen pen = new Pen(Color.ForestGreen, 3);
            IsecPoints[0] = new Point(50+uplenght, 60);
            IsecPoints[1] = new Point(50 +2*uplenght, 60);
            IsecPoints[2] = new Point(50+2*uplenght, 60 + upheight);
            IsecPoints[3] = new Point(50+2*uplenght-a,60+upheight);
            IsecPoints[4] = new Point(50 +2*uplenght-a,60+upheight+midheight);
            IsecPoints[5] = new Point(50+2*uplenght-a+b,60+upheight+midheight);
            IsecPoints[6] = new Point(50+2*uplenght-a+b,60+upheight+midheight+lowheight);
            IsecPoints[7] = new Point(50+2*uplenght-a+b-lowlenght,60+upheight+midheight+lowheight);
            IsecPoints[8] = new Point(50+2*uplenght-a+b-lowlenght,60+upheight+midheight);
            IsecPoints[9] = new Point(50+2*uplenght-a+2*b-lowlenght,60+upheight+midheight);
            IsecPoints[10] = new Point(50+2*uplenght-a+2*b-lowlenght,60+upheight);
            IsecPoints[11] = new Point(50+uplenght,60+upheight);
            
            
            pictureBox.CreateGraphics().DrawPolygon(pen, IsecPoints.ToArray());
            double Isecarea = CalculateIsec();
            areaIsecbox.Text = Isecarea.ToString();
            

        }
        public double CalculateAreaRec()
        {
            double area = 0;
            if (Recpoints != null && Recpoints.Length >= 3)
            {
                int numPoints = Recpoints.Length;

                for (int i = 0; i < numPoints - 1; i++)
                {
                    area += (Recpoints[i].X * Recpoints[i + 1].Y) - (Recpoints[i + 1].X * Recpoints[i].Y);
                }


                area += (Recpoints[numPoints - 1].X * Recpoints[0].Y) - (Recpoints[0].X * Recpoints[numPoints - 1].Y);


                area = Math.Abs(area) / 2.0;
            }
            return area;

        }
        public double CalculateIsec()
        {
            double area = 0;
            if (IsecPoints != null && IsecPoints.Length >= 3)
            {
                int numPoints = IsecPoints.Length;

                for (int i = 0; i < numPoints - 1; i++)
                {
                    area += (IsecPoints[i].X * IsecPoints[i + 1].Y) - (IsecPoints[i + 1].X * IsecPoints[i].Y);
                }


                area += (IsecPoints[numPoints - 1].X * IsecPoints[0].Y) - (IsecPoints[0].X * IsecPoints[numPoints - 1].Y);


                area = Math.Abs(area) / 2.0;
            }
            return area;



        }
        public double CalculateAreaPolgon()
        {
            double area = 0;
            if (TrianglePoints != null && TrianglePoints.Length >= 3)
            {
                int numPoints = TrianglePoints.Length;

                for (int i = 0; i < numPoints - 1; i++)
                {
                    area += (TrianglePoints[i].X * TrianglePoints[i + 1].Y) - (TrianglePoints[i + 1].X * TrianglePoints[i].Y);
                }


                area += (TrianglePoints[numPoints - 1].X * TrianglePoints[0].Y) - (TrianglePoints[0].X * TrianglePoints[numPoints - 1].Y);


                area = Math.Abs(area) / 2.0;
            }
            return area;
        }
        public void ClearTriangle_Click(object sender, EventArgs e)
        {

            triHeight.Clear();
            trilenght.Clear();
            areaBox.Clear();
            pictureBox.Refresh();
            inertiaBox.Clear();
        }
        public void ClearRectangle_Click(object sender, EventArgs e)
        {
            RecAreaBox.Clear();
            RecInertiaBox.Clear();
            pictureBox.Refresh();
            textRecHeight.Clear();
            textRecLenght.Clear();
        }
        public void ClearIsec_Click(object sender, EventArgs e)
        {
            areaIsecbox.Clear();
            inertiaIsecbox.Clear();
            pictureBox.Refresh();
            lowheightbox.Clear();
            lowlenghtbox.Clear();
            upheightbox.Clear();
            uplenghtbox.Clear();
            midheightbox.Clear();
            midlenghtbox.Clear();

        }


    }
}
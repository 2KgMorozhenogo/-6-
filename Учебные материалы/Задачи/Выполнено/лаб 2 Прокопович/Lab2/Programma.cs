using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab2
{
    public partial class Programma : Form
    {

        private Graphics graphics;
        private ShapeType selectedShape;    //переменная "selectedShape" хранит выбранный тип фигуры
        private bool isDrawing;             //Для нажатия мышки
        private List<Shape> shapes = new List<Shape>();     // для хранения инф. о фигурах, которые использовал пользователь
        //Dictionary<ShapeType, Size> initialSizes = new Dictionary<ShapeType, Size>(); // Для начального размера фигур

        


        public Programma()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
            selectedShape = ShapeType.None;
            isDrawing = false;      // Для мышки
            pictureBox1.Click += PictureBox_Click;
            pictureBox1.Paint += PictureBox_Paint;
            LoadShapesFromFile("shapes.txt"); // Загрузка рисунков из файла
            DrawAllShapes();
            this.Resize += Programma_Resize;


        }

        private void SaveShapesToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var shape in shapes)
                {
                    writer.WriteLine($"{shape.Type},{shape.Location.X},{shape.Location.Y}");
                }
            }
        }

        private void LoadShapesFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                shapes.Clear(); // Очищаем текущий список фигур перед загрузкой
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            ShapeType type;
                            if (Enum.TryParse(parts[0], out type))
                            {
                                int x = int.Parse(parts[1]);
                                int y = int.Parse(parts[2]);
                                shapes.Add(new Shape(type, new Point(x, y)));
                            }
                        }
                    }
                }
                // Перерисовываем pictureBox1 после загрузки фигур
                DrawAllShapes();
            }
        }



        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (isDrawing)
            {
                // Добавляем фигуру в список
                shapes.Add(new Shape(selectedShape, PointToClient(MousePosition)));
                // Очищаем область рисования
                ClearPictureBox();
                // Перерисовываем все фигуры на PictureBox
                DrawAllShapes();
                // Сохраняем изменения в файл
                SaveShapesToFile("shapes.txt");
            }
        }
       private void PictureBox_Paint(object sender, PaintEventArgs e)
{
    // При перерисовке PictureBox1 отрисовываем все фигуры из списка
    DrawAllShapes();
}
        private void ExitB_Click(object sender, EventArgs e)
        {
            this.Close();
            //MainMenu frm1 = new MainMenu();
            //frm1.Show();
        }



        public class Shape
        {
            public ShapeType Type { get; set; }
            public Point Location { get; set; }

            public Shape(ShapeType type, Point location)
            {
                Type = type;
                Location = location;
            }
        }


        private void DrawAllShapes()
        {
            // Очищаем область рисования перед отрисовкой фигур
            ClearPictureBox();

            foreach (var shape in shapes)
            {
                DrawShape(shape.Type, shape.Location);
            }
        }

        
        public enum ShapeType
        {
            None,
            Circle,
            Rectangle,
            Square,
            Ellipse,
            RightTriangle,
            IsoscelesTriangle,
            EquilateralTriangle,
            Rhombus,
            Trapezoid,
            Parallelogram,
            FilledCircle,
            Trapezoid1
            // Добавьте другие типы фигур
        }

        private void DrawShape(ShapeType shapeType, Point location)

        {
            //ClearPictureBox();
            switch (shapeType)
            {
                case ShapeType.Circle:
                    graphics.DrawEllipse(Pens.White, location.X - 50, location.Y - 50, 100, 100);
                    break;
                // Окружность
                case ShapeType.Rectangle:
                    graphics.DrawRectangle(Pens.White, location.X - 50, location.Y - 50, 200, 100);
                    // Прямоугольник
                    break;
                case ShapeType.Square:
                    graphics.DrawRectangle(Pens.White, location.X - 50, location.Y - 50, 100, 100);
                    // Квадрат
                    break;
                case ShapeType.Ellipse:
                    graphics.DrawEllipse(Pens.White, location.X - 50, location.Y - 30, 100, 60);
                    // Эллипс
                    break;
                case ShapeType.RightTriangle:
                    Point[] trianglePoints = { new Point(location.X - 50, location.Y + 50), new Point(location.X + 50, location.Y + 50), new Point(location.X - 50, location.Y - 50) };
                    graphics.DrawPolygon(Pens.White, trianglePoints);
                    // Прямоугольный треугольник
                    break;
                case ShapeType.IsoscelesTriangle:
                    Point[] isoscelesTrianglePoints = { new Point(location.X - 50, location.Y + 50), new Point(location.X + 50, location.Y + 50), new Point(location.X, location.Y - 50) };
                    graphics.DrawPolygon(Pens.White, isoscelesTrianglePoints);
                    // Равнобедренный треугольник
                    break;
                case ShapeType.EquilateralTriangle:
                    Point[] equilateralTrianglePoints = { new Point(location.X, location.Y - 50), new Point(location.X + 43, location.Y + 25), new Point(location.X - 43, location.Y + 25) };
                    graphics.DrawPolygon(Pens.White, equilateralTrianglePoints);
                    // Равносторонний треугольник
                    break;
                case ShapeType.Rhombus:
                    Point[] rhombusPoints = { new Point(location.X, location.Y - 50), new Point(location.X + 50, location.Y), new Point(location.X, location.Y + 50), new Point(location.X - 50, location.Y) };
                    graphics.DrawPolygon(Pens.White, rhombusPoints);
                    // Ромб
                    break;
                case ShapeType.Trapezoid:
                    Point[] invertedTrapezoidPoints = { new Point(location.X - 60, location.Y + 40), new Point(location.X + 60, location.Y + 40), new Point(location.X + 40, location.Y - 40), new Point(location.X - 40, location.Y - 40) };
                    graphics.DrawPolygon(Pens.White, invertedTrapezoidPoints);
                    // Трапеция 
                    break;
                case ShapeType.Parallelogram:
                    Point[] parallelogramPoints = { new Point(location.X - 40, location.Y + 40), new Point(location.X + 20, location.Y + 40), new Point(location.X + 40, location.Y - 40), new Point(location.X - 20, location.Y - 40) };
                    graphics.DrawPolygon(Pens.White, parallelogramPoints);
                    // Параллелограмм
                    break;
                case ShapeType.FilledCircle:
                    graphics.FillEllipse(Brushes.White, location.X - 50, location.Y - 50, 100, 100);
                    // круг


                    break;
                case ShapeType.Trapezoid1:
                    //трапеция 
                    Point[] invertedTrapezoid1Points = { new Point(location.X - 60, location.Y + 40), new Point(location.X + 60, location.Y + 40), new Point(location.X + 40, location.Y - 40), new Point(location.X - 40, location.Y - 40) };
                    graphics.DrawPolygon(Pens.White, invertedTrapezoid1Points);
                    //обводка трапеции
                    graphics.DrawLine(Pens.Red, location.X - 62, location.Y + 42, location.X + 62, location.Y + 42);
                    graphics.DrawLine(Pens.Red, location.X + 62, location.Y + 42, location.X + 42, location.Y - 42);
                    graphics.DrawLine(Pens.Red, location.X + 42, location.Y - 42, location.X - 42, location.Y - 42);
                    graphics.DrawLine(Pens.Red, location.X - 42, location.Y - 42, location.X - 62, location.Y + 42);

                    ;
                    break;
            }
        }
 private void Programma_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveShapesToFile("shapes.txt");
        }

        private void ClearPictureBox()
        {
            graphics.Clear(Color.Black);
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)

        {
            if (radioButton2.Checked)
            {
                selectedShape = ShapeType.Circle;
                isDrawing = true;
            }
            else
            {
                selectedShape = ShapeType.None;
                isDrawing = false;
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            {

                if (radioButton3.Checked)
                {
                    selectedShape = ShapeType.Ellipse;
                    isDrawing = true;
                }
                else
                {

                    selectedShape = ShapeType.None;
                    isDrawing = false;
                }
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (radioButton4.Checked)
                {
                    selectedShape = ShapeType.Rhombus;
                    isDrawing = true;
                }
                else
                {
                    selectedShape = ShapeType.None;
                    isDrawing = false;
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (radioButton5.Checked)
                {
                    selectedShape = ShapeType.IsoscelesTriangle;
                    isDrawing = true;
                }
                else
                {
                    selectedShape = ShapeType.None;
                    isDrawing = false;
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {


            if (radioButton6.Checked)
            {
                selectedShape = ShapeType.EquilateralTriangle;
                isDrawing = true;
            }
            else
            {
                selectedShape = ShapeType.None;
                isDrawing = false;
            }

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (radioButton7.Checked)
                {
                    selectedShape = ShapeType.RightTriangle;
                    isDrawing = true;
                }
                else
                {
                    selectedShape = ShapeType.None;
                    isDrawing = false;
                }
            }
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton8.Checked)
            {
                selectedShape = ShapeType.Rectangle;
                isDrawing = true;
            }
            else
            {
                selectedShape = ShapeType.None;
                isDrawing = false;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                selectedShape = ShapeType.Trapezoid;
                isDrawing = true;
            }
            else
            {
                selectedShape = ShapeType.None;
                isDrawing = false;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                selectedShape = ShapeType.Parallelogram;
                isDrawing = true;
            }
            else
            {
                selectedShape = ShapeType.None;
                isDrawing = false;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                selectedShape = ShapeType.FilledCircle;
                isDrawing = true;
            }
            else
            {
                selectedShape = ShapeType.None;
                isDrawing = false;
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                selectedShape = ShapeType.Square;
                isDrawing = true;
            }
            else
            {
                selectedShape = ShapeType.None;
                isDrawing = false;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                selectedShape = ShapeType.Trapezoid1;
                isDrawing = true;
            }
            else
            {
                selectedShape = ShapeType.None;
                isDrawing = false;
            }
        }
        /////

       
private void Programma_Resize(object sender, EventArgs e)
        {
            // Перерисовываем фигуры при изменении размеров формы
            DrawAllShapes();
        }
        private void ClearB_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            shapes.Clear();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (isDrawing == true)
            {
                shapes.Add(new Shape(selectedShape, e.Location));
                DrawAllShapes();
            }
        }

        bool models = false;




        private void Programma_Load(object sender, EventArgs e)
        {

        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

       
        public bool checkMain = false;



        private void button1_Click(object sender, EventArgs e)
        {
            Help frm3 = new Help();
            if (checkMain == false)
            {
                checkMain = true;
                frm3.Show();
                //frm3.ShowDialog();
            }
            else if (checkMain == true)
            {
                checkMain = false;
                frm3.Hide();
            }



        }

       
    }
}

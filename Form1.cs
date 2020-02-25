using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Shapes;
using ShapeListMaintenance;
using Newtonsoft.Json;
//using System.Text.Json;
using System.IO;


namespace Lab1
{
    public partial class MainForm : Form
    {
        // Список фигур
        private ShapeList shapeList;
        // Список с описанием фигур для cmbShapeSwitch
        public List<ShapeDescription> shapeDescriptions;
        // Перо(обводка фигур)
        private Pen globalPen;
        // Кисть(заливка фигур)
        private SolidBrush globalBrush;
        // Поверхность для рисования
        private Graphics graphics;
        // Битмап для рисования
        private Bitmap canvas;
        // Координаты мыши:
        // Point(x1,y1) - в момент нажатия на ЛКМ
        // Point(x2,y2) - в момент отпускания ЛКМ
        private int x1, x2, y1, y2;
        private AbstractShape tmpAbstractShape;

        // Метод для очистки холста
        public void ClearCanvas()
        {
            // Создаем битмап с размерами picCanvas
            canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            // Освобождаем ресурсы
            picCanvas.Image.Dispose();
            // Сохраняем в picCanvas пустой битмап
            picCanvas.Image = (Image)canvas.Clone();
            // Освобождаем память
            canvas.Dispose();
        }

        // Метод подготовки холста
        public void PrepareCanvas()
        {
            // Создаем битмап с размерами picCanvas
            canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            new System.Drawing.Rectangle(0, 0, picCanvas.Width, picCanvas.Height);
            // Переносим содержимое picCanvas на битмап
            picCanvas.DrawToBitmap(canvas, new System.Drawing.Rectangle(0, 0, picCanvas.Width, picCanvas.Height));
            // Создаем область для отрисовки
            graphics = Graphics.FromImage(canvas);
        }

        // Метод завершения работы с холстом
        public void SaveCanvas()
        {
            // Освобождаем ресурсы
            picCanvas.Image.Dispose();
            // Переносим на picCanvas битмап
            picCanvas.Image = (Image)canvas.Clone();

            // Освобождаем память
            graphics.Dispose();
            canvas.Dispose();
        }

        // Событие "ЛКМ нажата"
        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            // Сохраняем начальные координаты курсора относительно фигуры
            x1 = e.X;
            y1 = e.Y;
        }

        // Событие "ЛКМ отпущена"
        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            // Сохраняем конечные координаты курсора относительно фигуры
            x2 = e.X;
            y2 = e.Y;

            // Подготовка холста
            PrepareCanvas();
            // Получаем нужный метод из ComboBox'a
            Func<AbstractShape> func = (Func<AbstractShape>)cmbShapeSwitch.SelectedValue;
            // Создаем новую фигуру
            tmpAbstractShape = func();
            // Инициализация всех полей фигуры
            tmpAbstractShape.Init(globalPen.Color,globalBrush.Color, x1, y1, x2, y2);
            // Отрисовка фигуры
            tmpAbstractShape.Draw(graphics);
            // Добавление фигуры в список
            shapeList.AddToList(tmpAbstractShape);
            // Сохранение холста
            SaveCanvas();
        }

        // Событие "Нажатие на кнопку выбора цвета линии"
        private void btnLineColor_Click(object sender, EventArgs e)
        {
            // Открываем диалоговое окно с выбором цвета
            colorDialog.ShowDialog();
            // Присваиваем выбранный цвет перу
            globalPen.Color = colorDialog.Color;
        }

        // Событие "Нажатие на кнопку очистки холста"
        private void btnClearCanvas_Click(object sender, EventArgs e)
        {
            // Очищаем форму
            ClearCanvas();
        }

        // Событие "Нажатие на кнопку очистки списка фигур"
        private void btnClearShapeList_Click(object sender, EventArgs e)
        {
            // Очищаем список фигур
            shapeList.Clear();
            // Очищаем форму
            ClearCanvas();
        }

        // Событие "Нажатие на кнопку отрисовки списка фигур"
        private void btnDrawShapeList_Click(object sender, EventArgs e)
        {
            // Подготовка холста
            PrepareCanvas();
            // Отрисовка списка фигур
            shapeList.Draw(graphics);
            // Сохранение холста
            SaveCanvas();
        }

        private void btnLoadShapes_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            String filename = openFileDialog.FileName;
            string jsonstring = File.ReadAllText(filename);
            try
            {
                var shapeList2 = JsonConvert.DeserializeObject<ShapeList>(jsonstring);
                PrepareCanvas();
                shapeList.Draw(graphics);
                SaveCanvas();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Файл поврежден, чтение невозможно \n"+"Расшифровка ошибки: "+exception.Message, "Ошибка чтения файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveShapes_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            String filename = saveFileDialog.FileName;
            String jsonstring = JsonConvert.SerializeObject(shapeList);
            File.WriteAllText(filename, jsonstring);
            MessageBox.Show(jsonstring);
        }

        // Событие "Нажатие на кнопку выбора цвета заливки"
        private void btnFillColor_Click(object sender, EventArgs e)
        {
            // Открываем диалоговое окно с выбором цвета
            colorDialog.ShowDialog();
            // Присваиваем выбранный цвет кисти
            globalBrush.Color = colorDialog.Color;
        }

        public MainForm()
        {
            InitializeComponent();
            // Настройка cmbShapeSwitch
            shapeDescriptions = new List<ShapeDescription>()
            {
                new ShapeDescription { Name = "Линия", Create = ShapeFactory.LineCreate },
                new ShapeDescription { Name = "Прямоугольник", Create = ShapeFactory.RectangleCreate },
                new ShapeDescription { Name = "Квадрат", Create = ShapeFactory.SquareCreate },
                new ShapeDescription { Name = "Треугольник", Create = ShapeFactory.TriangleCreate},
                new ShapeDescription { Name = "Элипс", Create = ShapeFactory.EllipseCreate },
                new ShapeDescription { Name = "Круг", Create = ShapeFactory.CircleCreate }
            };
            cmbShapeSwitch.DataSource = shapeDescriptions;
            cmbShapeSwitch.DisplayMember = "Name";
            cmbShapeSwitch.ValueMember = "Create";

            // Инициализация пера и кисти
            globalPen = new Pen(Color.Black);
            globalBrush = new SolidBrush(Color.Black);
            // Созданием экземпляра списка фигур
            shapeList = new ShapeList();

            // Создаем битмап с размерами picCanvas
            canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            // Переносим на picCanvas битмап
            picCanvas.Image = (Image)canvas.Clone();
            // Освобождаем память
            canvas.Dispose();


        }
    }
}

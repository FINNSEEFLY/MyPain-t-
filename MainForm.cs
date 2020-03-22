using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Shapes;
using ShapeListMaintenance;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;


namespace Lab1
{
    public partial class MainForm : Form
    {
        private ShapeList shapeList;
        public List<AbstractShapeFactory> shapeFactories;
        public List<ShapeFactoryDescription> factoryList;
        private Graphics mainGraphics, tmpGraphics;
        private Bitmap mainCanvas, tmpCanvas;
        private AbstractShape tmpAbstractShape;
        private Point[] tmpPointArray;
        private int dotCounter;

        // Метод для очистки холста
        public void ClearMainCanvas()
        {
            mainCanvas.Dispose();
            mainCanvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image.Dispose();
            picCanvas.Image = (Image)mainCanvas.Clone();
        }

        // Метод подготовки холста
        public void PrepareGraphicsToDrawing()
        {
            // Создаем область для отрисовки
            mainGraphics = Graphics.FromImage(mainCanvas);
        }

        // Метод завершения работы с холстом
        public void SaveMainCanvas()
        {
            picCanvas.Image.Dispose();
            picCanvas.Image = (Image)mainCanvas.Clone();
            mainGraphics.Dispose();
        }

        // Метод сохранения фигуры
        public void SaveShape()
        {
            PrepareGraphicsToDrawing();
            tmpAbstractShape.Draw(mainGraphics);
            shapeList.AddToList(tmpAbstractShape);
            SaveMainCanvas();
        }

        public MainForm()
        {
            // Поиск поиск и создание списка всех наследников типа AbstractShapeFactory
            Type baseShapeFactory = typeof(AbstractShapeFactory);
            IEnumerable<Type> ShapeFactoryList = Assembly.GetAssembly(baseShapeFactory).GetTypes().Where(type => type.IsSubclassOf(baseShapeFactory));
            
            shapeFactories = new List<AbstractShapeFactory>();
            factoryList = new List<ShapeFactoryDescription>();
            foreach (Type listitem in ShapeFactoryList)
            {
                var factory = (AbstractShapeFactory)listitem.GetConstructors()[0].Invoke(new object[0]);
                shapeFactories.Add(factory);
                factoryList.Add(new ShapeFactoryDescription { Name = factory.ShapeName, Create = factory.Create });
            }

            InitializeComponent();

            // Настройка cmbShapeSwitch
            cmbShapeSwitch.DataSource = factoryList;
            cmbShapeSwitch.DisplayMember = "Name";
            cmbShapeSwitch.ValueMember = "Create";

            // Созданием экземпляра списка фигур
            shapeList = new ShapeList();

            mainCanvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = (Image)mainCanvas.Clone();

            // Создаем новую фигуру
            Func<Color, Color, AbstractShape> someFactory = (Func<Color, Color, AbstractShape>)cmbShapeSwitch.SelectedValue;
            tmpAbstractShape = someFactory(Color.Black, Color.Black);

            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown_First_Point);
            cmbShapeSwitch.SelectedValueChanged += new System.EventHandler(cmbShapeSwitch_SelectedValueChanged);
            lblInfo.Text = "Нажмите ЛКМ по холсту для начала рисования";
        }
        // Событие "Изменение размеров основной формы"
        private void MainForm_Resize(object sender, EventArgs e)
        {
            PrepareGraphicsToDrawing();
            shapeList.Draw(mainGraphics);
            SaveMainCanvas();
            mainCanvas.Dispose();
            mainCanvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.DrawToBitmap(mainCanvas, new System.Drawing.Rectangle(0, 0, picCanvas.Width, picCanvas.Height));
        }

        // Событие "Изменение значения индекса Combobox"
        private void cmbShapeSwitch_SelectedValueChanged(object sender, EventArgs e)
        {
            // Создаем новую фигуру
            Func<Color, Color, AbstractShape> func = (Func<Color, Color, AbstractShape>)cmbShapeSwitch.SelectedValue;
            tmpAbstractShape = func(tmpAbstractShape.penColor, tmpAbstractShape.brushColor);
        }

        // Событие "ЛКМ нажата первый раз"
        private void pnlCanvas_MouseDown_First_Point(object sender, MouseEventArgs e)
        {
            this.picCanvas.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown_First_Point);
            cmbShapeSwitch.Enabled = false;
            dotCounter = 1;
            if (tmpAbstractShape.maxNumberOfDots == 0)
            {
                this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown_Infinity_Point);
                this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove_Infinity_Point);
                this.picCanvas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDoubleClick);
                tmpPointArray = new Point[2];
                tmpPointArray[0] = e.Location;
                lblInfo.Text = "Чтобы перестать рисовать, сделайте двойной щелчок ЛКМ";
            }
            else
            {
                this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown_Limited_Point);
                this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove_Limited_Point);
                tmpPointArray = new Point[tmpAbstractShape.maxNumberOfDots];
                for (int i = 0; i < tmpAbstractShape.maxNumberOfDots; i++)
                {
                    tmpPointArray[i] = e.Location;
                }
                lblInfo.Text = "Кол-во точек до конца рисования: [ " + (tmpPointArray.Length - dotCounter).ToString() + " ] ";
            }
        }

        // Событие "ЛКМ нажата при рисовании фигуры с известным числом точек"
        private void pnlCanvas_MouseDown_Limited_Point(object sender, MouseEventArgs e)
        {
            tmpPointArray[dotCounter] = e.Location;
            dotCounter++;
            lblInfo.Text = "Кол-во точек до конца рисования: [ " + (tmpPointArray.Length - dotCounter).ToString() + " ] ";
            if (dotCounter == tmpAbstractShape.maxNumberOfDots)
            {
                tmpAbstractShape.Init(tmpPointArray);
                SaveShape();
                Array.Resize(ref tmpPointArray, 0);
                this.picCanvas.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove_Limited_Point);
                this.picCanvas.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown_Limited_Point);
                this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown_First_Point);
                cmbShapeSwitch.Enabled = true;
                lblInfo.Text = "Нажмите ЛКМ по холсту для начала рисования";
            }
        }

        // Событие "ЛКМ нажата при рисовании фигуры с неизвестным числом точек"
        private void pnlCanvas_MouseDown_Infinity_Point(object sender, MouseEventArgs e)
        {
            Array.Resize(ref tmpPointArray, tmpPointArray.Length + 1);
            tmpPointArray[tmpPointArray.Length - 1] = e.Location;
            dotCounter++;
        }

        // Событие "Курсор передвигается при рисовании фигурыс известным числом точек"
        private void picCanvas_MouseMove_Limited_Point(object sender, MouseEventArgs e)
        {
            tmpCanvas = (Bitmap)mainCanvas.Clone();
            tmpGraphics = Graphics.FromImage(tmpCanvas);
            tmpPointArray[dotCounter] = e.Location;
            tmpAbstractShape.Init(tmpPointArray);
            tmpAbstractShape.Draw(tmpGraphics);
            picCanvas.Image.Dispose();
            picCanvas.Image = (Image)tmpCanvas.Clone();
            tmpGraphics.Dispose();
            tmpCanvas.Dispose();
        }

        // Событие "Курсор передвигается при рисовании фигуры с неизвестным числом точек"
        private void picCanvas_MouseMove_Infinity_Point(object sender, MouseEventArgs e)
        {
            tmpCanvas = (Bitmap)mainCanvas.Clone();
            tmpGraphics = Graphics.FromImage(tmpCanvas);
            tmpPointArray[tmpPointArray.Length - 1] = e.Location;
            tmpAbstractShape.Init(tmpPointArray);
            tmpAbstractShape.Draw(tmpGraphics);
            picCanvas.Image.Dispose();
            picCanvas.Image = (Image)tmpCanvas.Clone();
            tmpGraphics.Dispose();
            tmpCanvas.Dispose();
        }
        private void picCanvas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tmpPointArray[tmpPointArray.Length - 1] = e.Location;
            tmpAbstractShape.Init(tmpPointArray);
            SaveShape();
            Array.Resize(ref tmpPointArray, 0);
            this.picCanvas.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove_Infinity_Point);
            this.picCanvas.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown_Infinity_Point);
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown_First_Point);
            cmbShapeSwitch.Enabled = true;
            this.picCanvas.MouseDoubleClick -= new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDoubleClick);
            lblInfo.Text = "Нажмите ЛКМ по холсту для начала рисования";
        }

        // Событие "Нажатие на кнопку выбора цвета линии"
        private void btnLineColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            tmpAbstractShape.penColor = colorDialog.Color;
        }

        // Событие "Нажатие на кнопку выбора цвета заливки"
        private void btnFillColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            tmpAbstractShape.brushColor = colorDialog.Color;
        }

        // Событие "Нажатие на кнопку очистки фигур"
        private void btnClearShapeList_Click(object sender, EventArgs e)
        {
            shapeList.Clear();
            ClearMainCanvas();
        }

        // Событие "Нажатие на кнопку отрисовки списка фигур"
        private void btnDrawShapeList_Click(object sender, EventArgs e)
        {
            PrepareGraphicsToDrawing();
            shapeList.Draw(mainGraphics);
            SaveMainCanvas();
        }

        // Событие "Нажатие на кнопку сохранить фигуры"
        private void btnSaveShapes_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var formatter = new BinaryFormatter();
            using (var fileStream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, shapeList);
            }
        }

        // Событие "Нажатие на кнопку загрузить фигуры"
        private void btnLoadShapes_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var formatter = new BinaryFormatter();
            using (var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
            {
                try
                {
                    shapeList.Clear();
                    ClearMainCanvas();
                    shapeList = (ShapeList)formatter.Deserialize(fileStream);
                    PrepareGraphicsToDrawing();
                    shapeList.Draw(mainGraphics);
                    SaveMainCanvas();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Файл поврежден, чтение невозможно \n" + "Расшифровка ошибки: \n" + exception.Message, "Ошибка чтения файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

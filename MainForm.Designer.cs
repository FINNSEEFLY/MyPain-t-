namespace Lab1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlToolBar = new System.Windows.Forms.Panel();
            this.btnLoadShapes = new System.Windows.Forms.Button();
            this.btnSaveShapes = new System.Windows.Forms.Button();
            this.btnDrawShapeList = new System.Windows.Forms.Button();
            this.btnClearShapeList = new System.Windows.Forms.Button();
            this.pnlShapes = new System.Windows.Forms.Panel();
            this.cmbShapeSwitch = new System.Windows.Forms.ComboBox();
            this.lblShapeSwitch = new System.Windows.Forms.Label();
            this.pnlColorBar = new System.Windows.Forms.Panel();
            this.btnLineColor = new System.Windows.Forms.Button();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlToolBar.SuspendLayout();
            this.pnlShapes.SuspendLayout();
            this.pnlColorBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlToolBar.Controls.Add(this.btnLoadShapes);
            this.pnlToolBar.Controls.Add(this.btnSaveShapes);
            this.pnlToolBar.Controls.Add(this.btnDrawShapeList);
            this.pnlToolBar.Controls.Add(this.btnClearShapeList);
            this.pnlToolBar.Controls.Add(this.pnlShapes);
            this.pnlToolBar.Controls.Add(this.pnlColorBar);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Margin = new System.Windows.Forms.Padding(10);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(884, 70);
            this.pnlToolBar.TabIndex = 0;
            // 
            // btnLoadShapes
            // 
            this.btnLoadShapes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoadShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadShapes.Location = new System.Drawing.Point(631, 0);
            this.btnLoadShapes.Name = "btnLoadShapes";
            this.btnLoadShapes.Size = new System.Drawing.Size(78, 70);
            this.btnLoadShapes.TabIndex = 7;
            this.btnLoadShapes.Text = "Загрузить фигуры из файла";
            this.btnLoadShapes.UseVisualStyleBackColor = true;
            this.btnLoadShapes.Click += new System.EventHandler(this.btnLoadShapes_Click);
            // 
            // btnSaveShapes
            // 
            this.btnSaveShapes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSaveShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveShapes.Location = new System.Drawing.Point(553, 0);
            this.btnSaveShapes.Name = "btnSaveShapes";
            this.btnSaveShapes.Size = new System.Drawing.Size(78, 70);
            this.btnSaveShapes.TabIndex = 6;
            this.btnSaveShapes.Text = "Сохранить фигуры в файл";
            this.btnSaveShapes.UseVisualStyleBackColor = true;
            this.btnSaveShapes.Click += new System.EventHandler(this.btnSaveShapes_Click);
            // 
            // btnDrawShapeList
            // 
            this.btnDrawShapeList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDrawShapeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDrawShapeList.Location = new System.Drawing.Point(466, 0);
            this.btnDrawShapeList.Name = "btnDrawShapeList";
            this.btnDrawShapeList.Size = new System.Drawing.Size(87, 70);
            this.btnDrawShapeList.TabIndex = 5;
            this.btnDrawShapeList.Text = "Нарисовать список фигур";
            this.btnDrawShapeList.UseVisualStyleBackColor = true;
            this.btnDrawShapeList.Click += new System.EventHandler(this.btnDrawShapeList_Click);
            // 
            // btnClearShapeList
            // 
            this.btnClearShapeList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClearShapeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearShapeList.Location = new System.Drawing.Point(394, 0);
            this.btnClearShapeList.Name = "btnClearShapeList";
            this.btnClearShapeList.Size = new System.Drawing.Size(72, 70);
            this.btnClearShapeList.TabIndex = 4;
            this.btnClearShapeList.Text = "Очистить фигуры";
            this.btnClearShapeList.UseVisualStyleBackColor = true;
            this.btnClearShapeList.Click += new System.EventHandler(this.btnClearShapeList_Click);
            // 
            // pnlShapes
            // 
            this.pnlShapes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlShapes.Controls.Add(this.cmbShapeSwitch);
            this.pnlShapes.Controls.Add(this.lblShapeSwitch);
            this.pnlShapes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlShapes.Location = new System.Drawing.Point(117, 0);
            this.pnlShapes.Name = "pnlShapes";
            this.pnlShapes.Size = new System.Drawing.Size(277, 70);
            this.pnlShapes.TabIndex = 1;
            // 
            // cmbShapeSwitch
            // 
            this.cmbShapeSwitch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbShapeSwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShapeSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbShapeSwitch.FormattingEnabled = true;
            this.cmbShapeSwitch.Location = new System.Drawing.Point(0, 42);
            this.cmbShapeSwitch.Name = "cmbShapeSwitch";
            this.cmbShapeSwitch.Size = new System.Drawing.Size(275, 26);
            this.cmbShapeSwitch.TabIndex = 2;
            // 
            // lblShapeSwitch
            // 
            this.lblShapeSwitch.AutoSize = true;
            this.lblShapeSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShapeSwitch.Location = new System.Drawing.Point(63, 8);
            this.lblShapeSwitch.Name = "lblShapeSwitch";
            this.lblShapeSwitch.Size = new System.Drawing.Size(148, 25);
            this.lblShapeSwitch.TabIndex = 1;
            this.lblShapeSwitch.Text = "Выбор фигуры";
            // 
            // pnlColorBar
            // 
            this.pnlColorBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorBar.Controls.Add(this.btnLineColor);
            this.pnlColorBar.Controls.Add(this.btnFillColor);
            this.pnlColorBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColorBar.Location = new System.Drawing.Point(0, 0);
            this.pnlColorBar.Name = "pnlColorBar";
            this.pnlColorBar.Size = new System.Drawing.Size(117, 70);
            this.pnlColorBar.TabIndex = 0;
            // 
            // btnLineColor
            // 
            this.btnLineColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLineColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLineColor.Location = new System.Drawing.Point(0, 35);
            this.btnLineColor.Name = "btnLineColor";
            this.btnLineColor.Size = new System.Drawing.Size(115, 35);
            this.btnLineColor.TabIndex = 1;
            this.btnLineColor.Text = "Цвет линии";
            this.btnLineColor.UseVisualStyleBackColor = true;
            this.btnLineColor.Click += new System.EventHandler(this.btnLineColor_Click);
            // 
            // btnFillColor
            // 
            this.btnFillColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFillColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFillColor.Location = new System.Drawing.Point(0, 0);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(115, 35);
            this.btnFillColor.TabIndex = 0;
            this.btnFillColor.Text = "Цвет заливки";
            this.btnFillColor.UseVisualStyleBackColor = true;
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCanvas.InitialImage = null;
            this.picCanvas.Location = new System.Drawing.Point(0, 70);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(884, 391);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "shp";
            this.saveFileDialog.Title = "Сохранение списка фигур";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "shp";
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Title = "Загрузка списка фигур";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInfo.Location = new System.Drawing.Point(0, 448);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "lblInfo";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.pnlToolBar);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MainForm";
            this.Text = "MyPain-t-";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.pnlToolBar.ResumeLayout(false);
            this.pnlShapes.ResumeLayout(false);
            this.pnlShapes.PerformLayout();
            this.pnlColorBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolBar;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel pnlColorBar;
        private System.Windows.Forms.Panel pnlShapes;
        private System.Windows.Forms.Button btnLineColor;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Label lblShapeSwitch;
        private System.Windows.Forms.ComboBox cmbShapeSwitch;
        private System.Windows.Forms.Button btnClearShapeList;
        private System.Windows.Forms.Button btnDrawShapeList;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnSaveShapes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnLoadShapes;
        private System.Windows.Forms.Label lblInfo;
    }
}


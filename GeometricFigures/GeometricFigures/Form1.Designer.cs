
namespace GeometricFigures
{
    partial class Calculator
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.Title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Polygon = new System.Windows.Forms.RadioButton();
            this.Trapeze = new System.Windows.Forms.RadioButton();
            this.Rhomboid = new System.Windows.Forms.RadioButton();
            this.Diamond = new System.Windows.Forms.RadioButton();
            this.Triangle = new System.Windows.Forms.RadioButton();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.Square = new System.Windows.Forms.RadioButton();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.Calculadora = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.tbxPerimetro = new System.Windows.Forms.TextBox();
            this.labelAREA = new System.Windows.Forms.Label();
            this.labelPERIMETER = new System.Windows.Forms.Label();
            this.Label_Dato1 = new System.Windows.Forms.Label();
            this.label_Dato2 = new System.Windows.Forms.Label();
            this.textBox_Dato1 = new System.Windows.Forms.TextBox();
            this.textBox_Dato2 = new System.Windows.Forms.TextBox();
            this.label_Dato3 = new System.Windows.Forms.Label();
            this.textBox_Dato3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(201, 39);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(381, 26);
            this.Title.TabIndex = 0;
            this.Title.Text = "Basic Geometric Figures Calculator";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.Polygon);
            this.groupBox1.Controls.Add(this.Trapeze);
            this.groupBox1.Controls.Add(this.Rhomboid);
            this.groupBox1.Controls.Add(this.Diamond);
            this.groupBox1.Controls.Add(this.Triangle);
            this.groupBox1.Controls.Add(this.Rectangle);
            this.groupBox1.Controls.Add(this.Square);
            this.groupBox1.Controls.Add(this.Circle);
            this.groupBox1.Location = new System.Drawing.Point(53, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 219);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figure";
            // 
            // Polygon
            // 
            this.Polygon.AutoSize = true;
            this.Polygon.Location = new System.Drawing.Point(32, 180);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(63, 17);
            this.Polygon.TabIndex = 2;
            this.Polygon.TabStop = true;
            this.Polygon.Text = "Polygon";
            this.Polygon.UseVisualStyleBackColor = true;
            this.Polygon.CheckedChanged += new System.EventHandler(this.Polygon_CheckedChanged);
            // 
            // Trapeze
            // 
            this.Trapeze.AutoSize = true;
            this.Trapeze.Location = new System.Drawing.Point(32, 134);
            this.Trapeze.Name = "Trapeze";
            this.Trapeze.Size = new System.Drawing.Size(64, 17);
            this.Trapeze.TabIndex = 2;
            this.Trapeze.TabStop = true;
            this.Trapeze.Text = "Trapeze";
            this.Trapeze.UseVisualStyleBackColor = true;
            this.Trapeze.CheckedChanged += new System.EventHandler(this.Trapeze_CheckedChanged);
            // 
            // Rhomboid
            // 
            this.Rhomboid.AutoSize = true;
            this.Rhomboid.Location = new System.Drawing.Point(32, 111);
            this.Rhomboid.Name = "Rhomboid";
            this.Rhomboid.Size = new System.Drawing.Size(73, 17);
            this.Rhomboid.TabIndex = 2;
            this.Rhomboid.TabStop = true;
            this.Rhomboid.Text = "Rhomboid";
            this.Rhomboid.UseVisualStyleBackColor = true;
            this.Rhomboid.CheckedChanged += new System.EventHandler(this.Rhomboid_CheckedChanged);
            // 
            // Diamond
            // 
            this.Diamond.AutoSize = true;
            this.Diamond.Location = new System.Drawing.Point(32, 88);
            this.Diamond.Name = "Diamond";
            this.Diamond.Size = new System.Drawing.Size(67, 17);
            this.Diamond.TabIndex = 5;
            this.Diamond.TabStop = true;
            this.Diamond.Text = "Diamond";
            this.Diamond.UseVisualStyleBackColor = true;
            this.Diamond.CheckedChanged += new System.EventHandler(this.Diamond_CheckedChanged);
            // 
            // Triangle
            // 
            this.Triangle.AutoSize = true;
            this.Triangle.Location = new System.Drawing.Point(32, 65);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(63, 17);
            this.Triangle.TabIndex = 4;
            this.Triangle.TabStop = true;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.CheckedChanged += new System.EventHandler(this.Triangle_CheckedChanged);
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(32, 42);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(74, 17);
            this.Rectangle.TabIndex = 3;
            this.Rectangle.TabStop = true;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.CheckedChanged += new System.EventHandler(this.Rectangle_CheckedChanged);
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.Location = new System.Drawing.Point(32, 19);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(59, 17);
            this.Square.TabIndex = 3;
            this.Square.TabStop = true;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.CheckedChanged += new System.EventHandler(this.Square_CheckedChanged);
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Location = new System.Drawing.Point(32, 157);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(51, 17);
            this.Circle.TabIndex = 2;
            this.Circle.TabStop = true;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedCahnged);
            // 
            // Calculadora
            // 
            this.Calculadora.BackColor = System.Drawing.Color.Azure;
            this.Calculadora.Location = new System.Drawing.Point(190, 99);
            this.Calculadora.Name = "Calculadora";
            this.Calculadora.Size = new System.Drawing.Size(75, 23);
            this.Calculadora.TabIndex = 2;
            this.Calculadora.Text = "Calculate";
            this.Calculadora.UseVisualStyleBackColor = false;
            this.Calculadora.Click += new System.EventHandler(this.Calculadora_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox2.Controls.Add(this.textBox_Dato3);
            this.groupBox2.Controls.Add(this.label_Dato3);
            this.groupBox2.Controls.Add(this.textBox_Dato2);
            this.groupBox2.Controls.Add(this.textBox_Dato1);
            this.groupBox2.Controls.Add(this.label_Dato2);
            this.groupBox2.Controls.Add(this.Label_Dato1);
            this.groupBox2.Controls.Add(this.Calculadora);
            this.groupBox2.Location = new System.Drawing.Point(252, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 128);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Azure;
            this.Clear.Location = new System.Drawing.Point(442, 330);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // tbxArea
            // 
            this.tbxArea.BackColor = System.Drawing.Color.LightPink;
            this.tbxArea.Location = new System.Drawing.Point(567, 259);
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.ReadOnly = true;
            this.tbxArea.Size = new System.Drawing.Size(141, 20);
            this.tbxArea.TabIndex = 3;
            // 
            // tbxPerimetro
            // 
            this.tbxPerimetro.BackColor = System.Drawing.Color.LightPink;
            this.tbxPerimetro.Location = new System.Drawing.Point(567, 296);
            this.tbxPerimetro.Name = "tbxPerimetro";
            this.tbxPerimetro.ReadOnly = true;
            this.tbxPerimetro.Size = new System.Drawing.Size(141, 20);
            this.tbxPerimetro.TabIndex = 4;
            // 
            // labelAREA
            // 
            this.labelAREA.AutoSize = true;
            this.labelAREA.BackColor = System.Drawing.Color.Transparent;
            this.labelAREA.Location = new System.Drawing.Point(527, 262);
            this.labelAREA.Name = "labelAREA";
            this.labelAREA.Size = new System.Drawing.Size(29, 13);
            this.labelAREA.TabIndex = 5;
            this.labelAREA.Text = "Area";
            // 
            // labelPERIMETER
            // 
            this.labelPERIMETER.AutoSize = true;
            this.labelPERIMETER.BackColor = System.Drawing.Color.Transparent;
            this.labelPERIMETER.Location = new System.Drawing.Point(505, 296);
            this.labelPERIMETER.Name = "labelPERIMETER";
            this.labelPERIMETER.Size = new System.Drawing.Size(51, 13);
            this.labelPERIMETER.TabIndex = 6;
            this.labelPERIMETER.Text = "Perimeter";
            // 
            // Label_Dato1
            // 
            this.Label_Dato1.AutoSize = true;
            this.Label_Dato1.Location = new System.Drawing.Point(6, 46);
            this.Label_Dato1.Name = "Label_Dato1";
            this.Label_Dato1.Size = new System.Drawing.Size(0, 13);
            this.Label_Dato1.TabIndex = 3;
            // 
            // label_Dato2
            // 
            this.label_Dato2.AutoSize = true;
            this.label_Dato2.Location = new System.Drawing.Point(6, 72);
            this.label_Dato2.Name = "label_Dato2";
            this.label_Dato2.Size = new System.Drawing.Size(0, 13);
            this.label_Dato2.TabIndex = 4;
            // 
            // textBox_Dato1
            // 
            this.textBox_Dato1.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox_Dato1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_Dato1.Location = new System.Drawing.Point(111, 42);
            this.textBox_Dato1.Name = "textBox_Dato1";
            this.textBox_Dato1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Dato1.TabIndex = 5;
            // 
            // textBox_Dato2
            // 
            this.textBox_Dato2.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox_Dato2.Location = new System.Drawing.Point(111, 69);
            this.textBox_Dato2.Name = "textBox_Dato2";
            this.textBox_Dato2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Dato2.TabIndex = 6;
            // 
            // label_Dato3
            // 
            this.label_Dato3.AutoSize = true;
            this.label_Dato3.Location = new System.Drawing.Point(231, 46);
            this.label_Dato3.Name = "label_Dato3";
            this.label_Dato3.Size = new System.Drawing.Size(0, 13);
            this.label_Dato3.TabIndex = 7;
            // 
            // textBox_Dato3
            // 
            this.textBox_Dato3.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox_Dato3.Location = new System.Drawing.Point(350, 43);
            this.textBox_Dato3.Name = "textBox_Dato3";
            this.textBox_Dato3.Size = new System.Drawing.Size(100, 20);
            this.textBox_Dato3.TabIndex = 8;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 402);
            this.Controls.Add(this.labelPERIMETER);
            this.Controls.Add(this.labelAREA);
            this.Controls.Add(this.tbxPerimetro);
            this.Controls.Add(this.tbxArea);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Geometry Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.RadioButton Square;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.RadioButton Diamond;
        private System.Windows.Forms.RadioButton Triangle;
        private System.Windows.Forms.RadioButton Trapeze;
        private System.Windows.Forms.RadioButton Rhomboid;
        private System.Windows.Forms.RadioButton Polygon;
        private System.Windows.Forms.Button Calculadora;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox tbxArea;
        private System.Windows.Forms.TextBox tbxPerimetro;
        private System.Windows.Forms.Label labelAREA;
        private System.Windows.Forms.Label labelPERIMETER;
        private System.Windows.Forms.Label label_Dato2;
        private System.Windows.Forms.Label Label_Dato1;
        private System.Windows.Forms.TextBox textBox_Dato3;
        private System.Windows.Forms.Label label_Dato3;
        private System.Windows.Forms.TextBox textBox_Dato2;
        private System.Windows.Forms.TextBox textBox_Dato1;
    }
}


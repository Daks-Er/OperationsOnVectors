
namespace OperationsOnVectors
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.Koordinat = new System.Windows.Forms.GroupBox();
            this.Ay = new System.Windows.Forms.TextBox();
            this.Bx = new System.Windows.Forms.TextBox();
            this.By = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Znach = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Formula = new System.Windows.Forms.GroupBox();
            this.formu = new System.Windows.Forms.TextBox();
            this.Rez = new System.Windows.Forms.GroupBox();
            this.rezult = new System.Windows.Forms.TextBox();
            this.Dan = new System.Windows.Forms.GroupBox();
            this.Do = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.operac = new System.Windows.Forms.ComboBox();
            this.C = new System.Windows.Forms.Button();
            this.Koordinat.SuspendLayout();
            this.Formula.SuspendLayout();
            this.Rez.SuspendLayout();
            this.Dan.SuspendLayout();
            this.SuspendLayout();
            // 
            // Koordinat
            // 
            this.Koordinat.Controls.Add(this.Ay);
            this.Koordinat.Controls.Add(this.Bx);
            this.Koordinat.Controls.Add(this.By);
            this.Koordinat.Controls.Add(this.label2);
            this.Koordinat.Controls.Add(this.Ax);
            this.Koordinat.Controls.Add(this.label1);
            this.Koordinat.Location = new System.Drawing.Point(15, 66);
            this.Koordinat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Koordinat.Name = "Koordinat";
            this.Koordinat.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Koordinat.Size = new System.Drawing.Size(239, 128);
            this.Koordinat.TabIndex = 0;
            this.Koordinat.TabStop = false;
            this.Koordinat.Text = "Координаты";
            // 
            // Ay
            // 
            this.Ay.Location = new System.Drawing.Point(137, 32);
            this.Ay.Name = "Ay";
            this.Ay.Size = new System.Drawing.Size(71, 26);
            this.Ay.TabIndex = 7;
            // 
            // Bx
            // 
            this.Bx.Location = new System.Drawing.Point(50, 84);
            this.Bx.Name = "Bx";
            this.Bx.Size = new System.Drawing.Size(74, 26);
            this.Bx.TabIndex = 6;
            // 
            // By
            // 
            this.By.Location = new System.Drawing.Point(137, 84);
            this.By.Name = "By";
            this.By.Size = new System.Drawing.Size(71, 26);
            this.By.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "b = {                ;                }";
            // 
            // Ax
            // 
            this.Ax.Location = new System.Drawing.Point(50, 32);
            this.Ax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ax.Name = "Ax";
            this.Ax.Size = new System.Drawing.Size(74, 26);
            this.Ax.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "a = {                ;                }";
            // 
            // Znach
            // 
            this.Znach.Location = new System.Drawing.Point(142, 38);
            this.Znach.Name = "Znach";
            this.Znach.Size = new System.Drawing.Size(77, 26);
            this.Znach.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Formula
            // 
            this.Formula.Controls.Add(this.formu);
            this.Formula.Location = new System.Drawing.Point(15, 198);
            this.Formula.Name = "Formula";
            this.Formula.Size = new System.Drawing.Size(481, 68);
            this.Formula.TabIndex = 5;
            this.Formula.TabStop = false;
            this.Formula.Text = "Формула";
            // 
            // formu
            // 
            this.formu.Location = new System.Drawing.Point(3, 26);
            this.formu.Name = "formu";
            this.formu.Size = new System.Drawing.Size(472, 26);
            this.formu.TabIndex = 0;
            // 
            // Rez
            // 
            this.Rez.Controls.Add(this.rezult);
            this.Rez.Location = new System.Drawing.Point(537, 198);
            this.Rez.Name = "Rez";
            this.Rez.Size = new System.Drawing.Size(159, 68);
            this.Rez.TabIndex = 6;
            this.Rez.TabStop = false;
            this.Rez.Text = "Результат";
            // 
            // rezult
            // 
            this.rezult.Location = new System.Drawing.Point(6, 26);
            this.rezult.Name = "rezult";
            this.rezult.Size = new System.Drawing.Size(147, 26);
            this.rezult.TabIndex = 0;
            // 
            // Dan
            // 
            this.Dan.Controls.Add(this.Do);
            this.Dan.Controls.Add(this.Znach);
            this.Dan.Controls.Add(this.label3);
            this.Dan.Location = new System.Drawing.Point(294, 83);
            this.Dan.Name = "Dan";
            this.Dan.Size = new System.Drawing.Size(258, 87);
            this.Dan.TabIndex = 7;
            this.Dan.TabStop = false;
            this.Dan.Text = "Дополнительные данные";
            // 
            // Do
            // 
            this.Do.Location = new System.Drawing.Point(24, 38);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(87, 26);
            this.Do.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "=";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // operac
            // 
            this.operac.BackColor = System.Drawing.SystemColors.Menu;
            this.operac.FormattingEnabled = true;
            this.operac.Items.AddRange(new object[] {
            "Сложение",
            "Вычитание",
            "Скалярное произведение",
            "Умножение на число",
            "Длина вектора",
            "Угол между векторами",
            "Коллинеарность двух векторов"});
            this.operac.Location = new System.Drawing.Point(15, 12);
            this.operac.Name = "operac";
            this.operac.Size = new System.Drawing.Size(295, 28);
            this.operac.TabIndex = 9;
            this.operac.Text = "Выберите операцию";
            this.operac.SelectedIndexChanged += new System.EventHandler(this.operac_SelectedIndexChanged);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(372, 12);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(118, 28);
            this.C.TabIndex = 10;
            this.C.Text = "Очистить";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(708, 283);
            this.Controls.Add(this.C);
            this.Controls.Add(this.operac);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dan);
            this.Controls.Add(this.Rez);
            this.Controls.Add(this.Formula);
            this.Controls.Add(this.Koordinat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Операции над векторами";
            this.Koordinat.ResumeLayout(false);
            this.Koordinat.PerformLayout();
            this.Formula.ResumeLayout(false);
            this.Formula.PerformLayout();
            this.Rez.ResumeLayout(false);
            this.Rez.PerformLayout();
            this.Dan.ResumeLayout(false);
            this.Dan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Koordinat;
        private System.Windows.Forms.TextBox Ax;
        private System.Windows.Forms.TextBox Ay;
        private System.Windows.Forms.TextBox Bx;
        private System.Windows.Forms.TextBox By;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Znach;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox Formula;
        private System.Windows.Forms.TextBox formu;
        private System.Windows.Forms.GroupBox Rez;
        private System.Windows.Forms.TextBox rezult;
        private System.Windows.Forms.GroupBox Dan;
        private System.Windows.Forms.TextBox Do;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox operac;
        private System.Windows.Forms.Button C;
    }
}


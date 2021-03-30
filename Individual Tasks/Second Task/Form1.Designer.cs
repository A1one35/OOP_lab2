
namespace Second_Task
{
    partial class Form1
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
            this.Transparency = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.Button();
            this.hello_World = new System.Windows.Forms.Button();
            this.Super_button = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Transparency
            // 
            this.Transparency.Location = new System.Drawing.Point(16, 15);
            this.Transparency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Transparency.Name = "Transparency";
            this.Transparency.Size = new System.Drawing.Size(152, 58);
            this.Transparency.TabIndex = 0;
            this.Transparency.Text = "Прозорість";
            this.Transparency.UseVisualStyleBackColor = true;
            this.Transparency.Click += new System.EventHandler(this.Transparency_Click);
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(223, 15);
            this.Color.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(160, 58);
            this.Color.TabIndex = 1;
            this.Color.Text = "Колір тла";
            this.Color.UseVisualStyleBackColor = true;
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // hello_World
            // 
            this.hello_World.Location = new System.Drawing.Point(427, 15);
            this.hello_World.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hello_World.Name = "hello_World";
            this.hello_World.Size = new System.Drawing.Size(152, 58);
            this.hello_World.TabIndex = 2;
            this.hello_World.Text = "hello World";
            this.hello_World.UseVisualStyleBackColor = true;
            this.hello_World.Click += new System.EventHandler(this.hello_World_Click);
            // 
            // Super_button
            // 
            this.Super_button.Location = new System.Drawing.Point(16, 80);
            this.Super_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Super_button.Name = "Super_button";
            this.Super_button.Size = new System.Drawing.Size(563, 70);
            this.Super_button.TabIndex = 3;
            this.Super_button.Text = "супермегакнопка";
            this.Super_button.UseVisualStyleBackColor = true;
            this.Super_button.Click += new System.EventHandler(this.Super_button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 180);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(291, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "\"супермегакнопка\" робить \"Прозорість\"";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(16, 240);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(279, 21);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "\"супермегакнопка\" змінює \"Колір тла\"";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(16, 301);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(303, 21);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "\"супермегакнопка\" виводить \"hello World\"";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 444);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Super_button);
            this.Controls.Add(this.hello_World);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Transparency);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Transparency;
        private System.Windows.Forms.Button Color;
        private System.Windows.Forms.Button hello_World;
        private System.Windows.Forms.Button Super_button;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}


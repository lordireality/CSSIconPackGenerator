namespace CSSIconPackGenerator
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
            this.Generate = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.TextBox();
            this.cssClassTemplate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OutPut = new System.Windows.Forms.TextBox();
            this.RemoveSolid = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(712, 188);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(76, 29);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(116, 9);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(672, 20);
            this.Path.TabIndex = 1;
            this.Path.Text = "C:\\";
            // 
            // cssClassTemplate
            // 
            this.cssClassTemplate.Location = new System.Drawing.Point(116, 35);
            this.cssClassTemplate.Multiline = true;
            this.cssClassTemplate.Name = "cssClassTemplate";
            this.cssClassTemplate.Size = new System.Drawing.Size(672, 147);
            this.cssClassTemplate.TabIndex = 2;
            this.cssClassTemplate.Text = ".icon-button.{1},.icon-lbutton.{1},\r\n.icon-header.{1}{\r\n    background-image: url" +
    "(\'../icon-pack/{0}\');\r\n}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IconsFolderPath";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CSS class template";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "{0} - full file name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "{1} - shortname";
            // 
            // OutPut
            // 
            this.OutPut.Location = new System.Drawing.Point(16, 223);
            this.OutPut.Multiline = true;
            this.OutPut.Name = "OutPut";
            this.OutPut.ReadOnly = true;
            this.OutPut.Size = new System.Drawing.Size(772, 331);
            this.OutPut.TabIndex = 7;
            this.OutPut.Text = ".icon-button.{1},.icon-lbutton.{1},\r\n.icon-header.{1}{\r\n    background-image: url" +
    "(\'../icon-pack/{0}\');\r\n}";
            // 
            // RemoveSolid
            // 
            this.RemoveSolid.AutoSize = true;
            this.RemoveSolid.Location = new System.Drawing.Point(116, 188);
            this.RemoveSolid.Name = "RemoveSolid";
            this.RemoveSolid.Size = new System.Drawing.Size(108, 17);
            this.RemoveSolid.TabIndex = 8;
            this.RemoveSolid.Text = "Remove solid tag";
            this.RemoveSolid.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 572);
            this.Controls.Add(this.RemoveSolid);
            this.Controls.Add(this.OutPut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cssClassTemplate);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.Generate);
            this.Name = "Form1";
            this.Text = "CSSIconPackGenerator v.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.TextBox cssClassTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OutPut;
        private System.Windows.Forms.CheckBox RemoveSolid;
    }
}


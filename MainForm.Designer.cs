namespace Physics
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.charSizeFld = new System.Windows.Forms.TextBox();
            this.airTempFld = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.secondParamLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.emissivityFld = new System.Windows.Forms.TextBox();
            this.t5TextBox = new System.Windows.Forms.TextBox();
            this.lengthFld = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.t4TextBox = new System.Windows.Forms.TextBox();
            this.t3TextBox = new System.Windows.Forms.TextBox();
            this.t2TextBox = new System.Windows.Forms.TextBox();
            this.t1TextBox = new System.Windows.Forms.TextBox();
            this.verticalRButton = new System.Windows.Forms.RadioButton();
            this.horizontalRButton = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CalculateBut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.avTempTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.heatTransferCoeffFld = new System.Windows.Forms.TextBox();
            this.nusseltFld = new System.Windows.Forms.TextBox();
            this.rayleighFld = new System.Windows.Forms.TextBox();
            this.grashofFld = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.equtionPicBox = new System.Windows.Forms.PictureBox();
            this.GraphButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equtionPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Характерный размер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Температура воздуха";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Температура поверхности в локальных точках";
            // 
            // charSizeFld
            // 
            this.charSizeFld.Location = new System.Drawing.Point(145, 17);
            this.charSizeFld.MaxLength = 4;
            this.charSizeFld.Name = "charSizeFld";
            this.charSizeFld.Size = new System.Drawing.Size(80, 20);
            this.charSizeFld.TabIndex = 1;
            // 
            // airTempFld
            // 
            this.airTempFld.Location = new System.Drawing.Point(146, 113);
            this.airTempFld.MaxLength = 4;
            this.airTempFld.Name = "airTempFld";
            this.airTempFld.Size = new System.Drawing.Size(80, 20);
            this.airTempFld.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "мм";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.secondParamLabel);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.emissivityFld);
            this.groupBox1.Controls.Add(this.t5TextBox);
            this.groupBox1.Controls.Add(this.lengthFld);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.t4TextBox);
            this.groupBox1.Controls.Add(this.t3TextBox);
            this.groupBox1.Controls.Add(this.t2TextBox);
            this.groupBox1.Controls.Add(this.t1TextBox);
            this.groupBox1.Controls.Add(this.verticalRButton);
            this.groupBox1.Controls.Add(this.horizontalRButton);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.charSizeFld);
            this.groupBox1.Controls.Add(this.airTempFld);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(365, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 223);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные параметры";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(231, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "мм";
            // 
            // secondParamLabel
            // 
            this.secondParamLabel.AutoSize = true;
            this.secondParamLabel.Location = new System.Drawing.Point(7, 86);
            this.secondParamLabel.Name = "secondParamLabel";
            this.secondParamLabel.Size = new System.Drawing.Size(96, 13);
            this.secondParamLabel.TabIndex = 22;
            this.secondParamLabel.Text = "Длина цилиндра l";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Коэффициент черноты";
            // 
            // emissivityFld
            // 
            this.emissivityFld.Location = new System.Drawing.Point(145, 193);
            this.emissivityFld.MaxLength = 5;
            this.emissivityFld.Name = "emissivityFld";
            this.emissivityFld.Size = new System.Drawing.Size(81, 20);
            this.emissivityFld.TabIndex = 11;
            // 
            // t5TextBox
            // 
            this.t5TextBox.Location = new System.Drawing.Point(210, 161);
            this.t5TextBox.MaxLength = 4;
            this.t5TextBox.Name = "t5TextBox";
            this.t5TextBox.Size = new System.Drawing.Size(45, 20);
            this.t5TextBox.TabIndex = 10;
            // 
            // lengthFld
            // 
            this.lengthFld.Location = new System.Drawing.Point(145, 83);
            this.lengthFld.MaxLength = 4;
            this.lengthFld.Name = "lengthFld";
            this.lengthFld.Size = new System.Drawing.Size(80, 20);
            this.lengthFld.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(258, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "°С";
            // 
            // t4TextBox
            // 
            this.t4TextBox.Location = new System.Drawing.Point(159, 161);
            this.t4TextBox.MaxLength = 4;
            this.t4TextBox.Name = "t4TextBox";
            this.t4TextBox.Size = new System.Drawing.Size(45, 20);
            this.t4TextBox.TabIndex = 9;
            // 
            // t3TextBox
            // 
            this.t3TextBox.Location = new System.Drawing.Point(108, 161);
            this.t3TextBox.MaxLength = 4;
            this.t3TextBox.Name = "t3TextBox";
            this.t3TextBox.Size = new System.Drawing.Size(45, 20);
            this.t3TextBox.TabIndex = 8;
            // 
            // t2TextBox
            // 
            this.t2TextBox.Location = new System.Drawing.Point(57, 161);
            this.t2TextBox.MaxLength = 4;
            this.t2TextBox.Name = "t2TextBox";
            this.t2TextBox.Size = new System.Drawing.Size(45, 20);
            this.t2TextBox.TabIndex = 7;
            // 
            // t1TextBox
            // 
            this.t1TextBox.Location = new System.Drawing.Point(6, 161);
            this.t1TextBox.MaxLength = 4;
            this.t1TextBox.Name = "t1TextBox";
            this.t1TextBox.Size = new System.Drawing.Size(45, 20);
            this.t1TextBox.TabIndex = 6;
            // 
            // verticalRButton
            // 
            this.verticalRButton.AutoSize = true;
            this.verticalRButton.Location = new System.Drawing.Point(127, 57);
            this.verticalRButton.Name = "verticalRButton";
            this.verticalRButton.Size = new System.Drawing.Size(99, 17);
            this.verticalRButton.TabIndex = 3;
            this.verticalRButton.Text = "Вертикальный";
            this.verticalRButton.UseVisualStyleBackColor = true;
            this.verticalRButton.CheckedChanged += new System.EventHandler(this.verticalRButton_CheckedChanged);
            // 
            // horizontalRButton
            // 
            this.horizontalRButton.AutoSize = true;
            this.horizontalRButton.Checked = true;
            this.horizontalRButton.Location = new System.Drawing.Point(10, 57);
            this.horizontalRButton.Name = "horizontalRButton";
            this.horizontalRButton.Size = new System.Drawing.Size(110, 17);
            this.horizontalRButton.TabIndex = 2;
            this.horizontalRButton.TabStop = true;
            this.horizontalRButton.Text = "Горизонтальный";
            this.horizontalRButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Тип цилиндра";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "°С";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "°С";
            // 
            // CalculateBut
            // 
            this.CalculateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateBut.Location = new System.Drawing.Point(539, 409);
            this.CalculateBut.Name = "CalculateBut";
            this.CalculateBut.Size = new System.Drawing.Size(100, 35);
            this.CalculateBut.TabIndex = 12;
            this.CalculateBut.Text = "Вычислить";
            this.CalculateBut.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.avTempTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.heatTransferCoeffFld);
            this.groupBox2.Controls.Add(this.nusseltFld);
            this.groupBox2.Controls.Add(this.rayleighFld);
            this.groupBox2.Controls.Add(this.grashofFld);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(365, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 162);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вычисления";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(228, 133);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Вт/(м²·К)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(228, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "°С";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Среднее значение t";
            // 
            // avTempTextBox
            // 
            this.avTempTextBox.Location = new System.Drawing.Point(132, 24);
            this.avTempTextBox.Name = "avTempTextBox";
            this.avTempTextBox.ReadOnly = true;
            this.avTempTextBox.Size = new System.Drawing.Size(90, 20);
            this.avTempTextBox.TabIndex = 24;
            this.avTempTextBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Коэфф. теплоотдачи α";
            // 
            // heatTransferCoeffFld
            // 
            this.heatTransferCoeffFld.Location = new System.Drawing.Point(132, 130);
            this.heatTransferCoeffFld.Name = "heatTransferCoeffFld";
            this.heatTransferCoeffFld.ReadOnly = true;
            this.heatTransferCoeffFld.Size = new System.Drawing.Size(92, 20);
            this.heatTransferCoeffFld.TabIndex = 22;
            this.heatTransferCoeffFld.TabStop = false;
            // 
            // nusseltFld
            // 
            this.nusseltFld.Location = new System.Drawing.Point(132, 104);
            this.nusseltFld.Name = "nusseltFld";
            this.nusseltFld.ReadOnly = true;
            this.nusseltFld.Size = new System.Drawing.Size(92, 20);
            this.nusseltFld.TabIndex = 21;
            this.nusseltFld.TabStop = false;
            // 
            // rayleighFld
            // 
            this.rayleighFld.Location = new System.Drawing.Point(132, 78);
            this.rayleighFld.Name = "rayleighFld";
            this.rayleighFld.ReadOnly = true;
            this.rayleighFld.Size = new System.Drawing.Size(92, 20);
            this.rayleighFld.TabIndex = 20;
            this.rayleighFld.TabStop = false;
            // 
            // grashofFld
            // 
            this.grashofFld.Location = new System.Drawing.Point(132, 50);
            this.grashofFld.Name = "grashofFld";
            this.grashofFld.ReadOnly = true;
            this.grashofFld.Size = new System.Drawing.Size(92, 20);
            this.grashofFld.TabIndex = 19;
            this.grashofFld.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Число Нуссельта (Nu)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Число Релея (Ra)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Число Гросгофа (Gr)";
            // 
            // equtionPicBox
            // 
            this.equtionPicBox.Location = new System.Drawing.Point(12, 12);
            this.equtionPicBox.Name = "equtionPicBox";
            this.equtionPicBox.Size = new System.Drawing.Size(347, 438);
            this.equtionPicBox.TabIndex = 17;
            this.equtionPicBox.TabStop = false;
            // 
            // GraphButton
            // 
            this.GraphButton.Enabled = false;
            this.GraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GraphButton.Location = new System.Drawing.Point(375, 409);
            this.GraphButton.Name = "GraphButton";
            this.GraphButton.Size = new System.Drawing.Size(100, 35);
            this.GraphButton.TabIndex = 13;
            this.GraphButton.Text = "График";
            this.GraphButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 462);
            this.Controls.Add(this.GraphButton);
            this.Controls.Add(this.equtionPicBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CalculateBut);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Тепломассообмен";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equtionPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox charSizeFld;
        private System.Windows.Forms.TextBox airTempFld;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CalculateBut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox heatTransferCoeffFld;
        private System.Windows.Forms.TextBox nusseltFld;
        private System.Windows.Forms.TextBox rayleighFld;
        private System.Windows.Forms.TextBox grashofFld;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox equtionPicBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox t4TextBox;
        private System.Windows.Forms.TextBox t3TextBox;
        private System.Windows.Forms.TextBox t2TextBox;
        private System.Windows.Forms.RadioButton verticalRButton;
        private System.Windows.Forms.RadioButton horizontalRButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox avTempTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox t5TextBox;
        private System.Windows.Forms.TextBox t1TextBox;
        private System.Windows.Forms.Button GraphButton;
        private System.Windows.Forms.TextBox lengthFld;
        private System.Windows.Forms.TextBox emissivityFld;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label secondParamLabel;
        private System.Windows.Forms.Label label14;
    }
}


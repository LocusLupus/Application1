namespace Polygon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            buttonTriangle = new Button();
            trilenght = new TextBox();
            triHeight = new TextBox();
            labelTriangle = new Label();
            labeltrih = new Label();
            labeltriw = new Label();
            cleartri = new Button();
            triarea = new Label();
            inertia = new Label();
            inertiaBox = new TextBox();
            areaBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textRecLenght = new TextBox();
            textRecHeight = new TextBox();
            RecInertiaBox = new TextBox();
            RecAreaBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            recClear = new Button();
            ButtonRec = new Button();
            label4 = new Label();
            ISection = new Label();
            uplenghtbox = new TextBox();
            upheightbox = new TextBox();
            midlenghtbox = new TextBox();
            lowlenghtbox = new TextBox();
            IsecClear = new Button();
            buttonIsec = new Button();
            uplenght = new Label();
            lowlenght = new Label();
            upheight = new Label();
            midlenght = new Label();
            midheightbox = new TextBox();
            lowheightbox = new TextBox();
            midheight = new Label();
            lowheight = new Label();
            inertiaIsecbox = new TextBox();
            areaIsecbox = new TextBox();
            AreaIsec = new Label();
            InertiaIsec = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.ControlLightLight;
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(723, 597);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // buttonTriangle
            // 
            buttonTriangle.Location = new Point(986, 74);
            buttonTriangle.Name = "buttonTriangle";
            buttonTriangle.Size = new Size(75, 23);
            buttonTriangle.TabIndex = 1;
            buttonTriangle.Text = "Calculate";
            buttonTriangle.UseVisualStyleBackColor = true;
            // 
            // trilenght
            // 
            trilenght.AcceptsReturn = true;
            trilenght.Location = new Point(855, 75);
            trilenght.Name = "trilenght";
            trilenght.Size = new Size(100, 23);
            trilenght.TabIndex = 4;
            // 
            // triHeight
            // 
            triHeight.AcceptsReturn = true;
            triHeight.Location = new Point(740, 75);
            triHeight.Name = "triHeight";
            triHeight.Size = new Size(100, 23);
            triHeight.TabIndex = 6;
            // 
            // labelTriangle
            // 
            labelTriangle.AccessibleRole = AccessibleRole.TitleBar;
            labelTriangle.BackColor = SystemColors.HighlightText;
            labelTriangle.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelTriangle.ForeColor = SystemColors.ControlText;
            labelTriangle.Location = new Point(740, 9);
            labelTriangle.Name = "labelTriangle";
            labelTriangle.Size = new Size(321, 40);
            labelTriangle.TabIndex = 60;
            labelTriangle.Text = " Triangle";
            labelTriangle.TextAlign = ContentAlignment.TopCenter;
            // 
            // labeltrih
            // 
            labeltrih.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labeltrih.Location = new Point(740, 49);
            labeltrih.Name = "labeltrih";
            labeltrih.Size = new Size(100, 23);
            labeltrih.TabIndex = 61;
            labeltrih.Text = "Height";
            labeltrih.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labeltriw
            // 
            labeltriw.BackColor = SystemColors.GradientInactiveCaption;
            labeltriw.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labeltriw.Location = new Point(855, 49);
            labeltriw.Name = "labeltriw";
            labeltriw.Size = new Size(100, 23);
            labeltriw.TabIndex = 62;
            labeltriw.Text = "Side Lenght";
            labeltriw.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cleartri
            // 
            cleartri.Location = new Point(986, 100);
            cleartri.Name = "cleartri";
            cleartri.Size = new Size(75, 23);
            cleartri.TabIndex = 63;
            cleartri.Text = "Clear";
            cleartri.UseVisualStyleBackColor = true;
            // 
            // triarea
            // 
            triarea.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            triarea.Location = new Point(740, 100);
            triarea.Name = "triarea";
            triarea.Size = new Size(100, 23);
            triarea.TabIndex = 64;
            triarea.Text = " Area";
            triarea.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inertia
            // 
            inertia.Location = new Point(855, 104);
            inertia.Name = "inertia";
            inertia.Size = new Size(125, 23);
            inertia.TabIndex = 65;
            inertia.Text = "Moment of Inertia";
            // 
            // inertiaBox
            // 
            inertiaBox.Location = new Point(855, 126);
            inertiaBox.Name = "inertiaBox";
            inertiaBox.Size = new Size(201, 23);
            inertiaBox.TabIndex = 66;
            // 
            // areaBox
            // 
            areaBox.Location = new Point(740, 126);
            areaBox.Name = "areaBox";
            areaBox.Size = new Size(100, 23);
            areaBox.TabIndex = 67;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.TitleBar;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(740, 161);
            label1.Name = "label1";
            label1.Size = new Size(321, 40);
            label1.TabIndex = 68;
            label1.Text = "Rectangle";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Location = new Point(741, 207);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 70;
            label3.Text = "Height";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textRecLenght
            // 
            textRecLenght.Location = new Point(855, 233);
            textRecLenght.Name = "textRecLenght";
            textRecLenght.Size = new Size(100, 23);
            textRecLenght.TabIndex = 71;
            // 
            // textRecHeight
            // 
            textRecHeight.Location = new Point(740, 233);
            textRecHeight.Name = "textRecHeight";
            textRecHeight.Size = new Size(100, 23);
            textRecHeight.TabIndex = 72;
            // 
            // RecInertiaBox
            // 
            RecInertiaBox.Location = new Point(855, 285);
            RecInertiaBox.Name = "RecInertiaBox";
            RecInertiaBox.Size = new Size(201, 23);
            RecInertiaBox.TabIndex = 73;
            // 
            // RecAreaBox
            // 
            RecAreaBox.Location = new Point(741, 285);
            RecAreaBox.Name = "RecAreaBox";
            RecAreaBox.Size = new Size(100, 23);
            RecAreaBox.TabIndex = 74;
            // 
            // label5
            // 
            label5.Location = new Point(741, 259);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 76;
            label5.Text = "Area";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location = new Point(855, 259);
            label6.Name = "label6";
            label6.Size = new Size(125, 23);
            label6.TabIndex = 77;
            label6.Text = "Moment of Inertia";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // recClear
            // 
            recClear.Location = new Point(986, 259);
            recClear.Name = "recClear";
            recClear.Size = new Size(75, 23);
            recClear.TabIndex = 78;
            recClear.Text = "Clear";
            recClear.UseVisualStyleBackColor = true;
            // 
            // ButtonRec
            // 
            ButtonRec.Location = new Point(986, 233);
            ButtonRec.Name = "ButtonRec";
            ButtonRec.Size = new Size(75, 23);
            ButtonRec.TabIndex = 79;
            ButtonRec.Text = "Calculate";
            ButtonRec.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Location = new Point(855, 207);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 81;
            label4.Text = "Side Lenght";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ISection
            // 
            ISection.BackColor = SystemColors.ButtonHighlight;
            ISection.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ISection.Location = new Point(740, 320);
            ISection.Name = "ISection";
            ISection.Size = new Size(316, 40);
            ISection.TabIndex = 82;
            ISection.Text = "I Shaped Section";
            ISection.TextAlign = ContentAlignment.TopCenter;
            // 
            // uplenghtbox
            // 
            uplenghtbox.Location = new Point(855, 392);
            uplenghtbox.Name = "uplenghtbox";
            uplenghtbox.Size = new Size(100, 23);
            uplenghtbox.TabIndex = 83;
            // 
            // upheightbox
            // 
            upheightbox.Location = new Point(855, 455);
            upheightbox.Name = "upheightbox";
            upheightbox.Size = new Size(100, 23);
            upheightbox.TabIndex = 84;
            // 
            // midlenghtbox
            // 
            midlenghtbox.Location = new Point(741, 455);
            midlenghtbox.Name = "midlenghtbox";
            midlenghtbox.Size = new Size(100, 23);
            midlenghtbox.TabIndex = 85;
            // 
            // lowlenghtbox
            // 
            lowlenghtbox.Location = new Point(741, 392);
            lowlenghtbox.Name = "lowlenghtbox";
            lowlenghtbox.Size = new Size(100, 23);
            lowlenghtbox.TabIndex = 86;
            // 
            // IsecClear
            // 
            IsecClear.Location = new Point(986, 426);
            IsecClear.Name = "IsecClear";
            IsecClear.Size = new Size(75, 23);
            IsecClear.TabIndex = 87;
            IsecClear.Text = "Clear";
            IsecClear.UseVisualStyleBackColor = true;
            // 
            // buttonIsec
            // 
            buttonIsec.Location = new Point(986, 391);
            buttonIsec.Name = "buttonIsec";
            buttonIsec.Size = new Size(75, 23);
            buttonIsec.TabIndex = 88;
            buttonIsec.Text = "Calculate";
            buttonIsec.UseVisualStyleBackColor = true;
            // 
            // uplenght
            // 
            uplenght.Location = new Point(855, 366);
            uplenght.Name = "uplenght";
            uplenght.Size = new Size(100, 23);
            uplenght.TabIndex = 89;
            uplenght.Text = "Upper Lenght";
            uplenght.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lowlenght
            // 
            lowlenght.Location = new Point(742, 366);
            lowlenght.Name = "lowlenght";
            lowlenght.Size = new Size(99, 23);
            lowlenght.TabIndex = 90;
            lowlenght.Text = "Lower lenght";
            lowlenght.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // upheight
            // 
            upheight.Location = new Point(855, 429);
            upheight.Name = "upheight";
            upheight.Size = new Size(100, 23);
            upheight.TabIndex = 91;
            upheight.Text = "Upper height";
            upheight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // midlenght
            // 
            midlenght.Location = new Point(740, 426);
            midlenght.Name = "midlenght";
            midlenght.Size = new Size(100, 23);
            midlenght.TabIndex = 92;
            midlenght.Text = "Middle Lenght";
            midlenght.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // midheightbox
            // 
            midheightbox.Location = new Point(855, 513);
            midheightbox.Name = "midheightbox";
            midheightbox.Size = new Size(100, 23);
            midheightbox.TabIndex = 96;
            // 
            // lowheightbox
            // 
            lowheightbox.Location = new Point(740, 513);
            lowheightbox.Name = "lowheightbox";
            lowheightbox.Size = new Size(100, 23);
            lowheightbox.TabIndex = 97;
            // 
            // midheight
            // 
            midheight.AutoSize = true;
            midheight.Location = new Point(855, 495);
            midheight.Name = "midheight";
            midheight.Size = new Size(92, 15);
            midheight.TabIndex = 100;
            midheight.Text = "  Middle Height";
            midheight.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lowheight
            // 
            lowheight.AutoSize = true;
            lowheight.Location = new Point(742, 495);
            lowheight.Name = "lowheight";
            lowheight.Size = new Size(88, 15);
            lowheight.TabIndex = 101;
            lowheight.Text = "  Lower Height";
            lowheight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inertiaIsecbox
            // 
            inertiaIsecbox.Location = new Point(855, 562);
            inertiaIsecbox.Name = "inertiaIsecbox";
            inertiaIsecbox.Size = new Size(201, 23);
            inertiaIsecbox.TabIndex = 102;
            // 
            // areaIsecbox
            // 
            areaIsecbox.Location = new Point(740, 562);
            areaIsecbox.Name = "areaIsecbox";
            areaIsecbox.Size = new Size(100, 23);
            areaIsecbox.TabIndex = 103;
            // 
            // AreaIsec
            // 
            AreaIsec.Location = new Point(742, 544);
            AreaIsec.Name = "AreaIsec";
            AreaIsec.Size = new Size(88, 15);
            AreaIsec.TabIndex = 104;
            AreaIsec.Text = "  Area";
            AreaIsec.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InertiaIsec
            // 
            InertiaIsec.AutoSize = true;
            InertiaIsec.Location = new Point(855, 544);
            InertiaIsec.Name = "InertiaIsec";
            InertiaIsec.Size = new Size(115, 15);
            InertiaIsec.TabIndex = 105;
            InertiaIsec.Text = "  Moment of Inertia";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1420, 654);
            Controls.Add(InertiaIsec);
            Controls.Add(AreaIsec);
            Controls.Add(areaIsecbox);
            Controls.Add(inertiaIsecbox);
            Controls.Add(lowheight);
            Controls.Add(midheight);
            Controls.Add(lowheightbox);
            Controls.Add(midheightbox);
            Controls.Add(midlenght);
            Controls.Add(upheight);
            Controls.Add(lowlenght);
            Controls.Add(uplenght);
            Controls.Add(buttonIsec);
            Controls.Add(IsecClear);
            Controls.Add(lowlenghtbox);
            Controls.Add(midlenghtbox);
            Controls.Add(upheightbox);
            Controls.Add(uplenghtbox);
            Controls.Add(ISection);
            Controls.Add(label4);
            Controls.Add(ButtonRec);
            Controls.Add(recClear);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(RecAreaBox);
            Controls.Add(RecInertiaBox);
            Controls.Add(textRecHeight);
            Controls.Add(textRecLenght);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(areaBox);
            Controls.Add(inertiaBox);
            Controls.Add(inertia);
            Controls.Add(triarea);
            Controls.Add(cleartri);
            Controls.Add(labeltriw);
            Controls.Add(labeltrih);
            Controls.Add(labelTriangle);
            Controls.Add(triHeight);
            Controls.Add(trilenght);
            Controls.Add(buttonTriangle);
            Controls.Add(pictureBox);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonTriangle;
        private TextBox trilenght;
        private TextBox triHeight;
        private Label labelTriangle;
        private Label labeltrih;
        private Label labeltriw;
        public PictureBox pictureBox;
        private Button cleartri;
        private Label triarea;
        private Label inertia;
        private TextBox inertiaBox;
        private TextBox areaBox;
        private Label label1;
        private Label label3;
        private TextBox textRecLenght;
        private TextBox textRecHeight;
        private TextBox RecInertiaBox;
        private TextBox RecAreaBox;
        private Label label5;
        private Label label6;
        private Button recClear;
        private Button ButtonRec;
        private Label label4;
        private Label ISection;
        private TextBox uplenghtbox;
        private TextBox upheightbox;
        private TextBox midlenghtbox;
        private TextBox lowlenghtbox;
        private Button IsecClear;
        private Button buttonIsec;
        private Label uplenght;
        private Label lowlenght;
        private Label upheight;
        private Label midlenght;
        private TextBox midheightbox;
        private TextBox lowheightbox;
        private Label midheight;
        private Label lowheight;
        private TextBox inertiaIsecbox;
        private TextBox areaIsecbox;
        private Label AreaIsec;
        private Label InertiaIsec;
    }
}
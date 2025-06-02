namespace MathQuiz
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
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            label1 = new Label();
            equationLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            numericAnswer = new NumericUpDown();
            continueButton = new Button();
            buttonCont = new Button();
            questionLabel = new Label();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericAnswer).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.Location = new Point(266, 9);
            timeLabel.Margin = new Padding(0, 0, 3, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(141, 5);
            label1.Name = "label1";
            label1.Size = new Size(122, 35);
            label1.TabIndex = 1;
            label1.Text = "Time Left:";
            // 
            // equationLabel
            // 
            equationLabel.Font = new Font("Segoe UI", 18F);
            equationLabel.Location = new Point(38, 70);
            equationLabel.Name = "equationLabel";
            equationLabel.Size = new Size(400, 45);
            equationLabel.TabIndex = 2;
            equationLabel.Text = "?";
            equationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 165);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(109, 150);
            label3.Name = "label3";
            label3.Size = new Size(101, 35);
            label3.TabIndex = 4;
            label3.Text = "Answer:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericAnswer
            // 
            numericAnswer.Font = new Font("Segoe UI", 14F);
            numericAnswer.Location = new Point(216, 151);
            numericAnswer.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericAnswer.Minimum = new decimal(new int[] { 99999, 0, 0, int.MinValue });
            numericAnswer.Name = "numericAnswer";
            numericAnswer.Size = new Size(150, 39);
            numericAnswer.TabIndex = 5;
            numericAnswer.ThousandsSeparator = true;
            // 
            // continueButton
            // 
            continueButton.Font = new Font("Segoe UI", 14F);
            continueButton.Location = new Point(141, 228);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(205, 60);
            continueButton.TabIndex = 6;
            continueButton.Text = "Start the Quiz!";
            continueButton.UseVisualStyleBackColor = true;
            // 
            // buttonCont
            // 
            buttonCont.Font = new Font("Segoe UI", 14F);
            buttonCont.Location = new Point(125, 228);
            buttonCont.Name = "buttonCont";
            buttonCont.Size = new Size(224, 60);
            buttonCont.TabIndex = 6;
            buttonCont.Text = "Start the Quiz!";
            buttonCont.UseVisualStyleBackColor = true;
            buttonCont.Click += buttonCont_Click;
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Font = new Font("Segoe UI", 15F);
            questionLabel.ImageAlign = ContentAlignment.TopLeft;
            questionLabel.Location = new Point(12, 5);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(54, 35);
            questionLabel.TabIndex = 7;
            questionLabel.Text = "Q 0";
            questionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 349);
            Controls.Add(questionLabel);
            Controls.Add(buttonCont);
            Controls.Add(continueButton);
            Controls.Add(numericAnswer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(equationLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Math Quiz";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericAnswer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label equationLabel;
        private Label label2;
        private Label label3;
        private NumericUpDown numericAnswer;
        private Button continueButton;
        private Button buttonCont;
        private Label questionLabel;
        private System.Windows.Forms.Timer timer;
    }
}

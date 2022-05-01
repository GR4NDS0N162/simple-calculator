namespace SimpleCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.CommaButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.DevisionButton = new System.Windows.Forms.Button();
            this.RBracketButton = new System.Windows.Forms.Button();
            this.LBracketButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.MainExpression = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PowButton = new System.Windows.Forms.Button();
            this.InverseButton = new System.Windows.Forms.Button();
            this.BkspButton = new System.Windows.Forms.Button();
            this.SummaryExpression = new System.Windows.Forms.TextBox();
            this.CountBracket = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.BackColor = System.Drawing.Color.White;
            this.PlusMinusButton.FlatAppearance.BorderSize = 0;
            this.PlusMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusMinusButton.ForeColor = System.Drawing.Color.Black;
            this.PlusMinusButton.Location = new System.Drawing.Point(13, 559);
            this.PlusMinusButton.Margin = new System.Windows.Forms.Padding(1);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(112, 80);
            this.PlusMinusButton.TabIndex = 0;
            this.PlusMinusButton.TabStop = false;
            this.PlusMinusButton.Text = "+/-";
            this.PlusMinusButton.UseVisualStyleBackColor = false;
            this.PlusMinusButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.PlusMinusButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlusMinusButton_MouseClick);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.White;
            this.ZeroButton.FlatAppearance.BorderSize = 0;
            this.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZeroButton.ForeColor = System.Drawing.Color.Black;
            this.ZeroButton.Location = new System.Drawing.Point(127, 559);
            this.ZeroButton.Margin = new System.Windows.Forms.Padding(1);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(112, 80);
            this.ZeroButton.TabIndex = 1;
            this.ZeroButton.TabStop = false;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.ZeroButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ZeroButton_MouseClick);
            // 
            // CommaButton
            // 
            this.CommaButton.BackColor = System.Drawing.Color.White;
            this.CommaButton.FlatAppearance.BorderSize = 0;
            this.CommaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommaButton.ForeColor = System.Drawing.Color.Black;
            this.CommaButton.Location = new System.Drawing.Point(241, 559);
            this.CommaButton.Margin = new System.Windows.Forms.Padding(1);
            this.CommaButton.Name = "CommaButton";
            this.CommaButton.Size = new System.Drawing.Size(112, 80);
            this.CommaButton.TabIndex = 2;
            this.CommaButton.TabStop = false;
            this.CommaButton.Text = ",";
            this.CommaButton.UseVisualStyleBackColor = false;
            this.CommaButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.CommaButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CommaButton_MouseClick);
            // 
            // EqualButton
            // 
            this.EqualButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EqualButton.FlatAppearance.BorderSize = 0;
            this.EqualButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EqualButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqualButton.ForeColor = System.Drawing.Color.Black;
            this.EqualButton.Location = new System.Drawing.Point(355, 559);
            this.EqualButton.Margin = new System.Windows.Forms.Padding(1);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(112, 80);
            this.EqualButton.TabIndex = 3;
            this.EqualButton.TabStop = false;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = false;
            this.EqualButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.EqualButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EqualButton_MouseClick);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.PlusButton.FlatAppearance.BorderSize = 0;
            this.PlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusButton.ForeColor = System.Drawing.Color.Black;
            this.PlusButton.Location = new System.Drawing.Point(355, 477);
            this.PlusButton.Margin = new System.Windows.Forms.Padding(1);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(112, 80);
            this.PlusButton.TabIndex = 7;
            this.PlusButton.TabStop = false;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.PlusButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlusButton_MouseClick);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.White;
            this.ThreeButton.FlatAppearance.BorderSize = 0;
            this.ThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThreeButton.ForeColor = System.Drawing.Color.Black;
            this.ThreeButton.Location = new System.Drawing.Point(241, 477);
            this.ThreeButton.Margin = new System.Windows.Forms.Padding(1);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(112, 80);
            this.ThreeButton.TabIndex = 6;
            this.ThreeButton.TabStop = false;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.ThreeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ThreeButton_MouseClick);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.White;
            this.TwoButton.FlatAppearance.BorderSize = 0;
            this.TwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TwoButton.ForeColor = System.Drawing.Color.Black;
            this.TwoButton.Location = new System.Drawing.Point(127, 477);
            this.TwoButton.Margin = new System.Windows.Forms.Padding(1);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(112, 80);
            this.TwoButton.TabIndex = 5;
            this.TwoButton.TabStop = false;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.TwoButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TwoButton_MouseClick);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.White;
            this.OneButton.FlatAppearance.BorderSize = 0;
            this.OneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneButton.ForeColor = System.Drawing.Color.Black;
            this.OneButton.Location = new System.Drawing.Point(13, 477);
            this.OneButton.Margin = new System.Windows.Forms.Padding(1);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(112, 80);
            this.OneButton.TabIndex = 4;
            this.OneButton.TabStop = false;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.OneButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OneButton_MouseClick);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.MultiplyButton.FlatAppearance.BorderSize = 0;
            this.MultiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplyButton.ForeColor = System.Drawing.Color.Black;
            this.MultiplyButton.Location = new System.Drawing.Point(355, 313);
            this.MultiplyButton.Margin = new System.Windows.Forms.Padding(1);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(112, 80);
            this.MultiplyButton.TabIndex = 15;
            this.MultiplyButton.TabStop = false;
            this.MultiplyButton.Text = "×";
            this.MultiplyButton.UseVisualStyleBackColor = false;
            this.MultiplyButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.MultiplyButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MultiplyButton_MouseClick);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.White;
            this.NineButton.FlatAppearance.BorderSize = 0;
            this.NineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NineButton.ForeColor = System.Drawing.Color.Black;
            this.NineButton.Location = new System.Drawing.Point(241, 313);
            this.NineButton.Margin = new System.Windows.Forms.Padding(1);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(112, 80);
            this.NineButton.TabIndex = 14;
            this.NineButton.TabStop = false;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.NineButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NineButton_MouseClick);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.White;
            this.EightButton.FlatAppearance.BorderSize = 0;
            this.EightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EightButton.ForeColor = System.Drawing.Color.Black;
            this.EightButton.Location = new System.Drawing.Point(127, 313);
            this.EightButton.Margin = new System.Windows.Forms.Padding(1);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(112, 80);
            this.EightButton.TabIndex = 13;
            this.EightButton.TabStop = false;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.EightButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EightButton_MouseClick);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.White;
            this.SevenButton.FlatAppearance.BorderSize = 0;
            this.SevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SevenButton.ForeColor = System.Drawing.Color.Black;
            this.SevenButton.Location = new System.Drawing.Point(13, 313);
            this.SevenButton.Margin = new System.Windows.Forms.Padding(1);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(112, 80);
            this.SevenButton.TabIndex = 12;
            this.SevenButton.TabStop = false;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.SevenButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SevenButton_MouseClick);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.MinusButton.FlatAppearance.BorderSize = 0;
            this.MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusButton.ForeColor = System.Drawing.Color.Black;
            this.MinusButton.Location = new System.Drawing.Point(355, 395);
            this.MinusButton.Margin = new System.Windows.Forms.Padding(1);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(112, 80);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.TabStop = false;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.MinusButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MinusButton_MouseClick);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.White;
            this.SixButton.FlatAppearance.BorderSize = 0;
            this.SixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SixButton.ForeColor = System.Drawing.Color.Black;
            this.SixButton.Location = new System.Drawing.Point(241, 395);
            this.SixButton.Margin = new System.Windows.Forms.Padding(1);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(112, 80);
            this.SixButton.TabIndex = 10;
            this.SixButton.TabStop = false;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.SixButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SixButton_MouseClick);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.White;
            this.FiveButton.FlatAppearance.BorderSize = 0;
            this.FiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiveButton.ForeColor = System.Drawing.Color.Black;
            this.FiveButton.Location = new System.Drawing.Point(127, 395);
            this.FiveButton.Margin = new System.Windows.Forms.Padding(1);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(112, 80);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.TabStop = false;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.FiveButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FiveButton_MouseClick);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.White;
            this.FourButton.FlatAppearance.BorderSize = 0;
            this.FourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FourButton.ForeColor = System.Drawing.Color.Black;
            this.FourButton.Location = new System.Drawing.Point(13, 395);
            this.FourButton.Margin = new System.Windows.Forms.Padding(1);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(112, 80);
            this.FourButton.TabIndex = 8;
            this.FourButton.TabStop = false;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.FourButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FourButton_MouseClick);
            // 
            // DevisionButton
            // 
            this.DevisionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.DevisionButton.FlatAppearance.BorderSize = 0;
            this.DevisionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DevisionButton.ForeColor = System.Drawing.Color.Black;
            this.DevisionButton.Location = new System.Drawing.Point(355, 231);
            this.DevisionButton.Margin = new System.Windows.Forms.Padding(1);
            this.DevisionButton.Name = "DevisionButton";
            this.DevisionButton.Size = new System.Drawing.Size(112, 80);
            this.DevisionButton.TabIndex = 19;
            this.DevisionButton.TabStop = false;
            this.DevisionButton.Text = "/";
            this.DevisionButton.UseVisualStyleBackColor = false;
            this.DevisionButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.DevisionButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DevisionButton_MouseClick);
            // 
            // RBracketButton
            // 
            this.RBracketButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.RBracketButton.FlatAppearance.BorderSize = 0;
            this.RBracketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBracketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBracketButton.ForeColor = System.Drawing.Color.Black;
            this.RBracketButton.Location = new System.Drawing.Point(241, 231);
            this.RBracketButton.Margin = new System.Windows.Forms.Padding(1);
            this.RBracketButton.Name = "RBracketButton";
            this.RBracketButton.Size = new System.Drawing.Size(112, 80);
            this.RBracketButton.TabIndex = 21;
            this.RBracketButton.TabStop = false;
            this.RBracketButton.Text = ")";
            this.RBracketButton.UseVisualStyleBackColor = false;
            this.RBracketButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.RBracketButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RBracketButton_MouseClick);
            // 
            // LBracketButton
            // 
            this.LBracketButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.LBracketButton.FlatAppearance.BorderSize = 0;
            this.LBracketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBracketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBracketButton.ForeColor = System.Drawing.Color.Black;
            this.LBracketButton.Location = new System.Drawing.Point(127, 231);
            this.LBracketButton.Margin = new System.Windows.Forms.Padding(1);
            this.LBracketButton.Name = "LBracketButton";
            this.LBracketButton.Size = new System.Drawing.Size(112, 80);
            this.LBracketButton.TabIndex = 20;
            this.LBracketButton.TabStop = false;
            this.LBracketButton.Text = "(";
            this.LBracketButton.UseVisualStyleBackColor = false;
            this.LBracketButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.LBracketButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LBracketButton_MouseClick);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClearAllButton.FlatAppearance.BorderSize = 0;
            this.ClearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearAllButton.ForeColor = System.Drawing.Color.Black;
            this.ClearAllButton.Location = new System.Drawing.Point(241, 149);
            this.ClearAllButton.Margin = new System.Windows.Forms.Padding(1);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(112, 80);
            this.ClearAllButton.TabIndex = 22;
            this.ClearAllButton.TabStop = false;
            this.ClearAllButton.Text = "C";
            this.ClearAllButton.UseVisualStyleBackColor = false;
            this.ClearAllButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.ClearAllButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearAllButton_MouseClick);
            // 
            // MainExpression
            // 
            this.MainExpression.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.MainExpression.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MainExpression.ForeColor = System.Drawing.Color.Black;
            this.MainExpression.Location = new System.Drawing.Point(12, 76);
            this.MainExpression.Name = "MainExpression";
            this.MainExpression.ReadOnly = true;
            this.MainExpression.Size = new System.Drawing.Size(455, 44);
            this.MainExpression.TabIndex = 24;
            this.MainExpression.TabStop = false;
            this.MainExpression.Text = "0";
            this.MainExpression.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MainExpression.TextChanged += new System.EventHandler(this.MainExpression_TextChanged);
            this.MainExpression.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.ForeColor = System.Drawing.Color.Black;
            this.ClearButton.Location = new System.Drawing.Point(127, 149);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(1);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(112, 80);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.TabStop = false;
            this.ClearButton.Text = "CE";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.ClearButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearButton_MouseClick);
            // 
            // PowButton
            // 
            this.PowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.PowButton.FlatAppearance.BorderSize = 0;
            this.PowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PowButton.ForeColor = System.Drawing.Color.Black;
            this.PowButton.Location = new System.Drawing.Point(13, 149);
            this.PowButton.Margin = new System.Windows.Forms.Padding(1);
            this.PowButton.Name = "PowButton";
            this.PowButton.Size = new System.Drawing.Size(112, 80);
            this.PowButton.TabIndex = 17;
            this.PowButton.TabStop = false;
            this.PowButton.Text = "xⁿ";
            this.PowButton.UseVisualStyleBackColor = false;
            this.PowButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.PowButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PowButton_MouseClick);
            // 
            // InverseButton
            // 
            this.InverseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.InverseButton.FlatAppearance.BorderSize = 0;
            this.InverseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InverseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InverseButton.ForeColor = System.Drawing.Color.Black;
            this.InverseButton.Location = new System.Drawing.Point(13, 231);
            this.InverseButton.Margin = new System.Windows.Forms.Padding(1);
            this.InverseButton.Name = "InverseButton";
            this.InverseButton.Size = new System.Drawing.Size(112, 80);
            this.InverseButton.TabIndex = 18;
            this.InverseButton.TabStop = false;
            this.InverseButton.Text = "1/x";
            this.InverseButton.UseVisualStyleBackColor = false;
            this.InverseButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.InverseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InverseButton_MouseClick);
            // 
            // BkspButton
            // 
            this.BkspButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.BkspButton.FlatAppearance.BorderSize = 0;
            this.BkspButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BkspButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BkspButton.ForeColor = System.Drawing.Color.Black;
            this.BkspButton.Location = new System.Drawing.Point(355, 149);
            this.BkspButton.Margin = new System.Windows.Forms.Padding(1);
            this.BkspButton.Name = "BkspButton";
            this.BkspButton.Size = new System.Drawing.Size(112, 80);
            this.BkspButton.TabIndex = 23;
            this.BkspButton.TabStop = false;
            this.BkspButton.Text = "⌫";
            this.BkspButton.UseVisualStyleBackColor = false;
            this.BkspButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.BkspButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BkspButton_MouseClick);
            // 
            // SummaryExpression
            // 
            this.SummaryExpression.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.SummaryExpression.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SummaryExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SummaryExpression.ForeColor = System.Drawing.Color.Black;
            this.SummaryExpression.Location = new System.Drawing.Point(12, 38);
            this.SummaryExpression.Name = "SummaryExpression";
            this.SummaryExpression.ReadOnly = true;
            this.SummaryExpression.Size = new System.Drawing.Size(455, 17);
            this.SummaryExpression.TabIndex = 25;
            this.SummaryExpression.TabStop = false;
            this.SummaryExpression.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SummaryExpression.TextChanged += new System.EventHandler(this.SummaryExpression_TextChanged);
            this.SummaryExpression.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            // 
            // CountBracket
            // 
            this.CountBracket.AutoSize = true;
            this.CountBracket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.CountBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CountBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.CountBracket.ForeColor = System.Drawing.Color.Black;
            this.CountBracket.Location = new System.Drawing.Point(185, 274);
            this.CountBracket.Margin = new System.Windows.Forms.Padding(1);
            this.CountBracket.Name = "CountBracket";
            this.CountBracket.Size = new System.Drawing.Size(0, 22);
            this.CountBracket.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(479, 649);
            this.Controls.Add(this.CountBracket);
            this.Controls.Add(this.SummaryExpression);
            this.Controls.Add(this.BkspButton);
            this.Controls.Add(this.InverseButton);
            this.Controls.Add(this.PowButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.MainExpression);
            this.Controls.Add(this.DevisionButton);
            this.Controls.Add(this.RBracketButton);
            this.Controls.Add(this.LBracketButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.CommaButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.PlusMinusButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlusMinusButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button CommaButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button DevisionButton;
        private System.Windows.Forms.Button RBracketButton;
        private System.Windows.Forms.Button LBracketButton;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.TextBox MainExpression;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button PowButton;
        private System.Windows.Forms.Button InverseButton;
        private System.Windows.Forms.Button BkspButton;
        private System.Windows.Forms.TextBox SummaryExpression;
		private System.Windows.Forms.Label CountBracket;
	}
}


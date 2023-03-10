namespace System_5
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
            listView1 = new ListView();
            listView2 = new ListView();
            listView3 = new ListView();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.Location = new Point(12, 35);
            listView1.Name = "listView1";
            listView1.Size = new Size(247, 354);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.BorderStyle = BorderStyle.FixedSingle;
            listView2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            listView2.Location = new Point(278, 35);
            listView2.Name = "listView2";
            listView2.Size = new Size(247, 354);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            listView3.BorderStyle = BorderStyle.FixedSingle;
            listView3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            listView3.Location = new Point(541, 35);
            listView3.Name = "listView3";
            listView3.Size = new Size(247, 354);
            listView3.TabIndex = 2;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.MouseDoubleClick += CreatedListbox_MouseDoubleClick;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.CausesValidation = false;
            numericUpDown1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.ImeMode = ImeMode.Off;
            numericUpDown1.Location = new Point(12, 395);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(165, 39);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Enabled = false;
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("SimSun-ExtB", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(541, 395);
            button1.Name = "button1";
            button1.Size = new Size(247, 45);
            button1.TabIndex = 4;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 2);
            label1.Name = "label1";
            label1.Size = new Size(169, 30);
            label1.TabIndex = 5;
            label1.Text = "Working Threads";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(318, 2);
            label2.Name = "label2";
            label2.Size = new Size(163, 30);
            label2.TabIndex = 6;
            label2.Text = "Waiting Threads";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(586, 2);
            label3.Name = "label3";
            label3.Size = new Size(164, 30);
            label3.TabIndex = 7;
            label3.Text = "Created Threads";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(listView1);
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ListView listView2;
        private ListView listView3;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
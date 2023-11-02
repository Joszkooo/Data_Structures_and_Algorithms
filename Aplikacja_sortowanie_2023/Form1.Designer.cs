namespace Sortowania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txt_box1_liczby = new TextBox();
            btn1_bubble = new Button();
            btn2_select = new Button();
            btn3_insert = new Button();
            btn4_merge = new Button();
            btn5_quick = new Button();
            Choose_side = new CheckBox();
            txt_box2_wynik = new TextBox();
            nup1_jaki_zakres = new NumericUpDown();
            btn6_generuj = new Button();
            label1_czas = new Label();
            label2_time = new Label();
            ((System.ComponentModel.ISupportInitialize)nup1_jaki_zakres).BeginInit();
            SuspendLayout();
            // 
            // txt_box1_liczby
            // 
            txt_box1_liczby.Location = new Point(15, 34);
            txt_box1_liczby.Name = "txt_box1_liczby";
            txt_box1_liczby.Size = new Size(653, 23);
            txt_box1_liczby.TabIndex = 0;
            txt_box1_liczby.TextChanged += txt_box1_liczby_TextChanged;
            // 
            // btn1_bubble
            // 
            btn1_bubble.Location = new Point(15, 857);
            btn1_bubble.Name = "btn1_bubble";
            btn1_bubble.Size = new Size(338, 146);
            btn1_bubble.TabIndex = 1;
            btn1_bubble.Text = "Bubble Sort";
            btn1_bubble.UseVisualStyleBackColor = true;
            btn1_bubble.Click += btn1_bubble_Click;
            // 
            // btn2_select
            // 
            btn2_select.Location = new Point(359, 857);
            btn2_select.Name = "btn2_select";
            btn2_select.Size = new Size(338, 146);
            btn2_select.TabIndex = 2;
            btn2_select.Text = "Select Sort";
            btn2_select.UseVisualStyleBackColor = true;
            btn2_select.Click += btn2_select_Click;
            // 
            // btn3_insert
            // 
            btn3_insert.Location = new Point(703, 857);
            btn3_insert.Name = "btn3_insert";
            btn3_insert.Size = new Size(338, 146);
            btn3_insert.TabIndex = 3;
            btn3_insert.Text = "Insert Sort";
            btn3_insert.UseVisualStyleBackColor = true;
            btn3_insert.Click += btn3_insert_Click;
            // 
            // btn4_merge
            // 
            btn4_merge.Location = new Point(1047, 857);
            btn4_merge.Name = "btn4_merge";
            btn4_merge.Size = new Size(338, 146);
            btn4_merge.TabIndex = 4;
            btn4_merge.Text = "Merge Sort";
            btn4_merge.UseVisualStyleBackColor = true;
            btn4_merge.Click += btn4_merge_Click;
            // 
            // btn5_quick
            // 
            btn5_quick.Location = new Point(1391, 857);
            btn5_quick.Name = "btn5_quick";
            btn5_quick.Size = new Size(338, 146);
            btn5_quick.TabIndex = 5;
            btn5_quick.Text = "Quick sort";
            btn5_quick.UseVisualStyleBackColor = true;
            btn5_quick.Click += btn5_quick_Click;
            // 
            // Choose_side
            // 
            Choose_side.AutoSize = true;
            Choose_side.BackColor = SystemColors.ActiveBorder;
            Choose_side.Location = new Point(959, 43);
            Choose_side.Name = "Choose_side";
            Choose_side.Size = new Size(15, 14);
            Choose_side.TabIndex = 6;
            Choose_side.UseVisualStyleBackColor = false;
            Choose_side.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txt_box2_wynik
            // 
            txt_box2_wynik.Location = new Point(15, 436);
            txt_box2_wynik.Name = "txt_box2_wynik";
            txt_box2_wynik.Size = new Size(653, 23);
            txt_box2_wynik.TabIndex = 7;
            txt_box2_wynik.TextChanged += txt_box2_wynik_TextChanged;
            // 
            // nup1_jaki_zakres
            // 
            nup1_jaki_zakres.Location = new Point(1159, 34);
            nup1_jaki_zakres.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            nup1_jaki_zakres.Name = "nup1_jaki_zakres";
            nup1_jaki_zakres.Size = new Size(653, 23);
            nup1_jaki_zakres.TabIndex = 8;
            nup1_jaki_zakres.ValueChanged += nup1_jaki_zakres_ValueChanged;
            // 
            // btn6_generuj
            // 
            btn6_generuj.Location = new Point(1337, 400);
            btn6_generuj.Name = "btn6_generuj";
            btn6_generuj.Size = new Size(327, 93);
            btn6_generuj.TabIndex = 9;
            btn6_generuj.Text = "Generuj";
            btn6_generuj.UseVisualStyleBackColor = true;
            btn6_generuj.Click += btn6_generuj_Click;
            // 
            // label1_czas
            // 
            label1_czas.AutoSize = true;
            label1_czas.Location = new Point(1351, 535);
            label1_czas.Name = "label1_czas";
            label1_czas.Size = new Size(34, 15);
            label1_czas.TabIndex = 10;
            label1_czas.Text = "Czas:";
            label1_czas.Click += label1_czas_Click;
            // 
            // label2_time
            // 
            label2_time.AutoSize = true;
            label2_time.Location = new Point(1454, 535);
            label2_time.Name = "label2_time";
            label2_time.Size = new Size(43, 15);
            label2_time.TabIndex = 11;
            label2_time.Text = "............";
            label2_time.Click += label2_time_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1824, 1015);
            Controls.Add(label2_time);
            Controls.Add(label1_czas);
            Controls.Add(btn6_generuj);
            Controls.Add(nup1_jaki_zakres);
            Controls.Add(txt_box2_wynik);
            Controls.Add(Choose_side);
            Controls.Add(btn5_quick);
            Controls.Add(btn4_merge);
            Controls.Add(btn3_insert);
            Controls.Add(btn2_select);
            Controls.Add(btn1_bubble);
            Controls.Add(txt_box1_liczby);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nup1_jaki_zakres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_box1_liczby;
        private Button btn1_bubble;
        private Button btn2_select;
        private Button btn3_insert;
        private Button btn4_merge;
        private Button btn5_quick;
        private CheckBox Choose_side;
        private TextBox txt_box2_wynik;
        private NumericUpDown nup1_jaki_zakres;
        private Button btn6_generuj;
        private Label label1_czas;
        private Label label2_time;
    }
}
namespace wezly
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
            btn_make_node = new Button();
            btn2_wezel2 = new Button();
            SuspendLayout();
            // 
            // btn_make_node
            // 
            btn_make_node.Location = new Point(185, 277);
            btn_make_node.Name = "btn_make_node";
            btn_make_node.Size = new Size(181, 62);
            btn_make_node.TabIndex = 0;
            btn_make_node.Text = "1";
            btn_make_node.UseVisualStyleBackColor = true;
            btn_make_node.Click += btn_make_node_Click;
            // 
            // btn2_wezel2
            // 
            btn2_wezel2.Location = new Point(427, 277);
            btn2_wezel2.Name = "btn2_wezel2";
            btn2_wezel2.Size = new Size(181, 62);
            btn2_wezel2.TabIndex = 1;
            btn2_wezel2.Text = "2";
            btn2_wezel2.UseVisualStyleBackColor = true;
            btn2_wezel2.Click += btn2_wezel2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn2_wezel2);
            Controls.Add(btn_make_node);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_make_node;
        private Button btn2_wezel2;
    }
}
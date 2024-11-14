
namespace dolgozat1
{
    partial class Form1
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
            this.tree = new System.Windows.Forms.PictureBox();
            this.tree1 = new System.Windows.Forms.PictureBox();
            this.men1 = new System.Windows.Forms.PictureBox();
            this.men2 = new System.Windows.Forms.PictureBox();
            this.basket = new System.Windows.Forms.PictureBox();
            this.basket1 = new System.Windows.Forms.PictureBox();
            this.men = new System.Windows.Forms.PictureBox();
            this.apple = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.men1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.men2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.men)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).BeginInit();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.Location = new System.Drawing.Point(26, 28);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(172, 136);
            this.tree.TabIndex = 0;
            this.tree.TabStop = false;
            // 
            // tree1
            // 
            this.tree1.Location = new System.Drawing.Point(84, 162);
            this.tree1.Name = "tree1";
            this.tree1.Size = new System.Drawing.Size(52, 213);
            this.tree1.TabIndex = 1;
            this.tree1.TabStop = false;
            // 
            // men1
            // 
            this.men1.Location = new System.Drawing.Point(273, 233);
            this.men1.Name = "men1";
            this.men1.Size = new System.Drawing.Size(26, 142);
            this.men1.TabIndex = 2;
            this.men1.TabStop = false;
            // 
            // men2
            // 
            this.men2.Location = new System.Drawing.Point(225, 271);
            this.men2.Name = "men2";
            this.men2.Size = new System.Drawing.Size(60, 19);
            this.men2.TabIndex = 3;
            this.men2.TabStop = false;
            // 
            // basket
            // 
            this.basket.Location = new System.Drawing.Point(410, 335);
            this.basket.Name = "basket";
            this.basket.Size = new System.Drawing.Size(81, 40);
            this.basket.TabIndex = 4;
            this.basket.TabStop = false;
            // 
            // basket1
            // 
            this.basket1.Location = new System.Drawing.Point(444, 297);
            this.basket1.Name = "basket1";
            this.basket1.Size = new System.Drawing.Size(14, 38);
            this.basket1.TabIndex = 5;
            this.basket1.TabStop = false;
            // 
            // men
            // 
            this.men.Location = new System.Drawing.Point(258, 187);
            this.men.Name = "men";
            this.men.Size = new System.Drawing.Size(51, 50);
            this.men.TabIndex = 6;
            this.men.TabStop = false;
            // 
            // apple
            // 
            this.apple.Location = new System.Drawing.Point(157, 187);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(17, 19);
            this.apple.TabIndex = 7;
            this.apple.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gyűjtött almák száma:";
            this.label1.Move += new System.EventHandler(this.Form1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kosár teherbírása:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nagyobb kosár: \r\n    (+5 alma)\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gyorsabb szedés:\r\n    (-1 ütés)\r\n\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "10 alma";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "30 alma";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apple);
            this.Controls.Add(this.men);
            this.Controls.Add(this.basket1);
            this.Controls.Add(this.basket);
            this.Controls.Add(this.men2);
            this.Controls.Add(this.men1);
            this.Controls.Add(this.tree1);
            this.Controls.Add(this.tree);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.men1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.men2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.men)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tree;
        private System.Windows.Forms.PictureBox tree1;
        private System.Windows.Forms.PictureBox men1;
        private System.Windows.Forms.PictureBox men2;
        private System.Windows.Forms.PictureBox basket;
        private System.Windows.Forms.PictureBox basket1;
        private System.Windows.Forms.PictureBox men;
        private System.Windows.Forms.PictureBox apple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


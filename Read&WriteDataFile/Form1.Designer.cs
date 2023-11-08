namespace Read_WriteDataFile
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFavFood = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtFavDrink = new System.Windows.Forms.TextBox();
            this.txtFavColor = new System.Windows.Forms.TextBox();
            this.txtFavAnimal = new System.Windows.Forms.TextBox();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnSave.Location = new System.Drawing.Point(58, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(265, 62);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("SimSun", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Favorite food: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFavFood
            // 
            this.txtFavFood.Font = new System.Drawing.Font("SimSun", 12F);
            this.txtFavFood.Location = new System.Drawing.Point(348, 6);
            this.txtFavFood.Name = "txtFavFood";
            this.txtFavFood.Size = new System.Drawing.Size(265, 44);
            this.txtFavFood.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("SimSun", 12F);
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Favorite beverage: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("SimSun", 12F);
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Favorite color: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("SimSun", 12F);
            this.label4.Location = new System.Drawing.Point(43, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Favorite animal: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnRead.Location = new System.Drawing.Point(348, 224);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(265, 62);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "&Read";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // txtFavDrink
            // 
            this.txtFavDrink.Font = new System.Drawing.Font("SimSun", 12F);
            this.txtFavDrink.Location = new System.Drawing.Point(348, 59);
            this.txtFavDrink.Name = "txtFavDrink";
            this.txtFavDrink.Size = new System.Drawing.Size(265, 44);
            this.txtFavDrink.TabIndex = 7;
            // 
            // txtFavColor
            // 
            this.txtFavColor.Font = new System.Drawing.Font("SimSun", 12F);
            this.txtFavColor.Location = new System.Drawing.Point(348, 109);
            this.txtFavColor.Name = "txtFavColor";
            this.txtFavColor.Size = new System.Drawing.Size(265, 44);
            this.txtFavColor.TabIndex = 8;
            // 
            // txtFavAnimal
            // 
            this.txtFavAnimal.Font = new System.Drawing.Font("SimSun", 12F);
            this.txtFavAnimal.Location = new System.Drawing.Point(348, 159);
            this.txtFavAnimal.Name = "txtFavAnimal";
            this.txtFavAnimal.Size = new System.Drawing.Size(265, 44);
            this.txtFavAnimal.TabIndex = 9;
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // btnRandomize
            // 
            this.btnRandomize.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnRandomize.Location = new System.Drawing.Point(58, 305);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(555, 62);
            this.btnRandomize.TabIndex = 10;
            this.btnRandomize.Text = "&Randomize";
            this.btnRandomize.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 447);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.txtFavAnimal);
            this.Controls.Add(this.txtFavColor);
            this.Controls.Add(this.txtFavDrink);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFavFood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "My Favorite";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFavFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtFavDrink;
        private System.Windows.Forms.TextBox txtFavColor;
        private System.Windows.Forms.TextBox txtFavAnimal;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button btnRandomize;
    }
}


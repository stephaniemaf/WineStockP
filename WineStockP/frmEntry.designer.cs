
namespace WineShop
{
    partial class frmEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnterShop = new System.Windows.Forms.Button();
            this.btnSearchWines = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vladimir Script", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chateau Du Vin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vladimir Script", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wine Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vladimir Script", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search Wines";
            // 
            // btnEnterShop
            // 
            this.btnEnterShop.Location = new System.Drawing.Point(363, 150);
            this.btnEnterShop.Name = "btnEnterShop";
            this.btnEnterShop.Size = new System.Drawing.Size(110, 30);
            this.btnEnterShop.TabIndex = 3;
            this.btnEnterShop.Text = "Enter";
            this.btnEnterShop.UseVisualStyleBackColor = true;
            this.btnEnterShop.Click += new System.EventHandler(this.btnEnterShop_Click);
            // 
            // btnSearchWines
            // 
            this.btnSearchWines.Location = new System.Drawing.Point(363, 248);
            this.btnSearchWines.Name = "btnSearchWines";
            this.btnSearchWines.Size = new System.Drawing.Size(110, 30);
            this.btnSearchWines.TabIndex = 4;
            this.btnSearchWines.Text = "Enter";
            this.btnSearchWines.UseVisualStyleBackColor = true;
            this.btnSearchWines.Click += new System.EventHandler(this.btnEnterclub_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(630, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchWines);
            this.Controls.Add(this.btnEnterShop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entry Form";
            this.Load += new System.EventHandler(this.frmEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnterShop;
        private System.Windows.Forms.Button btnSearchWines;
        private System.Windows.Forms.Button btnExit;
    }
}


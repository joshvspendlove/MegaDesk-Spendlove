namespace MegaDesk_Spendlove
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addQuoteBtn = new System.Windows.Forms.Button();
            this.viewQuotesBtn = new System.Windows.Forms.Button();
            this.searchQuoteBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addQuoteBtn
            // 
            this.addQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteBtn.Location = new System.Drawing.Point(12, 12);
            this.addQuoteBtn.Name = "addQuoteBtn";
            this.addQuoteBtn.Size = new System.Drawing.Size(150, 50);
            this.addQuoteBtn.TabIndex = 0;
            this.addQuoteBtn.Text = "&Add New Quote";
            this.addQuoteBtn.UseVisualStyleBackColor = true;
            this.addQuoteBtn.Click += new System.EventHandler(this.addQuoteBtn_Click);
            // 
            // viewQuotesBtn
            // 
            this.viewQuotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuotesBtn.Location = new System.Drawing.Point(12, 68);
            this.viewQuotesBtn.Name = "viewQuotesBtn";
            this.viewQuotesBtn.Size = new System.Drawing.Size(150, 50);
            this.viewQuotesBtn.TabIndex = 1;
            this.viewQuotesBtn.Text = "&View Quotes";
            this.viewQuotesBtn.UseVisualStyleBackColor = true;
            this.viewQuotesBtn.Click += new System.EventHandler(this.viewQuotesBtn_Click);
            // 
            // searchQuoteBtn
            // 
            this.searchQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuoteBtn.Location = new System.Drawing.Point(12, 124);
            this.searchQuoteBtn.Name = "searchQuoteBtn";
            this.searchQuoteBtn.Size = new System.Drawing.Size(150, 50);
            this.searchQuoteBtn.TabIndex = 2;
            this.searchQuoteBtn.Text = "&Search Quotes";
            this.searchQuoteBtn.UseVisualStyleBackColor = true;
            this.searchQuoteBtn.Click += new System.EventHandler(this.searchQuoteBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(12, 180);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(150, 50);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.searchQuoteBtn);
            this.Controls.Add(this.viewQuotesBtn);
            this.Controls.Add(this.addQuoteBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "MegaDesk-Spendlove - Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuoteBtn;
        private System.Windows.Forms.Button viewQuotesBtn;
        private System.Windows.Forms.Button searchQuoteBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}


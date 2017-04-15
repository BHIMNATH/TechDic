namespace New
{
    partial class TechDic
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
            this.item = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // item
            // 
            this.item.AllowDrop = true;
            this.item.BackColor = System.Drawing.Color.LimeGreen;
            this.item.BeepOnError = true;
            this.item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item.HideSelection = false;
            this.item.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.item.Location = new System.Drawing.Point(39, 110);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(389, 40);
            this.item.TabIndex = 0;
            this.item.Text = "Enter Word";
            this.item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.item_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(458, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // view
            // 
            this.view.AutoSize = true;
            this.view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.view.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20.25F, System.Drawing.FontStyle.Bold);
            this.view.Location = new System.Drawing.Point(279, 280);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(0, 46);
            this.view.TabIndex = 2;
            // 
            // TechDic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(757, 390);
            this.Controls.Add(this.view);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.item);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TechDic";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechDic";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TechDic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox item;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label view;


    }
}


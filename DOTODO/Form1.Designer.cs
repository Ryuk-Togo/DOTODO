
namespace DOTODO
{
    partial class Today
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
            this.lbl_day = new System.Windows.Forms.Label();
            this.list_todo = new System.Windows.Forms.ListBox();
            this.txtDo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.list_do = new System.Windows.Forms.ListBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_day
            // 
            this.lbl_day.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_day.Font = new System.Drawing.Font("Meiryo UI", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_day.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbl_day.Location = new System.Drawing.Point(12, 9);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(358, 58);
            this.lbl_day.TabIndex = 0;
            this.lbl_day.Text = "6.10.2021 fri";
            this.lbl_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_todo
            // 
            this.list_todo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_todo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.list_todo.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.list_todo.ForeColor = System.Drawing.Color.GreenYellow;
            this.list_todo.FormattingEnabled = true;
            this.list_todo.ItemHeight = 23;
            this.list_todo.Location = new System.Drawing.Point(12, 88);
            this.list_todo.Name = "list_todo";
            this.list_todo.Size = new System.Drawing.Size(358, 326);
            this.list_todo.TabIndex = 1;
            // 
            // txtDo
            // 
            this.txtDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDo.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDo.ForeColor = System.Drawing.Color.White;
            this.txtDo.Location = new System.Drawing.Point(12, 661);
            this.txtDo.Name = "txtDo";
            this.txtDo.Size = new System.Drawing.Size(358, 30);
            this.txtDo.TabIndex = 4;
            this.txtDo.Text = "aaa";
            this.txtDo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDo_KeyDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(12, 697);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // list_do
            // 
            this.list_do.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_do.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.list_do.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.list_do.ForeColor = System.Drawing.Color.GreenYellow;
            this.list_do.FormattingEnabled = true;
            this.list_do.ItemHeight = 23;
            this.list_do.Location = new System.Drawing.Point(12, 421);
            this.list_do.Name = "list_do";
            this.list_do.Size = new System.Drawing.Size(358, 234);
            this.list_do.TabIndex = 6;
            this.list_do.DoubleClick += new System.EventHandler(this.list_do_DoubleClick);
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHide.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHide.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnHide.Location = new System.Drawing.Point(231, 697);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(139, 38);
            this.btnHide.TabIndex = 7;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // Today
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(382, 747);
            this.ControlBox = false;
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.list_do);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDo);
            this.Controls.Add(this.list_todo);
            this.Controls.Add(this.lbl_day);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Today";
            this.Opacity = 0.8D;
            this.Load += new System.EventHandler(this.Today_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.ListBox list_todo;
        private System.Windows.Forms.TextBox txtDo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox list_do;
        private System.Windows.Forms.Button btnHide;
    }
}


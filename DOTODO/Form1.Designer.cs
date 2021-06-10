
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
            this.link_input_do = new System.Windows.Forms.LinkLabel();
            this.link_time_todo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_day
            // 
            this.lbl_day.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_day.Font = new System.Drawing.Font("Meiryo UI", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_day.ForeColor = System.Drawing.Color.White;
            this.lbl_day.Location = new System.Drawing.Point(12, 9);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(306, 58);
            this.lbl_day.TabIndex = 0;
            this.lbl_day.Text = "6.10.2021 fri";
            this.lbl_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_todo
            // 
            this.list_todo.FormattingEnabled = true;
            this.list_todo.ItemHeight = 15;
            this.list_todo.Location = new System.Drawing.Point(12, 88);
            this.list_todo.Name = "list_todo";
            this.list_todo.Size = new System.Drawing.Size(306, 544);
            this.list_todo.TabIndex = 1;
            // 
            // link_input_do
            // 
            this.link_input_do.AutoSize = true;
            this.link_input_do.Location = new System.Drawing.Point(262, 673);
            this.link_input_do.Name = "link_input_do";
            this.link_input_do.Size = new System.Drawing.Size(56, 15);
            this.link_input_do.TabIndex = 2;
            this.link_input_do.TabStop = true;
            this.link_input_do.Text = "Input do";
            this.link_input_do.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // link_time_todo
            // 
            this.link_time_todo.AutoSize = true;
            this.link_time_todo.Location = new System.Drawing.Point(239, 700);
            this.link_time_todo.Name = "link_time_todo";
            this.link_time_todo.Size = new System.Drawing.Size(79, 15);
            this.link_time_todo.TabIndex = 3;
            this.link_time_todo.TabStop = true;
            this.link_time_todo.Text = "Setting todo";
            this.link_time_todo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Today
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(330, 747);
            this.Controls.Add(this.link_time_todo);
            this.Controls.Add(this.link_input_do);
            this.Controls.Add(this.list_todo);
            this.Controls.Add(this.lbl_day);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Today";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.ListBox list_todo;
        private System.Windows.Forms.LinkLabel link_input_do;
        private System.Windows.Forms.LinkLabel link_time_todo;
    }
}


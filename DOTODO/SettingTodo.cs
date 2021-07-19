using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DOTODO
{
    public partial class SettingTodo : Form
    {
        string _doText = "";

        public SettingTodo()
        {
            InitializeComponent();
        }

        public SettingTodo(string doText)
        {
            InitializeComponent();
            _doText = doText;
                 
        }

        private void SettingTodo_Load(object sender, EventArgs e)
        {
            this.txtDo.Text = _doText;

            // Formのある画面を取得
            Screen screen = Screen.FromControl(this);

            // Formのサイズを画面サイズの1/5に設定
            this.Height = screen.Bounds.Height - 35;
            this.Top = 0;
            this.Left = screen.Bounds.Width - this.Width;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

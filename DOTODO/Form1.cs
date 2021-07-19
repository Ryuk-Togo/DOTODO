using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOTODO
{
    public partial class Today : Form
    {
        public Today()
        {
            InitializeComponent();
        }

        private void Today_Load(object sender, EventArgs e)
        {
            // Formのある画面を取得
            Screen screen = Screen.FromControl(this);

            // Formのサイズを画面サイズの1/5に設定
            this.Height = screen.Bounds.Height - 35;
            this.Top = 0;
            this.Left = screen.Bounds.Width - this.Width;

        }

        private void txtDo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter && this.txtDo.Text != "")
            {
                this.list_do.Items.Add(this.txtDo.Text);
                this.txtDo.Text = "";
            }
        }

        private void list_do_DoubleClick(object sender, EventArgs e)
        {
            SettingTodo setting = new SettingTodo(this.list_do.SelectedItem.ToString());
            setting.ShowDialog();

/*            CtrlTodo todo = new CtrlTodo(this.list_do.SelectedItem.ToString());
            todo.Show();
*/
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

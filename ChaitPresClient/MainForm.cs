using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChaitPresClient
{
    public partial class MainForm : Form
    {
        LobbyForm parent;
        public MainForm(LobbyForm parent)
        {
            InitializeComponent();

            this.parent = parent;
        }

        private void btn_backToLobby_Click(object sender, EventArgs e)
        {
            clear();
            this.Hide();
            parent.Show();
        }

        private void clear()
        {

        }
    }
}

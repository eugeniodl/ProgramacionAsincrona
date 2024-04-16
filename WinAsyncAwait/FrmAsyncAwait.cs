using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAsyncAwait
{
    public partial class FrmAsyncAwait : Form
    {
        public FrmAsyncAwait()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            loadingGIF.Visible = true;
            await EsperarAsync();
            loadingGIF.Visible = false;
        }

        private async Task EsperarAsync()
        {
            await Task.Delay(5000);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorNewForm
{
    public partial class frmInput : Form
    {

        

        // deklarasi tipe data untuk event 
        public delegate void CreateUpdateEventHandler(Calculator nilai);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnProcess;

        //inisialisasi field
        private Calculator nilai;

        // Constructor default
        public frmInput()
        {
            InitializeComponent();
        }

        public frmInput(string title)
            : this()
        {
            // ganti judul form
            this.Text = title;
        }


        private void btnProses_Click(object sender, EventArgs e)
        {
            //Calculator nilai = new Calculator();
            nilai = new Calculator();

            //menampung inlai input
            nilai.a  = Convert.ToInt16(txtNilai1.Text);
            nilai.b  = Convert.ToInt16(txtNilai2.Text);
            nilai.c = Convert.ToString(txtOperasi.Text);

            //panggil event
            OnProcess(nilai);


        }





    }
}

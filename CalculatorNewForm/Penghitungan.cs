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
    public partial class frmPenghitungan : Form
    {
        private int penjumlahan(int a, int b)
        {
            return a + b;
        }

        private int pengurangan(int a, int b)
        {
            return a - b;
        }

        private int perkalian(int a, int b)
        {
            return a * b;
        }

        private int pembagian(int a, int b)
        {
            return a / b;
        }

        //method event handler untuk merespon event OnProcess(nilai)
        private void frmInput_OnProcess(Calculator nilai)
        {
            if (nilai.c == "Penjumlahan")
            {

                lstHasil.Items.Add(string.Format("Hasil penjumlahan {0} + {1} = {2}", nilai.a, nilai.b, penjumlahan(nilai.a, nilai.b)));
            }


            else if (nilai.c == "Pengurangan")
                {

                    lstHasil.Items.Add(string.Format("Hasil pengurangan {0} - {1} = {2}", nilai.a, nilai.b, pengurangan(nilai.a, nilai.b)));
                }

            else if (nilai.c == "Perkalian")
            {

                lstHasil.Items.Add(string.Format("Hasil perkalian {0} * {1} = {2}", nilai.a, nilai.b, perkalian(nilai.a, nilai.b)));
            }



            else if (nilai.c == "Pembagian")
                {

                lstHasil.Items.Add(string.Format("Hasil pembagian {0} / {1} = {2}", nilai.a, nilai.b, pembagian(nilai.a, nilai.b)));
            }
        }

        // Constructor default
        public frmPenghitungan()
        {
            InitializeComponent();
        }

       

        private void btnHitung_Click(object sender, EventArgs e)
        {
            //objek form input
            frmInput datainput = new frmInput("Calculator");

            //pengaitan eventhandler onprocess dengan method frmInput_OnProcess
            datainput.OnProcess += frmInput_OnProcess;

            //memanggil form input
            datainput.ShowDialog();         
        }
    }
}

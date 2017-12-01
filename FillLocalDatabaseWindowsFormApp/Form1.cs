using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TseHn2017Application.AppCode.Context;
using TseHn2017Application.AppCode.Services;

namespace FillLocalDatabaseWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TseActasPresidenteDbContext())
                {
                    var service = new TseApiToLocalDbContext(context);
                    while (label2.Text != "18128")
                    {
                        label2.Text = service.ActasGuardadas.ToString();
                        service.InsertTseApiToLocalDataBase(Convert.ToInt32(label2.Text));
                    }

                    MessageBox.Show("Actas guardadas a la base de datos. Consulta en tu SQL SERVER");
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

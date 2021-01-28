using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask5
{
    public partial class Form1 : Form
    {
        private Entities entities;
        public Form1()
        {
            InitializeComponent();
            entities = new Entities();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           if(entities!=null)
            {
                entities.Tables.Load();
                dataGridView1.DataSource = entities.Tables.Local.ToBindingList();
            }
        }
    }
}

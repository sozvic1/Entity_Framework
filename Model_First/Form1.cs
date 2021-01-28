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

namespace Model_First
{
    public partial class Form1 : Form
    {
        private Model1Container entities;
        public Form1()
        {
            InitializeComponent();
            entities = new Model1Container();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (entities.PersonInfoes == null)
            {
                entities.PersonInfoes.Add(
                    new PersonInfo()
                    {
                        Age = 19,
                        FirstName = "Alex",
                        LastName = "asdas"
                    });
                entities.PersonInfoes.Add(
                         new PersonInfo()
                         {
                             Age = 32,
                             FirstName = "Ivan",
                             LastName = "Nassa"
                         });
                entities.SaveChanges();
            }
            

                entities.PersonInfoes.Load();
                dataGridView1.DataSource = entities.PersonInfoes.Local.ToBindingList();
            
        }
    }
}

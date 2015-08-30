using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void makeSound(Animal ananimal)
        {

            lstAnimal.Items.Add(ananimal.Speak());
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            Dog fluffy = new Dog("Fluffy");
            makeSound(fluffy);
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            Cat mrWhiskers = new Cat("Mr. Whiskers");
            makeSound(mrWhiskers);
        }
    }
}

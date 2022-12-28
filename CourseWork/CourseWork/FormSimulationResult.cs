using CourseWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work
{
    public partial class FormSimulationResult : Form
    {
        FormInputForSimulation formInputForSimulation;
        public FormSimulationResult(FormInputForSimulation owner)
        {
            InitializeComponent();
            formInputForSimulation = owner;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PrintData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInputForSimulation formInputForSimulation = new FormInputForSimulation();
            formInputForSimulation.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (formInputForSimulation.dataValidation() == false)
            {
                formInputForSimulation.Algoritm();
            }
            PrintData();
        }

        void PrintData ()
        {
            label14.Text = Convert.ToString(formInputForSimulation.passengerCount);
            label11.Text = Convert.ToString(formInputForSimulation.passengerCount - formInputForSimulation.uninvited_pas);
            label4.Text = Convert.ToString(formInputForSimulation.medium_time_on_checkpoint_enter);
            label6.Text = Convert.ToString(formInputForSimulation.medium_time_on_reseptions);
            label8.Text = Convert.ToString(formInputForSimulation.medium_time_on_checkpoint_boad_area);

            if (formInputForSimulation.medium_time_on_reseptions >= 5 && formInputForSimulation.medium_time_on_reseptions <= 10)
            {
                label5.Text = "Средняя";
            }
            else if (formInputForSimulation.medium_time_on_reseptions < 5)
            {
                label5.Text = "Низкая";
            }
            else if (formInputForSimulation.medium_time_on_reseptions > 10)
            {
                label5.Text = "Высокая";
            }
        }
    }
}

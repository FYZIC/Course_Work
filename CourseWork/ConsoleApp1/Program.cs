//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//// See https://aka.ms/new-console-template for more information


//namespace program
//{

//    public interface ICalculator
//    {
//        public int Calculate(int x, int y);
//    }

//    public interface ISummarizer
//    {
//        public int Summ(int x, int y);
//    }

//    internal class Calculator1 : ICalculator, ISummarizer
//    {
//        public int Calculate(int x, int y)
//        {
//            return x * y;
//        }

//        public int Summ(int x, int y)
//        {
//            return x + y;
//        }
//    }

//    internal class Calculator2 : ICalculator
//    {
//        public int Calculate(int x, int y)
//        {
//            return x - y;
//        }
//    }

//    public class Program
//    {
//        public static void Main()
//        {
//            List<ICalculator> list = new List<ICalculator>();
//            list.Add(new Calculator1());
//            list.Add(new Calculator2());
//            foreach (ICalculator i in list)
//                Console.WriteLine(i.Calculate(5, 7));

//            ISummarizer summarizer = new Calculator1();
//            Console.WriteLine(summarizer.Summ(5, 7));
//        }
//    }
//}

/////////////////////////
/////using CourseWork;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Course_Work
//{
//    public partial class FormInputForSimulation : Form
//    {
//        public int passengerCount = 0, uninvited_pas = 0;
//        public double medium_time_on_checkpoint_enter, medium_time_on_reseptions, medium_time_on_pas_control, medium_time_on_checkpoint_boad_area;
//        List<IPassengerService> queue = new List<IPassengerService>();

//        public FormInputForSimulation()
//        {
//            InitializeComponent();
//            maskedTextBoxPasCountFrom.Text = "0";
//            maskedTextBoxPasCountTo.Text = "0";
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {

//            if (dataValidation() == false)
//            {
//                Algoritm();

//                FormSimulationResult formSimulationResult = new FormSimulationResult(this);
//                formSimulationResult.Show();
//                this.Hide();
//            }
//        }

//        public bool dataValidation()
//        {
//            bool flag = true;
//            PassengerList passengerList = new PassengerList();

//            Сheckpoint checkpoint = new Сheckpoint();
//            passengerCount = passengerList.SetPassengersCount(Convert.ToInt32(maskedTextBoxPasCountFrom.Text), Convert.ToInt32(maskedTextBoxPasCountTo.Text));
//            if (maskedTextBoxEnteranceFrom.Text == "" || maskedTextBoxEnteranceTo.Text == "" || maskedTextBoxBoadingAreaCount.Text == "" || maskedTextBoxBoadingAreaFrom.Text == "" || maskedTextBoxBoadingAreaTo.Text == "" || maskedTextBoxEntercneckpoint.Text == "" || maskedTextBoxPasControlFrom.Text == "" || maskedTextBoxPasControlTo.Text == "" ||
//                maskedTextBoxPasCountFrom.Text == "" || maskedTextBoxPasCountTo.Text == "" || maskedTextBoxReseptionFrom.Text == "" || maskedTextBoxReseptions.Text == "" || maskedTextBoxReseptionTo.Text == "" || maskedTextBoxPassControl.Text == "")
//            {
//                MessageBox.Show("Заполнены не все поля");
//            }
//            else if (Convert.ToInt32(maskedTextBoxEnteranceFrom.Text) > Convert.ToInt32(maskedTextBoxEnteranceTo.Text))
//            {
//                MessageBox.Show("Неверно задан диапазон значений для времени обслуживания при входе в аэропорт");
//            }
//            else if (Convert.ToInt32(maskedTextBoxBoadingAreaFrom.Text) > Convert.ToInt32(maskedTextBoxBoadingAreaTo.Text))
//            {
//                MessageBox.Show("Неверно задан диапазон значений для времени обслуживания при входе в зону посадки");
//            }
//            else if (Convert.ToInt32(maskedTextBoxPasControlFrom.Text) > Convert.ToInt32(maskedTextBoxPasControlTo.Text))
//            {
//                MessageBox.Show("Неверно задан диапазон значений для времени прохождения паспортного контроля");
//            }
//            else if (Convert.ToInt32(maskedTextBoxPasCountFrom.Text) > Convert.ToInt32(maskedTextBoxPasCountTo.Text))
//            {
//                MessageBox.Show("Неверно задан диапазон значений для количества пассажиров");
//            }
//            else if (Convert.ToInt32(maskedTextBoxReseptionFrom.Text) > Convert.ToInt32(maskedTextBoxReseptionTo.Text))
//            {
//                MessageBox.Show("Неверно задан диапазон значений для времени обслуживания пассажира на стойке регистрации");
//            }
//            else flag = false;

//            return flag;
//        }

//        public void Algoritm()
//        {
//            uninvited_pas = 0;
//            PassengerList passengerList = new PassengerList();
//            List<Passenger> passengers = new List<Passenger>();

//            passengers = passengerList.NewPassengerList(Convert.ToInt32(maskedTextBoxPasCountFrom.Text), Convert.ToInt32(maskedTextBoxPasCountTo.Text), Convert.ToInt32(maskedTextBoxEnteranceFrom.Text), Convert.ToInt32(maskedTextBoxEnteranceFrom.Text), Convert.ToInt32(maskedTextBoxReseptionFrom.Text), Convert.ToInt32(maskedTextBoxReseptionTo.Text), Convert.ToInt32(maskedTextBoxBoadingAreaFrom.Text), Convert.ToInt32(maskedTextBoxBoadingAreaTo.Text), Convert.ToInt32(maskedTextBoxPasControlFrom.Text), Convert.ToInt32(maskedTextBoxPasControlTo.Text));
//            for (int i = 0; i < passengers.Count; i++)
//            {
//                if (passengers[i].willPassCheckpointEnter == false || passengers[i].willPassControl == false || passengers[i].willPassCheckpointBoadingArea == false) { uninvited_pas++; }
//                if (passengers[i].willPassCheckpointEnter == false) { passengers.Remove(passengers[i]); continue; }
//                if (passengers[i].willPassControl == false) { passengers.Remove(passengers[i]); continue; }
//                if (passengers[i].registration == false) { passengers.Remove(passengers[i]); continue; }
//            }

//            queue.Add(new CheckpointEnter());
//            queue.Add(new CheckpointRegistration());
//            queue.Add(new CheckpointPasControl());
//            queue.Add(new CheckpointBoadingArea());


//            medium_time_on_checkpoint_enter = queue[0].Queue(passengers, Convert.ToInt32(maskedTextBoxEntercneckpoint.Text), passengerList.count_passengers);
//            medium_time_on_reseptions = queue[1].Queue(passengers, Convert.ToInt32(maskedTextBoxReseptions.Text), passengerList.count_passengers);
//            medium_time_on_pas_control = queue[2].Queue(passengers, Convert.ToInt32(maskedTextBoxPassControl.Text), passengerList.count_passengers);
//            medium_time_on_checkpoint_boad_area = queue[3].Queue(passengers, Convert.ToInt32(maskedTextBoxBoadingAreaCount.Text), passengerList.count_passengers);

//        }
//    }
//}

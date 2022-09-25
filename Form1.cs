using System.Timers;

namespace DigitalCLock {
    public partial class Form1 : Form {


        public Form1() {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            lblStatus.Text = DateTime.Now.ToString("T");
        }

        private void Form1_Load(object sender, EventArgs e) {
            //timer1.Start();


            System.Timers.Timer timer2 = new System.Timers.Timer();
            timer2.Interval = 1000;
            timer2.Elapsed += Timer_Elapsed;
            timer2.Start();

        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
            Invoke(new MethodInvoker(delegate () {
                lblStatus.Text = DateTime.Now.ToString("T");

            }));
        }

    }
}
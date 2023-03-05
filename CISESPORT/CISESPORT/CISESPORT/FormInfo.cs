using System.Numerics;
using System.Xml.Linq;

namespace CISESPORT
{
    public partial class FormInfo : Form
    {
        private Player _newPlayer;
        public FormInfo()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tBname.Text;
            string lastname = tBlastname.Text;
            string studentid = tBstudentid.Text;
            string mail = tBmail.Text;
            string phone = tBphone.Text;
            string major = tBmajor.Text;
            string displayname = tBdisplayname.Text;
            int iAge = 0;
            try
            {
                string age = tBage.Text;
                iAge = Int32.Parse(age);
            }
            catch (FormatException ex)
            {
                //Do something if have some exception
                MessageBox.Show("คุณใส่ข้อมูลไม่ถูกต้อง");
                return;
            }

            _newPlayer = new Player(name, lastname, studentid, major,
                displayname, mail, phone, iAge);

            this.DialogResult = DialogResult.OK;
        }
        public Player getPlayer() { return _newPlayer; }
    }
    
}
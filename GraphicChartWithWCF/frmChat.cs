using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace GraphicChartWithWCF
{
    public partial class frmChat : Form
    {

        #region Singleton

        private static frmChat instance;

        public static frmChat GetInstanceOfThisForm()
        {
            if(instance == null)
                instance = new frmChat();

            return instance;
        }

        #endregion

        int lastLabelBottom = 0;

        public frmChat()
        {
            InitializeComponent();

            server.Join(txtUser.Text);

            instance = this;
        }

        private static InstanceContext context = new InstanceContext(new MyCallback());
        Proxy.ChatServiceClient server = new Proxy.ChatServiceClient(context);

        private void button1_Click(object sender, EventArgs e)
        {
            VerificaLimiteLabels();
            if(!string.IsNullOrEmpty(txtKeyboard.Text))
            {
                CreateLabelSender(txtKeyboard.Text);

                server.SendMesssage(txtKeyboard.Text);
            }
                
        }

        public void CreateLabelSender(string message)
        {
            TextBox text = new TextBox();
            text.BackColor = Color.FromArgb(88, 110, 115);
            text.ForeColor = Color.FromArgb(188, 234, 244);
            text.Location = new Point(0, lastLabelBottom + 10);
            text.MaximumSize = new Size(259, 120);
            text.Text = TrataMensagem(message);
            text.Multiline = true;
            text.ScrollBars = ScrollBars.None;

            AutoSizeTextBox(text);

            lastLabelBottom = text.Bottom;

            Chat.Controls.Add(text);
        }

        public void CreateLabelReceiver(string message)
        {
            TextBox text = new TextBox();
            text.BackColor = Color.FromArgb(90, 173, 191);
            text.ForeColor = Color.FromArgb(88, 110, 115);
            
            text.MaximumSize = new Size(259, 120);
            text.Text = TrataMensagem(message);
            text.Multiline = true;
            text.ScrollBars = ScrollBars.None;

            AutoSizeTextBox(text);

            text.Location = new Point(Chat.Width - text.Width - 3, lastLabelBottom + 10);

            lastLabelBottom = text.Bottom;

            Chat.Controls.Add(text);
        }

        private string TrataMensagem(string message)
        {
            string aux = "";

            for (int i = 0; i < message.Length; i++)
            {
                if (i%15 == 0)
                    aux += "\n";

                aux += message[i];
            }

            return aux;
        }

        private void AutoSizeTextBox(TextBox txt)
        {
            const int x = 0;
            const int y = 2;

            Size tamanho = TextRenderer.MeasureText(txt.Text, txt.Font);
            txt.ClientSize = new Size(tamanho.Width + x, tamanho.Height + y);
        }

        public void VerificaLimiteLabels()
        {
            if(lastLabelBottom >= 320)
            {
                Chat.Controls.Clear();
                
                lastLabelBottom = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            VerificaLimiteLabels();

            InstanceContext context = new InstanceContext(new MyCallback());
            Proxy.ChatServiceClient server = new Proxy.ChatServiceClient(context);
        }
    }

    public class MyCallback : Proxy.IChatServiceCallback
    {
        public void RecieveMessage(string user, string message)
        {
            frmChat chat = frmChat.GetInstanceOfThisForm();
            chat.VerificaLimiteLabels();
            chat.CreateLabelReceiver(message);
        }
    }
}

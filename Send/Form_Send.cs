using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Send
{
    public partial class Form_Send : Form
    {
        public Form_Send()
        {
            InitializeComponent();

            this.ExpressionList = new List<string>();
            this.ResultList = new List<string>();

            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
        }

        private void btnFileName_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = openFileDialog1.FileName;
                this.tbFileName.Text = fileName;

            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string FileName = this.tbFileName.Text;
            ReadFile(FileName);
            UpdatetbContent();
            this.tbFileName.Text = "";
        }

        private void btnReadTextBox_Click(object sender, EventArgs e)
        {
            ReadtbInput();
            UpdatetbContent();
            this.tbInput.Text = "";
        }

        private void btnValExpress_Click(object sender, EventArgs e)
        {
            if (tbContent.Text != "")
            {
                ChangeButton(false);
                this.bgWorker.RunWorkerAsync();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.ExpressionList = new List<string>();
            this.ResultList = new List<string>();
            
            this.tbFileName.Text = "";
            this.tbInput.Text = "";
            ChangeButton(true);

            UpdatetbContent();
            UpdatetbResult();
        }
        //
        //
        //

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //ResetMSMQ(ExpressionMSMQ);
            //ResetMSMQ(ResultMSMQ);
            foreach (string s in this.ExpressionList) {
                SendMSMQ(ExpressionMSMQ, s);
            }
            SendMSMQ(ExpressionMSMQ, "end");

            ReceiveMSMQ(ResultMSMQ);
        }

        private void SendMSMQ(string queueName, string myMess)
        {
            MessageQueue messQueue = null;
            if (!MessageQueue.Exists(queueName))
            {
                messQueue = MessageQueue.Create(queueName);
            }
            else
            {
                messQueue = new MessageQueue(queueName);
            }
            messQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
            messQueue.Send(myMess);
            messQueue.Close();
        }

        private void ReceiveMSMQ(string queueName)
        {
            MessageQueue messQueue = null;
            while (!MessageQueue.Exists(queueName)) { 
            }
            messQueue = new MessageQueue(queueName);
            messQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
            messQueue.ReceiveCompleted += MessQueue_ReceiveCompleted;
            messQueue.BeginReceive();
        }
        private void ResetMSMQ(string queueName)
        {
            MessageQueue messQueue = null;
            if (MessageQueue.Exists(queueName))
            {
                messQueue = new MessageQueue(queueName);
                messQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                MessageQueue.Delete(queueName);
                MessageQueue.Create(queueName);
            }

        }

            private void MessQueue_ReceiveCompleted(object sender, ReceiveCompletedEventArgs e)
        {
            MessageQueue mq = (MessageQueue)sender;
            System.Messaging.Message m = mq.EndReceive(e.AsyncResult);
            String result = (string)(m.Body);
            if (result == "end")
            {
                mq.Close();
                this.Invoke((Action)(() => this.UpdatetbResult()));
            }
            else
            {
                this.Invoke((Action)(() => this.ResultList.Add(result)));
                mq.BeginReceive();
            }

            return;
        }

        private void ReadFile(string pathFile)
        {

            if (File.Exists(pathFile))
            {
                this.ExpressionList.AddRange(File.ReadAllLines(pathFile).ToList());
            }
            else
            {
                MessageBox.Show("File khong ton tai");
            }
        }

        private void ReadtbInput()
        {

            string s = this.tbInput.Text;
            this.ExpressionList.Add(s);
        }

        private void UpdatetbContent()
        {
            this.tbContent.Text = "";
            foreach (string s in this.ExpressionList)
            {
                this.tbContent.AppendText(s);
                this.tbContent.AppendText(Environment.NewLine);
            }
        }

        private void UpdatetbResult()
        {
            this.tbResult.Text = "";
            foreach (string s in this.ResultList)
            {
                this.tbResult.AppendText(s);
                this.tbResult.AppendText(Environment.NewLine);
            }
        }

        private void ChangeButton(bool status)
        {
            this.btnValExpress.Enabled = status;
            this.btnFileName.Enabled = status;
            this.btnReadFile.Enabled = status;
            this.btnReadTextBox.Enabled = status;
        }
    }
}

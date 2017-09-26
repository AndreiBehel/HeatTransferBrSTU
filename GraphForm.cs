using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace Physics
{
    public interface IGraphForm
    {
        myData[] data { set; }
        bool flag { set; }
    }
    public partial class GraphForm : Form, IGraphForm
    {
        private myData[] dataArray;
        private bool isRunning = true;
        private int timeDelay = 150;
        public GraphForm()
        {
            InitializeComponent();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            convChart.Series[0].Points.Clear();
            convChart.Series[1].Points.Clear();
            convChart.Series[2].Points.Clear();
            new Thread(new ParameterizedThreadStart(worker)).Start(new Action<myData>(this.AddDataPoint));
        }
        private void worker(object obj)
        {
            var _delegate = (Action<myData>)obj;
            for (int x = 0; x < dataArray.Length; x++)
            {
                if (!isRunning) break;
                _delegate(dataArray[x]);
                Thread.Sleep(timeDelay);
            }
        }
        public void AddDataPoint(myData d)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<myData>(this.AddDataPoint), new object[] { d });
            }
            else
            {
                convChart.Series[0].Points.AddXY(d.X, d.Y_c);
                convChart.Series[1].Points.AddXY(d.X, d.Y_r);
                convChart.Series[2].Points.AddXY(d.X, d.Y_total);
            }
        }
        public bool flag
        {
            set { isRunning = value; }
        }
        public myData[] data
        {
            set { dataArray = value; }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.isRunning = false;
        }

        private void GraphForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.isRunning = false;
        }
    }
    public class myData
    {
        public double X;
        public double Y_c;
        public double Y_r;
        public double Y_total;
    }
}

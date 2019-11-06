using Parser.Core;
using Parser.Core.Findanime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser
{
    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser;

        public Form1()
        {
            InitializeComponent();

            parser = new ParserWorker<string[]>(
                    new FindanimeParser()
                );

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            ListTitle.Items.AddRange(arg2);
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All works done!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parser.Settings = new FindanimeSettings((int)NumericStart.Value, (int)NumericEnd.Value);
            parser.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

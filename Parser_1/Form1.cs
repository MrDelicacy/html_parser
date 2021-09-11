using Parser_1.Core;
using Parser_1.Core.Functionality;
using System;
using System.Windows.Forms;

namespace Parser_1
{
    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser;
        string startUrl = "https://finance.i.ua/usd/";
        public Form1()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(new FunctionalityParser());
            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData+= Parser_OnNewData;
            TreeView tree = new TreeView();
           
        }
        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("все завершено");
        }
        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            parserList.Items.AddRange(arg2);
            foreach(string str in arg2)
            treeView1.Nodes.Add(str);


        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //parser.ParserSettings = new FunctionalitySettings((int)startNumeric.Value,(int)endNumeric.Value);
            parser.ParserSettings = new FunctionalitySettings(startUrl);
            parser.Start();
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionII
{
    public partial class Acercade : Form
    {
        public Acercade()
        {
            InitializeComponent();
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://github.com/yoniberplay";
            linkLabel1.Links.Add(link);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);

        }

        private void Acercade_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}

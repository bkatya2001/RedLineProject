using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedLineProject
{
    public partial class HelpForm : Form
    {
        public HelpForm(string docs)
        {
            InitializeComponent();

            webBrowser1.DocumentText = docs;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSSIconPackGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            var path = Path.Text;
            var template = cssClassTemplate.Text;
            OutPut.Text = "";
            if(!Directory.Exists(path))
            {
                MessageBox.Show("Path not found!");
                return;
            }
            var filesList = Directory.GetFiles(path);
            foreach (var file in filesList) {
                try
                {
                    var fullName = file.Replace(path, "");
                    var shortName = fullName.Replace(".svg", "");
                    if (RemoveSolid.CheckState == CheckState.Checked)
                    {
                        shortName = shortName.Replace("-solid", "");
                    }

                    OutPut.Text += string.Format(template, fullName, shortName) + "\n\n";
                } catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Error occured in file: {0}\nEx:\n{1}",file,ex.Message));
                }

                
            }
        }

    }
}

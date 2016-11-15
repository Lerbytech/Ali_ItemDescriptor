using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ali_ItemDescriptor
{
  public partial class Form1 : Form
  {

    CItemParameters Item;

    public Form1()
    {
      InitializeComponent();
    }

    private void BTN_DefaultStats_Click(object sender, EventArgs e)
    {
      
    }

    private void BTN_GenStats_Click(object sender, EventArgs e)
    {

    }

    private void BTN_GenDescrition_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Item = new CItemParameters();
    }


    private void Fill_ItemStats(List<string> text)
    {

    }

    private void Fill_Descritption(List<string> text)
    {


    }

  }
}

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

    CItemCard Item;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Item = new CItemCard();
 
    }

    #region buttons
    private void BTN_DefaultStats_Click(object sender, EventArgs e)
    {
      CDescriptionGrabber descr = new CDescriptionGrabber();
      descr.DoStuff();

      Item = CItemGenerator.GetDefaultStats();
      Fill_ItemStats(CItemGenerator.GetItemStats(Item));
      Fill_Description(CItemDescriptionGenerator.GetDescription(Item));
    }

    private void BTN_GenStats_Click(object sender, EventArgs e)
    {
      Item = CItemGenerator.GenerateStats();
      Fill_ItemStats(CItemGenerator.GetItemStats(Item));
      Fill_Description(CItemDescriptionGenerator.GetDescription(Item));
    }

    private void BTN_GenDescription_Click(object sender, EventArgs e)
    {
      Fill_Description(CItemDescriptionGenerator.GetDescription(Item));
    }

    #endregion


    #region Fill textboxes on form

    private void Fill_ItemStats(List<string> text)
    {
      TB_ItemStats.Clear();

      foreach (var I in text)
      {
        TB_ItemStats.AppendText(I);
        TB_ItemStats.AppendText("\n");
      }
    }

    private void Fill_Description(List<string> text)
    {
      TB_Description.Clear();

      foreach (var I in text)
      {
        TB_Description.AppendText(I);
        TB_Description.AppendText("\n");
      }
    }
    #endregion


  }
}

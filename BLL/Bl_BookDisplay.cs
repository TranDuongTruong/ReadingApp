using ReadingCommicBook.DAL;
using ReadingCommicBook.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingCommicBook.BLL
{
    internal class Bl_BookDisplay
    {
      public  DAL_BookDisplay dAL_BookDisplay = new DAL_BookDisplay();
     frm_BookDisplay frm_BookDisplay;

        public Bl_BookDisplay(frm_BookDisplay frm_BookDisplay)
        {
            this.frm_BookDisplay = frm_BookDisplay;
        }

        public string  GetChap(int chap)
        {
            String content = "";
            return content;
        }
        public void LoadData(String id, string title, int chap, int length)
        {
            frm_BookDisplay.curentChap = chap;
            frm_BookDisplay.maxChap = length;
            frm_BookDisplay.id = id;
            frm_BookDisplay.labk_BInf.Text = "  /   " + title;
            frm_BookDisplay.labk_Chap.Text = "  /  " + "Chương " + chap;

            for (int i = 0; i < frm_BookDisplay.maxChap; i++)
            {
                frm_BookDisplay.com_chapter.Items.Add("Chapter " + (i + 1));
            }
          
            DisplayText();

        }
        public void DisplayText()
        {
            if (frm_BookDisplay.curentChap <= frm_BookDisplay.maxChap) frm_BookDisplay.content = dAL_BookDisplay.baseClass.LoadTextFile(frm_BookDisplay.id + "_c" + frm_BookDisplay.curentChap + ".txt");
            frm_BookDisplay.com_chapter.SelectedItem = "Chapter " + frm_BookDisplay.curentChap;
            frm_BookDisplay.richTextBox1.Text = frm_BookDisplay.content;


        }
    
    }
}

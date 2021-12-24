using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextRemix
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void btnAddSentence_Click(object sender, EventArgs e)
      {
         if (!string.IsNullOrEmpty(tbSentence.Text) && !Sentencator.SentenceTime.ContainsKey(tbSentence.Text))
         {
            Sentencator.SentenceTime.Add(tbSentence.Text, new Point((int)nmSentencesMin.Value, (int)nmSentencesMax.Value));
            Sentencator.SentenceAfterLines.Add(tbSentence.Text, (int)nmAfterMoreLines.Value);
            lboxSentences.Items.Add(tbSentence.Text);
         }
      }

      bool itemChanged = false;
      private void lboxSentences_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (lboxSentences.SelectedIndex >= 0)
         {
            itemChanged = true;
            nmSentencesMin.Value = Sentencator.SentenceTime[lboxSentences.SelectedItem.ToString()].X;
            nmSentencesMax.Value = Sentencator.SentenceTime[lboxSentences.SelectedItem.ToString()].Y;
            nmAfterMoreLines.Value = Sentencator.SentenceAfterLines[lboxSentences.SelectedItem.ToString()];
         }
         if (tbSentence.Text == string.Empty)
         {
            tbSentence.Text = lboxSentences.SelectedItem.ToString();
         }
      }

      /// <summary>
      /// 
      /// </summary>
      private void lboxSentences_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Delete && lboxSentences.SelectedIndex >= 0)
         {
            Sentencator.SentenceTime.Remove(lboxSentences.SelectedItem.ToString());
            lboxSentences.Items.RemoveAt(lboxSentences.SelectedIndex);
         }
      }

      /// <summary>
      /// 
      /// </summary>
      private void nmSentences_ValueChanged(object sender, EventArgs e)
      {
         if (lboxSentences.SelectedIndex >= 0 && !itemChanged)
         {
            Sentencator.SentenceTime[lboxSentences.SelectedItem.ToString()] = new Point((int)nmSentencesMin.Value, (int)nmSentencesMax.Value);
         }
      }

      /// <summary>
      /// 
      /// </summary>
      private void nmSentencesMax_ValueChanged(object sender, EventArgs e)
      {
         if (lboxSentences.SelectedIndex >= 0 && !itemChanged)
         {
            Sentencator.SentenceTime[lboxSentences.SelectedItem.ToString()] = new Point((int)nmSentencesMin.Value, (int)nmSentencesMax.Value);
         }
         else if (itemChanged)
         {
            itemChanged = false;
         }
      }

      /// <summary>
      /// 
      /// </summary>
      private void nmAfterMoreLines_ValueChanged(object sender, EventArgs e)
      {
         if (lboxSentences.SelectedIndex >= 0 && !itemChanged)
         {
            Sentencator.SentenceAfterLines[lboxSentences.SelectedItem.ToString()] = (int)nmAfterMoreLines.Value;
         }
         else if (itemChanged)
         {
            itemChanged = false;
         }
      }

      /// <summary>
      /// 
      /// </summary>
      private void lboxCreated_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (lboxCreated.SelectedIndex >= 0)
         {
            Clipboard.SetText(string.Join("\n", Sentencator.blabolList[lboxCreated.SelectedItem.ToString()]));
         }
      }

      /// <summary>
      /// 
      /// </summary>
      private void btnCreateBlabol_Click(object sender, EventArgs e)
      {
         if (!lboxCreated.Items.Contains(tbBlabolName.Text))
         {
            Sentencator.CreateBlabol(tbBlabolName.Text);
            lboxCreated.Items.Add(tbBlabolName.Text);
         }
      }

      /// <summary>
      /// 
      /// </summary>
      private void btnAfter_Click(object sender, EventArgs e)
      {
         string selectedItem = lboxSentences.SelectedItem.ToString();
         if (lboxSentences.Items.Contains(tbSentence.Text) && !lboxAfter.Items.Contains(selectedItem) && selectedItem != tbSentence.Text)
         {
            lboxAfter.Items.Add(selectedItem);
            Sentencator.afterList[tbSentence.Text].Add(selectedItem);
         }
      }

      /// <summary>
      /// 
      /// </summary>
      private void lboxAfter_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Delete && lboxAfter.SelectedIndex >= 0)
         {
            Sentencator.afterList.Remove(lboxAfter.SelectedItem.ToString());
            lboxAfter.Items.Remove(lboxAfter.SelectedItem.ToString());
         }
      }


   }
}

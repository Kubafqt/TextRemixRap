
namespace TextRemix
{
   partial class Form1
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.btnAddSentence = new System.Windows.Forms.Button();
         this.tbSentence = new System.Windows.Forms.TextBox();
         this.lboxSentences = new System.Windows.Forms.ListBox();
         this.btnCreateBlabol = new System.Windows.Forms.Button();
         this.nmSentencesMin = new System.Windows.Forms.NumericUpDown();
         this.lboxCreated = new System.Windows.Forms.ListBox();
         this.tbBlabolName = new System.Windows.Forms.TextBox();
         this.nmSentencesMax = new System.Windows.Forms.NumericUpDown();
         this.lboxAfter = new System.Windows.Forms.ListBox();
         this.btnAfter = new System.Windows.Forms.Button();
         this.nmAfterMoreLines = new System.Windows.Forms.NumericUpDown();
         this.cboxAndAfter = new System.Windows.Forms.CheckBox();
         ((System.ComponentModel.ISupportInitialize)(this.nmSentencesMin)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.nmSentencesMax)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.nmAfterMoreLines)).BeginInit();
         this.SuspendLayout();
         // 
         // btnAddSentence
         // 
         this.btnAddSentence.Location = new System.Drawing.Point(510, 44);
         this.btnAddSentence.Name = "btnAddSentence";
         this.btnAddSentence.Size = new System.Drawing.Size(75, 23);
         this.btnAddSentence.TabIndex = 0;
         this.btnAddSentence.Text = "sentence";
         this.btnAddSentence.UseVisualStyleBackColor = true;
         this.btnAddSentence.Click += new System.EventHandler(this.btnAddSentence_Click);
         // 
         // tbSentence
         // 
         this.tbSentence.Location = new System.Drawing.Point(330, 45);
         this.tbSentence.Name = "tbSentence";
         this.tbSentence.Size = new System.Drawing.Size(174, 23);
         this.tbSentence.TabIndex = 1;
         // 
         // lboxSentences
         // 
         this.lboxSentences.FormattingEnabled = true;
         this.lboxSentences.ItemHeight = 15;
         this.lboxSentences.Location = new System.Drawing.Point(332, 82);
         this.lboxSentences.Name = "lboxSentences";
         this.lboxSentences.Size = new System.Drawing.Size(253, 289);
         this.lboxSentences.TabIndex = 2;
         this.lboxSentences.SelectedIndexChanged += new System.EventHandler(this.lboxSentences_SelectedIndexChanged);
         this.lboxSentences.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lboxSentences_KeyDown);
         // 
         // btnCreateBlabol
         // 
         this.btnCreateBlabol.Location = new System.Drawing.Point(755, 33);
         this.btnCreateBlabol.Name = "btnCreateBlabol";
         this.btnCreateBlabol.Size = new System.Drawing.Size(110, 23);
         this.btnCreateBlabol.TabIndex = 3;
         this.btnCreateBlabol.Text = "create blabol";
         this.btnCreateBlabol.UseVisualStyleBackColor = true;
         this.btnCreateBlabol.Click += new System.EventHandler(this.btnCreateBlabol_Click);
         // 
         // nmSentencesMin
         // 
         this.nmSentencesMin.Location = new System.Drawing.Point(332, 11);
         this.nmSentencesMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.nmSentencesMin.Name = "nmSentencesMin";
         this.nmSentencesMin.Size = new System.Drawing.Size(54, 23);
         this.nmSentencesMin.TabIndex = 4;
         this.nmSentencesMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.nmSentencesMin.ValueChanged += new System.EventHandler(this.nmSentences_ValueChanged);
         // 
         // lboxCreated
         // 
         this.lboxCreated.FormattingEnabled = true;
         this.lboxCreated.ItemHeight = 15;
         this.lboxCreated.Location = new System.Drawing.Point(612, 67);
         this.lboxCreated.Name = "lboxCreated";
         this.lboxCreated.Size = new System.Drawing.Size(253, 304);
         this.lboxCreated.TabIndex = 5;
         this.lboxCreated.SelectedIndexChanged += new System.EventHandler(this.lboxCreated_SelectedIndexChanged);
         // 
         // tbBlabolName
         // 
         this.tbBlabolName.Location = new System.Drawing.Point(612, 33);
         this.tbBlabolName.Name = "tbBlabolName";
         this.tbBlabolName.Size = new System.Drawing.Size(137, 23);
         this.tbBlabolName.TabIndex = 6;
         // 
         // nmSentencesMax
         // 
         this.nmSentencesMax.Location = new System.Drawing.Point(401, 11);
         this.nmSentencesMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.nmSentencesMax.Name = "nmSentencesMax";
         this.nmSentencesMax.Size = new System.Drawing.Size(45, 23);
         this.nmSentencesMax.TabIndex = 7;
         this.nmSentencesMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.nmSentencesMax.ValueChanged += new System.EventHandler(this.nmSentencesMax_ValueChanged);
         // 
         // lboxAfter
         // 
         this.lboxAfter.FormattingEnabled = true;
         this.lboxAfter.ItemHeight = 15;
         this.lboxAfter.Location = new System.Drawing.Point(55, 82);
         this.lboxAfter.Name = "lboxAfter";
         this.lboxAfter.Size = new System.Drawing.Size(253, 289);
         this.lboxAfter.TabIndex = 8;
         this.lboxAfter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lboxAfter_KeyDown);
         // 
         // btnAfter
         // 
         this.btnAfter.Location = new System.Drawing.Point(70, 45);
         this.btnAfter.Name = "btnAfter";
         this.btnAfter.Size = new System.Drawing.Size(75, 23);
         this.btnAfter.TabIndex = 9;
         this.btnAfter.Text = "after";
         this.btnAfter.UseVisualStyleBackColor = true;
         this.btnAfter.Click += new System.EventHandler(this.btnAfter_Click);
         // 
         // nmAfterMoreLines
         // 
         this.nmAfterMoreLines.Location = new System.Drawing.Point(490, 12);
         this.nmAfterMoreLines.Name = "nmAfterMoreLines";
         this.nmAfterMoreLines.Size = new System.Drawing.Size(45, 23);
         this.nmAfterMoreLines.TabIndex = 10;
         this.nmAfterMoreLines.ValueChanged += new System.EventHandler(this.nmAfterMoreLines_ValueChanged);
         // 
         // cboxAndAfter
         // 
         this.cboxAndAfter.AutoSize = true;
         this.cboxAndAfter.Location = new System.Drawing.Point(165, 48);
         this.cboxAndAfter.Name = "cboxAndAfter";
         this.cboxAndAfter.Size = new System.Drawing.Size(51, 19);
         this.cboxAndAfter.TabIndex = 11;
         this.cboxAndAfter.Text = "AND";
         this.cboxAndAfter.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(900, 392);
         this.Controls.Add(this.cboxAndAfter);
         this.Controls.Add(this.nmAfterMoreLines);
         this.Controls.Add(this.btnAfter);
         this.Controls.Add(this.lboxAfter);
         this.Controls.Add(this.nmSentencesMax);
         this.Controls.Add(this.tbBlabolName);
         this.Controls.Add(this.lboxCreated);
         this.Controls.Add(this.nmSentencesMin);
         this.Controls.Add(this.btnCreateBlabol);
         this.Controls.Add(this.lboxSentences);
         this.Controls.Add(this.tbSentence);
         this.Controls.Add(this.btnAddSentence);
         this.MaximizeBox = false;
         this.Name = "Form1";
         this.Text = "Text remix";
         ((System.ComponentModel.ISupportInitialize)(this.nmSentencesMin)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.nmSentencesMax)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.nmAfterMoreLines)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnAddSentence;
      private System.Windows.Forms.TextBox tbSentence;
      private System.Windows.Forms.ListBox lboxSentences;
      private System.Windows.Forms.Button btnCreateBlabol;
      private System.Windows.Forms.NumericUpDown nmSentencesMin;
      private System.Windows.Forms.ListBox lboxCreated;
      private System.Windows.Forms.TextBox tbBlabolName;
      private System.Windows.Forms.NumericUpDown nmSentencesMax;
      private System.Windows.Forms.ListBox lboxAfter;
      private System.Windows.Forms.Button btnAfter;
      private System.Windows.Forms.NumericUpDown nmAfterMoreLines;
      private System.Windows.Forms.CheckBox cboxAndAfter;
   }
}


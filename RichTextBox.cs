 private void RichTextBox_TextChanged(object sender, EventArgs e)
 {
     RichTextBox.AppendText("Text d'exemple de RichTextBox amb cursiva");
     RichTextBox.SelectionFont = new System.Drawing.Font("Times New Roman", 10, System.Drawing.FontStyle.Italic);
     System.Drawing.Image img = System.Drawing.Image.FromFile("richbox1.jpg");
 }

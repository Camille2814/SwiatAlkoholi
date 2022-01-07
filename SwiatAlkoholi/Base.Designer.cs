namespace SwiatAlkoholi
{
    partial class Base
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GIN 135 EAST HYOGO DRY 42% 0,7L JAPONIA",
            "GIN 24 HERBS BOTANIC 0,7L 40%",
            "GIN BLOOM PASSIONFRUIT & VANILLA 40% 0,7L",
            "CACHACA IPANEMA 38% 0,7 L",
            "RUM ABUELO 12YO 0,7L 40% PANAMA",
            "RUM APPLETON ESTATE 21YO 0,7L 43% JAMAICA",
            "LIKIER STUMBRAS THE NINES 999 BITTER AUTHENTIC 0,5L 40%",
            "LIKIER DĘBOWA CHERRY GOLD PODKOWA 0,7L 30%"});
            this.comboBox1.Location = new System.Drawing.Point(15, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(386, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Wybierz produkt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj do koszyka";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(339, 132);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Zamawiam";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Base
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Base";
            this.Size = new System.Drawing.Size(574, 206);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
    }
}

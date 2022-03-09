using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4E_INF_FerraroDomenico_Pizzeria
{
    public partial class Form1 : Form
    {
        private Label lblPizza;
        private ComboBox cmbScelta;
        private Button btnAggiungi;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblPizza = new System.Windows.Forms.Label();
            this.cmbScelta = new System.Windows.Forms.ComboBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.Location = new System.Drawing.Point(38, 54);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(72, 15);
            this.lblPizza.TabIndex = 0;
            this.lblPizza.Text = "Tipo di pizza";
            // 
            // cmbScelta
            // 
            this.cmbScelta.FormattingEnabled = true;
            this.cmbScelta.Items.AddRange(new object[] {
            "Margherita",
            "Quattro Stagioni",
            "Verdure"});
            this.cmbScelta.Location = new System.Drawing.Point(116, 51);
            this.cmbScelta.Name = "cmbScelta";
            this.cmbScelta.Size = new System.Drawing.Size(121, 23);
            this.cmbScelta.TabIndex = 1;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(270, 51);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(81, 23);
            this.btnAggiungi.TabIndex = 2;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(839, 446);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.cmbScelta);
            this.Controls.Add(this.lblPizza);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

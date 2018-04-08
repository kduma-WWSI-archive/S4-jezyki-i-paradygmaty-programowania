using System.Drawing;
using System.Windows.Forms;

namespace Mapa
{
    partial class MapaForm
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pozycja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Pozycja
            // 
            this.Pozycja.AutoSize = true;
            this.Pozycja.ForeColor = System.Drawing.Color.White;
            this.Pozycja.Location = new System.Drawing.Point(12, 9);
            this.Pozycja.Name = "Pozycja";
            this.Pozycja.Size = new System.Drawing.Size(35, 13);
            this.Pozycja.TabIndex = 0;
            this.Pozycja.Text = "label1";
            // 
            // MapaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(709, 426);
            this.Controls.Add(this.Pozycja);
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.Name = "MapaForm";
            this.Text = "Mapa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MapaForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MapaForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MapaForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Timer timer1;
        private Label Pozycja;
    }
}


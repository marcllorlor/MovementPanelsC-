using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalJaume
{
    public partial class fmExamenFinal : Form
    {
        //Llistes objectes
        List<clBarra> llBarres = new List<clBarra>();
        List<clQuadrat> llQuadrats = new List<clQuadrat>();

        Int32 contadorRecorregutSencerBarra = 0;
        Int32 contadorRecorregutSencerQuadrat = 0;

        clQuadrat quadrat = null;
        Panel pnQuadrat = null;

        clBarra barra = null;

        public fmExamenFinal()
        {
            InitializeComponent();
        }

        private void fmExamenFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {
                //No he conseguit fer la funcio de focus al form
                this.Close();
            }
        }

        private void btnBarra_Click(object sender, EventArgs e)
        {
            llBarres.Add(new clBarra(this, btnBarra));
            //Aqui estem assignant un event (una funcio) a un event de la llista de boles(una propietat en aquest cas)
            llBarres[llBarres.Count - 1].heFetRecorregutSencer += new EventHandler(RecorregutSencer);
            
        }

        private void RecorregutSencer(object sender, EventArgs e)
        {
            //Aquest sera el codi cada cop que la barra torni a X despres de fer tot el recorregut
            contadorRecorregutSencerBarra++;
            lbBarres.Text = "barres: " + contadorRecorregutSencerBarra.ToString();
        }

        private void btnQuadrat_Click(object sender, EventArgs e)
        {
            llQuadrats.Add(new clQuadrat(this, llQuadrats));
            //Aqui estem assignant un event (una funcio) a un event de la llista de boles(una propietat en aquest cas)
            llQuadrats[llQuadrats.Count - 1].heArribatFinal += new EventHandler(ArribarFinalQuadrat);
        }

        private void ArribarFinalQuadrat(object sender, EventArgs e)
        {
            if(llQuadrats.Count >= 0)
            {
                quadrat = new clQuadrat(this,llQuadrats);
                pnQuadrat = quadrat.retornarquadrat(llQuadrats);
                Int32 indexborrar = quadrat.retornarindexQuadrat(pnQuadrat, llQuadrats);
                llQuadrats.RemoveAt(indexborrar);
                this.Controls.Remove(pnQuadrat);
                contadorRecorregutSencerQuadrat++;
                lbQuadrats.Text = "quadrats: " + contadorRecorregutSencerQuadrat.ToString();
            }
            //Aquest sera el codi cada cop que el quadrat arribi al final de Y
            
        }

        private void btnCanviarColor_Click(object sender, EventArgs e)
        {
            barra = new clBarra(this,btnBarra);
            barra.canviarcolorsBarres(llBarres);
        }
    }
}

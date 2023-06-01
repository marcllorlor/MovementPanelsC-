using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalJaume
{
    internal class clQuadrat
    {
        //Constants
        Int32 MIN_MIDA_QUADRAT = 20;
        Int32 MAX_MIDA_QUADRAT = 40;

        Color[] vColors = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Magenta, Color.Violet };

        Int32 MIN_VELOCITAT_CAIGUDA = 20;
        Int32 MAX_VELOCITAT_CAIGUDA = 30;

        Int32 POS_INICIAL_Y = 0;

        Form fMain = null;
        Panel pnQuadrat = null;

        Timer tMovimentQuadrat = null;

        

        //Size mida = Size.Empty;

        //Events
        public event EventHandler heArribatFinal;

        List<clQuadrat> llQuadrat = null;

        public clQuadrat(Form xfMain, List<clQuadrat> xlQuadrat)
        {
            llQuadrat = xlQuadrat;
            Random R = new Random();
            fMain = xfMain;
            pnQuadrat = new Panel();

            //Aqui estem editant les varaibles que definiran el color i tamany de boles
            Int32 midaquadrat = R.Next(MIN_MIDA_QUADRAT, MAX_MIDA_QUADRAT + 1);
            Size mida = new Size(midaquadrat, midaquadrat);

            //Aqui estem assignant el colorPanell que despres farem servir per fer la bola de dins
            //colorPanell = vColors[R.Next(0, vColors.Length)];

            //Aqui definim la posicio X i Y que estara la bola a dins del form
            Int32 posX = R.Next(0, fMain.Width - mida.Width);
            //Aqui per definir la posicio de Y ya tenim la variable global que es 0


            //Aqui estem assignants les propietats a les boles
            pnQuadrat.Size = mida;
            pnQuadrat.BackColor = vColors[R.Next(0,vColors.Length)];
            pnQuadrat.Location = new Point(posX, POS_INICIAL_Y);

            

            //Aqui arranquem el Timer que es el que fara que la pilota es vagi movent cada X temps
            iniTimer();

            //Aqui afegirem el panell Bola a dins del Form
            fMain.Controls.Add(pnQuadrat);
        }

        private void iniTimer()
        {
            tMovimentQuadrat = new Timer();
            tMovimentQuadrat.Interval = 20;
            tMovimentQuadrat.Tick += delegate (object sender, EventArgs e)
            {
                mourequadrat(sender, e);
            };
            tMovimentQuadrat.Start();
        }

        private void mourequadrat(object sender, EventArgs e)
        {
            Random R = new Random();

            if(pnQuadrat.Location.Y > fMain.Height)
            {
                //Aqui es quan toca al final de la pantalla que sha de borrar de la pantalla i de la llista
                if(llQuadrat.Count > 0)
                {
                    heArribatFinal(sender, EventArgs.Empty);
                }
                
            }
            else
            {
                pnQuadrat.Location = new Point(pnQuadrat.Location.X, pnQuadrat.Location.Y + R.Next(MIN_VELOCITAT_CAIGUDA, MAX_VELOCITAT_CAIGUDA));
            }
        }

        public Panel retornarquadrat(List<clQuadrat> xlQuadrat)
        {
            return pnQuadrat;
            
        }

        public Int32 retornarindexQuadrat(Panel xPanel, List<clQuadrat> xlQuadrat)
        {
            Int32 numerofinal = 0;
            for(int i = 0; i < xlQuadrat.Count-1; i++)
            {
                if (xlQuadrat[i].pnQuadrat == xPanel)
                {
                     numerofinal = i;
                }
            }

            return numerofinal;
        }

        
    }
}

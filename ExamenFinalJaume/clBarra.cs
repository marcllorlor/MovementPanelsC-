using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalJaume
{
    internal class clBarra
    {
        //Constants
        //Altura de la barra
        Int32 MAX_ALTURA_BARRA = 30;
        Int32 MIN_ALTURA_BARRA = 15;
        //Eixample de la barra
        Int32 MIN_WIDTH_BARRA = 50;
        Int32 MAX_WIDTH_BARRA = 70;

        Form fMain = null;
        Panel pnBarra = null;

        Size midabarra = Size.Empty;

        Color colorPanell = Color.Empty;
        Color[] vColors = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Magenta, Color.Violet };

        Timer tMovimentBarra = null;

        Int32 posY = 0;
        Int32 posX = 0;

        Int32 MAX_AUGMENT_X = 20;
        Int32 MIN_AUGMENT_X = 10;

        Int32 TAMANY_HEIGHT_BARRA = 0;
        Int32 TAMANY_WIDHT_BARRA = 0;

        Boolean arribatFinal = false;

        //Events
        public event EventHandler heFetRecorregutSencer;

        //Constructor
        public clBarra(Form xfMain, Button btnExemple)
        {
            Random R = new Random();
            fMain = xfMain;
            pnBarra = new Panel();

            //Aqui estem editant les varaibles que definiran el color i tamany de boles
            TAMANY_WIDHT_BARRA = R.Next(MIN_WIDTH_BARRA, MAX_WIDTH_BARRA + 1);
            TAMANY_HEIGHT_BARRA = R.Next(MIN_ALTURA_BARRA, MAX_ALTURA_BARRA + 1);
            midabarra = new Size(TAMANY_WIDHT_BARRA, TAMANY_HEIGHT_BARRA);

            

            //Aqui estem assignant el colorPanell que despres farem servir per fer la bola de dins
            colorPanell = vColors[R.Next(0, vColors.Length)];

            //Aqui definim la posicio X i Y que estara la bola a dins del form
            posX = 0; //Poso 0 per que l'exericic indica que sha de posar a lesquerra del tot
            posY = R.Next(btnExemple.Location.Y + btnExemple.Height+10,fMain.Height);


            //Aqui estem assignants les propietats a les boles
            pnBarra.Size = midabarra;
            pnBarra.BackColor = vColors[R.Next(0, vColors.Length)];
            pnBarra.Location = new Point(posX, posY);

            //Aqui arranquem el Timer que es el que fara que la pilota es vagi movent cada X temps
            iniTimer();

            //Aqui afegirem el panell Bola a dins del Form
            fMain.Controls.Add(pnBarra);

        }

        private void iniTimer()
        {
            tMovimentBarra = new Timer();
            tMovimentBarra.Interval = 20;
            tMovimentBarra.Tick += delegate (object sender, EventArgs e)
            {
                mourebarra(sender, e);
            };
            tMovimentBarra.Start();
        }

        private void mourebarra(object sender, EventArgs e)
        {
            Random R = new Random();
            

            if (pnBarra.Width < fMain.Width && arribatFinal==false)
            {
                //Aquest sera el codi quan la barra vagi cap a la dreta
                pnBarra.Size = new Size(pnBarra.Size.Width + R.Next(MIN_AUGMENT_X, MAX_AUGMENT_X), pnBarra.Size.Height);
            }
            if(pnBarra.Width < 1)
            {
                //Aqui es quan tecta que la barra ya ha arribat al limit de la esquerra
                heFetRecorregutSencer(sender, EventArgs.Empty);
                arribatFinal = false;

            }
            if(pnBarra.Width >= fMain.Width)
            {
                //Aqui es quan detecta que ha arribat al final
                arribatFinal=true;
            }
            if(pnBarra.Width > 0 && arribatFinal == true)
            {
                //Aquest es el codi del moviment cap a lesquerra
                pnBarra.Size = new Size(pnBarra.Size.Width - R.Next(MIN_AUGMENT_X, MAX_AUGMENT_X), pnBarra.Size.Height);
            }
            
        }

        public void canviarcolorsBarres(List<clBarra> xlBarra)
        {
            Random R = new Random();
            for (int i = 0; i < xlBarra.Count; i++)
            {
                xlBarra[i].pnBarra.BackColor = vColors[R.Next(0, vColors.Length)];
            }
        }
    }
}

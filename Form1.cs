using System;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form





    {
        public Form1()
        {
            InitializeComponent();


        }

        private void yeniden()
        {
            groupBox5.Visible = false;
            haftaskor1.Text = "0";
            haftaskor2.Text = "0";
            haftaskor3.Text = "0";
            haftaskor4.Text = "0";
            haftaskor5.Text = "0";
            haftaskor6.Text = "0";
            haftaskor7.Text = "0";
            haftaskor8.Text = "0";
            haftaskor9.Text = "0";
            haftaskor10.Text = "0";
            haftaskor11.Text = "0";
            haftaskor12.Text = "0";

            bjkpuan = 0;
            gspuan = 0;
            fbpuan = 0;
            tspuan = 0;

            bjkpuantablo.Text = "0";
            gspuantablo.Text = "0";
            fbpuantablo.Text = "0";
            tspuantablo.Text = "0";

            btnhafta1.Enabled = true;
            btnhafta2.Enabled = true;
            btnhafta3.Enabled = true;

            sampiyonisim.Text = " ";
            btnsifirla.Visible = false;
            btnhafta2.Visible = false;
            btnhafta3.Visible = false;
        }
        Random rastgele = new Random();
        int bjkpuan = 0;
        int gspuan = 0;
        int fbpuan = 0;
        int tspuan = 0;
        int sampiyon;
        int o, p;
        private void btnhafta1_Click(object sender, EventArgs e)
        {
            int a = rastgele.Next(0, 6);
            int b = rastgele.Next(0, 6);
            int c = rastgele.Next(0, 6);
            int d = rastgele.Next(0, 6);

            haftaskor1.Text = a.ToString();
            haftaskor2.Text = b.ToString();
            haftaskor3.Text = c.ToString();
            haftaskor4.Text = d.ToString();

            if (Convert.ToInt32(haftaskor1.Text) > Convert.ToInt32(haftaskor2.Text))
            {
                bjkpuan = bjkpuan + 3;
                bjkpuantablo.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(haftaskor1.Text) == Convert.ToInt32(haftaskor2.Text))
            {
                bjkpuan = bjkpuan + 1;
                gspuan = gspuan + 1;
                bjkpuantablo.Text = bjkpuan.ToString();
                gspuantablo.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(haftaskor2.Text) > Convert.ToInt32(haftaskor1.Text))
            {
                gspuan = gspuan + 3;
                gspuantablo.Text = gspuan.ToString();
            }

            if (Convert.ToInt32(haftaskor3.Text) > Convert.ToInt32(haftaskor4.Text))
            {
                fbpuan = fbpuan + 3;
                fbpuantablo.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(haftaskor3.Text) == Convert.ToInt32(haftaskor4.Text))
            {
                fbpuan = fbpuan + 1;
                tspuan = tspuan + 1;
                fbpuantablo.Text = fbpuan.ToString();
                tspuantablo.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(haftaskor4.Text) > Convert.ToInt32(haftaskor3.Text))
            {
                tspuan = tspuan + 3;
                tspuantablo.Text = tspuan.ToString();


            }
            btnhafta1.Enabled = false;
            btnhafta2.Enabled = true;
            btnhafta2.Visible = true;
        }

        private void btnhafta2_Click(object sender, EventArgs e)
        {
            int a = rastgele.Next(0, 6);
            int b = rastgele.Next(0, 6);
            int c = rastgele.Next(0, 6);
            int d = rastgele.Next(0, 6);

            haftaskor5.Text = a.ToString();
            haftaskor6.Text = b.ToString();
            haftaskor7.Text = c.ToString();
            haftaskor8.Text = d.ToString();

            if (Convert.ToInt32(haftaskor5.Text) > Convert.ToInt32(haftaskor6.Text))
            {
                bjkpuan = bjkpuan + 3;
                bjkpuantablo.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(haftaskor5.Text) == Convert.ToInt32(haftaskor6.Text))
            {
                bjkpuan = bjkpuan + 1;
                fbpuan = fbpuan + 1;
                bjkpuantablo.Text = bjkpuan.ToString();
                fbpuantablo.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(haftaskor6.Text) > Convert.ToInt32(haftaskor5.Text))
            {
                fbpuan = fbpuan + 3;
                fbpuantablo.Text = fbpuan.ToString();
            }

            if (Convert.ToInt32(haftaskor7.Text) > Convert.ToInt32(haftaskor8.Text))
            {
                gspuan = gspuan + 3;
                gspuantablo.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(haftaskor7.Text) == Convert.ToInt32(haftaskor8.Text))
            {
                gspuan = gspuan + 1;
                tspuan = tspuan + 1;
                fbpuantablo.Text = fbpuan.ToString();
                tspuantablo.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(haftaskor8.Text) > Convert.ToInt32(haftaskor7.Text))
            {
                tspuan = tspuan + 3;
                tspuantablo.Text = tspuan.ToString();


            }
            btnhafta2.Enabled = false;
            btnhafta3.Enabled = true;
            btnhafta3.Visible = true;
        }

        private void btnhafta3_Click(object sender, EventArgs e)
        {
            int a = rastgele.Next(0, 6);
            int b = rastgele.Next(0, 6);
            int c = rastgele.Next(0, 6);
            int d = rastgele.Next(0, 6);

            haftaskor9.Text = a.ToString();
            haftaskor10.Text = b.ToString();
            haftaskor11.Text = c.ToString();
            haftaskor12.Text = d.ToString();

            if (Convert.ToInt32(haftaskor9.Text) > Convert.ToInt32(haftaskor10.Text))
            {
                bjkpuan = bjkpuan + 3;
                bjkpuantablo.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(haftaskor9.Text) == Convert.ToInt32(haftaskor10.Text))
            {
                bjkpuan = bjkpuan + 1;
                tspuan = tspuan + 1;
                bjkpuantablo.Text = bjkpuan.ToString();
                tspuantablo.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(haftaskor10.Text) > Convert.ToInt32(haftaskor9.Text))
            {
                tspuan = tspuan + 3;
                tspuantablo.Text = tspuan.ToString();
            }

            if (Convert.ToInt32(haftaskor11.Text) > Convert.ToInt32(haftaskor12.Text))
            {
                fbpuan = fbpuan + 3;
                fbpuantablo.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(haftaskor11.Text) == Convert.ToInt32(haftaskor12.Text))
            {
                fbpuan = fbpuan + 1;
                gspuan = gspuan + 1;
                fbpuantablo.Text = fbpuan.ToString();
                gspuantablo.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(haftaskor12.Text) > Convert.ToInt32(haftaskor11.Text))
            {
                gspuan = gspuan + 3;
                gspuantablo.Text = gspuan.ToString();


            }
            btnhafta3.Enabled = false;

            if (Convert.ToUInt32(bjkpuantablo.Text) > Convert.ToUInt32(gspuantablo.Text) && Convert.ToUInt32(bjkpuantablo.Text) > Convert.ToUInt32(tspuantablo.Text) && Convert.ToUInt32(bjkpuantablo.Text) > Convert.ToUInt32(fbpuantablo.Text))
            {
                sampiyonisim.Text = "Þampiyon Beþiktaþ!";
            }
            if (Convert.ToUInt32(fbpuantablo.Text) > Convert.ToUInt32(gspuantablo.Text) && Convert.ToUInt32(fbpuantablo.Text) > Convert.ToUInt32(tspuantablo.Text) && Convert.ToUInt32(fbpuantablo.Text) > Convert.ToUInt32(bjkpuantablo.Text))
            {
                sampiyonisim.Text = "Þampiyon Fenerbahçe!";
            }

            if (Convert.ToUInt32(gspuantablo.Text) > Convert.ToUInt32(bjkpuantablo.Text) && Convert.ToUInt32(gspuantablo.Text) > Convert.ToUInt32(tspuantablo.Text) && Convert.ToUInt32(gspuantablo.Text) > Convert.ToUInt32(fbpuantablo.Text))
            {
                sampiyonisim.Text = "Þampiyon Galatasaray!";
            }


            if (Convert.ToUInt32(tspuantablo.Text) > Convert.ToUInt32(gspuantablo.Text) && Convert.ToUInt32(tspuantablo.Text) > Convert.ToUInt32(bjkpuantablo.Text) && Convert.ToUInt32(tspuantablo.Text) > Convert.ToUInt32(fbpuantablo.Text))
            {

                sampiyonisim.Text = "Þampiyon Trabzonspor!";
            }

            if (Convert.ToInt32(bjkpuantablo.Text) == Convert.ToInt32(fbpuantablo.Text) && Convert.ToInt32(bjkpuantablo.Text) > Convert.ToUInt32(gspuantablo.Text) && Convert.ToInt32(bjkpuantablo.Text) > Convert.ToUInt32(tspuantablo.Text))
            {

                groupBox5.Visible = true;
                final1.Text = "Beþiktaþ";
                final2.Text = "Fenerbahçe";

                int g = rastgele.Next(0, 6);
                int f = rastgele.Next(0, 6);

                finalskor1.Text = g.ToString();
                finalskor2.Text = f.ToString();

                if (Convert.ToInt32(finalskor1.Text) > Convert.ToInt32(finalskor2.Text))
                {
                    sampiyonisim.Text = "Þampiyon Beþiktaþ";
                }
                if (Convert.ToInt32(finalskor1.Text) == Convert.ToInt32(finalskor2.Text))
                {
                    sampiyonisim.Text = "Berabere";
                }
                if (Convert.ToInt32(finalskor2.Text) > Convert.ToInt32(finalskor1.Text))
                {
                    sampiyonisim.Text = "Þampiyon Fenerbahçe";

                }
            }


            if (Convert.ToInt32(gspuantablo.Text) == Convert.ToInt32(tspuantablo.Text) && Convert.ToInt32(gspuantablo.Text) > Convert.ToUInt32(fbpuantablo.Text) && Convert.ToInt32(gspuantablo.Text) > Convert.ToUInt32(bjkpuantablo.Text))
            {
                groupBox5.Visible = true;

                final1.Text = "Galatasaray";
                final2.Text = "Trabzonspor";

                int g = rastgele.Next(0, 6);
                int f = rastgele.Next(0, 6);

                finalskor1.Text = g.ToString();
                finalskor2.Text = f.ToString();

                if (Convert.ToInt32(finalskor1.Text) > Convert.ToInt32(finalskor2.Text))
                {
                    sampiyonisim.Text = "Þampiyon Galatasaray";
                }
                if (Convert.ToInt32(finalskor1.Text) == Convert.ToInt32(finalskor2.Text))
                {
                    sampiyonisim.Text = "Berabere";
                }
                if (Convert.ToInt32(finalskor2.Text) > Convert.ToInt32(finalskor1.Text))
                {
                    sampiyonisim.Text = "Þampiyon Trabzonspor";

                }
            }


            if (Convert.ToInt32(bjkpuantablo.Text) == Convert.ToInt32(tspuantablo.Text) && Convert.ToInt32(bjkpuantablo.Text) > Convert.ToUInt32(gspuantablo.Text) && Convert.ToInt32(bjkpuantablo.Text) > Convert.ToUInt32(fbpuantablo.Text))
            {
                groupBox5.Visible = true;

                final1.Text = "Beþiktaþ";
                final2.Text = "Trabzonspor";

                int g = rastgele.Next(0, 6);
                int f = rastgele.Next(0, 6);

                finalskor1.Text = g.ToString();
                finalskor2.Text = f.ToString();

                if (Convert.ToInt32(finalskor1.Text) > Convert.ToInt32(finalskor2.Text))
                {
                    sampiyonisim.Text = "Þampiyon Beþiktaþ";
                }
                if (Convert.ToInt32(finalskor1.Text) == Convert.ToInt32(finalskor2.Text))
                {
                    sampiyonisim.Text = "Berabere";
                }
                if (Convert.ToInt32(finalskor2.Text) > Convert.ToInt32(finalskor1.Text))
                {
                    sampiyonisim.Text = "Þampiyon Trabzonspor";

                }
            }


            if (Convert.ToInt32(bjkpuantablo.Text) == Convert.ToInt32(gspuantablo.Text) && Convert.ToInt32(bjkpuantablo.Text) > Convert.ToUInt32(tspuantablo.Text) && Convert.ToInt32(bjkpuantablo.Text) > Convert.ToUInt32(fbpuantablo.Text))
            {
                groupBox5.Visible = true;

                final1.Text = "Beþiktaþ";
                final2.Text = "Galatasaray";

                int g = rastgele.Next(0, 6);
                int f = rastgele.Next(0, 6);

                finalskor1.Text = g.ToString();
                finalskor2.Text = f.ToString();

                if (Convert.ToInt32(finalskor1.Text) > Convert.ToInt32(finalskor2.Text))
                {
                    sampiyonisim.Text = "Þampiyon Beþiktaþ";
                }
                if (Convert.ToInt32(finalskor1.Text) == Convert.ToInt32(finalskor2.Text))
                {
                    sampiyonisim.Text = "Berabere";
                }
                if (Convert.ToInt32(finalskor2.Text) > Convert.ToInt32(finalskor1.Text))
                {
                    sampiyonisim.Text = "Þampiyon Galatasaray";

                }
            }

            if (Convert.ToInt32(fbpuantablo.Text) == Convert.ToInt32(gspuantablo.Text) && Convert.ToInt32(fbpuantablo.Text) > Convert.ToUInt32(tspuantablo.Text) && Convert.ToInt32(fbpuantablo.Text) > Convert.ToUInt32(bjkpuantablo.Text))
            {
                groupBox5.Visible = true;

                final1.Text = "Fenerbahçe";
                final2.Text = "Galatasaray";

                int g = rastgele.Next(0, 6);
                int f = rastgele.Next(0, 6);

                finalskor1.Text = g.ToString();
                finalskor2.Text = f.ToString();

                if (Convert.ToInt32(finalskor1.Text) > Convert.ToInt32(finalskor2.Text))
                {
                    sampiyonisim.Text = "Þampiyon Fenerbahçe";
                }
                if (Convert.ToInt32(finalskor1.Text) == Convert.ToInt32(finalskor2.Text))
                {
                    sampiyonisim.Text = "Berabere";
                }
                if (Convert.ToInt32(finalskor2.Text) > Convert.ToInt32(finalskor1.Text))
                {
                    sampiyonisim.Text = "Þampiyon Galatasaray";

                }
            }

            if (Convert.ToInt32(bjkpuantablo.Text) == Convert.ToInt32(gspuantablo.Text) && Convert.ToInt32(bjkpuantablo.Text) > Convert.ToUInt32(tspuantablo.Text) && Convert.ToInt32(bjkpuantablo.Text) > Convert.ToUInt32(fbpuantablo.Text))
            {
                groupBox5.Visible = true;

                final1.Text = "Beþiktaþ";
                final2.Text = "Galatasaray";

                int g = rastgele.Next(0, 6);
                int f = rastgele.Next(0, 6);

                finalskor1.Text = g.ToString();
                finalskor2.Text = f.ToString();

                if (Convert.ToInt32(finalskor1.Text) > Convert.ToInt32(finalskor2.Text))
                {
                    sampiyonisim.Text = "Þampiyon Beþiktaþ";
                }
                if (Convert.ToInt32(finalskor1.Text) == Convert.ToInt32(finalskor2.Text))
                {
                    sampiyonisim.Text = "Berabere";
                }
                if (Convert.ToInt32(finalskor2.Text) > Convert.ToInt32(finalskor1.Text))
                {
                    sampiyonisim.Text = "Þampiyon Galatasaray";

                }
            }

            if (Convert.ToInt32(fbpuantablo.Text) == Convert.ToInt32(tspuantablo.Text) && Convert.ToInt32(fbpuantablo.Text) > Convert.ToUInt32(gspuantablo.Text) && Convert.ToInt32(fbpuantablo.Text) > Convert.ToUInt32(bjkpuantablo.Text))
            {
                groupBox5.Visible = true;

                final1.Text = "Fenerbahçe";
                final2.Text = "Trabzonspor";

                int g = rastgele.Next(0, 6);
                int f = rastgele.Next(0, 6);

                finalskor1.Text = g.ToString();
                finalskor2.Text = f.ToString();

                if (Convert.ToInt32(finalskor1.Text) > Convert.ToInt32(finalskor2.Text))
                {
                    sampiyonisim.Text = "Þampiyon Fenerbahçe";
                }
                if (Convert.ToInt32(finalskor1.Text) == Convert.ToInt32(finalskor2.Text))
                {
                    sampiyonisim.Text = "Berabere";
                }
                if (Convert.ToInt32(finalskor2.Text) > Convert.ToInt32(finalskor1.Text))
                {
                    sampiyonisim.Text = "Þampiyon Trabzonspor";

                }
            }

            btnsifirla.Visible = true;

        }

        private void btnsifirla_Click(object sender, EventArgs e)
        {
            yeniden();
        }
    }
}


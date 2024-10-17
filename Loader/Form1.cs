using loader;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <author>
/// chres0
/// </author>

namespace undericalloader
{
    public partial class Form1 : Form
    {
        /// <information>
        /// The structure of the code is to present an interface by changing the location of objects using a timer. You can develop and fork the project if you want.
        /// </information>

        Timer t1 = new Timer();

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(389, 276);
            primopicture.Visible = false;
            legionbackground.Visible = false;

        }

        public static DateTime UnixTimeToDateTime(long unixtime)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            try
            {
                dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            }
            catch
            {
                dtDateTime = DateTime.MaxValue;
            }
            return dtDateTime;
        }

        Color konec = Color.FromArgb(10, 10, 10);
        Color seda = Color.FromArgb(128, 128, 128);
        Color bila = Color.FromArgb(255, 255, 255);
        Color konecna = Color.FromArgb(21, 19, 21);
        Color cernoch = Color.FromArgb(17, 16, 17);
        Color modra = Color.FromArgb(48, 104, 194);

        // ANIMATION //
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                t1.Stop();    //if it is, we stop the timer
                Close();   //and we try to close the form
            }
            else
                Opacity -= 0.05;
        }

        // ANIMATION //

        // Here we go //
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            SignInAnimation.Start();
            Label3TextColorAnimation.Start();
            Label2TextColorChangeAnimation.Start();
            logotextColorChangeAnimation.Start();
            SignInAnimation2.Start();
            OpacityAnimation.Start();
            AnimateLabel2Left.Start();
            ExitAnimation.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Opacity = 0;

            t1.Interval = 10;
            t1.Tick += new EventHandler(fadeIn);
            t1.Start();

            label2HorizontalPositionAnimation.Start();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                e.Cancel = false;

                t1.Tick += new EventHandler(fadeOut);
                t1.Start();

                if (Opacity == 0)
                    e.Cancel = true;
            }
        }

        private async void SignInAnimation_Tick(object sender, EventArgs e)
        {
            SignInAnimation.Stop();

            if (signin.FillColor != konec)
            {
                int[][] colors = {
                new int[] {48, 104, 194},
                new int[] {41, 89, 165},
                new int[] {39, 84, 157},
                new int[] {36, 77, 145},
                new int[] {29, 65, 124},
                new int[] {23, 52, 99},
                new int[] {17, 39, 76},
                new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    signin.FillColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }

            username.Visible = false;
            password.Visible = false;
        }

        private async void SignInAnimation2_Tick(object sender, EventArgs e)
        {
            SignInAnimation2.Stop();

            if (signin.ForeColor != konec)
            {
                int[][] colors = {
                new int[] {255, 255, 255},
                new int[] {222, 222, 222},
                new int[] {185, 186, 186},
                new int[] {144, 145, 146},
                new int[] {111, 111, 111},
                new int[] {67, 67, 67},
                new int[] {28, 28, 28},
                new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    signin.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }

                guna2ProgressBar1.Location = new Point(72, 206);
                signin.Hide();
            }
        }



        private async void AnimateLabel2Left_Tick(object sender, EventArgs e)
        {
            AnimateLabel2Left.Stop();

            for (int x = 28; x >= -103; x -= 8)
            {
                label2.Location = new Point(x, 73);
                await Task.Delay(3);
            }
        }


        private async void Label2TextColorChangeAnimation_Tick(object sender, EventArgs e)
        {
            Label2TextColorChangeAnimation.Stop();

            if (label2.ForeColor != konec)
            {
                int[][] colors = {
                new int[] {128, 128, 128},
                new int[] {100, 100, 100},
                new int[] {80, 80, 80},
                new int[] {60, 60, 60},
                new int[] {50, 50, 50},
                new int[] {30, 30, 30},
                new int[] {20, 20, 20},
                new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    label2.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private async void Label3TextColorAnimation_Tick(object sender, EventArgs e)
        {
            Label3TextColorAnimation.Stop();

            if (label3.ForeColor != konec)
            {
                int[][] colors = {
                new int[] {128, 128, 128},
                new int[] {100, 100, 100},
                new int[] {80, 80, 80},
                new int[] {60, 60, 60},
                new int[] {50, 50, 50},
                new int[] {30, 30, 30},
                new int[] {20, 20, 20},
                new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    label3.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private async void logotextColorChangeAnimation_Tick(object sender, EventArgs e)
        {
            logotextColorChangeAnimation.Stop();

            if (logotext.ForeColor != konec)
            {
                int[][] colors = {
                new int[] {255, 255, 255},
                new int[] {222, 222, 222},
                new int[] {185, 186, 186},
                new int[] {144, 145, 146},
                new int[] {111, 111, 111},
                new int[] {67, 67, 67},
                new int[] {28, 28, 28},
                new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    logotext.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }

        private async void OpacityAnimation_Tick(object sender, EventArgs e)
        {
            OpacityAnimation.Stop();

            for (int opacity = 99; opacity >= 1; opacity--)
            {
                this.Opacity = opacity / 100.0;
                await Task.Delay(10);
            }
        }


        private async void ExitAnimation_Tick(object sender, EventArgs e)
        {
            ExitAnimation.Stop();
            await Task.Delay(350);
            Application.Exit();
        }


        private async void label2HorizontalPositionAnimation_Tick(object sender, EventArgs e)
        {
            label2HorizontalPositionAnimation.Stop();

            for (int i = -103; i <= 65; i += 8)
            {
                label2.Location = new Point(i, 73);
                await Task.Delay(10);
            }

            label2TextColorAnimation.Start();
        }


        private async void ZBARVENITEXTUANIMACE_Tick(object sender, EventArgs e)
        {
            label2TextColorAnimation.Stop();

            if (label2.ForeColor == Color.White)
            {
                return;
            }

            for (int i = 128; i <= 255; i += 20)
            {
                label2.ForeColor = Color.FromArgb(i, i, i);
                await Task.Delay(10);
            }

            label2.ForeColor = Color.White;
        }


        // disable
        private async void logotextAnimation_Tick(object sender, EventArgs e)
        {
            logotext.Location = new Point(53, -1);

            for (int i = 0; i <= 21; i += 5)
            {
                logotext.Location = new Point(53, i);
                await Task.Delay(3);
            }
        }


        private async void signin_Click(object sender, EventArgs e)
        {
            Program.KeyAuthApp.login(username.Text, password.Text);
            if (!Program.KeyAuthApp.response.success)
            {
                ErrorMessageAnimation.Start();
                WrongXAnimation.Start();

                await Task.Delay(1000);
                WrongXBackAnimation.Start();
                ErrorMessageBackAnimation.Start();
            }
            else
            {
                HELLOANIMACEBARVA.Start();
                SignInAnimation.Start();
                logotextColorChangeAnimation.Start();
                LOGOPRYC.Start();
                Label3TextColorAnimation.Start();
                EXITCOLOR.Start();
                SignInAnimation2.Start();
                Fatalitypanelsead.Start();
                fatalitybttn.Show();
                legionbttn.Hide();
                primobttn.Hide();
                fatalitysedanabilou.Start();
                legionbackground.Visible = false;
                primopicture.Visible = false;
                fata.Visible = true;
                cheatselection.Text = "chres0";  // change
                await Task.Delay(100);
                LOGOTIMER.Start();
                PROGRESBARANIMACE.Start();


                for (var i = 0; i < Program.KeyAuthApp.user_data.subscriptions.Count; i++)
                {
                    expire.Text = " " + UnixTimeToDateTime(long.Parse(Program.KeyAuthApp.user_data.subscriptions[i].expiry));
                }
            }
        }

        private async void ErrorMessageAnimation_Tick(object sender, EventArgs e)
        {
            ErrorMessageAnimation.Stop();
            errornotification.Location = new Point(422, 245);
            await Task.Delay(3);
            errornotification.Location = new Point(373, 245);
            errornotification.Location = new Point(363, 245);
            await Task.Delay(3);
            errornotification.Location = new Point(352, 245);
            errornotification.Location = new Point(342, 245);
            await Task.Delay(3);
            errornotification.Location = new Point(332, 245);
            errornotification.Location = new Point(322, 245);
            await Task.Delay(3);
            errornotification.Location = new Point(312, 245);
            errornotification.Location = new Point(302, 245);
            await Task.Delay(3);
            errornotification.Location = new Point(292, 245);
            errornotification.Location = new Point(282, 245);
            await Task.Delay(3);
            errornotification.Location = new Point(272, 245);
            errornotification.Location = new Point(262, 245);
            await Task.Delay(3);
            errornotification.Location = new Point(252, 245);
            errornotification.Location = new Point(242, 245);
            await Task.Delay(3);
            errornotification.Location = new Point(232, 245);
            errornotification.Location = new Point(222, 245);

        }

        private async void WrongXAnimation_Tick(object sender, EventArgs e)
        {
            WrongXAnimation.Stop();

            wrongX.Location = new Point(375, 228);
            await Task.Delay(3);
            wrongX.Location = new Point(365, 228);
            wrongX.Location = new Point(355, 228);
            await Task.Delay(3);
            wrongX.Location = new Point(345, 228);
            wrongX.Location = new Point(335, 228);
            await Task.Delay(3);
            wrongX.Location = new Point(325, 228);
            wrongX.Location = new Point(315, 228);
            await Task.Delay(3);
            wrongX.Location = new Point(305, 228);
            wrongX.Location = new Point(295, 228);
            await Task.Delay(3);
            wrongX.Location = new Point(285, 228);
            wrongX.Location = new Point(275, 228);
            await Task.Delay(3);
            wrongX.Location = new Point(265, 228);
            wrongX.Location = new Point(255, 228);
            await Task.Delay(3);
            wrongX.Location = new Point(245, 228);
            wrongX.Location = new Point(235, 228);
            await Task.Delay(3);
            wrongX.Location = new Point(225, 228);
            wrongX.Location = new Point(215, 228);
            await Task.Delay(3);
            wrongX.Location = new Point(205, 228);
            wrongX.Location = new Point(195, 228);
            await Task.Delay(3);
            wrongX.Location = new Point(185, 228);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start("https://example.com");
        }

        private async void WrongXBackAnimation_Back(object sender, EventArgs e)
        {
            WrongXBackAnimation.Stop();

            int startX = 185;
            int step = 10;

            for (int i = 0; i < 22; i++)
            {
                wrongX.Location = new Point(startX + (i * step), 228);
                await Task.Delay(3);
            }
        }

        private async void ErrorMessageBackAnimation_Back(object sender, EventArgs e)
        {
            ErrorMessageBackAnimation.Stop();

            var positions = new Point[] {
                new Point(222, 245),
                new Point(232, 245),
                new Point(242, 245),
                new Point(252, 245),
                new Point(262, 245),
                new Point(272, 245),
                new Point(282, 245),
                new Point(292, 245),
                new Point(302, 245),
                new Point(312, 245),
                new Point(322, 245),
                new Point(332, 245),
                new Point(342, 245),
                new Point(352, 245),
                new Point(363, 245),
                new Point(373, 245),
                new Point(422, 245)
            };

            foreach (var position in positions)
            {
                errornotification.Location = position;
                await Task.Delay(3);
            }
        }


        private async void HELLOANIMACEBARVA_Tick(object sender, EventArgs e)
        {
            HELLOANIMACEBARVA.Stop();
            if (label2.ForeColor != konec)
            {
                var colorSteps = new Color[] {
                    Color.FromArgb(255, 255, 255),
                    Color.FromArgb(222, 222, 222),
                    Color.FromArgb(185, 186, 186),
                    Color.FromArgb(144, 145, 146),
                    Color.FromArgb(111, 111, 111),
                    Color.FromArgb(67, 67, 67),
                    Color.FromArgb(28, 28, 28),
                    Color.FromArgb(10, 10, 10)
                };

                foreach (var color in colorSteps)
                {
                    label2.ForeColor = color;
                    await Task.Delay(10);
                }
            }
        }


        private void LOGOPRYC_Tick(object sender, EventArgs e)
        {
            LOGOPRYC.Stop();
        }

        private void LOGOTIMER_Tick(object sender, EventArgs e)
        {
            LOGOTIMER.Stop();
        }

        private async void PROGRESBARANIMACE_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value += 1;

            if (guna2ProgressBar1.Value >= 100)
            {
                PROGRESBARANIMACE.Stop();
                await Task.Delay(400);
                PROGBARZMIZENI2.Start();
                PROGBARZMIZENI.Start();
                LOGOBAR.Start();
                await Task.Delay(10);
                EXITCOLORZPATKY.Start();
                LogoTextBackAnimation.Start();
                gamepanel.Location = new Point(22, 60);
                infopanel.Location = new Point(158, 60);
                cheatlist.Location = new Point(30, 47);
                information.Location = new Point(166, 47);

                LOGOVIDET.Start();
            }
        }


        private async void PROGBARZMIZENI_Tick(object sender, EventArgs e)
        {
            PROGBARZMIZENI.Stop();
            if (guna2ProgressBar1.ProgressColor2 != konec)
            {
                var colorSteps = new Color[] {
                    Color.FromArgb(48, 104, 194),
                    Color.FromArgb(41, 89, 165),
                    Color.FromArgb(39, 84, 157),
                    Color.FromArgb(36, 77, 145),
                    Color.FromArgb(29, 65, 124),
                    Color.FromArgb(23, 52, 99),
                    Color.FromArgb(17, 39, 76),
                    Color.FromArgb(10, 10, 10)
                };

                foreach (var color in colorSteps)
                {
                    guna2ProgressBar1.ProgressColor2 = color;
                    await Task.Delay(3);
                }
            }
        }


        private void LOGOBAR_Tick(object sender, EventArgs e)
        {
            LOGOBAR.Stop();
        }
        private async void PROGBARZMIZENI2_Tick(object sender, EventArgs e)
        {
            PROGBARZMIZENI2.Stop();
            if (guna2ProgressBar1.ProgressColor != konec)
            {
                var colorSteps = new Color[] {
                    Color.FromArgb(48, 104, 194),
                    Color.FromArgb(41, 89, 165),
                    Color.FromArgb(39, 84, 157),
                    Color.FromArgb(36, 77, 145),
                    Color.FromArgb(29, 65, 124),
                    Color.FromArgb(23, 52, 99),
                    Color.FromArgb(17, 39, 76),
                    Color.FromArgb(10, 10, 10)
                };

                foreach (var color in colorSteps)
                {
                    guna2ProgressBar1.ProgressColor = color;
                    await Task.Delay(3);
                }
            }
        }


        private void csgovyber_Click(object sender, EventArgs e)
        {
            Fatalitypanelsead.Start();
            fatalitybttn.Show();
            legionbttn.Hide();
            primobttn.Hide();
            fatalitysedanabilou.Start();
            legionbackground.Visible = false;
            primopicture.Visible = false;
            fata.Visible = true;
            cheatselection.Text = "Fatality.win";
        }

        private async void LOGOVIDET_Tick(object sender, EventArgs e)
        {
            LOGOVIDET.Stop();
        }

        private async void EXITCOLOR_Tick(object sender, EventArgs e)
        {
            EXITCOLOR.Stop();

            if (guna2ControlBox1.IconColor != konec)
            {
                int[][] colors = {
                new int[] {255, 255, 255},
                new int[] {222, 222, 222},
                new int[] {185, 186, 186},
                new int[] {144, 145, 146},
                new int[] {111, 111, 111},
                new int[] {67, 67, 67},
                new int[] {28, 28, 28},
                new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    guna2ControlBox1.IconColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private async void EXITCOLORZPATKY_Tick(object sender, EventArgs e)
        {
            EXITCOLORZPATKY.Stop();

            if (guna2ControlBox1.IconColor != bila)
            {
                int[][] colors = {
                new int[] {10, 10, 10},
                new int[] {28, 28, 28},
                new int[] {67, 67, 67},
                new int[] {111, 111, 111},
                new int[] {144, 144, 144},
                new int[] {185, 185, 185},
                new int[] {222, 222, 222},
                new int[] {255, 255, 255}
                };

                foreach (var color in colors)
                {
                    guna2ControlBox1.IconColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }

        private async void LogoTextBackAnimation_Back(object sender, EventArgs e)
        {
            LogoTextBackAnimation.Stop();

            if (logotext.ForeColor != bila)
            {
                int[][] colors = {
                new int[] {10, 10, 10},
                new int[] {28, 28, 28},
                new int[] {67, 67, 67},
                new int[] {111, 111, 111},
                new int[] {144, 144, 144},
                new int[] {185, 185, 185},
                new int[] {222, 222, 222},
                new int[] {255, 255, 255}
                };

                foreach (var color in colors)
                {
                    logotext.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }

        private void guna2ShadowPanel1_Click(object sender, EventArgs e)
        {
            fatalitytextbarva.Start();
            fatalitybttn.Hide();
            Fatalitypanelzpatky.Start();
            legionbttn.Hide();
            primobttn.Show();
            legionbackground.Visible = false;
            cheatselection.Text = "Primordial.dev";
            primopicture.Visible = true;
            fata.Visible = false;
        }

        private async void fatalitytextbarva_Tick(object sender, EventArgs e)
        {
            fatalitytextbarva.Stop();

            if (fatalitytext.ForeColor != seda)
            {
                Color[] colorSteps = {
                    Color.FromArgb(255, 255, 255),
                    Color.FromArgb(240, 240, 240),
                    Color.FromArgb(220, 220, 220),
                    Color.FromArgb(200, 200, 200),
                    Color.FromArgb(180, 180, 180),
                    Color.FromArgb(160, 160, 160),
                    Color.FromArgb(140, 140, 140),
                    Color.FromArgb(128, 128, 128)
                };

                foreach (var color in colorSteps)
                {
                    fatalitytext.ForeColor = color;
                    await Task.Delay(10);
                }
            }
        }


        private async void fatalitysedanabilou_Tick(object sender, EventArgs e)
        {
            fatalitysedanabilou.Stop();

            if (fatalitytext.ForeColor != bila)
            {
                int[][] colorSteps = {
                    new int[] { 128, 128, 128 },
                    new int[] { 140, 140, 140 },
                    new int[] { 160, 160, 160 },
                    new int[] { 180, 180, 180 },
                    new int[] { 200, 200, 200 },
                    new int[] { 220, 220, 220 },
                    new int[] { 240, 240, 240 },
                    new int[] { 255, 255, 255 }
                };

                foreach (var color in colorSteps)
                {
                    fatalitytext.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private void legionpanel_Click(object sender, EventArgs e)
        {
            fatalitybttn.Hide();
            legionbttn.Show();
            primobttn.Hide();
            fatalitytextbarva.Start();
            Fatalitypanelzpatky.Start();
            primopicture.Visible = false;
            legionbackground.Visible = true;
            cheatselection.Text = "Legions.win";
            fata.Visible = false;
        }

        private void primotext_Click(object sender, EventArgs e)
        {
            fatalitytextbarva.Start();
            Fatalitypanelzpatky.Start();
            fatalitybttn.Hide();
            legionbttn.Hide();
            primobttn.Show();

            legionbackground.Visible = false;
            cheatselection.Text = "Primordial.dev";
            primopicture.Visible = true;
            fata.Visible = false;
        }

        private void legionstext_Click(object sender, EventArgs e)
        {
            fatalitytextbarva.Start();
            fatalitybttn.Hide();
            Fatalitypanelzpatky.Start();
            legionbttn.Show();
            primobttn.Hide();
            cheatselection.Text = "Legions.win";
            primopicture.Visible = false;
            legionbackground.Visible = true;
            fata.Visible = false;
        }

        private void fatalitytext_Click(object sender, EventArgs e)
        {

            Fatalitypanelsead.Start();
            fatalitybttn.Show();
            legionbttn.Hide();
            primobttn.Hide();
            fatalitysedanabilou.Start();
            legionbackground.Visible = false;
            primopicture.Visible = false;
            fata.Visible = true;
            cheatselection.Text = "Unturned";
        }

        private async void legionbttn_Click(object sender, EventArgs e)
        {
            HELLOANIMACEBARVA.Start();
            SignInAnimation.Start();
            logotextColorChangeAnimation.Start();
            LOGOPRYC.Start();
            Label3TextColorAnimation.Start();
            EXITCOLOR.Start();
            sedylogin.Start();
            SignInAnimation2.Start();

            legionbackground.Visible = false;



            primopicture.Visible = false;
            fata.Visible = false;

            fatalitypanelshadow.Start();
            gamepanelshadow.Start();
            infopanelshadow.Start();



            label4pryc.Start();
            label5pryc.Start();
            label6pryc.Start();
            label7pryc.Start();
            label8pryc.Start();
            cheatpryc.Start();
            undetectedpryc.Start();
            expirepryc.Start();

            legionbttnpryc.Start();
            primobttnpryc.Start();
            fatalitybttnpryc.Start();

            cheatlistpryc.Start();
            informationpryc.Start();
            fatalitytextseda.Start();
            fatalitybttnbila.Start();
            legionsbttnbila.Start();
            primordialbttnbila.Start();

            guna2ProgressBar2.Location = new Point(72, 206);
            gamepanel.Hide();
            infopanel.Hide();

            await Task.Delay(250);
            LOGOTIMER.Start();

            progressbarinject.Start();
        }

        private async void primobttn_Click(object sender, EventArgs e)
        {
            HELLOANIMACEBARVA.Start();
            SignInAnimation.Start();
            logotextColorChangeAnimation.Start();
            LOGOPRYC.Start();
            Label3TextColorAnimation.Start();
            EXITCOLOR.Start();
            sedylogin.Start();
            SignInAnimation2.Start();

            legionbackground.Visible = false;


            primopicture.Visible = false;

            fata.Visible = false;

            fatalitypanelshadow.Start();
            gamepanelshadow.Start();
            infopanelshadow.Start();



            label4pryc.Start();
            label5pryc.Start();
            label6pryc.Start();
            label7pryc.Start();
            label8pryc.Start();
            cheatpryc.Start();
            undetectedpryc.Start();
            expirepryc.Start();

            legionbttnpryc.Start();
            primobttnpryc.Start();
            fatalitybttnpryc.Start();

            cheatlistpryc.Start();
            informationpryc.Start();
            fatalitytextseda.Start();
            fatalitybttnbila.Start();
            legionsbttnbila.Start();
            primordialbttnbila.Start();

            guna2ProgressBar2.Location = new Point(72, 206);
            gamepanel.Hide();
            infopanel.Hide();


            await Task.Delay(250);
            LOGOTIMER.Start();

            progressbarinject.Start();
        }

        private async void fatalitybttn_Click(object sender, EventArgs e)
        {
            HELLOANIMACEBARVA.Start();
            SignInAnimation.Start();
            logotextColorChangeAnimation.Start();
            LOGOPRYC.Start();
            Label3TextColorAnimation.Start();
            EXITCOLOR.Start();
            sedylogin.Start();
            SignInAnimation2.Start();


            legionbackground.Visible = false;


            primopicture.Visible = false;

            fata.Visible = false;

            fatalitypanelshadow.Start();
            gamepanelshadow.Start();
            infopanelshadow.Start();



            label4pryc.Start();
            label5pryc.Start();
            label6pryc.Start();
            label7pryc.Start();
            label8pryc.Start();
            cheatpryc.Start();
            undetectedpryc.Start();
            expirepryc.Start();

            legionbttnpryc.Start();
            primobttnpryc.Start();
            fatalitybttnpryc.Start();

            cheatlistpryc.Start();
            informationpryc.Start();

            fatalitytextpryc.Start();
            fatalitybttnbila.Start();
            legionsbttnbila.Start();
            primordialbttnbila.Start();

            legionbttn.Hide();
            primobttn.Hide();
            fatalitybttn.Hide();

            guna2ProgressBar2.Location = new Point(72, 206);
            gamepanel.Hide();
            infopanel.Hide();

            await Task.Delay(250);
            LOGOTIMER.Start();

            progressbarinject.Start();
        }

        private async void Fatalitypanelsead_Tick(object sender, EventArgs e)
        {
            Fatalitypanelsead.Stop();

            if (fatalityvyber.FillColor != cernoch)
            {
                fatalityvyber.FillColor = Color.FromArgb(10, 10, 10);
                await Task.Delay(10);
                fatalityvyber.FillColor = Color.FromArgb(17, 16, 17);
            }
        }


        private async void Fatalitypanelzpatky_Tick(object sender, EventArgs e)
        {
            Fatalitypanelzpatky.Stop();

            if (fatalityvyber.FillColor != konec)
            {
                fatalityvyber.FillColor = Color.FromArgb(17, 16, 17);
                await Task.Delay(10);
                fatalityvyber.FillColor = Color.FromArgb(10, 10, 10);
            }
        }


        private async void fatalitypanelshadow_Tick(object sender, EventArgs e)
        {
            fatalitypanelshadow.Stop();

            if (fatalityvyber.ShadowColor != konec)
            {
                fatalityvyber.ShadowColor = Color.FromArgb(21, 19, 21);
                await Task.Delay(10);
                fatalityvyber.ShadowColor = Color.FromArgb(10, 10, 10);
            }
        }


        private async void gamepanelshadow_Tick(object sender, EventArgs e)
        {
            gamepanelshadow.Stop();

            if (gamepanel.ShadowColor != konec)
            {
                gamepanel.ShadowColor = Color.FromArgb(21, 19, 21);
                await Task.Delay(10);
                gamepanel.ShadowColor = Color.FromArgb(10, 10, 10);
            }
        }


        private async Task ChangeLabelColor(Label label)
        {
            if (label.ForeColor == konec)
            {
                return;
            }

            int[][] colors = {
                new int[] {255, 255, 255},
                new int[] {222, 222, 222},
                new int[] {185, 186, 186},
                new int[] {144, 145, 146},
                new int[] {111, 111, 111},
                new int[] {67, 67, 67},
                new int[] {28, 28, 28},
                new int[] {10, 10, 10}
            };

            foreach (var color in colors)
            {
                label.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                await Task.Delay(10);
            }
        }


        private async void label4pryc_Tick(object sender, EventArgs e)
        {
            label4pryc.Stop();
            await ChangeLabelColor(label4);
        }

        private async void label5pryc_Tick(object sender, EventArgs e)
        {
            label5pryc.Stop();
            await ChangeLabelColor(label5);
        }

        private async void label6pryc_Tick(object sender, EventArgs e)
        {
            label6pryc.Stop();
            await ChangeLabelColor(label6);
        }

        private async void label7pryc_Tick(object sender, EventArgs e)
        {
            label7pryc.Stop();
            await ChangeLabelColor(label7);
        }


        private async void cheatpryc_Tick(object sender, EventArgs e)
        {
            cheatpryc.Stop();

            if (cheatselection.ForeColor != konec)
            {
                int[][] colors = {
                    new int[] {48, 104, 194},
                    new int[] {41, 89, 165},
                    new int[] {39, 84, 157},
                    new int[] {36, 77, 145},
                    new int[] {29, 65, 124},
                    new int[] {23, 52, 99},
                    new int[] {17, 39, 76},
                    new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    cheatselection.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private async void undetectedpryc_Tick(object sender, EventArgs e)
        {
            undetectedpryc.Stop();

            if (undetected.ForeColor != konec)
            {
                int[][] colors = {
                    new int[] {109, 179, 91},
                    new int[] {98, 160, 82},
                    new int[] {85, 139, 71},
                    new int[] {74, 120, 62},
                    new int[] {61, 99, 51},
                    new int[] {47, 77, 39},
                    new int[] {21, 21, 21},
                    new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    undetected.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private async void expirepryc_Tick(object sender, EventArgs e)
        {
            expirepryc.Stop();

            if (expire.ForeColor != konec)
            {
                int[][] colors = {
                    new int[] {48, 104, 194},
                    new int[] {41, 89, 165},
                    new int[] {39, 84, 157},
                    new int[] {36, 77, 145},
                    new int[] {29, 65, 124},
                    new int[] {23, 52, 99},
                    new int[] {17, 39, 76},
                    new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    expire.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private async void label8pryc_Tick(object sender, EventArgs e)
        {
            label8pryc.Stop();

            if (label8.ForeColor != konec)
            {
                int[][] colors = {
                new int[] {48, 104, 194},
                new int[] {41, 89, 165},
                new int[] {39, 84, 157},
                new int[] {36, 77, 145},
                new int[] {29, 65, 124},
                new int[] {23, 52, 99},
                new int[] {17, 39, 76},
                new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    label8.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private async void legionbttnpryc_Tick(object sender, EventArgs e)
        {
            legionbttnpryc.Stop();

            if (legionbttn.FillColor != konec)
            {
                int[][] colors = {
                    new int[] {48, 104, 194},
                    new int[] {41, 89, 165},
                    new int[] {39, 84, 157},
                    new int[] {36, 77, 145},
                    new int[] {29, 65, 124},
                    new int[] {23, 52, 99},
                    new int[] {17, 39, 76},
                    new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    legionbttn.FillColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private async void primobttnpryc_Tick(object sender, EventArgs e)
        {
            primobttnpryc.Stop();

            if (primobttn.FillColor != konec)
            {
                int[][] colors = {
                new int[] {48, 104, 194},
                new int[] {41, 89, 165},
                new int[] {39, 84, 157},
                new int[] {36, 77, 145},
                new int[] {29, 65, 124},
                new int[] {23, 52, 99},
                new int[] {17, 39, 76},
                new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    primobttn.FillColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private async void fatalitybttnpryc_Tick(object sender, EventArgs e)
        {
            fatalitybttnpryc.Stop();

            if (fatalitybttn.FillColor != konec)
            {
                int[][] colors = {
                new int[] {48, 104, 194},
                new int[] {41, 89, 165},
                new int[] {39, 84, 157},
                new int[] {36, 77, 145},
                new int[] {29, 65, 124},
                new int[] {23, 52, 99},
                new int[] {17, 39, 76},
                new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    fatalitybttn.FillColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private async void informationpryc_Tick(object sender, EventArgs e)
        {
            informationpryc.Stop();

            if (information.ForeColor != konec)
            {
                int[][] colors = {
                new int[] {128, 128, 128},
                new int[] {100, 100, 100},
                new int[] {80, 80, 80},
                new int[] {60, 60, 60},
                new int[] {50, 50, 50},
                new int[] {30, 30, 30},
                new int[] {20, 20, 20},
                new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    information.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private async void cheatlistpryc_Tick(object sender, EventArgs e)
        {
            cheatlistpryc.Stop();

            if (cheatlist.ForeColor != konec)
            {
                int[][] colors = {
                new int[] {128, 128, 128},
                new int[] {100, 100, 100},
                new int[] {80, 80, 80},
                new int[] {60, 60, 60},
                new int[] {50, 50, 50},
                new int[] {30, 30, 30},
                new int[] {20, 20, 20},
                new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    cheatlist.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private async void infopanelshadow_Tick(object sender, EventArgs e)
        {
            infopanelshadow.Stop();

            if (infopanel.ShadowColor != konec)
            {
                int[][] colors = {
                new int[] {21, 19, 21},
                new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    infopanel.ShadowColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private async void fatalitytextpryc_Tick(object sender, EventArgs e)
        {
            fatalitytextpryc.Stop();

            if (fatalitytext.ForeColor != konec)
            {
                int[][] colors = {
                new int[] {255, 255, 255},
                new int[] {222, 222, 222},
                new int[] {185, 186, 186},
                new int[] {144, 145, 146},
                new int[] {111, 111, 111},
                new int[] {67, 67, 67},
                new int[] {28, 28, 28},
                new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    fatalitytext.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private async void fatalitytextseda_Tick(object sender, EventArgs e)
        {
            fatalitytextseda.Stop();

            if (fatalitytext.ForeColor != konec)
            {
                int[][] colors = {
                new int[] {128, 128, 128},
                new int[] {100, 100, 100},
                new int[] {80, 80, 80},
                new int[] {60, 60, 60},
                new int[] {50, 50, 50},
                new int[] {30, 30, 30},
                new int[] {20, 20, 20},
                new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    fatalitytext.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private async void progressbarinject_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar2.Value += 1;

            if (guna2ProgressBar2.Value >= 100)
            {
                progressbarinject.Stop();
                await Task.Delay(400);
                this.Hide();
                Form2 main = new Form2();
                main.Show();
            }
        }


        private async void fatalitybttnbila_Tick(object sender, EventArgs e)
        {
            fatalitybttnbila.Stop();

            if (fatalitybttn.ForeColor != konec)
            {
                int[][] colors = {
                new int[] {255, 255, 255},
                new int[] {222, 222, 222},
                new int[] {185, 186, 186},
                new int[] {144, 145, 146},
                new int[] {111, 111, 111},
                new int[] {67, 67, 67},
                new int[] {28, 28, 28},
                new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    fatalitybttn.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private async void primordialbttnbila_Tick(object sender, EventArgs e)
        {
            primordialbttnbila.Stop();

            if (primobttn.ForeColor != konec)
            {
                int[][] colors = {
                new int[] {255, 255, 255},
                new int[] {222, 222, 222},
                new int[] {185, 186, 186},
                new int[] {144, 145, 146},
                new int[] {111, 111, 111},
                new int[] {67, 67, 67},
                new int[] {28, 28, 28},
                new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    primobttn.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }


        private async void legionsbttnbila_Tick(object sender, EventArgs e)
        {
            legionsbttnbila.Stop();

            if (legionbttn.ForeColor != konec)
            {
                int[][] colors = {
                new int[] {255, 255, 255},
                new int[] {222, 222, 222},
                new int[] {185, 186, 186},
                new int[] {144, 145, 146},
                new int[] {111, 111, 111},
                new int[] {67, 67, 67},
                new int[] {28, 28, 28},
                new int[] {10, 10, 10}
                };

                foreach (var color in colors)
                {
                    legionbttn.ForeColor = Color.FromArgb(color[0], color[1], color[2]);
                    await Task.Delay(10);
                }
            }
        }

        private void sedylogin_Tick(object sender, EventArgs e)
        {
            sedylogin.Stop();
        }

        // Ohh, it's finally over //
    }
}

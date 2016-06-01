using System;
using System.Security.Cryptography;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Hangman
{
    [Activity (Label = "Play Hangman")]
    public class Hangman : Activity
    {
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button btnE;
        private Button btnF;
        private Button btnG;
        private Button btnH;
        private Button btnI;
        private Button btnJ;
        private Button btnK;
        private Button btnL;
        private Button btnM;
        private Button btnN;
        private Button btnO;
        private Button btnP;
        private Button btnQ;
        private Button btnR;
        private Button btnS;
        private Button btnT;
        private Button btnU;
        private Button btnV;
        private Button btnW;
        private Button btnX;
        private Button btnY;
        private Button btnZ;
        

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //
            SetContentView(Resource.Layout.Main);

            IntializeControls();
        }

        public void IntializeControls()
        {
            btnA = FindViewById<Button>(Resource.Id.btnA);
            btnB = FindViewById<Button>(Resource.Id.btnB);
            btnC = FindViewById<Button>(Resource.Id.btnC);
            btnD = FindViewById<Button>(Resource.Id.btnD);
            btnE = FindViewById<Button>(Resource.Id.btnE);
            btnF = FindViewById<Button>(Resource.Id.btnF);
            btnG = FindViewById<Button>(Resource.Id.btnG);
            btnH = FindViewById<Button>(Resource.Id.btnH);
            btnI = FindViewById<Button>(Resource.Id.btnI);
            btnJ = FindViewById<Button>(Resource.Id.btnJ);
            btnK = FindViewById<Button>(Resource.Id.btnK);
            btnL = FindViewById<Button>(Resource.Id.btnL);
            btnM = FindViewById<Button>(Resource.Id.btnM);
            btnN = FindViewById<Button>(Resource.Id.btnN);
            btnO = FindViewById<Button>(Resource.Id.btnO);
            btnP = FindViewById<Button>(Resource.Id.btnP);
            btnQ = FindViewById<Button>(Resource.Id.btnQ);
            btnR = FindViewById<Button>(Resource.Id.btnR);
            btnS = FindViewById<Button>(Resource.Id.btnS);
            btnT = FindViewById<Button>(Resource.Id.btnT);
            btnU = FindViewById<Button>(Resource.Id.btnU);
            btnV = FindViewById<Button>(Resource.Id.btnV);
            btnW = FindViewById<Button>(Resource.Id.btnW);
            btnX = FindViewById<Button>(Resource.Id.btnX);
            btnY = FindViewById<Button>(Resource.Id.btnY);
            btnZ = FindViewById<Button>(Resource.Id.btnZ);

            btnA.Click += BtnAll_Click;
            btnB.Click += BtnAll_Click;
            btnC.Click += BtnAll_Click;
            btnD.Click += BtnAll_Click;
            btnE.Click += BtnAll_Click;
            btnF.Click += BtnAll_Click;
            btnG.Click += BtnAll_Click;
            btnH.Click += BtnAll_Click;
            btnI.Click += BtnAll_Click;
            btnJ.Click += BtnAll_Click;
            btnK.Click += BtnAll_Click;
            btnL.Click += BtnAll_Click;
            btnM.Click += BtnAll_Click;
            btnN.Click += BtnAll_Click;
            btnO.Click += BtnAll_Click;
            btnP.Click += BtnAll_Click;
            btnQ.Click += BtnAll_Click;
            btnR.Click += BtnAll_Click;
            btnS.Click += BtnAll_Click;
            btnT.Click += BtnAll_Click;
            btnU.Click += BtnAll_Click;
            btnV.Click += BtnAll_Click;
            btnW.Click += BtnAll_Click;
            btnX.Click += BtnAll_Click;
            btnY.Click += BtnAll_Click;
            btnZ.Click += BtnAll_Click;
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            //Disabling buttons when clicked
            Button clickedButton = (Button) sender;
            clickedButton.Enabled = false;
        }

        
    }

    
}


using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Hangman
{
    [Activity (Label = "Hangman", Icon = "@drawable/icon")]
    public class MainActivity : Activity
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

            //Disables buttons after click
            btnA.Click += delegate
            {
                btnA.Enabled = false;
            };
            btnB.Click += delegate
            {
                btnB.Enabled = false;
            };
            btnC.Click += delegate
            {
                btnC.Enabled = false;
            };
            btnD.Click += delegate
            {
                btnD.Enabled = false;
            };
            btnE.Click += delegate
            {
                btnE.Enabled = false;
            };
            btnF.Click += delegate
            {
                btnF.Enabled = false;
            };
            btnG.Click += delegate
            {
                btnG.Enabled = false;
            };
            btnH.Click += delegate
            {
                btnH.Enabled = false;
            };
            btnI.Click += delegate
            {
                btnI.Enabled = false;
            };
            btnJ.Click += delegate
            {
                btnJ.Enabled = false;
            };
            btnK.Click += delegate
            {
                btnK.Enabled = false;
            };
            btnL.Click += delegate
            {
                btnL.Enabled = false;
            };
            btnM.Click += delegate
            {
                btnM.Enabled = false;
            };
            btnN.Click += delegate
            {
                btnN.Enabled = false;
            };
            btnO.Click += delegate
            {
                btnO.Enabled = false;
            };
            btnP.Click += delegate
            {
                btnP.Enabled = false;
            };
            btnQ.Click += delegate
            {
                btnQ.Enabled = false;
            };
            btnR.Click += delegate
            {
                btnR.Enabled = false;
            };
            btnS.Click += delegate
            {
                btnS.Enabled = false;
            };
            btnT.Click += delegate
            {
                btnT.Enabled = false;
            };
            btnU.Click += delegate
            {
                btnU.Enabled = false;
            };
            btnV.Click += delegate
            {
                btnV.Enabled = false;
            };
            btnW.Click += delegate
            {
                btnW.Enabled = false;
            };
            btnX.Click += delegate
            {
                btnX.Enabled = false;
            };
            btnY.Click += delegate
            {
                btnY.Enabled = false;
            };
            btnZ.Click += delegate
            {
                btnZ.Enabled = false;
            };




        }


       




    }
}


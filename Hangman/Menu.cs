using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Hangman
{
    [Activity(Label = "Menu", MainLauncher = true)]
    public class Menu : Activity
    {
        private Spinner spinner;
        private string difficulty = "Easy";
        private Button btnPlay;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Menu);

            SpinnerSetup();
            IntializeControls();
        }


        public void IntializeControls()
        {
            btnPlay = FindViewById<Button>(Resource.Id.btnPlay);

            btnPlay.Click += onBtnPlayClick;

            //btnPlay.Click += delegate
            //{
            //    StartActivity(typeof(Main));
            //};


        }

        void onBtnPlayClick(object sender, EventArgs e)
        {
            //StartActivity(typeof(Main));
        }

        private void SpinnerSetup()
        {
            //Tie in the spinner
            try
            {
                var spinner = FindViewById<Spinner>(Resource.Id.SPDifficulty);

                //Tie it to the method
                spinner.ItemSelected += spinner_ItemSelected;

                //TheCreateFromResource() method then creates a new ArrayAdapter, which binds each item in the string array to the initial appearance for the Spinner
                var arrayadapter = ArrayAdapter.CreateFromResource(this, Resource.Array.difficulty_array, Android.Resource.Layout.SimpleSpinnerDropDownItem);

                arrayadapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);

                //Setting the ArrayAdapter to associate all of its items with the Spinner by setting the Adapter property 
                spinner.Adapter = arrayadapter;
            }
            catch (Exception e)
            {
                Console.WriteLine("Spinner error " + e.Message);
            }
        }

        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            //Making a fake spinner to send through data to it
            var spinner = (Spinner)sender;

            //difficulty = spinner.GetItemAtPosition(e.Position).ToString();

            string toast = string.Format("Difficulty set to {0}", spinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();

            //difficulty = difficulty.ToLower();
        }

    }

    
}
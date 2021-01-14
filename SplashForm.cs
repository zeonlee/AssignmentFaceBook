using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace AssignmentFaceBook
{
    public class SplashScreen1 : Form
    {


        //Delegate for cross thread call to close
        private delegate void CloseDelegate();

        //The type of form to be displayed as the splash screen.
        private static SplashScreen splashForm;

        static public void ShowSplashScreen()
        {
            // Make sure it is only launched once.    
            if (splashForm != null) return;
            splashForm = new SplashScreen();
            
            Thread thread = new Thread(new ThreadStart(SplashScreen1.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static private void ShowForm()
        {
            if (splashForm != null) Application.Run(splashForm);
        }

        static public void CloseForm()
        {
            splashForm?.Invoke(new CloseDelegate(SplashScreen1.CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            if (splashForm != null)
            {
                splashForm.Close();
                splashForm = null;
            };
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SplashScreen
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

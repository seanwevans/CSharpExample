using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace events
{
    public partial class events : Form
    {
        public events()
        {
            InitializeComponent();
        }
     
        
        
        //
        // class variables
        //
          
        // languages & default language
        enum languages { ENGLISH, FRENCH, GERMAN, ITALIAN, SPANISH };
        int currentLanguage = (int)languages.ENGLISH;

        // default color
        const string bgColor = "fff2f2f2";  // windows gray
        Color currentColor = ColorTranslator.FromHtml("#FFF2F2F2");
        string currentColorName = "fff2f2f2";

        // holds color translation values, referenced by hex code key
        // colorDict["fff71514"] = { "Red", "Rouge", "Rot", "Rosso", "Rojo" };
        Dictionary<string, string[]> colorDict = new Dictionary<string, string[]>();

        // background image
        Bitmap background = new Bitmap("Colors.png");
        
        
        
        //
        // form load event
        //
                          
        private void events_Load(object sender, EventArgs e)
        {            
            // set background and read in translations to dictionary
            BackgroundImage = background;
            string[] colorCodes = File.ReadAllLines("Colors Translated.txt");

            foreach (string s in colorCodes)
            {
                string[] spl = s.Split(',');              
                string[] cols = { spl[1], spl[2], spl[3], spl[4], spl[5] };
                colorDict.Add(spl[0], cols);
            }
        }

        //
        // form keydown event
        //

        private void events_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.I)
            {
                MessageBox.Show("You can choose from five different languages by clicking on the radio buttons");
            }

            if (e.Shift && e.KeyCode == Keys.A)
            {
                MessageBox.Show("Version 1.0");
            }
        }

        //
        // form mouse down event
        //

        private void events_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Just click on the color chip to see the translation");
            }
            else
            {
                UpdateColor(e);
            }            
        }

        
        
        //
        // update current color
        //

        private void UpdateColor(MouseEventArgs e = null)
        {   
            // if called from form mousedown event change color
            if (e != null)
            {
                currentColor = background.GetPixel(e.X, e.Y);                
            }
            
            // update color label
            try
            {
                currentColorName = colorDict[currentColor.Name][currentLanguage];
            }
            catch (KeyNotFoundException)
            {
                currentColorName = colorDict[bgColor][currentLanguage];
            }

            lblColor.Text = currentColorName;
        }



        //
        // radio button mouse down events
        // change language and update color
        //

        private void rdoEnglish_Click(object sender, EventArgs e)
        {
            currentLanguage = (int)languages.ENGLISH;
            UpdateColor();
        }

        private void rdoFrench_Click(object sender, EventArgs e)
        {
            currentLanguage = (int)languages.FRENCH;
            UpdateColor();
        }

        private void rdoGerman_Click(object sender, EventArgs e)
        {
            currentLanguage = (int)languages.GERMAN;
            UpdateColor();
        }

        private void rdoItalian_Click(object sender, EventArgs e)
        {
            currentLanguage = (int)languages.ITALIAN;
            UpdateColor();
        }

        private void rdoSpanish_Click(object sender, EventArgs e)
        {
            currentLanguage = (int)languages.SPANISH;
            UpdateColor();
        }                
    }
}

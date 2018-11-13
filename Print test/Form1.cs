//This is a simple programm to print to a dymo labelmanager PNP using c# winforms and the dymo labelmanager framework (included into Dymo's SDK)
//Designed by L'elektrongeek     

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DYMO.Label.Framework; //include Dymo framework (available in dymo SDK)
using MetroFramework.Forms; //include Metroframework (just for cosmetic purposes)

namespace Print_test
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Print(string TEXT_TO_PRINT) // Create a function to print a a string , using a label as mask file 
        {
            var label_file = DYMO.Label.Framework.Label.Open("Label.label"); // Open mask file (created on DYMO Label Software v8)
            label_file.SetObjectText("DynamicText", TEXT_TO_PRINT); // link the object "dynText" (on label file) to the string "TEXT_TO_PRINT" 

            label_file.Print("DYMO LabelManager PnP"); //Print on printer called "DYMO LabelManager PnP" (You can change this to any printer colmpatible with DYMO Label Software v8)
        }

        private void PRINT_Button_Click(object sender, EventArgs e)
        {
            Print(STRING_TO_BE_PRINTED.Text.ToString()); //Call the print function with the entered text as the string argument
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrosswordCall
{
    public partial class Call : UserControl
    {
        public Label LetterCall { get { return letterCall; } }
        public Label NumberTop { get { return numberTop; } }
        public Label NumberBottom { get { return numberBottom; } }
        
        public Call()
        {
            InitializeComponent();

            numberTop.Parent = letterCall;
            numberTop.Font = new Font("Verdana", 8);
            numberBottom.Parent = letterCall;
            numberBottom.Font = new Font("Verdana", 8);
        }
    }
}

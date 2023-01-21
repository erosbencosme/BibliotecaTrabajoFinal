using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaTrabajoFinal
{
    public partial class ControlLibro : UserControl
    {
        public ControlLibro()
        {
            InitializeComponent();
            dateTimeLibro.Format = DateTimePickerFormat.Custom;
            dateTimeLibro.CustomFormat = "yyyy";
            dateTimeLibro.ShowUpDown = true;
        }
    }
}

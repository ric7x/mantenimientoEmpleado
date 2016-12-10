using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoEmpleados
{
    class habilitarYDeshabilitar
    {

        public void deshabilitar(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Enabled=false;
                }                   
        
        else if(txt is ComboBox)
            {
                ((ComboBox)txt).Enabled = false;
            }
                else if (txt is DateTimePicker)
                {
                    ((DateTimePicker)txt).Enabled = false;
                }



            }
        }


        public void habilitar(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Enabled = true;
                }

                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).Enabled = true;
                }
                else if (txt is DateTimePicker)
                {
                    ((DateTimePicker)txt).Enabled = true;
                }



            }
        }

       






    }
}

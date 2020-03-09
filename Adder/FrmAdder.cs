using System;
using System.Windows.Forms;

namespace Adder
{
    public partial class FrmAdder : Form
    {
        public FrmAdder()
        {
            Random rnd = new Random();
            this.num1 = Convert.ToByte(rnd.Next(0, 15));
            this.num2 = Convert.ToByte(rnd.Next(0, 15));
            InitializeComponent();
            this.updateValues(group: "num1", value: this.num1);
            this.updateValues(group: "num2", value: this.num2);
        }

        private byte num1 = 0;
        private byte num2 = 0;
        private byte result = 0;

        /// <summary>
        /// Mithilfe des übergebenen Objekts wird der Name des ausgelösten Objektes
        /// herausgefunden
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>Gibt den Name des Form-Objekts zurück</returns>
        private string getNameFromSender(object sender)
        {
            string name = "";
            if (sender.GetType() == typeof(NumericUpDown))
            {
                NumericUpDown num = (NumericUpDown)sender;
                name = num.Name;
            }
            else if (sender.GetType() == typeof(ComboBox))
            {
                ComboBox cmb = (ComboBox)sender;
                name = cmb.Name;
            }
            return name;
        }

        /// <summary>
        /// Mithilfe des übergebenes Wertes werden die Formularfelder ausgefüllt
        /// </summary>
        /// <param name="group"></param>
        /// <param name="value"></param>
        private void updateValues(string group, byte value)
        {
            if (group == "num1")
            {
                this.num1 = value;
                // BitNumbers
                string strValue = Convert.ToString(value, 2).PadLeft(4, '0');
                numNum1Bit3.Value = Convert.ToDecimal(strValue[0].ToString());
                numNum1Bit2.Value = Convert.ToDecimal(strValue[1].ToString());
                numNum1Bit1.Value = Convert.ToDecimal(strValue[2].ToString());
                numNum1Bit0.Value = Convert.ToDecimal(strValue[3].ToString());

                // DecNumber
                numNum1Dec.Value = (decimal)value;

                // HexNumber
                cmbNum1Hex.SelectedIndex = cmbNum1Hex.FindStringExact(Convert.ToString(value, 16));
            }
            if (group == "num2")
            {
                this.num2 = value;
                // BitNumbers
                string strValue = Convert.ToString(value, 2).PadLeft(4, '0');
                numNum2Bit3.Value = Convert.ToDecimal(strValue[0].ToString());
                numNum2Bit2.Value = Convert.ToDecimal(strValue[1].ToString());
                numNum2Bit1.Value = Convert.ToDecimal(strValue[2].ToString());
                numNum2Bit0.Value = Convert.ToDecimal(strValue[3].ToString());

                // DecNumber
                numNum2Dec.Value = (decimal)value;

                // HexNumber
                cmbNum2Hex.SelectedIndex = cmbNum1Hex.FindStringExact(Convert.ToString(value, 16));
            }
            if (group == "result")
            {
                // BitNumbers
                string strValue = Convert.ToString(value, 2).PadLeft(4, '0');
                numResultBit3.Value = Convert.ToDecimal(strValue[0].ToString());
                numResultBit2.Value = Convert.ToDecimal(strValue[1].ToString());
                numResultBit1.Value = Convert.ToDecimal(strValue[2].ToString());
                numResultBit0.Value = Convert.ToDecimal(strValue[3].ToString());

                // DecNumber
                numResultDec.Value = (decimal)value;

                // HexNumber
                cmbResultHex.SelectedIndex = cmbNum1Hex.FindStringExact(Convert.ToString(value, 16));
            }
        }

        /// <summary>
        /// Event-Handler für Nummer1-Gruppe.
        /// Wenn sich die Nummer1 ändert, werden alle Formularfelder
        /// für die Nummer 1 geändert.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void num1_ValueChanged(object sender, EventArgs e)
        {
            string name = getNameFromSender(sender);
            byte value = 0;
            // Bit-Wert hat sich geändert
            if (name.Contains("numNum1Bit"))
            {
                string bitValue = numNum1Bit3.Value.ToString() + numNum1Bit2.Value.ToString() + numNum1Bit1.Value.ToString() + numNum1Bit0.Value.ToString();
                value = Convert.ToByte(bitValue, 2);
            }
            // Dezimal-Eingabe wurde betätigt
            else if (name == numNum1Dec.Name)
            {
                value = (byte)numNum1Dec.Value;
            }
            // Hex-Eingabe wurde betätigt
            else if (name == cmbNum1Hex.Name)
            {
                value = Convert.ToByte(cmbNum1Hex.SelectedItem.ToString(), 16);
            }
            updateValues(group: "num1", value: value);
        }

        private void num2_ValueChanged(object sender, EventArgs e)
        {
            string name = getNameFromSender(sender);
            byte value = 0;
            // Bit-Wert hat sich geändert
            if (name.Contains("numNum2Bit"))
            {
                string bitValue = numNum2Bit3.Value.ToString() + numNum2Bit2.Value.ToString() + numNum2Bit1.Value.ToString() + numNum2Bit0.Value.ToString();
                value = Convert.ToByte(bitValue, 2);
            }
            // Dezimal-Eingabe wurde betätigt
            else if (name == numNum2Dec.Name)
            {
                value = (byte)numNum2Dec.Value;
            }
            // Hex-Eingabe wurde betätigt
            else if (name == cmbNum2Hex.Name)
            {
                value = Convert.ToByte(cmbNum2Hex.SelectedItem.ToString(), 16);
            }
            updateValues(group: "num2", value: value);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (this.num1 + this.num2 > 15)
            {
                lblMessage.Text = "Zu hoch";
            } else
            {
                lblMessage.Text = "OK";
            }
        }
    }
}

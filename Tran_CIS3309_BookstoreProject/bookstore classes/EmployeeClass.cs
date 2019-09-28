//     Nicholas Tran
//     CIS 3309 Bookstore Lab 2 Project
//     tug26951@temple.edu
//     February 13, 2018 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tran_CIS3309_BookstoreProject
{   //Employee class to create employee objects for login/verification
    class EmployeeClass
    {   //Attributes of the employee class
        private int hiddenAccessID = 0;
        private string hiddenName = "";
        private int hiddenPin = 0;
        private decimal hiddenAnnualPay = 0.0m;
        private DateTime hiddenLastDateOfAccess = default(DateTime);
        private const int validAccessIDLength = 5;
        private const int validPinLength = 4;

        //Default constructor
        public EmployeeClass()
        {
        }//End default constructor

        //Compares the AccessID passed to the attribute accessid value of the employee object
        public bool checkEmployeeID(int inputID)
        {
            if (this.hiddenAccessID != inputID)
            {
                return false;
            }
            else return true;
        }//End check employee method

        //this creates an employee object, splits the employeestring and stores the substrings
        public Boolean createEmployeeObject(string s)  // IN: string from the Employee Text File
        {

            EmployeeClass thisEmployee = this;
            string[] employeeString = s.Split('*');
            int i;
            for (i = 0; i < employeeString.Length - 1; i++)
            {
                string newString = employeeString[i].Trim();
                employeeString[i] = newString;
            }//End for loop

            int employeeStringSize = employeeString.GetLength(0);

            // Convert AccessID to an integer of required length
            if (employeeString[0].Length != validAccessIDLength)
            {
                MessageBox.Show(employeeString[0]
                    + "_: AccessID string is not exactly 5 characters. Employee File Corrupt. Execution Terminated.",
                      "AccessID in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }//End if

            try
            {
                hiddenAccessID = Convert.ToInt32(employeeString[0]);
            }
            catch
            {
                MessageBox.Show(employeeString[0]
                    + " AccessID string is not a valid integer. Employee File Corrupt. Execution Terminated.",
                      "AccessID in Employee File Invalid",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }//End try

            // Name string to string (no conversion)
            hiddenName = employeeString[1];
            if (hiddenName == " " || hiddenName == "")
            {
                MessageBox.Show(hiddenName
                    + ": Name string is empty or Blank. Employee File Corrupt. Execution Terminated.",
                      "Name in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }//End if

            // Convert Pin to an integer of required length
            if (employeeString[2].Length != validPinLength)
            {
                MessageBox.Show(employeeString[2]
                    + ": Pin string is not exactly 4 characters. Employee File Corrupt. Execution Terminated.",
                      "Pin in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }//End if

            try
            {
                hiddenPin = Convert.ToInt32(employeeString[2]);
            }
            catch
            {
                MessageBox.Show(employeeString[2]
                    + ": Pin string is empty or Blank. Employee File Corrupt.  Execution Terminated.",
                      "Pin in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }//End try

            // Convert annualPay to a positive decimal
            try
            {
                hiddenAnnualPay = Convert.ToDecimal(employeeString[3].Replace(",",
                    "").Replace("$", ""));
            }
            catch
            {
                MessageBox.Show(employeeString[3]
                    + ": Annual Pay string is not a valid decimal. Employee File Corrupt. Execution Terminated.",
                      "Annual pay in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }//End try

            // Convert last Date of Access to a date
            try
            {
                hiddenLastDateOfAccess = DateTime.Parse(employeeString[4]);
            }
            catch
            {
                MessageBox.Show(employeeString[4]
                    + ": Date of Last Access string is not a valid date. Employee File Corrupt.  Execution Terminated.",
                      "Date of last access in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }//End try

            // All data valid
            return (true);
        }  // end createEmployeeObject

        //Generates a string with all attribute values of an employee object
        public string createStringToDisplay()
        {
            string message = "Access ID: " + this.hiddenAccessID + "\n"
                + "Name: " + this.hiddenName + "\n"
                + "Pin: " + this.hiddenPin + "\n"
                + "Annual Pay: " + this.hiddenAnnualPay + "\n"
                + "Last Inventory Access: " + this.hiddenLastDateOfAccess;
            return message;
        }//End create string to display method

        //Changes the date of the transaction for the employee object
        public void updateEmployeeTransactionDate()
        {
            this.hiddenLastDateOfAccess = DateTime.Now;
        }//End update employee transaction date method

        //Compares the pin passed to the attribute pin value of an employee object
        public bool verifyPin(int pin)
        {
            if (this.hiddenPin != pin)
            {
                return false;
            }
            else return true;
        }//End verify pin method
        
        //Creates a string to write employee attrbutes to a file
        public string createWriteString()
        {
            string writeString = this.hiddenAccessID + " * "
                + this.hiddenName + " * "
                + this.hiddenPin + " * "
                + this.hiddenAnnualPay + " * "
                + this.hiddenLastDateOfAccess + " * ";
            return writeString;
        }//End create write string method
    }//End employee class 
}//End namespace

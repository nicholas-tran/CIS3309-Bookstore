using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tran_CIS3309_BookstoreProject
{   //Book class for the sole purpose of creating book objects from a read string and written out to a write file
    class BookClass
    {   //Attributes of the book class
        private string hiddenISBN = "XXX-XXX";
        private string hiddenTitle = "";
        private string hiddenAuthor = "";
        private decimal hiddenPrice = 0.0m;
        private int hiddenNumberOnHand = 0;
        private DateTime hiddenLastDateOfTransaction = default(DateTime);
        private string[] hiddenBookAttributes = new string[6];

        //Default constructor
        public BookClass()
        {
        }//End default constructor

        //Parameterized constructor
        public BookClass(string isbn, string title, string author, decimal price, int numberOnHand, DateTime lastTransactionDate)
        {
            this.hiddenISBN = isbn;
            this.hiddenTitle = title;
            this.hiddenAuthor = author;
            this.hiddenPrice = price;
            this.hiddenNumberOnHand = numberOnHand;
            this.hiddenLastDateOfTransaction = lastTransactionDate;
        }//End default constructor

        //Creates another book object from string and sets attribute values for the book object
        public Boolean createBookObject(string s)  // IN: string from the Employee Text File
        {
            BookClass book = this;
            string[] bookString = s.Split('*');
            int i;
            for (i = 0; i < bookString.Length - 1; i++)
            {
                string newString = bookString[i].Trim();
                bookString[i] = newString;
            }//End for loop

            int employeeStringSize = bookString.GetLength(0);

            // Convert AccessID to an integer of required length
            if (bookString[0].Length != Globals.BookStore.getHiddenISBNTotalLength())
            {
                MessageBox.Show(bookString[0]
                    + ": ISBN string is not exactly 7 characters. Book File Corrupt. Execution Terminated.",
                      "ISBN in Book File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }//End if
            //Convert ISBN to string
            try
            {
                hiddenISBN = Convert.ToString(bookString[0]);
            }
            catch
            {
                MessageBox.Show(bookString[0]
                    + " ISBN string is not a valid ISBN string. Book File Corrupt. Execution Terminated.",
                      "ISBN in Book File Invalid",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }//End try catch

            // Name string to string (no conversion)
            hiddenTitle = bookString[1];
            if (hiddenTitle == " " || hiddenTitle == "")
            {
                MessageBox.Show(hiddenTitle
                    + ": Title string is empty or Blank. Book File Corrupt. Execution Terminated.",
                      "Title in Book File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }//End if
            //Convert author to string
            try
            {
                hiddenAuthor = Convert.ToString(bookString[2]);
            }
            catch
            {
                MessageBox.Show(bookString[2]
                    + ": Author string is empty or Blank. Book File Corrupt.  Execution Terminated.",
                      "Author in Book File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }//End try catch
            //Convert price to decimal 
            try
            {
                hiddenPrice = Convert.ToDecimal(bookString[3].Replace(".",
                    ".").Replace("$", ""));
            }
            catch
            {
                MessageBox.Show(bookString[3]
                    + ": Price string is not a valid decimal. Book File Corrupt. Execution Terminated.",
                      "Price in Book File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }//End try catch
            //Convert number on hand to an int
            try
            {
                hiddenNumberOnHand = Convert.ToInt32(bookString[4]);
            }
            catch
            {
                MessageBox.Show(bookString[4]
                    + ": Number on hand string is not a valid integer. Book File Corrupt. Execution Terminated.",
                      "Number on hand in Book File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }//End try catch
            // Convert last Date of Access to a date
            try
            {
                hiddenLastDateOfTransaction = DateTime.Parse(bookString[5]);
            }
            catch
            {
                MessageBox.Show(bookString[5]
                    + ": Date of Last transaction string is not a valid date. Book File Corrupt.  Execution Terminated.",
                      "Date of last transaction in Book File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }//End try catch

            // All data valid
            return (true);
        }//End create book object method

        //Compares the passed ISBN to the attribute hiddenISBN value of the book object
        public bool bookMatch(string ISBN)
        {
            if (!this.hiddenISBN.Equals(ISBN))
            {
                return false;
            }
            else
                //To do
                return true;
        }//End book match method

        //Returns a string with all values of the attributes of a book object
        public string displayBookRecord()
        {
            string message = "ISBN: " + this.hiddenISBN + "\n"
                  + "Title: " + this.hiddenTitle + "\n"
                  + "Author: " + this.hiddenAuthor + "\n"
                  + "Price: " + hiddenPrice + "\n"
                  + "On Hand: " + hiddenNumberOnHand + "\n"
                  + "Last Inventory Transaction: " + hiddenLastDateOfTransaction;
            return message;
        }//End display book record method

        //creates a string to write to a file
        public string createBookWrite()
        {
            string writeString = this.hiddenISBN + " * " + this.hiddenTitle + " * " + this.hiddenAuthor + " * $" + this.hiddenPrice + " * " + this.hiddenNumberOnHand + " * " + this.hiddenLastDateOfTransaction;
            return writeString;
        }//End create book write method
        
        //Creates a string array from the attributes of the book object
        public void createBookAttributes()
        {
            hiddenBookAttributes[0] = this.hiddenISBN;
            hiddenBookAttributes[1] = this.hiddenTitle;
            hiddenBookAttributes[2] = this.hiddenAuthor;
            hiddenBookAttributes[3] = Convert.ToString(this.hiddenPrice);
            hiddenBookAttributes[4] = Convert.ToString(this.hiddenNumberOnHand);
            hiddenBookAttributes[5] = Convert.ToString(this.hiddenLastDateOfTransaction);
        }//End create book attributes method
        
        //Returns the string array containing book attributes by calling create book attributes method
        public string[] returnBookAttributeArray()
        {
            BookClass book = this;
            book.createBookAttributes();
            return hiddenBookAttributes;
        }//End return book attributes method
    }//End book class 
}//End namespace

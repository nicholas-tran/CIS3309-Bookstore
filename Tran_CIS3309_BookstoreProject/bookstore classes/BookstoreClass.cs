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
{   // Contains constants, properties and other data related to the Bookstore
    class BookStoreClass
    {
        // Books and the EmployeeList and all the text files belong to the Bookstore
        public BookClass Book = new BookClass();
        public EmployeeListClass EmployeeList = new EmployeeListClass();
        bool isEndOfFile = true;

        // The Files the Bookstore Owns
        private static string currentBookFilePath = "currentBookFile.txt";
        private static string updatedBookFilePath = "updatedBookFile.txt";
        private static string currentEmployeeFilePath = "currentEmployeeFile.txt";
        private static string updatedEmployeeFilePath = "updatedEmployeeFile.txt";

        public static currentFileClass currentBookFile = new
            currentFileClass(currentBookFilePath);
        public static updatedFileClass updatedBookFile = new
            updatedFileClass(updatedBookFilePath);
        public static currentFileClass currentEmployeeFile = new
            currentFileClass(currentEmployeeFilePath);
        public static updatedFileClass updatedEmployeeFile = new
            updatedFileClass(updatedEmployeeFilePath);

        // Bookstore parameters (Named constants defined by the Bookstore)
        private const int hiddenAccessIDLength = 5;   // Length of AccessNet ID
        private const int hiddenISBNLeftLength = 3;   // Length of left part of ISBN
        private const int hiddenISBNRightLength = 3;  // Length of right part of ISBN
        private const int hiddenISBNTotalLength = 7;
        // Number of attempts BookStore allows a user before terminating an inventory 
        //    update session
        private const int hiddenTryCountMax = 3;
        //Actual attempts 
        int tryCount = 0;

        //Used to increment tryCount variable
        public void incrementTryCount()
        {
            tryCount++;
        }//End increment try count method

        //Compares tryCount to const maximum try count variable
        public bool checkTryCount()
        {
            if (tryCount != hiddenTryCountMax)
            {
                return true;
            }
            else return false;
        }//End check try count method

        //Returns tryCount 
        public int getTryCount()
        {
            return tryCount;
        }//End getTryCount method

        // Find Employee in Employee List
        // Returns a reference to the employee found and (through an argument) returns
        //     true or false
        public EmployeeClass findEmployee(int ID,              // IN: employee ID to be found   
             out Boolean found)   // OUT: flag indicating if Employee ID found in current
                                  //      Employee object
        {
            EmployeeClass emp;    // reference to current Employee being checked for ID

            if ((emp = EmployeeList.findEmployeeInList(ID)) != null)
            {
                emp.updateEmployeeTransactionDate();
                found = true;
            }
            else
                found = false;
            return emp;
        }  // end findEmployee


        // Displays the list of employees (After they were written to the Employee File)
        public void displayEntireEmployeeList()
        {
            EmployeeList.displayEntireList();
        }   // end writeEntireEmploeeList

        //Compares ISBN input to ISBN from current book file
        public bool verifyISBN(string ISBN)
        {
            isEndOfFile = false;
            currentBookFile.rewindFile();
            while (!isEndOfFile)
            {
                string readString = currentBookFile.getNextRecord(ref isEndOfFile);
                if (readString == null)
                {
                    break;
                }//End if
                /*String[] tempArray = readString.Split('*');
                for (int i = 0; i < tempArray.Length; i++)
                {
                    string newString = tempArray[i].Trim();
                    tempArray[i] = newString;
                }
                */
                Book = new BookClass();
                Book.createBookObject(readString);
                //Book.createBookAttributes();
                string[] tempArray = Book.returnBookAttributeArray();

                if (tempArray[0].Equals(ISBN))
                {
                    return true;
                }//End if
            }//End while
            return false;
        }//End verify ISBN method

        //Reads and writes up to line where ISBN is matched then skips write of that line and continues read and write to updatedBook file
        public void deleteBookFromFile(string ISBN)
        {
            isEndOfFile = false;
            currentBookFile.rewindFile();
            while (!isEndOfFile)
            {
                string readString = currentBookFile.getNextRecord(ref isEndOfFile);
                if (readString == null)
                {
                    break;
                }//End if
                Book = new BookClass();
                Book.createBookObject(readString);
                string[] tempArray = Book.returnBookAttributeArray();
                if (!Book.bookMatch(ISBN))
                {
                    updatedBookFile.writeNextRecord(readString);
                }//End if
                else
                {
                    readString = currentBookFile.getNextRecord(ref isEndOfFile);
                    updatedBookFile.writeNextRecord(readString);
                }//End else
            }//End while
            updatedBookFile.closeFile();
        }//End delete from book file method

        //Reads and writes books to updatedBook File and creates a book class with the attribute changes then writes out that obj and the rest of the currentBook file
        public void modifyBookFromFile(string ISBN, string author, string title, decimal price, int onHand, DateTime date)
        {
            isEndOfFile = false;
            currentBookFile.rewindFile();
            while (!isEndOfFile)
            {
                string readString = currentBookFile.getNextRecord(ref isEndOfFile);
                if (readString == null)
                {
                    break;
                }//End if
                Book = new BookClass();
                Book.createBookObject(readString);
                string[] tempArray = Book.returnBookAttributeArray();
                if (!Book.bookMatch(ISBN))
                {
                    updatedBookFile.writeNextRecord(readString);
                }//End if
                else
                {
                    this.Book = new BookClass(ISBN, title, author, price, onHand, date);
                    updatedBookFile.writeNextRecord(this.Book.createBookWrite());
                    MessageBox.Show(this.Book.displayBookRecord(), "Updated Book Record");
                }//End else
            }//End while
            updatedBookFile.closeFile();
        }//End modify book from file method

        //Reads and writes all books to updatedBook file and then adds a new book
        public void addNewBook(string ISBN, string title, string author, decimal price, int onHand, DateTime date)
        {
            isEndOfFile = false;
            currentBookFile.rewindFile();
            while (!isEndOfFile)
            {
                string readString = currentBookFile.getNextRecord(ref isEndOfFile);
                if (readString == null)
                {
                    break;
                }//End if
                updatedBookFile.writeNextRecord(readString);
            }//End while
            Book = new BookClass(ISBN, title, author, price, onHand, date);
            updatedBookFile.writeNextRecord(Book.createBookWrite());
            MessageBox.Show(Book.displayBookRecord(), "New Book Record");
            updatedBookFile.closeFile();
        }//End addNewBook method

        //Returns the isbn total length
        public int getHiddenISBNTotalLength()
        {
            return hiddenISBNTotalLength;
        }//End hidden ISBN total length method

        //Writes all employee objects in employee list object to updatedFile
        public void writeEmployeeToFile()
        {
            List<string> writeEmployee = Globals.BookStore.EmployeeList.prepareWriteList();
            foreach (string employee in writeEmployee)
            {
                updatedEmployeeFile.writeNextRecord(employee);
            }//End for each
            updatedEmployeeFile.closeFile();
            Globals.BookStore.displayEntireEmployeeList();
        }//End write employee to file method

        //Closes all files
        public void closeAllFiles()
        {
            currentBookFile.closeFile();
            currentEmployeeFile.closeFile();
            updatedBookFile.closeFile();
            updatedEmployeeFile.closeFile();
        }//End close all file method
    }//End Bookstore class
}//End namespace
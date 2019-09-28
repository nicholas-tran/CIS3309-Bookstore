//     Nicholas Tran
//     CIS 3309 Bookstore Lab 2 Project
//     tug26951@temple.edu
//     February 13, 2018 
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tran_CIS3309_BookstoreProject
{   //Stores employee objects to be used as login/verification
    class EmployeeListClass
    {   //Attributes of the employeeList class
        List<EmployeeClass> internalList = new List<EmployeeClass>();
        private int indexCurrentEmployee = 0;

        //Constructor that creates a new list object and sets the attribute list to reference the new list
        public EmployeeListClass()
        {
            List<EmployeeClass> internalList = new List<EmployeeClass>();
        }//End constructor

        //Finds an employee object with matching accessID from list
        public EmployeeClass findEmployeeInList(int accessID)
        {
            foreach (EmployeeClass obj in internalList)
            {
                if (obj.checkEmployeeID(accessID) == true)
                {
                    return internalList.ElementAt(indexCurrentEmployee);
                }//end if
                else
                    indexCurrentEmployee++;
            }//end foreach
            indexCurrentEmployee = 0;
            return null;
        }//End find employee in list method

        //Reads from currentEmployee file and creates employee objects to store in list
        public Boolean initializeEntireList()
        {
            string nextRecord;
            Boolean isEndOfFile = true;
            Boolean success;
            int countProcessedRecords = 0;

            nextRecord = BookStoreClass.currentEmployeeFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                countProcessedRecords++;
                EmployeeClass emp = new EmployeeClass();
                success = emp.createEmployeeObject(nextRecord);
                if (success != true)
                {
                    MessageBox.Show
                       ("Unable to create an Employee Object.  Employee list not created.",
                        "Employee List Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }//End if
                internalList.Add(emp);
                nextRecord = BookStoreClass.currentEmployeeFile.getNextRecord(ref isEndOfFile);
            } //end While

            if (countProcessedRecords > 0)
                return true;
            else
                return false;
        }  // end initializeEntireList

        //Verify input pin to pin of current employee object found with matched accessID
        public bool verifyPin(int PIN)
        {
            if (internalList[indexCurrentEmployee].verifyPin(PIN))
            {
                return true;
            }//end if
            else return false;
        }//End verify pin method

        //Displays entire list as seperate messageboxes
        public void displayEntireList()
        {
            foreach (EmployeeClass obj in internalList)
            {
                MessageBox.Show(obj.createStringToDisplay(), "Employees on File.");
            }//End foreach
        }//End display entire list method

        //Prepares strings created from the employee objects in the list to write into updatedEmployee file
        public List<string> prepareWriteList()
        {
            List<string> employeeWrite = new List<string>();
            foreach (EmployeeClass obj in internalList)
            {
                employeeWrite.Add(obj.createWriteString());
            }
            return employeeWrite;
        }//End prepare write list method
    }//End employeeList class
}//End namespace

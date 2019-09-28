//     Nicholas Tran
//     CIS 3309 Bookstore Lab 2 Project
//     tug26951@temple.edu
//     February 13, 2018 

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tran_CIS3309_BookstoreProject
{   //Specify file path to write strings using streamwriter
    class updatedFileClass
    {  
        private string updatedFilePath;
        private System.IO.StreamWriter updatedFileSW;   // Reference variable of type SW
        private int recordWriteCount;

        // Constructor with file path input
        // Create instance of StreamWriter class (type) and store reference
        public updatedFileClass(string filePath)
        {
            recordWriteCount = 0;
            updatedFilePath = filePath;
            try
            {
                updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file " + updatedFilePath + " Terminate Program.",
                                "Output File Connection Error.",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end Try
        } // end updatedFileClass Constructor 



        // Write a record from the current file
        public void writeNextRecord(string record)
        {
            try
            {
                updatedFileSW.WriteLine(record);
            }
            catch (Exception ex)
            {
                MessageBox.Show("IO error in file write. Terminate program.",
                                "File Write Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            } // end try and catch

            recordWriteCount++; // increment the record written count
        } // end writeNextRecord()


        // Get value of number of records written
        public int getRecordsWrittenCount()
        {
            return recordWriteCount;
        } // end getRecordsWrittenCount



        // Close the output file
        public void closeFile()
        {
            updatedFileSW.Close();
        }  // end closeFile


        // Rewind the output file
        public void rewindFile()
        {
            recordWriteCount = 0;
            updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            updatedFileSW.Flush();
            updatedFileSW.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        }  // end rewindFile

    } // end updatedFileClass
} // end namespace

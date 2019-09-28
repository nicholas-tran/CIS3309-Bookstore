//     Nicholas Tran
//     CIS 3309 Bookstore Lab 2 Project
//     tug26951@temple.edu
//     February 13, 2018 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tran_CIS3309_BookstoreProject
{
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
        }

        private void btnOKIsbn_Click(object sender, EventArgs e)
        {
            try
            {
                int firstISBN;
                int secondISBN;
                firstISBN = Convert.ToInt32(txtFirstISBN.Text);
                secondISBN = Convert.ToInt32(txtSecondISBN.Text);
                if (txtFirstISBN.Text.Length != 3 || txtSecondISBN.Text.Length != 3)
                {
                    MessageBox.Show("Invalid Size ISBN.");
                    return;
                }
                if(firstISBN < 0 || secondISBN < 0)
                {
                    MessageBox.Show("Cannot be negative.");
                    return;  
                }
                string combinedISBN = txtFirstISBN.Text + "-" + txtSecondISBN.Text;
                if (!Globals.BookStore.verifyISBN(combinedISBN))
                {
                    MessageBox.Show("Book Not Found!\nTime To Add A New Book.", "Failed Match.");
                    txtAddISBN.Text = combinedISBN;
                    txtAddISBN.Enabled = false;
                    lblSelectTransaction.Visible = true;
                    lblSelectTransaction.Enabled = true;
                    btnAddNewBook.Visible = true;
                    btnAddNewBook.Enabled = true;
                    txtFirstISBN.Enabled = false;
                    txtSecondISBN.Enabled = false;
                    btnOKIsbn.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Book Found.\nModify or Delete Time.", "Successful Match.");
                    lblSelectTransaction.Visible = true;
                    lblSelectTransaction.Enabled = true;
                    btnUpdateBook.Visible = true;
                    btnUpdateBook.Enabled = true;
                    btnDeleteBook.Visible = true;
                    btnDeleteBook.Enabled = true;
                    txtFirstISBN.Enabled = false;
                    txtSecondISBN.Enabled = false;
                    btnOKIsbn.Enabled = false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Format.");
            }
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
            pnlAdd.Enabled = true;
            lblAddBook.BringToFront();
            lblAddBook.Visible = true;
            lblAddBook.Enabled = true;
            btnAddNewBook.Enabled = false;
            txtAddISBN.Text = txtFirstISBN.Text + "-" + txtSecondISBN.Text;
            txtAddDate.Text = Convert.ToString(DateTime.Now);
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            pnlModify.Visible = true;
            pnlModify.Enabled = true;
            lblModifyBook.BringToFront();
            lblModifyBook.Visible = true;
            lblModifyBook.Enabled = true;
            btnDeleteBook.Enabled = false;
            btnUpdateBook.Enabled = false;
            string[] tempArray = Globals.BookStore.Book.returnBookAttributeArray();
            txtModifyISBN.Text = tempArray[0];
            txtModifyTitle.Text = tempArray[1];
            txtModifyAuthor.Text = tempArray[2];
            txtModifyPrice.Text = tempArray[3];
            txtModifyOnHand.Text = tempArray[4];
            txtModifyDate.Text = tempArray[5];
            txtModifyDate.Enabled = false;

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            txtDeleteISBN.Text = txtFirstISBN.Text + "-" + txtSecondISBN.Text;
            txtDeleteISBN.Enabled = false;
            pnlDelete.Visible = true;
            pnlDelete.Enabled = true;
            lblDeleteBook.BringToFront();
            lblDeleteBook.Visible = false;
            lblDeleteBook.Enabled = false;
            btnUpdateBook.Enabled = false;
            btnDeleteBook.Enabled = false;
            string[] tempArray = Globals.BookStore.Book.returnBookAttributeArray();
            txtDeleteISBN.Text = tempArray[0];
            txtDeleteTitle.Text = tempArray[1];
            txtDeleteAuthor.Text = tempArray[2];
            txtDeletePrice.Text = tempArray[3];
            txtDeleteOnHand.Text = tempArray[4];
            txtDeleteTransactionDate.Text = tempArray[5];
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Globals.BookStore.writeEmployeeToFile();
            Globals.BookStore.closeAllFiles();
            System.Windows.Forms.Application.Exit();
        }

        private void btnAddYes_Click(object sender, EventArgs e)
        {
            try
            {
                string[] newISBN = Convert.ToString(txtAddISBN.Text).Split('-');
                for (int i = 0; i < newISBN.Length; i++)
                {
                    int check;
                    Int32.TryParse(newISBN[i], out check);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ISBN Invalid Format.");
            }
            try
            {
                decimal newPrice;
                if (!Decimal.TryParse(txtAddPrice.Text, out newPrice))
                {
                    MessageBox.Show("Price Invalid Format.");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Price Invalid Format.");
            }
            try
            {
                int newOnHand;
                if (!Int32.TryParse(txtAddOnHand.Text, out newOnHand))
                {
                    MessageBox.Show("On Hand Invalid Format.");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("On Hand Invalid Format.");
            }
            try
            {
                DateTime newDate;
                if (!DateTime.TryParse(txtAddDate.Text, out newDate))
                {
                    MessageBox.Show("Date Invalid Format");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Date Invalid Format.");
            }
            if(Convert.ToDecimal(txtAddPrice.Text) < 0)
            {
                MessageBox.Show("Price cannot be negative!");
                txtAddPrice.Focus();
                txtAddPrice.Clear();
                return;
            }
            if (Convert.ToInt32(txtAddOnHand.Text) < 0)
            {
                MessageBox.Show("On hand cannot be negative!");
                txtAddOnHand.Focus();
                txtAddOnHand.Clear();
                return;
            }
            Globals.BookStore.addNewBook(txtAddISBN.Text, txtAddTitle.Text, txtAddAuthor.Text, Decimal.Round(Convert.ToDecimal(txtAddPrice.Text),2), Convert.ToInt32(txtAddOnHand.Text), Convert.ToDateTime(txtAddDate.Text));
            lblAddBook.Enabled = false;
            lblAddBook.Visible = false;
            pnlAdd.Enabled = false;
            pnlAdd.Visible = false;
            btnAddNewBook.Enabled = false;
            btnAddNewBook.Visible = false;
            lblSelectTransaction.Enabled = false;
            lblSelectTransaction.Visible = false;
            MessageBox.Show("Added a new book. Hit done to exit.", "Success.");
        }

        private void btnAddNo_Click(object sender, EventArgs e)
        {
            txtAddISBN.Clear();
            txtAddTitle.Clear();
            txtAddAuthor.Clear();
            txtAddPrice.Clear();
            txtAddOnHand.Clear();
            txtAddDate.Clear();
            pnlAdd.Visible = false;
            pnlAdd.Enabled = false;
            lblAddBook.Visible = false;
            lblAddBook.Enabled = false;
            btnAddNewBook.Visible = false;
            btnAddNewBook.Enabled = false;
            lblAddBook.Visible = false;
            lblAddBook.Enabled = false;
            lblSelectTransaction.Visible = false;
            txtFirstISBN.Clear();
            txtFirstISBN.Enabled = true;
            txtSecondISBN.Clear();
            txtSecondISBN.Enabled = true;
            txtFirstISBN.Focus();
            btnOKIsbn.Enabled = true;
        }

        private void btnDeleteYes_Click(object sender, EventArgs e)
        {
            Globals.BookStore.deleteBookFromFile(txtDeleteISBN.Text);
            MessageBox.Show("ISBN: " + txtDeleteISBN.Text
                + "\nTitle: " + txtDeleteTitle.Text
                + "\nAuthor: " + txtDeleteAuthor.Text
                + "\nPrice: " + txtDeletePrice.Text
                + "\nOn Hand: " + txtDeleteOnHand.Text
                + "Transaction Date: " + txtDeleteTransactionDate.Text, "Book Deleted");
            lblDeleteBook.Enabled = false;
            lblDeleteBook.Visible = false;
            pnlDelete.Enabled = false;
            pnlDelete.Visible = false;
            btnDeleteBook.Enabled = false;
            btnDeleteBook.Visible = false;
            lblSelectTransaction.Enabled = false;
            lblSelectTransaction.Visible = false;
            MessageBox.Show("Deleted a book. Hit done to exit.", "Success.");
        }

        private void btnModifyYes_Click(object sender, EventArgs e)
        {
            try
            {
                string[] newISBN = Convert.ToString(txtModifyISBN.Text).Split('-');
                for (int i = 0; i < newISBN.Length; i++)
                {
                    int check;
                    Int32.TryParse(newISBN[i], out check);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ISBN Invalid Format.");
            }
            try
            {
                decimal newPrice;
                if (!Decimal.TryParse(txtModifyPrice.Text, out newPrice))
                {
                    MessageBox.Show("Price Invalid Format.");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Price Invalid Format.");
            }
            try
            {
                int newOnHand;
                if (!Int32.TryParse(txtModifyOnHand.Text, out newOnHand))
                {
                    MessageBox.Show("On Hand Invalid Format.");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("On Hand Invalid Format.");
            }
            try
            {
                DateTime newDate;
                if (!DateTime.TryParse(txtModifyDate.Text, out newDate))
                {
                    MessageBox.Show("Date Invalid Format");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Date Invalid Format.");
            }
            if (Convert.ToDecimal(txtModifyPrice.Text) < 0)
            {
                MessageBox.Show("Price cannot be negative!");
                txtModifyPrice.Focus();
                txtModifyPrice.Clear();
                return;
            }
            if (Convert.ToInt32(txtModifyOnHand.Text) < 0)
            {
                MessageBox.Show("On hand cannot be negative!");
                txtModifyOnHand.Focus();
                txtModifyOnHand.Clear();
                return;
            }
            Globals.BookStore.modifyBookFromFile(txtModifyISBN.Text, txtModifyAuthor.Text, txtModifyTitle.Text, Decimal.Round(Convert.ToDecimal(txtModifyPrice.Text),2), Convert.ToInt32(txtModifyOnHand.Text), Convert.ToDateTime(DateTime.Now));
            lblModifyBook.Enabled = false;
            lblModifyBook.Visible = false;
            pnlModify.Enabled = false;
            pnlModify.Visible = false;
            btnUpdateBook.Enabled = false;
            btnUpdateBook.Visible = false;
            btnDeleteBook.Enabled = false;
            btnDeleteBook.Visible = false;
            lblSelectTransaction.Enabled = false;
            lblSelectTransaction.Visible = false;
            MessageBox.Show("Updated a book. Hit done to exit.", "Success.");

        }

        private void txtFirstISBN_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstISBN.Text.Length == 3)
            {
                txtSecondISBN.Focus();
            }
        }

        private void txtSecondISBN_TextChanged(object sender, EventArgs e)
        {
            if (txtSecondISBN.Text.Length == 3)
            {
                btnOKIsbn.Focus();
            }
        }

        private void btnDeleteNo_Click(object sender, EventArgs e)
        {
            pnlDelete.Visible = false;
            pnlDelete.Enabled = false;
            lblDeleteBook.Visible = false;
            lblDeleteBook.Enabled = false;
            btnUpdateBook.Enabled = true;
            btnDeleteBook.Enabled = true;
            btnUpdateBook.Visible = false;
            btnUpdateBook.Enabled = false;
            btnDeleteBook.Visible = false;
            btnDeleteBook.Enabled = false;
            lblSelectTransaction.Visible = false;
            lblSelectTransaction.Enabled = false;
            txtFirstISBN.Clear();
            txtFirstISBN.Enabled = true;
            txtSecondISBN.Clear();
            txtSecondISBN.Enabled = true;
            txtFirstISBN.Focus();
            btnOKIsbn.Enabled = true;
        }

        private void btnModifyNo_Click(object sender, EventArgs e)
        {
            pnlModify.Visible = false;
            pnlModify.Enabled = false;
            lblModifyBook.Visible = false;
            lblModifyBook.Enabled = false;
            btnUpdateBook.Enabled = false;
            btnDeleteBook.Enabled = false;
            lblSelectTransaction.Visible = false;
            btnUpdateBook.Visible = false;
            btnUpdateBook.Enabled = false;
            btnDeleteBook.Visible = false;
            btnDeleteBook.Enabled = false;
            txtFirstISBN.Clear();
            txtFirstISBN.Enabled = true;
            txtSecondISBN.Clear();
            txtSecondISBN.Enabled = true;
            txtFirstISBN.Focus();
            btnOKIsbn.Enabled = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;
            Application.Exit();
        }
    }

}

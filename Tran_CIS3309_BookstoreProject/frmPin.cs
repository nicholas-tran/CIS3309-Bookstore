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
    public partial class frmPin : Form
    {
        public frmPin()
        {
            InitializeComponent();
        }

        private void btnOKPin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToString(txtPin.Text).Length != 4)
                {
                    MessageBox.Show("Input does not meet requirements.");
                    MessageBox.Show("Attempts Left: " + (2 - Globals.BookStore.getTryCount()), "Pin does not match AccessID.");
                    Globals.BookStore.incrementTryCount();
                    txtPin.Focus();
                    txtPin.Clear();
                    return;
                }
                if (!Globals.BookStore.EmployeeList.verifyPin(Convert.ToInt32(txtPin.Text)))
                {
                    MessageBox.Show("Attempts Left: " + (2 - Globals.BookStore.getTryCount()), "Pin does not match AccessID.");
                    Globals.BookStore.incrementTryCount();
                    txtPin.Focus();
                    txtPin.Clear();
                    if (!Globals.BookStore.checkTryCount())
                    {
                        MessageBox.Show("Max tries.");
                        System.Windows.Forms.Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Pin match.");
                    this.Visible = false;
                    frmTransaction newForm = new frmTransaction();
                    newForm.Show();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Input does not meet requirements.");
                txtPin.Focus();
                txtPin.Clear();
                MessageBox.Show("Attempts Left: " + (2 - Globals.BookStore.getTryCount()), "Pin does not match AccessID.");
                Globals.BookStore.incrementTryCount();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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

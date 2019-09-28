namespace Tran_CIS3309_BookstoreProject
{
    partial class frmTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStore = new System.Windows.Forms.Label();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.lblEnterISBN = new System.Windows.Forms.Label();
            this.txtFirstISBN = new System.Windows.Forms.TextBox();
            this.lblDash = new System.Windows.Forms.Label();
            this.txtSecondISBN = new System.Windows.Forms.TextBox();
            this.btnOKIsbn = new System.Windows.Forms.Button();
            this.lblSelectTransaction = new System.Windows.Forms.Label();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.btnAddNo = new System.Windows.Forms.Button();
            this.btnAddYes = new System.Windows.Forms.Button();
            this.txtAddDate = new System.Windows.Forms.TextBox();
            this.txtAddOnHand = new System.Windows.Forms.TextBox();
            this.txtAddPrice = new System.Windows.Forms.TextBox();
            this.lblAddDate = new System.Windows.Forms.Label();
            this.txtAddAuthor = new System.Windows.Forms.TextBox();
            this.lblAddAuthor = new System.Windows.Forms.Label();
            this.lblAddOnHand = new System.Windows.Forms.Label();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.lblAddPrice = new System.Windows.Forms.Label();
            this.txtAddISBN = new System.Windows.Forms.TextBox();
            this.lblAddISBN = new System.Windows.Forms.Label();
            this.lblAddBook = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblModifyBook = new System.Windows.Forms.Label();
            this.pnlModify = new System.Windows.Forms.Panel();
            this.btnModifyNo = new System.Windows.Forms.Button();
            this.btnModifyYes = new System.Windows.Forms.Button();
            this.txtModifyDate = new System.Windows.Forms.TextBox();
            this.txtModifyOnHand = new System.Windows.Forms.TextBox();
            this.txtModifyPrice = new System.Windows.Forms.TextBox();
            this.lblModifyDate = new System.Windows.Forms.Label();
            this.txtModifyAuthor = new System.Windows.Forms.TextBox();
            this.lblModifyAuthor = new System.Windows.Forms.Label();
            this.lblModifyOnHand = new System.Windows.Forms.Label();
            this.txtModifyTitle = new System.Windows.Forms.TextBox();
            this.lblModifyTitle = new System.Windows.Forms.Label();
            this.lblModifyPrice = new System.Windows.Forms.Label();
            this.txtModifyISBN = new System.Windows.Forms.TextBox();
            this.lblModifyISBN = new System.Windows.Forms.Label();
            this.lblDeleteBook = new System.Windows.Forms.Label();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.txtDeletePrice = new System.Windows.Forms.TextBox();
            this.lblDeletePrice = new System.Windows.Forms.Label();
            this.txtDeleteTransactionDate = new System.Windows.Forms.TextBox();
            this.txtDeleteOnHand = new System.Windows.Forms.TextBox();
            this.lblDeleteTransactionDate = new System.Windows.Forms.Label();
            this.txtDeleteAuthor = new System.Windows.Forms.TextBox();
            this.lblDeleteAuthor = new System.Windows.Forms.Label();
            this.lblDeleteOnHand = new System.Windows.Forms.Label();
            this.txtDeleteTitle = new System.Windows.Forms.TextBox();
            this.lblDeleteTitle = new System.Windows.Forms.Label();
            this.btnDeleteNo = new System.Windows.Forms.Button();
            this.btnDeleteYes = new System.Windows.Forms.Button();
            this.txtDeleteISBN = new System.Windows.Forms.TextBox();
            this.lblDeleteISBN = new System.Windows.Forms.Label();
            this.pnlAdd.SuspendLayout();
            this.pnlModify.SuspendLayout();
            this.pnlDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(167, 8);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(114, 13);
            this.lblStore.TabIndex = 0;
            this.lblStore.Text = "Book Worm Bookstore";
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Location = new System.Drawing.Point(181, 34);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(91, 13);
            this.lblTransaction.TabIndex = 1;
            this.lblTransaction.Text = "Transaction Page";
            // 
            // lblEnterISBN
            // 
            this.lblEnterISBN.AutoSize = true;
            this.lblEnterISBN.Location = new System.Drawing.Point(12, 69);
            this.lblEnterISBN.Name = "lblEnterISBN";
            this.lblEnterISBN.Size = new System.Drawing.Size(203, 13);
            this.lblEnterISBN.TabIndex = 2;
            this.lblEnterISBN.Text = "Enter the ISBN for Book (in form nnn-nnn)";
            // 
            // txtFirstISBN
            // 
            this.txtFirstISBN.Location = new System.Drawing.Point(220, 66);
            this.txtFirstISBN.MaxLength = 3;
            this.txtFirstISBN.Name = "txtFirstISBN";
            this.txtFirstISBN.Size = new System.Drawing.Size(52, 20);
            this.txtFirstISBN.TabIndex = 3;
            this.txtFirstISBN.TextChanged += new System.EventHandler(this.txtFirstISBN_TextChanged);
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Location = new System.Drawing.Point(278, 69);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(10, 13);
            this.lblDash.TabIndex = 4;
            this.lblDash.Text = "-";
            // 
            // txtSecondISBN
            // 
            this.txtSecondISBN.Location = new System.Drawing.Point(294, 66);
            this.txtSecondISBN.MaxLength = 3;
            this.txtSecondISBN.Name = "txtSecondISBN";
            this.txtSecondISBN.Size = new System.Drawing.Size(52, 20);
            this.txtSecondISBN.TabIndex = 5;
            this.txtSecondISBN.TextChanged += new System.EventHandler(this.txtSecondISBN_TextChanged);
            // 
            // btnOKIsbn
            // 
            this.btnOKIsbn.Location = new System.Drawing.Point(352, 63);
            this.btnOKIsbn.Name = "btnOKIsbn";
            this.btnOKIsbn.Size = new System.Drawing.Size(75, 23);
            this.btnOKIsbn.TabIndex = 6;
            this.btnOKIsbn.Text = "OK";
            this.btnOKIsbn.UseVisualStyleBackColor = true;
            this.btnOKIsbn.Click += new System.EventHandler(this.btnOKIsbn_Click);
            // 
            // lblSelectTransaction
            // 
            this.lblSelectTransaction.AutoSize = true;
            this.lblSelectTransaction.Enabled = false;
            this.lblSelectTransaction.Location = new System.Drawing.Point(12, 112);
            this.lblSelectTransaction.Name = "lblSelectTransaction";
            this.lblSelectTransaction.Size = new System.Drawing.Size(105, 13);
            this.lblSelectTransaction.TabIndex = 7;
            this.lblSelectTransaction.Text = "Select a Transaction";
            this.lblSelectTransaction.Visible = false;
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Enabled = false;
            this.btnAddNewBook.Location = new System.Drawing.Point(140, 107);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(159, 23);
            this.btnAddNewBook.TabIndex = 8;
            this.btnAddNewBook.Text = "Add New Book To Inventory";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Visible = false;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Enabled = false;
            this.btnUpdateBook.Location = new System.Drawing.Point(140, 136);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(159, 23);
            this.btnUpdateBook.TabIndex = 9;
            this.btnUpdateBook.Text = "Update A Book In Inventory";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Visible = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Enabled = false;
            this.btnDeleteBook.Location = new System.Drawing.Point(140, 166);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(159, 23);
            this.btnDeleteBook.TabIndex = 10;
            this.btnDeleteBook.Text = "Delete A Book From Inventory";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Visible = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdd.Controls.Add(this.btnAddNo);
            this.pnlAdd.Controls.Add(this.btnAddYes);
            this.pnlAdd.Controls.Add(this.txtAddDate);
            this.pnlAdd.Controls.Add(this.txtAddOnHand);
            this.pnlAdd.Controls.Add(this.txtAddPrice);
            this.pnlAdd.Controls.Add(this.lblAddDate);
            this.pnlAdd.Controls.Add(this.txtAddAuthor);
            this.pnlAdd.Controls.Add(this.lblAddAuthor);
            this.pnlAdd.Controls.Add(this.lblAddOnHand);
            this.pnlAdd.Controls.Add(this.txtAddTitle);
            this.pnlAdd.Controls.Add(this.lblAddTitle);
            this.pnlAdd.Controls.Add(this.lblAddPrice);
            this.pnlAdd.Controls.Add(this.txtAddISBN);
            this.pnlAdd.Controls.Add(this.lblAddISBN);
            this.pnlAdd.Enabled = false;
            this.pnlAdd.Location = new System.Drawing.Point(15, 209);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(425, 120);
            this.pnlAdd.TabIndex = 11;
            this.pnlAdd.Visible = false;
            // 
            // btnAddNo
            // 
            this.btnAddNo.Location = new System.Drawing.Point(208, 92);
            this.btnAddNo.Name = "btnAddNo";
            this.btnAddNo.Size = new System.Drawing.Size(75, 23);
            this.btnAddNo.TabIndex = 13;
            this.btnAddNo.Text = "NO";
            this.btnAddNo.UseVisualStyleBackColor = true;
            this.btnAddNo.Click += new System.EventHandler(this.btnAddNo_Click);
            // 
            // btnAddYes
            // 
            this.btnAddYes.Location = new System.Drawing.Point(124, 92);
            this.btnAddYes.Name = "btnAddYes";
            this.btnAddYes.Size = new System.Drawing.Size(75, 23);
            this.btnAddYes.TabIndex = 12;
            this.btnAddYes.Text = "YES";
            this.btnAddYes.UseVisualStyleBackColor = true;
            this.btnAddYes.Click += new System.EventHandler(this.btnAddYes_Click);
            // 
            // txtAddDate
            // 
            this.txtAddDate.Enabled = false;
            this.txtAddDate.Location = new System.Drawing.Point(269, 67);
            this.txtAddDate.Name = "txtAddDate";
            this.txtAddDate.Size = new System.Drawing.Size(142, 20);
            this.txtAddDate.TabIndex = 11;
            // 
            // txtAddOnHand
            // 
            this.txtAddOnHand.Location = new System.Drawing.Point(269, 38);
            this.txtAddOnHand.Name = "txtAddOnHand";
            this.txtAddOnHand.Size = new System.Drawing.Size(142, 20);
            this.txtAddOnHand.TabIndex = 10;
            // 
            // txtAddPrice
            // 
            this.txtAddPrice.Location = new System.Drawing.Point(269, 11);
            this.txtAddPrice.Name = "txtAddPrice";
            this.txtAddPrice.Size = new System.Drawing.Size(142, 20);
            this.txtAddPrice.TabIndex = 9;
            // 
            // lblAddDate
            // 
            this.lblAddDate.AutoSize = true;
            this.lblAddDate.Location = new System.Drawing.Point(176, 70);
            this.lblAddDate.Name = "lblAddDate";
            this.lblAddDate.Size = new System.Drawing.Size(92, 13);
            this.lblAddDate.TabIndex = 8;
            this.lblAddDate.Text = "Transaction Date:";
            // 
            // txtAddAuthor
            // 
            this.txtAddAuthor.Location = new System.Drawing.Point(56, 67);
            this.txtAddAuthor.Name = "txtAddAuthor";
            this.txtAddAuthor.Size = new System.Drawing.Size(118, 20);
            this.txtAddAuthor.TabIndex = 5;
            // 
            // lblAddAuthor
            // 
            this.lblAddAuthor.AutoSize = true;
            this.lblAddAuthor.Location = new System.Drawing.Point(15, 70);
            this.lblAddAuthor.Name = "lblAddAuthor";
            this.lblAddAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAddAuthor.TabIndex = 4;
            this.lblAddAuthor.Text = "Author:";
            // 
            // lblAddOnHand
            // 
            this.lblAddOnHand.AutoSize = true;
            this.lblAddOnHand.Location = new System.Drawing.Point(215, 41);
            this.lblAddOnHand.Name = "lblAddOnHand";
            this.lblAddOnHand.Size = new System.Drawing.Size(53, 13);
            this.lblAddOnHand.TabIndex = 7;
            this.lblAddOnHand.Text = "On Hand:";
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(56, 38);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(118, 20);
            this.txtAddTitle.TabIndex = 3;
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Location = new System.Drawing.Point(15, 41);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(33, 13);
            this.lblAddTitle.TabIndex = 2;
            this.lblAddTitle.Text = "Title: ";
            // 
            // lblAddPrice
            // 
            this.lblAddPrice.AutoSize = true;
            this.lblAddPrice.Location = new System.Drawing.Point(234, 14);
            this.lblAddPrice.Name = "lblAddPrice";
            this.lblAddPrice.Size = new System.Drawing.Size(34, 13);
            this.lblAddPrice.TabIndex = 6;
            this.lblAddPrice.Text = "Price:";
            // 
            // txtAddISBN
            // 
            this.txtAddISBN.Enabled = false;
            this.txtAddISBN.Location = new System.Drawing.Point(56, 11);
            this.txtAddISBN.Name = "txtAddISBN";
            this.txtAddISBN.Size = new System.Drawing.Size(118, 20);
            this.txtAddISBN.TabIndex = 1;
            // 
            // lblAddISBN
            // 
            this.lblAddISBN.AutoSize = true;
            this.lblAddISBN.Location = new System.Drawing.Point(15, 14);
            this.lblAddISBN.Name = "lblAddISBN";
            this.lblAddISBN.Size = new System.Drawing.Size(35, 13);
            this.lblAddISBN.TabIndex = 0;
            this.lblAddISBN.Text = "ISBN:";
            // 
            // lblAddBook
            // 
            this.lblAddBook.AutoSize = true;
            this.lblAddBook.Enabled = false;
            this.lblAddBook.Location = new System.Drawing.Point(25, 203);
            this.lblAddBook.Name = "lblAddBook";
            this.lblAddBook.Size = new System.Drawing.Size(136, 13);
            this.lblAddBook.TabIndex = 12;
            this.lblAddBook.Text = "Group Of Book Add Control";
            this.lblAddBook.Visible = false;
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDone.Location = new System.Drawing.Point(365, 591);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 13;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblModifyBook
            // 
            this.lblModifyBook.AutoSize = true;
            this.lblModifyBook.Enabled = false;
            this.lblModifyBook.Location = new System.Drawing.Point(25, 329);
            this.lblModifyBook.Name = "lblModifyBook";
            this.lblModifyBook.Size = new System.Drawing.Size(154, 13);
            this.lblModifyBook.TabIndex = 15;
            this.lblModifyBook.Text = "Group Of Book Change Control";
            this.lblModifyBook.Visible = false;
            // 
            // pnlModify
            // 
            this.pnlModify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlModify.Controls.Add(this.btnModifyNo);
            this.pnlModify.Controls.Add(this.btnModifyYes);
            this.pnlModify.Controls.Add(this.txtModifyDate);
            this.pnlModify.Controls.Add(this.txtModifyOnHand);
            this.pnlModify.Controls.Add(this.txtModifyPrice);
            this.pnlModify.Controls.Add(this.lblModifyDate);
            this.pnlModify.Controls.Add(this.txtModifyAuthor);
            this.pnlModify.Controls.Add(this.lblModifyAuthor);
            this.pnlModify.Controls.Add(this.lblModifyOnHand);
            this.pnlModify.Controls.Add(this.txtModifyTitle);
            this.pnlModify.Controls.Add(this.lblModifyTitle);
            this.pnlModify.Controls.Add(this.lblModifyPrice);
            this.pnlModify.Controls.Add(this.txtModifyISBN);
            this.pnlModify.Controls.Add(this.lblModifyISBN);
            this.pnlModify.Enabled = false;
            this.pnlModify.Location = new System.Drawing.Point(15, 335);
            this.pnlModify.Name = "pnlModify";
            this.pnlModify.Size = new System.Drawing.Size(425, 120);
            this.pnlModify.TabIndex = 14;
            this.pnlModify.Visible = false;
            // 
            // btnModifyNo
            // 
            this.btnModifyNo.Location = new System.Drawing.Point(208, 92);
            this.btnModifyNo.Name = "btnModifyNo";
            this.btnModifyNo.Size = new System.Drawing.Size(75, 23);
            this.btnModifyNo.TabIndex = 13;
            this.btnModifyNo.Text = "NO";
            this.btnModifyNo.UseVisualStyleBackColor = true;
            this.btnModifyNo.Click += new System.EventHandler(this.btnModifyNo_Click);
            // 
            // btnModifyYes
            // 
            this.btnModifyYes.Location = new System.Drawing.Point(124, 92);
            this.btnModifyYes.Name = "btnModifyYes";
            this.btnModifyYes.Size = new System.Drawing.Size(75, 23);
            this.btnModifyYes.TabIndex = 12;
            this.btnModifyYes.Text = "YES";
            this.btnModifyYes.UseVisualStyleBackColor = true;
            this.btnModifyYes.Click += new System.EventHandler(this.btnModifyYes_Click);
            // 
            // txtModifyDate
            // 
            this.txtModifyDate.Location = new System.Drawing.Point(269, 67);
            this.txtModifyDate.Name = "txtModifyDate";
            this.txtModifyDate.Size = new System.Drawing.Size(142, 20);
            this.txtModifyDate.TabIndex = 11;
            // 
            // txtModifyOnHand
            // 
            this.txtModifyOnHand.Location = new System.Drawing.Point(269, 38);
            this.txtModifyOnHand.Name = "txtModifyOnHand";
            this.txtModifyOnHand.Size = new System.Drawing.Size(142, 20);
            this.txtModifyOnHand.TabIndex = 10;
            // 
            // txtModifyPrice
            // 
            this.txtModifyPrice.Location = new System.Drawing.Point(269, 11);
            this.txtModifyPrice.Name = "txtModifyPrice";
            this.txtModifyPrice.Size = new System.Drawing.Size(142, 20);
            this.txtModifyPrice.TabIndex = 9;
            // 
            // lblModifyDate
            // 
            this.lblModifyDate.AutoSize = true;
            this.lblModifyDate.Location = new System.Drawing.Point(176, 70);
            this.lblModifyDate.Name = "lblModifyDate";
            this.lblModifyDate.Size = new System.Drawing.Size(92, 13);
            this.lblModifyDate.TabIndex = 8;
            this.lblModifyDate.Text = "Transaction Date:";
            // 
            // txtModifyAuthor
            // 
            this.txtModifyAuthor.Location = new System.Drawing.Point(56, 67);
            this.txtModifyAuthor.Name = "txtModifyAuthor";
            this.txtModifyAuthor.Size = new System.Drawing.Size(118, 20);
            this.txtModifyAuthor.TabIndex = 5;
            // 
            // lblModifyAuthor
            // 
            this.lblModifyAuthor.AutoSize = true;
            this.lblModifyAuthor.Location = new System.Drawing.Point(15, 70);
            this.lblModifyAuthor.Name = "lblModifyAuthor";
            this.lblModifyAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblModifyAuthor.TabIndex = 4;
            this.lblModifyAuthor.Text = "Author:";
            // 
            // lblModifyOnHand
            // 
            this.lblModifyOnHand.AutoSize = true;
            this.lblModifyOnHand.Location = new System.Drawing.Point(215, 41);
            this.lblModifyOnHand.Name = "lblModifyOnHand";
            this.lblModifyOnHand.Size = new System.Drawing.Size(53, 13);
            this.lblModifyOnHand.TabIndex = 7;
            this.lblModifyOnHand.Text = "On Hand:";
            // 
            // txtModifyTitle
            // 
            this.txtModifyTitle.Location = new System.Drawing.Point(56, 38);
            this.txtModifyTitle.Name = "txtModifyTitle";
            this.txtModifyTitle.Size = new System.Drawing.Size(118, 20);
            this.txtModifyTitle.TabIndex = 3;
            // 
            // lblModifyTitle
            // 
            this.lblModifyTitle.AutoSize = true;
            this.lblModifyTitle.Location = new System.Drawing.Point(15, 41);
            this.lblModifyTitle.Name = "lblModifyTitle";
            this.lblModifyTitle.Size = new System.Drawing.Size(33, 13);
            this.lblModifyTitle.TabIndex = 2;
            this.lblModifyTitle.Text = "Title: ";
            // 
            // lblModifyPrice
            // 
            this.lblModifyPrice.AutoSize = true;
            this.lblModifyPrice.Location = new System.Drawing.Point(234, 14);
            this.lblModifyPrice.Name = "lblModifyPrice";
            this.lblModifyPrice.Size = new System.Drawing.Size(34, 13);
            this.lblModifyPrice.TabIndex = 6;
            this.lblModifyPrice.Text = "Price:";
            // 
            // txtModifyISBN
            // 
            this.txtModifyISBN.Enabled = false;
            this.txtModifyISBN.Location = new System.Drawing.Point(56, 11);
            this.txtModifyISBN.Name = "txtModifyISBN";
            this.txtModifyISBN.Size = new System.Drawing.Size(118, 20);
            this.txtModifyISBN.TabIndex = 1;
            // 
            // lblModifyISBN
            // 
            this.lblModifyISBN.AutoSize = true;
            this.lblModifyISBN.Location = new System.Drawing.Point(15, 14);
            this.lblModifyISBN.Name = "lblModifyISBN";
            this.lblModifyISBN.Size = new System.Drawing.Size(35, 13);
            this.lblModifyISBN.TabIndex = 0;
            this.lblModifyISBN.Text = "ISBN:";
            // 
            // lblDeleteBook
            // 
            this.lblDeleteBook.AutoSize = true;
            this.lblDeleteBook.Enabled = false;
            this.lblDeleteBook.Location = new System.Drawing.Point(25, 459);
            this.lblDeleteBook.Name = "lblDeleteBook";
            this.lblDeleteBook.Size = new System.Drawing.Size(148, 13);
            this.lblDeleteBook.TabIndex = 17;
            this.lblDeleteBook.Text = "Group Of Book Delete Control";
            this.lblDeleteBook.Visible = false;
            // 
            // pnlDelete
            // 
            this.pnlDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDelete.Controls.Add(this.txtDeletePrice);
            this.pnlDelete.Controls.Add(this.lblDeletePrice);
            this.pnlDelete.Controls.Add(this.txtDeleteTransactionDate);
            this.pnlDelete.Controls.Add(this.txtDeleteOnHand);
            this.pnlDelete.Controls.Add(this.lblDeleteTransactionDate);
            this.pnlDelete.Controls.Add(this.txtDeleteAuthor);
            this.pnlDelete.Controls.Add(this.lblDeleteAuthor);
            this.pnlDelete.Controls.Add(this.lblDeleteOnHand);
            this.pnlDelete.Controls.Add(this.txtDeleteTitle);
            this.pnlDelete.Controls.Add(this.lblDeleteTitle);
            this.pnlDelete.Controls.Add(this.btnDeleteNo);
            this.pnlDelete.Controls.Add(this.btnDeleteYes);
            this.pnlDelete.Controls.Add(this.txtDeleteISBN);
            this.pnlDelete.Controls.Add(this.lblDeleteISBN);
            this.pnlDelete.Enabled = false;
            this.pnlDelete.Location = new System.Drawing.Point(15, 465);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(425, 120);
            this.pnlDelete.TabIndex = 16;
            this.pnlDelete.Visible = false;
            // 
            // txtDeletePrice
            // 
            this.txtDeletePrice.Enabled = false;
            this.txtDeletePrice.Location = new System.Drawing.Point(269, 9);
            this.txtDeletePrice.Name = "txtDeletePrice";
            this.txtDeletePrice.Size = new System.Drawing.Size(142, 20);
            this.txtDeletePrice.TabIndex = 23;
            // 
            // lblDeletePrice
            // 
            this.lblDeletePrice.AutoSize = true;
            this.lblDeletePrice.Enabled = false;
            this.lblDeletePrice.Location = new System.Drawing.Point(234, 12);
            this.lblDeletePrice.Name = "lblDeletePrice";
            this.lblDeletePrice.Size = new System.Drawing.Size(34, 13);
            this.lblDeletePrice.TabIndex = 22;
            this.lblDeletePrice.Text = "Price:";
            // 
            // txtDeleteTransactionDate
            // 
            this.txtDeleteTransactionDate.Enabled = false;
            this.txtDeleteTransactionDate.Location = new System.Drawing.Point(269, 64);
            this.txtDeleteTransactionDate.Name = "txtDeleteTransactionDate";
            this.txtDeleteTransactionDate.Size = new System.Drawing.Size(142, 20);
            this.txtDeleteTransactionDate.TabIndex = 21;
            // 
            // txtDeleteOnHand
            // 
            this.txtDeleteOnHand.Enabled = false;
            this.txtDeleteOnHand.Location = new System.Drawing.Point(269, 35);
            this.txtDeleteOnHand.Name = "txtDeleteOnHand";
            this.txtDeleteOnHand.Size = new System.Drawing.Size(142, 20);
            this.txtDeleteOnHand.TabIndex = 20;
            // 
            // lblDeleteTransactionDate
            // 
            this.lblDeleteTransactionDate.AutoSize = true;
            this.lblDeleteTransactionDate.Enabled = false;
            this.lblDeleteTransactionDate.Location = new System.Drawing.Point(176, 67);
            this.lblDeleteTransactionDate.Name = "lblDeleteTransactionDate";
            this.lblDeleteTransactionDate.Size = new System.Drawing.Size(92, 13);
            this.lblDeleteTransactionDate.TabIndex = 19;
            this.lblDeleteTransactionDate.Text = "Transaction Date:";
            // 
            // txtDeleteAuthor
            // 
            this.txtDeleteAuthor.Enabled = false;
            this.txtDeleteAuthor.Location = new System.Drawing.Point(56, 64);
            this.txtDeleteAuthor.Name = "txtDeleteAuthor";
            this.txtDeleteAuthor.Size = new System.Drawing.Size(118, 20);
            this.txtDeleteAuthor.TabIndex = 17;
            // 
            // lblDeleteAuthor
            // 
            this.lblDeleteAuthor.AutoSize = true;
            this.lblDeleteAuthor.Location = new System.Drawing.Point(15, 67);
            this.lblDeleteAuthor.Name = "lblDeleteAuthor";
            this.lblDeleteAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblDeleteAuthor.TabIndex = 16;
            this.lblDeleteAuthor.Text = "Author:";
            // 
            // lblDeleteOnHand
            // 
            this.lblDeleteOnHand.AutoSize = true;
            this.lblDeleteOnHand.Enabled = false;
            this.lblDeleteOnHand.Location = new System.Drawing.Point(215, 38);
            this.lblDeleteOnHand.Name = "lblDeleteOnHand";
            this.lblDeleteOnHand.Size = new System.Drawing.Size(53, 13);
            this.lblDeleteOnHand.TabIndex = 18;
            this.lblDeleteOnHand.Text = "On Hand:";
            // 
            // txtDeleteTitle
            // 
            this.txtDeleteTitle.Enabled = false;
            this.txtDeleteTitle.Location = new System.Drawing.Point(56, 35);
            this.txtDeleteTitle.Name = "txtDeleteTitle";
            this.txtDeleteTitle.Size = new System.Drawing.Size(118, 20);
            this.txtDeleteTitle.TabIndex = 15;
            // 
            // lblDeleteTitle
            // 
            this.lblDeleteTitle.AutoSize = true;
            this.lblDeleteTitle.Location = new System.Drawing.Point(15, 38);
            this.lblDeleteTitle.Name = "lblDeleteTitle";
            this.lblDeleteTitle.Size = new System.Drawing.Size(33, 13);
            this.lblDeleteTitle.TabIndex = 14;
            this.lblDeleteTitle.Text = "Title: ";
            // 
            // btnDeleteNo
            // 
            this.btnDeleteNo.Location = new System.Drawing.Point(208, 92);
            this.btnDeleteNo.Name = "btnDeleteNo";
            this.btnDeleteNo.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteNo.TabIndex = 13;
            this.btnDeleteNo.Text = "NO";
            this.btnDeleteNo.UseVisualStyleBackColor = true;
            this.btnDeleteNo.Click += new System.EventHandler(this.btnDeleteNo_Click);
            // 
            // btnDeleteYes
            // 
            this.btnDeleteYes.Location = new System.Drawing.Point(124, 92);
            this.btnDeleteYes.Name = "btnDeleteYes";
            this.btnDeleteYes.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteYes.TabIndex = 12;
            this.btnDeleteYes.Text = "YES";
            this.btnDeleteYes.UseVisualStyleBackColor = true;
            this.btnDeleteYes.Click += new System.EventHandler(this.btnDeleteYes_Click);
            // 
            // txtDeleteISBN
            // 
            this.txtDeleteISBN.Enabled = false;
            this.txtDeleteISBN.Location = new System.Drawing.Point(57, 9);
            this.txtDeleteISBN.Name = "txtDeleteISBN";
            this.txtDeleteISBN.Size = new System.Drawing.Size(118, 20);
            this.txtDeleteISBN.TabIndex = 1;
            // 
            // lblDeleteISBN
            // 
            this.lblDeleteISBN.AutoSize = true;
            this.lblDeleteISBN.Location = new System.Drawing.Point(16, 12);
            this.lblDeleteISBN.Name = "lblDeleteISBN";
            this.lblDeleteISBN.Size = new System.Drawing.Size(35, 13);
            this.lblDeleteISBN.TabIndex = 0;
            this.lblDeleteISBN.Text = "ISBN:";
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDone;
            this.ClientSize = new System.Drawing.Size(452, 626);
            this.Controls.Add(this.lblDeleteBook);
            this.Controls.Add(this.pnlDelete);
            this.Controls.Add(this.lblModifyBook);
            this.Controls.Add(this.pnlModify);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblAddBook);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.lblSelectTransaction);
            this.Controls.Add(this.btnOKIsbn);
            this.Controls.Add(this.txtSecondISBN);
            this.Controls.Add(this.lblDash);
            this.Controls.Add(this.txtFirstISBN);
            this.Controls.Add(this.lblEnterISBN);
            this.Controls.Add(this.lblTransaction);
            this.Controls.Add(this.lblStore);
            this.Name = "frmTransaction";
            this.Text = "Select a Transaction";
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlModify.ResumeLayout(false);
            this.pnlModify.PerformLayout();
            this.pnlDelete.ResumeLayout(false);
            this.pnlDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Label lblEnterISBN;
        private System.Windows.Forms.TextBox txtFirstISBN;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.TextBox txtSecondISBN;
        private System.Windows.Forms.Button btnOKIsbn;
        private System.Windows.Forms.Label lblSelectTransaction;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label lblAddBook;
        private System.Windows.Forms.Label lblAddAuthor;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.TextBox txtAddISBN;
        private System.Windows.Forms.Label lblAddISBN;
        private System.Windows.Forms.Button btnAddNo;
        private System.Windows.Forms.Button btnAddYes;
        private System.Windows.Forms.TextBox txtAddDate;
        private System.Windows.Forms.TextBox txtAddOnHand;
        private System.Windows.Forms.TextBox txtAddPrice;
        private System.Windows.Forms.Label lblAddDate;
        private System.Windows.Forms.TextBox txtAddAuthor;
        private System.Windows.Forms.Label lblAddOnHand;
        private System.Windows.Forms.Label lblAddPrice;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblModifyBook;
        private System.Windows.Forms.Panel pnlModify;
        private System.Windows.Forms.Button btnModifyNo;
        private System.Windows.Forms.Button btnModifyYes;
        private System.Windows.Forms.TextBox txtModifyDate;
        private System.Windows.Forms.TextBox txtModifyOnHand;
        private System.Windows.Forms.TextBox txtModifyPrice;
        private System.Windows.Forms.Label lblModifyDate;
        private System.Windows.Forms.TextBox txtModifyAuthor;
        private System.Windows.Forms.Label lblModifyAuthor;
        private System.Windows.Forms.Label lblModifyOnHand;
        private System.Windows.Forms.TextBox txtModifyTitle;
        private System.Windows.Forms.Label lblModifyTitle;
        private System.Windows.Forms.Label lblModifyPrice;
        private System.Windows.Forms.TextBox txtModifyISBN;
        private System.Windows.Forms.Label lblModifyISBN;
        private System.Windows.Forms.Label lblDeleteBook;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Button btnDeleteNo;
        private System.Windows.Forms.Button btnDeleteYes;
        private System.Windows.Forms.TextBox txtDeleteISBN;
        private System.Windows.Forms.Label lblDeleteISBN;
        private System.Windows.Forms.TextBox txtDeletePrice;
        private System.Windows.Forms.Label lblDeletePrice;
        private System.Windows.Forms.TextBox txtDeleteTransactionDate;
        private System.Windows.Forms.TextBox txtDeleteOnHand;
        private System.Windows.Forms.Label lblDeleteTransactionDate;
        private System.Windows.Forms.TextBox txtDeleteAuthor;
        private System.Windows.Forms.Label lblDeleteAuthor;
        private System.Windows.Forms.Label lblDeleteOnHand;
        private System.Windows.Forms.TextBox txtDeleteTitle;
        private System.Windows.Forms.Label lblDeleteTitle;
    }
}
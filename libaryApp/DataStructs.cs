﻿using System;
using System.Collections.Generic;
using System.Text;

namespace libaryApp
{

    #region bookClasses

    /// <summary>
    /// book class and all its propety
    /// </summary>
    public class Book
    {
        public int bookId { private get; set; }
        public string BookName { get; set; }
        public Generes Genre { get; set; }
        public Authors Author { get; set; }
        public Publishers Publisher { get; set; }
        public short PublicationYear { get; set; }
     
        public int getBookID()
        {
            return bookId;
        }
    }

    public class BookCopies
    {

        public int CopyID { get; set; }

        private bool _isAvailable;
        public string isAvailable { get { return _isAvailable ? "נמצא" : "לא נמצא"; } }
        public int bookId { private get;  set; }
        public BookCopies(int bookId, int CopyID, bool isAvailable)

        {
            this._isAvailable = isAvailable;
            this.CopyID = CopyID;
            this.bookId = bookId;

        }

        public int getBookID()
        {
            return bookId;
        }

    }

    /// <summary>
    /// book's Attribute abscract structure.
    /// </summary>
    public abstract class BookAttributes
    {
        public int ID { get; }
        public string Value { get; }
        public BookAttributes(int id, string value)
        {
            ID = id;
            Value = value;
        }
        public override string ToString() 
        {
            return Value;
        }
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                BookAttributes p = (BookAttributes)obj;
                return (ID == p.ID) && (Value == p.Value);
            }
        }
        public override int GetHashCode()
        {
            return ID.GetHashCode() + Value.GetHashCode();
        }
    }


    /// <summary>
    /// one of book's Attribute
    /// </summary>
    public class Generes : BookAttributes
    {
        public Generes(int id, string value) : base(id, value)
        {

        }
    }
    /// <summary>
    /// one of book's Attribute
    /// </summary>
    public class Publishers : BookAttributes
    {
        public Publishers(int id, string value) : base(id, value)
        {

        }

    }
    /// <summary>
    /// one of book's Attribute
    /// </summary>
    public class Authors : BookAttributes
    {
        public Authors(int id, string value) : base(id, value)
        {

        }

    }
    #endregion


    public class Member
    {
        public string memberName { get; set; }
        public int MemberID { get; set; }
        public long PersonID { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Email { get;  set; }
    }

    public class Loan
    {
        public int LoanID { get; set; }
        public int CopyID { get; set; }
        public string BookName { get; set; }
        public DateTime dateOfLoan { get; set; }
    }

}

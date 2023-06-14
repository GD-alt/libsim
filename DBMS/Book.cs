using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS
{
    public class Book
    {
        private string _holder;
        private DateTime _issueDate;
        private string _bookName;
        private double _cost;
        private bool _ifPresent;

        public string Holder
        {
            get { return _holder; }
            set { _holder = value; }
        }

        public DateTime IssueDate
        {
            get { return _issueDate; }
            set { _issueDate = value; }
        }

        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }

        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public bool Present
        {
            get { return _ifPresent; }
            set { _ifPresent = value; }
        }

        public Book (string holder, DateTime issueDate, string bookName, double cost, bool present)
        {
            Holder = holder;
            IssueDate = issueDate;
            BookName = bookName;
            Cost = cost;
            Present = present;
        }

        public override string ToString()
        {
            return $"{BookName} ({Cost} RUR) (Present? {Present}) holded by {Holder} at {IssueDate}";
        }
    }
}

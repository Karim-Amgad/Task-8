using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal struct Account
    {
        #region Attributes
        private int AccountId;
        private string AccountHolder;
        private decimal Balance;
        #endregion

        #region Properties
        public int ACCOUNTID
        {
            get { return AccountId; }
            set { AccountId = value; }
        }
        public string ACCOUNTHOLDER
        {
            get { return AccountHolder; }
            set { AccountHolder = value; }
        }

        public decimal BALANCE
        {
            get { return Balance; }
            set { Balance = value; }
        }
        #endregion

        #region Constructor
        public Account (int _Id, string _AccountHolder, decimal _Balance)
        {
            AccountId = _Id;
            AccountHolder = _AccountHolder;
            Balance = _Balance;
        }
        #endregion
    }
}

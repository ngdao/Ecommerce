using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    class OrderObject
    {

        private String senderID;
        private String receiverID;
        private int cardNo;
        private decimal amount;
        private decimal unitPrice;


        public void setSenderID(string senderID)
        {
            this.senderID = senderID;
        }

        public void setReceiverID(string receiverID)
        {
            this.receiverID = receiverID;
        }

        public void setCardNo(int cardNo)
        {
            this.cardNo = cardNo;
        }

        public void setAmount(decimal amount)
        {
            this.amount = amount;
        }

        public void setUnitPrice(decimal unitPrice)
        {
            this.unitPrice = unitPrice;
        }

        public string getSenderID()
        {
            return this.senderID;
        }

        public string getReceiverID()
        {
            return this.receiverID;
        }

        public int getCardNo()
        {
            return this.cardNo;
        }

        public decimal getAmount()
        {
            return this.amount;
        }

        public decimal getUnitPrice()
        {
            return this.unitPrice;
        }

    }
}

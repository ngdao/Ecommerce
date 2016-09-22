using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    class BankService
    {

        public void addClient(String clientID, decimal init_amount_to_deposit) {

        }

        public void depositToClientAmount(decimal ) {

        }
        public decimal withdrawFromClientAmount() {
            return 0; //TODO:: Update this. THIS IS MERELY A PLACEHOLDER TO WARD OFF ANNOYING IDE ERROR NOTIFICATION.
        }


        /// <summary>
        /// This private class is for use of the Bank Service class only. This Client is for use of the bank to track it's current Customers/clients and their current standing with the Bank
        /// from their valid credit card number, to the amount that they have stored in the bank system.
        /// </summary>
        private class Client {
            private String clientID;
            private int cardNo;
            private decimal amount;


            /// <summary>
            /// This Getter function returns the client Identification String of a client to this bank.
            /// </summary>
            /// <returns>This String format of a Client ID.</returns>
            public String getClientID() {
                return this.clientID;
            }


            /// <summary>
            /// This Getter Function returns the credit card number of a Client to this bank.
            /// </summary>
            /// <returns>The integer format of a credit card number of a Client to this bank.</returns>
            public int getClientCardNo() {
                return this.cardNo;
            }


            /// <summary>
            /// This Getter function returns the total amount a Client has in the Bank in the proper format (to 2 decimal places).
            /// </summary>
            /// <returns>The decimal amount a Client has in the bank.</returns>
            public decimal getClientAmount() {
                return decimal.Round(this.amount,2,MidpointRounding.AwayFromZero);//properly round decimal value for accuracy whilst handling currency.
            }

            /// <summary>
            /// This Setter Function updates the Client's Identifier.
            /// </summary>
            /// <param name="id">String representation of the new Client ID.</param>
            public void setClientID(String id) { }

            /// <summary>
            /// This Setter Function updates the client's credit card number.
            /// </summary>
            /// <param name="cNumber">integer representation of the new credit card number.</param>
            public void setClientCardNo(int cNumber) { }


            /// <summary>
            /// This Setter Function updates the decimal amount of a clients monetary value in the bank.
            /// </summary>
            /// <param name="amt">New decimal value to set the Client's amount attribute to.</param>
            public void setClientAmount(decimal amt) { }
        }


    }


}


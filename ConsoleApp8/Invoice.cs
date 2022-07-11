using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
     class Invoice
    {
        private string account;
        private string customer;
        private string provider;
        public string Article { get; set; }
        public int Quantity { get; set; }
        public Invoice(string account,string customer,string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public Invoice()
        {

        }
        public double CostCalculation(bool needEdv)
        {
            double price = 0;
            double edv = 0.18;
            if (Article == "laptop")
            {
                price = 1400;
            }
           else if(Article== "SD")
            {
                price = 30;
            }
               else
            {
                price = 12;
            }



            if (needEdv == true)
            {
                price = price * Quantity + edv;
            }


            else
            {
                price = price * Quantity;
            }
        
            return price;
        }

            

           
             
         }


        }
    
   



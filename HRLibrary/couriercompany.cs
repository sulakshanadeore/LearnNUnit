using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HRLibrary
{

   public class Courier
    {

        public Courier(int cid,string sendername,string recname,string recadd,string senderadd,
            float courweight,string status,int tracid,DateTime deliverydate,int userid)
        {
            CourierID = cid;
            this.sendername = sendername;
            receiverName = recname; 
           weight = courweight;
            senderAddress = senderadd;
            receiverAddress = recadd;
            this.status = status;
            this.deliveryDate = deliverydate;
            this.userId = userid;
            trackingNumber = tracid;





        }
        public int CourierID { get; set; }
        public string sendername { get; set; } 
        public string senderAddress { get; set; }
        public string receiverName { get; set; }
        public string receiverAddress { get; set; }
        public float weight { get; set; }

        public string status { get; set; }
        public int trackingNumber { get; set; }

        public DateTime deliveryDate { get; set; }
        public int userId { get; set; }
        
    }


    public class couriercompany
    {

        public string CompanyName { get; set; }

        public List<Courier> couriers { get; set; }
        
        //employeeDetails- 
        //    collection of Employee Objects,
        
        //locationDetails - collection of Location Objects.
    }

    public class CourierCompanyCollection
    {
          public List<couriercompany> couriercompanies { get; set; }
       // couriercompany[] couriercompanies = new couriercompany[2];
        public CourierCompanyCollection(couriercompany company)
        {
            this.couriercompanies.Add(company);
            //for (int i = 0; i < couriercompanies.Length; i++)
            //{
            //    this.couriercompanies[i] = company;
            //}
        }
    }

    interface ICourierUserService {
        
    string    getOrderStatus(int trackingNo);
        /**Get the status of a courier order.
        *@param trackingNumber The tracking number of the courier order.
        * @return The status of the courier order (e.g., yetToTransit, In Transit, Delivered).
*/


    }

    class CourierUserServiceCollectionImpl : ICourierUserService
    {
        CourierCompanyCollection _companyObj;

        public CourierUserServiceCollectionImpl(CourierCompanyCollection courierCompanyCollection)
        {
                _companyObj = courierCompanyCollection; 
        }
        public string getOrderStatus(int trackingNo)
        {
            string courierStatus = null;
            //   throw new NotImplementedException();
            for(int i=0;i<=_companyObj.couriercompanies.Count;i++)
            {
                List<Courier> couriers=_companyObj.couriercompanies[i].couriers;
                         
                Courier courierdata=couriers.Find(c=>c.trackingNumber==trackingNo);
                courierStatus=courierdata.status;
            }

            return courierStatus;
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JarvisGUI
{
    class InternetConnectionSettings
    {
        public bool connectionCheck()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                    return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        byte[] data;
        public double CheckInternetSpeed()
        {
            // Create Object Of WebClient
            WebClient wc = new WebClient();
            
            //DateTime Variable To Store Download Start Time.
            DateTime dt1 = DateTime.Now;

            //Number Of Bytes Downloaded Are Stored In ‘data’
            try
            {
                data = wc.DownloadData("http://www.google.com");

            }
            catch (Exception)
            {

             
            }
            //DateTime Variable To Store Download End Time.
            DateTime dt2 = DateTime.Now;

            //To Calculate Speed in Kb Divide Value Of data by 1024 And Then by End Time Subtract Start Time To Know Download Per Second.
            return Math.Round((data.Length / 1024) / (dt2 - dt1).TotalSeconds, 2);
        }

    }
}

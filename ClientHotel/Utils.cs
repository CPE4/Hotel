using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientHotel
{
    class Utils
    {
        public static string getDataFromApi(string url, string format, string id = "undefined")
        {
            if (id != "undefined")
            {
                url += id.ToString();
            }
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = "application/" + format;
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Get the stream associated with the response.
            Stream receiveStream = response.GetResponseStream();

            // Pipes the stream to a higher level stream reader with the required encoding format. 
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            string data = readStream.ReadToEnd();
            response.Close();
            readStream.Close();

            return data;
        }

        public static void sendDataToApi(string url, string data, string id = "undefined")
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            if (id != "undefined")
            {
                request.Method = "PUT";
            }
            else
            {
                request.Method = "POST";
            }

            // Set the content type of the data being posted.
            request.Accept = "application/json";
            request.ContentType = "text/json";


            StreamWriter StreamWriter = new StreamWriter(request.GetRequestStream());
            StreamWriter.Write(data);
            StreamWriter.Flush();
            StreamWriter.Close();
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream receiveStream = response.GetResponseStream();
            
            // Close the Stream object.
            response.Close();
        }

        public static void deleteDataFromApi(string url, string id)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + id);
            request.Method = "DELETE";
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // Get the stream associated with the response.
                Stream receiveStream = response.GetResponseStream();

                // Pipes the stream to a higher level stream reader with the required encoding format. 
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                response.Close();
                readStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex.Message);
            }


        }
    }
}

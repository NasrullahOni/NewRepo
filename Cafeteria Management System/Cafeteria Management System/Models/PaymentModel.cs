//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;

//namespace Cafeteria_Management_System.Models
//{
// public static class MakePayment
//    {
//        public static async Task<GetPayment> MakePaymentAsync(Payment model)
//        {
//           GetPayment result = new GetPayment();
//            using (var httpClient = new HttpClient())
//            {
//                StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
//                using (var response = await httpClient.PostAsync("https://cyberpay-payment-api.azurewebsites.net/api/v1/payments", content))
//                {
//                    string apiResponse = await response.Content.ReadAsStringAsync();
//                    result = JsonConvert.DeserializeObject<GetPayment>(apiResponse);
//                }
//            }
//            return result;
//        }
//    }

    
//    public class Datas
//    {
//        public string TransactionReference { get; set; }
//        public int charge { get; set; }
//        public string redirectUrl { get; set; }
//    }
//    public class GetPayment
//    {
//        public Data data { get; set; }
//        public bool succeeded { get; set; }
//    }



//}

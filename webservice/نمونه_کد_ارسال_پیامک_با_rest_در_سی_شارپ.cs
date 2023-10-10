using System.Net.Http;
void Main()
{
var client = new HttpClient(); 
var data = new List<KeyValuePair<string, string>>
{
new KeyValuePair<string, string>("username","USERNAME"),
new KeyValuePair<string, string>("password","PASSWORD" ),
new KeyValuePair<string, string>("mobile","09395213300" ),
new KeyValuePair<string, string>("message","MESSAGE_TEXT" ),
new KeyValuePair<string, string>("line","983000...." ),
// new KeyValuePair<string, string>("type","2" ), برای ارسال پیامک فعالسازی با خط خدماتی شرکت
};
var response = client.PostAsync("https://sms.3300.ir/api/wssend.ashx", new FormUrlEncodedContent(data)).Result;
Console.Write(response.Content.ReadAsStringAsync().Result);

//result: نمونه پاسخ دریافتی
//{"data":{"message_id":35702617027,"line":983000330000,"mobile":989395213300},"status":-1,"msg":"success"}
}

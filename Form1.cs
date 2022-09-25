using MegaMill.Models;
using System.Drawing.Printing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace MegaMill
{
    public partial class Form1 : Form
    {
        public const string currentUrl = "https://www.megamillions.com/cmspages/utilservice.asmx/GetLatestDrawData";
        public const string getAllNumbersUrl = "https://www.megamillions.com/cmspages/utilservice.asmx/GetDrawingPagingData";
        public Form1()
        {
            InitializeComponent();

            startDatePicker.Value = DateTime.Today.AddDays(-7);

            GetCurrentNumbers();
        }

        public async void GetCurrentNumbers()
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage message = new(HttpMethod.Get, currentUrl);

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                var temp = await response.Content.ReadAsStringAsync();
                temp = temp.Replace("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<string xmlns=\"http://tempuri.org/\">", "");
                temp = temp.Replace("</string>", "");

                var currentNumbersResponse = JsonSerializer.Deserialize<CurrentNumbersResponse>(temp);

                currentNumbers.Items.Add(currentNumbersResponse.Drawing.N1.ToString());
                currentNumbers.Items.Add(currentNumbersResponse.Drawing.N2.ToString());
                currentNumbers.Items.Add(currentNumbersResponse.Drawing.N3.ToString());
                currentNumbers.Items.Add(currentNumbersResponse.Drawing.N4.ToString());
                currentNumbers.Items.Add(currentNumbersResponse.Drawing.N5.ToString());
                currentNumbers.Items.Add(currentNumbersResponse.Drawing.MBall.ToString());
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var requestObject = new
            {
              pageSize = 1000,
              startDate = startDatePicker.Value.ToShortDateString(),
              endDate = endDatePicker.Value.ToShortDateString(),
              pageNumber = 1,
            };

            HttpClient client = new HttpClient();
            HttpRequestMessage message = new(HttpMethod.Post, getAllNumbersUrl);
            message.Content = new StringContent(JsonSerializer.Serialize<object>(requestObject), Encoding.UTF8,
                                    "application/json");
            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                var temp = await response.Content.ReadAsStringAsync();
                temp = temp.Remove(0, 6);
                temp = temp.Remove(temp.Length - 2);
                temp = temp.Replace("\\", "");
                temp = temp.Replace("\\", "");

                var drawingData = JsonSerializer.Deserialize<DrawingDataResponse>(temp);

                PrintData(drawingData);
            }
        }

        public void PrintData(DrawingDataResponse data)
        {
            List<int> numbers = new();

            displayBox.Items.Add("");
            displayBox.Items.Add("Winning Numbers");
            displayBox.Items.Add("---------------------------------------");
            displayBox.Items.Add("");
            foreach(var numberSet in data.DrawingData)
            {
                displayBox.Items.Add($"Date Played: {numberSet.PlayDate}");
                displayBox.Items.Add($"Number 1:      {numberSet.N1}");
                displayBox.Items.Add($"Number 2:      {numberSet.N2}");
                displayBox.Items.Add($"Number 3:      {numberSet.N3}");
                displayBox.Items.Add($"Number 4:      {numberSet.N4}");
                displayBox.Items.Add($"Number 5:      {numberSet.N5}");
                displayBox.Items.Add($"Mega Ball:     {numberSet.MBall}");
                displayBox.Items.Add("");
                displayBox.Items.Add("--------------------------------------");
                displayBox.Items.Add("");

                numbers.Add(numberSet.N1);
                numbers.Add(numberSet.N2);
                numbers.Add(numberSet.N3);
                numbers.Add(numberSet.N4);
                numbers.Add(numberSet.N5);
                numbers.Add(numberSet.MBall);
            }

            displayBox.Items.Add("");
            displayBox.Items.Add("Number Frequency");
            displayBox.Items.Add("");

            var counts = AnalyzeNumbers(numbers);
            var orderdCounts = counts.OrderByDescending(x => x.Value);
            foreach(var count in orderdCounts)
            {
                displayBox.Items.Add($"{count.Key} : {count.Value}");
            }

            copyButton.Enabled = true;
        }

        private Dictionary<int, int> AnalyzeNumbers(List<int> numbers)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach(var number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 0;
                }
            }

            return counts;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayBox.Items.Clear();
            copyButton.Enabled = false;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            var stringBuilder = new StringBuilder();
            
            foreach(var item in displayBox.Items)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            Clipboard.SetText(stringBuilder.ToString());
        }

        private List<T> CollectionToList<T>( ListBox.ObjectCollection collection)
        {
            List<T> list = new List<T>();

            foreach(var item in collection)
            {
                list.Add((T) item);
            }

            return list;
        }
    }
}
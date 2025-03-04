using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleNativeLLMClient
{
    public partial class SimpleNativeLLMClient : Form
    {
        private List<Message> conversation = new List<Message>();
        private readonly HttpClient client = new HttpClient();

        public SimpleNativeLLMClient()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load saved settings
            urlTextBox.Text = Properties.Settings.Default.ServerUrl;
            apiKeyTextBox.Text = Properties.Settings.Default.ApiKey;
            modelTextBox.Text = Properties.Settings.Default.Model;
            promptTextBox.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save settings
            Properties.Settings.Default.ServerUrl = urlTextBox.Text;
            Properties.Settings.Default.ApiKey = apiKeyTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            string url = urlTextBox.Text.Trim();
            string model = modelTextBox.Text.Trim();
            string apiKey = apiKeyTextBox.Text.Trim();
            string prompt = promptTextBox.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(url) || string.IsNullOrWhiteSpace(apiKey) || string.IsNullOrWhiteSpace(prompt))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            sendButton.Enabled = false;
            try
            {
                // Add the user's message to the conversation (assuming 'conversation' is a List<Message>)
                var msg = new Message { role = "user", content = prompt };
                conversation.Add(msg);
                UpdateConversationDisplay(); // Update UI (assuming this method exists)
                promptTextBox.Clear();

                // Prepare the request body
                var requestBody = new
                {
                    model = "gpt-3.5-turbo", // Adjust model as needed
                    messages = conversation.ToArray()
                };
                var json = JsonSerializer.Serialize(requestBody);

                // Construct the full URI and create HttpRequestMessage
                var fullUri = new Uri(new Uri(url), "v1/chat/completions");
                var request = new HttpRequestMessage(HttpMethod.Post, fullUri);
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the request using the existing HttpClient instance
                var response = await client.SendAsync(request);

                // Handle the response
                if (response.IsSuccessStatusCode)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    var chatResponse = JsonSerializer.Deserialize<ChatCompletionResponse>(responseJson);
                    if (chatResponse.choices.Length > 0)
                    {
                        var assistantMessage = chatResponse.choices[0].message;
                        conversation.Add(assistantMessage);
                        UpdateConversationDisplay();
                    }
                    else
                    {
                        MessageBox.Show("No response from server.");
                    }
                }
                else
                {
                    var errorJson = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error: {response.StatusCode} - {errorJson}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
            finally
            {
                sendButton.Enabled = true;
                promptTextBox.Focus();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            conversation.Clear();
            responseTextBox.Clear();
            promptTextBox.Focus();
        }

        private void PromptTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendButton_Click(sender, e);
                e.Handled = true;
            }
        }

        private void UpdateConversationDisplay()
        {
            responseTextBox.Text = string.Join("\n\n", conversation.Select(m => $"{m.role}: {m.content}"));
            responseTextBox.Text = responseTextBox.Text.Replace("\n", Environment.NewLine);
            responseTextBox.SelectionStart = responseTextBox.Text.Length;
            responseTextBox.ScrollToCaret();
        }
    }
}

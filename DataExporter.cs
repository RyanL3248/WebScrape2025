using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Word;

namespace WebScrape2025
{
    class DataExporter
    {
        public DataExporter()
        {
            
        }

        // Method to export data to a JSON file (#4 Writing to a JSON file)
        public void ExportToJson(string filePath, object data)
        {
            try
            {
                // Serialize the data into JSON format
                string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);

                // Write the JSON data to the file
                File.WriteAllText(filePath, jsonData);

                MessageBox.Show("Data successfully exported to JSON.");
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the export process
                MessageBox.Show($"Error exporting data to JSON: {ex.Message}");
            }
        }

        // Method to export data to a Word document (#5 API - Microsoft Word Interop API) (#6 Error Handling)
        public void ExportToWord(string filePath, List<string> data)
        {
            try
            {
                // Create a new instance of the Word application
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                wordApp.Visible = false; // You can make it true for visual feedback

                // Create a new Word document
                Document wordDoc = wordApp.Documents.Add();

                // Add content from the List<string> data to the Word document
                foreach (var sentence in data)
                {
                    // Add the sentence as a paragraph
                    Paragraph para = wordDoc.Content.Paragraphs.Add();
                    para.Range.Text = sentence; // Set the paragraph text to the current sentence
                    para.Range.InsertParagraphAfter(); // Insert a paragraph break after each sentence
                }

                // Save the document to the specified file path
                wordDoc.SaveAs2(filePath);

                // Close the document and Word application
                wordDoc.Close();
                wordApp.Quit();

                MessageBox.Show("Data successfully exported to Word.");
            }
            catch (COMException comEx)
            {
                // Handle errors related to COM or Word automation
                MessageBox.Show($"COM Error: {comEx.Message}");
            }
            catch (Exception ex)
            {
                // General error handling
                MessageBox.Show($"Error exporting data to Word: {ex.Message}");
            }
        }

    }
}

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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Document = Microsoft.Office.Interop.Word.Document;
using Paragraph = Microsoft.Office.Interop.Word.Paragraph;
using Document2 = iText.Layout.Document;
using Paragraph2 = iText.Layout.Element.Paragraph;
using TextAlignment = iText.Layout.Properties.TextAlignment;

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

        //Method to export data to PDF file
        public void ExportToPdf(List<string> data, string filePath)
        {
            // Create a PdfWriter instance to write to the specified file path
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                // Create a PdfDocument object using the PdfWriter
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    // Create a Document object to add content to the PDF
                    Document2 document = new Document2(pdf);

                    // Add a title to the document (optional)
                    document.Add(new Paragraph2("Exported List of Strings")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(14));

                    // Add each string from the List<string> as a separate paragraph
                    foreach (string item in data)
                    {
                        document.Add(new Paragraph2(item));
                    }
                }
            }
        }

    }
}

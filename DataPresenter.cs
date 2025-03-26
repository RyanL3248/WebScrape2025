using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScrape2025
{
    class DataPresenter
    {
        private TextBox _outputTextBox; // TextBox or RichTextBox to display the data

        // Constructor to initialize the DataPresenter with the output control
        public DataPresenter(TextBox outputTextBox)
        {
            _outputTextBox = outputTextBox;
        }

        // Method to display a list of data in a bulleted format
        public void DisplayDataInBulletedList(List<string> data)
        {
            // Clear previous content
            _outputTextBox.Clear();

            // Check if there is any data
            if (data.Count > 0)
            {
                foreach (var item in data)
                {
                    _outputTextBox.AppendText($"- {item}{Environment.NewLine}"); // Add a bullet point and newline for each data item
                }
            }
            else
            {
                _outputTextBox.AppendText("No data found."); // If no data found, display a message
            }
        }

        // Method to sort the list using QuickSort algorithm 
        public void QuickSort(List<string> data)
        {
            // Call the QuickSort method recursively
            QuickSortHelper(data, 0, data.Count - 1);
        }

        // Helper method for QuickSort 
        private void QuickSortHelper(List<string> data, int low, int high)
        {
            if (low < high)
            {
                // Find the pivot element
                int pivotIndex = Partition(data, low, high);

                // Recursively sort elements before and after partition
                QuickSortHelper(data, low, pivotIndex - 1);
                QuickSortHelper(data, pivotIndex + 1, high);
            }
        }

        // Method to partition the list for QuickSort
        private int Partition(List<string> data, int low, int high)
        {
            // Use the last element as pivot
            string pivot = data[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                // If current element is smaller or equal to pivot
                if (string.Compare(data[j], pivot) <= 0)
                {
                    i++;
                    // Swap data[i] and data[j]
                    string temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
            }

            // Swap the pivot element with the element at i+1
            string temp1 = data[i + 1];
            data[i + 1] = data[high];
            data[high] = temp1;

            return i + 1;
        }

        public void DisplayData(List<string> data)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}

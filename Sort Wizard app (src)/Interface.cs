using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SortingWizard
{
    public partial class Interface : Form
    {
       

        public Interface()
        {
            InitializeComponent();
        }


        //Pesonal Individual Dataset
        private void btnEnterDataset_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter your dataset (Numbers or Names separated by commas, If your Dataset contains both numbers and names, numbers will be sorted first in ascending order, then names in the alphebetical order):",
                "Enter Dataset",
                "");

            
            if (!string.IsNullOrWhiteSpace(input))
            {
                listBoxDataset.Items.Clear();
                string[] items = input.Split(',');
                foreach (var item in items)
                {
                    listBoxDataset.Items.Add(item.Trim());
                }
            }
        }

        //QuickSort button clicked
        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            SortList(QuickSort);
        }
        //BubbleSort button clicked
        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            SortList(BubbleSort);
        }

        // General method to sort the list using a specified sorting method
        private void SortList(Action<List<object>> sortingMethod)
        {
            // Separate numbers and strings
            List<object> items = new List<object>();

            foreach (var item in listBoxDataset.Items)
            {
                if (item != null) // Ensure item is not null
                {
                    items.Add(item);
                }
            }

            sortingMethod(items); // Sort the items

            listBoxDataset.Items.Clear(); // Clear the list box

            // Add sorted items back to the list box
            foreach (var item in items)
            {
                listBoxDataset.Items.Add(item);
            }
        }

        // Bubble Sort method for numbers and strings
        private void BubbleSort(List<object> items)
        {
            for (int j = 0; j < items.Count - 1; j++)
            {
                for (int i = 0; i < items.Count - 1 - j; i++)
                {
                    if (CompareItems(items[i], items[i + 1]) > 0)
                    {
                        // Swap items
                        var temp = items[i];
                        items[i] = items[i + 1];
                        items[i + 1] = temp;
                    }
                }
            }
        }

        // Quick Sort method for numbers and strings
        private void QuickSort(List<object> items)
        {
            QuickSortHelper(items, 0, items.Count - 1);
        }

        private void QuickSortHelper(List<object> items, int left, int right)
        {
            if (left >= right)
                return;

            var pivot = items[(left + right) / 2];
            int index = Partition(items, left, right, pivot);
            QuickSortHelper(items, left, index - 1);
            QuickSortHelper(items, index, right);
        }

        private int Partition(List<object> items, int left, int right, object pivot)
        {
            while (left <= right)
            {
                while (CompareItems(items[left], pivot) < 0)
                    left++;

                while (CompareItems(items[right], pivot) > 0)
                    right--;

                if (left <= right)
                {
                    var temp = items[left];
                    items[left] = items[right];
                    items[right] = temp;
                    left++;
                    right--;
                }
            }
            return left;
        }

        // Comparison method for mixed datasets
        private int CompareItems(object x, object y)
        {
            bool xIsNumber = int.TryParse(x.ToString(), out int xNum);
            bool yIsNumber = int.TryParse(y.ToString(), out int yNum);

            if (xIsNumber && yIsNumber)
            {
                // Compare as integers
                return xNum.CompareTo(yNum);
            }
            else if (xIsNumber)
            {
                // Numbers come before strings
                return -1;
            }
            else if (yIsNumber)
            {
                // Numbers come before strings
                return 1;
            }
            else
            {
                // Compare as strings
                return string.Compare(x.ToString(), y.ToString(), StringComparison.OrdinalIgnoreCase);
            }
        }

        //clear button clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxDataset.Items.Clear();
        }

    }
}




namespace SortingWizard
{
    partial class Interface
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listBoxDataset = new ListBox();
            btnQuickSort = new Button();
            btnBubbleSort = new Button();
            btnEnterDataset = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // listBoxDataset
            // 
            listBoxDataset.FormattingEnabled = true;
            listBoxDataset.ItemHeight = 15;
            listBoxDataset.Location = new Point(13, 12);
            listBoxDataset.Margin = new Padding(4, 3, 4, 3);
            listBoxDataset.Name = "listBoxDataset";
            listBoxDataset.Size = new Size(139, 169);
            listBoxDataset.TabIndex = 0;
            // 
            // btnQuickSort
            // 
            btnQuickSort.Location = new Point(242, 90);
            btnQuickSort.Margin = new Padding(4, 3, 4, 3);
            btnQuickSort.Name = "btnQuickSort";
            btnQuickSort.Size = new Size(88, 27);
            btnQuickSort.TabIndex = 4;
            btnQuickSort.Text = "Quick Sort";
            btnQuickSort.UseVisualStyleBackColor = true;
            btnQuickSort.Click += btnQuickSort_Click;
            // 
            // btnBubbleSort
            // 
            btnBubbleSort.Location = new Point(338, 90);
            btnBubbleSort.Margin = new Padding(4, 3, 4, 3);
            btnBubbleSort.Name = "btnBubbleSort";
            btnBubbleSort.Size = new Size(88, 27);
            btnBubbleSort.TabIndex = 5;
            btnBubbleSort.Text = "Bubble Sort";
            btnBubbleSort.UseVisualStyleBackColor = true;
            btnBubbleSort.Click += btnBubbleSort_Click;
            // 
            // btnEnterDataset
            // 
            btnEnterDataset.Location = new Point(160, 24);
            btnEnterDataset.Margin = new Padding(4, 3, 4, 3);
            btnEnterDataset.Name = "btnEnterDataset";
            btnEnterDataset.Size = new Size(388, 27);
            btnEnterDataset.TabIndex = 6;
            btnEnterDataset.Text = "Enter Your own Dataset";
            btnEnterDataset.UseVisualStyleBackColor = true;
            btnEnterDataset.Click += btnEnterDataset_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(291, 123);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 27);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Interface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 337);
            Controls.Add(btnClear);
            Controls.Add(btnEnterDataset);
            Controls.Add(btnBubbleSort);
            Controls.Add(btnQuickSort);
            Controls.Add(listBoxDataset);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Interface";
            Text = "Sort Wizard App";
            ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox listBoxDataset;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnEnterDataset;
        private System.Windows.Forms.Button btnClear;
    }
}

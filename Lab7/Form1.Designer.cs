namespace Lab7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            cocktailBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)cocktailBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.DataSource = cocktailBindingSource;
            listBox1.DisplayMember = "Name";
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(25, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(174, 349);
            listBox1.TabIndex = 0;
            // 
            // cocktailBindingSource
            // 
            cocktailBindingSource.DataSource = typeof(Models.Cocktail);
            cocktailBindingSource.CurrentChanged += cocktailBindingSource_CurrentChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(205, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(575, 349);
            dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 450);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Lab7";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cocktailBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private BindingSource cocktailBindingSource;
        private DataGridView dataGridView1;
    }
}

using System.Diagnostics.Metrics;

namespace System_5
{
    public partial class Form1 : Form
    {
        Thread? thread;
        Semaphore? semaphore = null;
        List<Thread> threads = new List<Thread>();
        bool flag = true;
        public Form1()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.Columns.Add("Name of Threads  ");
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.MultiSelect = false;
            listView2.View = View.Details;
            listView2.Columns.Add("Name of Threads  ");
            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.MultiSelect = false;
            listView3.View = View.Details;
            listView3.Columns.Add("Name of Threads  ");
            listView3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView3.MultiSelect = false;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if(flag)
            {
                numericUpDown1.Enabled = false;
                semaphore = new Semaphore((int)numericUpDown1.Value, (int)numericUpDown1.Value);
                flag = false;
            }

            thread = new Thread(() => Simulation());
            thread.Name = thread.ManagedThreadId.ToString();
            threads.Add(thread);

            listView3.Items.Add($"Thread : " + thread.Name);
        }

        private void Simulation()
        {
            if (numericUpDown1.Value > 0)
            {
                bool st = false;
                while (!st)
                {
                    if (semaphore!.WaitOne())
                    {
                        try
                        {
                            Thread.Sleep(3000);
                            var t = Thread.CurrentThread;
                            Invoke(() =>
                            {
                                foreach (ListViewItem item in listView2.Items)
                                {
                                    string i = item.Text.Split(" ")[2];
                                    if (i == t.Name)
                                        listView2.Items.Remove(item);
                                }
                            });
                            Invoke(() => listView1.Items.Add($"Thread : " + t.Name));
                        }
                        finally
                        {
                            st = true;
                            var t = Thread.CurrentThread;

                            Thread.Sleep(2000);

                            Invoke(() =>
                            {
                                foreach (ListViewItem item in listView1.Items)
                                {
                                    string i = item.Text.Split(" ")[2];
                                    if (i == t.Name)
                                        listView1.Items.Remove(item);
                                }
                            });

                            threads.Remove(t);
                            if (threads.Count == 0)
                            {
                                flag = true;
                                Invoke(() =>
                                {
                                    numericUpDown1.Enabled = true;
                                    button1.Enabled = false;
                                });
                            }

                            semaphore.Release();
                        }
                    }
                }
            }
            else
                MessageBox.Show("You don't choice count");
        }

        private void CreatedListbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                bool flag = false;
                foreach (var selectedItem in listView3.SelectedItems)
                {
                    string s = selectedItem.ToString()!.Split(" ")[3];
                    foreach (var thread in threads)
                    {
                        if (thread.Name == s.Remove(s.Length - 1, 1))
                        {
                            thread?.Start();
                            flag = true;
                            break;
                        }
                    }

                    if (flag)
                    {
                        listView3.Items.Remove((ListViewItem)selectedItem);
                        listView2.Items.Add((ListViewItem)selectedItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
    }
}
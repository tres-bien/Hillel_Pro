using System.Drawing;
using System.Drawing.Configuration;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Homework_5
{
    public partial class fWordSearcher : Form
    {
        private static object mock = new();

        public fWordSearcher()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text.Contains(tWordSearch.Text))
            {
                int index = -1;
                int selectStart = this.richTextBox1.SelectionStart;

                while ((index = this.richTextBox1.Text.IndexOf(tWordSearch.Text, (index + 1))) != -1)
                {
                    this.richTextBox1.Select((index), tWordSearch.Text.Length);
                    this.richTextBox1.SelectionBackColor = Color.Tan;
                    this.richTextBox1.Select(selectStart, 0);
                    this.richTextBox1.SelectionBackColor = Color.Black;
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var tokenSource = new CancellationTokenSource();

            var task1 = Task.Run(() => Read(10, Color.Aqua, tokenSource.Token));
            var task2 = Task.Run(() => Read(1000, Color.Yellow, tokenSource.Token));
            var task3 = Task.Run(() => Read(5000, Color.Green, tokenSource.Token));

            await Task.WhenAny(task1, task2, task3);
            tokenSource.Cancel();

            this.Invoke(new Action(() => richTextBox1.SelectionColor = Color.Red));
            this.Invoke(new Action(() => richTextBox1.AppendText("\nFinished")));
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private List<string> GetPaths()
        {
            List<string> paths = Directory.EnumerateFiles(@"G:\myFolder\Hillel_Pro\Homework_5\Text", "*.txt", SearchOption.AllDirectories).ToList();
            return paths;
        }

        public async Task Read(int delay, Color color, CancellationToken token)
        {
            string text = string.Empty;
            foreach (string path in GetPaths())
            {
                var readStream = new StreamReader(File.OpenRead(path));

                while (!readStream.EndOfStream)
                {
                    Write(await readStream.ReadLineAsync(), color);
                }

                if (token.IsCancellationRequested) return;
                await Task.Delay(delay, token);
            }
        }

        public async Task Write(string text, Color color, string searchWord = null)
        {
            lock (mock)
            {
                this.Invoke(new Action(() => richTextBox1.BackColor = Color.Black));
                this.Invoke(new Action(() => richTextBox1.SelectionColor = color));
                this.Invoke(new Action(() => richTextBox1.AppendText(text + "\n")));
            }
        }
    }
}
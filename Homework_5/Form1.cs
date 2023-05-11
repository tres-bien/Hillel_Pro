using System.Drawing.Configuration;

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

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var task1 = Task.Run(() => Read(1000, Color.Aqua));
            var task2 = Task.Run(() => Read(100, Color.Yellow));
            var task3 = Task.Run(() => Read(500, Color.Green));
        }

        private List<string> GetPaths()
        {
            List<string> paths = Directory.EnumerateFiles(@"G:\myFolder\Hillel_Pro\Homework_5\Text", "*.txt", SearchOption.AllDirectories).ToList();
            return paths;
        }

        public async Task Read(int delay, Color color)
        {
            string text = string.Empty;
            foreach (string path in GetPaths())
            {
                var readStream = new StreamReader(File.OpenRead(path));
                while (!readStream.EndOfStream)
                {
                    //text = await readStream.ReadLineAsync();
                    Write(await readStream.ReadLineAsync(), color);
                }
                await Task.Delay(delay);
            }
        }

        public async void Write(string text, Color color)
        {
            lock (mock)
            {
                this.Invoke(new Action(() => tDisplayText.BackColor = Color.Black));
                tDisplayText.ForeColor = color;
                this.Invoke(new Action(() => tDisplayText.Text += text));
                //tDisplayText.ForeColor = Color.Empty;
            }
        }
    }
}
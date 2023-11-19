using System.ComponentModel;

namespace bfs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void bfs(Wezel w)
        {
            List<Wezel> visited = new List<Wezel>();
            Queue<Wezel> queue = new Queue<Wezel>();

            visited.Add(w);
            queue.Enqueue(w);

            while (queue.Count > 0)
            {
                var s = queue.Dequeue();
                MessageBox.Show(s.ToString());

                foreach(var x in s.childs)
                {
                    if (!visited.Contains(x))
                    {
                        visited.Add(x);
                        queue.Enqueue(x);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_bfs_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel(5);
            var w2 = new Wezel(3);
            var w3 = new Wezel(1);
            var w4 = new Wezel(2);
            var w5 = new Wezel(4);
            var w6 = new Wezel(8);
            var w7 = new Wezel(9);

            w1.childs.Add(w2);
            w1.childs.Add(w3);
            w1.childs.Add(w7);
            w2.childs.Add(w4);
            w2.childs.Add(w5);
            w3.childs.Add(w6);
            w6.childs.Add(w4);

            bfs(w1);
        }
    }
    public class Wezel
    {
        public int value;
        public List<Wezel> childs = new List<Wezel>();
        public Wezel(int number)
        {
            this.value = number;
        }
        public override string ToString()
        {
            return "Wartoœæ " + this.value.ToString();
        }
    }
}
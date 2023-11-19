namespace wezly
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void A(Wezel w)
        {
            MessageBox.Show(w.ToString());
            foreach (var child in w.childs)
            {
                A(child);
            }
        }

        List<Wezel2> visited = new List<Wezel2>();
        void A(Wezel2 w)
        {
            MessageBox.Show(w.ToString());
            visited.Add(w);
            foreach (var somsiad in w.sasiedzi)
            {
                if(!visited.Contains(somsiad))
                {
                    A(somsiad);
                }
            }
        }

        private void btn_make_node_Click(object sender, EventArgs e)
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

            A(w1);
        }

        private void btn2_wezel2_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel2(1);
            var w2 = new Wezel2(2);
            var w3 = new Wezel2(3);
            var w4 = new Wezel2(4);
            var w5 = new Wezel2(5);

            w1.Add(w2);
            w1.Add(w3);
            w2.Add(w4);
            w4.Add(w3);
            w4.Add(w5);

            A(w1);
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

    public class Wezel2
    {
        public int value;
        public List<Wezel2> sasiedzi = new List<Wezel2>();
        public Wezel2(int number)
        {
            this.value = number;
        }
        public override string ToString()
        {
            return this.value.ToString();
        }

        public void Add(Wezel2 w) { 
            this.sasiedzi.Add(w);
            w.sasiedzi.Add(this);
        }
    }
}
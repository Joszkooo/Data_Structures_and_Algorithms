using System.Collections.Concurrent;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Sortowania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            label1_czas.Enabled = false;
            label2_time.Enabled = false;
            btn6_generuj.Enabled = false;
            nup1_jaki_zakres.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //ma w³¹czyæ b¹dŸ wy³¹czyæ praw¹ stronê i tak samo z lew¹
            if (this.Choose_side.Checked)
            {
                txt_box1_liczby.Enabled = false;
                txt_box2_wynik.Enabled = false;
                label1_czas.Enabled = true;
                label2_time.Enabled = true;
                btn6_generuj.Enabled = true;
                nup1_jaki_zakres.Enabled = true;
            }
            else
            {
                txt_box1_liczby.Enabled = true;
                txt_box2_wynik.Enabled = true;
                label1_czas.Enabled = false;
                label2_time.Enabled = false;
                btn6_generuj.Enabled = false;
                nup1_jaki_zakres.Enabled = false;
            }

        }

        int[] array()
        {
            if (Choose_side.Checked)
            {
                return btn6_generuj.
            }
            else
            {
                string[] temp = txt_box1_liczby.Text.Split(new char[] { ' ' });
                int[] arr = Array.ConvertAll(temp, int.Parse);
                return arr;
            }
        }

        private void txt_box1_liczby_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_box2_wynik_TextChanged(object sender, EventArgs e)
        {

        }

        private void nup1_jaki_zakres_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_czas_Click(object sender, EventArgs e)
        {

        }

        private void label2_time_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btn1_bubble_Click(object sender, EventArgs e)
        {
            //czas start
            var watch = Stopwatch.StartNew();

            int[] arr = array();
            int len = arr.Length;
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            string solution = "";
            for (int i = 0; i < len; i++)
            {
                solution += arr[i].ToString();
            
            }
            //czas stop
            watch.Stop();

            //MessageBox.Show(solution);
            if (Choose_side.Checked)
            {
                //wypisz ile sek
                label1_czas.Text = watch.ElapsedMilliseconds.ToString();
            }
            else
            {
                txt_box2_wynik.Text = solution;
            }
        }

        private void btn2_select_Click(object sender, EventArgs e)
        {

        }

        private void btn3_insert_Click(object sender, EventArgs e)
        {

        }

        private void btn4_merge_Click(object sender, EventArgs e)
        {

        }
        //int partition(int[] arr, int low, int high)
        //{
        //    int pivolt = arr[low];
        //    int leftwall = low;

        //    for(int i=0; )
        //}

        //int[] quickSort(int[] arr, int low, int high)
        //{
        //    if(low < high)
        //    {
        //        int pivot_location = partition(arr, low, high);
        //        quickSort(arr, low, pivot_location);
        //        quickSort(arr, pivot_location + 1, high);
        //    }
        //}

        private void btn5_quick_Click(object sender, EventArgs e)
        {
            
        }

        private void btn6_generuj_Click(object sender, EventArgs e)
        {
            int[] random_arr = new int[Decimal.ToUInt16(nup1_jaki_zakres.Value)];
            Random randNum = new Random();
            for(int i = 0; i < random_arr.Length; i++)
            {
                random_arr[i] = randNum.Next(0, 1000);
            }
        }
    }
}
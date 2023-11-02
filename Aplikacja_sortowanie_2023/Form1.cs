using System.Drawing;
using System;
using System.Windows.Forms;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Diagnostics;
using System.Security.Cryptography;

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

        public int[] tab()
        {
            string[] temp = txt_box1_liczby.Text.Split(new char[] { });
            int[] myint = Array.ConvertAll(temp, int.Parse);
            return myint;
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
            Stopwatch timer = new Stopwatch();
            if (Choose_side.Checked)
            {
                if (random_arr.Length == 0) MessageBox.Show("ERROR!");
                else
                {
                    timer.Start();
                    int[] arr = random_arr;
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
                    timer.Stop();
                    label2_time.Text = timer.Elapsed.ToString();
                }
            }
            else
            {
                int[] arr = tab();
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
                string result = "";
                for (int i = 0; i < len; i++) result += arr[i].ToString() + " ";
                txt_box2_wynik.Text = result;
            }
        }

        private void btn2_select_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            if (Choose_side.Checked)
            {
                if (random_arr.Length == 0) MessageBox.Show("ERROR!");
                else
                {
                    timer.Start();
                    int[] arr = random_arr;
                    int len = arr.Length;
                    for (int i = 0; i < len - 1; i++)
                    {
                        int index_min = i;
                        for (int j = i + 1; j < len; j++)
                        {
                            if (arr[j] < arr[index_min]) index_min = j;
                        }
                        if (index_min != i)
                        {
                            int temp = arr[i];
                            arr[i] = arr[index_min];
                            arr[index_min] = temp;
                        }
                    }
                    timer.Stop();
                    label2_time.Text = timer.Elapsed.ToString();
                }
            }
            else
            {
                int[] arr = tab();
                int len = arr.Length;
                for (int i = 0; i < len - 1; i++)
                {
                    int index_min = i;
                    for (int j = i + 1; j < len; j++)
                    {
                        if (arr[j] < arr[index_min]) index_min = j;
                    }
                    if (index_min != i)
                    {
                        int temp = arr[i];
                        arr[i] = arr[index_min];
                        arr[index_min] = temp;
                    }
                }
                string result = "";
                for (int i = 0; i < len; i++) result += arr[i].ToString() + " ";
                txt_box2_wynik.Text = result;
            }
        }

        private void btn3_insert_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            if (Choose_side.Checked)
            {
                if (random_arr.Length == 0) MessageBox.Show("ERROR!");
                else
                {
                    timer.Start();
                    int[] arr = random_arr;
                    int len = arr.Length;
                    for (int i = 1; i < len; i++)
                    {
                        int j = i;
                        while (j > 0 && arr[j - 1] > arr[j])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j - 1];
                            arr[j - 1] = temp;
                            j--;
                        }
                    }
                    timer.Stop();
                    label2_time.Text = timer.Elapsed.ToString();
                }
            }
            else
            {
                int[] arr = tab();
                int len = arr.Length;
                for (int i = 1; i < len; i++)
                {
                    int j = i;
                    while (j > 0 && arr[j - 1] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                        j--;
                    }
                }
                string result = "";
                for (int i = 0; i < len; i++) result += arr[i].ToString() + " ";
                txt_box2_wynik.Text = result;
            }
        }

        void mergeSort(int[] arr)
        {
            int len = arr.Length;
            if (len == 1) return;

            int midpoint = len / 2;

            int[] left = new int[midpoint];
            int[] right = new int[len - midpoint];

            Array.Copy(arr, 0, left, 0, midpoint);
            Array.Copy(arr, midpoint, right, 0, len - midpoint);

            mergeSort(left);
            mergeSort(right);
            merge(arr, left, right);
        }

        void merge(int[] arr, int[] left, int[] right)
        {

            int i = 0, j = 0, k = 0;
            int leftLength = left.Length;
            int rightLength = right.Length;

            while (i < leftLength && j < rightLength)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < leftLength)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            while (j < rightLength)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }

        private void btn4_merge_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            if (Choose_side.Checked)
            {
                if (random_arr.Length == 0) MessageBox.Show("ERROR!");
                else
                {
                    timer.Start();
                    int[] arr = random_arr;

                    mergeSort(arr);

                    timer.Stop();
                    label2_time.Text = timer.Elapsed.ToString();
                }
            }
            else
            {
                int[] arr = tab();
                int len = arr.Length;

                mergeSort(arr);

                string result = "";
                for (int i = 0; i < len; i++) result += arr[i].ToString() + " ";
                txt_box2_wynik.Text = result;
            }
        }

        void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivot_location = partition(arr, low, high);
                quickSort(arr, low, pivot_location - 1);
                quickSort(arr, pivot_location + 1, high);
            }
        }

        int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int leftWall = low;

            for (int i = low; i < high; i++)
            {
                if (arr[i] <= pivot)
                {
                    int temp1 = arr[i];
                    arr[i] = arr[leftWall];
                    arr[leftWall] = temp1;
                    leftWall++;
                }
            }
            int temp2 = arr[leftWall];
            arr[leftWall] = arr[high];
            arr[high] = temp2;

            return leftWall;
        }

        private void btn5_quick_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            if (Choose_side.Checked)
            {
                if (random_arr.Length == 0) MessageBox.Show("ERROR!");
                else
                {
                    timer.Start();
                    int[] arr = random_arr;

                    quickSort(arr, 0, arr.Length - 1);

                    timer.Stop();
                    label2_time.Text = timer.Elapsed.ToString();
                }
            }
            else
            {
                int[] arr = tab();
                int len = arr.Length;

                quickSort(arr, 0, arr.Length - 1);

                string result = "";
                for (int i = 0; i < len; i++) result += arr[i].ToString() + " ";
                txt_box2_wynik.Text = result;
            }
        }
        int[] random_arr;
        private void btn6_generuj_Click(object sender, EventArgs e)
        {
            random_arr = new int[Decimal.ToUInt32(nup1_jaki_zakres.Value) + 1];
            Random randNum = new Random();
            for (int i = 0; i < random_arr.Length; i++)
            {
                random_arr[i] = randNum.Next(0, 1000);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false; //GroupBox ı form1 açılınca görünmez yapar
        }
        int kaldır;  // global olarak değişkenler tanımladım 

        int deger = 0;
        int deger2 = 0;
        int deger3 = 0;
        int deger4 = 0;// global olarak değişkenler tanımladım 
        int deger5 = 0;
        int deger6 = 0;
        int tutar = 0;

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (listBox1.Items.Contains(textBox2.Text))//texbox2 içindeki değer listbox1 inin içinde varsa bu ifin içine girer
            {
                kaldır = listBox1.Items.IndexOf(textBox2.Text);//listbox1 in içinde DVD nin ilk olduğu yeri bulup kaldır değişkenine atarım

                listBox1.Items.RemoveAt(kaldır);//listbox1 den kaldırın içindeki değeri kaldırırım
                listBox2.Items.RemoveAt(kaldır);//listbox2 den kaldırın içindeki değeri kaldırırım
                listBox3.Items.RemoveAt(kaldır);//listbox3 den kaldırın içindeki değeri kaldırırım
                deger2++;//global olarak tanımladığım değeri butona tıklandığı zaman 1 arttırdım
                tutar = (deger2 * Convert.ToInt32(textBox7.Text));//global olarak tanımladığım tutar değişkenine deger2 nin içindeki değer ve textbox7 nin içindeki değeri çarptırdım
                listBox1.Items.Add(textBox2.Text);//listbox1 in içine textbox2 nin içindeki değeri atadım
                listBox3.Items.Add(tutar);//listbox3 ün içine tutar değişkeninin içindeki değeri atadım
                listBox2.Items.Add(deger2);//lisbox2 nin içine deger2 nin içindeki değeri yazdırıyorum
               
                deger += Convert.ToInt32(textBox7.Text);//global olarak tanımladığım deger değişkeninin içine += ile textbox7 nin içindeki değeri atıyorum
                textBox13.Text = deger.ToString(); // deger in içindeki değeri   textbox13 ün içine atıyorum   

            }
            else //yoksa
            {
                listBox1.Items.Add(textBox2.Text);//listbox1 in içine textbox2 nin içindeki değeri atadım
                listBox3.Items.Add(textBox7.Text);//listbox3 ün içine textbox7 nin içindeki değeri atadım
                deger2++;//global olarak tanımladığım değeri 1 arttırdım
                listBox2.Items.Add(deger2);//listbox2 in içine deger2  nin içindeki değeri atadım
                deger += Convert.ToInt32(textBox7.Text);//global olarak tanımladığım deger değişkeninin içine += ile textbox7 nin içindeki değeri atıyorum
                textBox13.Text = deger.ToString();// deger in içindeki değeri   textbox13 ün içine atıyorum   
            }

            
        }
       
        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Contains(textBox3.Text))//texbox3 içindeki değer listbox1 inin içinde varsa bu ifin içine girer
            {
                kaldır = listBox1.Items.IndexOf(textBox3.Text);//listbox1 in içinde CD nin ilk olduğu yeri bulup kaldır değişkenine atarım

                listBox1.Items.RemoveAt(kaldır);//listbox1 den kaldırın içindeki değeri kaldırırım
                listBox2.Items.RemoveAt(kaldır);//listbox2 den kaldırın içindeki değeri kaldırırım
                listBox3.Items.RemoveAt(kaldır);//listbox3 den kaldırın içindeki değeri kaldırırım
                deger3++;//global olarak tanımladığım değeri butona tıklandığı zaman 1 arttırdım
                tutar = (deger3 * Convert.ToInt32(textBox8.Text));//global olarak tanımladığım tutar değişkenine deger3 ün içindeki değer ve textbox8 in içindeki değeri çarptırdım
                listBox1.Items.Add(textBox3.Text);//listbox1 in içine textbox3 ün içindeki değeri atadım
                listBox3.Items.Add(tutar);//listbox3 ün içine tutar değişkeninin içindeki değeri atadım
                listBox2.Items.Add(deger3);//lisbox2 nin içine deger3 ün içindeki değeri yazdırıyorum
                deger += Convert.ToInt32(textBox8.Text);//global olarak tanımladığım deger değişkeninin içine += ile textbox8 in içindeki değeri atıyorum
                textBox13.Text = deger.ToString();// deger in içindeki değeri   textbox13 ün içine atıyorum  
            }
            else//yoksa
            {
                listBox1.Items.Add(textBox3.Text);//listbox1 in içine textbox3 ün içindeki değeri atadım
                listBox3.Items.Add(textBox8.Text);//listbox3 ün içine textbox8 in içindeki değeri atadım
                deger3++;//global olarak tanımladığım değeri 1 arttırdım
                listBox2.Items.Add(deger3);//listbox2 in içine deger3  ün içindeki değeri atadım
                deger += Convert.ToInt32(textBox8.Text);//global olarak tanımladığım deger değişkeninin içine += ile textbox8 in içindeki değeri atıyorum
                textBox13.Text = deger.ToString();// deger in içindeki değeri   textbox13 ün içine atıyorum  
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(textBox4.Text))//texbox4 içindeki değer listbox1 inin içinde varsa bu ifin içine girer
            {
                kaldır = listBox1.Items.IndexOf(textBox4.Text);//listbox1 in içinde Kağıt ın ilk olduğu yeri bulup kaldır değişkenine atarım

                listBox1.Items.RemoveAt(kaldır);//listbox1 den kaldırın içindeki değeri kaldırırım
                listBox2.Items.RemoveAt(kaldır);//listbox2 den kaldırın içindeki değeri kaldırırım
                listBox3.Items.RemoveAt(kaldır);//listbox3 den kaldırın içindeki değeri kaldırırım
                deger4++;//global olarak tanımladığım değeri butona tıklandığı zaman 1 arttırdım
                tutar = (deger4 * Convert.ToInt32(textBox9.Text));//global olarak tanımladığım tutar değişkenine deger4 ün içindeki değer ve textbox9 in içindeki değeri çarptırdım
                listBox1.Items.Add(textBox4.Text);//listbox1 in içine textbox4 ün içindeki değeri atadım
                listBox3.Items.Add(tutar);//listbox3 ün içine tutar değişkeninin içindeki değeri atadım
                listBox2.Items.Add(deger4);//lisbox2 nin içine deger4 ün içindeki değeri yazdırıyorum
                deger += Convert.ToInt32(textBox9.Text);//global olarak tanımladığım deger değişkeninin içine += ile textbox9 un içindeki değeri atıyorum
                textBox13.Text = deger.ToString();// deger in içindeki değeri   textbox13 ün içine atıyorum  
            }
            else//yoksa
            {
                listBox1.Items.Add(textBox4.Text);//listbox1 in içine textbox4 ün içindeki değeri atadım
                listBox3.Items.Add(textBox9.Text);//listbox3 ün içine textbox9 un içindeki değeri atadım
                deger4++;//global olarak tanımladığım değeri 1 arttırdım
                listBox2.Items.Add(deger4);//listbox2 in içine deger4  ün içindeki değeri atadım
                deger += Convert.ToInt32(textBox9.Text);//global olarak tanımladığım deger değişkeninin içine += ile textbox9 un içindeki değeri atıyorum
                textBox13.Text = deger.ToString();// deger in içindeki değeri   textbox13 ün içine atıyorum

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Contains(textBox5.Text))//texbox5 içindeki değer listbox1 inin içinde varsa bu ifin içine girer
            {
                kaldır = listBox1.Items.IndexOf(textBox5.Text);//listbox1 in içinde Kasa nın ilk olduğu yeri bulup kaldır değişkenine atarım
                listBox1.Items.RemoveAt(kaldır);//listbox1 den kaldırın içindeki değeri kaldırırım
                listBox2.Items.RemoveAt(kaldır);//listbox2 den kaldırın içindeki değeri kaldırırım
                listBox3.Items.RemoveAt(kaldır);//listbox3 den kaldırın içindeki değeri kaldırırım
                deger5++;//global olarak tanımladığım değeri butona tıklandığı zaman 1 arttırdım
                tutar = (deger5 * Convert.ToInt32(textBox10.Text));//global olarak tanımladığım tutar değişkenine deger5 in içindeki değer ve textbox10 in içindeki değeri çarptırdım
                listBox1.Items.Add(textBox5.Text);//listbox1 in içine textbox5 ün içindeki değeri atadım
                listBox3.Items.Add(tutar);//listbox3 ün içine tutar değişkeninin içindeki değeri atadım
                listBox2.Items.Add(deger5);//lisbox2 nin içine deger5 ün içindeki değeri yazdırıyorum
                deger += Convert.ToInt32(textBox10.Text);//global olarak tanımladığım deger değişkeninin içine += ile textbox10 un içindeki değeri atıyorum
                textBox13.Text = deger.ToString();// deger in içindeki değeri   textbox13 ün içine atıyorum
            }
            else//yoksa
            {
                listBox1.Items.Add(textBox5.Text);//listbox1 in içine textbox5 ün içindeki değeri atadım
                listBox3.Items.Add(textBox10.Text);//listbox3 ün içine textbox10 un içindeki değeri atadım
                deger5++;//global olarak tanımladığım değeri 1 arttırdım
                listBox2.Items.Add(deger5);//listbox2 in içine deger5  ün içindeki değeri atadım
                deger += Convert.ToInt32(textBox10.Text);//global olarak tanımladığım deger değişkeninin içine += ile textbox10 un içindeki değeri atıyorum
                textBox13.Text = deger.ToString();// deger in içindeki değeri   textbox13 ün içine atıyorum

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {


            if (listBox1.Items.Contains(textBox6.Text))//texbox6 içindeki değer listbox1 inin içinde varsa bu ifin içine girer
            {
                kaldır = listBox1.Items.IndexOf(textBox6.Text);//listbox1 in içinde Bilgisayar ın ilk olduğu yeri bulup kaldır değişkenine atarım
                listBox1.Items.RemoveAt(kaldır);//listbox1 den kaldırın içindeki değeri kaldırırım
                listBox2.Items.RemoveAt(kaldır);//listbox2 den kaldırın içindeki değeri kaldırırım
                listBox3.Items.RemoveAt(kaldır);//listbox3 den kaldırın içindeki değeri kaldırırım
                deger6++;//global olarak tanımladığım değeri butona tıklandığı zaman 1 arttırdım
                tutar = (deger6 * Convert.ToInt32(textBox11.Text));//global olarak tanımladığım tutar değişkenine deger6 in içindeki değer ve textbox11 in içindeki değeri çarptırdım
                listBox1.Items.Add(textBox6.Text);//listbox1 in içine textbox6 nın içindeki değeri atadım
                listBox3.Items.Add(tutar);//listbox3 ün içine tutar değişkeninin içindeki değeri atadım
                listBox2.Items.Add(deger6);//lisbox2 nin içine deger6 nın içindeki değeri yazdırıyorum
                deger += Convert.ToInt32(textBox11.Text);//global olarak tanımladığım deger değişkeninin içine += ile textbox11 un içindeki değeri atıyorum
                textBox13.Text = deger.ToString();// deger in içindeki değeri   textbox13 ün içine atıyorum
            }
            else//yoksa
            {
                listBox1.Items.Add(textBox6.Text);//listbox1 in içine textbox6 nın içindeki değeri atadım
                listBox3.Items.Add(textBox11.Text);//listbox3 ün içine textbox11 un içindeki değeri atadım
                deger6++;//global olarak tanımladığım değeri 1 arttırdım
                listBox2.Items.Add(deger6);//listbox2 in içine deger6  ün içindeki değeri atadım
                deger += Convert.ToInt32(textBox11.Text);//global olarak tanımladığım deger değişkeninin içine += ile textbox11 un içindeki değeri atıyorum
                textBox13.Text = deger.ToString();// deger in içindeki değeri   textbox13 ün içine atıyorum

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;//para yükle butonuna basılınca gizlediğimiz groupbox açılır
        }

        private void button7_Click(object sender, EventArgs e)
        {

            
            textBox12.Text += textBox1.Text;//textbox12 ye textbox1 de girilen değeri üstüne ekliyor
            textBox14.Text += textBox1.Text;//textbox14 de textbox1 de girilen değeri üstüne ekliyor
            deger += Convert.ToInt32(textBox1.Text);//glbal olarak tanımladığımız deger değişkenine textbox1 içindeki  += ile atadım
            textBox14.Text = deger.ToString();//deger içindeki değeritextbox14 de attım
            textBox12.Text = deger.ToString();//deger içindeki değeri textbox12 içine attım
            groupBox1.Visible = false;//yükle butonuna basıldığı zaman groupbox tekrar gizleniyor
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();// ürün sil butonuna basıldığı zaman listbxoların içindeki değerler ,toplam tutarı tutan textbox ve tanımaladığım temizle fonskiyonun içindeki değerler silinir 
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            textBox13.Clear();
            textBox13.Text = "0";//textbox13 içini 0 yapıyorum
            temizle();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (listBox1.Items.Count > 0)// listbox1 içindeki değer 0 dan küçükse ifin içine girer
            {
                int sayi1 = Convert.ToInt32(textBox13.Text);//textbox13 ün içindeki değeri sayi1 değişkenine atıyorum
                int sayi2 = Convert.ToInt32(textBox12.Text);//textbox12 in içindeki değeri sayi2 değişkenine atıyorum
                if (sayi1 > sayi2)//sayi1 sayi2 den büyükse
                {
                    MessageBox.Show("bakiye yetersiz");//bakiye yetersiz mesajı verecek
                }
                else//değilse
                {
                    textBox13.Text = "0";//textbox13 içini 0 yapıcak
                    temizle();//tanımaladığım temizle fonskiyonun içindeki değerler silinir
                    int sonuc = sayi2 - sayi1;//sonuc diye tanımladığım değişkenin içine sayi2 den sayi1 i çıkarıp kalan değeri atadım
                    textBox12.Text = sonuc.ToString();//textbox12 ye ve textbox14 de sonucu atadım
                    textBox14.Text = sonuc.ToString();
                    MessageBox.Show("Alışveriş başarıyla gerçekleşti.Kalan Bakiye" + sonuc);//messagebox ile alışveriş başarıyla gerçekleşti ve kalan bakiyeyi yanına ekleyerek mesaj verdim
                    listBox1.Items.Clear();//listboxlar ve textbox13 içindeki değerleri sildim
                    listBox2.Items.Clear();
                    listBox3.Items.Clear();
                    textBox13.Clear();


                }
            }
            else //değilse
                MessageBox.Show("Lütfen  ürün ekleyiniz");//mesaj olarak ürün ekleyin dedim

            
        }
        public void temizle()//temzile adında donksiyon tanımladım deger değişkenlerinin içini 0 yapıyor
        {
            deger = 0;
            deger2 = 0;
            deger3 = 0;
            deger4 = 0;
            deger5 = 0;
            deger6 = 0;
        }
    }
}

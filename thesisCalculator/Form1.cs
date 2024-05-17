using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kalkulator_Prac_Dyplmowych
{
    public partial class Form1 : Form
    {
        private int bwPages = 0;
        private int colorPages = 0;

        private int copies = 1;
        private int pages = 0;

        private int bwPages2 = 0;
        private int colorPages2 = 0;

        private int copies2 = 0;
        private int pages2 = 0;

        private double cddvdPrice = 0;
        private int cddvdCopies = 0;
        private double stickerCddvdPrice = 0;

        double[,] priceTableBw = new double[,] {
            {1, 10, 1.25},
            {11, 50, 0.8},
            {51, 100, 0.4},
            {101, 250, 0.3},
            {251, 500, 0.25},
            {501, int.MaxValue, 0.24} 
        };

        double[,] priceTableC = new double[,] {
            {1, 10, 4.50},
            {11, 50, 2.85},
            {51, 100, 2.75},
            {101, 250, 2.25},
            {251, 500, 1.55},
            {501, 1000, 1.50 },
            {1001,int.MaxValue, 0.95}
        };

        List<(string, double)>
            plytyPrices = new List<(string, double)>
            {
                ("CD", 9.50),
                ("DVD", 14.00),
                ("Bez płyty", 0.00)
            };

        List<CoverPrice> coverPrices = new List<CoverPrice>();

        public Form1()
        {
            InitializeComponent();
            Form1_Load(this, EventArgs.Empty);

            AddCoverPrices();
        }

        private void AddCoverPrices()
        {
            coverPrices.Add(new CoverPrice("Oprawa Twarda", 1, 95, 17.50));
            coverPrices.Add(new CoverPrice("Oprawa Twarda", 96, 125, 20.00));
            coverPrices.Add(new CoverPrice("Oprawa Twarda", 126, 150, 25.00));
            coverPrices.Add(new CoverPrice("Oprawa Twarda", 151, 300, 30.00));

            coverPrices.Add(new CoverPrice("Oprawa Miękka klejona", 1, 95, 10.00));
            coverPrices.Add(new CoverPrice("Oprawa Miękka klejona", 96, 125, 12.50));
            coverPrices.Add(new CoverPrice("Oprawa Miękka klejona", 126, 150, 15.00));
            coverPrices.Add(new CoverPrice("Oprawa Miękka klejona", 151, 300, 25.00));

            coverPrices.Add(new CoverPrice("Oprawa Miękka klejona okładka uczelni", 1, 95, 20.00));
            coverPrices.Add(new CoverPrice("Oprawa Miękka klejona okładka uczelni", 96, 125, 25.00));
            coverPrices.Add(new CoverPrice("Oprawa Miękka klejona okładka uczelni", 126, 150, 25.00));
            coverPrices.Add(new CoverPrice("Oprawa Miękka klejona okładka uczelni", 151, 300, 30.00));

            coverPrices.Add(new CoverPrice("Oprawa Miękka grzbiet plastikowy", 1, 95, 8.00));
            coverPrices.Add(new CoverPrice("Oprawa Miękka grzbiet plastikowy", 96, 125, 9.00));
            coverPrices.Add(new CoverPrice("Oprawa Miękka grzbiet plastikowy", 126, 150, 12.00));
            coverPrices.Add(new CoverPrice("Oprawa Miękka grzbiet plastikowy", 151, 300, 15.00));

            coverPrices.Add(new CoverPrice("Oprawa Miękka grzbiet metalowy", 1, 95, 9.00));
            coverPrices.Add(new CoverPrice("Oprawa Miękka grzbiet metalowy", 96, 125, 10.00));
            coverPrices.Add(new CoverPrice("Oprawa Miękka grzbiet metalowy", 126, 150, 14.00));
            coverPrices.Add(new CoverPrice("Oprawa Miękka grzbiet metalowy", 151, 300, 20.00));

            coverPrices.Add(new CoverPrice("Oprawa Miękka listwa wsuwana ", 1, 95, 10.00));
            coverPrices.Add(new CoverPrice("Oprawa Miękka listwa wsuwana ", 96, 125, 12.50));
            coverPrices.Add(new CoverPrice("Oprawa Miękka listwa wsuwana ", 126, 150, 15.00));
            coverPrices.Add(new CoverPrice("Oprawa Miękka listwa wsuwana ", 151, 300, 25.00));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            comboBox2_bothSided.Items.Add("Tak");
            comboBox2_bothSided.Items.Add("Nie");

           
            comboBox1.Items.Add("Tak");
            comboBox1.Items.Add("Nie");

          
            comboBox1.SelectedIndex = 0;

            
            comboBox2_bothSided.SelectedIndex = 0;

            comboBox1_cover.Items.Add("Oprawa Twarda");
            comboBox1_cover.Items.Add("Oprawa Miękka klejona");
            comboBox1_cover.Items.Add("Oprawa Miękka klejona okładka uczelni");
            comboBox1_cover.Items.Add("Oprawa Miękka grzbiet plastikowy");
            comboBox1_cover.Items.Add("Oprawa Miękka grzbiet metalowy");
            comboBox1_cover.Items.Add("Oprawa Miękka listwa wsuwana ");


            comboBox1_cover.SelectedIndex = 0;

            comboBox2.Items.Add("Oprawa Twarda");
            comboBox2.Items.Add("Oprawa Miękka klejona");
            comboBox2.Items.Add("Oprawa Miękka klejona okładka uczelni");
            comboBox2.Items.Add("Oprawa Miękka grzbiet plastikowy");
            comboBox2.Items.Add("Oprawa Miękka grzbiet metalowy");
            comboBox2.Items.Add("Oprawa Miękka listwa wsuwana ");


            comboBox2.SelectedIndex = 0;

            comboBox3_cd.Items.Add("Bez płyty");
            comboBox3_cd.Items.Add("CD");
            comboBox3_cd.Items.Add("DVD");

            comboBox3_cd.SelectedIndex = 0;

            comboBox3.Items.Add("Nie");
            comboBox3.Items.Add("Tak");

            comboBox3.SelectedIndex = 0;

        }

        private void textBox1_bwCount_TextChanged(object sender, EventArgs e)
        {
           
            if (int.TryParse(textBox1_bwCount.Text, out int result))
            {
                
                bwPages = result;
            }
            else
            {

            }
        }

        private void textBox3_cCount_TextChanged(object sender, EventArgs e)
        {
            
            if (int.TryParse(textBox3_cCount.Text, out int result))
            {
                
                colorPages = result;
            }
            else
            {

            }
        }

        private void textBox2_copies_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2_copies.Text, out int result))
            {
                // Jeśli wartość jest poprawna, przypisujemy ją do zmiennej bwPages
                copies = result;
            }
            else
            {

            }
        }

        private void comboBox2_bothSided_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2_bothSided.SelectedItem != null)
            {
                if (comboBox2_bothSided.SelectedItem.ToString() == "Tak")
                {
                   
                    pages = (int)Math.Ceiling((double)(bwPages + colorPages) / 2);

                }
                else if (comboBox2_bothSided.SelectedItem.ToString() == "Nie")
                {
         
                    pages = bwPages + colorPages;
                }
            }
        }

        private void button1_count_Click(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            double bwPrice = 0;
            double cPrice = 0;
            double bwPrice2 = 0;
            double cPrice2 = 0;

            bwPages = bwPages * copies;
            colorPages = colorPages * copies;

            for (int i = 0; i < priceTableBw.GetLength(0); i++)
            {
                int startRange = (int)priceTableBw[i, 0];
                int endRange = (int)priceTableBw[i, 1];
                double rangePrice = priceTableBw[i, 2];

                if (bwPages >= startRange && bwPages <= endRange)
                {
                    bwPrice = bwPages * rangePrice;
                    break;
                }
            }

            for (int i = 0; i < priceTableC.GetLength(0); i++)
            {
                int startRange = (int)priceTableC[i, 0];
                int endRange = (int)priceTableC[i, 1];
                double rangePrice = priceTableC[i, 2];

                if (colorPages >= startRange && colorPages <= endRange)
                {
                    cPrice = colorPages * rangePrice;
                    break;
                }
            }

            
            if (comboBox2_bothSided.SelectedItem != null && comboBox2_bothSided.SelectedItem.ToString() == "Tak")
            {
               
                pages = (int)Math.Ceiling((double)(bwPages + colorPages) / 2);
            }
            else
            {
                
                pages = bwPages + colorPages;
            }

           
            string selectedCoverType = comboBox1_cover.SelectedItem.ToString();
            double coverPrice = CalculateCoverPrice(selectedCoverType, pages);

           

            bwPages2 = bwPages2 * copies2;
            colorPages2 = colorPages2 * copies2;

            for (int i = 0; i < priceTableBw.GetLength(0); i++)
            {
                int startRange = (int)priceTableBw[i, 0];
                int endRange = (int)priceTableBw[i, 1];
                double rangePrice = priceTableBw[i, 2];

                if (bwPages2 >= startRange && bwPages2 <= endRange)
                {
                    bwPrice2 = bwPages2 * rangePrice;
                    break;
                }
            }

            for (int i = 0; i < priceTableC.GetLength(0); i++)
            {
                int startRange = (int)priceTableC[i, 0];
                int endRange = (int)priceTableC[i, 1];
                double rangePrice = priceTableC[i, 2];

                if (colorPages2 >= startRange && colorPages2 <= endRange)
                {
                    cPrice2 = colorPages2 * rangePrice;
                    break;
                }
            }

            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Tak")
            {
                pages2 = (int)Math.Ceiling((double)(bwPages2 + colorPages2) / 2);
            }
            else
            {
                
                pages2 = bwPages2 + colorPages2;
            }

            
            string selectedCoverType2 = comboBox2.SelectedItem.ToString();
            double coverPrice2 = CalculateCoverPrice(selectedCoverType, pages2);

            double totalPrice = (bwPrice + cPrice + (coverPrice * copies)) + (bwPrice2 + cPrice2 + (coverPrice2 * copies2)) + (cddvdPrice * cddvdCopies) + stickerCddvdPrice;

            textBox4_totalPrice.Text = totalPrice.ToString("C2"); 

        }


        private double CalculateCoverPrice(string coverType, int pages)
        {
            
            foreach (var cover in coverPrices)
            {
                if (cover.CoverType == coverType && pages >= cover.MinPages && pages <= cover.MaxPages)
                {
                    return cover.Price;
                }
            }

           
            return 0;
        }

        private void textBox4_totalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
            if (int.TryParse(textBox3.Text, out int result))
            {
                
                bwPages2 = result;
            }
            else
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            if (int.TryParse(textBox1.Text, out int result))
            {
                
                colorPages2 = result;
            }
            else
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(textBox2.Text, out int result))
            {
               
                copies2 = result;
            }
            else
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Tak")
                {
                   
                    pages2 = (int)Math.Ceiling((double)(bwPages2 + colorPages2) / 2);

                }
                else if (comboBox1.SelectedItem.ToString() == "Nie")
                {
                    
                    pages2 = bwPages2 + colorPages2;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(textBox4.Text, out int result))
            {

                cddvdCopies = result;
            }
            else
            {

            }
        }

        private void comboBox3_cd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3_cd.SelectedItem != null)
            {
                if (comboBox3_cd.SelectedItem != null)
                {
                    string selectedItem = comboBox3_cd.SelectedItem.ToString();
                    var selectedPlyta = plytyPrices.FirstOrDefault(p => p.Item1 == selectedItem);
                    if (selectedPlyta != default)
                    {
                        cddvdPrice = selectedPlyta.Item2;
                    }
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString() == "Tak")
            {
                if (cddvdCopies == 1)
                {
                    stickerCddvdPrice = 17.50;
                }

                else if (cddvdCopies > 1)
                {
                    stickerCddvdPrice = 17.50 + ((cddvdCopies - 1) * 5.50);
                }


            }
            else if (comboBox3.SelectedItem.ToString() == "Nie")
            {
                cddvdPrice = 0;
            }
        }
    }
}

public class CoverPrice
{
    public string CoverType { get; set; }
    public int MinPages { get; set; }
    public int MaxPages { get; set; }
    public double Price { get; set; }

    public CoverPrice(string coverType, int minPages, int maxPages, double price)
    {
        CoverType = coverType;
        MinPages = minPages;
        MaxPages = maxPages;
        Price = price;
    }
}

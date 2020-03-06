using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Created by Corry Burton
 * 
 * Ticker Picker - the application that picks a random stock from the NYSE/NASDAQ listed stocks and suggests a play.
 *  
 * Created 3/6/2020
 * 
 * Contact corrybrtn@gmail.com
 **/


namespace TickerPicker
{
   

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void populateBtn_Click_1(object sender, EventArgs e)
        {

            //assign all line items of nasdaq.txt to the nasdaq array
            string[] nasdaq = System.IO.File.ReadAllLines(@"..\..\nasdaq.txt"); 
            //assign all line items of nyse.txt to the nyse array
            string[] nyse = System.IO.File.ReadAllLines(@"..\..\nyse.txt");
            
            //take just the ticker from each string and reassign it back to the array
            for (int i = 0; i < nasdaq.Length; i++){
                nasdaq[i] = nasdaq[i].Substring(0, nasdaq[i].IndexOf("\t"));
            }
            //take just the ticker from each string and reassign it back to the array
            for (int i = 0; i < nyse.Length; i++)
            {
                nyse[i] = nyse[i].Substring(0, nyse[i].IndexOf("\t"));
            }

            //concatenate the arrays into a single array, stocks
            string[] stocks = nyse.Concat(nasdaq);
            Console.WriteLine(String.Join(",", stocks));

            //get the number of tickers in the stocks array
            int length = stocks.Length;

            //add each ticker to the list box
            for (int i = 0; i < length; i++)
            {
                listBox.Items.Add(stocks[i]);
            }
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            //get the number of items in the list box
            int total = listBox.Items.Count;
            //new random object
            Random random = new Random();
            //get a random number between 1 and the number of items in the listbox
            int num = random.Next(0, total - 1);

            //assign the random index of the listbox to the string newStock
            string newStock = listBox.Items[num].ToString();
            //display the newStock string to the outLabel control
            outLabel.Text = newStock;
        }

        private void whatDoBtn_Click(object sender, EventArgs e)
        {
            //if the stock has options trading
            if (optionsCB.Checked)
            {
                //new random object
                Random random = new Random();
                //random number between 1 and 3
                int num = (random.Next(0, 3) + 1);
                switch (num)
                {
                    //1 = buy the stock
                    case 1:
                        whatDoLabel.Text = "Buy this stock.";
                        break;
                    //2 = buy calls
                    case 2:
                        whatDoLabel.Text = "Buy calls";
                        break;
                    //3 = buy puts
                    case 3:
                        whatDoLabel.Text = "Buy puts";
                        break;
                }
            }

            //no options trading 
            else
            {
                //new random between 1 and 2
                Random random = new Random();
                int num = (random.Next(0, 2) + 1);

                switch (num)
                {
                    //1 = buy
                    case 1:
                        whatDoLabel.Text = "Buy this stock.";
                        break;
                    //2 = avoid
                    case 2:
                        whatDoLabel.Text = "Don't buy it, it's a dud! Pick another";
                        break;
                }
            }
                
                
        }
    }
    public static class Extension
    {
        //concat method concatenates two arrays
        public static T[] Concat<T>(this T[] first, params T[] second)
        {
            if (first == null)
            {
                return second;
            }
            if (second == null)
            {
                return first;
            }

            T[] result = new T[first.Length + second.Length];
            first.CopyTo(result, 0);
            second.CopyTo(result, first.Length);

            return result;
        }
    }
}

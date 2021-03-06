﻿using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MegaDesk2
{
	public partial class DisplayQuote : Form
	{
		//public DeskQuote Quote { get; }

		public DisplayQuote(DeskQuote quote)

		{

			InitializeComponent();
			//Quote = quote;
			fullNameOutput.Text = quote.CustomerName;
			widthOutput.Text = $"{quote.Desk.width}in";
			depthOutput.Text = $"{quote.Desk.depth}in";
			numberOfDrawersOutput.Text = quote.Desk.numberOfDrawers.ToString();
			surfaceMaterialOutput.Text = quote.Desk.SurfaceMaterial.ToString();
			rushOrderOutput.Text = (System.Attribute.GetCustomAttribute(quote.DayLengths.GetType().GetField(quote.DayLengths.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description
								   ?? quote.DayLengths.ToString();
			dateOutput.Text = quote.Date.ToShortDateString();
			quotePriceOutput.Text = $"${quote.QuotePrice}";
		}
	}
}
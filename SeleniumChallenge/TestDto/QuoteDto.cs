using System;
using System.ComponentModel;

namespace SeleniumChallenge.TestDto
{
    public class QuoteDto
    {
        public QuoteCategory Category;
        public string Address;
        public string Brand;
        public string Model;
        public int RetailValue;
        public DateTime BuyDate;
        public QuoteCondition Condition;

        /// <summary>
        /// Default quote values. Quick way to get a valid quote
        /// </summary>
        public QuoteDto()
        {
            this.Category = QuoteCategory.Appliances;
            this.Address = "31 Fitzroy Street, Kirribilli NSW, Australia";
            this.Brand = "Hyper X";
            this.Model = "Keyboard";
            this.RetailValue = 120;
            this.BuyDate = DateTime.Now;
            this.Condition = QuoteCondition.New;
        }

        /// <summary>
        /// Custom quote values
        /// </summary>
        public QuoteDto(QuoteCategory category, string address, string brand, string model, int retailValue,
            DateTime buyDate, QuoteCondition condition)
        {
            this.Category = category;
            this.Address = address;
            this.Brand = brand;
            this.Model = model;
            this.RetailValue = retailValue;
            this.BuyDate = buyDate;
            this.Condition = condition;
        }
    }

    public enum QuoteCategory
    {
        [Description("appliances")]
        Appliances,
        [Description("electronics")]
        Electronics,
        [Description("furniture")]
        Furniture,
        [Description("eyewear")]
        EyeWear,
        [Description("tools & gardening")]
        ToolsAndGardening,
        [Description("sports equipment")]
        SportsEquipment
    }

    public enum QuoteCondition
    {
        [Description("New")]
        New,
        [Description("Used")]
        Used
    }
}
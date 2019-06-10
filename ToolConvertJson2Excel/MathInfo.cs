using Newtonsoft.Json;

namespace ToolConvertJson2Excel
{
    public class MathInfo
    {
        [JsonProperty(PropertyName = "No")]
        public int No { get; set; }

        [JsonProperty(PropertyName = "OWPMatchId")]
        public string OWPMatchId { get; set; }

        [JsonProperty(PropertyName = "Date")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "Match Status")]
        public string MatchStatus { get; set; }

        [JsonProperty(PropertyName = "InfoSite ID")]
        public string InfoSiteID { get; set; }

        [JsonProperty(PropertyName = "Time")]
        public string Time { get; set; }

        [JsonProperty(PropertyName = "Other Time")]
        public string OtherTime { get; set; }

        [JsonProperty(PropertyName = "MatchOffer")]
        public string MatchOffer { get; set; }

        [JsonProperty(PropertyName = "League")]
        public string League { get; set; }

        [JsonProperty(PropertyName = "Home")]
        public string Home { get; set; }

        [JsonProperty(PropertyName = "Away")]
        public string Away { get; set; }

        [JsonProperty(PropertyName = "Note")]
        public string Note { get; set; }

        [JsonProperty(PropertyName = "Round")]
        public string Round { get; set; }

        [JsonProperty(PropertyName = "Division")]
        public string Division { get; set; }

        [JsonProperty(PropertyName = "Remark")]
        public string Remark { get; set; }

        [JsonProperty(PropertyName = "No.HDP")]
        public string NoHDP { get; set; }

        [JsonProperty(PropertyName = "Max Bet (HDP)")]
        public string MaxBetHDP { get; set; }

        [JsonProperty(PropertyName = "Spread (HDP)")]
        public string SpreadHDP { get; set; }

        [JsonProperty(PropertyName = "Trader (HDP)")]
        public string TraderHDP { get; set; }

        [JsonProperty(PropertyName = "Other Traders (HDP)")]
        public string OtherTradersHDP { get; set; }

        [JsonProperty(PropertyName = "Max Bet (1H HDP)")]
        public string MaxBet1HHDP { get; set; }

        [JsonProperty(PropertyName = "Spread (1H HDP)")]
        public string Spread1HHDP { get; set; }

        [JsonProperty(PropertyName = "Trader (1H HDP)")]
        public string Trader1HHDP { get; set; }

        [JsonProperty(PropertyName = "Other Traders (1H HDP)")]
        public string OtherTraders1HHDP { get; set; }

        [JsonProperty(PropertyName = "Max Bet (OU)")]
        public string MaxBetOU { get; set; }

        [JsonProperty(PropertyName = "Spread (OU)")]
        public string SpreadOU { get; set; }

        [JsonProperty(PropertyName = "Trader (OU)")]
        public string TraderOU { get; set; }

        [JsonProperty(PropertyName = "Other Traders (OU)")]
        public string OtherTradersOU { get; set; }

        [JsonProperty(PropertyName = "Max Bet (1H OU)")]
        public string MaxBet1HOU { get; set; }

        [JsonProperty(PropertyName = "Spread (1H OU)")]
        public string Spread1HOU { get; set; }

        [JsonProperty(PropertyName = "Trader (1H OU)")]
        public string Trader1HOU { get; set; }

        [JsonProperty(PropertyName = "Other Traders (1H OU)")]
        public string OtherTraders1HOU { get; set; }

        [JsonProperty(PropertyName = "Max Bet (1X2)")]
        public string MaxBet1X2 { get; set; }

        [JsonProperty(PropertyName = "Spread (1X2)")]
        public string Spread1X2 { get; set; }

        [JsonProperty(PropertyName = "Trader (1X2)")]
        public string Trader1X2 { get; set; }

        [JsonProperty(PropertyName = "Other Traders (1X2)")]
        public string OtherTraders1X2 { get; set; }

        [JsonProperty(PropertyName = "Max Bet (1H 1X2)")]
        public string MaxBet1H1X2 { get; set; }

        [JsonProperty(PropertyName = "Spread (1H 1X2)")]
        public string Spread1H1X2 { get; set; }

        [JsonProperty(PropertyName = "Trader (1H 1X2)")]
        public string Trader1H1X2 { get; set; }

        [JsonProperty(PropertyName = "Other Traders (1H 1X2)")]
        public string OtherTraders1H1X2 { get; set; }

        [JsonProperty(PropertyName = "Max Bet (x mins)")]
        public string MaxBetxmins { get; set; }

        [JsonProperty(PropertyName = "Spread (x mins)")]
        public string Spreadxmins { get; set; }

        [JsonProperty(PropertyName = "Trader (15 mins)")]
        public string Trader15mins { get; set; }

        [JsonProperty(PropertyName = "Other Traders (15 mins)")]
        public string OtherTraders15mins { get; set; }

        [JsonProperty(PropertyName = "Trader (10 mins)")]
        public string Trader10mins { get; set; }

        [JsonProperty(PropertyName = "Other Traders (10 mins)")]
        public string OtherTraders10mins { get; set; }

        [JsonProperty(PropertyName = "LA")]
        public string LA { get; set; }

        [JsonProperty(PropertyName = "Other LA")]
        public string OtherLA { get; set; }

        [JsonProperty(PropertyName = "Max Bet (FM)")]
        public string MaxBetFM { get; set; }

        [JsonProperty(PropertyName = "Spread (FM)")]
        public string SpreadFM { get; set; }

        [JsonProperty(PropertyName = "Trader (FM)")]
        public string TraderFM { get; set; }

        [JsonProperty(PropertyName = "Other Traders (FM)")]
        public string OtherTradersFM { get; set; }

        [JsonProperty(PropertyName = "Trader (AIO)")]
        public string TraderAIO { get; set; }

        [JsonProperty(PropertyName = "Other Traders (AIO)")]
        public string OtherTradersAIO { get; set; }

        [JsonProperty(PropertyName = "Agent")]
        public string Agent { get; set; }

        [JsonProperty(PropertyName = "TV")]
        public string TV { get; set; }

        [JsonProperty(PropertyName = "Channel")]
        public string Channel { get; set; }

        [JsonProperty(PropertyName = "WB")]
        public string WB { get; set; }

        [JsonProperty(PropertyName = "OtherProvider")]
        public string OtherProvider { get; set; }

        [JsonProperty(PropertyName = "Provider")]
        public string Provider { get; set; }

        [JsonProperty(PropertyName = "Phone")]
        public string Phone { get; set; }

        [JsonProperty(PropertyName = "Web1")]
        public string Web1 { get; set; }

        [JsonProperty(PropertyName = "Web2")]
        public string Web2 { get; set; }

        [JsonProperty(PropertyName = "Web3")]
        public string Web3 { get; set; }

        [JsonProperty(PropertyName = "Web4")]
        public string Web4 { get; set; }
    }
}
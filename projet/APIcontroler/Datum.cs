using System;
using System.Linq;

namespace projet.APIcontroler
{
    public class Datum
    {
        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public double price { get; set; }
        public double price_btc { get; set; }
        public long market_cap { get; set; }
        public double percent_change_24h { get; set; }
        public double percent_change_7d { get; set; }
        public double percent_change_30d { get; set; }
        public string s { get; set; }
        public string n { get; set; }
        public double p { get; set; }
        public double p_btc { get; set; }
        public double gs { get; set; }
        public long mc { get; set; }
        /*public double volume_24h { get; set; }
        public string max_supply { get; set; }
        /*public int social_contributors_calc_24h_previous { get; set; }
        public int url_shares_calc_24h_previous { get; set; }
        public double volume_24h { get; set; }
        public int tweet_spam_calc_24h_previous { get; set; }
        public int news_calc_24h_previous { get; set; }
        public double average_sentiment_calc_24h_previous { get; set; }
        public long social_score_calc_24h_previous { get; set; }
        public int social_volume_calc_24h_previous { get; set; }
        public int alt_rank_30d_calc_24h_previous { get; set; }
        public int alt_rank_calc_24h_previous { get; set; }
        public int social_contributors_calc_24h { get; set; }
        public double social_contributors_calc_24h_percent { get; set; }
        public int url_shares_calc_24h { get; set; }
        public double url_shares_calc_24h_percent { get; set; }
        public int tweet_spam_calc_24h { get; set; }
        public double tweet_spam_calc_24h_percent { get; set; }
        public int news_calc_24h { get; set; }
        public double news_calc_24h_percent { get; set; }
        public double average_sentiment_calc_24h { get; set; }
        public int average_sentiment_calc_24h_percent { get; set; }
        public long social_score_calc_24h { get; set; }
        public double social_score_calc_24h_percent { get; set; }
        public int social_volume_calc_24h { get; set; }
        public double social_volume_calc_24h_percent { get; set; }
        public int asset_id { get; set; }
        public int time { get; set; }
        public double open { get; set; }
        public double high { get; set; }
        public double low { get; set; }*/
        public double volume { get; set; }/*
        public int url_shares { get; set; }
        public int unique_url_shares { get; set; }
        public int reddit_posts { get; set; }
        public int reddit_posts_score { get; set; }
        public int reddit_comments { get; set; }
        public int reddit_comments_score { get; set; }
        public int tweets { get; set; }
        public int tweet_spam { get; set; }
        public int tweet_followers { get; set; }
        public int tweet_quotes { get; set; }
        public int tweet_retweets { get; set; }
        public int tweet_replies { get; set; }
        public int tweet_favorites { get; set; }
        public int tweet_sentiment1 { get; set; }
        public int tweet_sentiment2 { get; set; }
        public int tweet_sentiment3 { get; set; }
        public int tweet_sentiment4 { get; set; }
        public int tweet_sentiment5 { get; set; }
        public int tweet_sentiment_impact1 { get; set; }
        public int tweet_sentiment_impact2 { get; set; }
        public int tweet_sentiment_impact3 { get; set; }
        public int tweet_sentiment_impact4 { get; set; }
        public int tweet_sentiment_impact5 { get; set; }
        public int social_score { get; set; }
        public double average_sentiment { get; set; }
        public int sentiment_absolute { get; set; }
        public int sentiment_relative { get; set; }
        public int news { get; set; }
        public int price_score { get; set; }
        public int social_impact_score { get; set; }
        public double correlation_rank { get; set; }*/
        public double galaxy_score { get; set; }
        public double volatility { get; set; }
        public int alt_rank { get; set; }/*
        public int alt_rank_30d { get; set; }
        public int market_cap_rank { get; set; }
        public int percent_change_24h_rank { get; set; }
        public int volume_24h_rank { get; set; }
        public int social_volume_24h_rank { get; set; }
        public int social_score_24h_rank { get; set; }
        public int social_contributors { get; set; }
        public int social_volume { get; set; }
        public int social_volume_global { get; set; }
        public double social_dominance { get; set; }
        public long market_cap_global { get; set; }
        public double market_dominance { get; set; }
        public int medium { get; set; }
        public int youtube { get; set; }
        public double close { get; set; }*/

        public string getLimitedSymbol()
        {
            if (s.Contains('('))
            {
                return s.Substring(0,s.IndexOf('('));
            }
            if (s.Length > 7)
            {
                return s.Substring(0, 7);
            }
            return s;
        }

        public string getLimitedPrice()
        {
            return p.ToString().Substring(0, 8);
        }

        public string getLimitedPriceBtc()
        {
            return p_btc.ToString().Substring(0, 8);
        }

        public string getLimitedMC()
        {
            int l = mc.ToString().Length;
            if (l > 7)
            {
                return (mc / Math.Pow(10, l-1)).ToString().Substring(0,5)+"E"+(l-1).ToString();
            }

            return l.ToString();
        }
    }
}
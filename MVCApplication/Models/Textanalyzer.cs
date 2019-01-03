using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApplication.Models
{

    public class Textanalyzer
    {
        public string Name { get; set; }

        public Textanalyzer(string name)
        {
            Name = name;


        }


        public List<string> Analyze(string content)
        {
            StringBuilder tatstr = new StringBuilder();
            StringBuilder adstr = new StringBuilder();
            Dictionary<string, int> wonder = new Dictionary<string, int>();
            List<string> setfin = new List<string>();           
            List<string> super = new List<string>();
            List<string> replist = new List<string>();
            List<string> replist2 = new List<string>();

            string inpi2 = content.ToLower();
            var punctuation = inpi2.Where(Char.IsPunctuation).Distinct().ToArray();
            var superman = inpi2.Split().Select(x => x.Trim(punctuation));

            foreach (var item in superman)
            {
                super.Add(item);

            }
            
            int lim = super.Count();
            for(int i = 0; i < lim; i++)
            {
                if (setfin.Contains(super[i]))
                {
                    wonder[super[i]] += 1;
                }

                else
                {
                    setfin.Add(super[i]);
                    wonder.Add(super[i], 1);
                }

            }

               foreach (KeyValuePair<string, int> item in wonder)
            {
                adstr.Clear();
                string elem = item.Value.ToString();
                adstr.Append(elem);
                adstr.Append(": ");
                for (int j = 0; j < item.Value; j++) { 
                    adstr.Append(item.Key);
                adstr.Append("  ");
                }
                string addstr = adstr.ToString();
                replist2.Add(addstr);

            }

            replist2.Sort();
            replist2.Reverse();

            return replist2;
            
          

        }


 
            }

            

        }

        





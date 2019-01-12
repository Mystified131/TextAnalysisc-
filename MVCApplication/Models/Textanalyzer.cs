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


        public Dictionary<string, int> Analyze(string content)
        {
            StringBuilder tatstr = new StringBuilder();
            StringBuilder adstr = new StringBuilder();
            Dictionary<string, int> wonder = new Dictionary<string, int>();
            Dictionary<string, int> retDict = new Dictionary<string, int>();
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


            List<string> outlst = new List<string>();
            outlst.Add("of");
            outlst.Add("on");
            outlst.Add("the");
            outlst.Add("he");
            outlst.Add("she");
            outlst.Add("or");
            outlst.Add("it");
            outlst.Add("its");
            outlst.Add("and");
            outlst.Add("in");
            outlst.Add("for");
            outlst.Add("i");
            outlst.Add("him");
            outlst.Add("her");
            outlst.Add("a");
            outlst.Add("an");
            outlst.Add("is");
            outlst.Add("to");
            outlst.Add("was");
            outlst.Add("that");
            outlst.Add("is");
            outlst.Add("had");
            outlst.Add("by");
            outlst.Add("at");
            outlst.Add("as");
            outlst.Add("his");
            outlst.Add("would");
            outlst.Add("which");
            outlst.Add("would");
            outlst.Add("when");
            outlst.Add("where");
            outlst.Add("why");
            outlst.Add("if");
            outlst.Add("then");
            outlst.Add("with");
            outlst.Add("what");
            outlst.Add("we");
            outlst.Add("this");
            outlst.Add("my");
            outlst.Add("our");
            outlst.Add("their");


            foreach (var item in superman)
            {
                foreach(var otem in outlst)
                {
                    if(item == otem)
                    {

                        super.Remove(item);

                    }

                }

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
                    wonder.Add((super[i]), 1);
                }

            }

            var NewD = wonder.OrderByDescending(x => x.Key);
            var newDict = NewD.OrderByDescending(x => x.Value);

            foreach (var item in newDict)
            {

                string newstr = item.Key + " ";
                retDict.Add(newstr, item.Value);

            }

            return retDict;
            
          

        }


 
            }

            

        }

        





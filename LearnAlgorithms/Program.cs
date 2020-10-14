using System;
using System.Collections.Generic;

namespace LearnAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "itisalongestablishedfactthatareadaaderwillbedistractedbythereadablekabakcontenkavaktofaeyedipadanadapideyepagewhenlookingatitslayout.thepointofusingloremipsumisthatithasamore-or-lessnormaldistributionofletters,asopposedtousing'contenthere,contenthere',makingitlooklikereadableenglish.manydesktoppublishingpackagesandwebpageeditorsnowuseloremipsumastheirdefaultmodeltext,andasearchfor'loremipsum'willuncovermanywebsitesstillintheirinfancy.variousversionshaveevolvedovertheyearssometimesbyaccidentsometimesonpurpose";
            List<string> palindromicWords = PalindromicWords.GetPalindromicWords(input);
            palindromicWords.ForEach(x => Console.WriteLine(x));
            Console.ReadLine();
        }

    }
}

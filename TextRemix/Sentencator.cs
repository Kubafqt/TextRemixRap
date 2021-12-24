using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TextRemix
{
   class Sentencator
   {
      public static Dictionary<string, int> SentenceAfterLines = new Dictionary<string, int>();
      public static Dictionary<string, int> SentenceTimesToLeft = new Dictionary<string, int>();
      public static Dictionary<string, Point> SentenceTime = new Dictionary<string, Point>();
      public static Dictionary<string, List<string>> afterList = new Dictionary<string, List<string>>();
      public static Dictionary<string, bool> afterAnd = new Dictionary<string, bool>();
      public static Dictionary<string, List<string>> blabolList = new Dictionary<string, List<string>>();
      static Random random = new Random();

      /// <summary>
      /// 
      /// </summary>
      /// <param name="blabolName"></param>
      public static void CreateBlabol(string blabolName)
      {
         if (!blabolList.ContainsKey(blabolName))
         {
            blabolList.Add(blabolName, new List<string>());
            SentenceTimesToLeft = SentenceAfterLines;
            SentenceTimesToLeft = SentenceTimesToLeft.ToDictionary(p => p.Key, p => 0);
         }
         for (int i = 0; i < 100; i++)
         {
            List<string> keys = SentenceTimesToLeft.Keys.ToList();//.Where(x => x.Value == 0).Select(x => x.Key).ToList();
            if (keys.Count == 0)
            {
               keys.Add(SentenceTimesToLeft.OrderBy(kvp => kvp.Value).First().Key);
               //SentenceTimesToLeft[keys[0]] = 0;
            }
            string sentence = keys[random.Next(keys.Count)];
            int sentenceTime = random.Next(SentenceTime[sentence].X, SentenceTime[sentence].Y);
            blabolList[blabolName].AddRange(Enumerable.Repeat(sentence, sentenceTime));
            SentenceTimesToLeft[sentence] = SentenceAfterLines[sentence];
            ReduceSentenceTimesToLeft(sentence, sentenceTime);
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sentence"></param>
      /// <param name="sentenceTime"></param>
      private static void ReduceSentenceTimesToLeft(string sentence, int sentenceTime)
      {
         //SentenceTimesToLeft = SentenceTimesToLeft.ToDictionary(p => p.Key != sentence, p => p.Value -= sentenceTime);
         foreach (var item in SentenceTimesToLeft)
         {
            if (item.Key != sentence)
            {
               int sentenceTimeLeft = SentenceTimesToLeft[item.Key];
               SentenceTimesToLeft[item.Key] = sentenceTimeLeft -= sentenceTime >= 0 ? sentenceTimeLeft -= sentenceTime : 0;
            }
         }
      }
   }
}
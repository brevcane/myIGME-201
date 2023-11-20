﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web;

namespace TriviaApp
{
    class TriviaResult
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;
    }
    class Trivia
    {
        public int response_code;
        public List<TriviaResult> results;
    }

    //"response_code": 0,
    //"results": [{"type": "multiple","difficulty": "easy","category": "Entertainment: Television",
    //        "question": "The HBO series &quot;Game of Thrones&quot; is based on which series of books?",
    //        "correct_answer": "A Song of Ice and Fire","incorrect_answers": ["The Wheel of Time","Harry Potter","The Notebook"]
    // }]}
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = null;
            string s = null;

            HttpWebRequest request;
            HttpWebResponse response;
            StreamReader reader;

            url = "https://opentdb.com/api.php?amount=1";

            request = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)request.GetResponse();

            reader = new StreamReader(response.GetResponseStream());
            s = reader.ReadToEnd();
            reader.Close();

            Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

            trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
            trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].correct_answer);

            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; ++i)
            {
                trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
            }


        }
    }
}

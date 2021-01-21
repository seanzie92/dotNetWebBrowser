﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebBrowser.Logic
{
    //get and set methods for history 
    public class HistoryItem
    {
        public int Id
            {get; set;}

        public string URL
            {get; set;}

        public string Title
            {get; set;}

        public DateTime Date
            {get; set;}
    }
}

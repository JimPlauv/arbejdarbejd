using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace Arbejdarbejd.Manager
{
    public static class Texts
    {
        public static aaText GetText(string TextName)
        {
            WebApplication1.Models.ArbejdArbejdDBDataContext db = new ArbejdArbejdDBDataContext();
            
            return db.aaTexts.Where(i => i.TextName == TextName).SingleOrDefault();
        }
    }
}
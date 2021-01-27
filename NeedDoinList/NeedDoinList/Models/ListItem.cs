using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NeedDoinList.Models
{
    public class ListItem
    {
        private bool boxchecked;

        public bool BoxChecked
        {
            get { return boxchecked; }
            set { boxchecked = value; }
        }

        //[Required]
        //[StringLength(50, ErrorMessage = "Character limit reached(50 character limit).")]
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public ListItem(bool boxchecked, string text)
        {
            this.boxchecked = boxchecked;
            this.text = text;
        }
    }
}

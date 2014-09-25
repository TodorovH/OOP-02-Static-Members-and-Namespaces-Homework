using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04HTMLDispatcher
{
    public class ElementBuilder
    {
        private string elementName;
        private Dictionary<string, string> attributes = new Dictionary<string, string>();
        private string content = "";
        private bool isImgOrInput = false;

        public ElementBuilder(string elementName)
        {
            this.ElementName = elementName;
        }

        public string ElementName 
        {
            get 
            { 
                return this.elementName; 
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Argument name cannot be empty");
                }
                this.elementName = value;
            }
        }

        public void AddAttribute(string attribute, string value)
        {
            this.attributes.Add(attribute, value);
        }

        public void AddContent(string content)
        {
            this.content = content;
        }

        public void IsImgOrInput(bool isImgOrInput)
        {
            this.isImgOrInput = isImgOrInput;
        }

        public override string ToString()
        {
            string attributesStr = "";
            string result = "";

            foreach (var att in attributes)
            {
                attributesStr += " " + att.Key + "=\"" + att.Value + "\"";
            }

            if (isImgOrInput == false)
            {
                result = string.Format("<{0}{1}>{2}</{0}>", this.ElementName, attributesStr, this.content);
            }
            else
            {
                result = string.Format("<{0}{1} />", this.ElementName, attributesStr);
            }
            return result;
        }

        public static string operator *(ElementBuilder element, int n)
        {
            string str = "";

            for (int i = 0; i < n; i++)
            {
                str += element.ToString();
            }

            return str;
        }
    }
}

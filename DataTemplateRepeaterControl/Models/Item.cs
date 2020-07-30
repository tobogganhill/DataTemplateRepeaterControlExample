using System;
using System.IO;
using System.Net;
using Xamarin.Forms;

namespace DataTemplateRepeaterControl.Models
{
    public enum ItemType
    {
        TypeA
    }

    public abstract class Item
    {
        public string Id { get; set; }
        protected abstract ItemType Type { get; }
        public string CredentialName { get; set; }
        public string CredentialDesc { get; set; }
        public string CredentialGroup { get; set; }
        public string Role { get; set; }
        public string LongDescription { get; set; }

    }

    public class ItemA : Item
    {
        protected override ItemType Type => ItemType.TypeA;
    }

    //public class ItemB : Item
    //{
    //    protected override ItemType Type => ItemType.TypeB;
    //}

    //public class ItemC : Item
    //{
    //    protected override ItemType Type => ItemType.TypeC;
    //}
}
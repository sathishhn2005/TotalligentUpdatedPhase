using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Totalligent.BusinessEntities
{
    [DataContract]
    public class DataPoint
    {
        //public DataPoint(string y, double a, double b, double c)
        //{
        //    this.y = y;
        //    this.a = a;
        //    this.b = b;
        //    this.c = c;
        //}

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "y")]
        public string y = "";

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "a")]
        public Nullable<decimal> a = null;
        [DataMember(Name = "b")]
        public Nullable<decimal> b = null;
        [DataMember(Name = "c")]
        public Nullable<decimal> c = null;

        [DataMember(Name = "BusinessType")]
        public string BusinessType = "";
    }
}

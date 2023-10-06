using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLogic.Entities
{
    public class InlineResponse
    {
        public int? Count { get; set; }

        public int? Next { get; set; }

        public int? Previous { get; set; }

        public List<int?> All { get; set; }

        public List<InlineResponseResult> Results { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse200 {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Previous: ").Append(Previous).Append("\n");
            sb.Append("  All: ").Append(All).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((InlineResponse)obj);
        }

        public bool Equals(InlineResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Count == other.Count ||
                    Count != null &&
                    Count.Equals(other.Count)
                ) &&
                (
                    Next == other.Next ||
                    Next != null &&
                    Next.Equals(other.Next)
                ) &&
                (
                    Previous == other.Previous ||
                    Previous != null &&
                    Previous.Equals(other.Previous)
                ) &&
                (
                    All == other.All ||
                    All != null &&
                    All.SequenceEqual(other.All)
                ) &&
                (
                    Results == other.Results ||
                    Results != null &&
                    Results.SequenceEqual(other.Results)
                );
        }

        public override int GetHashCode()
        {
            unchecked 
            {
                var hashCode = 41;
                if (Count != null)
                    hashCode = hashCode * 59 + Count.GetHashCode();
                if (Next != null)
                    hashCode = hashCode * 59 + Next.GetHashCode();
                if (Previous != null)
                    hashCode = hashCode * 59 + Previous.GetHashCode();
                if (All != null)
                    hashCode = hashCode * 59 + All.GetHashCode();
                if (Results != null)
                    hashCode = hashCode * 59 + Results.GetHashCode();
                return hashCode;
            }
        }
    }
}

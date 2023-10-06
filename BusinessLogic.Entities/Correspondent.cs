using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace BusinessLogic.Entities
{
    public class Correspondent
    {
        public long? Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Match { get; set; }
        public long? MatchingAlgorithm { get; set; }
        public bool? IsInsensitive { get; set; }
        public long? DocumentCount { get; set; }
        public DateTime? LastCorrespondence { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Correspondent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Match: ").Append(Match).Append("\n");
            sb.Append("  MatchingAlgorithm: ").Append(MatchingAlgorithm).Append("\n");
            sb.Append("  IsInsensitive: ").Append(IsInsensitive).Append("\n");
            sb.Append("  DocumentCount: ").Append(DocumentCount).Append("\n");
            sb.Append("  LastCorrespondence: ").Append(LastCorrespondence).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Correspondent)obj);
        }

        public bool Equals(Correspondent other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) &&
                (
                    Slug == other.Slug ||
                    Slug != null &&
                    Slug.Equals(other.Slug)
                ) &&
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) &&
                (
                    Match == other.Match ||
                    Match != null &&
                    Match.Equals(other.Match)
                ) &&
                (
                    MatchingAlgorithm == other.MatchingAlgorithm ||
                    MatchingAlgorithm != null &&
                    MatchingAlgorithm.Equals(other.MatchingAlgorithm)
                ) &&
                (
                    IsInsensitive == other.IsInsensitive ||
                    IsInsensitive != null &&
                    IsInsensitive.Equals(other.IsInsensitive)
                ) &&
                (
                    DocumentCount == other.DocumentCount ||
                    DocumentCount != null &&
                    DocumentCount.Equals(other.DocumentCount)
                ) &&
                (
                    LastCorrespondence == other.LastCorrespondence ||
                    LastCorrespondence != null &&
                    LastCorrespondence.Equals(other.LastCorrespondence)
                );
        }

        public override int GetHashCode()
        {
            unchecked 
            {
                var hashCode = 41;
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Slug != null)
                    hashCode = hashCode * 59 + Slug.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Match != null)
                    hashCode = hashCode * 59 + Match.GetHashCode();
                if (MatchingAlgorithm != null)
                    hashCode = hashCode * 59 + MatchingAlgorithm.GetHashCode();
                if (IsInsensitive != null)
                    hashCode = hashCode * 59 + IsInsensitive.GetHashCode();
                if (DocumentCount != null)
                    hashCode = hashCode * 59 + DocumentCount.GetHashCode();
                if (LastCorrespondence != null)
                    hashCode = hashCode * 59 + LastCorrespondence.GetHashCode();
                return hashCode;
            }
        }

    }
}

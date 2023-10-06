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
    public class InlineResponseResult
    {
        public int? Id { get; set; }

        public string Slug { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public string TextColor { get; set; }

        public string Match { get; set; }

        public int? MatchingAlgorithm { get; set; }

        public bool? IsInsensitive { get; set; }

        public bool? IsInboxTag { get; set; }

        public int? DocumentCount { get; set; }

        public int? Owner { get; set; }

        public ApicorrespondentsidPermissions Permissions { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20016Results {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  TextColor: ").Append(TextColor).Append("\n");
            sb.Append("  Match: ").Append(Match).Append("\n");
            sb.Append("  MatchingAlgorithm: ").Append(MatchingAlgorithm).Append("\n");
            sb.Append("  IsInsensitive: ").Append(IsInsensitive).Append("\n");
            sb.Append("  IsInboxTag: ").Append(IsInboxTag).Append("\n");
            sb.Append("  DocumentCount: ").Append(DocumentCount).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponseResult)obj);
        }

        public bool Equals(InlineResponseResult other)
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
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
                ) &&
                (
                    TextColor == other.TextColor ||
                    TextColor != null &&
                    TextColor.Equals(other.TextColor)
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
                    IsInboxTag == other.IsInboxTag ||
                    IsInboxTag != null &&
                    IsInboxTag.Equals(other.IsInboxTag)
                ) &&
                (
                    DocumentCount == other.DocumentCount ||
                    DocumentCount != null &&
                    DocumentCount.Equals(other.DocumentCount)
                ) &&
                (
                    Owner == other.Owner ||
                    Owner != null &&
                    Owner.Equals(other.Owner)
                ) &&
                (
                    Permissions == other.Permissions ||
                    Permissions != null &&
                    Permissions.Equals(other.Permissions)
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
                if (Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();
                if (TextColor != null)
                    hashCode = hashCode * 59 + TextColor.GetHashCode();
                if (Match != null)
                    hashCode = hashCode * 59 + Match.GetHashCode();
                if (MatchingAlgorithm != null)
                    hashCode = hashCode * 59 + MatchingAlgorithm.GetHashCode();
                if (IsInsensitive != null)
                    hashCode = hashCode * 59 + IsInsensitive.GetHashCode();
                if (IsInboxTag != null)
                    hashCode = hashCode * 59 + IsInboxTag.GetHashCode();
                if (DocumentCount != null)
                    hashCode = hashCode * 59 + DocumentCount.GetHashCode();
                if (Owner != null)
                    hashCode = hashCode * 59 + Owner.GetHashCode();
                if (Permissions != null)
                    hashCode = hashCode * 59 + Permissions.GetHashCode();
                return hashCode;
            }
        }
    }
}

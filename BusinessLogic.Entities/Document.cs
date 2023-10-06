using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace BusinessLogic.Entities
{
    public class Document
    {
        public int? Id { get; set; }
        public int? Correspondent { get; set; }
        public int? DocumentType { get; set; }
        public int? StoragePath { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<int?> Tags { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Added { get; set; }
        public string ArchiveSerialNumber { get; set; }
        public string OriginalFileName { get; set; }
        public string ArchivedFileName { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Document {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Correspondent: ").Append(Correspondent).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  StoragePath: ").Append(StoragePath).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Added: ").Append(Added).Append("\n");
            sb.Append("  ArchiveSerialNumber: ").Append(ArchiveSerialNumber).Append("\n");
            sb.Append("  OriginalFileName: ").Append(OriginalFileName).Append("\n");
            sb.Append("  ArchivedFileName: ").Append(ArchivedFileName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Document)obj);
        }
        public bool Equals(Document other)
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
                    Correspondent == other.Correspondent ||
                    Correspondent != null &&
                    Correspondent.Equals(other.Correspondent)
                ) &&
                (
                    DocumentType == other.DocumentType ||
                    DocumentType != null &&
                    DocumentType.Equals(other.DocumentType)
                ) &&
                (
                    StoragePath == other.StoragePath ||
                    StoragePath != null &&
                    StoragePath.Equals(other.StoragePath)
                ) &&
                (
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
                ) &&
                (
                    Content == other.Content ||
                    Content != null &&
                    Content.Equals(other.Content)
                ) &&
                (
                    Tags == other.Tags ||
                    Tags != null &&
                    Tags.SequenceEqual(other.Tags)
                ) &&
                (
                    Created == other.Created ||
                    Created != null &&
                    Created.Equals(other.Created)
                ) &&
                (
                    CreatedDate == other.CreatedDate ||
                    CreatedDate != null &&
                    CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    Modified == other.Modified ||
                    Modified != null &&
                    Modified.Equals(other.Modified)
                ) &&
                (
                    Added == other.Added ||
                    Added != null &&
                    Added.Equals(other.Added)
                ) &&
                (
                    ArchiveSerialNumber == other.ArchiveSerialNumber ||
                    ArchiveSerialNumber != null &&
                    ArchiveSerialNumber.Equals(other.ArchiveSerialNumber)
                ) &&
                (
                    OriginalFileName == other.OriginalFileName ||
                    OriginalFileName != null &&
                    OriginalFileName.Equals(other.OriginalFileName)
                ) &&
                (
                    ArchivedFileName == other.ArchivedFileName ||
                    ArchivedFileName != null &&
                    ArchivedFileName.Equals(other.ArchivedFileName)
                );
        }
        public override int GetHashCode()
        {
            unchecked 
            {
                var hashCode = 41;
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Correspondent != null)
                    hashCode = hashCode * 59 + Correspondent.GetHashCode();
                if (DocumentType != null)
                    hashCode = hashCode * 59 + DocumentType.GetHashCode();
                if (StoragePath != null)
                    hashCode = hashCode * 59 + StoragePath.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (Content != null)
                    hashCode = hashCode * 59 + Content.GetHashCode();
                if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                if (Created != null)
                    hashCode = hashCode * 59 + Created.GetHashCode();
                if (CreatedDate != null)
                    hashCode = hashCode * 59 + CreatedDate.GetHashCode();
                if (Modified != null)
                    hashCode = hashCode * 59 + Modified.GetHashCode();
                if (Added != null)
                    hashCode = hashCode * 59 + Added.GetHashCode();
                if (ArchiveSerialNumber != null)
                    hashCode = hashCode * 59 + ArchiveSerialNumber.GetHashCode();
                if (OriginalFileName != null)
                    hashCode = hashCode * 59 + OriginalFileName.GetHashCode();
                if (ArchivedFileName != null)
                    hashCode = hashCode * 59 + ArchivedFileName.GetHashCode();
                return hashCode;
            }
        }
    }
}
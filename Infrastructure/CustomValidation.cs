using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DQMA.Infrastructure
{
    public static class CustomValidation
    {
        //Have different valid types e.g. valid image types, valid document types.
        private readonly static string[] VALID_IMAGE_TYPES = { "png", "jpg", "jpeg", "gif" };
        private readonly static string[] VALID_DOCUMENT_TYPES = { "txt", "csv", "doc", "docx", "pdf" };

        public static bool IsValidImageFile(this string fileName)
        {
            var extensions = fileName.Split(".");

            if (extensions.Any())
                return VALID_IMAGE_TYPES.Contains(extensions[extensions.Length - 1].ToLower());

            return false;
        }

        public static bool IsValidDocumentFile(this string fileName)
        {
            var extensions = fileName.Split(".");

            if (extensions.Any())
                return VALID_DOCUMENT_TYPES.Contains(extensions[extensions.Length - 1].ToLower());
            return false;
        }

        public static bool IsValidSearchTerm(this string searchTerm)
        {
            return searchTerm?.Length >= 3;
        }        
    }
}

using System.ComponentModel.DataAnnotations;

namespace Mango.Web.Utility
{
    public class AllowedExtensionsAttribute : ValidationAttribute
    {
        #region Declaration
        private readonly string[] _extensions;
        #endregion

        #region Constructor
        public AllowedExtensionsAttribute(string[] extensions)
        {
            _extensions = extensions;
        }
        #endregion

        #region Methods
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;

            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName);
                if (!_extensions.Contains(extension.ToLower()))
                {
                    return new ValidationResult("This photo extension is not allowed!");
                }
            }

            return ValidationResult.Success;
        } 
        #endregion

    }
}

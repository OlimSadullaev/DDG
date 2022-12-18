using System.ComponentModel.DataAnnotations;

namespace Mock_interview.Mock_InterviewServiceTools.Attributes
{
    public class FromFileAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is IFormFile file)
            {
                string[] extensions = new string[] { ".png", ".jpg" };
                var extension = Path.GetExtension(file.FileName);

                if (!extensions.Contains(extension.ToLower()))
                {
                    return new ValidationResult("This photo extension is not allowed!");
                }
            }
            return ValidationResult.Success;
        }
    }
}

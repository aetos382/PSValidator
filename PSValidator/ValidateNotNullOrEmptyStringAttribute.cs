namespace PSValidator
{
    using System;
    using System.Linq;
    using System.Management.Automation;

    using PSValidator.Properties;

    public class ValidateNotNullOrEmptyStringAttribute :
        ValidateEnumeratedArgumentsAttribute
    {
        protected override void ValidateElement(object element)
        {
            if (element == null)
            {
                throw new ValidationMetadataException(Resources.ArgumentIsNull);
            }

            string value = element as string;
            if (value == null)
            {
                throw new ValidationMetadataException(Resources.ArgumentIsNotString);
            }

            if (value.Length == 0)
            {
                throw new ValidationMetadataException(Resources.ArgumentIsEmptyString);
            }
        }
    }
}

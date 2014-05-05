namespace PSValidator
{
    using System;
    using System.Linq;
    using System.Management.Automation;
    using System.Management.Automation.Internal;

    using PSValidator.Properties;

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class ValidateNotEmptyStringAttribute :
        ValidateEnumeratedArgumentsAttribute
    {
        protected override void ValidateElement(object element)
        {
            if (element == null || element == AutomationNull.Value)
            {
                throw new ValidationMetadataException(Resources.ArgumentIsNull);
            }

            string value = element as string;
            if (value == null)
            {
                throw new ValidationMetadataException(Resources.ArgumentIsNotString);
            }

            if (string.IsNullOrEmpty(value))
            {
                throw new ValidationMetadataException(Resources.ArgumentIsEmptyString);
            }
        }

        public override string ToString()
        {
            return string.Format("[{0}()]", this.GetType().Name);
        }
    }
}

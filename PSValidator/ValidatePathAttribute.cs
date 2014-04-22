namespace PSValidator
{
    using System;
    using System.Linq;
    using System.Management.Automation;
    using System.Management.Automation.Internal;

    using PSValidator.Properties;

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class ValidatePathAttribute :
        ValidateArgumentsAttribute
    {
        public ValidatePathAttribute()
        {
            this.PathType = PathType.Any;
            this.LiteralPath = false;
        }

        public PathType PathType { get; set; }

        public bool LiteralPath { get; set; }

        protected override void Validate(
            object arguments,
            EngineIntrinsics engineIntrinsics)
        {
            var enumerable = LanguagePrimitives.GetEnumerable(arguments);
            if (enumerable != null)
            {
                foreach (var argument in enumerable)
                {
                    this.ValidateInternal(argument, engineIntrinsics);
                }
            }
            else
            {
                this.ValidateInternal(arguments, engineIntrinsics);
            }
        }

        private void ValidateInternal(
            object argument,
            EngineIntrinsics engineIntrinsics)
        {
            if (argument == null || argument == AutomationNull.Value)
            {
                return;
            }

            string path = argument as string;
            if (path == null)
            {
                throw new ValidationMetadataException(Resources.ArgumentIsNotString);
            }

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            this.ValidatePath(path, engineIntrinsics);
        }

        private void ValidatePath(
            string path,
            EngineIntrinsics engineIntrinsics)
        {
            var uiCulture = engineIntrinsics.Host.CurrentUICulture;

            var itemIntrinsics = engineIntrinsics.InvokeProvider.Item;
            if (!itemIntrinsics.Exists(path, false, this.LiteralPath))
            {
                string message = string.Format(uiCulture, Resources.PathNotExists, path);
                throw new ValidationMetadataException(message);
            }

            if (this.PathType == PathType.Any)
            {
                return;
            }

            bool isContainer = itemIntrinsics.IsContainer(path);

            if (this.PathType == PathType.Container)
            {
                if (!isContainer)
                {
                    string message = string.Format(uiCulture, Resources.PathIsNotContainer, path);
                    throw new ValidationMetadataException(message);
                }
            }
            else if (this.PathType == PathType.Leaf)
            {
                if (isContainer)
                {
                    string message = string.Format(uiCulture, Resources.PathIsNotLeaf, path);
                    throw new ValidationMetadataException(message);
                }
            }
        }
    }
}

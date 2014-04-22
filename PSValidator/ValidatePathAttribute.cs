namespace PSValidator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Management.Automation;
    using System.Text;
    using System.Threading.Tasks;

    public class ValidatePathAttribute :
        ValidateArgumentsAttribute
    {
        private readonly string path;

        public ValidatePathAttribute(string path)
        {
            this.path = path;

            this.PathType = PathType.Any;
            this.LiteralPath = false;
        }

        public string Path
        {
            get
            {
                return this.path;
            }
        }

        public PathType PathType { get; set; }

        public bool LiteralPath { get; set; }

        protected override void Validate(
            object arguments,
            EngineIntrinsics engineIntrinsics)
        {
        }
    }
}

using System.Management.Automation;

namespace IntelliTect.Cmdlet.Starter
{
    [Cmdlet(VerbsCommon.Get, "Example")]
    public class GetExample : PSCmdlet
    {
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true,
            Position = 0,
            HelpMessage = "An example parameter.")]
        [Alias("Name", "Filter")]
        public string[] Path { get; set; }


        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            foreach (string path in Path)
            {
                WriteObject($"Path is: {path}");
            }

            base.ProcessRecord();
        }
    }
}
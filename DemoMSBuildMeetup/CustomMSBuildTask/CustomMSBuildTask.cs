using Task = Microsoft.Build.Utilities.Task;

namespace MyTasks
{
    public class CustomMSBuildTask : Task
    {
        public override bool Execute()
        {
            Log.LogError("Hello from Prague .Net Meetup!");

            return true;
        }
    }
}
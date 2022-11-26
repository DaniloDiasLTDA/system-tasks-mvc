using System.ComponentModel;

namespace SystemTasks.Enums
{
    public enum StatusTask
    {
        [Description("To do")]
        Doing = 1,
        [Description("In Progress")]
        Progress = 2,
        [Description("It's Finalized")]
        Finalized = 3


    }
}

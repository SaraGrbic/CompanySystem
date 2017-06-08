using System;

namespace Zesium.Project.CompanySystem.Models
{
    [Serializable]
    public enum ProjectState
    {
        New,
        InProgres,
        Finished,
        Canceled,
        Delay
    }
}

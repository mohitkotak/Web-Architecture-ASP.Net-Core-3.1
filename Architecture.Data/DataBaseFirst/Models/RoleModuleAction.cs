using System;
using System.Collections.Generic;

namespace Architecture.DataBase.DatabaseFirst.Models
{
    public partial class RoleModuleAction
    {
        public RoleModuleAction()
        {
            UserRoleModuleAction = new HashSet<UserRoleModuleAction>();
        }

        public long Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? UpdatedUtcdate { get; set; }
        public DateTime? CreatedUtcdate { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public long RoleId { get; set; }
        public long ModuleActionId { get; set; }

        public virtual ModuleAction ModuleAction { get; set; }
        public virtual ICollection<UserRoleModuleAction> UserRoleModuleAction { get; set; }
    }
}

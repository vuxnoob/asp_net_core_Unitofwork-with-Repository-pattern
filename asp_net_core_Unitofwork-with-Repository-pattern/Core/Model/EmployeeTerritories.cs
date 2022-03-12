using System.Collections.Generic;

namespace asp_net_core_Unitofwork_with_Repository_pattern.Core.Model
{
	public partial class EmployeeTerritories
	{
		public int EmployeeId { get; set; }
		public string TerritoryId { get; set; }

		public virtual Employees Employee { get; set; }
		public virtual Territories Territory { get; set; }
	}
}
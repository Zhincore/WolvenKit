using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_FootIK : animAnimEvent
	{
		[Ordinal(3)] [RED("leg")] public CEnum<animLeg> Leg { get; set; }

		public animAnimEvent_FootIK(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
using Verse;
using RimWorld;

namespace THICCWall {
	public class THICCWall_Blueprint_Build : Blueprint_Build {
		public override void Print(SectionLayer layer) {
			THICCWall_Utility.Print(def, this, layer);
		}
	}
}

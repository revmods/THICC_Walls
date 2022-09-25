using Verse;

namespace THICCWall {
	public class THICCWall_Building : Building {
		public override void Print(SectionLayer layer) {
			THICCWall_Utility.Print(def, this, layer);
		}
	}
}

using Verse;
using RimWorld;
using UnityEngine;

namespace THICCWall {
	public class THICCWall_Utility {
		public static void Print(ThingDef def, Thing thing, SectionLayer layer) {
			// linked texture does not "work", or more specifically does not look good
			// seems like the game only checks the neighbors of the bottom left cell so the neighbors to the top and right are always filled because this wall is 2x2
			// then even if you are able to check the correct neighbors, it still wouldnt look nice in cases where the walls are not exactly adjacent
			// to fix that you would have to check every cell surrounding the wall then probably set the uvs manually
			// TLDR; you need a whole new atlasing function
			/*
			Material material = graphic.MatSingleFor(thing);
			bool flipUv = (!graphic.ShouldDrawRotated) && ((thing.Rotation == Rot4.West && graphic.WestFlipped) || (thing.Rotation == Rot4.East && graphic.EastFlipped));
			Graphic.TryGetTextureAtlasReplacementInfo(material, def.category.ToAtlasGroup(), flipUv, true, out material, out var uvs, out var vertexColor);
			Printer_Plane.PrintPlane(
			layer, 
				GenThing.TrueCenter(thing.Position, thing.Rotation, new IntVec2(2, 2), (float)AltitudeLayer.Building), 
				new Vector2(def.size.x, def.size.z),
				material,
				0f,
				flipUv,
				uvs,
				new Color32[] { vertexColor, vertexColor, vertexColor, vertexColor }
			);
			//*/

			// instead of worrying about all that, just draw each wall piece as a single piece
			Material material = thing.Graphic.MatSingleFor(thing);
			Printer_Plane.PrintPlane(
			layer,
				GenThing.TrueCenter(thing.Position, thing.Rotation, new IntVec2(2, 2), (float)AltitudeLayer.Building),
				new Vector2(def.size.x, def.size.z),
				material
			);
		}
	}
}

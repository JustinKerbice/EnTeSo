using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace KerbiceSoftwareInc
{
	public class ModuleEnginesT : ModuleEngines
	{
		[KSPField (guiName = "Temperature", guiUnits = "°C", guiFormat = "F1", guiActive = true)]
		public float temperature;

		//[KSPField(isPersistant = false, guiActive = true, guiName = "Engine Heat")]
		//public string HeatRejectionGUI = "0 °C";

		//		public override string GetInfo()
		//		{
		//string text = base.GetInfo();		//maybe, not tested
		//
		//			text = text + String.Format("Heat: {0:F1} °C", base.part.temperature);
		//		}

		public override void OnUpdate ()
		{
			this.temperature = base.part.temperature;
		}
	}


	public class ModuleEnginesTFX : ModuleEnginesFX
	{
		[KSPField (guiName = "Temperature", guiUnits = "°C", guiFormat = "F1", guiActive = true)]
		public float temperature;

		public override void OnUpdate ()
		{
			this.temperature = base.part.temperature;
		}
	}
}
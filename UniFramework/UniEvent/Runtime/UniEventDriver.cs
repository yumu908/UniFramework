﻿using UnityEngine;

namespace UniFramework.Event
{
	internal class UniEventDriver : MonoBehaviour
	{
		void Update()
		{
			UniEvent.Update();
		}

		void OnDestroy()
		{
			UniEvent.Destroy();
		}
	}
}
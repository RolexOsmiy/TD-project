// NULLcode Studio © 2015
// null-code.ru

using UnityEngine;
using System.Collections;

public class MaskControl : MonoBehaviour {

	public Color on = Color.green;
	public Color off = Color.red;
	public string respawnTag = "Respawn";
	private MeshRenderer[] ren;

	void Start()
	{
		ren = GetComponentsInChildren<MeshRenderer>();
		foreach(MeshRenderer r in ren)
		{
			r.material.color = on;
		}

		DragAndDrop.isOn = true;
	}

	void OnTriggerStay(Collider coll)
	{
		if(coll.tag != respawnTag)
		{
			foreach(MeshRenderer r in ren)
			{
				r.material.color = off;
			}

			DragAndDrop.isOn = false;
		}
	}

	void OnTriggerExit(Collider coll)
	{
		if(coll.tag != respawnTag)
		{
			foreach(MeshRenderer r in ren)
			{
				r.material.color = on;
			}

			DragAndDrop.isOn = true;
		}
	}
}

// NULLcode Studio © 2015
// null-code.ru

using UnityEngine;
using System.Collections;

public class MeshRendererOff : MonoBehaviour {

	private MeshRenderer[] m;

	void Start () 
	{
		m = GetComponentsInChildren<MeshRenderer>();
		foreach(MeshRenderer r in m)
		{
			r.enabled = false;
		}
	}
}

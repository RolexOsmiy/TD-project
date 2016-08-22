using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CurrentNavigation : MonoBehaviour {

	public static bool isPointer;
	public static Vector3 target;
	public GameObject targetPointer;

	void Start () 
	{
		targetPointer.SetActive(false);
	}

	void Update () 
	{
		targetPointer.SetActive(isPointer);

		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit))
		{
			if(Input.GetMouseButtonDown(1))
			{
				if(hit.transform.tag == "GameController")
				{
					target = hit.point;
					targetPointer.transform.localRotation = Quaternion.FromToRotation(Vector3.forward, hit.normal);
					targetPointer.transform.position = hit.point;
				}
			}
		}
	}
}

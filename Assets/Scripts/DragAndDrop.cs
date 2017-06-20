using UnityEngine;
using System.Collections;
using System;

public class DragAndDrop : MonoBehaviour {

	public Transform[] original;
	public Transform[] mask;
	public float shift = 0.01f;
	public string respawnTag = "Respawn";

	public static bool isOn;
	private Transform original_tmp;
	private Transform mask_tmp;
	private Vector3 curPos;
    private int price;
    public int[] PriceList;

	void Start()
	{
		isOn = false;
	}

	public void SetMask(int id)
	{
        if (GlobalVars_Script.money >= price)
        {
            switch (id)
            {
                case 1:
                    price = PriceList[0];
                    break;
                case 2:
                    price = PriceList[1];
                    break;
                default:
                    break;
            }
            foreach (Transform obj in original)
            {
                string name = obj.name.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries)[0];
                if (id.ToString() == name)
                {
                    original_tmp = Instantiate(obj);
                    original_tmp.gameObject.SetActive(false);
                }
            }

            foreach (Transform obj in mask)
            {
                string name = obj.name.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries)[0];
                if (id.ToString() == name)
                {
                    mask_tmp = Instantiate(obj);
                }
            }
        }
	}

	void Update() 
	{
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit))
		{
			curPos = hit.point + hit.normal * shift;
		}

		if(mask_tmp)
		{
			mask_tmp.position = curPos;

			if(Input.GetAxis("Mouse ScrollWheel") > 0)
			{
				mask_tmp.localEulerAngles += new Vector3(0, 45, 0);
			}
			if(Input.GetAxis("Mouse ScrollWheel") < 0)
			{
				mask_tmp.localEulerAngles -= new Vector3(0, 45, 0);
			}

			if(Input.GetMouseButtonDown(0) && isOn)
			{
                GlobalVars_Script.money -= price;
				original_tmp.gameObject.SetActive(true);
				original_tmp.position = mask_tmp.position;
				original_tmp.localEulerAngles = mask_tmp.localEulerAngles;
				original_tmp = null;
				isOn = false;
				Destroy(mask_tmp.gameObject);
			}
			else if(Input.GetMouseButtonDown(1))
			{
				Destroy(original_tmp.gameObject);
				Destroy(mask_tmp.gameObject);
			}
		}
	}
}

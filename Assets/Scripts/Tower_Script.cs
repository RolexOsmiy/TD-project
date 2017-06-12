using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Tower_Script : MonoBehaviour
{
    public static GameObject Target = null;
    public GameObject Bullet;
    public float AttackSpeed;
    private float nextFire;
    public float maxHp = 100;
    public float currentHp = 100;
    public float damage = 35;
    public GameObject button1;
    public GameObject icon;
    public Sprite[] button_icons;
    public string[] button_texts;
    public Sprite[] icons;
    public int[] button_price;
    int towerLevel = 1;
    GameObject managers;

    private void Awake()
    {
        managers = GameObject.Find("managers").gameObject;
    }

    private void Update()
    {
        Shoot();
    }

    private void OnMouseDown()
    {
        managers.GetComponent<Select_script>().selectUnit = this.gameObject;
    }

    public void ShowUI()
    {
        button1.GetComponentInChildren<Text>().text = button_texts[0];
        button1.transform.GetChild(1).GetComponent<Text>().text = "" + button_price[0];
        button1.GetComponent<Image>().sprite = button_icons[0];
        icon.GetComponent<Image>().sprite = button_icons[0];
        button1.SetActive(true);
    }

    public void Upgrade()
    {
        if (towerLevel == 1)
        {

        }
    }

    public void Shoot()
    {
        if (Target != null && Time.time > nextFire)
        {
            nextFire = Time.time + AttackSpeed;
            GameObject Clone = Instantiate(Bullet, this.transform.position, this.transform.rotation);
            Clone.GetComponent<TowerPacket_Script>().Target(Target);
        }
    }
}
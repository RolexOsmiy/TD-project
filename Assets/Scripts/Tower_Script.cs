using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Tower_Script : MonoBehaviour
{
    public bool tower = true;
    public bool upgradet = false;
    public GameObject Target = null;
    public GameObject Bullet = null;
    
    float nextFire;
    public float AttackSpeed = 1;
    public float maxHp = 100;
    public float currentHp = 100;
    public float damage = 30;

    public float AttackSpeed_2 = 0.5f;
    public float maxHp_2 = 100;
    public float currentHp_2 = 100;
    public float damage_2 = 40;
    GameObject managers;
    public int UpgradePrice = 180;
    

    private void Awake()
    {
        Bullet.GetComponent<TowerPacket_Script>().damage = damage;
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

    public void Upgrade()
    {
        if (GlobalVars_Script.money >= UpgradePrice)
        {
            AttackSpeed = AttackSpeed_2;
            maxHp = maxHp_2;
            currentHp = currentHp_2;
            damage = damage_2;
            GlobalVars_Script.money -= UpgradePrice;
            upgradet = true;
        }
    }

    public void Shoot()
    {
        if (Target && Time.time > nextFire)
        {
            nextFire = Time.time + AttackSpeed;
            GameObject Clone = Instantiate(Bullet, this.transform.position, this.transform.rotation);
            Clone.GetComponent<TowerPacket_Script>().Target(Target);
        }
    }
}
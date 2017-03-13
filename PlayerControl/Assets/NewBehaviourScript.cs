using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {



    // Use this for initialization
    void Start()
    {
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")//被碰撞的是敌人
            Destroy(col.gameObject);//销毁敌人

        Destroy(this.gameObject);//销毁子弹
    }
}
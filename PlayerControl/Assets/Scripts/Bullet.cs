using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionStay(Collision col)
    {

        Debug.Log("PENGDAOWUTI");
        if (col.gameObject.tag == "Enemy")//被碰撞的是敌人
        {
            Destroy(col.gameObject);//销毁敌人
            Destroy(this.gameObject);//销毁子弹
        }
    }
    void OnControllerColliderHit(Collision col)
    {
        Debug.Log("111");
        if (col.gameObject.tag == "Enemy")//被碰撞的是敌人
        {
            Destroy(col.gameObject);//销毁敌人
            Destroy(this.gameObject);//销毁子弹
        }
    }
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("2222");
    }
}

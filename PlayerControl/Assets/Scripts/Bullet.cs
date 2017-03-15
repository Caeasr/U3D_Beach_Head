using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    private GameControl gameControl;
	// Use this for initialization
	void Start () {
        gameControl = GameObject.Find("GameControl").GetComponent<GameControl>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")//被碰撞的是敌人
        {
            Destroy(col.gameObject);//销毁敌人
            gameControl.Score += 1;
        }
        Destroy(this.gameObject);//销毁子弹
    }
}

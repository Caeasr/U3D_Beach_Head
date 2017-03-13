using UnityEngine;
using System.Collections;

public class PlayerCotrol : MonoBehaviour {
    public float angleSpeed = 30;
    public GameObject bullet;
    public Transform bulletSpawn;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");//获取INPUT里面的值在INPUT里面设置
        float v = Input.GetAxis("Vertical");

        
        this.transform.eulerAngles += new Vector3(-v, h, 0) * angleSpeed * Time.deltaTime;
        //transform.Rotate(new Vector3(v,h,0) *angleSpeed* Time.deltaTime);
        //transform.rotation = Quaternion.Euler(this.transform.eulerAngles + new Vector3(v, h, 0) * angleSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
            Fire();
    }
    void Fire()
    {
        GameObject bulletIns = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation) as GameObject;//实例化子弹
        bulletIns.GetComponent<Rigidbody>().velocity = bulletIns.transform.up * 40;//给子弹一个向前的速度
        Destroy(bulletIns, 15); //创建3秒之后自动销毁，节省系统内存
    }
}

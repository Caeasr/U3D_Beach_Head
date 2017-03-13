using UnityEngine;
using System.Collections;

public class PlayerContral : MonoBehaviour {

    public float Speed = 10;
    public float TranslateSpeed = 20;
    private float x = 0;//X轴的标志位-1表示向X轴负方向移动
    private float y = 0;//Y轴的标志位
                       // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
            x = -1;
        else if (Input.GetKey(KeyCode.D))
            x = 1;
        else
            x = 0;
        if (Input.GetKey(KeyCode.W))
            y = 1;
        else if (Input.GetKey(KeyCode.S))
            y = -1;
        else
            y = 0;

        ////////////////////////////////通过transform移动///////////////////////////////////////////
        //this.transform.Translate(new Vector3(x, y, 0) * Speed * Time.deltaTime);//移动，对着人物前方移动,随着人物的XYZ轴移动；系统提供的方法
        //this.transform.position += new Vector3(x, y, 0) * Speed * Time.deltaTime;//直接修改世界坐标，随着世界的XYZ轴移动
        //this.transform.Rotate(new Vector3(x, y, 0) * TranslateSpeed * Time.deltaTime);//旋转;系统提供的方法在原来的基础上向XYZ轴旋转
        //transform.rotation = Quaternion.Euler(this.transform.eulerAngles+new Vector3(x, y, 0) * TranslateSpeed * Time.deltaTime);//this.transform.eulerAngles获取当前物体的欧拉角，Quaternion是四元素，四元素表示物体的方位，两个是可以互相转换的，计算机计算用四元素更加高效，本质都是矩阵运算，四元素转矩阵方便。
        //this.transform.eulerAngles += new Vector3(x, y, 0) * TranslateSpeed * Time.deltaTime;
        //常用的是transform.Translate和transform.Rotate。用不用THIS都可以transform是MONOBEHAVE脚本的一个属性
        ///////////////////////////////////通过rigidbody控制运动///////////////////////////////////////////////////
        //必须添加rigidbody组件
        //GetComponent<Rigidbody>().velocity=new Vector3(x, y, 0) * TranslateSpeed * Time.deltaTime;//移动
        //GetComponent<Rigidbody>().angularVelocity = new Vector3(x, y, 0) * TranslateSpeed * Time.deltaTime;//旋转
    }
}

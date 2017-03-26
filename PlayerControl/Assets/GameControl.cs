using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControl : MonoBehaviour {
    public GameObject enemy;//敌人的预制体
    public Transform enemyManage;//实例化后的敌人的父节点
    float time = 0;
    public float timer = 30;//每隔多久产生一个敌人
    private Button button;
    private Image image;
    //////////////////人物状态/////////////////
    int score = 0;
    public Text scoreText;
    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
            scoreText.text = "得分：" + value.ToString();

            button.transition = Selectable.Transition.ColorTint;

        }
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (time > timer)
        {
            EnemyCreat();
            time = 0;
        }
        time += Time.deltaTime;//Time.dealTime是每帧直接的时间间隔
    }
    void EnemyCreat()
    {   
        Vector2 dir = Random.insideUnitCircle;
        dir=dir.normalized* Random.Range(70f, 100f);
        GameObject go = Instantiate(enemy, new Vector3(dir.x,1,dir.y), Quaternion.identity) as GameObject;//实例化敌人
        go.transform.SetParent(enemyManage);//设置父节点
    }
}

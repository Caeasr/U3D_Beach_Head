using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public float speed = 5;
    private Transform player;
    private Vector3 direction;
	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        direction = player.position - transform.position;
        direction = direction.normalized;
        transform.position += direction * speed;
    }
}

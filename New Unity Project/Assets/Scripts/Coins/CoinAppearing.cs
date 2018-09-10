using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAppearing : MonoBehaviour {
   // [SerializeField] Rigidbody2D Player;
   // [SerializeField] Rigidbody2D Coins;
    // Use this for initialization
    void Start () {
    //    Player = GetComponent<Rigidbody2D>();
    //    Coins = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject);
        }
    }

}

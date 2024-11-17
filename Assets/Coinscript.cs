using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 7);
    }


    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D whatDidIHit)
    {
        if (whatDidIHit.tag == "Player")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().EarnScore(1);
            Destroy(this.gameObject);
        }
    }

}

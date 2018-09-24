using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseFat : MonoBehaviour {

    private Renderer rend;
    float fatness = 0;
    [SerializeField] GameObject body;

    void OnTriggerEnter(Collider coll)
    {
        if(coll.tag == "food")
        {
            fatness += 10;
            body.GetComponent<Renderer>().material.SetFloat("_Amount", fatness);
            Destroy(coll.gameObject);
        }

        if (coll.tag == "SpecialFood")
        {
            fatness += 100;
            transform.localScale = new Vector3(3, 3, 3);
            body.GetComponent<Renderer>().material.SetFloat("_Amount", fatness);
            Destroy(coll.gameObject);
        }

        if (coll.tag == "void")
        {
            transform.position = new Vector3(0, 10, 0);
        }
    }
}

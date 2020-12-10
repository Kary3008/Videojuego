using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {
    public float fuerzaSalto;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space))
            {
          //  anim.SetBool("estaSaltando", true);
            rb.AddForce(new Vector2(0, fuerzaSalto));
        }
    }
}

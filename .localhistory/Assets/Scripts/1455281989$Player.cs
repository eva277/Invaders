using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    [SerializeField]
    private float speed = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 velocity = Vector3.right * speed * Input.GetAxisRaw("Horizontal")*Time.deltaTime;
        transform.Translate(velocity);
        float x = Mathf.Clamp(transform.position.x, -4.48f, 4.48f);
        transform.position = new Vector3(x, transform.position.y, 0);


    }
}

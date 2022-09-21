using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 11f;

    private float movementX;

    [SerializeField]
    private Rigidbody2D myBody;

    private SpriteRenderer sr;

    private Animator anim;
    private string WALK_ANIMATION = "Walk";
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

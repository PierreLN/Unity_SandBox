using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SimpleSaut : MonoBehaviour
{
    private Rigidbody2D rig;
    public float impulsionSaut = 5.0f;
    public float forceAvance = 5.0f;
    private float horizontal;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rig.AddForce(Vector2.up * impulsionSaut,ForceMode2D.Impulse);
            EventManager.TriggerEvent("Ecoute", Color.red);
        }
        horizontal = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {
        rig.AddForce(Vector2.right * forceAvance * horizontal, ForceMode2D.Force);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Acteur"))
        {
            //SceneManager.LoadScene("Evenement");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRaycast : MonoBehaviour
{
    public Transform cible;
    private SpriteRenderer rendu;
    public float maxDistance = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        rendu = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rayon = cible.position - transform.position;
        rayon.Normalize();
        Debug.DrawRay(transform.position, rayon * maxDistance);
    }
}

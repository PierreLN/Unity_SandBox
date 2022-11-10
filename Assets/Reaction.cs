using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Reaction : MonoBehaviour
{
    private UnityAction<object> lesSauts;
    private SpriteRenderer rendu;

    // Start is called before the first frame update
    void Start()
    {
        rendu = GetComponent<SpriteRenderer>();
    }

    private void Awake()
    {
        lesSauts = new UnityAction<object>(lorsDeLaReaction);
    }

    private void OnEnable()
    {
        EventManager.StartListening("Ecoute", lesSauts);
    }

    private void OnDisable()
    {
        EventManager.StopListening("Ecoute", lesSauts);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void lorsDeLaReaction(object data)
    {
        Debug.Log("yo");
        Color col = (Color)data;

        rendu.color = col;
    }
}

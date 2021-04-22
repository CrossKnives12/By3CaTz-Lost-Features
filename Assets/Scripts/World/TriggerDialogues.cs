using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class TriggerDialogues : MonoBehaviour
{
    public GameObject theDialogueController;
    private DialogueController dc;

    // Start is called before the first frame update
    void Start()
    {
        dc = theDialogueController.GetComponent<DialogueController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D diaScened)
    {
        if (diaScened.CompareTag("Player"))
        {
            dc.diaCount += 1;
            dc.isDialogueScene = true;

            this.gameObject.SetActive(false);
        }
    }
}

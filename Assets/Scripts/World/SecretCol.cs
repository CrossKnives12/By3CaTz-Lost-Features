using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SecretCol : MonoBehaviour
{
    public GameObject theSecretController;
    private SecretController sc;

    // Start is called before the first frame update
    void Start()
    {
        sc = theSecretController.GetComponent<SecretController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D secret)
    {
        if (secret.CompareTag("Player"))
        {
            sc.ctr += 1;
            sc.isDialogue = true;

            this.gameObject.SetActive(false);
        }
    }
}

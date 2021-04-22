using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ItemCol : MonoBehaviour
{
    public GameObject theItemController;
    private ItemController ic;

    // Start is called before the first frame update
    void Start()
    {
        ic = theItemController.GetComponent<ItemController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D item)
    {
        if (item.CompareTag("Player"))
        {
            ic.itemCount += 1;
            ic.isDialogueAbilities = true;

            this.gameObject.SetActive(false);
        }
    }
}

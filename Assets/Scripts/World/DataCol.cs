using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class DataCol : MonoBehaviour
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

    private void OnTriggerEnter2D(Collider2D data)
    {
        if (data.CompareTag("Player"))
        {
            ic.dataCount += 1;
            ic.isDialogueData = true;

            this.gameObject.SetActive(false);
        }
    }
}

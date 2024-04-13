using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ResourceUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI resourceText;
    [SerializeField] private ResourceSource resource;

    public void OnQuantityChange()
    {
        resourceText.text = resource.Quantity.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

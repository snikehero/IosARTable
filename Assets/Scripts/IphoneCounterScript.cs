using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class IphoneCounterScript : MonoBehaviour
{
    public TMP_Text counterText;
    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreaseIphoneDestroyed() 
    {
        counter++;
        counterText.SetText(counter.ToString());
    }
}

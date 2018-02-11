using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GrayTestScript : MonoBehaviour {

    public Text valueDisplay;
    public Material greyscaleMat;
    float saturationAmount = 0.2f;
	// Use this for initialization
	public void DecreaseGrey () 
    {
        if (saturationAmount > -1.2f) {
            saturationAmount -= 0.2f;
            greyscaleMat.SetFloat("_EffectAmount", saturationAmount);
        }
        
	}
	
	// Update is called once per frame
    public void IncreaseGrey()
    {
        if (saturationAmount < 1.4f) {
            saturationAmount += 0.2f;
            greyscaleMat.SetFloat("_EffectAmount", saturationAmount);
        }
        
	}

    void Update()
    {
        valueDisplay.text = saturationAmount.ToString();
    }
}
